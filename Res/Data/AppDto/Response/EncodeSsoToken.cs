using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.EF.Data.AppDto.Response
{
    public class EncodeSsoToken : BaseDtoResponse
    {
        public string Url { get; set; }
        public string Token { get; set; }
    }
}
