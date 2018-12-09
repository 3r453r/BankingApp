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

        public Client(IClient client)
        {
            Active = client.Active;
            Created = DateTime.Now;
        }

        public void AddCard(IAccount account, IPaymentCard card)
        {
            throw new NotImplementedException();
        }

        public void CloseAccount(IAccount account)
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IAccount> GetAccounts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPaymentCard> GetPaymentCards()
        {
            throw new NotImplementedException();
        }

        public void OpenAccount(IAccount account)
        {
            throw new NotImplementedException();
        }

        public void RemoveCard(IAccount account, IPaymentCard card)
        {
            throw new NotImplementedException();
        }
    }
}
