using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CivicsApp.Models
{
    public class RepresentativeService : IRepresentativeService
    {
        public async Task<Representative> ListRepresentativesAsync()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-API-Key", "hxY9fxmPmO7Ev1UT6KUlbYaPVKM5v619B2DWRjIY");
            var membersOfHouseUrl = "https://api.propublica.org/congress/v1/116/house/members.json";

            var results = await httpClient.GetAsync(membersOfHouseUrl);
            var stringResult = await results.Content.ReadAsStringAsync();
            var myDeserializedClass = JsonConvert.DeserializeObject<Representative>(stringResult);
            return myDeserializedClass;
        }

        public async Task<Representative> ListStateRepresentativesAsync(String state)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-API-Key", "hxY9fxmPmO7Ev1UT6KUlbYaPVKM5v619B2DWRjIY");
            var membersOfHouseUrl = "https://api.propublica.org/congress/v1/members/house/OH/15/current.json";

            var results = await httpClient.GetAsync(membersOfHouseUrl);
            var stringResult = await results.Content.ReadAsStringAsync();
            var myDeserializedClass = JsonConvert.DeserializeObject<Representative>(stringResult);

            //for (int i = 0; i < myDeserializedClass.Results[0].Members.Count;)

            //if (myDeserializedClass.Results[0].Members[i].State != state)
            //    {
            //        myDeserializedClass.Results[0].Members.RemoveAt(i);
            //    }
            //else { i++; }

            return myDeserializedClass;
        }
    }
}
