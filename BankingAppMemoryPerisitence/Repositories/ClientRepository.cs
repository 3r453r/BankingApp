using BankingApp.Interfaces;
using BankingApp.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BankingAppMemoryPersistence.Repositories
{
    public class ClientRepository : IRepository<IClient>
    {       
        private static long lastId = 1;
        private static ClientRepository clientRepository;
        public static ClientRepository Repository
        {
            get
            {
                if (clientRepository == null) clientRepository = new ClientRepository();
                return clientRepository;
            }
        }

        private List<IClient> clients = new List<IClient>();

        private ClientRepository()
        {
        }

        public IClient Add(IClient client)
        {
            var _client = new Client(client);
            clients.Add(_client);
            return _client;
        }

        public void Remove(IClient client) => clients.Remove(client);

        public void Save(IClient client)
        {
        }

        public IQueryable<IClient> Items => clients.AsQueryable();

        private class Client : IClient
        {
            public bool Active { get; set; }
            public long ClientId { get; set; }
            public DateTime Created { get; set; }
            public DateTime? Deleted { get; set; }
            public long? PersonId { get; set; }

            public Client(IClient client)
            {
                Active = client.Active;
                ClientId = lastId++;
                Created = client.Created;
                Deleted = client.Deleted;
                PersonId = client.PersonId;
            }

            public void AddCard(IAccount account, IPaymentCard card)
            {
                throw new NotImplementedException();
            }

            public void CloseAccount(IAccount account)
            {
                throw new NotImplementedException();
            }

            public void Delete()
            {
                throw new NotImplementedException();
            }

            public IEnumerable<IAccount> GetAccounts()
            {
                throw new NotImplementedException();
            }

            public IEnumerable<IPaymentCard> GetPaymentCards()
            {
                throw new NotImplementedException();
            }

            public void OpenAccount(IAccount account)
            {
                throw new NotImplementedException();
            }

            public void RemoveCard(IAccount account, IPaymentCard card)
            {
                throw new NotImplementedException();
            }
        }
    }
}
