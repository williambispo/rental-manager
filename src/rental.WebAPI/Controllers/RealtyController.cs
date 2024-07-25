using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rental.Domain.Services.Realty.Interface;
using rental.Dto.Realty.Requests;

namespace rental.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RealtyController : ControllerBase
{
    private readonly IRealtyService _service;

    public RealtyController(IRealtyService service)
    {
        _service = service;
    }

    [HttpGet("ListAsync")]
    public async Task<IActionResult> ListAsync()
    {
        var response = await _service.ListAsync();

        return Ok(response);
    }

    [HttpGet("GetByIdAsync/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
    {
        var response = await _service.GetById(id);

        return Ok(response);
    }

    [HttpPost("InsertAsync")]
    public async Task<IActionResult> InsertAsync([FromBody] RealtyInsertRequest request)
    {
        var response = await _service.InsertAsync(request);

        return Ok(response);
    }

    [HttpPut("UpdateAsync")]
    public async Task<IActionResult> UpdateAsync([FromBody] RealtyUpdateRequest request)
    {
        var response = await _service.UpdateAsync(request);

        return Ok(response);
    }
}
