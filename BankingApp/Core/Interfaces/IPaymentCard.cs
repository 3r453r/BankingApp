using System;

namespace BankingApp.Interfaces
{
    public interface IPaymentCard
    {
        long paymentCardId { get; }

        string CardNumber { get; }

        long AccountId { get; }

        DateTime Issued { get; }

        DateTime? Suspended { get; set; }
    }
}