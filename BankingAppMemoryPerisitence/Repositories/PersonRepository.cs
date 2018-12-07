using System.Collections.Generic;
using System.Linq;
using BankingApp.Interfaces;
using BankingApp.Persistence;

namespace BankingAppMemoryPersistence.Repositories
{
    public class PersonRepository : IRepository<IPerson>
    {
        private static PersonRepository personRepository;

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
            people.Add(person);
            return person;
        }

        public void Remove(IPerson person) => people.Remove(person);

        public void Save(IPerson t)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<IPerson> Items => people.AsQueryable();
    }
}
