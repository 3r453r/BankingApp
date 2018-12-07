using BankingApp.Interfaces;
using BankingApp.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace BankingAppMemoryPersistence.Repositories
{
    public class ClientRepository : IRepository<IClient>
    {
        private List<IClient> clients = new List<IClient>();

        public void Add(IClient client) => clients.Add(client);

        public void Remove(IClient client) => clients.Remove(client);

        public IQueryable<IClient> Items => clients.AsQueryable();
    }
}
