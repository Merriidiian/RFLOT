using AeroflotAPI.Models;
using AeroflotAPI.Reporting.DTOs;

namespace AeroflotAPI.Repositories;

public interface IReportRepository
{
    Task<bool> AddReportZone(ReportZone zone);
    Task<IEnumerable<ReportZone>> GetReportInfoByPlaneAndData(string planeId, DateTime data);
}