using AeroflotAPI.Models;
using AeroflotAPI.Reporting.DTOs;

namespace AeroflotAPI.Repositories;

public class ReportRepository : IReportRepository
{
    private readonly ReportContext _context;

    public ReportRepository(ReportContext context)
    {
        _context = context;
    }

    public async Task<bool> AddReportZone(ReportZone zone)
    {
        try
        {
            var newReport = await _context.ReportZones.AddAsync(zone);
            var save = await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public async Task<IEnumerable<ReportZone>> GetReportInfoByPlaneAndData(string planeId, DateTime data)
    {
        var info = _context.ReportZones;
        var infoByPlane = info.Where(
            i => i.IdPlane == planeId).ToList();
        var infoByData = infoByPlane.Where(d => d.DateTimeStartGroup.Date == data.Date);
        await _context.AddRangeAsync();
        return infoByData;
    }
}