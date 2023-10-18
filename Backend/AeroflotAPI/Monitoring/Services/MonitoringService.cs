using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AeroflotAPI.Monitoring;

public class MonitoringService : IMonitoringService
{
    private readonly IMonitoringRepository _repository;

    public MonitoringService(IMonitoringRepository repository)
    {
        _repository = repository;
    }

    public async Task<View?> GetPlane(string idPlane)
    {
        var zonesPlane = await _repository.GetPlane(idPlane);
        return null;
    }
}