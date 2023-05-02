using DataAccess.Data;
using DXPOS.DTOs;
using DXPOS.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace DXPOS.Controllers.v1;

[ApiController]
[ApiVersion("1")]
[Route("v{version:apiVersion}/[controller]/[action]")]
public class CpuController : ControllerBase
{
    [HttpGet]
    [Produces(typeof(ResultDto<MaxNumCpuDto>))]
    public IActionResult GetCpuNum(
        [FromServices] CpuData cpuData)
    {
        MaxNumCpuDto maxNumCpuDto = new()
        {
            MaxNum = cpuData.GetPcNumber(),
        };

        var resultGenerator = new ResultGenerator<MaxNumCpuDto>(true, maxNumCpuDto, new ErrorMessage());
        return new JsonResult(resultGenerator.Generate());
    }

    [HttpPost]
    [Produces(typeof(ResultDto<CpuDto>))]
    public async Task<IActionResult> AddCpu(
         [FromQuery] int cpuNum,
         [FromQuery] string cpuName,
         [FromServices] CpuData cpuData)
    {
        ResultGenerator<CpuDto> resultGenerator;
        try
        {
            var id = await cpuData.AddCpu(cpuNum, cpuName);
            CpuDto cpuDto = new()
            {
                Id = id
            };

            resultGenerator = new ResultGenerator<CpuDto>(true, cpuDto, new ErrorMessage());
        }
        catch (Exception e)
        {
            resultGenerator = new ResultGenerator<CpuDto>(false, new CpuDto(), new ErrorMessage
            {
                Message = e.Message
            });
        }

        return new JsonResult(resultGenerator.Generate());
    }
}
