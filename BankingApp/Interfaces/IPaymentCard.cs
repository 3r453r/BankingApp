using System;

namespace BankingApp.Interfaces
{
    public interface IPaymentCard
    {
        string CardNumber { get; }

        long AccountId { get; }

        DateTime Issued { get; }

        bool Suspended { get; set; }
    }
}