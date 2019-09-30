using CdcSoftware.Pivotal.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP.EF.Data.AppDto.Request
{
    public class CreateAndGrantStatement : BaseDtoRequest
    {
        public string customerID { get; set; }
        public string customerContextID { get; set; }
        public string correlationID { get; set; }
        public string customerLogin { get; set; }
        public string partnerID  { get; set; }
        public string productNumber { get; set; }
        public DateTime statementTimeLimit { get; set; }
        public Id companyId { get; set; }
    }
}
