using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace AeroflotAPI.Reporting.DTOs;

public class ReportZoneDto
{
    [JsonConstructor]
    public ReportZoneDto(string idZone, string idChecker, string typeCheck, string zoneName, string idPlane,
        long dateTimeStartGroup,
        long dateTimeFinishGroup, List<BadEquips> badEquips)
    {
        IdZone = idZone;
        ZoneName = zoneName;
        IdPlane = idPlane;
        DateTimeStartGroup = dateTimeStartGroup;
        DateTimeFinishGroup = dateTimeFinishGroup;
        BadEquips = badEquips;
        TypeCheck = typeCheck;
        IdChecker = idChecker;
    }

    public string IdZone { get; set; }
    public string IdChecker { get; set; }
    public string TypeCheck { get; set; }
    public string ZoneName { get; set; }
    public string IdPlane { get; set; }
    public long DateTimeStartGroup { get; set; }
    public long DateTimeFinishGroup { get; set; }

    public List<BadEquips>? BadEquips { get; set; }
}

public class BadEquips
{
    public string RfId { get; set; }
    public string Name { get; set; }
    [DataType(DataType.Date)] public long DataExploitationBegin { get; set; }
    [DataType(DataType.Date)] public long DataExploitationFinish { get; set; }
    public string EquipmentInformation { get; set; }
    public string PlanePlace { get; set; }
    public string? Status { get; set; }
}