using AeroflotAPI.Models;

namespace AeroflotAPI.Repositories;

public interface IReportRepository
{
    Task<bool> AddReportZone(ReportZone zone);
}