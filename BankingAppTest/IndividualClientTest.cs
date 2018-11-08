using Xunit;
using BankingApp.Classes;
using BankingApp.Interfaces;
using BankingAppTest.Utility;
using BankingAppTest.IndividualClientTestData;

namespace BankingAppTest
{
    public class IndividualClientTest
    {
        private IndividualClient NewIndividualClient => ClientFactory.GetIndividualClient();

        [Fact]
        public void IsIPerson()
        {
            Assert.True(NewIndividualClient is IPerson);
        }

        [Theory]
        [ClassData(typeof(IdIsUsedForEqualityData))]
        public void IdIsUsedForEquality(IndividualClient c1, IndividualClient c2)
        {
            bool b = c1.Equals(c2);
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
    }
}
