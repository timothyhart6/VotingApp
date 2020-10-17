using System;
namespace CivicsApp.Models
{
    public interface ISenator
    {
        public string State { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
