using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CivicsApp.Models.Bills.ApiModels
{
    public class CosponsorsByParty
    {
        [JsonPropertyName("D")]
        public int D { get; set; }

        [JsonPropertyName("R")]
        public int R { get; set; }
    }

    public class Version
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("congressdotgov_url")]
        public string CongressdotgovUrl { get; set; }
    }

    public class Action
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("chamber")]
        public string Chamber { get; set; }

        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        [JsonPropertyName("datetime")]
        public string Datetime { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("bill_id")]
        public string BillId { get; set; }

        [JsonPropertyName("bill_slug")]
        public string BillSlug { get; set; }

        [JsonPropertyName("congress")]
        public string Congress { get; set; }

        [JsonPropertyName("bill")]
        public string Bill { get; set; }

        [JsonPropertyName("bill_type")]
        public string BillType { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("bill_uri")]
        public string BillUri { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("short_title")]
        public string ShortTitle { get; set; }

        [JsonPropertyName("sponsor_title")]
        public string SponsorTitle { get; set; }

        [JsonPropertyName("sponsor")]
        public string Sponsor { get; set; }

        [JsonPropertyName("sponsor_id")]
        public string SponsorId { get; set; }

        [JsonPropertyName("sponsor_uri")]
        public string SponsorUri { get; set; }

        [JsonPropertyName("sponsor_party")]
        public string SponsorParty { get; set; }

        [JsonPropertyName("sponsor_state")]
        public string SponsorState { get; set; }

        [JsonPropertyName("gpo_pdf_uri")]
        public object GpoPdfUri { get; set; }

        [JsonPropertyName("congressdotgov_url")]
        public string CongressdotgovUrl { get; set; }

        [JsonPropertyName("govtrack_url")]
        public string GovtrackUrl { get; set; }

        [JsonPropertyName("introduced_date")]
        public string IntroducedDate { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("last_vote")]
        public object LastVote { get; set; }

        [JsonPropertyName("house_passage")]
        public object HousePassage { get; set; }

        [JsonPropertyName("senate_passage")]
        public object SenatePassage { get; set; }

        [JsonPropertyName("enacted")]
        public object Enacted { get; set; }

        [JsonPropertyName("vetoed")]
        public object Vetoed { get; set; }

        [JsonPropertyName("cosponsors")]
        public int Cosponsors { get; set; }

        [JsonPropertyName("cosponsors_by_party")]
        public CosponsorsByParty CosponsorsByParty { get; set; }

        [JsonPropertyName("withdrawn_cosponsors")]
        public int WithdrawnCosponsors { get; set; }

        [JsonPropertyName("primary_subject")]
        public string PrimarySubject { get; set; }

        [JsonPropertyName("committees")]
        public string Committees { get; set; }

        [JsonPropertyName("committee_codes")]
        public List<string> CommitteeCodes { get; set; }

        [JsonPropertyName("subcommittee_codes")]
        public List<string> SubcommitteeCodes { get; set; }

        [JsonPropertyName("latest_major_action_date")]
        public string LatestMajorActionDate { get; set; }

        [JsonPropertyName("latest_major_action")]
        public string LatestMajorAction { get; set; }

        [JsonPropertyName("house_passage_vote")]
        public object HousePassageVote { get; set; }

        [JsonPropertyName("senate_passage_vote")]
        public object SenatePassageVote { get; set; }

        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        [JsonPropertyName("summary_short")]
        public string SummaryShort { get; set; }

        [JsonPropertyName("cbo_estimate_url")]
        public object CboEstimateUrl { get; set; }

        [JsonPropertyName("versions")]
        public List<Version> Versions { get; set; }

        [JsonPropertyName("actions")]
        public List<Action> Actions { get; set; }

        [JsonPropertyName("presidential_statements")]
        public List<object> PresidentialStatements { get; set; }

        [JsonPropertyName("votes")]
        public List<object> Votes { get; set; }
    }

    public class PropublicaBillDetails
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("copyright")]
        public string Copyright { get; set; }

        [JsonPropertyName("results")]
        public List<Result> Results { get; set; }
    }


}
