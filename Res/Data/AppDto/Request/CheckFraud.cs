using CdcSoftware.Pivotal.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP.EF.Data.AppDto.Request
{
    public class CheckFraud : BaseDtoRequest
    {
        public Id wflowStepId { get; set; }

        public Id ACaseProcessId { get; set; }
    }
}
