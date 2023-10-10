using MedicineProject.PlaceService.Domain.Dtos;

namespace MedicineProject.PlaceService.Domain.Services
{
    public interface IPlaceService
    {
        /// <summary>
        /// Возвращает список округов.
        /// </summary>
        /// <returns></returns>
        Task<List<CountyDto>> GetPlacesAsync();
    }
}
