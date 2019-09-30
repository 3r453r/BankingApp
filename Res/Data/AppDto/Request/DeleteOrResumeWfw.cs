using CdcSoftware.Pivotal.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.EF.Data.AppDto.Request
{
    public class DeleteOrResumeWfw : BaseDtoRequest
    {
        public Id WorkflowTemplateConfId { get; set; }
        public Id CaseProcessId { get; set; }
        public string ProcessTable { get; set; }
        public WfwOperation WfwOperation { get; set; }
        public CreateCaseOperation CaseProcessOperation { get; set; }
        public Id SourceWflowId { get; set; }
    }

    public enum WfwOperation
    {
        Delete,
        Resume
    }
}
