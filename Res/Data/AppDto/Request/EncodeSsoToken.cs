using CdcSoftware.Pivotal.Engine;
using PP.EF.Data.Nwk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.EF.Data.AppDto.Request
{
    public class EncodeSsoToken : BaseDtoRequest
    {
        public SsoToken Token { get; set; }
        public string CertificateAlias { get; set; }
        public Id OfertaId { get; set; }
        public string CreditUid { get; set; }   
    }
}
