using System;
using System.Data;

namespace PP.EF.Data.EdModel
{
    public class A_Case_Process : EdModel
    {
        public A_Case_Process(DataRow primaryDataRow) : base(primaryDataRow, "A_Case_Process", "A_Case_Process_Id")
        {
        }

        public byte[] A_Call_Id{
            get {
                var value = Row["A_Call_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Call_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Call_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Call_Id", DataRowVersion.Original] : (byte[])Row["A_Call_Id"];

        public DateTime? Data_Oddzwonienia{
            get {
                var value = Row["Data_Oddzwonienia"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Data_Oddzwonienia"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Data_Oddzwonienia_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Data_Oddzwonienia", DataRowVersion.Original] : (DateTime?)Row["Data_Oddzwonienia"];

        public DateTime? Czas_Oddzwonienia{
            get {
                var value = Row["Czas_Oddzwonienia"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Czas_Oddzwonienia"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Czas_Oddzwonienia_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Czas_Oddzwonienia", DataRowVersion.Original] : (DateTime?)Row["Czas_Oddzwonienia"];

        public byte[] AS_Czas_Przelozenia_Id{
            get {
                var value = Row["AS_Czas_Przelozenia_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Czas_Przelozenia_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Czas_Przelozenia_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Czas_Przelozenia_Id", DataRowVersion.Original] : (byte[])Row["AS_Czas_Przelozenia_Id"];

        public byte[] AS_Przyczyna_Przelozenia_Id{
            get {
                var value = Row["AS_Przyczyna_Przelozenia_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Przyczyna_Przelozenia_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Przyczyna_Przelozenia_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Przyczyna_Przelozenia_Id", DataRowVersion.Original] : (byte[])Row["AS_Przyczyna_Przelozenia_Id"];

        public byte? Czy_Osobiscie{
            get {
                var value = Row["Czy_Osobiscie"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Czy_Osobiscie"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Czy_Osobiscie_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Czy_Osobiscie", DataRowVersion.Original] : (byte?)Row["Czy_Osobiscie"];

        public byte[] A_Contract_Id{
            get {
                var value = Row["A_Contract_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Contract_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Contract_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Contract_Id", DataRowVersion.Original] : (byte[])Row["A_Contract_Id"];

        public int? Timer{
            get {
                var value = Row["Timer"];
                return value == DBNull.Value ? null : (int?)value;
            }

            set { Row["Timer"] = value == null ? DBNull.Value : (object)value; }
        }

        public int? Timer_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (int?)Row["Timer", DataRowVersion.Original] : (int?)Row["Timer"];

        public byte[] A_Karta_Kred_Debet_Id{
            get {
                var value = Row["A_Karta_Kred_Debet_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Karta_Kred_Debet_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Karta_Kred_Debet_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Karta_Kred_Debet_Id", DataRowVersion.Original] : (byte[])Row["A_Karta_Kred_Debet_Id"];

        public byte[] Osoba_Zlecajaca_Id{
            get {
                var value = Row["Osoba_Zlecajaca_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Osoba_Zlecajaca_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Osoba_Zlecajaca_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Osoba_Zlecajaca_Id", DataRowVersion.Original] : (byte[])Row["Osoba_Zlecajaca_Id"];

        public byte? Zrodlo_Dyspozycji{
            get {
                var value = Row["Zrodlo_Dyspozycji"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zrodlo_Dyspozycji"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zrodlo_Dyspozycji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zrodlo_Dyspozycji", DataRowVersion.Original] : (byte?)Row["Zrodlo_Dyspozycji"];

        public byte[] AV_Dyspozycja_Id{
            get {
                var value = Row["AV_Dyspozycja_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AV_Dyspozycja_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AV_Dyspozycja_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AV_Dyspozycja_Id", DataRowVersion.Original] : (byte[])Row["AV_Dyspozycja_Id"];

        public byte[] A_WFlow_Template_Conf_Id{
            get {
                var value = Row["A_WFlow_Template_Conf_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_WFlow_Template_Conf_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_WFlow_Template_Conf_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_WFlow_Template_Conf_Id", DataRowVersion.Original] : (byte[])Row["A_WFlow_Template_Conf_Id"];

        public byte? Oddzownic_Po_Realizacji{
            get {
                var value = Row["Oddzownic_Po_Realizacji"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Oddzownic_Po_Realizacji"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Oddzownic_Po_Realizacji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Oddzownic_Po_Realizacji", DataRowVersion.Original] : (byte?)Row["Oddzownic_Po_Realizacji"];

        public string Szablon{
            get {
                var value = Row["Szablon"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Szablon"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Szablon_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Szablon", DataRowVersion.Original] : (string)Row["Szablon"];

        public byte[] A_EM_EmailBodyTemplate_Id{
            get {
                var value = Row["A_EM_EmailBodyTemplate_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_EM_EmailBodyTemplate_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_EM_EmailBodyTemplate_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_EM_EmailBodyTemplate_Id", DataRowVersion.Original] : (byte[])Row["A_EM_EmailBodyTemplate_Id"];

        public byte? Osoba_Trzecia{
            get {
                var value = Row["Osoba_Trzecia"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Osoba_Trzecia"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Osoba_Trzecia_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Osoba_Trzecia", DataRowVersion.Original] : (byte?)Row["Osoba_Trzecia"];

        public string Osoba_Zglaszajaca{
            get {
                var value = Row["Osoba_Zglaszajaca"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Osoba_Zglaszajaca"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Osoba_Zglaszajaca_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Osoba_Zglaszajaca", DataRowVersion.Original] : (string)Row["Osoba_Zglaszajaca"];

        public string Kwota_Oplaty{
            get {
                var value = Row["Kwota_Oplaty"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Kwota_Oplaty"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Kwota_Oplaty_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Kwota_Oplaty", DataRowVersion.Original] : (string)Row["Kwota_Oplaty"];

        public byte? Brak_Oplaty{
            get {
                var value = Row["Brak_Oplaty"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Brak_Oplaty"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Brak_Oplaty_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Brak_Oplaty", DataRowVersion.Original] : (byte?)Row["Brak_Oplaty"];

        public byte? Wplata_Na_Rachunek_Techniczny{
            get {
                var value = Row["Wplata_Na_Rachunek_Techniczny"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Wplata_Na_Rachunek_Techniczny"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Wplata_Na_Rachunek_Techniczny_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Wplata_Na_Rachunek_Techniczny", DataRowVersion.Original] : (byte?)Row["Wplata_Na_Rachunek_Techniczny"];

        public string Rechunek_Techniczny{
            get {
                var value = Row["Rechunek_Techniczny"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Rechunek_Techniczny"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Rechunek_Techniczny_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Rechunek_Techniczny", DataRowVersion.Original] : (string)Row["Rechunek_Techniczny"];

        public byte? Obciaz_ROR_Klienta{
            get {
                var value = Row["Obciaz_ROR_Klienta"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Obciaz_ROR_Klienta"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Obciaz_ROR_Klienta_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Obciaz_ROR_Klienta", DataRowVersion.Original] : (byte?)Row["Obciaz_ROR_Klienta"];

        public byte? Wplata_Na_Rachunek_Kredytu{
            get {
                var value = Row["Wplata_Na_Rachunek_Kredytu"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Wplata_Na_Rachunek_Kredytu"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Wplata_Na_Rachunek_Kredytu_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Wplata_Na_Rachunek_Kredytu", DataRowVersion.Original] : (byte?)Row["Wplata_Na_Rachunek_Kredytu"];

        public DateTime? Termin_Realizacji{
            get {
                var value = Row["Termin_Realizacji"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Termin_Realizacji"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Termin_Realizacji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Termin_Realizacji", DataRowVersion.Original] : (DateTime?)Row["Termin_Realizacji"];

        public byte? Rodzaj_Adresu_Email{
            get {
                var value = Row["Rodzaj_Adresu_Email"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Rodzaj_Adresu_Email"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Rodzaj_Adresu_Email_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Rodzaj_Adresu_Email", DataRowVersion.Original] : (byte?)Row["Rodzaj_Adresu_Email"];

        public string Adres_Email{
            get {
                var value = Row["Adres_Email"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Adres_Email"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Adres_Email_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Adres_Email", DataRowVersion.Original] : (string)Row["Adres_Email"];

        public byte? Rodzaj_Adresu{
            get {
                var value = Row["Rodzaj_Adresu"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Rodzaj_Adresu"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Rodzaj_Adresu_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Rodzaj_Adresu", DataRowVersion.Original] : (byte?)Row["Rodzaj_Adresu"];

        public string Ulica{
            get {
                var value = Row["Ulica"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Ulica"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Ulica_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Ulica", DataRowVersion.Original] : (string)Row["Ulica"];

        public string Nr_Domu{
            get {
                var value = Row["Nr_Domu"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Nr_Domu"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Nr_Domu_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Nr_Domu", DataRowVersion.Original] : (string)Row["Nr_Domu"];

        public string Nr_Lokalu{
            get {
                var value = Row["Nr_Lokalu"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Nr_Lokalu"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Nr_Lokalu_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Nr_Lokalu", DataRowVersion.Original] : (string)Row["Nr_Lokalu"];

        public string Miejscowosc{
            get {
                var value = Row["Miejscowosc"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Miejscowosc"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Miejscowosc_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Miejscowosc", DataRowVersion.Original] : (string)Row["Miejscowosc"];

        public string Kod_Pocztowy{
            get {
                var value = Row["Kod_Pocztowy"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Kod_Pocztowy"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Kod_Pocztowy_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Kod_Pocztowy", DataRowVersion.Original] : (string)Row["Kod_Pocztowy"];

        public string Poczta{
            get {
                var value = Row["Poczta"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Poczta"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Poczta_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Poczta", DataRowVersion.Original] : (string)Row["Poczta"];

        public string Termin_Realizacji_Dyspozycji{
            get {
                var value = Row["Termin_Realizacji_Dyspozycji"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Termin_Realizacji_Dyspozycji"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Termin_Realizacji_Dyspozycji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Termin_Realizacji_Dyspozycji", DataRowVersion.Original] : (string)Row["Termin_Realizacji_Dyspozycji"];

        public DateTime? Case_Process_Start{
            get {
                var value = Row["Case_Process_Start"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Case_Process_Start"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Case_Process_Start_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Case_Process_Start", DataRowVersion.Original] : (DateTime?)Row["Case_Process_Start"];

        public byte[] Decydent_1{
            get {
                var value = Row["Decydent_1"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Decydent_1"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Decydent_1_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Decydent_1", DataRowVersion.Original] : (byte[])Row["Decydent_1"];

        public byte[] A_Team_Type_Id{
            get {
                var value = Row["A_Team_Type_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Team_Type_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Team_Type_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Team_Type_Id", DataRowVersion.Original] : (byte[])Row["A_Team_Type_Id"];

        public DateTime? Case_Process_End{
            get {
                var value = Row["Case_Process_End"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Case_Process_End"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Case_Process_End_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Case_Process_End", DataRowVersion.Original] : (DateTime?)Row["Case_Process_End"];

        public byte[] Decydent_2{
            get {
                var value = Row["Decydent_2"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Decydent_2"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Decydent_2_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Decydent_2", DataRowVersion.Original] : (byte[])Row["Decydent_2"];

        public byte[] A_Case_Process_Id{
            get {
                var value = Row["A_Case_Process_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Case_Process_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Case_Process_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Case_Process_Id", DataRowVersion.Original] : (byte[])Row["A_Case_Process_Id"];

        public byte[] A_WFlow_Template_Main_Id{
            get {
                var value = Row["A_WFlow_Template_Main_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_WFlow_Template_Main_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_WFlow_Template_Main_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_WFlow_Template_Main_Id", DataRowVersion.Original] : (byte[])Row["A_WFlow_Template_Main_Id"];

        public byte[] Akceptant{
            get {
                var value = Row["Akceptant"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Akceptant"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Akceptant_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Akceptant", DataRowVersion.Original] : (byte[])Row["Akceptant"];

        public byte? Dept{
            get {
                var value = Row["Dept"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Dept"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Dept_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Dept", DataRowVersion.Original] : (byte?)Row["Dept"];

        public string Rn_Descriptor{
            get {
                var value = Row["Rn_Descriptor"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Rn_Descriptor"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Rn_Descriptor_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Rn_Descriptor", DataRowVersion.Original] : (string)Row["Rn_Descriptor"];

        public byte[] A_WFlow_Template_Id{
            get {
                var value = Row["A_WFlow_Template_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_WFlow_Template_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_WFlow_Template_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_WFlow_Template_Id", DataRowVersion.Original] : (byte[])Row["A_WFlow_Template_Id"];

        public DateTime? Rn_Edit_Date{
            get {
                var value = Row["Rn_Edit_Date"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Rn_Edit_Date"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Rn_Edit_Date_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Rn_Edit_Date", DataRowVersion.Original] : (DateTime?)Row["Rn_Edit_Date"];

        public string Number_{
            get {
                var value = Row["Number_"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Number_"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Number__OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Number_", DataRowVersion.Original] : (string)Row["Number_"];

        public byte[] A_WFlow_Template_Type_Id{
            get {
                var value = Row["A_WFlow_Template_Type_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_WFlow_Template_Type_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_WFlow_Template_Type_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_WFlow_Template_Type_Id", DataRowVersion.Original] : (byte[])Row["A_WFlow_Template_Type_Id"];

        public byte[] Initiator_Id{
            get {
                var value = Row["Initiator_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Initiator_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Initiator_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Initiator_Id", DataRowVersion.Original] : (byte[])Row["Initiator_Id"];

        public byte[] Rn_Edit_User{
            get {
                var value = Row["Rn_Edit_User"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Rn_Edit_User"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Rn_Edit_User_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Rn_Edit_User", DataRowVersion.Original] : (byte[])Row["Rn_Edit_User"];

        public byte[] A_WFlow_Id{
            get {
                var value = Row["A_WFlow_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_WFlow_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_WFlow_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_WFlow_Id", DataRowVersion.Original] : (byte[])Row["A_WFlow_Id"];

        public byte[] A_WFlow_Template_Step_Id{
            get {
                var value = Row["A_WFlow_Template_Step_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_WFlow_Template_Step_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_WFlow_Template_Step_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_WFlow_Template_Step_Id", DataRowVersion.Original] : (byte[])Row["A_WFlow_Template_Step_Id"];

        public byte[] Owner_Id{
            get {
                var value = Row["Owner_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Owner_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Owner_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Owner_Id", DataRowVersion.Original] : (byte[])Row["Owner_Id"];

        public byte[] A_Team_Id{
            get {
                var value = Row["A_Team_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Team_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Team_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Team_Id", DataRowVersion.Original] : (byte[])Row["A_Team_Id"];

        public string End_Reason{
            get {
                var value = Row["End_Reason"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["End_Reason"] = value == null ? DBNull.Value : (object)value; }
        }

        public string End_Reason_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["End_Reason", DataRowVersion.Original] : (string)Row["End_Reason"];

        public byte[] Rn_Create_User{
            get {
                var value = Row["Rn_Create_User"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Rn_Create_User"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Rn_Create_User_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Rn_Create_User", DataRowVersion.Original] : (byte[])Row["Rn_Create_User"];

        public string Current_Step_Note{
            get {
                var value = Row["Current_Step_Note"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Current_Step_Note"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Current_Step_Note_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Current_Step_Note", DataRowVersion.Original] : (string)Row["Current_Step_Note"];

        public byte[] A_WFlow_Step_Id{
            get {
                var value = Row["A_WFlow_Step_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_WFlow_Step_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_WFlow_Step_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_WFlow_Step_Id", DataRowVersion.Original] : (byte[])Row["A_WFlow_Step_Id"];

        public byte[] Actor_Id{
            get {
                var value = Row["Actor_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Actor_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Actor_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Actor_Id", DataRowVersion.Original] : (byte[])Row["Actor_Id"];

        public byte[] Pracownik_ADM{
            get {
                var value = Row["Pracownik_ADM"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Pracownik_ADM"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Pracownik_ADM_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Pracownik_ADM", DataRowVersion.Original] : (byte[])Row["Pracownik_ADM"];

        public DateTime? Rn_Create_Date{
            get {
                var value = Row["Rn_Create_Date"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Rn_Create_Date"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Rn_Create_Date_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Rn_Create_Date", DataRowVersion.Original] : (DateTime?)Row["Rn_Create_Date"];

        public byte? Typ_Uruchomienia{
            get {
                var value = Row["Typ_Uruchomienia"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Typ_Uruchomienia"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Typ_Uruchomienia_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Typ_Uruchomienia", DataRowVersion.Original] : (byte?)Row["Typ_Uruchomienia"];

        public byte[] Company_Id{
            get {
                var value = Row["Company_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Company_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Company_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Company_Id", DataRowVersion.Original] : (byte[])Row["Company_Id"];

        public byte? Status_Decyzji{
            get {
                var value = Row["Status_Decyzji"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Status_Decyzji"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Status_Decyzji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Status_Decyzji", DataRowVersion.Original] : (byte?)Row["Status_Decyzji"];

        public DateTime? Nastepny_Dzien_Splaty{
            get {
                var value = Row["Nastepny_Dzien_Splaty"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Nastepny_Dzien_Splaty"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Nastepny_Dzien_Splaty_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Nastepny_Dzien_Splaty", DataRowVersion.Original] : (DateTime?)Row["Nastepny_Dzien_Splaty"];

        public decimal? Razem{
            get {
                var value = Row["Razem"];
                return value == DBNull.Value ? null : (decimal?)value;
            }

            set { Row["Razem"] = value == null ? DBNull.Value : (object)value; }
        }

        public decimal? Razem_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (decimal?)Row["Razem", DataRowVersion.Original] : (decimal?)Row["Razem"];

        public decimal? Odsetki{
            get {
                var value = Row["Odsetki"];
                return value == DBNull.Value ? null : (decimal?)value;
            }

            set { Row["Odsetki"] = value == null ? DBNull.Value : (object)value; }
        }

        public decimal? Odsetki_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (decimal?)Row["Odsetki", DataRowVersion.Original] : (decimal?)Row["Odsetki"];

        public int? Umowny_Dzien_Splaty{
            get {
                var value = Row["Umowny_Dzien_Splaty"];
                return value == DBNull.Value ? null : (int?)value;
            }

            set { Row["Umowny_Dzien_Splaty"] = value == null ? DBNull.Value : (object)value; }
        }

        public int? Umowny_Dzien_Splaty_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (int?)Row["Umowny_Dzien_Splaty", DataRowVersion.Original] : (int?)Row["Umowny_Dzien_Splaty"];

        public int? Wnioskowany_Dzien_Splaty{
            get {
                var value = Row["Wnioskowany_Dzien_Splaty"];
                return value == DBNull.Value ? null : (int?)value;
            }

            set { Row["Wnioskowany_Dzien_Splaty"] = value == null ? DBNull.Value : (object)value; }
        }

        public int? Wnioskowany_Dzien_Splaty_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (int?)Row["Wnioskowany_Dzien_Splaty", DataRowVersion.Original] : (int?)Row["Wnioskowany_Dzien_Splaty"];

        public int? Typ_Dyspozycji{
            get {
                var value = Row["Typ_Dyspozycji"];
                return value == DBNull.Value ? null : (int?)value;
            }

            set { Row["Typ_Dyspozycji"] = value == null ? DBNull.Value : (object)value; }
        }

        public int? Typ_Dyspozycji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (int?)Row["Typ_Dyspozycji", DataRowVersion.Original] : (int?)Row["Typ_Dyspozycji"];

        public int? Wyrazenie_Zgody{
            get {
                var value = Row["Wyrazenie_Zgody"];
                return value == DBNull.Value ? null : (int?)value;
            }

            set { Row["Wyrazenie_Zgody"] = value == null ? DBNull.Value : (object)value; }
        }

        public int? Wyrazenie_Zgody_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (int?)Row["Wyrazenie_Zgody", DataRowVersion.Original] : (int?)Row["Wyrazenie_Zgody"];

        public int? Sposob_Dostarczenia{
            get {
                var value = Row["Sposob_Dostarczenia"];
                return value == DBNull.Value ? null : (int?)value;
            }

            set { Row["Sposob_Dostarczenia"] = value == null ? DBNull.Value : (object)value; }
        }

        public int? Sposob_Dostarczenia_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (int?)Row["Sposob_Dostarczenia", DataRowVersion.Original] : (int?)Row["Sposob_Dostarczenia"];

        public string Telefon_Email{
            get {
                var value = Row["Telefon_Email"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Telefon_Email"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Telefon_Email_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Telefon_Email", DataRowVersion.Original] : (string)Row["Telefon_Email"];

        public string idCustomer{
            get {
                var value = Row["idCustomer"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["idCustomer"] = value == null ? DBNull.Value : (object)value; }
        }

        public string idCustomer_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["idCustomer", DataRowVersion.Original] : (string)Row["idCustomer"];

        public string Telefon_do_oddzwonienia{
            get {
                var value = Row["Telefon_do_oddzwonienia"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Telefon_do_oddzwonienia"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Telefon_do_oddzwonienia_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Telefon_do_oddzwonienia", DataRowVersion.Original] : (string)Row["Telefon_do_oddzwonienia"];

        public byte[] INIT_Klient_Id{
            get {
                var value = Row["INIT_Klient_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["INIT_Klient_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] INIT_Klient_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["INIT_Klient_Id", DataRowVersion.Original] : (byte[])Row["INIT_Klient_Id"];

        public byte[] INIT_Os_Zlecajaca_Id{
            get {
                var value = Row["INIT_Os_Zlecajaca_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["INIT_Os_Zlecajaca_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] INIT_Os_Zlecajaca_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["INIT_Os_Zlecajaca_Id", DataRowVersion.Original] : (byte[])Row["INIT_Os_Zlecajaca_Id"];

        public byte[] INIT_Contract_Id{
            get {
                var value = Row["INIT_Contract_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["INIT_Contract_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] INIT_Contract_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["INIT_Contract_Id", DataRowVersion.Original] : (byte[])Row["INIT_Contract_Id"];

        public byte[] INIT_Transakcja_Id{
            get {
                var value = Row["INIT_Transakcja_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["INIT_Transakcja_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] INIT_Transakcja_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["INIT_Transakcja_Id", DataRowVersion.Original] : (byte[])Row["INIT_Transakcja_Id"];

        public byte[] INIT_Karta_Kred_Debet_Id{
            get {
                var value = Row["INIT_Karta_Kred_Debet_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["INIT_Karta_Kred_Debet_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] INIT_Karta_Kred_Debet_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["INIT_Karta_Kred_Debet_Id", DataRowVersion.Original] : (byte[])Row["INIT_Karta_Kred_Debet_Id"];

        public byte[] INIT_Zlecenie_Stale_Id{
            get {
                var value = Row["INIT_Zlecenie_Stale_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["INIT_Zlecenie_Stale_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] INIT_Zlecenie_Stale_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["INIT_Zlecenie_Stale_Id", DataRowVersion.Original] : (byte[])Row["INIT_Zlecenie_Stale_Id"];

        public byte[] A_Transakcja_Id{
            get {
                var value = Row["A_Transakcja_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Transakcja_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Transakcja_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Transakcja_Id", DataRowVersion.Original] : (byte[])Row["A_Transakcja_Id"];

        public byte[] A_Zlecenie_Stale_Id{
            get {
                var value = Row["A_Zlecenie_Stale_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Zlecenie_Stale_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Zlecenie_Stale_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Zlecenie_Stale_Id", DataRowVersion.Original] : (byte[])Row["A_Zlecenie_Stale_Id"];

        public byte[] A_Rn_Activity_Id{
            get {
                var value = Row["A_Rn_Activity_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Rn_Activity_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Rn_Activity_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Rn_Activity_Id", DataRowVersion.Original] : (byte[])Row["A_Rn_Activity_Id"];

        public byte[] A_EM_Alias_Id{
            get {
                var value = Row["A_EM_Alias_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_EM_Alias_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_EM_Alias_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_EM_Alias_Id", DataRowVersion.Original] : (byte[])Row["A_EM_Alias_Id"];

        public string Nazwa_Dyspozycji{
            get {
                var value = Row["Nazwa_Dyspozycji"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Nazwa_Dyspozycji"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Nazwa_Dyspozycji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Nazwa_Dyspozycji", DataRowVersion.Original] : (string)Row["Nazwa_Dyspozycji"];

        public byte[] A_Team_BO_Id{
            get {
                var value = Row["A_Team_BO_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Team_BO_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Team_BO_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Team_BO_Id", DataRowVersion.Original] : (byte[])Row["A_Team_BO_Id"];

        public byte[] AS_Brand_Id{
            get {
                var value = Row["AS_Brand_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Brand_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Brand_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Brand_Id", DataRowVersion.Original] : (byte[])Row["AS_Brand_Id"];

        public byte? Poziom_uwierzytelnienia{
            get {
                var value = Row["Poziom_uwierzytelnienia"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Poziom_uwierzytelnienia"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Poziom_uwierzytelnienia_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Poziom_uwierzytelnienia", DataRowVersion.Original] : (byte?)Row["Poziom_uwierzytelnienia"];

        public byte? Typ_telefonu{
            get {
                var value = Row["Typ_telefonu"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Typ_telefonu"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Typ_telefonu_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Typ_telefonu", DataRowVersion.Original] : (byte?)Row["Typ_telefonu"];

        public byte[] Call_Object_Client_Id{
            get {
                var value = Row["Call_Object_Client_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Call_Object_Client_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Call_Object_Client_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Call_Object_Client_Id", DataRowVersion.Original] : (byte[])Row["Call_Object_Client_Id"];

        public byte? Potwierdzenie_Realizacji{
            get {
                var value = Row["Potwierdzenie_Realizacji"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Potwierdzenie_Realizacji"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Potwierdzenie_Realizacji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Potwierdzenie_Realizacji", DataRowVersion.Original] : (byte?)Row["Potwierdzenie_Realizacji"];

        public byte[] A_Team_CCI_Id{
            get {
                var value = Row["A_Team_CCI_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Team_CCI_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Team_CCI_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Team_CCI_Id", DataRowVersion.Original] : (byte[])Row["A_Team_CCI_Id"];

        public byte[] AS_Temat_Dysp_Zapytaj_Id{
            get {
                var value = Row["AS_Temat_Dysp_Zapytaj_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Temat_Dysp_Zapytaj_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Temat_Dysp_Zapytaj_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Temat_Dysp_Zapytaj_Id", DataRowVersion.Original] : (byte[])Row["AS_Temat_Dysp_Zapytaj_Id"];

        public byte? Zweryfikowano_Umowa{
            get {
                var value = Row["Zweryfikowano_Umowa"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zweryfikowano_Umowa"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zweryfikowano_Umowa_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zweryfikowano_Umowa", DataRowVersion.Original] : (byte?)Row["Zweryfikowano_Umowa"];

        public decimal? Nadplata_Kredytu{
            get {
                var value = Row["Nadplata_Kredytu"];
                return value == DBNull.Value ? null : (decimal?)value;
            }

            set { Row["Nadplata_Kredytu"] = value == null ? DBNull.Value : (object)value; }
        }

        public decimal? Nadplata_Kredytu_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (decimal?)Row["Nadplata_Kredytu", DataRowVersion.Original] : (decimal?)Row["Nadplata_Kredytu"];

        public decimal? Czesciowa_Splata{
            get {
                var value = Row["Czesciowa_Splata"];
                return value == DBNull.Value ? null : (decimal?)value;
            }

            set { Row["Czesciowa_Splata"] = value == null ? DBNull.Value : (object)value; }
        }

        public decimal? Czesciowa_Splata_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (decimal?)Row["Czesciowa_Splata", DataRowVersion.Original] : (decimal?)Row["Czesciowa_Splata"];

        public byte? Sposob_Rozliczenia{
            get {
                var value = Row["Sposob_Rozliczenia"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Sposob_Rozliczenia"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Sposob_Rozliczenia_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Sposob_Rozliczenia", DataRowVersion.Original] : (byte?)Row["Sposob_Rozliczenia"];

        public decimal? Limit_Gotowkowy{
            get {
                var value = Row["Limit_Gotowkowy"];
                return value == DBNull.Value ? null : (decimal?)value;
            }

            set { Row["Limit_Gotowkowy"] = value == null ? DBNull.Value : (object)value; }
        }

        public decimal? Limit_Gotowkowy_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (decimal?)Row["Limit_Gotowkowy", DataRowVersion.Original] : (decimal?)Row["Limit_Gotowkowy"];

        public decimal? Limit_Bezgotowkowy{
            get {
                var value = Row["Limit_Bezgotowkowy"];
                return value == DBNull.Value ? null : (decimal?)value;
            }

            set { Row["Limit_Bezgotowkowy"] = value == null ? DBNull.Value : (object)value; }
        }

        public decimal? Limit_Bezgotowkowy_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (decimal?)Row["Limit_Bezgotowkowy", DataRowVersion.Original] : (decimal?)Row["Limit_Bezgotowkowy"];

        public decimal? Koszt_Wysylki{
            get {
                var value = Row["Koszt_Wysylki"];
                return value == DBNull.Value ? null : (decimal?)value;
            }

            set { Row["Koszt_Wysylki"] = value == null ? DBNull.Value : (object)value; }
        }

        public decimal? Koszt_Wysylki_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (decimal?)Row["Koszt_Wysylki", DataRowVersion.Original] : (decimal?)Row["Koszt_Wysylki"];

        public byte[] AS_Typy_Kart_Id{
            get {
                var value = Row["AS_Typy_Kart_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Typy_Kart_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Typy_Kart_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Typy_Kart_Id", DataRowVersion.Original] : (byte[])Row["AS_Typy_Kart_Id"];

        public byte[] Uzytkownik_Karty{
            get {
                var value = Row["Uzytkownik_Karty"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Uzytkownik_Karty"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Uzytkownik_Karty_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Uzytkownik_Karty", DataRowVersion.Original] : (byte[])Row["Uzytkownik_Karty"];

        public string Nazwa_Na_Karcie{
            get {
                var value = Row["Nazwa_Na_Karcie"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Nazwa_Na_Karcie"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Nazwa_Na_Karcie_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Nazwa_Na_Karcie", DataRowVersion.Original] : (string)Row["Nazwa_Na_Karcie"];

        public byte? Sposob_Dostarczenia_Karty{
            get {
                var value = Row["Sposob_Dostarczenia_Karty"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Sposob_Dostarczenia_Karty"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Sposob_Dostarczenia_Karty_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Sposob_Dostarczenia_Karty", DataRowVersion.Original] : (byte?)Row["Sposob_Dostarczenia_Karty"];

        public byte? Okres{
            get {
                var value = Row["Okres"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Okres"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Okres_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Okres", DataRowVersion.Original] : (byte?)Row["Okres"];

        public byte[] AS_Jednostka_Banku_Id{
            get {
                var value = Row["AS_Jednostka_Banku_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Jednostka_Banku_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Jednostka_Banku_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Jednostka_Banku_Id", DataRowVersion.Original] : (byte[])Row["AS_Jednostka_Banku_Id"];

        public int? SDZ_Kraj{
            get {
                var value = Row["SDZ_Kraj"];
                return value == DBNull.Value ? null : (int?)value;
            }

            set { Row["SDZ_Kraj"] = value == null ? DBNull.Value : (object)value; }
        }

        public int? SDZ_Kraj_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (int?)Row["SDZ_Kraj", DataRowVersion.Original] : (int?)Row["SDZ_Kraj"];

        public int? SDZ_Typ_Dokumentu{
            get {
                var value = Row["SDZ_Typ_Dokumentu"];
                return value == DBNull.Value ? null : (int?)value;
            }

            set { Row["SDZ_Typ_Dokumentu"] = value == null ? DBNull.Value : (object)value; }
        }

        public int? SDZ_Typ_Dokumentu_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (int?)Row["SDZ_Typ_Dokumentu", DataRowVersion.Original] : (int?)Row["SDZ_Typ_Dokumentu"];

        public int? SDZ_Wersja{
            get {
                var value = Row["SDZ_Wersja"];
                return value == DBNull.Value ? null : (int?)value;
            }

            set { Row["SDZ_Wersja"] = value == null ? DBNull.Value : (object)value; }
        }

        public int? SDZ_Wersja_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (int?)Row["SDZ_Wersja", DataRowVersion.Original] : (int?)Row["SDZ_Wersja"];

        public string SDZ_Numer_Dokumentu{
            get {
                var value = Row["SDZ_Numer_Dokumentu"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["SDZ_Numer_Dokumentu"] = value == null ? DBNull.Value : (object)value; }
        }

        public string SDZ_Numer_Dokumentu_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["SDZ_Numer_Dokumentu", DataRowVersion.Original] : (string)Row["SDZ_Numer_Dokumentu"];

        public string SDZ_Nazwisko{
            get {
                var value = Row["SDZ_Nazwisko"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["SDZ_Nazwisko"] = value == null ? DBNull.Value : (object)value; }
        }

        public string SDZ_Nazwisko_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["SDZ_Nazwisko", DataRowVersion.Original] : (string)Row["SDZ_Nazwisko"];

        public string SDZ_Imie{
            get {
                var value = Row["SDZ_Imie"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["SDZ_Imie"] = value == null ? DBNull.Value : (object)value; }
        }

        public string SDZ_Imie_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["SDZ_Imie", DataRowVersion.Original] : (string)Row["SDZ_Imie"];

        public string SDZ_Numer_Ewidencyjny{
            get {
                var value = Row["SDZ_Numer_Ewidencyjny"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["SDZ_Numer_Ewidencyjny"] = value == null ? DBNull.Value : (object)value; }
        }

        public string SDZ_Numer_Ewidencyjny_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["SDZ_Numer_Ewidencyjny", DataRowVersion.Original] : (string)Row["SDZ_Numer_Ewidencyjny"];

        public DateTime? SDZ_Data_Wykreslenia{
            get {
                var value = Row["SDZ_Data_Wykreslenia"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["SDZ_Data_Wykreslenia"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? SDZ_Data_Wykreslenia_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["SDZ_Data_Wykreslenia", DataRowVersion.Original] : (DateTime?)Row["SDZ_Data_Wykreslenia"];

        public byte? SDZ_Noname{
            get {
                var value = Row["SDZ_Noname"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["SDZ_Noname"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? SDZ_Noname_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["SDZ_Noname", DataRowVersion.Original] : (byte?)Row["SDZ_Noname"];

        public byte? SDZ_New_Document{
            get {
                var value = Row["SDZ_New_Document"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["SDZ_New_Document"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? SDZ_New_Document_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["SDZ_New_Document", DataRowVersion.Original] : (byte?)Row["SDZ_New_Document"];

        public string Adres{
            get {
                var value = Row["Adres"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Adres"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Adres_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Adres", DataRowVersion.Original] : (string)Row["Adres"];

        public byte[] A_Rejestr_Awiz_Id{
            get {
                var value = Row["A_Rejestr_Awiz_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Rejestr_Awiz_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Rejestr_Awiz_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Rejestr_Awiz_Id", DataRowVersion.Original] : (byte[])Row["A_Rejestr_Awiz_Id"];

        public byte[] AS_Powod_Blokady_Karty_Id{
            get {
                var value = Row["AS_Powod_Blokady_Karty_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Powod_Blokady_Karty_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Powod_Blokady_Karty_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Powod_Blokady_Karty_Id", DataRowVersion.Original] : (byte[])Row["AS_Powod_Blokady_Karty_Id"];

        public byte[] A_Dyspozycja_Powody_Id{
            get {
                var value = Row["A_Dyspozycja_Powody_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Dyspozycja_Powody_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Dyspozycja_Powody_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Dyspozycja_Powody_Id", DataRowVersion.Original] : (byte[])Row["A_Dyspozycja_Powody_Id"];

        public string Ulica_N{
            get {
                var value = Row["Ulica_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Ulica_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Ulica_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Ulica_N", DataRowVersion.Original] : (string)Row["Ulica_N"];

        public string Nr_Domu_N{
            get {
                var value = Row["Nr_Domu_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Nr_Domu_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Nr_Domu_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Nr_Domu_N", DataRowVersion.Original] : (string)Row["Nr_Domu_N"];

        public string Nr_Lokalu_N{
            get {
                var value = Row["Nr_Lokalu_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Nr_Lokalu_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Nr_Lokalu_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Nr_Lokalu_N", DataRowVersion.Original] : (string)Row["Nr_Lokalu_N"];

        public string Miejscowosc_N{
            get {
                var value = Row["Miejscowosc_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Miejscowosc_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Miejscowosc_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Miejscowosc_N", DataRowVersion.Original] : (string)Row["Miejscowosc_N"];

        public string Kod_Pocztowy_N{
            get {
                var value = Row["Kod_Pocztowy_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Kod_Pocztowy_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Kod_Pocztowy_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Kod_Pocztowy_N", DataRowVersion.Original] : (string)Row["Kod_Pocztowy_N"];

        public string Poczta_N{
            get {
                var value = Row["Poczta_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Poczta_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Poczta_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Poczta_N", DataRowVersion.Original] : (string)Row["Poczta_N"];

        public string Wojewodztwo{
            get {
                var value = Row["Wojewodztwo"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Wojewodztwo"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Wojewodztwo_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Wojewodztwo", DataRowVersion.Original] : (string)Row["Wojewodztwo"];

        public string Wojewodztwo_N{
            get {
                var value = Row["Wojewodztwo_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Wojewodztwo_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Wojewodztwo_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Wojewodztwo_N", DataRowVersion.Original] : (string)Row["Wojewodztwo_N"];

        public byte? Zmien_Adres{
            get {
                var value = Row["Zmien_Adres"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zmien_Adres"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zmien_Adres_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zmien_Adres", DataRowVersion.Original] : (byte?)Row["Zmien_Adres"];

        public byte? Zmien_Email{
            get {
                var value = Row["Zmien_Email"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zmien_Email"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zmien_Email_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zmien_Email", DataRowVersion.Original] : (byte?)Row["Zmien_Email"];

        public byte[] AS_Kraj_Id{
            get {
                var value = Row["AS_Kraj_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Kraj_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Kraj_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Kraj_Id", DataRowVersion.Original] : (byte[])Row["AS_Kraj_Id"];

        public byte[] AS_Kraj_N_Id{
            get {
                var value = Row["AS_Kraj_N_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Kraj_N_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Kraj_N_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Kraj_N_Id", DataRowVersion.Original] : (byte[])Row["AS_Kraj_N_Id"];

        public string Adres_Email_N{
            get {
                var value = Row["Adres_Email_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Adres_Email_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Adres_Email_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Adres_Email_N", DataRowVersion.Original] : (string)Row["Adres_Email_N"];

        public byte? Zmien_Adres_Kartoteka{
            get {
                var value = Row["Zmien_Adres_Kartoteka"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zmien_Adres_Kartoteka"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zmien_Adres_Kartoteka_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zmien_Adres_Kartoteka", DataRowVersion.Original] : (byte?)Row["Zmien_Adres_Kartoteka"];

        public byte? Zmien_Tel_Stacjonarny{
            get {
                var value = Row["Zmien_Tel_Stacjonarny"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zmien_Tel_Stacjonarny"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zmien_Tel_Stacjonarny_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zmien_Tel_Stacjonarny", DataRowVersion.Original] : (byte?)Row["Zmien_Tel_Stacjonarny"];

        public byte? Zmien_Tel_Kom{
            get {
                var value = Row["Zmien_Tel_Kom"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zmien_Tel_Kom"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zmien_Tel_Kom_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zmien_Tel_Kom", DataRowVersion.Original] : (byte?)Row["Zmien_Tel_Kom"];

        public byte? Zmien_Tel_SMS{
            get {
                var value = Row["Zmien_Tel_SMS"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zmien_Tel_SMS"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zmien_Tel_SMS_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zmien_Tel_SMS", DataRowVersion.Original] : (byte?)Row["Zmien_Tel_SMS"];

        public byte? Zmien_Tel_Sluzbowy{
            get {
                var value = Row["Zmien_Tel_Sluzbowy"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zmien_Tel_Sluzbowy"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zmien_Tel_Sluzbowy_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zmien_Tel_Sluzbowy", DataRowVersion.Original] : (byte?)Row["Zmien_Tel_Sluzbowy"];

        public string Tel_Stacjonarny{
            get {
                var value = Row["Tel_Stacjonarny"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Tel_Stacjonarny"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Tel_Stacjonarny_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Tel_Stacjonarny", DataRowVersion.Original] : (string)Row["Tel_Stacjonarny"];

        public string Tel_Stacjonarny_N{
            get {
                var value = Row["Tel_Stacjonarny_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Tel_Stacjonarny_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Tel_Stacjonarny_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Tel_Stacjonarny_N", DataRowVersion.Original] : (string)Row["Tel_Stacjonarny_N"];

        public string Tel_Kom{
            get {
                var value = Row["Tel_Kom"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Tel_Kom"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Tel_Kom_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Tel_Kom", DataRowVersion.Original] : (string)Row["Tel_Kom"];

        public string Tel_Kom_N{
            get {
                var value = Row["Tel_Kom_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Tel_Kom_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Tel_Kom_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Tel_Kom_N", DataRowVersion.Original] : (string)Row["Tel_Kom_N"];

        public string Tel_SMS{
            get {
                var value = Row["Tel_SMS"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Tel_SMS"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Tel_SMS_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Tel_SMS", DataRowVersion.Original] : (string)Row["Tel_SMS"];

        public string Tel_SMS_N{
            get {
                var value = Row["Tel_SMS_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Tel_SMS_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Tel_SMS_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Tel_SMS_N", DataRowVersion.Original] : (string)Row["Tel_SMS_N"];

        public string Tel_Sluzbowy{
            get {
                var value = Row["Tel_Sluzbowy"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Tel_Sluzbowy"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Tel_Sluzbowy_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Tel_Sluzbowy", DataRowVersion.Original] : (string)Row["Tel_Sluzbowy"];

        public string Tel_Sluzbowy_N{
            get {
                var value = Row["Tel_Sluzbowy_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Tel_Sluzbowy_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Tel_Sluzbowy_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Tel_Sluzbowy_N", DataRowVersion.Original] : (string)Row["Tel_Sluzbowy_N"];

        public byte? Kanal_Autoryzacji{
            get {
                var value = Row["Kanal_Autoryzacji"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Kanal_Autoryzacji"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Kanal_Autoryzacji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Kanal_Autoryzacji", DataRowVersion.Original] : (byte?)Row["Kanal_Autoryzacji"];

        public int? Kod_Ilosc_Wysylek{
            get {
                var value = Row["Kod_Ilosc_Wysylek"];
                return value == DBNull.Value ? null : (int?)value;
            }

            set { Row["Kod_Ilosc_Wysylek"] = value == null ? DBNull.Value : (object)value; }
        }

        public int? Kod_Ilosc_Wysylek_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (int?)Row["Kod_Ilosc_Wysylek", DataRowVersion.Original] : (int?)Row["Kod_Ilosc_Wysylek"];

        public int? Kod_Ilosc_Weryfikacji{
            get {
                var value = Row["Kod_Ilosc_Weryfikacji"];
                return value == DBNull.Value ? null : (int?)value;
            }

            set { Row["Kod_Ilosc_Weryfikacji"] = value == null ? DBNull.Value : (object)value; }
        }

        public int? Kod_Ilosc_Weryfikacji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (int?)Row["Kod_Ilosc_Weryfikacji", DataRowVersion.Original] : (int?)Row["Kod_Ilosc_Weryfikacji"];

        public string Kod_Autoryzacji{
            get {
                var value = Row["Kod_Autoryzacji"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Kod_Autoryzacji"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Kod_Autoryzacji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Kod_Autoryzacji", DataRowVersion.Original] : (string)Row["Kod_Autoryzacji"];

        public string Kod_Autoryzacji_Spr{
            get {
                var value = Row["Kod_Autoryzacji_Spr"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Kod_Autoryzacji_Spr"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Kod_Autoryzacji_Spr_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Kod_Autoryzacji_Spr", DataRowVersion.Original] : (string)Row["Kod_Autoryzacji_Spr"];

        public byte? Status_Autoryzacji{
            get {
                var value = Row["Status_Autoryzacji"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Status_Autoryzacji"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Status_Autoryzacji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Status_Autoryzacji", DataRowVersion.Original] : (byte?)Row["Status_Autoryzacji"];

        public int? Quantity{
            get {
                var value = Row["Quantity"];
                return value == DBNull.Value ? null : (int?)value;
            }

            set { Row["Quantity"] = value == null ? DBNull.Value : (object)value; }
        }

        public int? Quantity_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (int?)Row["Quantity", DataRowVersion.Original] : (int?)Row["Quantity"];

        public decimal? Kwota_Awizacji{
            get {
                var value = Row["Kwota_Awizacji"];
                return value == DBNull.Value ? null : (decimal?)value;
            }

            set { Row["Kwota_Awizacji"] = value == null ? DBNull.Value : (object)value; }
        }

        public decimal? Kwota_Awizacji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (decimal?)Row["Kwota_Awizacji", DataRowVersion.Original] : (decimal?)Row["Kwota_Awizacji"];

        public DateTime? Data_Awizacji{
            get {
                var value = Row["Data_Awizacji"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Data_Awizacji"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Data_Awizacji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Data_Awizacji", DataRowVersion.Original] : (DateTime?)Row["Data_Awizacji"];

        public byte[] AS_Slownik_Walut_Id{
            get {
                var value = Row["AS_Slownik_Walut_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Slownik_Walut_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Slownik_Walut_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Slownik_Walut_Id", DataRowVersion.Original] : (byte[])Row["AS_Slownik_Walut_Id"];

        public DateTime? Przyjecie_Data{
            get {
                var value = Row["Przyjecie_Data"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Przyjecie_Data"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Przyjecie_Data_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Przyjecie_Data", DataRowVersion.Original] : (DateTime?)Row["Przyjecie_Data"];

        public DateTime? Przyjecie_Godz{
            get {
                var value = Row["Przyjecie_Godz"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Przyjecie_Godz"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Przyjecie_Godz_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Przyjecie_Godz", DataRowVersion.Original] : (DateTime?)Row["Przyjecie_Godz"];

        public byte? PWK_Kategoria_Akceptacji{
            get {
                var value = Row["PWK_Kategoria_Akceptacji"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["PWK_Kategoria_Akceptacji"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? PWK_Kategoria_Akceptacji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["PWK_Kategoria_Akceptacji", DataRowVersion.Original] : (byte?)Row["PWK_Kategoria_Akceptacji"];

        public byte? Init_Load{
            get {
                var value = Row["Init_Load"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Init_Load"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Init_Load_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Init_Load", DataRowVersion.Original] : (byte?)Row["Init_Load"];

        public string Nadawca_Adres{
            get {
                var value = Row["Nadawca_Adres"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Nadawca_Adres"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Nadawca_Adres_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Nadawca_Adres", DataRowVersion.Original] : (string)Row["Nadawca_Adres"];

        public string Imie_Drugie{
            get {
                var value = Row["Imie_Drugie"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Imie_Drugie"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Imie_Drugie_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Imie_Drugie", DataRowVersion.Original] : (string)Row["Imie_Drugie"];

        public string Imie_Drugie_N{
            get {
                var value = Row["Imie_Drugie_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Imie_Drugie_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Imie_Drugie_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Imie_Drugie_N", DataRowVersion.Original] : (string)Row["Imie_Drugie_N"];

        public string Imie_N{
            get {
                var value = Row["Imie_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Imie_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Imie_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Imie_N", DataRowVersion.Original] : (string)Row["Imie_N"];

        public string Nazwisko_N{
            get {
                var value = Row["Nazwisko_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Nazwisko_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Nazwisko_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Nazwisko_N", DataRowVersion.Original] : (string)Row["Nazwisko_N"];

        public string Imie_Matki{
            get {
                var value = Row["Imie_Matki"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Imie_Matki"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Imie_Matki_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Imie_Matki", DataRowVersion.Original] : (string)Row["Imie_Matki"];

        public string Imie_Matki_N{
            get {
                var value = Row["Imie_Matki_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Imie_Matki_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Imie_Matki_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Imie_Matki_N", DataRowVersion.Original] : (string)Row["Imie_Matki_N"];

        public string Imie_Ojca{
            get {
                var value = Row["Imie_Ojca"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Imie_Ojca"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Imie_Ojca_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Imie_Ojca", DataRowVersion.Original] : (string)Row["Imie_Ojca"];

        public string Imie_Ojca_N{
            get {
                var value = Row["Imie_Ojca_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Imie_Ojca_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Imie_Ojca_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Imie_Ojca_N", DataRowVersion.Original] : (string)Row["Imie_Ojca_N"];

        public string REGON_PESEL{
            get {
                var value = Row["REGON_PESEL"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["REGON_PESEL"] = value == null ? DBNull.Value : (object)value; }
        }

        public string REGON_PESEL_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["REGON_PESEL", DataRowVersion.Original] : (string)Row["REGON_PESEL"];

        public byte[] Plec_Id{
            get {
                var value = Row["Plec_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Plec_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Plec_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Plec_Id", DataRowVersion.Original] : (byte[])Row["Plec_Id"];

        public byte[] Plec_N_Id{
            get {
                var value = Row["Plec_N_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Plec_N_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Plec_N_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Plec_N_Id", DataRowVersion.Original] : (byte[])Row["Plec_N_Id"];

        public DateTime? Data_Ur{
            get {
                var value = Row["Data_Ur"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Data_Ur"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Data_Ur_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Data_Ur", DataRowVersion.Original] : (DateTime?)Row["Data_Ur"];

        public DateTime? Data_Ur_N{
            get {
                var value = Row["Data_Ur_N"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Data_Ur_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Data_Ur_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Data_Ur_N", DataRowVersion.Original] : (DateTime?)Row["Data_Ur_N"];

        public string Miejsce_Ur{
            get {
                var value = Row["Miejsce_Ur"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Miejsce_Ur"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Miejsce_Ur_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Miejsce_Ur", DataRowVersion.Original] : (string)Row["Miejsce_Ur"];

        public string Miejsce_Ur_N{
            get {
                var value = Row["Miejsce_Ur_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Miejsce_Ur_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Miejsce_Ur_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Miejsce_Ur_N", DataRowVersion.Original] : (string)Row["Miejsce_Ur_N"];

        public string Dowod_Nr{
            get {
                var value = Row["Dowod_Nr"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Dowod_Nr"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Dowod_Nr_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Dowod_Nr", DataRowVersion.Original] : (string)Row["Dowod_Nr"];

        public string Dowod_Nr_N{
            get {
                var value = Row["Dowod_Nr_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Dowod_Nr_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Dowod_Nr_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Dowod_Nr_N", DataRowVersion.Original] : (string)Row["Dowod_Nr_N"];

        public DateTime? Dowod_Wazny{
            get {
                var value = Row["Dowod_Wazny"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Dowod_Wazny"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Dowod_Wazny_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Dowod_Wazny", DataRowVersion.Original] : (DateTime?)Row["Dowod_Wazny"];

        public DateTime? Dowod_Wazny_N{
            get {
                var value = Row["Dowod_Wazny_N"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Dowod_Wazny_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Dowod_Wazny_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Dowod_Wazny_N", DataRowVersion.Original] : (DateTime?)Row["Dowod_Wazny_N"];

        public DateTime? Dowod_Wydany{
            get {
                var value = Row["Dowod_Wydany"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Dowod_Wydany"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Dowod_Wydany_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Dowod_Wydany", DataRowVersion.Original] : (DateTime?)Row["Dowod_Wydany"];

        public DateTime? Dowod_Wydany_N{
            get {
                var value = Row["Dowod_Wydany_N"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Dowod_Wydany_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Dowod_Wydany_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Dowod_Wydany_N", DataRowVersion.Original] : (DateTime?)Row["Dowod_Wydany_N"];

        public byte[] A_Pakiet_Id{
            get {
                var value = Row["A_Pakiet_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Pakiet_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Pakiet_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Pakiet_Id", DataRowVersion.Original] : (byte[])Row["A_Pakiet_Id"];

        public byte[] A_Pakiet_Id_N{
            get {
                var value = Row["A_Pakiet_Id_N"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Pakiet_Id_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Pakiet_Id_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Pakiet_Id_N", DataRowVersion.Original] : (byte[])Row["A_Pakiet_Id_N"];

        public byte[] AS_Rodzaj_Dok_Tozsamosci_Id{
            get {
                var value = Row["AS_Rodzaj_Dok_Tozsamosci_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Rodzaj_Dok_Tozsamosci_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Rodzaj_Dok_Tozsamosci_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Rodzaj_Dok_Tozsamosci_Id", DataRowVersion.Original] : (byte[])Row["AS_Rodzaj_Dok_Tozsamosci_Id"];

        public byte? Dyspozycja_Wysokokwotowa{
            get {
                var value = Row["Dyspozycja_Wysokokwotowa"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Dyspozycja_Wysokokwotowa"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Dyspozycja_Wysokokwotowa_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Dyspozycja_Wysokokwotowa", DataRowVersion.Original] : (byte?)Row["Dyspozycja_Wysokokwotowa"];

        public byte? Dyspozycja_Na_Dzien{
            get {
                var value = Row["Dyspozycja_Na_Dzien"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Dyspozycja_Na_Dzien"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Dyspozycja_Na_Dzien_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Dyspozycja_Na_Dzien", DataRowVersion.Original] : (byte?)Row["Dyspozycja_Na_Dzien"];

        public byte? Dzien_Dokumentu{
            get {
                var value = Row["Dzien_Dokumentu"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Dzien_Dokumentu"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Dzien_Dokumentu_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Dzien_Dokumentu", DataRowVersion.Original] : (byte?)Row["Dzien_Dokumentu"];

        public byte[] AS_Cykle_Kart_Id{
            get {
                var value = Row["AS_Cykle_Kart_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Cykle_Kart_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Cykle_Kart_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Cykle_Kart_Id", DataRowVersion.Original] : (byte[])Row["AS_Cykle_Kart_Id"];

        public byte[] Prev_WFlow_Id{
            get {
                var value = Row["Prev_WFlow_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Prev_WFlow_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Prev_WFlow_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Prev_WFlow_Id", DataRowVersion.Original] : (byte[])Row["Prev_WFlow_Id"];

        public byte[] Rachunek_Contract{
            get {
                var value = Row["Rachunek_Contract"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Rachunek_Contract"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Rachunek_Contract_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Rachunek_Contract", DataRowVersion.Original] : (byte[])Row["Rachunek_Contract"];

        public byte[] Kredyt_Contract{
            get {
                var value = Row["Kredyt_Contract"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Kredyt_Contract"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Kredyt_Contract_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Kredyt_Contract", DataRowVersion.Original] : (byte[])Row["Kredyt_Contract"];

        public byte? Forma_Otrzymywania_Wyciagu{
            get {
                var value = Row["Forma_Otrzymywania_Wyciagu"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Forma_Otrzymywania_Wyciagu"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Forma_Otrzymywania_Wyciagu_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Forma_Otrzymywania_Wyciagu", DataRowVersion.Original] : (byte?)Row["Forma_Otrzymywania_Wyciagu"];

        public byte? Forma_Wysylki_Harmo{
            get {
                var value = Row["Forma_Wysylki_Harmo"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Forma_Wysylki_Harmo"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Forma_Wysylki_Harmo_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Forma_Wysylki_Harmo", DataRowVersion.Original] : (byte?)Row["Forma_Wysylki_Harmo"];

        public byte? Forma_Wysylki_Harmo_N{
            get {
                var value = Row["Forma_Wysylki_Harmo_N"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Forma_Wysylki_Harmo_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Forma_Wysylki_Harmo_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Forma_Wysylki_Harmo_N", DataRowVersion.Original] : (byte?)Row["Forma_Wysylki_Harmo_N"];

        public string Karta_System{
            get {
                var value = Row["Karta_System"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Karta_System"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Karta_System_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Karta_System", DataRowVersion.Original] : (string)Row["Karta_System"];

        public byte? Dystrybucja_Email{
            get {
                var value = Row["Dystrybucja_Email"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Dystrybucja_Email"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Dystrybucja_Email_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Dystrybucja_Email", DataRowVersion.Original] : (byte?)Row["Dystrybucja_Email"];

        public string Email_Wyciagu{
            get {
                var value = Row["Email_Wyciagu"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Email_Wyciagu"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Email_Wyciagu_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Email_Wyciagu", DataRowVersion.Original] : (string)Row["Email_Wyciagu"];

        public decimal? Dostepne_Srodki{
            get {
                var value = Row["Dostepne_Srodki"];
                return value == DBNull.Value ? null : (decimal?)value;
            }

            set { Row["Dostepne_Srodki"] = value == null ? DBNull.Value : (object)value; }
        }

        public decimal? Dostepne_Srodki_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (decimal?)Row["Dostepne_Srodki", DataRowVersion.Original] : (decimal?)Row["Dostepne_Srodki"];

        public byte[] A_Wyciagi_Bankowe_Id{
            get {
                var value = Row["A_Wyciagi_Bankowe_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Wyciagi_Bankowe_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Wyciagi_Bankowe_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Wyciagi_Bankowe_Id", DataRowVersion.Original] : (byte[])Row["A_Wyciagi_Bankowe_Id"];

        public byte[] AS_Typ_Odstepstwa_Id{
            get {
                var value = Row["AS_Typ_Odstepstwa_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Typ_Odstepstwa_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Typ_Odstepstwa_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Typ_Odstepstwa_Id", DataRowVersion.Original] : (byte[])Row["AS_Typ_Odstepstwa_Id"];

        public byte? Odstepstwo_Kwotowe{
            get {
                var value = Row["Odstepstwo_Kwotowe"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Odstepstwo_Kwotowe"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Odstepstwo_Kwotowe_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Odstepstwo_Kwotowe", DataRowVersion.Original] : (byte?)Row["Odstepstwo_Kwotowe"];

        public decimal? Kwota_Odstepstwa{
            get {
                var value = Row["Kwota_Odstepstwa"];
                return value == DBNull.Value ? null : (decimal?)value;
            }

            set { Row["Kwota_Odstepstwa"] = value == null ? DBNull.Value : (object)value; }
        }

        public decimal? Kwota_Odstepstwa_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (decimal?)Row["Kwota_Odstepstwa", DataRowVersion.Original] : (decimal?)Row["Kwota_Odstepstwa"];

        public byte? Powod_Odstepstwa{
            get {
                var value = Row["Powod_Odstepstwa"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Powod_Odstepstwa"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Powod_Odstepstwa_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Powod_Odstepstwa", DataRowVersion.Original] : (byte?)Row["Powod_Odstepstwa"];

        public string Odstepstwo_Blad_Pracownik{
            get {
                var value = Row["Odstepstwo_Blad_Pracownik"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Odstepstwo_Blad_Pracownik"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Odstepstwo_Blad_Pracownik_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Odstepstwo_Blad_Pracownik", DataRowVersion.Original] : (string)Row["Odstepstwo_Blad_Pracownik"];

        public string Numer_Zgloszenia_Redmine{
            get {
                var value = Row["Numer_Zgloszenia_Redmine"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Numer_Zgloszenia_Redmine"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Numer_Zgloszenia_Redmine_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Numer_Zgloszenia_Redmine", DataRowVersion.Original] : (string)Row["Numer_Zgloszenia_Redmine"];

        public byte[] AS_Kategoria_Dysp_Zapytaj_Id{
            get {
                var value = Row["AS_Kategoria_Dysp_Zapytaj_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Kategoria_Dysp_Zapytaj_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Kategoria_Dysp_Zapytaj_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Kategoria_Dysp_Zapytaj_Id", DataRowVersion.Original] : (byte[])Row["AS_Kategoria_Dysp_Zapytaj_Id"];

        public byte[] AS_Podkategoria_Dysp_Zapyt_Id{
            get {
                var value = Row["AS_Podkategoria_Dysp_Zapyt_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Podkategoria_Dysp_Zapyt_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Podkategoria_Dysp_Zapyt_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Podkategoria_Dysp_Zapyt_Id", DataRowVersion.Original] : (byte[])Row["AS_Podkategoria_Dysp_Zapyt_Id"];

        public string WKR_Decyzja{
            get {
                var value = Row["WKR_Decyzja"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["WKR_Decyzja"] = value == null ? DBNull.Value : (object)value; }
        }

        public string WKR_Decyzja_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["WKR_Decyzja", DataRowVersion.Original] : (string)Row["WKR_Decyzja"];

        public string RRSO{
            get {
                var value = Row["RRSO"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["RRSO"] = value == null ? DBNull.Value : (object)value; }
        }

        public string RRSO_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["RRSO", DataRowVersion.Original] : (string)Row["RRSO"];

        public byte[] A_Komentarz_Id{
            get {
                var value = Row["A_Komentarz_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Komentarz_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Komentarz_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Komentarz_Id", DataRowVersion.Original] : (byte[])Row["A_Komentarz_Id"];

        public byte[] A_Call_Autoryzacja_Id{
            get {
                var value = Row["A_Call_Autoryzacja_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Call_Autoryzacja_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Call_Autoryzacja_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Call_Autoryzacja_Id", DataRowVersion.Original] : (byte[])Row["A_Call_Autoryzacja_Id"];

        public byte? Zweryfikowano_Poprawnie{
            get {
                var value = Row["Zweryfikowano_Poprawnie"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zweryfikowano_Poprawnie"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zweryfikowano_Poprawnie_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zweryfikowano_Poprawnie", DataRowVersion.Original] : (byte?)Row["Zweryfikowano_Poprawnie"];

        public string Wystawca_Dokumentu{
            get {
                var value = Row["Wystawca_Dokumentu"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Wystawca_Dokumentu"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Wystawca_Dokumentu_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Wystawca_Dokumentu", DataRowVersion.Original] : (string)Row["Wystawca_Dokumentu"];

        public string Wystawca_Dokumentu_N{
            get {
                var value = Row["Wystawca_Dokumentu_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Wystawca_Dokumentu_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Wystawca_Dokumentu_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Wystawca_Dokumentu_N", DataRowVersion.Original] : (string)Row["Wystawca_Dokumentu_N"];

        public byte[] AS_Wojewodztwa_Id_N{
            get {
                var value = Row["AS_Wojewodztwa_Id_N"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Wojewodztwa_Id_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Wojewodztwa_Id_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Wojewodztwa_Id_N", DataRowVersion.Original] : (byte[])Row["AS_Wojewodztwa_Id_N"];

        public byte? Sposob_Dostarczenia_Umowy{
            get {
                var value = Row["Sposob_Dostarczenia_Umowy"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Sposob_Dostarczenia_Umowy"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Sposob_Dostarczenia_Umowy_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Sposob_Dostarczenia_Umowy", DataRowVersion.Original] : (byte?)Row["Sposob_Dostarczenia_Umowy"];

        public byte[] A_Przesylka_Id{
            get {
                var value = Row["A_Przesylka_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Przesylka_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Przesylka_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Przesylka_Id", DataRowVersion.Original] : (byte[])Row["A_Przesylka_Id"];

        public byte[] AS_Profil_Klienta_Id{
            get {
                var value = Row["AS_Profil_Klienta_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Profil_Klienta_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Profil_Klienta_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Profil_Klienta_Id", DataRowVersion.Original] : (byte[])Row["AS_Profil_Klienta_Id"];

        public byte[] Opiekun_Company_Id{
            get {
                var value = Row["Opiekun_Company_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Opiekun_Company_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Opiekun_Company_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Opiekun_Company_Id", DataRowVersion.Original] : (byte[])Row["Opiekun_Company_Id"];

        public byte? Typ_Umowy{
            get {
                var value = Row["Typ_Umowy"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Typ_Umowy"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Typ_Umowy_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Typ_Umowy", DataRowVersion.Original] : (byte?)Row["Typ_Umowy"];

        public byte[] AS_Umowa_Pakietowa_Id{
            get {
                var value = Row["AS_Umowa_Pakietowa_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Umowa_Pakietowa_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Umowa_Pakietowa_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Umowa_Pakietowa_Id", DataRowVersion.Original] : (byte[])Row["AS_Umowa_Pakietowa_Id"];

        public byte? Pivotal_Bool_1{
            get {
                var value = Row["Pivotal_Bool_1"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Pivotal_Bool_1"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Pivotal_Bool_1_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Pivotal_Bool_1", DataRowVersion.Original] : (byte?)Row["Pivotal_Bool_1"];

        public byte? Pivotal_Bool_2{
            get {
                var value = Row["Pivotal_Bool_2"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Pivotal_Bool_2"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Pivotal_Bool_2_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Pivotal_Bool_2", DataRowVersion.Original] : (byte?)Row["Pivotal_Bool_2"];

        public byte? Pivotal_Bool_3{
            get {
                var value = Row["Pivotal_Bool_3"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Pivotal_Bool_3"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Pivotal_Bool_3_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Pivotal_Bool_3", DataRowVersion.Original] : (byte?)Row["Pivotal_Bool_3"];

        public byte? Pivotal_Bool_4{
            get {
                var value = Row["Pivotal_Bool_4"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Pivotal_Bool_4"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Pivotal_Bool_4_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Pivotal_Bool_4", DataRowVersion.Original] : (byte?)Row["Pivotal_Bool_4"];

        public string Pivotal_Text_254_1{
            get {
                var value = Row["Pivotal_Text_254_1"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Pivotal_Text_254_1"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Pivotal_Text_254_1_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Pivotal_Text_254_1", DataRowVersion.Original] : (string)Row["Pivotal_Text_254_1"];

        public string Pivotal_Text_254_2{
            get {
                var value = Row["Pivotal_Text_254_2"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Pivotal_Text_254_2"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Pivotal_Text_254_2_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Pivotal_Text_254_2", DataRowVersion.Original] : (string)Row["Pivotal_Text_254_2"];

        public string Pivotal_Text_254_3{
            get {
                var value = Row["Pivotal_Text_254_3"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Pivotal_Text_254_3"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Pivotal_Text_254_3_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Pivotal_Text_254_3", DataRowVersion.Original] : (string)Row["Pivotal_Text_254_3"];

        public string Pivotal_Text_254_4{
            get {
                var value = Row["Pivotal_Text_254_4"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Pivotal_Text_254_4"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Pivotal_Text_254_4_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Pivotal_Text_254_4", DataRowVersion.Original] : (string)Row["Pivotal_Text_254_4"];

        public byte[] Typ_ROR{
            get {
                var value = Row["Typ_ROR"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Typ_ROR"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Typ_ROR_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Typ_ROR", DataRowVersion.Original] : (byte[])Row["Typ_ROR"];

        public byte[] Pakiet_ROR{
            get {
                var value = Row["Pakiet_ROR"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Pakiet_ROR"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Pakiet_ROR_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Pakiet_ROR", DataRowVersion.Original] : (byte[])Row["Pakiet_ROR"];

        public byte? Typ_Wyciagu_ROR{
            get {
                var value = Row["Typ_Wyciagu_ROR"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Typ_Wyciagu_ROR"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Typ_Wyciagu_ROR_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Typ_Wyciagu_ROR", DataRowVersion.Original] : (byte?)Row["Typ_Wyciagu_ROR"];

        public byte? Pivotal_Bool_5{
            get {
                var value = Row["Pivotal_Bool_5"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Pivotal_Bool_5"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Pivotal_Bool_5_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Pivotal_Bool_5", DataRowVersion.Original] : (byte?)Row["Pivotal_Bool_5"];

        public byte? Pivotal_Bool_6{
            get {
                var value = Row["Pivotal_Bool_6"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Pivotal_Bool_6"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Pivotal_Bool_6_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Pivotal_Bool_6", DataRowVersion.Original] : (byte?)Row["Pivotal_Bool_6"];

        public byte? Pivotal_Bool_7{
            get {
                var value = Row["Pivotal_Bool_7"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Pivotal_Bool_7"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Pivotal_Bool_7_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Pivotal_Bool_7", DataRowVersion.Original] : (byte?)Row["Pivotal_Bool_7"];

        public byte? Pivotal_Bool_8{
            get {
                var value = Row["Pivotal_Bool_8"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Pivotal_Bool_8"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Pivotal_Bool_8_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Pivotal_Bool_8", DataRowVersion.Original] : (byte?)Row["Pivotal_Bool_8"];

        public byte[] Typ_Konta{
            get {
                var value = Row["Typ_Konta"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Typ_Konta"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Typ_Konta_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Typ_Konta", DataRowVersion.Original] : (byte[])Row["Typ_Konta"];

        public byte? Sposob_Dostarczenie_Loginu{
            get {
                var value = Row["Sposob_Dostarczenie_Loginu"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Sposob_Dostarczenie_Loginu"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Sposob_Dostarczenie_Loginu_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Sposob_Dostarczenie_Loginu", DataRowVersion.Original] : (byte?)Row["Sposob_Dostarczenie_Loginu"];

        public byte? Kanal_Wysylki{
            get {
                var value = Row["Kanal_Wysylki"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Kanal_Wysylki"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Kanal_Wysylki_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Kanal_Wysylki", DataRowVersion.Original] : (byte?)Row["Kanal_Wysylki"];

        public byte? Typ_Adresu{
            get {
                var value = Row["Typ_Adresu"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Typ_Adresu"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Typ_Adresu_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Typ_Adresu", DataRowVersion.Original] : (byte?)Row["Typ_Adresu"];

        public byte? Typ_Wyciagu_KO{
            get {
                var value = Row["Typ_Wyciagu_KO"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Typ_Wyciagu_KO"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Typ_Wyciagu_KO_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Typ_Wyciagu_KO", DataRowVersion.Original] : (byte?)Row["Typ_Wyciagu_KO"];

        public byte? Sposob_Dostarczenie_Hasla{
            get {
                var value = Row["Sposob_Dostarczenie_Hasla"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Sposob_Dostarczenie_Hasla"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Sposob_Dostarczenie_Hasla_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Sposob_Dostarczenie_Hasla", DataRowVersion.Original] : (byte?)Row["Sposob_Dostarczenie_Hasla"];

        public byte[] AS_Blokada_Id{
            get {
                var value = Row["AS_Blokada_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Blokada_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Blokada_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Blokada_Id", DataRowVersion.Original] : (byte[])Row["AS_Blokada_Id"];

        public byte? Stan_Kompletacji{
            get {
                var value = Row["Stan_Kompletacji"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Stan_Kompletacji"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Stan_Kompletacji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Stan_Kompletacji", DataRowVersion.Original] : (byte?)Row["Stan_Kompletacji"];

        public byte[] Obywatelstwo{
            get {
                var value = Row["Obywatelstwo"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Obywatelstwo"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Obywatelstwo_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Obywatelstwo", DataRowVersion.Original] : (byte[])Row["Obywatelstwo"];

        public byte[] AS_Relacja_Klienta_Do_Banku_Id{
            get {
                var value = Row["AS_Relacja_Klienta_Do_Banku_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Relacja_Klienta_Do_Banku_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Relacja_Klienta_Do_Banku_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Relacja_Klienta_Do_Banku_Id", DataRowVersion.Original] : (byte[])Row["AS_Relacja_Klienta_Do_Banku_Id"];

        public byte[] Kraj_Urodzenia{
            get {
                var value = Row["Kraj_Urodzenia"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Kraj_Urodzenia"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Kraj_Urodzenia_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Kraj_Urodzenia", DataRowVersion.Original] : (byte[])Row["Kraj_Urodzenia"];

        public byte[] AS_Rodzaj_Dok_Tozsamosci_Id_D{
            get {
                var value = Row["AS_Rodzaj_Dok_Tozsamosci_Id_D"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Rodzaj_Dok_Tozsamosci_Id_D"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Rodzaj_Dok_Tozsamosci_Id_D_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Rodzaj_Dok_Tozsamosci_Id_D", DataRowVersion.Original] : (byte[])Row["AS_Rodzaj_Dok_Tozsamosci_Id_D"];

        public string Dowod_Nr_D{
            get {
                var value = Row["Dowod_Nr_D"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Dowod_Nr_D"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Dowod_Nr_D_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Dowod_Nr_D", DataRowVersion.Original] : (string)Row["Dowod_Nr_D"];

        public string Nazwisko_Panienskie_Matki{
            get {
                var value = Row["Nazwisko_Panienskie_Matki"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Nazwisko_Panienskie_Matki"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Nazwisko_Panienskie_Matki_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Nazwisko_Panienskie_Matki", DataRowVersion.Original] : (string)Row["Nazwisko_Panienskie_Matki"];

        public byte[] AS_Stany_Cywilne_Id{
            get {
                var value = Row["AS_Stany_Cywilne_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Stany_Cywilne_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Stany_Cywilne_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Stany_Cywilne_Id", DataRowVersion.Original] : (byte[])Row["AS_Stany_Cywilne_Id"];

        public byte? Student{
            get {
                var value = Row["Student"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Student"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Student_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Student", DataRowVersion.Original] : (byte?)Row["Student"];

        public byte? Rezydent{
            get {
                var value = Row["Rezydent"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Rezydent"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Rezydent_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Rezydent", DataRowVersion.Original] : (byte?)Row["Rezydent"];

        public byte[] Kraj_Rezydencji{
            get {
                var value = Row["Kraj_Rezydencji"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Kraj_Rezydencji"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Kraj_Rezydencji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Kraj_Rezydencji", DataRowVersion.Original] : (byte[])Row["Kraj_Rezydencji"];

        public byte? Obywatel_US{
            get {
                var value = Row["Obywatel_US"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Obywatel_US"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Obywatel_US_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Obywatel_US", DataRowVersion.Original] : (byte?)Row["Obywatel_US"];

        public byte? Podatek_US{
            get {
                var value = Row["Podatek_US"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Podatek_US"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Podatek_US_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Podatek_US", DataRowVersion.Original] : (byte?)Row["Podatek_US"];

        public string NIP_US{
            get {
                var value = Row["NIP_US"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["NIP_US"] = value == null ? DBNull.Value : (object)value; }
        }

        public string NIP_US_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["NIP_US", DataRowVersion.Original] : (string)Row["NIP_US"];

        public byte[] AS_Prefiks_Ulicy_Id{
            get {
                var value = Row["AS_Prefiks_Ulicy_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Prefiks_Ulicy_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Prefiks_Ulicy_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Prefiks_Ulicy_Id", DataRowVersion.Original] : (byte[])Row["AS_Prefiks_Ulicy_Id"];

        public byte[] AS_Wojewodztwa_Id{
            get {
                var value = Row["AS_Wojewodztwa_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Wojewodztwa_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Wojewodztwa_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Wojewodztwa_Id", DataRowVersion.Original] : (byte[])Row["AS_Wojewodztwa_Id"];

        public byte[] AS_Prefiks_Ulicy_Id_N{
            get {
                var value = Row["AS_Prefiks_Ulicy_Id_N"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Prefiks_Ulicy_Id_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Prefiks_Ulicy_Id_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Prefiks_Ulicy_Id_N", DataRowVersion.Original] : (byte[])Row["AS_Prefiks_Ulicy_Id_N"];

        public byte[] AS_Poz_Ryzyk_Klienta_Id{
            get {
                var value = Row["AS_Poz_Ryzyk_Klienta_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Poz_Ryzyk_Klienta_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Poz_Ryzyk_Klienta_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Poz_Ryzyk_Klienta_Id", DataRowVersion.Original] : (byte[])Row["AS_Poz_Ryzyk_Klienta_Id"];

        public string NIP{
            get {
                var value = Row["NIP"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["NIP"] = value == null ? DBNull.Value : (object)value; }
        }

        public string NIP_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["NIP", DataRowVersion.Original] : (string)Row["NIP"];

        public int? Pivotal_Int_1{
            get {
                var value = Row["Pivotal_Int_1"];
                return value == DBNull.Value ? null : (int?)value;
            }

            set { Row["Pivotal_Int_1"] = value == null ? DBNull.Value : (object)value; }
        }

        public int? Pivotal_Int_1_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (int?)Row["Pivotal_Int_1", DataRowVersion.Original] : (int?)Row["Pivotal_Int_1"];

        public byte[] A_MA_Zadanie_Id{
            get {
                var value = Row["A_MA_Zadanie_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_MA_Zadanie_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_MA_Zadanie_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_MA_Zadanie_Id", DataRowVersion.Original] : (byte[])Row["A_MA_Zadanie_Id"];

        public byte[] A_MA_Lead_Id{
            get {
                var value = Row["A_MA_Lead_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_MA_Lead_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_MA_Lead_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_MA_Lead_Id", DataRowVersion.Original] : (byte[])Row["A_MA_Lead_Id"];

        public byte? SDZ_Blokada{
            get {
                var value = Row["SDZ_Blokada"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["SDZ_Blokada"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? SDZ_Blokada_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["SDZ_Blokada", DataRowVersion.Original] : (byte?)Row["SDZ_Blokada"];

        public byte[] AV_Jednostka_Banku_Segment_Id{
            get {
                var value = Row["AV_Jednostka_Banku_Segment_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AV_Jednostka_Banku_Segment_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AV_Jednostka_Banku_Segment_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AV_Jednostka_Banku_Segment_Id", DataRowVersion.Original] : (byte[])Row["AV_Jednostka_Banku_Segment_Id"];

        public byte[] AV_Company_Opiekun_Id{
            get {
                var value = Row["AV_Company_Opiekun_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AV_Company_Opiekun_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AV_Company_Opiekun_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AV_Company_Opiekun_Id", DataRowVersion.Original] : (byte[])Row["AV_Company_Opiekun_Id"];

        public byte[] Pakiet_KO{
            get {
                var value = Row["Pakiet_KO"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Pakiet_KO"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Pakiet_KO_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Pakiet_KO", DataRowVersion.Original] : (byte[])Row["Pakiet_KO"];

        public byte[] AS_Zrodlo_Majatkowe_Id{
            get {
                var value = Row["AS_Zrodlo_Majatkowe_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Zrodlo_Majatkowe_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Zrodlo_Majatkowe_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Zrodlo_Majatkowe_Id", DataRowVersion.Original] : (byte[])Row["AS_Zrodlo_Majatkowe_Id"];

        public byte? Oswia_FATCA{
            get {
                var value = Row["Oswia_FATCA"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Oswia_FATCA"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Oswia_FATCA_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Oswia_FATCA", DataRowVersion.Original] : (byte?)Row["Oswia_FATCA"];

        public byte? Oswia_Karne{
            get {
                var value = Row["Oswia_Karne"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Oswia_Karne"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Oswia_Karne_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Oswia_Karne", DataRowVersion.Original] : (byte?)Row["Oswia_Karne"];

        public byte? Zgoda_Rekl_Trad{
            get {
                var value = Row["Zgoda_Rekl_Trad"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zgoda_Rekl_Trad"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zgoda_Rekl_Trad_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zgoda_Rekl_Trad", DataRowVersion.Original] : (byte?)Row["Zgoda_Rekl_Trad"];

        public byte? Zgoda_Rekl_Elek{
            get {
                var value = Row["Zgoda_Rekl_Elek"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zgoda_Rekl_Elek"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zgoda_Rekl_Elek_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zgoda_Rekl_Elek", DataRowVersion.Original] : (byte?)Row["Zgoda_Rekl_Elek"];

        public byte? Zgoda_Rekl_Trad_GK{
            get {
                var value = Row["Zgoda_Rekl_Trad_GK"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zgoda_Rekl_Trad_GK"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zgoda_Rekl_Trad_GK_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zgoda_Rekl_Trad_GK", DataRowVersion.Original] : (byte?)Row["Zgoda_Rekl_Trad_GK"];

        public byte? Zgoda_Rekl_SMS{
            get {
                var value = Row["Zgoda_Rekl_SMS"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zgoda_Rekl_SMS"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zgoda_Rekl_SMS_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zgoda_Rekl_SMS", DataRowVersion.Original] : (byte?)Row["Zgoda_Rekl_SMS"];

        public byte? Skip_Start_Workflow{
            get {
                var value = Row["Skip_Start_Workflow"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Skip_Start_Workflow"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Skip_Start_Workflow_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Skip_Start_Workflow", DataRowVersion.Original] : (byte?)Row["Skip_Start_Workflow"];

        public byte[] N_AS_Rodzaj_Dok_Tozsamosci_Id{
            get {
                var value = Row["N_AS_Rodzaj_Dok_Tozsamosci_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["N_AS_Rodzaj_Dok_Tozsamosci_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] N_AS_Rodzaj_Dok_Tozsamosci_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["N_AS_Rodzaj_Dok_Tozsamosci_Id", DataRowVersion.Original] : (byte[])Row["N_AS_Rodzaj_Dok_Tozsamosci_Id"];

        public string N_Nazwisko_Panienskie_Matki{
            get {
                var value = Row["N_Nazwisko_Panienskie_Matki"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["N_Nazwisko_Panienskie_Matki"] = value == null ? DBNull.Value : (object)value; }
        }

        public string N_Nazwisko_Panienskie_Matki_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["N_Nazwisko_Panienskie_Matki", DataRowVersion.Original] : (string)Row["N_Nazwisko_Panienskie_Matki"];

        public byte[] N_Obywatelstwo{
            get {
                var value = Row["N_Obywatelstwo"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["N_Obywatelstwo"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] N_Obywatelstwo_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["N_Obywatelstwo", DataRowVersion.Original] : (byte[])Row["N_Obywatelstwo"];

        public byte[] N_Kraj_Rezydencji{
            get {
                var value = Row["N_Kraj_Rezydencji"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["N_Kraj_Rezydencji"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] N_Kraj_Rezydencji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["N_Kraj_Rezydencji", DataRowVersion.Original] : (byte[])Row["N_Kraj_Rezydencji"];

        public byte[] N_AS_Poz_Ryzyk_Klienta_Id{
            get {
                var value = Row["N_AS_Poz_Ryzyk_Klienta_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["N_AS_Poz_Ryzyk_Klienta_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] N_AS_Poz_Ryzyk_Klienta_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["N_AS_Poz_Ryzyk_Klienta_Id", DataRowVersion.Original] : (byte[])Row["N_AS_Poz_Ryzyk_Klienta_Id"];

        public byte[] N_Relacja_Klienta_Do_Banku_Id{
            get {
                var value = Row["N_Relacja_Klienta_Do_Banku_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["N_Relacja_Klienta_Do_Banku_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] N_Relacja_Klienta_Do_Banku_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["N_Relacja_Klienta_Do_Banku_Id", DataRowVersion.Original] : (byte[])Row["N_Relacja_Klienta_Do_Banku_Id"];

        public byte[] N_As_Zrodlo_Majatkowe_Id{
            get {
                var value = Row["N_As_Zrodlo_Majatkowe_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["N_As_Zrodlo_Majatkowe_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] N_As_Zrodlo_Majatkowe_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["N_As_Zrodlo_Majatkowe_Id", DataRowVersion.Original] : (byte[])Row["N_As_Zrodlo_Majatkowe_Id"];

        public byte? N_Rezydent{
            get {
                var value = Row["N_Rezydent"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["N_Rezydent"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? N_Rezydent_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["N_Rezydent", DataRowVersion.Original] : (byte?)Row["N_Rezydent"];

        public byte[] N_Kraj_Urodzenia{
            get {
                var value = Row["N_Kraj_Urodzenia"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["N_Kraj_Urodzenia"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] N_Kraj_Urodzenia_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["N_Kraj_Urodzenia", DataRowVersion.Original] : (byte[])Row["N_Kraj_Urodzenia"];

        public byte? N_Obywatel_US{
            get {
                var value = Row["N_Obywatel_US"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["N_Obywatel_US"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? N_Obywatel_US_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["N_Obywatel_US", DataRowVersion.Original] : (byte?)Row["N_Obywatel_US"];

        public byte? N_Podatek_US{
            get {
                var value = Row["N_Podatek_US"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["N_Podatek_US"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? N_Podatek_US_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["N_Podatek_US", DataRowVersion.Original] : (byte?)Row["N_Podatek_US"];

        public string N_NIP_US{
            get {
                var value = Row["N_NIP_US"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["N_NIP_US"] = value == null ? DBNull.Value : (object)value; }
        }

        public string N_NIP_US_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["N_NIP_US", DataRowVersion.Original] : (string)Row["N_NIP_US"];

        public byte? Poziom_Uwierz_Wylacz_CCO{
            get {
                var value = Row["Poziom_Uwierz_Wylacz_CCO"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Poziom_Uwierz_Wylacz_CCO"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Poziom_Uwierz_Wylacz_CCO_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Poziom_Uwierz_Wylacz_CCO", DataRowVersion.Original] : (byte?)Row["Poziom_Uwierz_Wylacz_CCO"];

        public byte? Kurier{
            get {
                var value = Row["Kurier"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Kurier"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Kurier_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Kurier", DataRowVersion.Original] : (byte?)Row["Kurier"];

        public string Zastrzezenie_Karty_Pytanie{
            get {
                var value = Row["Zastrzezenie_Karty_Pytanie"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Zastrzezenie_Karty_Pytanie"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Zastrzezenie_Karty_Pytanie_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Zastrzezenie_Karty_Pytanie", DataRowVersion.Original] : (string)Row["Zastrzezenie_Karty_Pytanie"];

        public string N_Zastrzezenie_Karty_Pytanie{
            get {
                var value = Row["N_Zastrzezenie_Karty_Pytanie"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["N_Zastrzezenie_Karty_Pytanie"] = value == null ? DBNull.Value : (object)value; }
        }

        public string N_Zastrzezenie_Karty_Pytanie_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["N_Zastrzezenie_Karty_Pytanie", DataRowVersion.Original] : (string)Row["N_Zastrzezenie_Karty_Pytanie"];

        public string Zastrzezenie_Karty_Odpowiedz{
            get {
                var value = Row["Zastrzezenie_Karty_Odpowiedz"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Zastrzezenie_Karty_Odpowiedz"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Zastrzezenie_Karty_Odpowiedz_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Zastrzezenie_Karty_Odpowiedz", DataRowVersion.Original] : (string)Row["Zastrzezenie_Karty_Odpowiedz"];

        public string N_Zastrzezenie_Karty_Odpowiedz{
            get {
                var value = Row["N_Zastrzezenie_Karty_Odpowiedz"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["N_Zastrzezenie_Karty_Odpowiedz"] = value == null ? DBNull.Value : (object)value; }
        }

        public string N_Zastrzezenie_Karty_Odpowiedz_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["N_Zastrzezenie_Karty_Odpowiedz", DataRowVersion.Original] : (string)Row["N_Zastrzezenie_Karty_Odpowiedz"];

        public byte[] AS_Zwrot_Grzecznosciowy_Id{
            get {
                var value = Row["AS_Zwrot_Grzecznosciowy_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Zwrot_Grzecznosciowy_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Zwrot_Grzecznosciowy_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Zwrot_Grzecznosciowy_Id", DataRowVersion.Original] : (byte[])Row["AS_Zwrot_Grzecznosciowy_Id"];

        public byte[] N_AS_Zwrot_Grzecznosciowy_Id{
            get {
                var value = Row["N_AS_Zwrot_Grzecznosciowy_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["N_AS_Zwrot_Grzecznosciowy_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] N_AS_Zwrot_Grzecznosciowy_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["N_AS_Zwrot_Grzecznosciowy_Id", DataRowVersion.Original] : (byte[])Row["N_AS_Zwrot_Grzecznosciowy_Id"];

        public byte? Risk_Level{
            get {
                var value = Row["Risk_Level"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Risk_Level"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Risk_Level_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Risk_Level", DataRowVersion.Original] : (byte?)Row["Risk_Level"];

        public byte? N_Risk_Level{
            get {
                var value = Row["N_Risk_Level"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["N_Risk_Level"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? N_Risk_Level_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["N_Risk_Level", DataRowVersion.Original] : (byte?)Row["N_Risk_Level"];

        public byte? Typ_Klienta{
            get {
                var value = Row["Typ_Klienta"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Typ_Klienta"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Typ_Klienta_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Typ_Klienta", DataRowVersion.Original] : (byte?)Row["Typ_Klienta"];

        public byte? Typ_negocjacji{
            get {
                var value = Row["Typ_negocjacji"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Typ_negocjacji"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Typ_negocjacji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Typ_negocjacji", DataRowVersion.Original] : (byte?)Row["Typ_negocjacji"];

        public decimal? Kwota{
            get {
                var value = Row["Kwota"];
                return value == DBNull.Value ? null : (decimal?)value;
            }

            set { Row["Kwota"] = value == null ? DBNull.Value : (object)value; }
        }

        public decimal? Kwota_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (decimal?)Row["Kwota", DataRowVersion.Original] : (decimal?)Row["Kwota"];

        public byte? Nowe_Srodki{
            get {
                var value = Row["Nowe_Srodki"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Nowe_Srodki"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Nowe_Srodki_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Nowe_Srodki", DataRowVersion.Original] : (byte?)Row["Nowe_Srodki"];

        public string DEPO_NegotiationId{
            get {
                var value = Row["DEPO_NegotiationId"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["DEPO_NegotiationId"] = value == null ? DBNull.Value : (object)value; }
        }

        public string DEPO_NegotiationId_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["DEPO_NegotiationId", DataRowVersion.Original] : (string)Row["DEPO_NegotiationId"];

        public string DEPO_AdvisorId{
            get {
                var value = Row["DEPO_AdvisorId"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["DEPO_AdvisorId"] = value == null ? DBNull.Value : (object)value; }
        }

        public string DEPO_AdvisorId_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["DEPO_AdvisorId", DataRowVersion.Original] : (string)Row["DEPO_AdvisorId"];

        public DateTime? DEPO_Closing_Time{
            get {
                var value = Row["DEPO_Closing_Time"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["DEPO_Closing_Time"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? DEPO_Closing_Time_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["DEPO_Closing_Time", DataRowVersion.Original] : (DateTime?)Row["DEPO_Closing_Time"];

        public string DEPO_Status{
            get {
                var value = Row["DEPO_Status"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["DEPO_Status"] = value == null ? DBNull.Value : (object)value; }
        }

        public string DEPO_Status_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["DEPO_Status", DataRowVersion.Original] : (string)Row["DEPO_Status"];

        public byte[] A_Sprawa_Id{
            get {
                var value = Row["A_Sprawa_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Sprawa_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Sprawa_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Sprawa_Id", DataRowVersion.Original] : (byte[])Row["A_Sprawa_Id"];

        public byte[] Odbiorca_Rachunek{
            get {
                var value = Row["Odbiorca_Rachunek"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Odbiorca_Rachunek"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Odbiorca_Rachunek_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Odbiorca_Rachunek", DataRowVersion.Original] : (byte[])Row["Odbiorca_Rachunek"];

        public byte[] SI{
            get {
                var value = Row["SI"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["SI"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] SI_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["SI", DataRowVersion.Original] : (byte[])Row["SI"];

        public byte[] SI_old{
            get {
                var value = Row["SI_old"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["SI_old"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] SI_old_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["SI_old", DataRowVersion.Original] : (byte[])Row["SI_old"];

        public byte? Company_Verified{
            get {
                var value = Row["Company_Verified"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Company_Verified"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Company_Verified_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Company_Verified", DataRowVersion.Original] : (byte?)Row["Company_Verified"];

        public byte? Sposob_Dostarczenia_Regulaminu{
            get {
                var value = Row["Sposob_Dostarczenia_Regulaminu"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Sposob_Dostarczenia_Regulaminu"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Sposob_Dostarczenia_Regulaminu_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Sposob_Dostarczenia_Regulaminu", DataRowVersion.Original] : (byte?)Row["Sposob_Dostarczenia_Regulaminu"];

        public byte? Not_Pers_Card_Order_Status{
            get {
                var value = Row["Not_Pers_Card_Order_Status"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Not_Pers_Card_Order_Status"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Not_Pers_Card_Order_Status_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Not_Pers_Card_Order_Status", DataRowVersion.Original] : (byte?)Row["Not_Pers_Card_Order_Status"];

        public byte[] A_Weryfikacja_Klienta_Id{
            get {
                var value = Row["A_Weryfikacja_Klienta_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Weryfikacja_Klienta_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Weryfikacja_Klienta_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Weryfikacja_Klienta_Id", DataRowVersion.Original] : (byte[])Row["A_Weryfikacja_Klienta_Id"];

        public byte[] KR{
            get {
                var value = Row["KR"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["KR"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] KR_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["KR", DataRowVersion.Original] : (byte[])Row["KR"];

        public byte[] AS_KR_Oferta_Id{
            get {
                var value = Row["AS_KR_Oferta_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_KR_Oferta_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_KR_Oferta_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_KR_Oferta_Id", DataRowVersion.Original] : (byte[])Row["AS_KR_Oferta_Id"];

        public string Dowod_Wydany_Przez{
            get {
                var value = Row["Dowod_Wydany_Przez"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Dowod_Wydany_Przez"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Dowod_Wydany_Przez_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Dowod_Wydany_Przez", DataRowVersion.Original] : (string)Row["Dowod_Wydany_Przez"];

        public string Dowod_Wydany_Przez_N{
            get {
                var value = Row["Dowod_Wydany_Przez_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Dowod_Wydany_Przez_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Dowod_Wydany_Przez_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Dowod_Wydany_Przez_N", DataRowVersion.Original] : (string)Row["Dowod_Wydany_Przez_N"];

        public byte? Czy_Pobrane_Sprawy{
            get {
                var value = Row["Czy_Pobrane_Sprawy"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Czy_Pobrane_Sprawy"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Czy_Pobrane_Sprawy_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Czy_Pobrane_Sprawy", DataRowVersion.Original] : (byte?)Row["Czy_Pobrane_Sprawy"];

        public int? Company_CIF{
            get {
                var value = Row["Company_CIF"];
                return value == DBNull.Value ? null : (int?)value;
            }

            set { Row["Company_CIF"] = value == null ? DBNull.Value : (object)value; }
        }

        public int? Company_CIF_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (int?)Row["Company_CIF", DataRowVersion.Original] : (int?)Row["Company_CIF"];

        public byte? Euro_FATCA_Niedotyczy{
            get {
                var value = Row["Euro_FATCA_Niedotyczy"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Euro_FATCA_Niedotyczy"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Euro_FATCA_Niedotyczy_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Euro_FATCA_Niedotyczy", DataRowVersion.Original] : (byte?)Row["Euro_FATCA_Niedotyczy"];

        public byte? Euro_FATCA_Niedotyczy_N{
            get {
                var value = Row["Euro_FATCA_Niedotyczy_N"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Euro_FATCA_Niedotyczy_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Euro_FATCA_Niedotyczy_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Euro_FATCA_Niedotyczy_N", DataRowVersion.Original] : (byte?)Row["Euro_FATCA_Niedotyczy_N"];

        public string Odbiorca_Bank{
            get {
                var value = Row["Odbiorca_Bank"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Odbiorca_Bank"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Odbiorca_Bank_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Odbiorca_Bank", DataRowVersion.Original] : (string)Row["Odbiorca_Bank"];

        public byte[] A_Kredyt_Rachunek_Id{
            get {
                var value = Row["A_Kredyt_Rachunek_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Kredyt_Rachunek_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Kredyt_Rachunek_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Kredyt_Rachunek_Id", DataRowVersion.Original] : (byte[])Row["A_Kredyt_Rachunek_Id"];

        public byte[] Pivotal_Binary_1{
            get {
                var value = Row["Pivotal_Binary_1"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Pivotal_Binary_1"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Pivotal_Binary_1_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Pivotal_Binary_1", DataRowVersion.Original] : (byte[])Row["Pivotal_Binary_1"];

        public byte[] Pivotal_Binary_2{
            get {
                var value = Row["Pivotal_Binary_2"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Pivotal_Binary_2"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Pivotal_Binary_2_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Pivotal_Binary_2", DataRowVersion.Original] : (byte[])Row["Pivotal_Binary_2"];

        public byte[] Pivotal_Binary_3{
            get {
                var value = Row["Pivotal_Binary_3"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Pivotal_Binary_3"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Pivotal_Binary_3_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Pivotal_Binary_3", DataRowVersion.Original] : (byte[])Row["Pivotal_Binary_3"];

        public string Pivotal_Text_254_5{
            get {
                var value = Row["Pivotal_Text_254_5"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Pivotal_Text_254_5"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Pivotal_Text_254_5_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Pivotal_Text_254_5", DataRowVersion.Original] : (string)Row["Pivotal_Text_254_5"];

        public string Pivotal_Text_254_6{
            get {
                var value = Row["Pivotal_Text_254_6"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Pivotal_Text_254_6"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Pivotal_Text_254_6_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Pivotal_Text_254_6", DataRowVersion.Original] : (string)Row["Pivotal_Text_254_6"];

        public DateTime? Dowod_Wazny_D{
            get {
                var value = Row["Dowod_Wazny_D"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Dowod_Wazny_D"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Dowod_Wazny_D_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Dowod_Wazny_D", DataRowVersion.Original] : (DateTime?)Row["Dowod_Wazny_D"];

        public DateTime? Dowod_Wydany_D{
            get {
                var value = Row["Dowod_Wydany_D"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Dowod_Wydany_D"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Dowod_Wydany_D_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Dowod_Wydany_D", DataRowVersion.Original] : (DateTime?)Row["Dowod_Wydany_D"];

        public string Wystawca_Dokumentu_D{
            get {
                var value = Row["Wystawca_Dokumentu_D"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Wystawca_Dokumentu_D"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Wystawca_Dokumentu_D_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Wystawca_Dokumentu_D", DataRowVersion.Original] : (string)Row["Wystawca_Dokumentu_D"];

        public byte[] AS_Rodzaj_Dok_Tozs_Id_D_N{
            get {
                var value = Row["AS_Rodzaj_Dok_Tozs_Id_D_N"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Rodzaj_Dok_Tozs_Id_D_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Rodzaj_Dok_Tozs_Id_D_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Rodzaj_Dok_Tozs_Id_D_N", DataRowVersion.Original] : (byte[])Row["AS_Rodzaj_Dok_Tozs_Id_D_N"];

        public string Dowod_Nr_D_N{
            get {
                var value = Row["Dowod_Nr_D_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Dowod_Nr_D_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Dowod_Nr_D_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Dowod_Nr_D_N", DataRowVersion.Original] : (string)Row["Dowod_Nr_D_N"];

        public DateTime? Dowod_Wazny_D_N{
            get {
                var value = Row["Dowod_Wazny_D_N"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Dowod_Wazny_D_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Dowod_Wazny_D_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Dowod_Wazny_D_N", DataRowVersion.Original] : (DateTime?)Row["Dowod_Wazny_D_N"];

        public DateTime? Dowod_Wydany_D_N{
            get {
                var value = Row["Dowod_Wydany_D_N"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Dowod_Wydany_D_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Dowod_Wydany_D_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Dowod_Wydany_D_N", DataRowVersion.Original] : (DateTime?)Row["Dowod_Wydany_D_N"];

        public string Wystawca_Dokumentu_D_N{
            get {
                var value = Row["Wystawca_Dokumentu_D_N"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Wystawca_Dokumentu_D_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Wystawca_Dokumentu_D_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Wystawca_Dokumentu_D_N", DataRowVersion.Original] : (string)Row["Wystawca_Dokumentu_D_N"];

        public byte? NROR_Kanal_Finalizacji{
            get {
                var value = Row["NROR_Kanal_Finalizacji"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["NROR_Kanal_Finalizacji"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? NROR_Kanal_Finalizacji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["NROR_Kanal_Finalizacji", DataRowVersion.Original] : (byte?)Row["NROR_Kanal_Finalizacji"];

        public byte[] A_NROR_Ubezp_Params_Id{
            get {
                var value = Row["A_NROR_Ubezp_Params_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_NROR_Ubezp_Params_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_NROR_Ubezp_Params_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_NROR_Ubezp_Params_Id", DataRowVersion.Original] : (byte[])Row["A_NROR_Ubezp_Params_Id"];

        public byte[] A_NROR_Ubezp_Params_Id_Karta{
            get {
                var value = Row["A_NROR_Ubezp_Params_Id_Karta"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_NROR_Ubezp_Params_Id_Karta"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_NROR_Ubezp_Params_Id_Karta_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_NROR_Ubezp_Params_Id_Karta", DataRowVersion.Original] : (byte[])Row["A_NROR_Ubezp_Params_Id_Karta"];

        public byte[] AS_NROR_Powody_Rezygnacji_Id{
            get {
                var value = Row["AS_NROR_Powody_Rezygnacji_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_NROR_Powody_Rezygnacji_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_NROR_Powody_Rezygnacji_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_NROR_Powody_Rezygnacji_Id", DataRowVersion.Original] : (byte[])Row["AS_NROR_Powody_Rezygnacji_Id"];

        public byte? Pivotal_Bool_9{
            get {
                var value = Row["Pivotal_Bool_9"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Pivotal_Bool_9"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Pivotal_Bool_9_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Pivotal_Bool_9", DataRowVersion.Original] : (byte?)Row["Pivotal_Bool_9"];

        public byte? Pivotal_Bool_10{
            get {
                var value = Row["Pivotal_Bool_10"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Pivotal_Bool_10"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Pivotal_Bool_10_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Pivotal_Bool_10", DataRowVersion.Original] : (byte?)Row["Pivotal_Bool_10"];

        public byte[] AS_Jezyk_Klienta_Id{
            get {
                var value = Row["AS_Jezyk_Klienta_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Jezyk_Klienta_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Jezyk_Klienta_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Jezyk_Klienta_Id", DataRowVersion.Original] : (byte[])Row["AS_Jezyk_Klienta_Id"];

        public byte[] AS_Jezyk_Klienta_Id_N{
            get {
                var value = Row["AS_Jezyk_Klienta_Id_N"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Jezyk_Klienta_Id_N"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Jezyk_Klienta_Id_N_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Jezyk_Klienta_Id_N", DataRowVersion.Original] : (byte[])Row["AS_Jezyk_Klienta_Id_N"];

        public byte[] AV_DI_Partner_Id{
            get {
                var value = Row["AV_DI_Partner_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AV_DI_Partner_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AV_DI_Partner_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AV_DI_Partner_Id", DataRowVersion.Original] : (byte[])Row["AV_DI_Partner_Id"];

        public byte[] AV_DI_Produkty_Id{
            get {
                var value = Row["AV_DI_Produkty_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AV_DI_Produkty_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AV_DI_Produkty_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AV_DI_Produkty_Id", DataRowVersion.Original] : (byte[])Row["AV_DI_Produkty_Id"];

        public byte? Decyzja_Klienta{
            get {
                var value = Row["Decyzja_Klienta"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Decyzja_Klienta"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Decyzja_Klienta_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Decyzja_Klienta", DataRowVersion.Original] : (byte?)Row["Decyzja_Klienta"];

        public byte[] A_DI_Raport_Exante_H_Id{
            get {
                var value = Row["A_DI_Raport_Exante_H_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_DI_Raport_Exante_H_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_DI_Raport_Exante_H_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_DI_Raport_Exante_H_Id", DataRowVersion.Original] : (byte[])Row["A_DI_Raport_Exante_H_Id"];

        public byte[] A_DI_Raport_Ostrze_H_Id{
            get {
                var value = Row["A_DI_Raport_Ostrze_H_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_DI_Raport_Ostrze_H_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_DI_Raport_Ostrze_H_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_DI_Raport_Ostrze_H_Id", DataRowVersion.Original] : (byte[])Row["A_DI_Raport_Ostrze_H_Id"];

        public byte[] A_Konto_Id{
            get {
                var value = Row["A_Konto_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Konto_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Konto_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Konto_Id", DataRowVersion.Original] : (byte[])Row["A_Konto_Id"];

        public byte? Ankieta_Decyzja{
            get {
                var value = Row["Ankieta_Decyzja"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Ankieta_Decyzja"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Ankieta_Decyzja_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Ankieta_Decyzja", DataRowVersion.Original] : (byte?)Row["Ankieta_Decyzja"];

        public byte? Zgoda_Na_Informacje_Osobiste{
            get {
                var value = Row["Zgoda_Na_Informacje_Osobiste"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zgoda_Na_Informacje_Osobiste"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zgoda_Na_Informacje_Osobiste_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zgoda_Na_Informacje_Osobiste", DataRowVersion.Original] : (byte?)Row["Zgoda_Na_Informacje_Osobiste"];

        public byte? Zgoda_Na_Informacje_Ogolne{
            get {
                var value = Row["Zgoda_Na_Informacje_Ogolne"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zgoda_Na_Informacje_Ogolne"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zgoda_Na_Informacje_Ogolne_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zgoda_Na_Informacje_Ogolne", DataRowVersion.Original] : (byte?)Row["Zgoda_Na_Informacje_Ogolne"];

        public byte? Ankieta_Decyzja_Karta{
            get {
                var value = Row["Ankieta_Decyzja_Karta"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Ankieta_Decyzja_Karta"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Ankieta_Decyzja_Karta_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Ankieta_Decyzja_Karta", DataRowVersion.Original] : (byte?)Row["Ankieta_Decyzja_Karta"];

        public string Kod_Polecenia{
            get {
                var value = Row["Kod_Polecenia"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Kod_Polecenia"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Kod_Polecenia_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Kod_Polecenia", DataRowVersion.Original] : (string)Row["Kod_Polecenia"];

        public byte? Zgoda_Na_Profilowanie{
            get {
                var value = Row["Zgoda_Na_Profilowanie"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zgoda_Na_Profilowanie"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zgoda_Na_Profilowanie_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zgoda_Na_Profilowanie", DataRowVersion.Original] : (byte?)Row["Zgoda_Na_Profilowanie"];

        public byte[] CKK{
            get {
                var value = Row["CKK"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["CKK"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] CKK_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["CKK", DataRowVersion.Original] : (byte[])Row["CKK"];

        public string Data_Quality_Xml{
            get {
                var value = Row["Data_Quality_Xml"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Data_Quality_Xml"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Data_Quality_Xml_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Data_Quality_Xml", DataRowVersion.Original] : (string)Row["Data_Quality_Xml"];

        public byte? Zmien_Fax{
            get {
                var value = Row["Zmien_Fax"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zmien_Fax"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zmien_Fax_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zmien_Fax", DataRowVersion.Original] : (byte?)Row["Zmien_Fax"];

        public string Data_Quality_Xml_Fatca{
            get {
                var value = Row["Data_Quality_Xml_Fatca"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Data_Quality_Xml_Fatca"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Data_Quality_Xml_Fatca_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Data_Quality_Xml_Fatca", DataRowVersion.Original] : (string)Row["Data_Quality_Xml_Fatca"];

        public string Data_Quality_Xml_AssetsSource{
            get {
                var value = Row["Data_Quality_Xml_AssetsSource"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Data_Quality_Xml_AssetsSource"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Data_Quality_Xml_AssetsSource_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Data_Quality_Xml_AssetsSource", DataRowVersion.Original] : (string)Row["Data_Quality_Xml_AssetsSource"];

        public byte? Kanal_Wplywu_Dane_Osobowe{
            get {
                var value = Row["Kanal_Wplywu_Dane_Osobowe"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Kanal_Wplywu_Dane_Osobowe"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Kanal_Wplywu_Dane_Osobowe_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Kanal_Wplywu_Dane_Osobowe", DataRowVersion.Original] : (byte?)Row["Kanal_Wplywu_Dane_Osobowe"];

        public byte? Kanal_Wysylki_Dane_Osobowe{
            get {
                var value = Row["Kanal_Wysylki_Dane_Osobowe"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Kanal_Wysylki_Dane_Osobowe"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Kanal_Wysylki_Dane_Osobowe_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Kanal_Wysylki_Dane_Osobowe", DataRowVersion.Original] : (byte?)Row["Kanal_Wysylki_Dane_Osobowe"];

        public DateTime? Anonymization_Date{
            get {
                var value = Row["Anonymization_Date"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Anonymization_Date"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Anonymization_Date_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Anonymization_Date", DataRowVersion.Original] : (DateTime?)Row["Anonymization_Date"];

        public byte? Pep{
            get {
                var value = Row["Pep"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Pep"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Pep_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Pep", DataRowVersion.Original] : (byte?)Row["Pep"];

        public byte[] AS_Stany_Cywilne_ESB_Id{
            get {
                var value = Row["AS_Stany_Cywilne_ESB_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Stany_Cywilne_ESB_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Stany_Cywilne_ESB_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Stany_Cywilne_ESB_Id", DataRowVersion.Original] : (byte[])Row["AS_Stany_Cywilne_ESB_Id"];

        public byte? Rodzaj_Sprzeciwu{
            get {
                var value = Row["Rodzaj_Sprzeciwu"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Rodzaj_Sprzeciwu"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Rodzaj_Sprzeciwu_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Rodzaj_Sprzeciwu", DataRowVersion.Original] : (byte?)Row["Rodzaj_Sprzeciwu"];

        public DateTime? Data_Sprzeciwu{
            get {
                var value = Row["Data_Sprzeciwu"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Data_Sprzeciwu"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Data_Sprzeciwu_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Data_Sprzeciwu", DataRowVersion.Original] : (DateTime?)Row["Data_Sprzeciwu"];

        public byte? Zgoda_Sp_Pow{
            get {
                var value = Row["Zgoda_Sp_Pow"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zgoda_Sp_Pow"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zgoda_Sp_Pow_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zgoda_Sp_Pow", DataRowVersion.Original] : (byte?)Row["Zgoda_Sp_Pow"];

        public byte? Zgoda_Sp_Pow_Ogolna{
            get {
                var value = Row["Zgoda_Sp_Pow_Ogolna"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zgoda_Sp_Pow_Ogolna"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zgoda_Sp_Pow_Ogolna_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zgoda_Sp_Pow_Ogolna", DataRowVersion.Original] : (byte?)Row["Zgoda_Sp_Pow_Ogolna"];

        public byte? Zgoda_Sp_Pow_Elektron{
            get {
                var value = Row["Zgoda_Sp_Pow_Elektron"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zgoda_Sp_Pow_Elektron"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zgoda_Sp_Pow_Elektron_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zgoda_Sp_Pow_Elektron", DataRowVersion.Original] : (byte?)Row["Zgoda_Sp_Pow_Elektron"];

        public byte? Zgoda_Sp_Pow_Telefon{
            get {
                var value = Row["Zgoda_Sp_Pow_Telefon"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Zgoda_Sp_Pow_Telefon"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Zgoda_Sp_Pow_Telefon_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Zgoda_Sp_Pow_Telefon", DataRowVersion.Original] : (byte?)Row["Zgoda_Sp_Pow_Telefon"];

        public byte? Procesowanie_Ubezpieczenia_BZ{
            get {
                var value = Row["Procesowanie_Ubezpieczenia_BZ"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Procesowanie_Ubezpieczenia_BZ"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Procesowanie_Ubezpieczenia_BZ_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Procesowanie_Ubezpieczenia_BZ", DataRowVersion.Original] : (byte?)Row["Procesowanie_Ubezpieczenia_BZ"];

        public byte? Klient_Pyta_O_Oferte{
            get {
                var value = Row["Klient_Pyta_O_Oferte"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Klient_Pyta_O_Oferte"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Klient_Pyta_O_Oferte_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Klient_Pyta_O_Oferte", DataRowVersion.Original] : (byte?)Row["Klient_Pyta_O_Oferte"];

        public byte? Forma_Wysylki_PPW{
            get {
                var value = Row["Forma_Wysylki_PPW"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Forma_Wysylki_PPW"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Forma_Wysylki_PPW_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Forma_Wysylki_PPW", DataRowVersion.Original] : (byte?)Row["Forma_Wysylki_PPW"];

        public byte? Typ_Wynagrodzenia{
            get {
                var value = Row["Typ_Wynagrodzenia"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Typ_Wynagrodzenia"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Typ_Wynagrodzenia_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Typ_Wynagrodzenia", DataRowVersion.Original] : (byte?)Row["Typ_Wynagrodzenia"];

        public DateTime? Data_Obowiazywania{
            get {
                var value = Row["Data_Obowiazywania"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Data_Obowiazywania"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Data_Obowiazywania_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Data_Obowiazywania", DataRowVersion.Original] : (DateTime?)Row["Data_Obowiazywania"];

        public string Nazwa{
            get {
                var value = Row["Nazwa"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Nazwa"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Nazwa_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Nazwa", DataRowVersion.Original] : (string)Row["Nazwa"];

        public byte? Wartosc_Wynagrodzenia{
            get {
                var value = Row["Wartosc_Wynagrodzenia"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Wartosc_Wynagrodzenia"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Wartosc_Wynagrodzenia_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Wartosc_Wynagrodzenia", DataRowVersion.Original] : (byte?)Row["Wartosc_Wynagrodzenia"];

        public byte[] Zalacznik_Id{
            get {
                var value = Row["Zalacznik_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["Zalacznik_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] Zalacznik_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["Zalacznik_Id", DataRowVersion.Original] : (byte[])Row["Zalacznik_Id"];

        public byte? Poziom_Fraudu{
            get {
                var value = Row["Poziom_Fraudu"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Poziom_Fraudu"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Poziom_Fraudu_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Poziom_Fraudu", DataRowVersion.Original] : (byte?)Row["Poziom_Fraudu"];

        public byte? Kanal_Realizacji{
            get {
                var value = Row["Kanal_Realizacji"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Kanal_Realizacji"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Kanal_Realizacji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Kanal_Realizacji", DataRowVersion.Original] : (byte?)Row["Kanal_Realizacji"];

        public byte? Wynik_Weryfikacji{
            get {
                var value = Row["Wynik_Weryfikacji"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Wynik_Weryfikacji"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Wynik_Weryfikacji_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Wynik_Weryfikacji", DataRowVersion.Original] : (byte?)Row["Wynik_Weryfikacji"];

        public byte? Email_Wyciag_BI{
            get {
                var value = Row["Email_Wyciag_BI"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Email_Wyciag_BI"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Email_Wyciag_BI_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Email_Wyciag_BI", DataRowVersion.Original] : (byte?)Row["Email_Wyciag_BI"];

        public byte? Email_Wyciag_BI_ROR{
            get {
                var value = Row["Email_Wyciag_BI_ROR"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Email_Wyciag_BI_ROR"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Email_Wyciag_BI_ROR_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Email_Wyciag_BI_ROR", DataRowVersion.Original] : (byte?)Row["Email_Wyciag_BI_ROR"];

        public byte[] AS_Transaction_Type_FRA_Id{
            get {
                var value = Row["AS_Transaction_Type_FRA_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Transaction_Type_FRA_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Transaction_Type_FRA_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Transaction_Type_FRA_Id", DataRowVersion.Original] : (byte[])Row["AS_Transaction_Type_FRA_Id"];

        public byte[] AS_Poziom_Weryfik_Klienta_Id{
            get {
                var value = Row["AS_Poziom_Weryfik_Klienta_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_Poziom_Weryfik_Klienta_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_Poziom_Weryfik_Klienta_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_Poziom_Weryfik_Klienta_Id", DataRowVersion.Original] : (byte[])Row["AS_Poziom_Weryfik_Klienta_Id"];

        public DateTime? Data_Czas{
            get {
                var value = Row["Data_Czas"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Data_Czas"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Data_Czas_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Data_Czas", DataRowVersion.Original] : (DateTime?)Row["Data_Czas"];

        public DateTime? Data_Potwierdzenia_Odbioru{
            get {
                var value = Row["Data_Potwierdzenia_Odbioru"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Data_Potwierdzenia_Odbioru"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Data_Potwierdzenia_Odbioru_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Data_Potwierdzenia_Odbioru", DataRowVersion.Original] : (DateTime?)Row["Data_Potwierdzenia_Odbioru"];

        public DateTime? Dane_Zostaly_Zmieszane{
            get {
                var value = Row["Dane_Zostaly_Zmieszane"];
                return value == DBNull.Value ? null : (DateTime?)value;
            }

            set { Row["Dane_Zostaly_Zmieszane"] = value == null ? DBNull.Value : (object)value; }
        }

        public DateTime? Dane_Zostaly_Zmieszane_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (DateTime?)Row["Dane_Zostaly_Zmieszane", DataRowVersion.Original] : (DateTime?)Row["Dane_Zostaly_Zmieszane"];

        public byte? Interval_Type{
            get {
                var value = Row["Interval_Type"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Interval_Type"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Interval_Type_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Interval_Type", DataRowVersion.Original] : (byte?)Row["Interval_Type"];

        public byte[] A_Dyspozycja_Produkt_Id{
            get {
                var value = Row["A_Dyspozycja_Produkt_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_Dyspozycja_Produkt_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_Dyspozycja_Produkt_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_Dyspozycja_Produkt_Id", DataRowVersion.Original] : (byte[])Row["A_Dyspozycja_Produkt_Id"];

        public byte? Pivotal_Bool_11{
            get {
                var value = Row["Pivotal_Bool_11"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Pivotal_Bool_11"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Pivotal_Bool_11_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Pivotal_Bool_11", DataRowVersion.Original] : (byte?)Row["Pivotal_Bool_11"];

        public string Informacje_Dla_Kuriera{
            get {
                var value = Row["Informacje_Dla_Kuriera"];
                return value == DBNull.Value ? null : (string)value;
            }

            set { Row["Informacje_Dla_Kuriera"] = value == null ? DBNull.Value : (object)value; }
        }

        public string Informacje_Dla_Kuriera_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (string)Row["Informacje_Dla_Kuriera", DataRowVersion.Original] : (string)Row["Informacje_Dla_Kuriera"];

        public byte[] A_ZG_AIS_CAF_Id{
            get {
                var value = Row["A_ZG_AIS_CAF_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["A_ZG_AIS_CAF_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] A_ZG_AIS_CAF_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["A_ZG_AIS_CAF_Id", DataRowVersion.Original] : (byte[])Row["A_ZG_AIS_CAF_Id"];

        public byte[] AS_TNT_Kod_Nadania_Id{
            get {
                var value = Row["AS_TNT_Kod_Nadania_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_TNT_Kod_Nadania_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_TNT_Kod_Nadania_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_TNT_Kod_Nadania_Id", DataRowVersion.Original] : (byte[])Row["AS_TNT_Kod_Nadania_Id"];

        public byte? Pivotal_Bool_12{
            get {
                var value = Row["Pivotal_Bool_12"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Pivotal_Bool_12"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Pivotal_Bool_12_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Pivotal_Bool_12", DataRowVersion.Original] : (byte?)Row["Pivotal_Bool_12"];

        public byte[] AS_ZG_Partner_Id{
            get {
                var value = Row["AS_ZG_Partner_Id"];
                return value == DBNull.Value ? null : (byte[])value;
            }

            set { Row["AS_ZG_Partner_Id"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte[] AS_ZG_Partner_Id_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte[])Row["AS_ZG_Partner_Id", DataRowVersion.Original] : (byte[])Row["AS_ZG_Partner_Id"];

        public byte? Typ_Aktualizacji_3DSecure{
            get {
                var value = Row["Typ_Aktualizacji_3DSecure"];
                return value == DBNull.Value ? null : (byte?)value;
            }

            set { Row["Typ_Aktualizacji_3DSecure"] = value == null ? DBNull.Value : (object)value; }
        }

        public byte? Typ_Aktualizacji_3DSecure_OriginalValue => Row.HasVersion(DataRowVersion.Original) ? (byte?)Row["Typ_Aktualizacji_3DSecure", DataRowVersion.Original] : (byte?)Row["Typ_Aktualizacji_3DSecure"];

    }
}
