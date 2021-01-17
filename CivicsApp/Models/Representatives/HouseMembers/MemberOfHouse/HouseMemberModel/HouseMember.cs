using System;
using System.Collections.Generic;
using CivicsApp.Models;

namespace CivicsApp.Models.Representatives.MemberOfHouse
{
    public class BillVotingInformation
    {
        public string BillId { get; set; }
        public string BillSlug { get; set; }
        public string Description { get; set; }
        public string BillVotingPosition { get; set; }
        public string DateOfVote { get; set; }
    }

    public class HouseMember
    {
        public HouseMember()
        {
            BillVotingHistory = new List<BillVotingInformation>();
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string NextElectionYear { get; set; }
        public Address OfficeAddress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string YouTube { get; set; }
        public string WebSite { get; set; }
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }
        public string MemberId { get; set; }

        public List<BillVotingInformation> BillVotingHistory { get; set; }
    }
}

