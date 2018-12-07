using System;
using System.Collections.Generic;
using BankingApp.Classes;
using BankingApp.Configuration;
using BankingApp.Data;
using BankingApp.Persistence;

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
            return new IndividualClient(data);
        }
    }
}
