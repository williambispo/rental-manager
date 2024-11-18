using Microsoft.AspNetCore.Mvc;
using rental.Domain.Models;
using rental.Domain.Services.Authenticate.Interface;

namespace rental.WebAPI.Controllers;

public class AuthenticateController : ControllerBase
{
    private readonly IAuthenticateService _service;

    public AuthenticateController(IAuthenticateService service)
    {
        _service = service;
    }

    [HttpPost("LoginAsync")]
    public async Task<IActionResult> LoginAsync([FromBody] LoginModel model)
    {
        var response = await _service.LoginAsync(model);

        return new ApiResult(response);
    }

    [HttpPost("RegisterAsync")]
    public async Task<IActionResult> RegisterAsync([FromBody] RegisterModel model)
    {
        var response = await _service.RegisterAsync(model);

        return new ApiResult(response);
    }
}
