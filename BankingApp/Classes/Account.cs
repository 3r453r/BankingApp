using BankingApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApp.Classes
{
    public abstract class Account : IAccount
    {
        public long AccountId { get; }

        public bool Virtual { get; protected set; }

        public string AccountNumber { get; set; }

        public DateTime Opened { get; protected set; }

        public DateTime? Closed { get; protected set; }

        protected List<IClient> Owners { get; set; }

        protected List<IPaymentCard> Cards { get; set; }

        public void AddOwner(IClient client)
        {
            if(!Owners.Contains(client))
                Owners.Add(client);
        }
            

        public void RemoveOwner(long clientId)
        {
            Owners.Remove(Owners.Single(c => c.ClientId == clientId));
        }

        public IEnumerable<IClient> GetOwners()
        {
            return Owners;
        }

        public IEnumerable<IPaymentCard> GetCards()
        {
            return Cards;
        }

        public void AddCard(IPaymentCard card)
        {
            if (!Cards.Contains(card))
                Cards.Add(card);
        }

        public void RemoveCard(string cardNumber)
        {
            Cards.Remove(Cards.Single(c => c.CardNumber == cardNumber));
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj.GetType().BaseType.Equals(typeof(Account))
                && AccountNumber == (obj as Account).AccountNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(AccountId, AccountNumber);
        }

        public static bool operator ==(Account account1, Account account2)
        {
            return EqualityComparer<Account>.Default.Equals(account1, account2);
        }

        public static bool operator !=(Account account1, Account account2)
        {
            return !(account1 == account2);
        }
    }
}
