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

        public DateTime? Deleted { get; protected set; }

        public Client(IClient client, IRepository<IClient> repository)
        {
            Accounts = client.GetAccounts().ToList();
            Created = client.Created;
            Deleted = client.Deleted;
            Active = client.Active;
            ClientId = client.ClientId;

            repository.Add(client);
        }

        public void AddCard(IAccount account, IPaymentCard card)
        {

        }

        public void RemoveCard(IAccount account, IPaymentCard card) => throw new NotImplementedException();

        public void Delete()
        {
            using (var scope = new TransactionScope())
            {
                foreach (var account in Accounts)
                {
                    CloseAccount(account);
                }
                scope.Complete();
            }
               
        }

        public IEnumerable<IAccount> GetAccounts() => Accounts;

        public IEnumerable<IPaymentCard> GetPaymentCards() => Accounts.SelectMany(a => a.GetCards());

        public void OpenAccount(IAccount account)
        {
            account.AddOwner(this);
            Accounts.Add(account);
        }

        public void CloseAccount(IAccount account)
        {
            try
            {
                account.RemoveOwner(this);
            }
            catch (InvalidOperationException)
            {
                throw new ArgumentException($"Account {account.AccountNumber} not found or duplicated for client {ClientId}");
            }
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is Client
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
