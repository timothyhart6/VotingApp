using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CivicsApp.Models.Representatives.CompleteListOfReps;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CivicsApp.Models
{
    public class RepresentativeService : IRepresentativeService
    {
        private RepresentativeAdapter adapter = new RepresentativeAdapter();


        public async Task<List<Representative>> ListRepresentativesAsync()
        {
            
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-API-Key", "hxY9fxmPmO7Ev1UT6KUlbYaPVKM5v619B2DWRjIY");
            var membersOfHouseUrl = "https://api.propublica.org/congress/v1/116/house/members.json";

            var results = await httpClient.GetAsync(membersOfHouseUrl);
            var stringResult = await results.Content.ReadAsStringAsync();
            var myDeserializedClass = JsonConvert.DeserializeObject<ListOfHouseMembers>(stringResult);
            List<Representative> reps = new List<Representative>();
            reps = adapter.ReturnListOfHouseMembers(myDeserializedClass);
            //reps = await Task.Run(() => adapter.ReturnListOfHouseMembers(myDeserializedClass));
            return reps;
        }

        public async Task<ListOfHouseMembers> ListStateRepresentativesAsync(String state)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-API-Key", "hxY9fxmPmO7Ev1UT6KUlbYaPVKM5v619B2DWRjIY");
            var membersOfHouseUrl = "https://api.propublica.org/congress/v1/members/house/OH/15/current.json";
            //var membersOfHouseUrl = "https://api.propublica.org/congress/v1/116/house/members.json";
            var results = await httpClient.GetAsync(membersOfHouseUrl);
            var stringResult = await results.Content.ReadAsStringAsync();
            var myDeserializedClass = JsonConvert.DeserializeObject<ListOfHouseMembers>(stringResult);

            for (int i = 0; i < myDeserializedClass.Results[0].Members.Count;)

                if (myDeserializedClass.Results[0].Members[i].State != state)
                {
                    myDeserializedClass.Results[0].Members.RemoveAt(i);
                }
                else { i++; }

            return myDeserializedClass;
        }
    }
}
