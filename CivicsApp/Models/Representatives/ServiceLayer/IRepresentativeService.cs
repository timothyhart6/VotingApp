﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CivicsApp.Models.UserDistrictRepresentatives;
using CivicsApp.Models.Representatives.CompleteListOfReps;
using CivicsApp.Models.Senators.Senator;


namespace CivicsApp.Models
{
    public interface IRepresentativeService
    {
        public Task<Representative> DisplayRepresentative(String MemberId);
        
        public Task<List<Representative>> ListRepresentativesAsync();

        public Task<DistrictRepresentatives> ListStateRepresentativesAsync(string address, string city, string state, string zipcode);
    }
}
