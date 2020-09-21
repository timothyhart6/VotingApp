using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CivicsApp.Models
{
    public class Representative
    {
        public int Id { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [JsonPropertyName("Name_Last")]
        public string Name_Last { get; set; }
    }
}
