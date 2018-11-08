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

        DateTime? Deleted { get; }

        void OpenAccount(IAccount account);

        void CloseAccount(IAccount account);

        void AddCard(IAccount account, IPaymentCard card);

        void RemoveCard(IAccount account, IPaymentCard card);

        void Delete();
    }
}
