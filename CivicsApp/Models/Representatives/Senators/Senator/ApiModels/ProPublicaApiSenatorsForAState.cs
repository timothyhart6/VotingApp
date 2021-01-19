using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;

namespace CivicsApp.Models
{
    public class SenateResult
    {
        //[JsonProperty("id")]
        //public string Id { get; set; }

        //[JsonProperty("name")]
        //public string Name { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        //[JsonProperty("middle_name")]
        //public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        //[JsonProperty("suffix")]
        //public object Suffix { get; set; }

        //[JsonProperty("role")]
        //public string Role { get; set; }

        //[JsonProperty("gender")]
        //public string Gender { get; set; }

        //[JsonProperty("party")]
        //public string Party { get; set; }

        //[JsonProperty("times_topics_url")]
        //public string TimesTopicsUrl { get; set; }

        //[JsonProperty("twitter_id")]
        //public string TwitterId { get; set; }

        //[JsonProperty("facebook_account")]
        //public string FacebookAccount { get; set; }

        //[JsonProperty("youtube_id")]
        //public string YoutubeId { get; set; }

        //[JsonProperty("seniority")]
        //public string Seniority { get; set; }

        //[JsonProperty("next_election")]
        //public string NextElection { get; set; }

        //[JsonProperty("api_uri")]
        //public string ApiUri { get; set; }
    }

    public class ProPublicaApiSenatorsForAState
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public List<SenateResult> Results { get; set; }
    }


}