using System;
using System.Net.Http;
using System.Threading.Tasks;
using CivicsApp.Models.Bills.ApiModels;
using Newtonsoft.Json;

namespace CivicsApp.Models.Bills.ServiceLayer
{
    public class BillService
    {
        public async Task<BillDetails> FetchBillDetailsAsync(string billSlug)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-API-Key", "hxY9fxmPmO7Ev1UT6KUlbYaPVKM5v619B2DWRjIY");

            var url = $"https://api.propublica.org/congress/v1/116/bills/{billSlug}.json";
            var results = await client.GetAsync(url);
            var stringResults = await results.Content.ReadAsStringAsync();
            var propublicaBillDetails = JsonConvert.DeserializeObject<PropublicaBillDetails>(stringResults);
            var billDetails = new BillDetails
            {
                BillId = propublicaBillDetails.Results[0].BillId,
                BillNumber = propublicaBillDetails.Results[0].Number,
                BillTitle = propublicaBillDetails.Results[0].Title,
                IntroducedDate = propublicaBillDetails.Results[0].IntroducedDate,
                HousePassage = propublicaBillDetails.Results[0].HousePassage,
                SenatePassage = propublicaBillDetails.Results[0].SenatePassage,
                Enacted = propublicaBillDetails.Results[0].Enacted,
                Vetoed = propublicaBillDetails.Results[0].Vetoed,
                SummaryShort = propublicaBillDetails.Results[0].SummaryShort,
                Summary = propublicaBillDetails.Results[0].Summary,
                CongressdotgovUrl = propublicaBillDetails.Results[0].CongressdotgovUrl,
                GovtrackUrl = propublicaBillDetails.Results[0].GovtrackUrl,
                BillUri = propublicaBillDetails.Results[0].BillUri
            };

            return billDetails;
        }
    }
}
