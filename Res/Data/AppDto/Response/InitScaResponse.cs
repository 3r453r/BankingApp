using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP.EF.Data.AppDto.Response
{
    public class InitScaResponse : BaseDtoResponse
    {
        public bool result { get; set; }

        public InitAuthorizationResponse resposne { get; set; }
    }

    public class InitAuthorizationResponse
    {
        public string confirmationID;

        public string smsNo;

        public Result result;
    }

    public class Result
    {
        public string errorCode;

        public string errorDescription;

        public string[] errorDetails;
    }
}
