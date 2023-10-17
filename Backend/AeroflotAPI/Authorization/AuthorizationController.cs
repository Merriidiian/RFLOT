using AeroflotAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AeroflotAPI;

[ApiController]
[ApiVersion("1.0")]
[Route("aeroflot/api/v{version:apiVersion}/authorization")]
public class AuthorizationController : ControllerBase
{
    private readonly IRepository _repository;

    public AuthorizationController(IRepository repository)
    {
        _repository = repository;
    }

    [Route("login-and-password")]
    [RequestSizeLimit(1 * 1024)]
    [HttpPost]
    public async Task<IActionResult> Authorization(string login, string password)
    {
        try
        {
            var response = await _repository.Authorisation(login, password);
            return Ok(response);
        }
        catch (Exception e)
        {
            return NotFound("Пользователь не найден");
        }
    }

    [Route("id")]
    [RequestSizeLimit(1 * 1024)]
    [HttpPost]
    public async Task<IActionResult> Authorization(string id)
    {
        var response = await _repository.Authorisation(id);
        if (response)
            return Ok();
        return NotFound();
    }
}