using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CivicsApp.Models.Representatives.CompleteListOfReps;
using CivicsApp.Models.Representatives.SpecificRep;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CivicsApp.Models
{
    public class RepresentativeService : IRepresentativeService
    {
        RepresentativeAdapter adapter = new RepresentativeAdapter();

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

        public async Task<SpecificRepresentative> ListStateRepresentativesAsync(String state)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-API-Key", "hxY9fxmPmO7Ev1UT6KUlbYaPVKM5v619B2DWRjIY");
            var membersOfHouseUrl = $"https://api.propublica.org/congress/v1/members/house/{state}/15/current.json";

            //var membersOfHouseUrl = "https://api.propublica.org/congress/v1/116/house/members.json";
            var results = await httpClient.GetAsync(membersOfHouseUrl);
            var stringResult = await results.Content.ReadAsStringAsync();
            var myDeserializedClass = JsonConvert.DeserializeObject<SpecificRepresentative>(stringResult);

            //for (int i = 0; i < myDeserializedClass.Results[0].Members.Count;)

            //    if (myDeserializedClass.Results[0].Members[i].State != state)
            //    {
            //        myDeserializedClass.Results[0].Members.RemoveAt(i);
            //    }
            //    else { i++; }

            return myDeserializedClass;
        }
    }
}
