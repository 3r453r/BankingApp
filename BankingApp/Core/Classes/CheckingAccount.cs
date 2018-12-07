using BankingApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Classes
{
    public class CheckingAccount : Account
    {
        #region Constructors
        public CheckingAccount(string accountNumber, List<IClient> owners, DateTime opened, DateTime? closed)
        {
            AccountNumber = accountNumber;
            Owners = owners;
            Opened = opened;
            Closed = closed;
            Virtual = false;
        }

        public CheckingAccount(string accountNumber, DateTime opened, DateTime? closed) : this(accountNumber, new List<IClient>(), opened, closed) { }
        #endregion

        #region Properties
        #endregion

        #region Methods
        #endregion

        #region Operators
        #endregion
    }
}
