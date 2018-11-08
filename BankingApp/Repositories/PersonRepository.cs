using System.Collections.Generic;
using BankingApp.Interfaces;

namespace BankingApp.Repositories
{
    class PersonRepository
    {
        private static List<IPerson> people = new List<IPerson>();

        public static void Add(IPerson person) => people.Add(person);

        public static IEnumerable<IPerson> People => people;
    }
}
