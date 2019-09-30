using CdcSoftware.Pivotal.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.EF.Data.AppDto.Request
{
    public class TakeWorkflowStep : BaseDtoRequest
    {
        public DateTime EditDate { get; set; }
        public Id WorkflowStepId { get; set; }
    }
}
