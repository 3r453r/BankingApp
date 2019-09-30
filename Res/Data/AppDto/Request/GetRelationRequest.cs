using CdcSoftware.Pivotal.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP.EF.Data.AppDto.Request
{
    public class GetRelationRequest : BaseDtoRequest
    {
        public List<EF.Data.Relation> Relations { get; set; }

        public bool IsCompany { get; set; }

        public Id CompanyId { get; set; }

        public string Nazwa { get; set; }

        public int CIF { get; set; }
    }
}
