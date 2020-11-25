using System;
using CivicsApp.Models.Representatives.MemberOfHouse;
using CivicsApp.Models.Senators.Senator;

namespace CivicsApp.Models.DistrictRepresentatives
{
    public class CurrentDistrictRepresentatives
    {
        public Senator senator1;
        public Senator senator2;
        public HouseMember houseMember;

        public CurrentDistrictRepresentatives(Senator senator1, Senator senator2, HouseMember houseMember)
        {
            this.senator1 = senator1;
            this.senator2 = senator2;
            this.houseMember = houseMember;
        }

        



    }
}
