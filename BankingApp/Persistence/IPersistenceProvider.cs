using BankingApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Persistence
{
    public interface IPersistenceProvider
    {
        IRepository<IClient> GetClientRepository();

        IRepository<IAccount> GetAccountRepository();

        IRepository<IPerson> GetPersonRepository();
    }
}
