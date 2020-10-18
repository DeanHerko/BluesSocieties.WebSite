using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BluesSocieties.WebSite.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DisplayFormat(NullDisplayText = "", ApplyFormatInEditMode = true)]
        public string HomePage { get; set; }        
        public string Facebook { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Locality { get; set; }
        public string AdminDistrict { get; set; }
        [JsonPropertyName("CountryRegion")]
        public string Region { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string LogoFileName { get; set; }
        public string BFMember { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Contact>(this);

    }
}
