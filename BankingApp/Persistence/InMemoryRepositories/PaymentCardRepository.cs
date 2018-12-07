using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankingApp.Interfaces;

namespace BankingApp.Repositories
{
    public class PaymentCardRepository : IRepository<IPaymentCard>
    {
        private List<IPaymentCard> paymentCards = new List<IPaymentCard>();

        public void Add(IPaymentCard paymentCard) => paymentCards.Add(paymentCard);

        public void Remove(IPaymentCard paymentCard) => paymentCards.Remove(paymentCard);

        public IQueryable<IPaymentCard> Elements => paymentCards.AsQueryable();
    }
}
