using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CivicsApp.Models

{
    public class Member : IRepresentative
    {
        public IRepresentative CreateRepresentative()
        {
            Representative representative = new Representative();
            return (IRepresentative)representative;
        }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }
    }

    public class Result

     {
        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("members")]
        public List<Member> Members { get; set; }
    }

    public class Representative
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }
    }
}