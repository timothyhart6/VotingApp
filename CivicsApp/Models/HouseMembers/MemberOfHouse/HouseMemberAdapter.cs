using CivicsApp.Models.Representatives.MemberOfHouse;

namespace CivicsApp.Models.HouseMembers.MemberOfHouse
{
    public class HouseMemberAdapter
    {
        public HouseMember ConvertToHouseMemeberObject(HouseMemberResult proPublicaHouseMember)
        {
            HouseMember houseMember = new HouseMember();

            houseMember.FirstName = proPublicaHouseMember.FirstName;
            houseMember.LastName = proPublicaHouseMember.LastName;

            return houseMember;
        }
    }
}