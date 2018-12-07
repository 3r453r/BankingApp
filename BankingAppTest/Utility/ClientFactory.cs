using System;
using System.Collections.Generic;
using BankingApp.Classes;
using BankingApp.Interfaces;
using BankingAppMemoryPerisitence;
using Moq;

namespace BankingAppTest.Utility
{
    public static class ClientFactory
    {
        private static MemoryPeristenceProvider persistenceProvider = new MemoryPeristenceProvider();

        public static IndividualClient GetIndividualClient(DateTime dateOfBirth, DateTime created, DateTime? deleted = null,
            bool active = true, bool deceased = false,
            string firstName = "A", string lastName = "B", string pesel = "1", string nip = "1")
        {
            return new IndividualClient(
                MockProvider.GetIClientMock(active, created, deleted).Object
                , MockProvider.GetIPersonMock(dateOfBirth, deceased, firstName, lastName, pesel, nip).Object
                , persistenceProvider
                );
        }

        public static IndividualClient GetIndividualClient(DateTime? deleted = null,
            bool active = true, bool deceased = false,
            string firstName = "A", string lastName = "B", string pesel = "1", string nip = "1")
        {
            return new IndividualClient(
                MockProvider.GetIClientMock(active, DateTime.Now, deleted).Object
                , MockProvider.GetIPersonMock(DateTime.MinValue, deceased, firstName, lastName, pesel, nip).Object
                , persistenceProvider
                );
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
