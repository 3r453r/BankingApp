using System;
using System.Collections.Generic;
using BankingApp.Classes;
using BankingApp.Configuration;
using BankingApp.Data;
using BankingApp.Interfaces;
using BankingApp.Persistence;
using BankingApp.Persistence.Entities;
using System.Linq;

namespace BankingApp.UI
{
    public class EmployeeActions : IEmployeeActions
    {
        private IPersistenceProvider persistence = BankingAppConfig.PersistenceProvider;

        public CheckingAccount CreateCheckingAccount(IEnumerable<Client> owners)
        {
            throw new NotImplementedException();
        }

        public IndividualClient CreateIndividualClient(PersonData data)
        {
            IPerson person = persistence.GetPersonRepository().Add(new NewPerson(data));
            return new IndividualClient(
                persistence.GetClientRepository().Add(new NewClient(person.PersonId))
                , person
                );
        }

        public IndividualClient FindIndividualClient(PersonData personData)
        {
            var personRepo = persistence.GetPersonRepository();
            IPerson person;
            if (personData.personId != null)
            {
                person = (from p in personRepo.Items
                    where p.PersonId == personData.personId
                    select p
                    ).Single();
            }
            else
            {
                person = BuildPersonQuery(personData, personRepo).Single();
            }

            var clientRepo = persistence.GetClientRepository();
            IClient client = (from c in clientRepo.Items
                              where c.PersonId == person.PersonId
                              select c
                              ).Single();

            return new IndividualClient(client, person);
        }

        public IndividualClient FindIndividualClient(ClientData clientData)
        {
            var clientRepo = persistence.GetClientRepository();
            IClient client;
            if (clientData.clientId != null)
            {
                client = (from c in clientRepo.Items
                          where c.ClientId == clientData.clientId
                          select c
                    ).Single();
            }
            else if (clientData.personId != null)
            {
                var personData = new PersonData();
                personData.personId = clientData.personId;

                return FindIndividualClient(personData);
            }
            else
            {
                client = BuildClientQuery(clientData, clientRepo).Single();
            }

            var personRepo = persistence.GetPersonRepository();
            IPerson person = (from p in personRepo.Items
                              where p.PersonId == client.PersonId
                              select p
                              ).Single();

            return new IndividualClient(client, person);
        }

        private IQueryable<IClient> BuildClientQuery(ClientData clientData, IRepository<IClient> clientRepo)
        {
            var query = clientRepo.Items;

            if(clientData.active != null) query = query.Where(c => c.Active == clientData.active);

            return query;
        }

        private IQueryable<IPerson> BuildPersonQuery(PersonData personData, IRepository<IPerson> personRepo)
        {
            var query = personRepo.Items;

            if (personData.DateOfBirth != null && personData.DateOfBirth != DateTime.MinValue) query = query.Where(p => p.DateOfBirth == personData.DateOfBirth);
            if (personData.Deceased != null) query = query.Where(p => p.Deceased == personData.Deceased);
            if (personData.FirstName != null) query = query.Where(p => p.FirstName == personData.FirstName);
            if (personData.LastName != null) query = query.Where(p => p.LastName == personData.LastName);
            if (personData.Nip != null) query = query.Where(p => p.Nip == personData.Nip);
            if (personData.Pesel != null) query = query.Where(p => p.Pesel == personData.Pesel);

            return query;
        }
    }
}
