using System;
using System.Data;

namespace PP.EF.Data.EdModel
{
    public class A_BIZ_Zastepstwo : EdModel
    {
        public A_BIZ_Zastepstwo(DataRow primaryDataRow) : base(primaryDataRow, "A_BIZ_Zastepstwo", "A_BIZ_Zastepstwo_Id")
        {
        }

        public byte[] A_BIZ_Zastepstwo_Id{
            get {
                var value = Row["A_BIZ_Zastepstwo_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_BIZ_Zastepstwo_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_BIZ_Zastepstwo_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_BIZ_Zastepstwo_Id", DataRowVersion.Original] : (byte[])Row["A_BIZ_Zastepstwo_Id"];

        public string Rn_Descriptor{
            get {
                var value = Row["Rn_Descriptor"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Rn_Descriptor"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Rn_Descriptor_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Rn_Descriptor", DataRowVersion.Original] : (string)Row["Rn_Descriptor"];

        public DateTime? Rn_Create_Date{
            get {
                var value = Row["Rn_Create_Date"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Rn_Create_Date"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Rn_Create_Date_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Rn_Create_Date", DataRowVersion.Original] : (DateTime?)Row["Rn_Create_Date"];

        public byte[] Rn_Create_User{
            get {
                var value = Row["Rn_Create_User"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Rn_Create_User"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Rn_Create_User_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Rn_Create_User", DataRowVersion.Original] : (byte[])Row["Rn_Create_User"];

        public DateTime? Rn_Edit_Date{
            get {
                var value = Row["Rn_Edit_Date"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Rn_Edit_Date"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Rn_Edit_Date_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Rn_Edit_Date", DataRowVersion.Original] : (DateTime?)Row["Rn_Edit_Date"];

        public byte[] Rn_Edit_User{
            get {
                var value = Row["Rn_Edit_User"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Rn_Edit_User"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Rn_Edit_User_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Rn_Edit_User", DataRowVersion.Original] : (byte[])Row["Rn_Edit_User"];

        public byte[] A_Team_Id{
            get {
                var value = Row["A_Team_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Team_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Team_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Team_Id", DataRowVersion.Original] : (byte[])Row["A_Team_Id"];

        public byte[] Doradca_Zastepowany_Id{
            get {
                var value = Row["Doradca_Zastepowany_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Doradca_Zastepowany_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Doradca_Zastepowany_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Doradca_Zastepowany_Id", DataRowVersion.Original] : (byte[])Row["Doradca_Zastepowany_Id"];

        public byte[] Doradca_Zastepujacy_Id{
            get {
                var value = Row["Doradca_Zastepujacy_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Doradca_Zastepujacy_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Doradca_Zastepujacy_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Doradca_Zastepujacy_Id", DataRowVersion.Original] : (byte[])Row["Doradca_Zastepujacy_Id"];

        public int? Powiadomienie_Dni{
            get {
                var value = Row["Powiadomienie_Dni"];
                return value == DBNull.Value ? null : (int?)value;
            }

            set { Row["Powiadomienie_Dni"] = value == null ? DBNull.Value : (object)value; }
        }

        public int? Powiadomienie_Dni_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (int?)Row["Powiadomienie_Dni", DataRowVersion.Original] : (int?)Row["Powiadomienie_Dni"];

        public DateTime? Data_Od{
            get {
                var value = Row["Data_Od"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Data_Od"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Data_Od_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Data_Od", DataRowVersion.Original] : (DateTime?)Row["Data_Od"];

        public DateTime? Data_Do{
            get {
                var value = Row["Data_Do"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Data_Do"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Data_Do_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Data_Do", DataRowVersion.Original] : (DateTime?)Row["Data_Do"];

        public string Opis{
            get {
                var value = Row["Opis"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Opis"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Opis_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Opis", DataRowVersion.Original] : (string)Row["Opis"];

        public byte? Aktywne{
            get {
                var value = Row["Aktywne"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Aktywne"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Aktywne_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Aktywne", DataRowVersion.Original] : (byte?)Row["Aktywne"];

        public byte? Anulowano{
            get {
                var value = Row["Anulowano"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Anulowano"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Anulowano_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Anulowano", DataRowVersion.Original] : (byte?)Row["Anulowano"];

        public DateTime? Data_Anulowania{
            get {
                var value = Row["Data_Anulowania"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Data_Anulowania"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Data_Anulowania_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Data_Anulowania", DataRowVersion.Original] : (DateTime?)Row["Data_Anulowania"];

        public byte? Przypomnienie_Wyslane{
            get {
                var value = Row["Przypomnienie_Wyslane"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Przypomnienie_Wyslane"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Przypomnienie_Wyslane_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Przypomnienie_Wyslane", DataRowVersion.Original] : (byte?)Row["Przypomnienie_Wyslane"];

    }
}
