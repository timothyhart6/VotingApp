using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CivicsApp.Models.UserDistrictRepresentatives
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class NormalizedInput
    {
        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    //public class OcdDivisionCountryUs
    //{
    //    [JsonProperty("name")]
    //    public string Name { get; set; }

    //    [JsonProperty("officeIndices")]
    //    public List<int> OfficeIndices { get; set; }
    //}

    //public class OcdDivisionCountryUsStateOhCountyFranklin
    //{
    //    [JsonProperty("name")]
    //    public string Name { get; set; }
    
    //    [JsonProperty("officeIndices")]
    //    public List<int> OfficeIndices { get; set; }
    //}

    //public class OcdDivisionCountryUsStateOhSldu15
    //{
    //    [JsonProperty("name")]
    //    public string Name { get; set; }

    //    [JsonProperty("officeIndices")]
    //    public List<int> OfficeIndices { get; set; }
    //}

    //public class OcdDivisionCountryUsStateOh
    //{
    //    [JsonProperty("name")]
    //    public string Name { get; set; }

    //    [JsonProperty("officeIndices")]
    //    public List<int> OfficeIndices { get; set; }
    //}

    //public class OcdDivisionCountryUsStateOhCd15
    //{
    //    [JsonProperty("name")]
    //    public string Name { get; set; }

    //    [JsonProperty("officeIndices")]
    //    public List<int> OfficeIndices { get; set; }
    //}

    //public class OcdDivisionCountryUsStateOhPlaceColumbus
    //{
    //    [JsonProperty("name")]
    //    public string Name { get; set; }

    //    [JsonProperty("officeIndices")]
    //    public List<int> OfficeIndices { get; set; }
    //}

    //public class OcdDivisionCountryUsStateOhSldl18
    //{
    //    [JsonProperty("name")]
    //    public string Name { get; set; }

    //    [JsonProperty("officeIndices")]
    //    public List<int> OfficeIndices { get; set; }
    //}

    //public class Divisions
    //{
    //    [JsonProperty("ocd-division/country:us")]
    //    public OcdDivisionCountryUs OcdDivisionCountryUs { get; set; }

    //    [JsonProperty("ocd-division/country:us/state:oh/county:franklin")]
    //    public OcdDivisionCountryUsStateOhCountyFranklin OcdDivisionCountryUsStateOhCountyFranklin { get; set; }

    //    [JsonProperty("ocd-division/country:us/state:oh/sldu:15")]
    //    public OcdDivisionCountryUsStateOhSldu15 OcdDivisionCountryUsStateOhSldu15 { get; set; }

    //    [JsonProperty("ocd-division/country:us/state:oh")]
    //    public OcdDivisionCountryUsStateOh OcdDivisionCountryUsStateOh { get; set; }

    //    [JsonProperty("ocd-division/country:us/state:oh/cd:15")]
    //    public OcdDivisionCountryUsStateOhCd15 OcdDivisionCountryUsStateOhCd15 { get; set; }

    //    [JsonProperty("ocd-division/country:us/state:oh/place:columbus")]
    //    public OcdDivisionCountryUsStateOhPlaceColumbus OcdDivisionCountryUsStateOhPlaceColumbus { get; set; }

    //    [JsonProperty("ocd-division/country:us/state:oh/sldl:18")]
    //    public OcdDivisionCountryUsStateOhSldl18 OcdDivisionCountryUsStateOhSldl18 { get; set; }
    //}

    public class Office
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("divisionId")]
        public string DivisionId { get; set; }

        [JsonProperty("levels")]
        public List<string> Levels { get; set; }

        [JsonProperty("roles")]
        public List<string> Roles { get; set; }

        [JsonProperty("officialIndices")]
        public List<int> OfficialIndices { get; set; }
    }

    public class GoogleAddress
    {
        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class Channel
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Official
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public List<GoogleAddress> Address { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("phones")]
        public List<string> Phones { get; set; }

        [JsonProperty("urls")]
        public List<string> Urls { get; set; }

        [JsonProperty("photoUrl")]
        public string PhotoUrl { get; set; }

        [JsonProperty("channels")]
        public List<Channel> Channels { get; set; }

        [JsonProperty("emails")]
        public List<string> Emails { get; set; }
    }

    public class GoogleApiRepresentatives
    {
        [JsonProperty("normalizedInput")]
        public NormalizedInput NormalizedInput { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        //[JsonProperty("divisions")]
        //public Divisions Divisions { get; set; }

        [JsonProperty("offices")]
        public List<Office> Offices { get; set; }

        [JsonProperty("officials")]
        public List<Official> Officials { get; set; }
    }


}
