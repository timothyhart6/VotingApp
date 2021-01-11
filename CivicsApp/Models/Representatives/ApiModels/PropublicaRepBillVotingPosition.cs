using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CivicsApp.Models.Representatives.ApiModels
{
    public class Bill
    {
        [JsonProperty("bill_id")]
        public string BillId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("api_uri")]
        public object ApiUri { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("latest_action")]
        public string LatestAction { get; set; }

        [JsonProperty("sponsor_id")]
        public string SponsorId { get; set; }

        [JsonProperty("bill_uri")]
        public string BillUri { get; set; }
    }

    public class Amendment
    {
    }

    public class Total
    {
        [JsonProperty("yes")]
        public int Yes { get; set; }

        [JsonProperty("no")]
        public int No { get; set; }

        [JsonProperty("present")]
        public int Present { get; set; }

        [JsonProperty("not_voting")]
        public int NotVoting { get; set; }
    }

    public class Vote
    {
        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("chamber")]
        public string Chamber { get; set; }

        [JsonProperty("congress")]
        public string Congress { get; set; }

        [JsonProperty("session")]
        public string Session { get; set; }

        [JsonProperty("roll_call")]
        public string RollCall { get; set; }

        [JsonProperty("vote_uri")]
        public string VoteUri { get; set; }

        [JsonProperty("bill")]
        public Bill Bill { get; set; }

        [JsonProperty("amendment")]
        public Amendment Amendment { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("total")]
        public Total Total { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }
    }

    public class Result
    {
        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("num_results")]
        public string NumResults { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("votes")]
        public List<Vote> Votes { get; set; }
    }

    public class PropublicaRepBillVotingPosition
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }
    }


}

