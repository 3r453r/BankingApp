using BankingApp.Interfaces;
using System;
using System.Collections.Generic;

namespace BankingApp.Persistence.Entities
{
    class NewClient : IClient
    {
        public bool Active { get; set; }
        public long ClientId => -1;
        public DateTime Created => DateTime.Now;
        public DateTime? Deleted { get; set; }
        public long? PersonId { get; set; }

        public NewClient(long personId)
        {
            PersonId = personId;
            Active = true;
        }

        public void AddCard(IAccount account, IPaymentCard card)
        {
        }

        public void CloseAccount(IAccount account)
        {
        }

        public void Delete()
        {
        }

        public IEnumerable<IAccount> GetAccounts()
        {
            return new IAccount[0];
        }

        public IEnumerable<IPaymentCard> GetPaymentCards()
        {
            return new IPaymentCard[0];
        }

        public void OpenAccount(IAccount account)
        {
        }

        public void RemoveCard(IAccount account, IPaymentCard card)
        {
        }
    }
}
