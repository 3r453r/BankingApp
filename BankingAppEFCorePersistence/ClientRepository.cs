using BankingApp.Interfaces;
using BankingApp.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingAppEFCorePersistence
{
    class ClientRepository : IRepository<IClient>
    {
        private BankingAppContext context = new BankingAppContext();

        public IQueryable<IClient> Items => context.Set<Client>().AsQueryable();

        public IClient Add(IClient client)
        {
            var _client = new Client(client);
            var entity = context.Add(_client).Entity;
            context.SaveChanges();
            return entity;
        }

        public void Remove(IClient client)
        {
            context.Remove(context.Find<Client>(client.ClientId));
            context.SaveChanges();
        }

        public void Save(IClient client)
        {
            var _client = context.Find<Client>(client.ClientId);
            _client.Active = client.Active;
            _client.Deleted = client.Deleted ?? _client.Deleted;
            context.Update(_client);
            context.SaveChanges();
        }
    }
}
