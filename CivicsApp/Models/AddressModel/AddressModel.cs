using System;
namespace CivicsApp.Models
{
    public class AddressModel
    {
        private string line1;
        private string zip;

        public AddressModel(string line1, string city, string state, string zip)
        {
            AddressLine1 = line1;
            City = city;
            State = state;
            ZipCode= zip;
        }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
