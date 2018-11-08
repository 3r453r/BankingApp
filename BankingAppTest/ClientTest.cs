using BankingApp.Classes;
using BankingAppTest.Utility;
using System;
using Xunit;

namespace BankingAppTest
{
    public class ClientTest
    {
        private Client NewClient => ClientFactory.GetClient();

        [Fact]
        public void IsClient()
        {
            Assert.True(NewClient is Client);
        }

        [Fact]
        public void OpenedAccountIsAddedToAccounts()
        {
            var account = new CheckingAccount("1", DateTime.Now, null);
            var client = NewClient;
            client.OpenAccount(account);
            Assert.Contains(account, client.GetAccounts());
        }

        [Fact]
        public void OpenedAccountHasClientAsOwner()
        {
            var account = new CheckingAccount("1", DateTime.Now, null);
            var client = NewClient;
            client.OpenAccount(account);
            Assert.Contains(client, account.GetOwners());
        }

        [Fact]
        public void ClosedAccountIsRemovedFromAccounts()
        {
            var account = new CheckingAccount("1", DateTime.Now, null);
            var client = NewClient;
            client.OpenAccount(account);
            client.CloseAccount(account);
            Assert.DoesNotContain(account, NewClient.GetAccounts());
        }

        [Fact]
        public void ClosedAccountDoesntHaveClientAsOwner()
        {
            var account = new CheckingAccount("1", DateTime.Now, null);
            var client = NewClient;
            client.OpenAccount(account);
            client.CloseAccount(account);
            Assert.DoesNotContain(NewClient, account.GetOwners());
        }

        [Fact]
        public void CardCanBeAddedOnlyToClientAccount()
        {
            var account = new CheckingAccount("1", DateTime.Now, null);
            var client = NewClient;
            client.AddCard(account, )
        }
    }
}
