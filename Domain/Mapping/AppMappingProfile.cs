using AutoMapper;
using MedicineProject.PlaceService.Domain.Models;
using MedicineProject.PlaceService.Domain.Dtos;

namespace MedicineProject.Domain.Mapping
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile() 
        {
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<County, CountyDto>().ReverseMap();
            CreateMap<City, CityDto>().ReverseMap();
        }
    }
}
