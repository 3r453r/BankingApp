using BankingApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Transactions;

namespace BankingApp.Classes
{
    public abstract class Client : IClient
    {
        protected List<IAccount> Accounts { get; set; }

        public bool Active { get; protected set; }

        public long ClientId { get; protected set; }

        public DateTime Created { get; protected set; }

        public DateTime Deleted { get; protected set; }

        public abstract void AddCard(IPaymentCard card);       

        public void Delete()
        {
            using (var scope = new TransactionScope())
            {
                foreach (var account in Accounts)
                {
                    CloseAccount(account.AccountNumber);
                }
                scope.Complete();
            }
                
        }

        public abstract IEnumerable<IAccount> GetAccounts();

        public abstract IEnumerable<IPaymentCard> GetPaymentCards();

        public void OpenAccount(IAccount account)
        {
            account.AddOwner(this);
            Accounts.Add(account);
        }

        public void CloseAccount(string accountNumber)
        {
            try
            {
                Accounts.Single(a => a.AccountNumber == accountNumber).RemoveOwner(this.ClientId);
            }
            catch (InvalidOperationException)
            {
                throw new ArgumentException($"Account {accountNumber} not found or duplicated for client {ClientId}");
            }
        }

        public abstract void RemoveCard(string cardNumber);

        public override bool Equals(object obj)
        {
            return obj != null && obj.GetType().BaseType.Equals(typeof(Client))
                && ClientId == (obj as Client).ClientId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ClientId);
        }

        public static bool operator ==(Client client1, Client client2)
        {
            return EqualityComparer<Client>.Default.Equals(client1, client2);
        }

        public static bool operator !=(Client client1, Client client2)
        {
            return !(client1 == client2);
        }
    }
}
