using AeroflotAPI.Services.RfId;
using Microsoft.AspNetCore.Mvc;

namespace AeroflotAPI.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("aeroflot/api/v{version:apiVersion}/rfid")]
public class RfidApiController : ControllerBase
{
    private readonly IRfidService _service;

    public RfidApiController(IRfidService service)
    {
        _service = service;
    }

    [Route("get-zones-by-plain-id")]
    [RequestSizeLimit(1 * 1024)]
    [HttpGet]
    [Produces("application/json")]
    public async Task<IActionResult> GetPlaneByPlaneId(string planeId, string idChecker)
    {
        try
        {
            var zones = await _service.GetZonesByPlainId(planeId);
            return Ok(zones);
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }


    [Route("post-rfids-by-zone-id")]
    [RequestSizeLimit(1 * 1024)]
    [HttpPost]
    [Produces("application/json")]
    public async Task<IActionResult> PostStartCheckZone(string idZone, string idChecker)
    {
        try
        {
            var response = await _service.PostStartCheckZone(idZone, idChecker);
            return Ok(response);
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }

    [Route("end-session")]
    [RequestSizeLimit(1 * 1024)]
    [HttpPost]
    [Produces("application/json")]
    public async Task<IActionResult> PostEndCheckZone(
        string idZone, string idChecker)
    {
        try
        {
            Thread.Sleep(30);
            var response =
                await _service.PostEndCheckZone(idZone, idChecker);
            if (response)
                return Ok();
            return NotFound();
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }

    [Route("rfid-info")]
    [RequestSizeLimit(1 * 1024)]
    [HttpGet]
    [Produces("application/json")]
    public async Task<IActionResult> GetRfid(string rfid)
    {
        try
        {
            var rfidItem = await _service.GetRfid(rfid);
            return Ok(rfidItem);
        }
        catch (Exception e)
        {
            return NotFound("rfid-метка не найдена!");
        }
    }

    /*public async Task<IActionResult> ChangeEquip()
    {
        
    }*/
}