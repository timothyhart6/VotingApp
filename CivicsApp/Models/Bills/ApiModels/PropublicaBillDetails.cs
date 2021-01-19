using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace CivicsApp.Models.Bills.ApiModels
{
    public class Version
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("congressdotgov_url")]
        public string CongressdotgovUrl { get; set; }
    }

    public class Action
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("action_type")]
        public string ActionType { get; set; }

        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class Result
    {
        [JsonProperty("bill_id")]
        public string BillId { get; set; }

        [JsonProperty("bill_slug")]
        public string BillSlug { get; set; }

        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("bill")]
        public string Bill { get; set; }

        [JsonProperty("bill_type")]
        public string BillType { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("bill_uri")]
        public string BillUri { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("short_title")]
        public string ShortTitle { get; set; }

        [JsonProperty("sponsor_title")]
        public string SponsorTitle { get; set; }

        [JsonProperty("sponsor")]
        public string Sponsor { get; set; }

        [JsonProperty("sponsor_id")]
        public string SponsorId { get; set; }

        [JsonProperty("sponsor_uri")]
        public string SponsorUri { get; set; }

        [JsonProperty("sponsor_party")]
        public string SponsorParty { get; set; }

        [JsonProperty("sponsor_state")]
        public string SponsorState { get; set; }

        [JsonProperty("gpo_pdf_uri")]
        public object GpoPdfUri { get; set; }

        [JsonProperty("congressdotgov_url")]
        public string CongressdotgovUrl { get; set; }

        [JsonProperty("govtrack_url")]
        public string GovtrackUrl { get; set; }

        [JsonProperty("introduced_date")]
        public string IntroducedDate { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("last_vote")]
        public object LastVote { get; set; }

        [JsonProperty("house_passage")]
        public string HousePassage { get; set; }

        [JsonProperty("senate_passage")]
        public object SenatePassage { get; set; }

        [JsonProperty("enacted")]
        public object Enacted { get; set; }

        [JsonProperty("vetoed")]
        public object Vetoed { get; set; }

        [JsonProperty("cosponsors")]
        public int Cosponsors { get; set; }

        [JsonProperty("cosponsors_by_party")]
        public object CosponsorsByParty { get; set; }

        [JsonProperty("withdrawn_cosponsors")]
        public int WithdrawnCosponsors { get; set; }

        [JsonProperty("primary_subject")]
        public string PrimarySubject { get; set; }

        [JsonProperty("committees")]
        public string Committees { get; set; }

        [JsonProperty("committee_codes")]
        public List<object> CommitteeCodes { get; set; }

        [JsonProperty("subcommittee_codes")]
        public List<object> SubcommitteeCodes { get; set; }

        [JsonProperty("latest_major_action_date")]
        public string LatestMajorActionDate { get; set; }

        [JsonProperty("latest_major_action")]
        public string LatestMajorAction { get; set; }

        [JsonProperty("house_passage_vote")]
        public string HousePassageVote { get; set; }

        [JsonProperty("senate_passage_vote")]
        public object SenatePassageVote { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("summary_short")]
        public string SummaryShort { get; set; }

        [JsonProperty("cbo_estimate_url")]
        public object CboEstimateUrl { get; set; }

        [JsonProperty("versions")]
        public List<Version> Versions { get; set; }

        [JsonProperty("actions")]
        public List<Action> Actions { get; set; }

        [JsonProperty("presidential_statements")]
        public List<object> PresidentialStatements { get; set; }

        [JsonProperty("votes")]
        public List<object> Votes { get; set; }
    }

    public class PropublicaBillDetails
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }
    }


}
