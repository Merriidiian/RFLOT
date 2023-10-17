using AeroflotAPI.Models;
using AutoMapper;

namespace AeroflotAPI.DTOs.AutoMapperProfiles;

public class ZoneMap : Profile
{
    public ZoneMap()
    {
        CreateMap<ZonesDto, Zone>().ReverseMap();
        CreateMap<Zone, ZonesDto>().ReverseMap();
        CreateMap<IQueryable<ZonesDto>, IQueryable<Zone>>().ReverseMap();
        CreateMap<IQueryable<Zone>, IQueryable<ZonesDto>>().ReverseMap();
    }
}