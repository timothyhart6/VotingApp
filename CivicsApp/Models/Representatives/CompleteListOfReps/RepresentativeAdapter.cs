using System;
using System.Collections.Generic;

namespace CivicsApp.Models.Representatives.CompleteListOfReps
{
    public class RepresentativeAdapter : ITarget
    {

        public List<Representative> ReturnListOfHouseMembers(ListOfHouseMembers deserializedClass)
        {
            List<Representative> representatives = new List<Representative>();

            for (int i = 0; i < deserializedClass.Results[0].Members.Count;)
            {
                var apiMember = deserializedClass.Results[0].Members[i];

                representatives.Add(new Representative(apiMember.FirstName));
            }
            return representatives;
        }
    }
}
