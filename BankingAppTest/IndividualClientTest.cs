using Xunit;
using BankingApp.Classes;
using BankingApp.Interfaces;

namespace BankingAppTest
{
    public class IndividualClientTest
    {
        [Fact]
        public void IsClient()
        {
            Assert.True(new IndividualClient(1) is IClient);
        }

        [Fact]
        public void IsPerson()
        {
            Assert.True(new IndividualClient(1) is IPerson);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        public void IdIsUsedForEquality(long id1, long id2)
        {
            var c1 = new IndividualClient(id1);
            var c2 = new IndividualClient(id2);
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
        public void OpenedAccountIsAddedToList()
        {
            var client = new IndividualClient(1);
            var account = new CheckingAccount("1");
            client.OpenAccount(account);
            Assert.Contains(account, client.GetAccounts());
        }

        [Fact]
        public void OpenedAccountHasClientAsOwner()
        {
            var client = new IndividualClient(1);
            var account = new CheckingAccount("1");
            client.OpenAccount(account);
            Assert.Contains(client, account.GetOwners());
        }
    }
}
