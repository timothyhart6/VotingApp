using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CivicsApp.Models.Representatives.CompleteListOfReps;
using CivicsApp.Models.Senators.Senator;
using CivicsApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CivicsApp.Models.DistrictRepresentatives;

using CivicsApp.Models.HouseMembers.MemberOfHouse;

namespace CivicsApp.Models
{
    public class RepresentativeService : IRepresentativeService
    {
        RepresentativeAdapter adapter = new RepresentativeAdapter();

        HouseMemberAdapter HouseMemberAdapter = new HouseMemberAdapter();
        SenatorAdapter SenatorAdapter = new SenatorAdapter();

        public async Task<Representative> DisplayRepresentative(string MemberId)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-API-Key", "hxY9fxmPmO7Ev1UT6KUlbYaPVKM5v619B2DWRjIY");
            //var RepresentativeUrl = $"https://api.propublica.org/congress/v1/members/{MemberId}.json";
            //var RepresentativeUrl = "https://api.propublica.org/congress/v1/members/"+ MemberId + ".json";
            var RepresentativeUrl = "https://api.propublica.org/congress/v1/members/A000374.json";
            var results = await httpClient.GetAsync(RepresentativeUrl);

            var stringResult = await results.Content.ReadAsStringAsync();
            var myDeserializedClass = JsonConvert.DeserializeObject<ApiRepresentativeClass>(stringResult);

            var Representative = adapter.ConvertToRepresentativeObjectForIndividual(myDeserializedClass.Results[0]);
            return Representative;

        }

        public async Task<List<Representative>> ListRepresentativesAsync()
        {
            List<Representative> ListOfRepresentatives = new List<Representative>();

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-API-Key", "hxY9fxmPmO7Ev1UT6KUlbYaPVKM5v619B2DWRjIY");
            var membersOfHouseUrl = "https://api.propublica.org/congress/v1/116/house/members.json";
            var results = await httpClient.GetAsync(membersOfHouseUrl);

            var stringResult = await results.Content.ReadAsStringAsync();
            var myDeserializedClass = JsonConvert.DeserializeObject<ListOfHouseMembers>(stringResult);

            for (int i = 0; i < myDeserializedClass.Results[0].Members.Count; i++)
            {
                ListOfRepresentatives.Add(adapter.ConvertToRepresentativeObject(myDeserializedClass.Results[0].Members[i]));
            }

            return ListOfRepresentatives;
        }

        public async Task<CurrentDistrictRepresentatives> ListStateRepresentativesAsync(string address, string city, string state, string zipcode, string district)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-API-Key", "hxY9fxmPmO7Ev1UT6KUlbYaPVKM5v619B2DWRjIY");
            
            var HouseMemberUrl = $"https://api.propublica.org/congress/v1/members/house/{state}/{district}/current.json";
            var SenateMembersUrl = $"https://api.propublica.org/congress/v1/members/senate/{state}/current.json";
            var GoogleRepresentativesUrl = $"https://www.googleapis.com/civicinfo/v2/representatives?key=AIzaSyCZom8UkHqmSzLcAWfnfL41vOfirikaS3w&address={address}{zipcode}";

            //HttpResponseMessage GoogleRepresentativesResults;

            //using (var request = new HttpRequestMessage(new HttpMethod("GET"), GoogleRepresentativesUrl))
            //{
            //    GoogleRepresentativesResults = await httpClient.SendAsync(request);
            //}


            var HouseMemberResults = await httpClient.GetAsync(HouseMemberUrl);
            var SenateMembersResults = await httpClient.GetAsync(SenateMembersUrl);
            var GoogleRepresentativesResults = await httpClient.GetAsync(GoogleRepresentativesUrl);

            var StringResultsForHouseMember = await HouseMemberResults.Content.ReadAsStringAsync();
            var StringResultsForSenateMembers = await SenateMembersResults.Content.ReadAsStringAsync();
            var StringResultsForGoogleRepresentatives = await GoogleRepresentativesResults.Content.ReadAsStringAsync();

            var ProPublicaHouseMember = JsonConvert.DeserializeObject<PropublicaApiHouseMember>(StringResultsForHouseMember);
            var ProPublicaSenators = JsonConvert.DeserializeObject<ProPublicaApiSenatorsForAState>(StringResultsForSenateMembers);
            var GoogleRepresentatives = JsonConvert.DeserializeObject<GoogleApiRepresentatives>(StringResultsForGoogleRepresentatives); 

            var Senator1 = SenatorAdapter.ConvertToSenatorObject(ProPublicaSenators.Results[0]);
            var Senator2 = SenatorAdapter.ConvertToSenatorObject(ProPublicaSenators.Results[1]);
            var HouseMember = HouseMemberAdapter.ConvertToHouseMemeberObject(ProPublicaHouseMember.Results[0], GoogleRepresentatives.Officials[4]);

            var DistrictReps = new CurrentDistrictRepresentatives(Senator1, Senator2, HouseMember);

            return DistrictReps;
        }
    }
}
