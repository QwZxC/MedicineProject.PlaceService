using AutoMapper;
using MedicineProject.PlaceService.Domain.Dtos;
using MedicineProject.PlaceService.Domain.Models;
using MedicineProject.PlaceService.Domain.Repositories;
using MedicineProject.PlaceService.Domain.Services;

namespace MedicineProject.PlaceService.Core.Services
{
    /// <summary>
    /// Сервис для работы с геолокацией.
    /// </summary>
    public class PlaceService : IPlaceService
    {
        private readonly IPlaceRepository _repository;
        private readonly IMapper _mapper;

        public PlaceService(IPlaceRepository repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<CountyDto>> GetPlacesAsync()
        {
            List<County> counties = await _repository.GetItemListAsync<County>();
            await LoadRegion(counties);
            counties.ForEach(county => LoadCities(county.Regions));

            List<CountyDto> countiesForResponse = new List<CountyDto>();
            counties.ForEach(county =>
            {
                CountyDto dto = _mapper.Map<CountyDto>(county);
                dto.RegionDTOs = MapObjects<Region, RegionDto>(county.Regions);
                dto.RegionDTOs.ForEach(region =>
                {
                    region.Cities = MapObjects<City, CityDto>(county.Regions.FirstOrDefault(dbRegion =>
                                                                        dbRegion.Id == region.Id).Cities);
                });
                countiesForResponse.Add(dto);
            });

            return countiesForResponse;
        }

        private async Task LoadRegion(List<County> counties)
        {
            List<Region> regions = await _repository.GetItemListAsync<Region>();
            counties.ForEach(county =>
            {
                List<Region> countyRegions = regions.ToList().FindAll(region => county.Id == region.CountyId);
                county.Regions.AddRange(countyRegions);
            });
        }

        private void LoadCities(List<Region> regions)
        {
            List<City> cities = _repository.GetItems<City>().ToList();
            regions.ForEach(region =>
            {
                region.Cities = cities.FindAll(city => city.RegionId == region.Id);
            });
        }
        
        protected List<TTarget> MapObjects<TOriginal, TTarget>(List<TOriginal> objects)
        {
            List<TTarget> DTOs = new List<TTarget>();
            objects.ForEach(item => DTOs.Add(_mapper.Map<TTarget>(item)));
            return DTOs;
        }
    }
}
