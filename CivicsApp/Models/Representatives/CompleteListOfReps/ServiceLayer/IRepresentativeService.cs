using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CivicsApp.Models.Representatives.CompleteListOfReps;

namespace CivicsApp.Models
{
    public interface IRepresentativeService
    {
        public Task<Representative> DisplayRepresentative(String MemberId);
        
        public Task<List<Representative>> ListRepresentativesAsync();

        public Task<ListOfHouseMembers> ListStateRepresentativesAsync(String state);
    }
}
