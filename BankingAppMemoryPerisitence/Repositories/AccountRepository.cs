using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankingApp.Interfaces;
using BankingApp.Persistence;

namespace BankingAppMemoryPersistence.Repositories
{
    public class AccountRepository : IRepository<IAccount>
    {
        private List<IAccount> accounts = new List<IAccount>();

        public IAccount Add(IAccount account)
        {
            accounts.Add(account);
            return account;
        }

        public void Remove(IAccount account) => accounts.Remove(account);

        public void Save(IAccount t)
        {
        }

        public IQueryable<IAccount> Items => accounts.AsQueryable();
    }
}
