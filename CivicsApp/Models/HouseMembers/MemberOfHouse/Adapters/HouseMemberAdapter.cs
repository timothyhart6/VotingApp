using CivicsApp.Models.Representatives.MemberOfHouse;

namespace CivicsApp.Models.HouseMembers.MemberOfHouse
{
    public class HouseMemberAdapter
    {
        public HouseMember ConvertToHouseMemeberObject(HouseMemberResult proPublicaHouseMember, DistrictRepresentatives.Official googleRep)
        {
            HouseMember houseMember = new HouseMember();

            houseMember.FirstName = proPublicaHouseMember.FirstName;
            houseMember.LastName = proPublicaHouseMember.LastName;
            houseMember.Phone = googleRep.Phones[0];

            return houseMember;
        }
    }
}