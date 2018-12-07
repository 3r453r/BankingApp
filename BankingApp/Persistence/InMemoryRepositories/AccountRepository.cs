using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankingApp.Interfaces;

namespace BankingApp.Repositories
{
    public class AccountRepository : IRepository<IAccount>
    {
        private List<IAccount> accounts = new List<IAccount>();

        public void Add(IAccount account) => accounts.Add(account);

        public void Remove(IAccount account) => accounts.Remove(account);

        public IQueryable<IAccount> Elements => accounts.AsQueryable();
    }
}
