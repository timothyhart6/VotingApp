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

        public Representative ConvertToRepresentativeObjectForIndividual(RepResult ApiRepresentative)
        {
            Representative Representative = new Representative();

            Representative.FirstName = ApiRepresentative.FirstName;
            Representative.LastName = ApiRepresentative.LastName;
            Representative.State = ApiRepresentative.Roles[0].State;
            Representative.District = ApiRepresentative.Roles[0].District;
            Representative.TwitterAccount = ApiRepresentative.TwitterAccount;
            return Representative;
        }
    }
}
