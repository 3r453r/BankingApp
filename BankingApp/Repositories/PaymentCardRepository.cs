using System;
using System.Collections.Generic;
using System.Text;
using BankingApp.Interfaces;

namespace BankingApp.Repositories
{
    class PaymentCardRepository
    {
        private static List<IPaymentCard> paymentCards = new List<IPaymentCard>();

        public static void Add(IPaymentCard paymentCard) => paymentCards.Add(paymentCard);

        public static IEnumerable<IPaymentCard> PaymentCards => paymentCards;
    }
}
