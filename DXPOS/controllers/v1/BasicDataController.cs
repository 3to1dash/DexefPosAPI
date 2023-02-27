using DataAccess.Data;
using DXPOS.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace DXPOS.Controllers.v1;

[ApiController]
[ApiVersion("1")]
[Route("v{version:apiVersion}/[controller]/[action]")]
public class BasicDataController : ControllerBase
{
    /// <summary>
    /// Retrieves a specific user branches
    /// </summary>
    /// <remarks>Returns all the branches of a given user</remarks>
    /// <param name="ip" example="000.00.00.000,0000">Database IP</param>
    /// <param name="database" example="Text">Database Name</param>
    /// <param name="userName" example="Jack">User Name</param>
    /// <response code="200">Branches retrieved</response>
    /// <response code="404">Branches not found</response>
    /// <response code="500">Oops! Can't lookup user branches right now</response>
    [HttpGet]
    [Produces(typeof(UserDTO))]
    public IResult GetBranches(
        [FromQuery] string ip,
        [FromQuery] string database,
        [FromQuery] string userName,
        [FromServices] UsersData userData)
    {
        var user = userData.GetUserByUserName(userName);
        var userDTO = new UserDTO
        {
            Name = user.Name,
            Type = user.Type
        };
        return Results.Ok(userDTO);
    }
}