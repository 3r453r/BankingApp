using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP.EF.Data.AppDto.Response
{
    public class GetAuthorizationMethodsResponse : BaseDtoResponse
    {
        public List<KeyValuePair<string, bool>> AuthorizationMethods { get; set; }
    }
}
