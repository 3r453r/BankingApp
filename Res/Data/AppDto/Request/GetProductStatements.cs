using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP.EF.Data.AppDto.Request
{
    public class GetProductStatements : BaseDtoRequest
    {
        public string customerID { get; set; }
        public string customerContextID { get; set; }
        public string correlationID { get; set; }
        public string customerLogin { get; set; }
        public string contextType { get; set; }
    }
}
