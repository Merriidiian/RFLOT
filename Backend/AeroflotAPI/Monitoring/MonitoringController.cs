using Microsoft.AspNetCore.Mvc;

namespace AeroflotAPI.Monitoring;

[Route("aeroflot/rfid/monitoring")]
public class MonitoringController : Controller
{
    private readonly IMonitoringService _service;

    public MonitoringController(IMonitoringService service)
    {
        _service = service;
    }

    /*public async Task<IActionResult> Monitoring(string idPlane)
    {
        var actors = await _service.GetPlane(idPlane);
        return ViewBag;
    }*/
}