using BankingAppTest.Utility;
using System.Collections;
using System.Collections.Generic;

namespace BankingAppTest.IndividualClientTestData
{
    class IdIsUsedForEqualityData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var c1 = ClientFactory.GetIndividualClient();
            var c2 = ClientFactory.GetIndividualClient();
            yield return new object[] { c1, c1};
            yield return new object[] { c1, c2 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
