using System;
using System.Threading.Tasks;

namespace CivicsApp.Models
{
    public interface ISenatorService
    {
        public Task<Senator> ListSenatorsAsync();
        //public Task<Senator> ListSenatorsForAStateAsync(String state);
    }
}
