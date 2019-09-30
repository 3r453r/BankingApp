using CdcSoftware.Pivotal.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP.EF.Data.AppDto.Response
{
    public class CheckSCAForDispositionResponse : BaseDtoResponse
    {
        public bool SCA_Availability { get; set; }

        public bool SCA_SMS_Available { get; set; }

        public bool SCA_BM_Available { get; set; }

        public bool SCA_Email_SMS_Available { get; set; }
    }
}
