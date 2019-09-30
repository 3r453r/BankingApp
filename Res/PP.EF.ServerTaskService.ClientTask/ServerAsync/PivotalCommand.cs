using PP.EF.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PP.EF.ServerTaskService.ClientTask.ServerAsync
{
    public class PivotalCommand
    {
        private const string xmlDeclaration = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
        private const string loginTypeName = "Client";
        private XNamespace xmlNamespace = XNamespace.Get("urn:schemas-pivotal-com/LifecycleServer60");

        public PivotalCommand()
        {
        }

        public static PivotalCommand CreateExecuteServerTaskCommand(
            string pivotalSystemName, string serverTaskName, string serverTaskMethodName)
        {
            PivotalCommand cmd = new PivotalCommand();
            cmd.PivotalSystemName = pivotalSystemName;
            cmd.ServerTaskName = serverTaskName;
            cmd.ServerTaskMethodName = serverTaskMethodName;
            cmd.Parameters = new object[0];
            return cmd;
        }

        public string PivotalSystemName { get; set; }

        public string ServerTaskName { get; set; }

        public string ServerTaskMethodName { get; set; }

        public object[] Parameters { get; set; }

        public override string ToString()
        {
            var doc = new XDocument();
            AddCommand(doc);
            return xmlDeclaration + doc.ToString(SaveOptions.DisableFormatting);
        }

        private void AddCommand(XDocument document)
        {
            var command = new XElement(xmlNamespace + "command");
            AddCommandHeader(command);
            AddExecuteServerTaskCommand(command);
            document.Add(command);
        }

        private void AddCommandHeader(XElement command)
        {
            command.Add(
                new XElement(xmlNamespace + "systemName", PivotalSystemName),
                new XElement(xmlNamespace + "loginType", loginTypeName));
        }

        private void AddExecuteServerTaskCommand(XElement command)
        {
            var serverTaskExecutionProperties = new XElement(xmlNamespace + "executeAppServerRule",
                    new XElement(xmlNamespace + "appServerRuleName", ServerTaskName),
                    new XElement(xmlNamespace + "appServerRuleMethod", ServerTaskMethodName));
            if (Parameters.Length > 0)
            {
                AddParameters(serverTaskExecutionProperties);
            }
            command.Add(serverTaskExecutionProperties);
        }

        private void AddParameters(XElement command)
        {
            var commandParameters = new XElement(xmlNamespace + "commandParameters");

            foreach (object parameter in Parameters)
            {
                AddParameter(commandParameters, parameter);
            }

            command.Add(commandParameters);
        }

        private void AddParameter(XElement commandParameters, object parameterValue)
        {
            XElement parameter;

            if (parameterValue == null)
            {
                parameter = new XElement(xmlNamespace + "emptyParameter");
            }
            else if (parameterValue.GetType() == typeof(string))
            {
                parameter = new XElement(xmlNamespace + "stringParameter", (string)parameterValue);
            }
            else if (parameterValue.GetType() == typeof(float))
            {
                parameter = new XElement(xmlNamespace + "floatParameter", (float)parameterValue);
            }
            else if (parameterValue.GetType() == typeof(double))
            {
                parameter = new XElement(xmlNamespace + "floatParameter", (double)parameterValue);
            }
            else if (parameterValue.GetType() == typeof(int))
            {
                parameter = new XElement(xmlNamespace + "integerParameter", (int)parameterValue);
            }
            else if (parameterValue.GetType() == typeof(bool))
            {
                parameter = new XElement(xmlNamespace + "booleanParameter", ((bool)parameterValue) ? 1 : 0);
            }
            else if (parameterValue.GetType() == typeof(byte[]))
            {
                byte[] bytes = (byte[])parameterValue;
                parameter = new XElement(xmlNamespace + "binaryParameter", bytes.ToHexBinary());
            }
            else if (parameterValue.GetType() == typeof(DateTime))
            {
                var dateValue = (DateTime)parameterValue;
                parameter = new XElement(xmlNamespace + "dateParameter", dateValue.ToString("yyyy-MM-ddTHH:mm:ss.fff"));
            }
            else
            {
                throw new ParameterTypeNotSupportedException(parameterValue.GetType());
            }

            commandParameters.Add(parameter);
        }

        public class ParameterTypeNotSupportedException : ApplicationException
        {
            public ParameterTypeNotSupportedException(Type notSupportedType)
                : base("Type " + notSupportedType.FullName + " is not supported.")
            {
            }
        }
    }
}
