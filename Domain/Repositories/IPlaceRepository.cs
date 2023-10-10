using MedicineProject.PlaceService.Domain.Models.Base;

namespace MedicineProject.PlaceService.Domain.Repositories
{
    public interface IPlaceRepository : IBaseRepository
    {
        IEnumerable<TModel> GetItems<TModel>() where TModel : BaseModel;
    }
}
