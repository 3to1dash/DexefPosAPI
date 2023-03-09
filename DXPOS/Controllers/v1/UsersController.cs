using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;

namespace DXPOS.Controllers.v1;

[ApiController]
[ApiVersion("1")]
[Route("v{version:apiVersion}/[controller]/[action]")]
public class UsersController : ControllerBase
{
    [HttpGet]
    //[Produces(typeof(ResultDto<IEnumerable<BranchDto>>))]
    public IActionResult GetUsersData(
        [FromQuery] string userName,
        [FromServices] CompanyData companyData)
    {
        var x = companyData.GetCompany(userName);

        return new JsonResult(x);
    }
}
