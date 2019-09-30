using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP.EF.Data.AppDto.Response
{
    public class CheckFraudResponse : BaseDtoResponse
    {
        public bool fraud { get; set; }
    }
}
