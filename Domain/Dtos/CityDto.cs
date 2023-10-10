using MedicineProject.PlaceService.Domain.Dtos.Base;
using System.Text.Json.Serialization;

namespace MedicineProject.PlaceService.Domain.Dtos
{
    public record CityDto : BaseDto
    {
        [JsonPropertyName("region_id")]
        public long RegionId { get; set; }

        public CityDto() { }
    }
}
