using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace CivicsApp.Models.AddressModel
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Benchmark
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("benchmarkName")]
        public string BenchmarkName { get; set; }

        [JsonProperty("benchmarkDescription")]
        public string BenchmarkDescription { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
    }

    //public class Address
    //{
    //    [JsonProperty("street")]
    //    public string Street { get; set; }

    //    [JsonProperty("city")]
    //    public string City { get; set; }

    //    [JsonProperty("state")]
    //    public string State { get; set; }

    //    [JsonProperty("zip")]
    //    public string Zip { get; set; }
    //}

    public class Input
    {
        [JsonProperty("benchmark")]
        public Benchmark Benchmark { get; set; }

        //[JsonProperty("address")]
        //public Address Address { get; set; }
    }

    public class Coordinates
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class TigerLine
    {
        [JsonProperty("tigerLineId")]
        public string TigerLineId { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }
    }

    public class AddressComponents
    {
        [JsonProperty("fromAddress")]
        public string FromAddress { get; set; }

        [JsonProperty("toAddress")]
        public string ToAddress { get; set; }

        [JsonProperty("preQualifier")]
        public string PreQualifier { get; set; }

        [JsonProperty("preDirection")]
        public string PreDirection { get; set; }

        [JsonProperty("preType")]
        public string PreType { get; set; }

        [JsonProperty("streetName")]
        public string StreetName { get; set; }

        [JsonProperty("suffixType")]
        public string SuffixType { get; set; }

        [JsonProperty("suffixDirection")]
        public string SuffixDirection { get; set; }

        [JsonProperty("suffixQualifier")]
        public string SuffixQualifier { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class AddressMatch
    {
        [JsonProperty("matchedAddress")]
        public string MatchedAddress { get; set; }

        [JsonProperty("coordinates")]
        public Coordinates Coordinates { get; set; }

        [JsonProperty("tigerLine")]
        public TigerLine TigerLine { get; set; }

        [JsonProperty("addressComponents")]
        public AddressComponents AddressComponents { get; set; }
    }

    public class Result
    {
        [JsonProperty("input")]
        public Input Input { get; set; }

        [JsonProperty("addressMatches")]
        public List<AddressMatch> AddressMatches { get; set; }
    }

    public class AddressCoordinatesApiModel
    {
        [JsonProperty("result")]
        public Result Result { get; set; }
    }

}
