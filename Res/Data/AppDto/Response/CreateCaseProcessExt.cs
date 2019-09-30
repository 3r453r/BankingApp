using CdcSoftware.Pivotal.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.EF.Data.AppDto.Response
{
    public class CreateCaseProcessExt : BaseDtoResponse
    {
        public Id CaseProcessId { get; set; }
        public string ProcessTable { get; set; }
        public FormInfo FormInfo { get; set; }
        public Id wFlowTemplateConfId {get; set;}
    }

    public class FormInfo
    {
        public string FormName { get; set; }
        public Id RecordId { get; set; }
    }
}
