using System.Threading.Tasks;
using CivicsApp.Models.UserDistrictRepresentatives;
using CivicsApp.Models.Representatives.MemberOfHouse;


namespace CivicsApp.Models.HouseMembers.MemberOfHouse
{
    public class HouseMemberAdapter
    {
        public HouseMember ConvertToHouseMemeberObject(HouseMemberResult ProPublicaHouseMember, GoogleApiRepresentatives GoogleRepresentatives)
        {
            HouseMember HouseMember = new HouseMember();
            var GoogleHouseMember = GoogleRepresentatives.Officials[4];

            HouseMember.MemberId = ProPublicaHouseMember.Id;
            HouseMember.FirstName = ProPublicaHouseMember.FirstName;
            HouseMember.MiddleName = ProPublicaHouseMember.MiddleName;
            HouseMember.LastName = ProPublicaHouseMember.LastName;
            HouseMember.District = ProPublicaHouseMember.District;
            HouseMember.State = GoogleRepresentatives.NormalizedInput.State;
            HouseMember.NextElectionYear = ProPublicaHouseMember.NextElection;
            HouseMember.OfficeAddress = new Address(GoogleHouseMember.Address[0].Line1,
                                                         GoogleHouseMember.Address[0].City,
                                                         GoogleHouseMember.Address[0].State,
                                                         GoogleHouseMember.Address[0].Zip);
            HouseMember.Phone = GoogleHouseMember.Phones[0];
            HouseMember.WebSite = GoogleHouseMember.Urls[0];
            if (GoogleHouseMember.Emails != null)
            {
                HouseMember.Email = GoogleHouseMember.Emails[0];
            }

            foreach (Channel channel in GoogleHouseMember.Channels)
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