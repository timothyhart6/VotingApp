using System;
namespace CivicsApp.Models
{
    public interface IRepresentative
    {
        public string State { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string District { get; set; }
    }

}
