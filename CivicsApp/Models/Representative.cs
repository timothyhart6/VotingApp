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

        //[JsonProperty("middle_name")]
        //public string MiddleName { get; set; }

        //[JsonProperty("suffix")]
        //public string Suffix { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        //[JsonPropertyName("id")]
        //public string Id { get; set; }

        //[JsonProperty("title")]
        //public string Title { get; set; }

        //[JsonProperty("short_title")]
        //public string ShortTitle { get; set; }

        //[JsonProperty("api_uri")]
        //public string ApiUri { get; set; }

        //[JsonProperty("date_of_birth")]
        //public string DateOfBirth { get; set; }

        //[JsonProperty("gender")]
        //public string Gender { get; set; }

        //[JsonProperty("party")]
        //public string Party { get; set; }

        //[JsonProperty("leadership_role")]
        //public string LeadershipRole { get; set; }

        //[JsonProperty("twitter_account")]
        //public string TwitterAccount { get; set; }

        //[JsonProperty("facebook_account")]
        //public string FacebookAccount { get; set; }

        //[JsonProperty("youtube_account")]
        //public string YoutubeAccount { get; set; }

        //[JsonProperty("govtrack_id")]
        //public string GovtrackId { get; set; }

        //[JsonProperty("cspan_id")]
        //public string CspanId { get; set; }

        //[JsonProperty("votesmart_id")]
        //public string VotesmartId { get; set; }

        //[JsonProperty("icpsr_id")]
        //public string IcpsrId { get; set; }

        //[JsonProperty("crp_id")]
        //public string CrpId { get; set; }

        //[JsonProperty("google_entity_id")]
        //public string GoogleEntityId { get; set; }

        //[JsonProperty("fec_candidate_id")]
        //public string FecCandidateId { get; set; }

        //[JsonProperty("url")]
        //public string Url { get; set; }

        //[JsonProperty("rss_url")]
        //public string RssUrl { get; set; }

        //[JsonProperty("contact_form")]
        //public string ContactForm { get; set; }

        //[JsonProperty("in_office")]
        //public bool InOffice { get; set; }

        //[JsonProperty("cook_pvi")]
        //public string CookPvi { get; set; }

        //[JsonProperty("dw_nominate")]
        //public double? DwNominate { get; set; }

        //[JsonProperty("ideal_point")]
        //public object IdealPoint { get; set; }

        //[JsonPropertyName("seniority")]
        //public string Seniority { get; set; }

        //[JsonPropertyName("next_election")]

        //public string NextElection { get; set; }

        //[JsonPropertyName("total_votes")]
        //public int? TotalVotes { get; set; }

        //[JsonPropertyName("missed_votes")]
        //public int? MissedVotes { get; set; }

        //[JsonPropertyName("total_present")]
        //public int? TotalPresent { get; set; }

        //[JsonPropertyName("last_updated")]
        //public string LastUpdated { get; set; }

        //[JsonPropertyName("ocd_id")]
        //public string OcdId { get; set; }

        //[JsonPropertyName("office")]
        //public string Office { get; set; }

        //[JsonPropertyName("phone")]
        //public string Phone { get; set; }

        //[JsonPropertyName("fax")]
        //public object Fax { get; set; }

        //[JsonPropertyName("at_large")]
        //public bool AtLarge { get; set; }

        //[JsonPropertyName("geoid")]
        //public string Geoid { get; set; }

        //[JsonPropertyName("missed_votes_pct")]
        //public double MissedVotesPct { get; set; }

        //[JsonPropertyName("votes_with_party_pct")]
        //public double VotesWithPartyPct { get; set; }

        //[JsonPropertyName("votes_against_party_pct")]
        //public double VotesAgainstPartyPct { get; set; }
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