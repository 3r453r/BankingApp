using Xunit;
using BankingApp.Classes;
using BankingApp.Interfaces;
using System;
using Moq;
using BankingApp.Repositories;

namespace BankingAppTest
{
    public class IndividualClientTest
    {
        private static Mock<IClient> clientMock = new Mock<IClient>();
        private static Mock<IPerson> personMock = new Mock<IPerson>();

        private IndividualClient factClient = ClientRepository.HasClient(1) ?
            ClientRepository.GetClient(1) as IndividualClient : new IndividualClient(clientProperties(clientMock, true, 1, DateTime.Now, null).Object, personProperties(personMock).Object);

        private static Mock<IClient> clientProperties(Mock<IClient> mock, bool active, long id, DateTime created, DateTime? deleted)
        {
            return mock.SetupAllProperties()
            //.SetupProperty(m => m.Active, active)
            //.SetupProperty(m => m.ClientId, id)
            //.SetupProperty(m => m.Created, created)
            //.SetupProperty(m => m.Deleted, deleted)
            ;
        }

        private static Mock<IPerson> personProperties(Mock<IPerson> mock)
        {
            return mock.SetupAllProperties()           
                //.SetupProperty(m => m.DateOfBirth, DateTime.Parse("2000-03-26"))
                //.SetupProperty(m => m.Deceased, false)
                //.SetupProperty(m => m.FirstName, "Adam")
                //.SetupProperty(m => m.LastName, "Spadam")
                //.SetupProperty(m => m.Nip, "908134531")
                //.SetupProperty(m => m.PersonId, 1)
                //.SetupProperty(m => m.Pesel, "67032813467")
                ;
        }

        [Fact]
        public void IsClient()
        {
            Assert.True(factClient is IClient);
        }

        [Fact]
        public void IsPerson()
        {
            Assert.True(factClient is IPerson);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        public void IdIsUsedForEquality(long id1, long id2)
        {
            var c1 = ClientRepository.HasClient(id1) ? ClientRepository.GetClient(id1) : new IndividualClient(clientProperties(clientMock, true, id1, DateTime.Now, null).Object, personProperties(personMock).Object);
            var c2 = ClientRepository.HasClient(id2) ? ClientRepository.GetClient(id2) : new IndividualClient(clientProperties(clientMock, true, id2, DateTime.Now, null).Object, personProperties(personMock).Object);
            if (c1.ClientId == c2.ClientId)
            {
                Assert.True(c1 == c2);
                Assert.True(c1.Equals(c2));
            }
            else
            {
                Assert.False(c1 == c2);
                Assert.False(c1.Equals(c2));
            }
        }

        [Fact]
        public void OpenedAccountIsAddedToAccounts()
        {
            var account = new CheckingAccount("1", DateTime.Now, null);
            factClient.OpenAccount(account);
            Assert.Contains(account, factClient.GetAccounts());
        }

        [Fact]
        public void OpenedAccountHasClientAsOwner()
        {
            var account = new CheckingAccount("1", DateTime.Now, null);
            factClient.OpenAccount(account);
            Assert.Contains(factClient, account.GetOwners());
        }

        [Fact]
        public void ClosedAccountIsRemovedFromAccounts()
        {
            var account = new CheckingAccount("1", DateTime.Now, null);
            factClient.OpenAccount(account);
            factClient.CloseAccount(account.AccountNumber);
            Assert.DoesNotContain(account, factClient.GetAccounts());
        }

        [Fact]
        public void ClosedAccountDoesntHaveClientAsOwner()
        {
            var account = new CheckingAccount("1", DateTime.Now, null);
            factClient.OpenAccount(account);
            factClient.CloseAccount(account.AccountNumber);
            Assert.DoesNotContain(factClient, account.GetOwners());
        }
    }
}
