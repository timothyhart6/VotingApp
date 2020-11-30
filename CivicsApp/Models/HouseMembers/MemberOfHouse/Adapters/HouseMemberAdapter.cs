using CivicsApp.Models.DistrictRepresentatives;
using CivicsApp.Models.Representatives.MemberOfHouse;


namespace CivicsApp.Models.HouseMembers.MemberOfHouse
{
    public class HouseMemberAdapter
    {
        public HouseMember ConvertToHouseMemeberObject(HouseMemberResult ProPublicaHouseMember, DistrictRepresentatives.Official GoogleRep)
        {
            HouseMember HouseMember = new HouseMember();

            HouseMember.FirstName = ProPublicaHouseMember.FirstName;
            HouseMember.MiddleName = ProPublicaHouseMember.MiddleName;
            HouseMember.LastName = ProPublicaHouseMember.LastName;
            HouseMember.District = ProPublicaHouseMember.District;
            HouseMember.NextElectionYear = ProPublicaHouseMember.NextElection;
            HouseMember.OfficeAddress = new AddressModel(GoogleRep.Address[0].Line1, GoogleRep.Address[0].City, GoogleRep.Address[0].State, GoogleRep.Address[0].Zip);
            HouseMember.Phone = GoogleRep.Phones[0];
            HouseMember.WebSite = GoogleRep.Urls[0];
            if (GoogleRep.Emails != null)
            {
                HouseMember.Email = GoogleRep.Emails[0];
            }

            foreach (Channel channel in GoogleRep.Channels)
            {
                switch(channel.Type)
                {
                    case "Facebook":
                        HouseMember.Facebook = channel.Id;
                        break;
                    case "Twitter":
                        HouseMember.Twitter = channel.Id;
                        break;
                    case "YouTube":
                        HouseMember.YouTube = channel.Id;
                        break;
                }
            }

            return HouseMember;
        }
    }
}