using BankingApp.Interfaces;
using BankingApp.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingAppEFCorePersistence
{
    public class EFPersistenceProvider : IPersistenceProvider
    {
        public EFPersistenceProvider(string connectionString)
        {
            Configuration.ConnectionString = connectionString;
        }
        public IRepository<IAccount> GetAccountRepository()
        {
            throw new NotImplementedException();
        }

        public IRepository<IClient> GetClientRepository()
        {
            return new ClientRepository();
        }

        public IRepository<IPerson> GetPersonRepository()
        {
            return new PersonRepository();
        }
    }
}
