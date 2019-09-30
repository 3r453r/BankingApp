using CdcSoftware.Pivotal.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP.EF.Data.AppDto.Request
{
    public class CheckSCAForDispositionRequest : BaseDtoRequest
    {
        public Id RecordId { get; set; }

        public string TableName { get; set; }
    }
}
