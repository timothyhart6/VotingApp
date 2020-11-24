using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CivicsApp.Models.Representatives.CompleteListOfReps;
using CivicsApp.Models.Representatives.SpecificRep;

namespace CivicsApp.Models
{
    public interface IRepresentativeService
    {
        public Task<Representative> DisplayRepresentative(String MemberId);
        
        public Task<List<Representative>> ListRepresentativesAsync();

        public Task<List<SpecificRepresentative>> ListStateRepresentativesAsync(String state, string district);
    }
}
