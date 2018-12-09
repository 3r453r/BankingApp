using System;
using System.Collections.Generic;
using System.Linq;
using BankingApp.Interfaces;
using BankingApp.Persistence;

namespace BankingAppMemoryPersistence.Repositories
{
    public class PersonRepository : IRepository<IPerson>
    {
        private static PersonRepository personRepository;
        private static long lastId = 1;

        private PersonRepository()
        {
        }

        public static PersonRepository Repository
        {
            get
            {
                if (personRepository == null) personRepository = new PersonRepository();
                return personRepository;
            }
        }

        private List<IPerson> people = new List<IPerson>();

        public IPerson Add(IPerson person)
        {
            var _person = new Person(person);
            people.Add(_person);
            return _person;
        }

        public void Remove(IPerson person) => people.Remove(person);

        public void Save(IPerson t)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<IPerson> Items => people.AsQueryable();

        private class Person : IPerson
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Pesel { get; set; }
            public string Nip { get; set; }
            public long PersonId { get; set; }
            public bool Deceased { get; set; }

            public Person(IPerson person)
            {
                FirstName = person.FirstName;
                LastName = person.LastName;
                DateOfBirth = person.DateOfBirth;
                Pesel = person.Pesel;
                Nip = person.Nip;
                Deceased = person.Deceased;
                PersonId = lastId++;
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
}
