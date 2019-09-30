using CdcSoftware.Pivotal.Applications.Core.Common;
using CdcSoftware.Pivotal.Engine.Types.ServerTasks;
using PP.EF.Data.AppDto;
using PP.EF.Data.AppDto.Response;
using PP.EF.Server.ServiceTasks;
using System;

namespace PP.EF.ServerTaskService.ServiceTask
{
    public class ServiceTaskService : ExtendedServiceTask
    {
        private DiagnosticLog Log = new DiagnosticLog();
        [TaskExecute]
        public void ExecuteServerTask(ParameterList parameterList)
        {
            var startDate = DateTime.Now;
            var serializedRequest = new BaseDtoSerialized {
                Data = TypeConvert.ToString(parameterList[2]),
                TypeName = TypeConvert.ToString(parameterList[3])
            };
            var request = serializedRequest.Deserialize();
            var baseDto = request as BaseDto;
            string methodName = TypeConvert.ToString(parameterList[1]);
            Log.WriteLog(SystemServer, LogLevel.INFO, $"ExecuteServerTask.{methodName}.Request", $"Id[{baseDto.Id}] Data[{(baseDto.MockLog ? baseDto.SerializeForLogging().Data : serializedRequest.Data)}]");

            var response = (SystemServer.ExecuteServerTask(TypeConvert.ToString(parameterList[0]), methodName
                , new Type[] { serializedRequest.GetDtoType() }, new object[] { request }, false) as BaseDtoResponse);
            response.Id = baseDto.Id;

            var serializedResponse = response.Serialize();
            Log.WriteLog(SystemServer, LogLevel.INFO, $"ExecuteServerTask.{methodName}.Response"
                , $"Id[{response.Id}] Time[{(DateTime.Now - startDate).ToString()}] Data[{(response.MockLog ? response.SerializeForLogging().Data : serializedResponse.Data)}]");

            parameterList.Clear();
            parameterList.Add(serializedResponse.Data);
            parameterList.Add(serializedResponse.TypeName);
        }
    }
}
