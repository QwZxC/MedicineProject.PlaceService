using MedicineProject.PlaceService.Domain.Models.Base;

namespace MedicineProject.PlaceService.Domain.Models
{
    public class Region : BaseModel
    {
        public long CountyId { get; set; }

        public County County { get; set; }

        public List<City> Cities { get; set; } = new List<City>();

        public Region() { }
    }
}
