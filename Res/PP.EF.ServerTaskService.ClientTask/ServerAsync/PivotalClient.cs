using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PP.EF.ServerTaskService.ClientTask.ServerAsync
{
    public class PivotalClient
    {
        private Uri pivotalXmlServicesUri;
        private string pivotalSystemName;
        private int timeoutms = 0;

        public WebRequest WebRequest { get; set; }
        public WebResponse WebResponse { get; set; }
        public PivotalCommand Command { get; set; }
        public HttpClient HttpClient { get; } = new HttpClient(new HttpClientHandler { UseDefaultCredentials = true});

        public PivotalClient()
        {
        }

        public PivotalClient(string pivotalXmlServicesUriString, string pivotalSystemName) //jeśli timeoutms == 0 => timeout standardowy (100 sek)
        {
            pivotalXmlServicesUri = new Uri(pivotalXmlServicesUriString);
            this.pivotalSystemName = pivotalSystemName;
        }

        public PivotalClient(string pivotalXmlServicesUriString, string pivotalSystemName, int timeoutms) //jeśli timeoutms == 0 => timeout standardowy (100 sek)
        {
            pivotalXmlServicesUri = new Uri(pivotalXmlServicesUriString);
            this.pivotalSystemName = pivotalSystemName;
            this.timeoutms = timeoutms;
        }

        public virtual Task<object[]> Execute(string serverTaskName, string serverTaskMethodName, params object[] parameters)
        {
            PivotalCommand command = CreatePivotalCommand(serverTaskName, serverTaskMethodName, parameters);
            return Execute(command);
        }

        private PivotalCommand CreatePivotalCommand(string serverTaskName, string serverTaskMethodName, object[] parameters)
        {
            PivotalCommand command = PivotalCommand.CreateExecuteServerTaskCommand(
                pivotalSystemName, serverTaskName, serverTaskMethodName);
            command.Parameters = parameters;

            return command;
        }

        public async Task<object[]> Execute(PivotalCommand command)
        {
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
            if(timeoutms > 0)
                HttpClient.Timeout = TimeSpan.FromMilliseconds(timeoutms);

            var response = await HttpClient.PostAsync(pivotalXmlServicesUri, new StreamContent(new MemoryStream(Encoding.UTF8.GetBytes(command.ToString()))));
            response.EnsureSuccessStatusCode();
            
            return ParseResponse(await response.Content.ReadAsStringAsync());
        }

        public object[] ParseResponse(string response)
        {
            XDocument doc = XDocument.Parse(response);

            ThrowExceptionIfPivotalReturnedError(doc);

            return doc.Descendants()
                .Where(d => d.Name.LocalName == "returnParameters").Descendants()
                .Select(s => ParseResponseParameter(s.Value, s.Name.LocalName))
                .ToArray<object>();
        }

        private void ThrowExceptionIfPivotalReturnedError(XDocument document)
        {
            bool errorReturned = document.Descendants().Where(d => d.Name.LocalName == "error").Any();

            if (errorReturned)
            {
                throw new PivotalErrorException(document.ToString());
            }
        }

        public class PivotalErrorException : ApplicationException
        {
            public PivotalErrorException(string message)
                : base(message)
            {
            }
        }

        private object ParseResponseParameter(string value, string parameterTypeName)
        {
            object result = null;
            switch (parameterTypeName)
            {
                case "stringParameter":
                    result = value;
                    break;
                case "booleanParameter":
                    result = bool.Parse(value);
                    break;
                case "integerParameter":
                    result = int.Parse(value);
                    break;
                case "binaryParameter":
                    result = SoapHexBinary.Parse(value).Value;
                    break;
            }

            if (result == null)
            {
                throw new ParameterTypeNotSupportedException(parameterTypeName);
            }
            return result;
        }

        public class ParameterTypeNotSupportedException : ApplicationException
        {
            public ParameterTypeNotSupportedException(string notSupportedTypeName)
                : base("Type " + notSupportedTypeName + " is not supported.")
            {
            }
        }
    }
}
