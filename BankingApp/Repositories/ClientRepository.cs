using BankingApp.Interfaces;
using System.Collections.Generic;

namespace BankingApp.Repositories
{
    public static class ClientRepository
    {
        private static List<IClient> clients = new List<IClient>();

        public static void Add(IClient client) => clients.Add(client);

        public static IEnumerable<IClient> Clients => clients;
    }
}
