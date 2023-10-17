using System.Text.Json;
using AeroflotAPI.Models;
using AeroflotAPI.Reporting.DTOs;
using AeroflotAPI.Repositories;
using AeroflotAPI.Services;
using AutoMapper;

namespace AeroflotAPI.Reporting.Services;

public class ReportService : IReportService
{
    private readonly IMapper _mapper;
    private readonly IReportRepository _repository;

    public ReportService(IReportRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<bool> AddReportZone(ReportZoneDto zone)
    {
        var zoneModel = new ReportZone
        {
            IdPlane = zone.IdPlane,
            IdZone = zone.IdZone,
            ZoneName = zone.ZoneName,
            DateTimeStartGroup = StaticMethods.UnixTimeStampToDateTime(zone.DateTimeStartGroup),
            DateTimeFinishGroup = StaticMethods.UnixTimeStampToDateTime(zone.DateTimeFinishGroup),
            TypeCheck = zone.TypeCheck,
            IdChecker = zone.IdChecker
        };
        try
        {
            if (zone.BadEquips != null) zoneModel.BadEquipJson = JsonSerializer.Serialize(zone.BadEquips);
        }
        catch (Exception e)
        {
            zoneModel.BadEquipJson = null;
        }

        var result = await _repository.AddReportZone(zoneModel);
        return result;
    }
}