using BankingApp.Classes;
using BankingApp.Interfaces;
using Moq;
using System;
using System.Collections.Generic;

namespace BankingAppTest.Utility
{
    public static class MockProvider
    {
        private static long LastClientId = 1;
        private static long LastPersonId = 1;
        private static long LastCardId = 1;

        public static Mock<IClient> GetIClientMock(bool active, DateTime created, DateTime? deleted)
        {
            var mock = new Mock<IClient>();
            mock.SetupGet(x => x.Active).Returns(active);
            mock.SetupGet(x => x.Created).Returns(created);
            mock.SetupGet(x => x.Deleted).Returns(deleted);
            mock.SetupGet(x => x.ClientId).Returns(LastClientId++);
            return mock;
        }

        public static Mock<IPerson> GetIPersonMock(DateTime dateOfBirth, bool deceased, string firstName, string lastName, string pesel, string nip)
        {
            var mock = new Mock<IPerson>();
            mock.SetupGet(x => x.DateOfBirth).Returns(dateOfBirth);
            mock.SetupGet(x => x.Deceased).Returns(deceased);
            mock.SetupGet(x => x.FirstName).Returns(firstName);
            mock.SetupGet(x => x.LastName).Returns(lastName);
            mock.SetupGet(x => x.Pesel).Returns(pesel);
            mock.SetupGet(x => x.Nip).Returns(nip);
            mock.SetupGet(x => x.PersonId).Returns(LastPersonId++);
            return mock;
        }

        public static Mock<IPaymentCard> GetIPaymentCardMock(string cardNumber, DateTime issued, bool suspended)
        {
            var mock = new Mock<IPaymentCard>();
            mock.SetupGet(x => x.AccountId).Returns(LastCardId++);
            mock.SetupGet(x => x.CardNumber).Returns(cardNumber);
            mock.SetupGet(x => x.Issued).Returns(suspended);
            mock.SetupGet(x => x.Suspended).Returns(LastClientId++);
            return mock;
        }
    }
}
