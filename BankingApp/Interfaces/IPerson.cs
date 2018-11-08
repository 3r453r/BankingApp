using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Interfaces
{
    public interface IPerson
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        DateTime DateOfBirth { get; set; } 

        string Pesel { get; set; }

        string Nip { get; set; }

        long PersonId { get; }

        bool Deceased { get; set; }

        IEnumerable<IIdentificationDocument> GetDocuments();

        void AddDocument(IIdentificationDocument document);
    }
}
