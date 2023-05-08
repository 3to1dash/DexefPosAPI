using BL.Data;
using DataAccess.Helpers;
using DXPOS.Helpers;
using DXPOS.ResponseDTOs;
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

    [HttpGet]
    [Produces(typeof(ResultDto<RegNumDto>))]
    public IActionResult getRegNum(
        [FromQuery] int branchID,
        [FromServices] BranchesData branchesData)
    {
        var regNum = branchesData.GetAccountMainMaxRegNum(branchID);

        var regNumDto = new RegNumDto { RegNum = regNum };

        var resultGenerator = new ResultGenerator<RegNumDto>(true, regNumDto, new ErrorMessage());

        return new JsonResult(resultGenerator.Generate());
    }

    [HttpGet]
    [Produces(typeof(ResultDto<NumWithPrefixDto>))]
    public IActionResult GetNumFromTable(
        [FromQuery] string dealing,
        [FromQuery] int branchId,
        [FromQuery] int CPU,
        [FromQuery] DateTime DTNow,
        [FromQuery] string? CustPrefix,
        [FromServices] BranchesData branchesData)
    {
        int? startNumber = 0;
        string? prefix;

        var invoiceTableNames = DealingHelperMethods.LoadTableName(dealing);

        if (string.IsNullOrEmpty(CustPrefix))
        {
            var result = branchesData.LoadPrefix(dealing, branchId, CPU, DTNow, out prefix, out startNumber);
        }
        else
        {
            prefix = CustPrefix;
        }

        branchesData.GetBillNumber(branchId, invoiceTableNames.Table, prefix, startNumber, out var num, out _, false);

        var numWithPrefix = new NumWithPrefixDto { Num = num, Prefix = prefix, BillNum = prefix + num };

        var resultGenerator = new ResultGenerator<NumWithPrefixDto>(true, numWithPrefix, new ErrorMessage());

        return new JsonResult(resultGenerator.Generate());
    }
}