using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Interfaces
{
    public interface IClient
    {
        IEnumerable<IAccount> GetAccounts();

        IEnumerable<IPaymentCard> GetPaymentCards();

        bool Active { get; }

        long ClientId { get; }

        DateTime Created { get; }

        DateTime Deleted { get; }

        void OpenAccount(IAccount account);

        void CloseAccount(string accountNumber);

        void AddCard(IPaymentCard card);

        void RemoveCard(string cardNumber);

        void Delete();
    }
}
