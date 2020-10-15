using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CivicsApp.Models
{
    public interface IRepresentativeService
    {
        public Task<Representative> ListRepresentativesAsync();
    }
}
