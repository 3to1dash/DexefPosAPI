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
        [FromQuery] string userName,
        [FromServices] BranchesData branchesData)
    {
        var branches = branchesData.GetUserBranches(true, userName)
            .Select(b => new BranchDto
            {
                Id = b.Id,
                Num = b.Num,
                Name = b.Name
            });

        var resultGenerator = new ResultGenerator<IEnumerable<BranchDto>>(true, branches, new ErrorMessage());

        return new JsonResult(resultGenerator.Generate());
    }

    [HttpGet]
    [Produces(typeof(ResultDto<List<StoreDto>>))]
    public IActionResult GetStores(
        [FromQuery] string userName,
        [FromQuery] string branchesList,
        [FromServices] BranchesData branchesData)
    {
        var stores = branchesData.GetBranchesStores(true, userName, branchesList)
            .Select(b => new StoreDto
            {
                Id = b.Id,
                Num = b.Num,
                Name = b.Stock
            });

        var resultGenerator = new ResultGenerator<IEnumerable<StoreDto>>(true, stores, new ErrorMessage());

        return new JsonResult(resultGenerator.Generate());
    }

    [HttpGet]
    [Produces(typeof(ResultDto<List<TaxesDto>>))]
    public IActionResult GetTaxes(
        [FromServices] BranchesData branchesData,
        [FromQuery] bool isSale = true)
    {
        var stores = branchesData.GetTaxes(true)
            .Select(b => new TaxesDto
            {
                TaxId = b.Id,
                TaxName = b.Name,
                DATPerc = b.Datperc,
                DATID = b.Datid,
                DATMinInvoice = b.DatminInvoice,
                EntryTaxId = b.TaxId,
                TaxPerc = isSale ? b.SaleTax : b.PurchaseTax
            });

        var resultGenerator = new ResultGenerator<IEnumerable<TaxesDto>>(true, stores, new ErrorMessage());

        return new JsonResult(resultGenerator.Generate());
    }

    [HttpGet]
    [Produces(typeof(ResultDto<TaskIdDto>))]
    public async Task<IActionResult> GetTaskID(
        [FromQuery] int cpu,
        [FromServices] BasicData basicData)
    {
        var taskId = await basicData.GetTaskIdByCpu(cpu);

        ResultGenerator<TaskIdDto> resultGenerator;

        if (taskId == null)
        {
            resultGenerator = new ResultGenerator<TaskIdDto>(false, new TaskIdDto(), new ErrorMessage
            {
                Code = "500",
                Title = "Record not found",
                Message = "Can not fetch the record from the database"
            });
        }
        else
        {
            resultGenerator = new ResultGenerator<TaskIdDto>(true, new TaskIdDto { TaskID = taskId }, new ErrorMessage());
        }

        return new JsonResult(resultGenerator.Generate());
    }
}