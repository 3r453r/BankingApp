using CdcSoftware.Pivotal.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP.EF.Data.AppDto.Request
{
    public class CheckCompanyBTRequest : BaseDtoRequest
    {
        public Id CompanyId { get; set; }

        public bool IsCompany { get; set; }
    }
}
