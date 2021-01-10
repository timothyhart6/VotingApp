using System;
using CivicsApp.Models.Representatives.MemberOfHouse;
using CivicsApp.Models.Senators.Senator;

namespace CivicsApp.Models.UserDistrictRepresentatives
{
    public class DistrictRepresentatives
    {
        public Senator senator1;
        public Senator senator2;
        public HouseMember houseMember;

        public DistrictRepresentatives(HouseMember houseMember)
        {
            this.houseMember = houseMember;
        }
    }
}
