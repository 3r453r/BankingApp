using System;
using System.Collections.Generic;
using System.Text;
using BankingApp.Interfaces;

namespace BankingApp.Repositories
{
    class AccountRepository
    {
        private static List<IAccount> accounts = new List<IAccount>();

        public static void Add(IAccount account) => accounts.Add(account);

        public static IEnumerable<IAccount> Accounts => accounts;
    }
}
