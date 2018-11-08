using BankingApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApp.Classes
{
    public class IndividualClient : Client, IPerson
    {
        #region StaticProperies
        #endregion

        #region StaticMethods
        #endregion

        #region Constructors
        public IndividualClient(IEnumerable<IAccount> accounts, IEnumerable<IPaymentCard> paymentCards, IEnumerable<IIdentificationDocument> documents, long id)
        {
            Accounts = accounts.ToList();
            PaymentCards = paymentCards.ToList();
            Created = DateTime.Now;
            Active = true;
            ClientId = id;
        }

        public IndividualClient(long id) : this(new List<IAccount>(), new List<IPaymentCard>(), new List<IIdentificationDocument>(), id) { }
        #endregion

        #region Properties
        private IEnumerable<IIdentificationDocument> Documents { get; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Pesel { get; set; }

        public string Nip { get; set; }

        public long PersonId { get; }

        public bool Deceased { get; set; }

        #endregion

        #region Methods
        public IEnumerable<IIdentificationDocument> GetDocuments()
        {
            throw new NotImplementedException();
        }

        public void AddDocument(IIdentificationDocument document)
        {
            throw new NotImplementedException();
        }

        public override void AddCard(IPaymentCard card)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<IAccount> GetAccounts()
        {
            return Accounts;
        }

        public override IEnumerable<IPaymentCard> GetPaymentCards()
        {
            throw new NotImplementedException();
        }

        public override void RemoveCard(string cardNubmer)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
