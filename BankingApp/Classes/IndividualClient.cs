using BankingApp.Interfaces;
using BankingApp.Repositories;
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
        public IndividualClient(IClient client, IPerson person)
        {
            Accounts = client.GetAccounts().ToList();
            Created = client.Created;
            Deleted = client.Deleted;
            Active = client.Active;
            ClientId = client.ClientId;
            Pesel = person.Pesel;
            Nip = person.Nip;
            Documents = person.GetDocuments();
            FirstName = person.FirstName;
            LastName = person.LastName;
            DateOfBirth = person.DateOfBirth;
            Deceased = person.Deceased;

            ClientRepository.Add(this);
        }
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
