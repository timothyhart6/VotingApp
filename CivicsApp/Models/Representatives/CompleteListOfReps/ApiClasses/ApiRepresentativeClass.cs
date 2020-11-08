using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
//using System.Text.Json.Serialization;

namespace CivicsApp.Models
{

    //public class Committee
    //{
    //    [JsonPropertyName("name")]
    //    public string Name { get; set; }

    //    [JsonPropertyName("code")]
    //    public string Code { get; set; }

    //    [JsonPropertyName("api_uri")]
    //    public string ApiUri { get; set; }

    //    [JsonPropertyName("side")]
    //    public string Side { get; set; }

    //    [JsonPropertyName("title")]
    //    public string Title { get; set; }

    //    [JsonPropertyName("rank_in_party")]
    //    public int RankInParty { get; set; }

    //    [JsonPropertyName("begin_date")]
    //    public string BeginDate { get; set; }

    //    [JsonPropertyName("end_date")]
    //    public string EndDate { get; set; }
    //}

    //public class Subcommittee
    //{
    //    [JsonPropertyName("name")]
    //    public string Name { get; set; }

    //    [JsonPropertyName("code")]
    //    public string Code { get; set; }

    //    [JsonPropertyName("parent_committee_id")]
    //    public string ParentCommitteeId { get; set; }

    //    [JsonPropertyName("api_uri")]
    //    public string ApiUri { get; set; }

    //    [JsonPropertyName("side")]
    //    public string Side { get; set; }

    //    [JsonPropertyName("title")]
    //    public string Title { get; set; }

    //    [JsonPropertyName("rank_in_party")]
    //    public int RankInParty { get; set; }

    //    [JsonPropertyName("begin_date")]
    //    public string BeginDate { get; set; }

    //    [JsonPropertyName("end_date")]
    //    public string EndDate { get; set; }
    //}

    public class Role
    {
        //    [JsonPropertyName("congress")]
        //    public string Congress { get; set; }

        //    [JsonPropertyName("chamber")]
        //    public string Chamber { get; set; }

        //    [JsonPropertyName("title")]
        //    public string Title { get; set; }

        //    [JsonPropertyName("short_title")]
        //    public string ShortTitle { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        //    [JsonPropertyName("party")]
        //    public string Party { get; set; }

        //    [JsonPropertyName("leadership_role")]
        //    public string LeadershipRole { get; set; }

        //    [JsonPropertyName("fec_candidate_id")]
        //    public string FecCandidateId { get; set; }

        //    [JsonPropertyName("seniority")]
        //    public string Seniority { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        //    [JsonPropertyName("at_large")]
        //    public bool AtLarge { get; set; }

        //    [JsonPropertyName("ocd_id")]
        //    public string OcdId { get; set; }

        //    [JsonPropertyName("start_date")]
        //    public string StartDate { get; set; }

        //    [JsonPropertyName("end_date")]
        //    public string EndDate { get; set; }

        //    [JsonPropertyName("office")]
        //    public string Office { get; set; }

        //    [JsonPropertyName("phone")]
        //    public string Phone { get; set; }

        //    [JsonPropertyName("fax")]
        //    public string Fax { get; set; }

        //    [JsonPropertyName("contact_form")]
        //    public object ContactForm { get; set; }

        //    [JsonPropertyName("cook_pvi")]
        //    public string CookPvi { get; set; }

        //    [JsonPropertyName("dw_nominate")]
        //    public double DwNominate { get; set; }

        //    [JsonPropertyName("ideal_point")]
        //    public object IdealPoint { get; set; }

        //    [JsonPropertyName("next_election")]
        //    public string NextElection { get; set; }

        //    [JsonPropertyName("total_votes")]
        //    public int TotalVotes { get; set; }

        //    [JsonPropertyName("missed_votes")]
        //    public int MissedVotes { get; set; }

        //    [JsonPropertyName("total_present")]
        //    public int TotalPresent { get; set; }

        //    [JsonPropertyName("senate_class")]
        //    public string SenateClass { get; set; }

        //    [JsonPropertyName("state_rank")]
        //    public string StateRank { get; set; }

        //    [JsonPropertyName("lis_id")]
        //    public string LisId { get; set; }

        //    [JsonPropertyName("bills_sponsored")]
        //    public int BillsSponsored { get; set; }

        //    [JsonPropertyName("bills_cosponsored")]
        //    public int BillsCosponsored { get; set; }

        //    [JsonPropertyName("missed_votes_pct")]
        //    public double MissedVotesPct { get; set; }

        //    [JsonPropertyName("votes_with_party_pct")]
        //    public double VotesWithPartyPct { get; set; }

        //    [JsonPropertyName("votes_against_party_pct")]
        //    public double VotesAgainstPartyPct { get; set; }

        //    [JsonPropertyName("committees")]
        //    public List<Committee> Committees { get; set; }

        //    [JsonPropertyName("subcommittees")]
        //    public List<Subcommittee> Subcommittees { get; set; }
    }

    public class RepResult
    {
        //[JsonPropertyName("id")]
        //public string Id { get; set; }

        //[JsonPropertyName("member_id")]
        //public string MemberId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        //[JsonPropertyName("middle_name")]
        //public object MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        //[JsonPropertyName("suffix")]
        //public object Suffix { get; set; }

        //[JsonPropertyName("date_of_birth")]
        //public string DateOfBirth { get; set; }

        //[JsonPropertyName("gender")]
        //public string Gender { get; set; }

        //[JsonPropertyName("url")]
        //public string Url { get; set; }

        //[JsonPropertyName("times_topics_url")]
        //public string TimesTopicsUrl { get; set; }

        //[JsonPropertyName("times_tag")]
        //public string TimesTag { get; set; }

        //[JsonPropertyName("govtrack_id")]
        //public string GovtrackId { get; set; }

        //[JsonPropertyName("cspan_id")]
        //public string CspanId { get; set; }

        //[JsonPropertyName("votesmart_id")]
        //public string VotesmartId { get; set; }

        //[JsonPropertyName("icpsr_id")]
        //public string IcpsrId { get; set; }

        //[JsonPropertyName("twitter_account")]
        //public string TwitterAccount { get; set; }

        //[JsonPropertyName("facebook_account")]
        //public string FacebookAccount { get; set; }

        //[JsonPropertyName("youtube_account")]
        //public object YoutubeAccount { get; set; }

        //[JsonPropertyName("crp_id")]
        //public string CrpId { get; set; }

        //[JsonPropertyName("google_entity_id")]
        //public string GoogleEntityId { get; set; }

        //[JsonPropertyName("rss_url")]
        //public string RssUrl { get; set; }

        //[JsonPropertyName("in_office")]
        //public bool InOffice { get; set; }

        //[JsonPropertyName("current_party")]
        //public string CurrentParty { get; set; }

        //[JsonPropertyName("most_recent_vote")]
        //public string MostRecentVote { get; set; }

        //[JsonPropertyName("last_updated")]
        //public string LastUpdated { get; set; }

        [JsonProperty("roles")]
        public List<Role> Roles { get; set; }
    }

    public class ApiRepresentativeClass
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public List<RepResult> Results { get; set; }
    }
}