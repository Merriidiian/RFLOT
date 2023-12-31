﻿using AeroflotAPI.Reporting.DTOs;
using AeroflotAPI.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AeroflotAPI.Reporting;

[ApiController]
[ApiVersion("1.0")]
[Route("aeroflot/api/v{version:apiVersion}/rfid-report")]
public class ReportController : ControllerBase
{
    private readonly IReportService _service;

    public ReportController(IReportService service)
    {
        _service = service;
    }

    [Route("add-report")]
    [HttpPost]
    [Produces("application/json")]
    public async Task<IActionResult> AddReportZone(ReportZoneDto zoneDto)
    {
        try
        {
            var result = await _service.AddReportZone(zoneDto);
            if (result)
                return Ok();
            return NotFound("Ошибка отправки отчёта");
        }
        catch (Exception e)
        {
            return NotFound("Ошибка отправки отчёта");
        }
    }

    [Route("get-zones")]
    [HttpGet]
    [Produces("application/json")]

    public async Task<IActionResult> GetZones(string planeId, DateTime data)
    {
        var result = await _service.GetReportInfoByPlaneAndData(planeId, data);
        if (result.Count() != 0)
            return Ok(result);
        else
            return NotFound();
    }
}