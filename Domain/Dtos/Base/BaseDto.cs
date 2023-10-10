using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MedicineProject.PlaceService.Domain.Dtos.Base
{
    public record BaseDto
    {
        [Key]
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
