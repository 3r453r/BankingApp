using BankingApp.Classes;
using BankingApp.UI;
using BankingAppTest.Utility;
using System;
using System.Collections.Generic;
using Xunit;

namespace BankingAppTest
{
    public class ClientTest
    {
        private Client NewClient => ClientFactory.GetClient();
        private EmployeeActions employeeActions = new EmployeeActions();

        [Fact]
        public void IsClient()
        {
            Assert.True(NewClient is Client);
        }

        [Fact]
        public void OpenedAccountIsAddedToAccounts()
        {
            var account = employeeActions.CreateCheckingAccount(new List<IndividualClient>());
            var client = NewClient;
            client.OpenAccount(account);
            Assert.Contains(account, client.GetAccounts());
        }

        [Fact]
        public void OpenedAccountHasClientAsOwner()
        {
            var account = employeeActions.CreateCheckingAccount(new List<IndividualClient>());
            var client = NewClient;
            client.OpenAccount(account);
            Assert.Contains(client, account.GetOwners());
        }

        [Fact]
        public void ClosedAccountIsRemovedFromAccounts()
        {
            var account = employeeActions.CreateCheckingAccount(new List<IndividualClient>());
            var client = NewClient;
            client.OpenAccount(account);
            client.CloseAccount(account);
            Assert.DoesNotContain(account, NewClient.GetAccounts());
        }

        [Fact]
        public void ClosedAccountDoesntHaveClientAsOwner()
        {
            var account = employeeActions.CreateCheckingAccount(new List<IndividualClient>());
            var client = NewClient;
            client.OpenAccount(account);
            client.CloseAccount(account);
            Assert.DoesNotContain(NewClient, account.GetOwners());
        }
    }
}
