using CdcSoftware.Pivotal.Engine.ServerProxy;
using CdcSoftware.Pivotal.Engine.Types.ServerTasks;
using PP.EF.Data.AppDto;
using PP.EF.Data.AppDto.Request;
using PP.EF.Data.AppDto.Response;
using PP.EF.ServerTaskService.ClientTask.ServerAsync;
using System;
using System.Threading.Tasks;

namespace PP.EF.ServerTaskService.Interface.Client
{
    public class ServerTaskService
    {
        private SystemClient systemClient;
        private string pivotalXmlServicesUriString;
        private string pivotalSystemName;
        private int timeoutms;
        public ServerTaskService(SystemClient systemClient)
        {
            this.systemClient = systemClient;
        }

        public ServerTaskService(SystemClient systemClient, string pivotalXmlServicesUriString, string pivotalSystemName)
        {
            this.systemClient = systemClient;
            this.pivotalXmlServicesUriString = pivotalXmlServicesUriString;
            this.pivotalSystemName = pivotalSystemName;
        }

        public ServerTaskService(SystemClient systemClient, string pivotalXmlServicesUriString, string pivotalSystemName, int timeoutms)
        {
            this.systemClient = systemClient;
            this.pivotalXmlServicesUriString = pivotalXmlServicesUriString;
            this.pivotalSystemName = pivotalSystemName;
            this.timeoutms = timeoutms;
        }

        public T ExecuteServerTask<T>(string serverTaskName, string methodName, BaseDtoRequest request) where T : BaseDtoResponse
        {
            var parameterList = new ParameterList();
            parameterList.Add(serverTaskName);
            parameterList.Add(methodName);

            request.Id = DateTime.Now.Ticks.ToString() + systemClient.UserProfile.UserId.ToString();
            var requestSerialized = request.Serialize();
            parameterList.Add(requestSerialized.Data);
            parameterList.Add(requestSerialized.TypeName);

            systemClient.ExecuteServerTask("A_GL_ServerTaskService", "ExecuteServerTask", parameterList);
            return new BaseDtoSerialized {
                Data = parameterList[0].ToString(),
                TypeName = parameterList[1].ToString()
            }.Deserialize() as T;
        }

        /// <summary>
        /// Wywołanie asynchroniczne niemożliwe na ServerTaskService(SystemClient systemClient)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serverTaskName"></param>
        /// <param name="methodName"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<T> ExecuteServerTaskAsync<T>(string serverTaskName, string methodName, BaseDtoRequest request) where T : BaseDtoResponse
        {
            if (string.IsNullOrEmpty(pivotalXmlServicesUriString) || string.IsNullOrEmpty(pivotalSystemName))
                throw new ArgumentNullException("pivotalXmlServicesUriString or pivotalSystemName is not given");

            request.Id = DateTime.Now.Ticks.ToString() + systemClient.UserProfile.UserId.ToString();
            var requestSerialized = request.Serialize();
            var param = new object[4];
            param[0] = serverTaskName;
            param[1] = methodName;
            param[2] = requestSerialized.Data;
            param[3] = requestSerialized.TypeName;

            param = await new PivotalClient(pivotalXmlServicesUriString, pivotalSystemName, timeoutms).Execute("A_GL_ServerTaskService", "ExecuteServerTask", param);

            return new BaseDtoSerialized
            {
                Data = param[0].ToString(),
                TypeName = param[1].ToString()
            }.Deserialize() as T;
        }

        public BaseDtoResponse ExecuteServerTask(string serverTaskName, string methodName, BaseDtoRequest request)
        {
            var parameterList = new ParameterList();
            parameterList.Add(serverTaskName);
            parameterList.Add(methodName);

            request.Id = DateTime.Now.Ticks.ToString() + systemClient.UserProfile.UserId.ToString();
            var requestSerialized = request.Serialize();
            parameterList.Add(requestSerialized.Data);
            parameterList.Add(requestSerialized.TypeName);

            systemClient.ExecuteServerTask("A_GL_ServerTaskService", "ExecuteServerTask", parameterList);
            return new BaseDtoSerialized
            {
                Data = parameterList[0].ToString(),
                TypeName = parameterList[1].ToString()
            }.Deserialize() as BaseDtoResponse;
        }
        /// <summary>
        /// Wywołanie asynchroniczne niemożliwe na ServerTaskService(SystemClient systemClient)
        /// </summary>
        /// <param name="serverTaskName"></param>
        /// <param name="methodName"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseDtoResponse> ExecuteServerTaskAsync(string serverTaskName, string methodName, BaseDtoRequest request)
        {
            request.Id = DateTime.Now.Ticks.ToString() + systemClient.UserProfile.UserId.ToString();
            var requestSerialized = request.Serialize();
            var param = new object[4];
            param[0] = serverTaskName;
            param[1] = methodName;
            param[2] = requestSerialized.Data;
            param[3] = requestSerialized.TypeName;

            param = await new PivotalClient(pivotalXmlServicesUriString, pivotalSystemName, timeoutms).Execute("A_GL_ServerTaskService", "ExecuteServerTask", param);

            return new BaseDtoSerialized
            {
                Data = param[0].ToString(),
                TypeName = param[1].ToString()
            }.Deserialize() as BaseDtoResponse;
        }
    }
}
