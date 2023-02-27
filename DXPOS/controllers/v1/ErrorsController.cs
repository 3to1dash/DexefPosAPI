using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace DXPOS.Controllers.v1;

[ApiController]
[ApiVersion("1")]
[Route("v{version:apiVersion}/[controller]/[action]")]
public class ErrorsController : ControllerBase
{
    [HttpGet("error")]
    public IResult Error()
    {
        throw new Exception("oops");
    }

    [HttpGet("errorhandler")]
    public IResult ErrorHandler(HttpContext ctx)
    {
        var error = string.Empty;
        var feature = ctx.Features.Get<IExceptionHandlerFeature>();

        if (feature == null) return Results.BadRequest($"There has been an error{Environment.NewLine}{error}");
        if (feature.Error is ArgumentException)
        {
            ctx.Response.StatusCode = 402;
        }

        error = feature.Error.Message;

        return Results.BadRequest($"There has been an error{Environment.NewLine}{error}");
    }
}