using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Data
{
    public struct PersonData
    {
        public string FirstName;
        public string LastName;
        public DateTime? DateOfBirth;
        public string Pesel;
        public string Nip;
        public bool? Deceased;
        public long? personId;
    }
}
