using BL.Data;
using DataAccess.Domain.Models;
using DXPOS.Helpers;
using DXPOS.RequestDTOs;
using DXPOS.ResponseDTOs;
using Microsoft.AspNetCore.Mvc;

namespace DXPOS.Controllers.v1;

[ApiController]
[ApiVersion("1")]
[Route("v{version:apiVersion}/[controller]/[action]")]
public class CustController : ControllerBase
{
    [HttpPost]
    [Produces(typeof(ResultDto<SuccessDto>))]
    public async Task<IActionResult> AddCust(
        [FromBody] AddCustDto cust,
        [FromServices] CustomerData customerData)
    {
        var customer = new Cust
        {
            BranchId = cust.branchID,
            TypeIndex = 0,
            ParentId = 0,
            Name = cust.name,
            Num = cust.num,
            FirstName = cust.name.Split(' ')[0],
            Active = true,
            Note = string.Empty,
            NoteIsImportant = false,
            Kind = "Cust",
            PageNum = string.Empty,
            Dt = DateTime.Now,
            Type = 1,
            PriceLevel = 1,
            Contacttime = null,
            AreaId = 0,
            GroupDiscount = 0,
            PersonalId = string.Empty,
            CashDiscount = 0,
            Taxable = false,
            Tax = 0,
            Prefix = string.Empty,
            Costid = 0,
            Rate = 1,
            TaxDoc = string.Empty,
            TaxGov = string.Empty,
            TradeRegister = string.Empty,
            Company = string.Empty,
            Person = string.Empty,
            Banknum = string.Empty,
            Bankname = string.Empty,
            Bankbranch = string.Empty,
            OpeningBalance = 0,
            ShowInAll = false,
            Phone1 = cust.phone,
            Phone2 = string.Empty,
            Phone3 = string.Empty,
            Mail = cust.mail,
            Adress = cust.address,
            CreditLimit = cust.creditLimit,
            TaxFile = cust.taxFile,
            Currency = cust.currency,
            WrittenBy = cust.writtenBy,
            LstUpdate = DateTime.Now,
            UpdatedBy = cust.writtenBy
        };

        var result = await customerData.SaveCustomer(customer, cust.cpu, "cmbcust");

        ResultGenerator<SuccessDto> resultGenerator;

        if (result > 0)
            resultGenerator = new ResultGenerator<SuccessDto>(true, new SuccessDto { Status = "True" }, new ErrorMessage());
        else
            resultGenerator = new ResultGenerator<SuccessDto>(false, new SuccessDto { Status = "False" }, new ErrorMessage());

        return new JsonResult(resultGenerator.Generate());
    }

    [HttpPost]
    [Produces(typeof(ResultDto<SuccessDto>))]
    public async Task<IActionResult> AddVendor(
        [FromBody] AddCustDto cust,
        [FromServices] CustomerData customerData)
    {
        var vendor = new Cust
        {
            BranchId = cust.branchID,
            TypeIndex = 0,
            ParentId = 0,
            Name = cust.name,
            Num = cust.num,
            FirstName = cust.name.Split(' ')[0],
            Active = true,
            Note = string.Empty,
            NoteIsImportant = false,
            Kind = "Vendor",
            PageNum = string.Empty,
            Dt = DateTime.Now,
            Type = 1,
            PriceLevel = 1,
            Contacttime = null,
            AreaId = 0,
            GroupDiscount = 0,
            PersonalId = string.Empty,
            CashDiscount = 0,
            Taxable = false,
            Tax = 0,
            Prefix = string.Empty,
            Costid = 0,
            Rate = 1,
            TaxDoc = string.Empty,
            TaxGov = string.Empty,
            TradeRegister = string.Empty,
            Company = string.Empty,
            Person = string.Empty,
            Banknum = string.Empty,
            Bankname = string.Empty,
            Bankbranch = string.Empty,
            OpeningBalance = 0,
            ShowInAll = false,
            Phone1 = cust.phone,
            Phone2 = string.Empty,
            Phone3 = string.Empty,
            Mail = cust.mail,
            Adress = cust.address,
            CreditLimit = cust.creditLimit,
            TaxFile = cust.taxFile,
            Currency = cust.currency,
            WrittenBy = cust.writtenBy,
            LstUpdate = DateTime.Now,
            UpdatedBy = cust.writtenBy
        };

        var result = await customerData.SaveCustomer(vendor, cust.cpu, "cmbvendor");

        ResultGenerator<SuccessDto> resultGenerator;

        if (result > 0)
            resultGenerator = new ResultGenerator<SuccessDto>(true, new SuccessDto { Status = "True" }, new ErrorMessage());
        else
            resultGenerator = new ResultGenerator<SuccessDto>(false, new SuccessDto { Status = "False" }, new ErrorMessage());

        return new JsonResult(resultGenerator.Generate());
    }

    [HttpGet]
    [Produces(typeof(ResultDto<CustDto>))]
    public IActionResult SearchVendor(
        [FromBody] SearchCustDto searchCust,
        [FromServices] CustomerData customerData)
    {
        var customer = customerData.GetCustomers(searchCust.BranchId, "vendor", searchCust.OldId, searchCust.Page);

        var customersDto = customer.Select(c => new CustDto
        {
            Id = c.Id,
            Num = c.Num,
            Name = c.Name,
            GrpName = c.GrpName,
            FirstName = c.FirstName,
            Balance = c.TotalBalance,
            Costid = c.Costid,
            Currency = c.Currency,
            CashDiscount = c.CashDiscount,
            GroupDiscount = c.GroupDiscount,
            Tax = c.Tax,
            Prefix = c.Prefix,
            Person = c.Person,
            Phone1 = c.Phone1,
            Phone2 = c.Phone2,
            Phone3 = c.Phone3,
            Adress = c.Adress,
            PriceLevel = c.PriceLevel,
            Kind = c.Kind,
            ShowInAll = c.ShowInAll,
            TypeIndex = c.TypeIndex,
            BranchID = c.BranchId,
            DefaultCash = c.DefaultCash,
            RepID = c.RepId,
            CreditLimit = c.CreditLimit,
            Taxable = c.Taxable,
            TaxPerc = c.TaxPerc,
            TaxName = c.TaxName
        });

        var resultGenerator = new ResultGenerator<IEnumerable<CustDto>>(true, customersDto, new ErrorMessage());

        return new JsonResult(resultGenerator.Generate());
    }

    [HttpGet]
    [Produces(typeof(ResultDto<CustDto>))]
    public IActionResult SearchCust(
        [FromBody] SearchCustDto searchCust,
        [FromServices] CustomerData customerData)
    {
        var customer = customerData.GetCustomers(searchCust.BranchId, "Cust", searchCust.OldId, searchCust.Page);

        var customersDto = customer.Select(c => new CustDto
        {
            Id = c.Id,
            Num = c.Num,
            Name = c.Name,
            GrpName = c.GrpName,
            FirstName = c.FirstName,
            Balance = c.TotalBalance,
            Costid = c.Costid,
            Currency = c.Currency,
            CashDiscount = c.CashDiscount,
            GroupDiscount = c.GroupDiscount,
            Tax = c.Tax,
            Prefix = c.Prefix,
            Person = c.Person,
            Phone1 = c.Phone1,
            Phone2 = c.Phone2,
            Phone3 = c.Phone3,
            Adress = c.Adress,
            PriceLevel = c.PriceLevel,
            Kind = c.Kind,
            ShowInAll = c.ShowInAll,
            TypeIndex = c.TypeIndex,
            BranchID = c.BranchId,
            DefaultCash = c.DefaultCash,
            RepID = c.RepId,
            CreditLimit = c.CreditLimit,
            Taxable = c.Taxable,
            TaxPerc = c.TaxPerc,
            TaxName = c.TaxName
        });

        var resultGenerator = new ResultGenerator<IEnumerable<CustDto>>(true, customersDto, new ErrorMessage());

        return new JsonResult(resultGenerator.Generate());
    }
}
