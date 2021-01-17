using System;
namespace CivicsApp.Models.Bills
{
    public class BillDetails
    {
        public string BillId { get; set; }
        public string BillName { get; set; }
        public string BillNumber { get; set; }
        public string BillTitle { get; set; }
        public string IntroducedDate { get; set; }
        public object HousePassage { get; set; }
        public object SenatePassage { get; set; }
        public object Enacted { get; set; }
        public object Vetoed { get; set; }
        public string SummaryShort { get; set; }
        public string Summary { get; set; }
        public string CongressdotgovUrl { get; set; }
        public string GovtrackUrl { get; set; }
        public string BillUri { get; set; }
    }
}
