using DataAccess.Data;
using DXPOS.DTOs;
using DXPOS.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace DXPOS.Controllers.v1;
[ApiController]
[ApiVersion("1")]
[Route("v{version:apiVersion}/[controller]/[action]")]
public class CpuController : Controller
{
    [HttpGet]
    public IActionResult GetCpuNum(
        [FromServices] CpuData cpuData)
    {
        CurrentPcDto currentPc = new()
        {
            Pcnumber = cpuData.GetPcNumber() + 1,
        };
        var resultGenerator = new ResultGenerator<CurrentPcDto>(true, currentPc, new List<ErrorMessage>());
        return new JsonResult(resultGenerator.SelectingMethods());
    }
    [HttpPost]
    public IActionResult AddCpu(
         [FromQuery] int cpuNum
       , [FromQuery] int cpuName
       )
    {

        return Ok();
    }
}
