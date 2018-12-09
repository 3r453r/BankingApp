using BankingApp.Data;
using BankingAppTest.Utility;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BankingAppTest.IndividualClientTestData
{
    class IdIsUsedForEqualityData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var c1 = ClientFactory.GetIndividualClient(GetPersonData());
            var c2 = ClientFactory.GetIndividualClient(GetPersonData());
            yield return new object[] { c1, c1};
            yield return new object[] { c1, c2 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        PersonData GetPersonData()
        {
            var data = new PersonData();
            data.FirstName = "A";
            data.LastName = "B";
            data.DateOfBirth = DateTime.Parse("1988-03-26");
            data.Pesel = "018284";
            data.Nip = "8173913";

            return data;
        }
    }
}
