using System;
using System.Collections.Generic;

namespace BankingApp.Interfaces
{
    public interface IAccount
    {
        long AccountId { get; }

        decimal Balance { get; }

        bool Virtual { get; }

        string AccountNumber { get; }

        DateTime Opened { get; }

        DateTime? Closed { get; }

        IEnumerable<IClient> GetOwners();

        void AddOwner(IClient owner);

        void RemoveOwner(IClient owner);

        IEnumerable<IPaymentCard> GetCards();

        void AddCard(IPaymentCard card);

        void RemoveCard(IPaymentCard card);      
    }
}