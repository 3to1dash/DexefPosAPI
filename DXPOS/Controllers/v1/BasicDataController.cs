using DataAccess.Data;
using DataAccess.Domain.Models;
using DXPOS.DTOs;
using DXPOS.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        var resultGenerator = new ResultGenerator<IEnumerable<BranchDto>>(true, branches, new List<ErrorMessage>());

        return new JsonResult(resultGenerator.SelectingMethods());
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

        var resultGenerator = new ResultGenerator<IEnumerable<StoreDto>>(true, stores, new List<ErrorMessage>());

        return new JsonResult(resultGenerator.SelectingMethods());
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

        var resultGenerator = new ResultGenerator<IEnumerable<TaxesDto>>(true, stores, new List<ErrorMessage>());

        return new JsonResult(resultGenerator.SelectingMethods());
    }


    [HttpGet]
    [Produces(typeof(ResultDto<List<CurrencyDto>>))]
    public IActionResult GeAllCurrencies([FromServices] CurrencyData currencyData)
    {
        var currencies = currencyData.GetCurrencies();
        var Dto = currencies.Select(c => new CurrencyDto
        {
            Id = c.Id,
            Num = c.Num,
            Name = c.Name,
            Value = c.Value,
            SubOne = c.SubOne,
            LocalRate = c.LocalRate
        }).ToList();
        if (Dto == null || !Dto.Any())
            return BadRequest("Currencies not found");
        return Ok(Dto);
    }


    [HttpGet]
    [Produces(typeof(ResultDto<List<CurrencyDto>>))]
    public IActionResult GeCurrencyById(
                [FromQuery][Required] string Value,
    [FromServices] CurrencyData currencyData)
    {
        if (string.IsNullOrEmpty(Value))
        {
            return BadRequest("Value cannot be null or empty");
        }
        var Serach = currencyData.GetSearchedCurrency(Value);
        var currencyDto = new CurrencyDto
        {
            Id = Serach.Id,
            Num = Serach.Num,
            Name = Serach.Name,
            Value = Serach.Value,
            SubOne = Serach.SubOne,
            LocalRate = Serach.LocalRate
        };
        return Ok(currencyDto);
    }
    [HttpGet]
    [Produces(typeof(ResultDto<List<AccountMainDto>>))]
    public IActionResult GeAccountmainByBranchId(
                        [FromQuery] decimal Value,
    [FromServices] AccountMainData accountMainData)
    {
        var Search = accountMainData.GetAcountMainByBranchid(Value);
        var dto = new AccountMainDto
        {
            RegNum = Search
        };
        if (dto == null)
            return BadRequest("Currencies not found");
        return Ok(dto);
    }
    [HttpGet]
    [Produces(typeof(ResultDto<List<ItemSearchDto>>))]
    public IActionResult GetKindData(
           [FromQuery][Required] int store_id,
           [FromQuery][Required] int groupid,
           [FromQuery][Required] string OldId,
           [FromQuery][Required] int page,
        [FromServices] ItemSearchData itemSearchData)
    {
        var xd = itemSearchData.GetAllItemSearch(store_id, groupid, OldId, page);
        if (xd == null || xd.Count <= 0)
        {
           return BadRequest("Entity comes Empty");
        }
        var Dto = xd.Select((x,i) => new ItemSearchDto
        {
            RN =i+1,
            Item_id = x.Id,
            Category_id = x.KindId,
            Kind_cost = x.KindCost,
            Total_val = x.TotalVal,
            IdentityUnite = x.IdentityUnite,
            HasEquation = x.HasEquation,
            IsOperate = x.IsOperate,
            ExprFormat = x.ExprFormat,
            Discountable = x.Discountable,
            ExprMin = x.ExprMin,
            Pricing_mode = x.PricingMode,
            Price_has_tax = x.PriceIncludeTax,
            Is_exp = x.IsExp,
            Minimum = x.Minimum,
            Maximum = x.Maximum,
            Category_name = x.ArName,
            Category_code = x.Code,
            Category_kind = x.Optkind,
            Isdiscountperc = x.Isdiscountperc,
            Discount_sale_value = x.Discountsale,
            Category_unite = x.Unite,
            Sale_price = x.Sale,
            Sale_price1 = x.Price1,
            Sale_price2 = x.Price2,
            Sale_price3 = x.Price3,
            Sale_price4 = x.Price4,
            Sale_price5 = x.Price5,
            Sale_price6 = x.Price6,
            Sale_price7 = x.Price7,
            Sale_price8 = x.Price8,
            Taxable = x.Taxable,
            Tax_amount = x.Tax,
            Serial_count = x.Serialcount,
            Currency = x.Currency,
            BuyPrice = x.Buy
        });
       
        return Ok(Dto);
    }


}
//if (string.IsNullOrEmpty(id))
//return BadRequest("Id Cannot be null or Empty");
//var intid = int.Parse(id);
//if (id <= 0 || id >= 20)
// return BadRequest("Id Cannot be null or Empty");