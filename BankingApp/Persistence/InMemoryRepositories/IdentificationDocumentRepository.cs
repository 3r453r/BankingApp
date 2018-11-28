using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankingApp.Interfaces;

namespace BankingApp.Repositories
{
    public class IdentificationDocumentRepository : IRepository<IIdentificationDocument>
    {
        private List<IIdentificationDocument> identificationDocuments = new List<IIdentificationDocument>();

        public void Add(IIdentificationDocument identificationDocument) => identificationDocuments.Add(identificationDocument);

        public void Remove(IIdentificationDocument identificationDocument) => identificationDocuments.Remove(identificationDocument);

        public IQueryable<IIdentificationDocument> Elements => identificationDocuments.AsQueryable();
    }
}
