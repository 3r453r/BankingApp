using BankingApp.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Configuration
{
    public class BankingAppConfig
    {
        internal static IPersistenceProvider PersistenceProvider { get; private set; }

        public BankingAppConfig SetPersistenceProvider(IPersistenceProvider persistenceProvider)
        {
            PersistenceProvider = persistenceProvider;
            return this;
        }
    }
}
