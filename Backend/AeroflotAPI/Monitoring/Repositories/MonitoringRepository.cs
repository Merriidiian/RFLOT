using AeroflotAPI.Models;
using AeroflotAPI.Repositories;

namespace AeroflotAPI.Monitoring;

public class MonitoringRepository : IMonitoringRepository
{
    private readonly ReportContext _context;

    public MonitoringRepository(ReportContext context)
    {
        _context = context;
    }

    public async Task<IQueryable<ReportZone>> GetPlane(string idPlane)
    {
        var zonesPlane = _context.ReportZones.Where(z => z.IdPlane == idPlane);
        return zonesPlane;
    }
}