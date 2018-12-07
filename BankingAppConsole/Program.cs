using BankingApp.Configuration;
using BankingApp.Persistence;
using BankingAppMemoryPerisitence;
using System;

namespace BankingAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            new BankingAppConfig().SetPersistenceProvider(new MemoryPeristenceProvider());
        }
    }
}
