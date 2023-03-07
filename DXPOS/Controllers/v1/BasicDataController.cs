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
    [Produces(typeof(ResultDto<IEnumerable<BranchDto>>))]
    public IActionResult GetBranches(
        [FromQuery] string ip,
        [FromQuery] string database,
        [FromQuery] string userName,
        [FromServices] BranchesData branchesData)
    {
        var branches = branchesData.GetUserBranches(true, userName)
            .Select(b => new BranchDto 
            {
                Id = b.Id,
                Num = b.Num,
                Name = b.Name,
                Currency = b.Currency
            });

        var resultGenerator = new ResultGenerator<IEnumerable<BranchDto>>(true, branches, new List<ErrorMessage>());

        return new JsonResult(resultGenerator.SelectingMethods());
    }

    [HttpGet]
    [Produces(typeof(ResultDto<List<StoreDto>>))]
    public IActionResult GetStores(
        [FromQuery] string ip,
        [FromQuery] string database,
        [FromQuery] string userName,
        [FromQuery] string branchesList,
        [FromServices] BranchesData branchesData)
    {
        var stores = branchesData.GetBranchesStores(true, userName, branchesList)
            .Select(b => new StoreDto
             {
                 Id = b.Id,
                 Num = b.Num,
                 Name = b.Stock,
                 branch = b.CompanyBranch.Name
            });

        var resultGenerator = new ResultGenerator<IEnumerable<StoreDto>>(true, stores, new List<ErrorMessage>());

        return new JsonResult(resultGenerator.SelectingMethods());
    }
}