using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using MedicineProject.PlaceService.Domain.Services;
using MedicineProject.PlaceService.Domain.Context;
using MedicineProject.PlaceService.Domain.Dtos;

namespace MedicineProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlacesController : ControllerBase
    {
        private readonly IPlaceService _placeService;
        private readonly IMemoryCache _cache;

        public PlacesController(WebMobileContext context, IMemoryCache memoryCache, IPlaceService placeService)
        {
            _placeService = placeService;
            _cache = memoryCache;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<CountyDto>))]
        public async Task<ActionResult<List<CountyDto>>> GetPlaces()
        {
            List<CountyDto> counties;
            if (_cache.TryGetValue(0, out counties))
            {
                return Ok(counties);
            }
            
            counties = await _placeService.GetPlacesAsync();

            _cache.Set(0, counties);

            return Ok(counties);
        }
    }
}

