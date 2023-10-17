using AeroflotAPI.Reporting.DTOs;

namespace AeroflotAPI.Services;

public interface IReportService
{
    Task<bool> AddReportZone(ReportZoneDto zone);
}