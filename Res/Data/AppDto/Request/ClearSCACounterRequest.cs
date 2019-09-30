using CdcSoftware.Pivotal.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP.EF.Data.AppDto.Request
{
    public class ClearSCACounterRequest : BaseDtoRequest
    {
        public Id wflowId { get; set; }

        public Id caseProcessId { get; set; }

        public Id dyspozycjaTransakcyjnaId { get; set; }
    }
}
