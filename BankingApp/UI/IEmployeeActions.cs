using BankingApp.Classes;
using BankingApp.Data;
using System.Collections.Generic;

namespace BankingApp.UI
{
    interface IEmployeeActions
    {
        IndividualClient CreateIndividualClient(PersonData data);

        CheckingAccount CreateCheckingAccount(IEnumerable<Client> owners);

        IndividualClient FindIndividualClient(ClientData clientData);

        IndividualClient FindIndividualClient(PersonData personData);
    }
}
