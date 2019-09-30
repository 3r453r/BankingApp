using CdcSoftware.Pivotal.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PP.EF.Data.AppDto.Request
{
    public class ImportExPostMoventum : BaseDtoRequest
    {
        public DataTable Data { get; set; }
        public string FileName { get; set; }
        public int TotalRows { get; set; }
        public int Year { get; set; }
        public Id ExPostHistId { get; set; }
        public bool DeleteData { get; set; }
        public int? PsatTable { get; set; }

        public override BaseDtoSerialized SerializeForLogging()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("Count", typeof(int));
            var row = dataTable.NewRow();
            row["Count"] = Data.Rows.Count;
            dataTable.Rows.Add(row);

            var mock = new ImportExPostMoventum
            {
                Data = dataTable,
                FileName = FileName
                , TotalRows = TotalRows
                , Year = Year
                , ExPostHistId = ExPostHistId
                , DeleteData = DeleteData
                , PsatTable = PsatTable                
                , Id = Id
                , MockLog = true
            };

            return mock.Serialize();
        }
    }
}
