using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace rental.WebAPI;

public class ApiResult : IActionResult
{
    private readonly Domain.Interfaces.Commands.IResult _result;

    public ApiResult(Domain.Interfaces.Commands.IResult result)
    {
        _result = result;
    }

    public async Task ExecuteResultAsync(ActionContext context)
    {
        var jsonResult = new JsonResult(_result)
        {
            StatusCode = !_result.Success
                ? (int)HttpStatusCode.BadRequest
                : (int)HttpStatusCode.OK
        };

        await jsonResult.ExecuteResultAsync(context);
    }
}