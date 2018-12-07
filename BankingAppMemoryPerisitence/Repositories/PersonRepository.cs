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

        public void Add(IPerson person) => people.Add(person);

        public void Remove(IPerson person) => people.Remove(person);

        public IQueryable<IPerson> Items => people.AsQueryable();
    }
}
