using MedicineProject.PlaceService.Domain.Dtos.Base;
using System.Text.Json.Serialization;

namespace MedicineProject.PlaceService.Domain.Dtos
{
    public record CountyDto : BaseDto
    {
        [JsonPropertyName("regions")]
        public List<RegionDto> RegionDTOs { get; set; } = new List<RegionDto>();

        public CountyDto() { }
    }
}
