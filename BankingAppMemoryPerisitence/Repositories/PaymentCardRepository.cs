using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankingApp.Interfaces;
using BankingApp.Persistence;

namespace BankingAppMemoryPersistence.Repositories
{
    public class PaymentCardRepository : IRepository<IPaymentCard>
    {
        private List<IPaymentCard> paymentCards = new List<IPaymentCard>();

        public IPaymentCard Add(IPaymentCard paymentCard)
        {
            paymentCards.Add(paymentCard);
            return paymentCard;
        }

        public void Remove(IPaymentCard paymentCard) => paymentCards.Remove(paymentCard);

        public void Save(IPaymentCard t)
        {
        }

        public IQueryable<IPaymentCard> Items => paymentCards.AsQueryable();
    }
}
