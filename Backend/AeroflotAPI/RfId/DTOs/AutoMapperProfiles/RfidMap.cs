using AeroflotAPI.Models;
using AutoMapper;

namespace AeroflotAPI.DTOs.AutoMapperProfiles;

public class RfidMap : Profile
{
    public RfidMap()
    {
        CreateMap<RfidDto, Equip>().ReverseMap();
        CreateMap<RfidDto, Equip>()
            .ForMember(dest => dest.DataExploitationBegin,
                opt => opt.MapFrom(src => StaticMethods.UnixTimeStampToDateTime(src.DataTimes.DataExploitationBegin)))
            .ForMember(dest => dest.DataExploitationFinish,
                opt => opt.MapFrom(src => StaticMethods.UnixTimeStampToDateTime(src.DataTimes.DataExploitationFinish)))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        CreateMap<Equip, RfidDto>()
            .ForMember(dest => dest.DataTimes,
                opt => opt.MapFrom(src => new DataTimes
                {
                    DataExploitationBegin = StaticMethods.ConvertToTimestamp(src.DataExploitationBegin.Date),
                    DataExploitationFinish = StaticMethods.ConvertToTimestamp(src.DataExploitationFinish.Date)
                }));
    }
}