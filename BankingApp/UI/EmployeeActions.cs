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

        public IndividualClient FindIndividualClient(ClientData clientData, PersonData personData)
        {
            CheckData(clientData, personData);

            var clientRepo = persistence.GetClientRepository();
            var personRepo = persistence.GetPersonRepository();
            IClient client;
            IPerson person;
            if (clientData.clientId > 0)
            {
                var clientQuery = from c in clientRepo.Items
                         where c.ClientId == clientData.clientId
                         select c;
                client = clientQuery.Single();

                var personQuery = from p in personRepo.Items
                                  where p.PersonId == client.PersonId
                                  select p;
                person = personQuery.Single();
            }
            else

            return new IndividualClient(client, person);
        }

        private void CheckData(ClientData clientData, PersonData personData)
        {
            if (clientData.personId != null && personData.personId != null && clientData.personId != personData.personId)
                throw new ArgumentException($"client.PersonId({clientData.personId}) != person.PersonId({personData.personId})");
        }
    }
}
