using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace EdClassGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = args[0];
            string @namespace = args[1];
            string[] tableNames;
            if (args[2] == "all")
            {
                tableNames = new string[0];
            }
            else
            {
                tableNames = new string[args.Length - 2];
                Array.Copy(args, 2, tableNames, 0, args.Length - 2);
            }

            DataTable columnData = new DataTable();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(@"select t.TABLE_NAME, c.COLUMN_NAME, c.DATA_TYPE from INFORMATION_SCHEMA.TABLES t
join INFORMATION_SCHEMA.COLUMNS c on t.TABLE_NAME = c.TABLE_NAME and t.TABLE_SCHEMA = c.TABLE_SCHEMA and t.TABLE_CATALOG = c.TABLE_CATALOG
where t.TABLE_TYPE = 'BASE TABLE' and t.TABLE_SCHEMA = 'dbo'", conn))
                {
                    if (tableNames.Length > 0)
                    {
                        cmd.CommandText += $" and t.TABLE_NAME in ({string.Join(',', tableNames.Select(n => $"'{n}'"))})";
                    }
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(columnData);
                    }
                }
            }

            Directory.CreateDirectory("Model");

            foreach (var grouping in columnData.AsEnumerable().GroupBy(r => Convert.ToString(r["TABLE_NAME"])))
            {
                string text = GenerateClassContent(grouping, @namespace);
                if (string.IsNullOrEmpty(text))
                    continue;

                File.WriteAllText($@"Model\{grouping.Key}.cs", text);
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static string GenerateClassContent(IGrouping<string, DataRow> grouping, string @namespace)
        {
            int substLen = grouping.Key.Length + 3 > 30 ? 30 : grouping.Key.Length + 3;
            var builder = new StringBuilder();
            builder.AppendLine("using System;");
            builder.AppendLine("using System.Data;");
            builder.AppendLine("");
            builder.AppendLine("namespace " + @namespace);
            builder.AppendLine("{");
            builder.AppendLine(Indent(1) + "public class " + grouping.Key + " : EdModel");
            builder.AppendLine(Indent(1) + "{");
            builder.Append($@"        public {grouping.Key}(DataRow primaryDataRow) : base(primaryDataRow, ""{grouping.Key}"", ""{(grouping.Key + "_Id").Substring(0, substLen)}"")
        {{
        }}");
            builder.AppendLine("");
            builder.AppendLine("");
            foreach (var row in grouping)
            {
                string colName = Convert.ToString(row["COLUMN_NAME"]);

                string type = "";
                try
                {
                    type = GetTypeFromSqlType(Convert.ToString(row["DATA_TYPE"]));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine($"{grouping.Key}[{colName}]:  {e.Message}");
                    return null;
                }
                builder.AppendLine(Indent(2) + "public " + type + " " + colName + "{");

                builder.AppendLine(Indent(3) + "get {");

                builder.AppendLine(Indent(4) + "var value = Row[\"" + colName +"\"];");
                builder.AppendLine(Indent(4) + $"return value == DBNull.Value ? null : ({type})value;");

                builder.AppendLine(Indent(3) + "}");
                builder.AppendLine("");
                builder.AppendLine(Indent(3) + "set { Row[\"" + colName + "\"] = value == null ? DBNull.Value : (object)value; }");

                builder.AppendLine(Indent(2) + "}");
                builder.AppendLine("");
                builder.AppendLine(Indent(2) + "public " + type + " " + colName + "_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? ("
                    + type + ")Row[\"" + colName + "\", DataRowVersion.Original] : (" + type + ")Row[\"" + colName + "\"];");
                builder.AppendLine("");
            }
            builder.AppendLine(Indent(1) + "}");
            builder.AppendLine("}");

            return builder.ToString();
        }

        private static string GetTypeFromSqlType(string sqlType)
        {
            switch (sqlType)
            {
                case "image":
                case "varbinary":
                case "binary": return "byte[]";
                case "datetime":
                case "date":
                case "time": return "DateTime?";
                case "smallint":
                case "int": return "int?";
                case "bit":
                case "tinyint": return "byte?";
                case "ntext":
                case "varchar":
                case "xml":
                case "nvarchar": return "string";
                case "decimal":
                case "float": return "decimal?";
                case "bigint": return "long?";
                default: throw new ArgumentException($"Unrecognized sqlType: [{sqlType}]");
            }
        }

        private static string Indent(int depth)
        {
            string result = "";
            for (int i = 0; i < depth; i++)
            {
                result += "    ";
            }
            return result;
        }
    }
}
