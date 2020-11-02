using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CivicsApp.Models.Representatives.CompleteListOfReps
{
    public class RepresentativeAdapter : ITarget
    {
        List<Representative> representatives = new List<Representative>();
        public List<Representative> ReturnListOfHouseMembers(ListOfHouseMembers deserializedClass)
        {

             for (int i = 0; i < deserializedClass.Results[0].Members.Count; i++)
            {
                var apiMember = deserializedClass.Results[0].Members[i];

                representatives.Add(new Representative(apiMember.FirstName));
            }
            return representatives;
        }
    }
}
