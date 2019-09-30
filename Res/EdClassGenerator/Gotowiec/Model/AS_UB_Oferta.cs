using System;
using System.Data;

namespace PP.EF.Data.EdModel
{
    public class AS_UB_Oferta : EdModel
    {
        public AS_UB_Oferta(DataRow primaryDataRow) : base(primaryDataRow, "AS_UB_Oferta", "AS_UB_Oferta_Id")
        {
        }

        public byte[] AS_UB_Oferta_Id{
            get {
                var value = Row["AS_UB_Oferta_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_UB_Oferta_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_UB_Oferta_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_UB_Oferta_Id", DataRowVersion.Original] : (byte[])Row["AS_UB_Oferta_Id"];

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

        public string Ubezpieczyciel{
            get {
                var value = Row["Ubezpieczyciel"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Ubezpieczyciel"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Ubezpieczyciel_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Ubezpieczyciel", DataRowVersion.Original] : (string)Row["Ubezpieczyciel"];

        public string Nazwa_Ubezpieczenia{
            get {
                var value = Row["Nazwa_Ubezpieczenia"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Nazwa_Ubezpieczenia"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Nazwa_Ubezpieczenia_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Nazwa_Ubezpieczenia", DataRowVersion.Original] : (string)Row["Nazwa_Ubezpieczenia"];

        public string ID_Ubezpieczyciela{
            get {
                var value = Row["ID_Ubezpieczyciela"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["ID_Ubezpieczyciela"] = value == null ? DBNull.Value : (object)value; }
        }

        public string ID_Ubezpieczyciela_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["ID_Ubezpieczyciela", DataRowVersion.Original] : (string)Row["ID_Ubezpieczyciela"];

        public string Kod_Ubezpieczyciela{
            get {
                var value = Row["Kod_Ubezpieczyciela"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Kod_Ubezpieczyciela"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Kod_Ubezpieczyciela_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Kod_Ubezpieczyciela", DataRowVersion.Original] : (string)Row["Kod_Ubezpieczyciela"];

        public byte? Aktywna{
            get {
                var value = Row["Aktywna"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Aktywna"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Aktywna_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Aktywna", DataRowVersion.Original] : (byte?)Row["Aktywna"];

        public DateTime? Data_od{
            get {
                var value = Row["Data_od"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Data_od"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Data_od_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Data_od", DataRowVersion.Original] : (DateTime?)Row["Data_od"];

        public DateTime? Data_do{
            get {
                var value = Row["Data_do"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Data_do"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Data_do_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Data_do", DataRowVersion.Original] : (DateTime?)Row["Data_do"];

        public byte[] AS_UB_Typ_Ubezpieczenia_Id{
            get {
                var value = Row["AS_UB_Typ_Ubezpieczenia_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_UB_Typ_Ubezpieczenia_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_UB_Typ_Ubezpieczenia_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_UB_Typ_Ubezpieczenia_Id", DataRowVersion.Original] : (byte[])Row["AS_UB_Typ_Ubezpieczenia_Id"];

        public string Kod_Wniosku{
            get {
                var value = Row["Kod_Wniosku"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Kod_Wniosku"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Kod_Wniosku_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Kod_Wniosku", DataRowVersion.Original] : (string)Row["Kod_Wniosku"];

        public string Nazwa_Wniosku{
            get {
                var value = Row["Nazwa_Wniosku"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Nazwa_Wniosku"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Nazwa_Wniosku_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Nazwa_Wniosku", DataRowVersion.Original] : (string)Row["Nazwa_Wniosku"];

    }
}
