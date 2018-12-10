using BankingApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Persistence.Entities
{
    class NewAccount : IAccount
    {
        public long AccountId => -1;

        public decimal Balance => 0m;

        public bool Virtual { get; set; }

        public string AccountNumber { get; set; }

        public DateTime Opened => DateTime.Now;

        public DateTime? Closed => null;

        public void AddCard(IPaymentCard card)
        {
        }

        public void AddOwner(IClient owner)
        {
        }

        public IEnumerable<IPaymentCard> GetCards()
        {
            return new IPaymentCard[0];
        }

        public IEnumerable<IClient> GetOwners()
        {
            return new IClient[0];
        }

        public void RemoveCard(IPaymentCard card)
        {
        }

        public void RemoveOwner(IClient owner)
        {
        }
    }
}
