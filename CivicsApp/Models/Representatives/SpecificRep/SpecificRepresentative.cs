﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CivicsApp.Models.Representatives.SpecificRep
{
    public class SpecificRepresentative : ISpecificRepresentative
    {

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }

    public class Root
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public List<SpecificRepresentative> Results { get; set; }
    }
}