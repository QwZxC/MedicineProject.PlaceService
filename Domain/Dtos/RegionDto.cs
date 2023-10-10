using MedicineProject.PlaceService.Domain.Dtos.Base;

namespace MedicineProject.PlaceService.Domain.Dtos
{
    public record RegionDto : BaseDto
    {
        public long CountyId { get; set; }
        
        public List<CityDto> Cities { get; set; } = new List<CityDto>();

        public RegionDto() { }
    }
}
