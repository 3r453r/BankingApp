using System;
using System.Collections.Generic;
using System.Text;
using BankingApp.Interfaces;

namespace BankingApp.Repositories
{
    class IdentificationDocumentRepository
    {
        private static List<IIdentificationDocument> identificationDocuments = new List<IIdentificationDocument>();

        public static void Add(IIdentificationDocument identificationDocument) => identificationDocuments.Add(identificationDocument);

        public static IEnumerable<IIdentificationDocument> IdentificationDocuments => identificationDocuments;
    }
}
