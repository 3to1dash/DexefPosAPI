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
        MaxNumCpuDto maxNumCpu = new()
        {
            MaxNum = cpuData.GetPcNumber() + 1,
        };
        var resultGenerator = new ResultGenerator<CurrentPcDto>(true, currentPc, new List<ErrorMessage>());
        return new JsonResult(resultGenerator.Generate());
    }
    [HttpPost]
    public IActionResult AddCpu(
         [FromQuery] int cpuNum
       , [FromQuery] string cpuName
       , [FromServices] CpuData cpuData
       )
    {
        try
        {
            cpuData.AddCpu(cpuNum, cpuName);
            return Ok("Done");

        }
        catch (Exception e)
        {
            return Ok("not");
        }


        //CpuDto cpuDto = new CpuDto()
        //{
        //    Id = id
        //};

        //var resultGenerator = new ResultGenerator<CpuDto>(true, cpuDto, new List<ErrorMessage>());
        //return new JsonResult(resultGenerator.SelectingMethods());

    }
}
