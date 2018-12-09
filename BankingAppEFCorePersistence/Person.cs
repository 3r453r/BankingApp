using BankingApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingAppEFCorePersistence
{
    public class Person : IPerson
    {
        public long PersonId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Pesel { get; set; }
        public string Nip { get; set; }
        public bool Deceased { get; set; }

        public Person(IPerson person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            DateOfBirth = person.DateOfBirth;
            Pesel = person.Pesel;
            Nip = person.Nip;
            Deceased = person.Deceased;
        }

        public void AddDocument(IIdentificationDocument document)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IIdentificationDocument> GetDocuments()
        {
            throw new NotImplementedException();
        }
    }
}
