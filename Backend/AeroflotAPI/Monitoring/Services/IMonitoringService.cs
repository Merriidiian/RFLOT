using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AeroflotAPI.Monitoring;

public interface IMonitoringService
{
    Task<View?> GetPlane(string idPlane);
}