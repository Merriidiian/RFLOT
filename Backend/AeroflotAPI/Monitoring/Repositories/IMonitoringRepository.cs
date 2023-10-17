using AeroflotAPI.Models;

namespace AeroflotAPI.Monitoring;

public interface IMonitoringRepository
{
    Task<IQueryable<ReportZone>> GetPlane(string idPlane);
}