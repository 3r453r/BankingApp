using CdcSoftware.Pivotal.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP.EF.Data.AppDto.Request
{
    public class IncreaseCallRequest : BaseDtoRequest
    {
        public Id CallId { get; set; }

        public Id EmployeeId { get; set; }

        public Id CaseProcessId { get; set; }

        public string ProcessTable { get; set; }
    }
}
