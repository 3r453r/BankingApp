using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PP.EF.Data.AppDto.Response
{
    public class GetRelationResponse : BaseDtoResponse
    {
        public DataTable RelationsTable { get; set; }
    }
}
