using MedicineProject.PlaceService.Domain.Models.Base;

namespace MedicineProject.PlaceService.Domain.Models
{
    public class City : BaseModel
    {
        public Region Region { get; set; }

        public long RegionId { get; set; }

        public City() { }
    }
}
