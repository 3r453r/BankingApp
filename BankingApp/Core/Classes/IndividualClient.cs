using BankingApp.Interfaces;
using BankingApp.Persistence;
using System;
using System.Collections.Generic;

namespace BankingApp.Classes
{
    public class IndividualClient : Client, IPerson
    {
        #region Constructors
        public IndividualClient(IClient client, IPerson person) : base(client)
        {
            Documents = person.GetDocuments();
            this.person = person;
        }
        #endregion

        #region Properties and Fields
        private IPerson person;

        private IEnumerable<IIdentificationDocument> Documents { get; }

        public string FirstName { get => person.FirstName; set => person.FirstName = value; }

        public string LastName { get => person.LastName; set => person.LastName = value; }

        public DateTime DateOfBirth { get => person.DateOfBirth; set => person.DateOfBirth = value; }

        public string Pesel { get => person.Pesel; set => person.Pesel = value; }

        public string Nip { get => person.Nip; set => person.Nip = value; }

        public long PersonId { get; }

        public bool Deceased { get => person.Deceased; set => person.Deceased = value; }

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
        #endregion
    }
}
