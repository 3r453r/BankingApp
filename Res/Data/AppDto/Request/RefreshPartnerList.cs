using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP.EF.Data.AppDto.Request
{
    public class RefreshPartnerList : BaseDtoRequest
    {
        public DateTime? ModifiedAfter { get; set; }
        public string UserId { get; set; }
        public Dictionary<string, string> attributes { get; set; }
    }
}
