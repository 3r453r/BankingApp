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

        public Person(IPerson person): this(person.FirstName, person.LastName, person.DateOfBirth, person.Pesel, person.Nip, person.Deceased)
        {
        }

        internal Person(string firstName, string lastName, DateTime dateOfBirth, string pesel, string nip, bool deceased)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Pesel = pesel;
            Nip = nip;
            Deceased = deceased;
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
