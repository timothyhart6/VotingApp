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
using CivicsApp.Models.Representatives.MemberOfHouse;
using CivicsApp.Models.AddressModel;

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

        public async Task<HouseMemberResult> FetchProPublicaHouseMember(HttpClient httpClient, string state, string district)
        {
            var HouseMemberUrl = $"https://api.propublica.org/congress/v1/members/house/{state}/{district}/current.json";
            var HouseMemberResults = await httpClient.GetAsync(HouseMemberUrl);
            var StringResultsForHouseMember = await HouseMemberResults.Content.ReadAsStringAsync();
            var ProPublicaHouseMember = JsonConvert.DeserializeObject<PropublicaApiHouseMember>(StringResultsForHouseMember);

            return ProPublicaHouseMember.Results[0];
        }

        public async Task<ProPublicaApiSenatorsForAState> FetchPropublicaSenators(HttpClient httpClient, string state)
        {
            var SenateMembersUrl = $"https://api.propublica.org/congress/v1/members/senate/{state}/current.json";
            var SenateMembersResults = await httpClient.GetAsync(SenateMembersUrl);
            var StringResultsForSenateMembers = await SenateMembersResults.Content.ReadAsStringAsync();
            var ProPublicaSenators = JsonConvert.DeserializeObject<ProPublicaApiSenatorsForAState>(StringResultsForSenateMembers);

            return ProPublicaSenators;
        }

        public async Task<GoogleApiRepresentatives> FetchGoogleRepresentatives(HttpClient httpClient, string address, string zipCode)
        {
            var GoogleRepresentativesUrl = $"https://www.googleapis.com/civicinfo/v2/representatives?key=AIzaSyCZom8UkHqmSzLcAWfnfL41vOfirikaS3w&address={address}{zipCode}";
            var GoogleRepresentativesResults = await httpClient.GetAsync(GoogleRepresentativesUrl);
            var StringResultsForGoogleRepresentatives = await GoogleRepresentativesResults.Content.ReadAsStringAsync();
            var GoogleRepresentatives = JsonConvert.DeserializeObject<GoogleApiRepresentatives>(StringResultsForGoogleRepresentatives);

            return GoogleRepresentatives;
        }

        public async Task<HouseMember> AddAddressCoordinates(HouseMember houseMember, string address, string city, string state, string zipCode)
        {
            HttpClient client = new HttpClient();
            var url = $"https://geocoding.geo.census.gov/geocoder/locations/address?street={address}&city={city}&state={state}&zip={zipCode}&benchmark=Public_AR_Census2010&format=json";
            var results = await client.GetAsync(url);
            var stringResults = await results.Content.ReadAsStringAsync();
            var addressCoordinates = JsonConvert.DeserializeObject<AddressCoordinatesApiModel>(stringResults);
            houseMember.CoordinateX = addressCoordinates.Result.AddressMatches[0].Coordinates.X;
            houseMember.CoordinateY = addressCoordinates.Result.AddressMatches[0].Coordinates.Y;

            return houseMember;
        }

        public string FetchCongressionalDistrict(GoogleApiRepresentatives googleApiRepresentatives)
        {
            var divisionId = googleApiRepresentatives.Offices[3].DivisionId;
            string district = divisionId.Substring(divisionId.Length - 2);
            return district;
        }

    public async Task<CurrentDistrictRepresentatives> ListStateRepresentativesAsync(string address, string city, string state, string zipCode)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-API-Key", "hxY9fxmPmO7Ev1UT6KUlbYaPVKM5v619B2DWRjIY");

            var googleRepresentatives = await FetchGoogleRepresentatives(httpClient, address, zipCode);
            var district = FetchCongressionalDistrict(googleRepresentatives);

            var propublicaSenators = FetchPropublicaSenators(httpClient, state);
            var propublicaHouseMember = FetchProPublicaHouseMember(httpClient, state, district);

            await Task.WhenAll(propublicaHouseMember, propublicaSenators);

            var Senator1 = SenatorAdapter.ConvertToSenatorObject(propublicaSenators.Result.Results[0]);
            var Senator2 = SenatorAdapter.ConvertToSenatorObject(propublicaSenators.Result.Results[1]);
            var HouseMember = HouseMemberAdapter.ConvertToHouseMemeberObject(propublicaHouseMember.Result, googleRepresentatives);

            await AddAddressCoordinates(HouseMember, address, city, state, zipCode);
            var DistrictReps = new CurrentDistrictRepresentatives(Senator1, Senator2, HouseMember);

            return DistrictReps;
        }

    }
}
