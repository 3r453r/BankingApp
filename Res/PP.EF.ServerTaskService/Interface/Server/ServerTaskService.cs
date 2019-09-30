using CdcSoftware.Pivotal.Engine.Server;
using CdcSoftware.Pivotal.Engine.Types.ServerTasks;
using PP.EF.Data.AppDto.Request;
using PP.EF.Data.AppDto.Response;
using System;

namespace PP.EF.ServerTaskService.Interface.Server
{
    public class ServerTaskService
    {
        private SystemServer systemServer;
        public ServerTaskService(SystemServer systemServer)
        {
            this.systemServer = systemServer;
        }

        public T ExecuteServerTask<T>(string serverTaskName, string methodName, BaseDtoRequest request, bool newTransaction = false) where T : BaseDtoResponse
        {
            var parameterList = new ParameterList();
            parameterList.Add(serverTaskName);
            parameterList.Add(methodName);
            var requestSerialized = request.Serialize();
            parameterList.Add(requestSerialized.Data);
            parameterList.Add(requestSerialized.TypeName);

            return (T)systemServer.ExecuteServerTask(serverTaskName, methodName
                , new Type[] { request.GetType() }, new object[] { request }, newTransaction);
        }

        public BaseDtoResponse ExecuteServerTask(string serverTaskName, string methodName, BaseDtoRequest request, bool newTransaction = false)
        {
            var parameterList = new ParameterList();
            parameterList.Add(serverTaskName);
            parameterList.Add(methodName);
            var requestSerialized = request.Serialize();
            parameterList.Add(requestSerialized.Data);
            parameterList.Add(requestSerialized.TypeName);

            return (BaseDtoResponse)systemServer.ExecuteServerTask(serverTaskName, methodName
                , new Type[] { request.GetType() }, new object[] { request }, newTransaction);
        }
    }
}
