using System;
using System.Collections.Generic;

namespace BankingApp.Interfaces
{
    public interface IAccount
    {
        long AccountId { get; }

        string AccountNumber { get; set; }

        DateTime Opened { get; }

        DateTime Closed { get; }

        IEnumerable<IClient> GetOwners();

        void AddOwner(IClient client);

        void RemoveOwner(IClient client);
    }
}