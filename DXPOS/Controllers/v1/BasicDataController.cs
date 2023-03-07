using DataAccess.Data;
using DXPOS.DTOs;
using DXPOS.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace DXPOS.Controllers.v1;

[ApiController]
[ApiVersion("1")]
[Route("v{version:apiVersion}/[controller]/[action]")]
public class BasicDataController : ControllerBase
{
    [HttpGet]
    [Produces(typeof(UserDTO))]
    public IActionResult GetBranches(
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

        var resultGenerator = new ResultGenerator<UserDTO>(true, userDTO, new List<ErrorMessage>());

        return new JsonResult(resultGenerator.SelectingMethods());
    }
}