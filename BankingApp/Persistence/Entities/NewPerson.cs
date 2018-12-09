using BankingApp.Data;
using BankingApp.Interfaces;
using System;
using System.Collections.Generic;

namespace BankingApp.Persistence.Entities
{
    class NewPerson : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Pesel { get; set; }
        public string Nip { get; set; }
        public long PersonId => -1;
        public bool Deceased { get; set; }

        public NewPerson(PersonData data)
        {
            FirstName = data.FirstName;
            LastName = data.LastName;
            DateOfBirth = data.DateOfBirth ?? DateTime.MinValue;
            Pesel = data.Pesel;
            Nip = data.Nip;
            Deceased = data.Deceased ?? false;
        }

        public void AddDocument(IIdentificationDocument document)
        {
        }

        public IEnumerable<IIdentificationDocument> GetDocuments()
        {
            return new IIdentificationDocument[0];
        }
    }
}
