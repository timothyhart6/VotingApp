using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CivicsApp.Models.Representatives.CompleteListOfReps
{
    public class RepresentativeAdapter
    {
        public Representative ConvertToRepresentativeObject(Member ApiRepresentative)
        {
            Representative Representative = new Representative();

            Representative.FirstName = ApiRepresentative.FirstName;
            Representative.LastName = ApiRepresentative.LastName;
            Representative.State = ApiRepresentative.State;
            Representative.District = ApiRepresentative.District;
            return Representative;
        }
    }
}
