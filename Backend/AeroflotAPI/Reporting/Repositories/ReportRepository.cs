using AeroflotAPI.Models;

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
}