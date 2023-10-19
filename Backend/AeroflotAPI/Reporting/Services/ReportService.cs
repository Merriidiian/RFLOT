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

    public async Task<IEnumerable<ReportInfoByPlaneAndData>> GetReportInfoByPlaneAndData(string planeId, DateTime data)
    {
        var info = await _repository.GetReportInfoByPlaneAndData(planeId, data);
        var list = info.Select(i => new ReportInfoByPlaneAndData
            {
                PlaneId = i.IdPlane,
                Zone = i.ZoneName,
                DataBegin = i.DateTimeStartGroup.ToString("MM/dd/yyyy hh:mm:ss"),
                DataEnd = i.DateTimeFinishGroup.ToString("MM/dd/yyyy hh:mm:ss"),
                Type = i.TypeCheck
            });
        var reportInfoByPlaneAndDatas = list.ToList();
        foreach (var report in reportInfoByPlaneAndDatas)
        {
            report.Type = report.Type switch
            {
                "1" => "Предполетная",
                "2" => "Постполетная",
                _ => report.Type
            };
        }
        return reportInfoByPlaneAndDatas;
    }
}