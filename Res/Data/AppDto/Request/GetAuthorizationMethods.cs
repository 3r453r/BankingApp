using CdcSoftware.Pivotal.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP.EF.Data.AppDto.Request
{
    public class GetAuthorizationMethods : BaseDtoRequest
    {
        public Id CaseProcessId { get; set; }

        public Id DyspozycjaTransakcyjnaId { get; set; }

        public Id CompanyId { get; set; }
    }
}
