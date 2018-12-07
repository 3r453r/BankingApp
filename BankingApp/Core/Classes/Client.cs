using BankingApp.Configuration;
using BankingApp.Interfaces;
using BankingApp.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace BankingApp.Classes
{
    public abstract class Client : IClient
    {
        protected IPersistenceProvider persistence = BankingAppConfig.PersistenceProvider;

        private IClient _client;

        public bool Active { get => _client.Active; set => _client.Active = value; }

        public long ClientId { get => _client.ClientId; }

        public DateTime Created { get => _client.Created; }

        public DateTime? Deleted { get => _client.Deleted; set => _client.Deleted = value; }
        public long? PersonId { get => _client.PersonId; set => _client.PersonId = value; }

        internal Client(IClient client)
        {
            _client = client;
        }

        public void AddCard(IAccount account, IPaymentCard card)
        {

        }

        public void RemoveCard(IAccount account, IPaymentCard card) => throw new NotImplementedException();

        public void Delete()
        {
            using (var scope = new TransactionScope())
            {
                foreach (var account in GetAccounts())
                {
                    CloseAccount(account);
                }
                scope.Complete();
            }
               
        }

        public IEnumerable<IAccount> GetAccounts() => from account in persistence.GetAccountRepository().Items
                                                      where account.GetOwners().Contains(this)
                                                      select account;

        public IEnumerable<IPaymentCard> GetPaymentCards() => GetAccounts().SelectMany(a => a.GetCards());

        public void OpenAccount(IAccount account)
        {
            account.AddOwner(this);
            persistence.GetAccountRepository().Add(account);
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
