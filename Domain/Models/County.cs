using MedicineProject.PlaceService.Domain.Models.Base;

namespace MedicineProject.PlaceService.Domain.Models
{
    public class County : BaseModel
    {
        public List<Region> Regions { get; set; }

        public County() { }
    }
}
