using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CivicsApp.Models.Representatives.SpecificRep
{
    public class SpecificRepresentativeService
    {

        public async Task<SpecificRepresentative> ListStateRepresentativesAsync(String state)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-API-Key", "hxY9fxmPmO7Ev1UT6KUlbYaPVKM5v619B2DWRjIY");
            var membersOfHouseUrl = "https://api.propublica.org/congress/v1/members/house/OH/15/current.json";
            var results = await httpClient.GetAsync(membersOfHouseUrl);
            var stringResult = await results.Content.ReadAsStringAsync();
            var myDeserializedClass = JsonConvert.DeserializeObject<SpecificRepresentative>(stringResult);
            return myDeserializedClass;
        }
        
    }
}
