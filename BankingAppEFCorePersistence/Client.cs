using BankingApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingAppEFCorePersistence
{
    public class Client : IClient
    {
        public long ClientId { get; set; }

        public long? PersonId { get; set; }
        public Person Person { get; set; }

        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Deleted { get; set; }

        public Client(IClient client) : this(client.Active, client.PersonId)
        {
        }

        internal Client(bool active, long? personId)
        {
            Active = active;
            PersonId = personId;
            Created = DateTime.Now;
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
