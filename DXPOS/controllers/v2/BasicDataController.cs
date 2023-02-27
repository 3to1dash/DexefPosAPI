using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;

namespace DXPOS.Controllers.v2;

[ApiController]
[ApiVersion("2")]
[Route("v{version:apiVersion}/[controller]/[action]")]
public class BasicDataController : ControllerBase
{
    [HttpGet]
    public IResult GetBranches(
        [FromQuery] string ip,
        [FromQuery] string database,
        [FromQuery] string userName,
        [FromServices] UsersData userData)
    {
        var user = userData.GetUserByUserName(userName);
        return Results.Ok(user);
    }
}