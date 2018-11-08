using BankingApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Classes
{
    public abstract class Account : IAccount
    {
        public long AccountId { get; }

        public string AccountNumber { get; set; }

        public DateTime Opened { get; }

        public DateTime Closed { get; }

        protected List<IClient> Owners { get; set; }

        public void AddOwner(IClient client)
        {
            if(!Owners.Contains(client))
                Owners.Add(client);
        }

        public void RemoveOwner(IClient client)
        {
            Owners.Remove(client);
        }

        public IEnumerable<IClient> GetOwners()
        {
            return Owners;
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj.GetType().BaseType.Equals(typeof(Account))
                && AccountNumber == (obj as Account).AccountNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(AccountId, AccountNumber);
        }

        public static bool operator ==(Account account1, Account account2)
        {
            return EqualityComparer<Account>.Default.Equals(account1, account2);
        }

        public static bool operator !=(Account account1, Account account2)
        {
            return !(account1 == account2);
        }
    }
}
