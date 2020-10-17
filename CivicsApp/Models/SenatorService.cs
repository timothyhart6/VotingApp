using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CivicsApp.Models
{
    public class SenatorService : ISenatorService
    {

        public async Task<Senator> ListSenatorsAsync()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-API-Key", "hxY9fxmPmO7Ev1UT6KUlbYaPVKM5v619B2DWRjIY");
            var membersOfSenateUrl = "https://api.propublica.org/congress/v1/116/senate/members.json";

            var results = await httpClient.GetAsync(membersOfSenateUrl);
            var stringResult = await results.Content.ReadAsStringAsync();
            var myDeserializedClass = JsonConvert.DeserializeObject<Senator>(stringResult);
            return myDeserializedClass;
        }

        //public async Task<Senator> ListSenatorsForAStateAsync(string state)
        //{
        //    var httpClient = new HttpClient();
        //    httpClient.DefaultRequestHeaders.Add("X-API-Key", "hxY9fxmPmO7Ev1UT6KUlbYaPVKM5v619B2DWRjIY");
        //    var membersOfSenateUrl = "https://api.propublica.org/congress/v1/116/senate/members.json";

        //    var results = await httpClient.GetAsync(membersOfSenateUrl);
        //    var stringResult = await results.Content.ReadAsStringAsync();
        //    var myDeserializedClass = JsonConvert.DeserializeObject<Senator>(stringResult);

        //    //for (int i = 0; i < myDeserializedClass.Results[0].Members.Count;)

        //    //    if (myDeserializedClass.Results[0].Members[i].State != state)
        //    //    {
        //    //        myDeserializedClass.Results[0].Members.RemoveAt(i);
        //    //    }
        //    //    else { i++; }

        //    return myDeserializedClass;

        //}
    }
}
