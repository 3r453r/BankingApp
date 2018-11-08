using System;
using System.Collections.Generic;

namespace BankingApp.Interfaces
{
    public interface IAccount
    {
        long AccountId { get; }

        bool Virtual { get; }

        string AccountNumber { get; set; }

        DateTime Opened { get; }

        DateTime? Closed { get; }

        IEnumerable<IClient> GetOwners();

        void AddOwner(IClient client);

        void RemoveOwner(long clientId);

        IEnumerable<IPaymentCard> GetCards();

        void AddCard(IPaymentCard card);

        void RemoveCard(string cardNumber);
    }
}