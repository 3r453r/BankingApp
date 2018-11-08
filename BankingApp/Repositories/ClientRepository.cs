using BankingApp.Classes;
using BankingApp.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApp.Repositories
{
    public static class ClientRepository
    {
        private static long LastId = 1;

        private static List<IClient> Clients = new List<IClient>();

        public static void Add(IClient client)
        {
            if (Clients.Any(c => c.ClientId == client.ClientId))
                throw new ArgumentException($"client with Id[{client.ClientId}] already exists");
            Clients.Add(client);
        }

        public static bool HasClient(long clientId)
        {
            return Clients.Any(c => c.ClientId == clientId);
        }

        public static bool HasClient(IClient client)
        {
            return Clients.Contains(client);
        }

        public static Client GetClient(long clientId)
        {
            return Clients.First(c => c.ClientId == clientId) as Client;
        }

        public static string Serialize()
        {
            return JsonConvert.SerializeObject(Clients);
        }
    }
}
