using BankingApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Classes
{
    public class CheckingAccount : Account
    {
        #region StaticProperies
        #endregion

        #region StaticMethods
        #endregion

        #region Constructors
        public CheckingAccount(string accountNumber, List<IClient> owners)
        {
            AccountNumber = accountNumber;
            Owners = owners;
        }

        public CheckingAccount(string accountNumber) : this(accountNumber, new List<IClient>()) { }
        #endregion

        #region Properties
        #endregion

        #region Methods
        #endregion

        #region Operators
        #endregion
    }
}
