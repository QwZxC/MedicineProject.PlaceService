using MedicineProject.PlaceService.Domain.Context;
using MedicineProject.PlaceService.Domain.Models.Base;
using MedicineProject.PlaceService.Domain.Repositories;

namespace MedicineProject.Infrastructure.Repositories
{
    public class PlaceRepository : BaseRepository, IPlaceRepository
    {
        public PlaceRepository(WebMobileContext context) : base(context)
        {

        }
        
        public IEnumerable<TModel> GetItems<TModel>()
            where TModel : BaseModel
        {
            return _context.Set<TModel>();
        }
    }
}
