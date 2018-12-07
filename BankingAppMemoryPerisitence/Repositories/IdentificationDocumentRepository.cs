using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankingApp.Interfaces;
using BankingApp.Persistence;

namespace BankingAppMemoryPersistence.Repositories
{
    public class IdentificationDocumentRepository : IRepository<IIdentificationDocument>
    {
        static long Id;

        private List<IIdentificationDocument> identificationDocuments = new List<IIdentificationDocument>();

        public IIdentificationDocument Add(IIdentificationDocument identificationDocument)
        {
            identificationDocuments.Add(identificationDocument);
            return identificationDocument;
        }

        public void Save(IIdentificationDocument identificationDocument)
        {
        }

        public void Remove(IIdentificationDocument identificationDocument) => identificationDocuments.Remove(identificationDocument);

        public IQueryable<IIdentificationDocument> Items => identificationDocuments.AsQueryable();
    }
}
