using AeroflotAPI.Reporting.DTOs;

namespace AeroflotAPI.Monitoring;

public class PlaneModel
{
    public string PlaneId { get; set; }
    public string PlaneName { get; set; }
    private List<ReportZoneDto> Zones { get; set; }
}