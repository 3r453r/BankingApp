using BankingApp.Interfaces;
using BankingApp.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingAppEFCorePersistence
{
    class PersonRepository : IRepository<IPerson>
    {
        private BankingAppContext context = BankingAppContext.Context;

        public IQueryable<IPerson> Items => context.Set<Person>().AsQueryable();

        public IPerson Add(IPerson person)
        {
            var _person = new Person(person);
            var entity = context.Add(_person).Entity;
            context.SaveChanges();
            return entity;
        }

        public void Remove(IPerson person)
        {            
            context.Remove(context.Find<Person>(person.PersonId));
            context.SaveChanges();
        }

        public void Save(IPerson person)
        {
            var _person = context.Find<Person>(person.PersonId);
            _person.FirstName = person.FirstName ?? _person.FirstName;
            _person.LastName = person.LastName ?? _person.LastName;
            _person.DateOfBirth = person.DateOfBirth == DateTime.MinValue ? _person.DateOfBirth : person.DateOfBirth;
            _person.Pesel = person.Pesel ?? _person.Pesel;
            _person.Nip = person.Nip ?? _person.Nip;
            _person.Deceased = person.Deceased;
            context.Update(_person);
            context.SaveChanges();
        }
    }
}
