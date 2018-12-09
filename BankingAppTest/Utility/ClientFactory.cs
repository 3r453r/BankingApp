using System;
using System.Collections.Generic;
using BankingApp.Classes;
using BankingApp.Data;
using BankingApp.Interfaces;
using BankingApp.UI;
using BankingAppMemoryPerisitence;
using Moq;

namespace BankingAppTest.Utility
{
    public static class ClientFactory
    {
        private static MemoryPeristenceProvider persistenceProvider = new MemoryPeristenceProvider();
        private static EmployeeActions employeeActions = new EmployeeActions();

        public static IndividualClient GetIndividualClient(PersonData data)
        {
            return employeeActions.CreateIndividualClient(data);
        }

        public static Client GetClient(DateTime created, List<IAccount> accounts = null, DateTime? deleted = null, bool active = true)
        {
            if (accounts == null)
                accounts = new List<IAccount>();

            var iClientMock = MockProvider.GetIClientMock(active, created, deleted);

            iClientMock.Setup(x => x.GetAccounts()).Returns(accounts);

            return new Mock<Client>(iClientMock).Object;
        }

        public static Client GetClient(List<IAccount> accounts = null, DateTime? deleted = null, bool active = true)
        {
            if (accounts == null)
                accounts = new List<IAccount>();

            var iClientMock = MockProvider.GetIClientMock(active, DateTime.Now, deleted);

            iClientMock.Setup(x => x.GetAccounts()).Returns(accounts);

            return new Mock<Client>(iClientMock.Object).Object;
        }
    }
}
