using DataAccess.Data;
using DataAccess.Domain.Models;
using DXPOS.DTOs;
using DXPOS.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace DXPOS.Controllers.v1;

[ApiController]
[ApiVersion("1")]
[Route("v{version:apiVersion}/[controller]/[action]")]
public class UsersController : ControllerBase
{
    [HttpGet]
    [Produces(typeof(ResultDto<IEnumerable<CompanyDto>>))]
    public IActionResult GetUsersData(
        [FromQuery] string userName,
        [FromQuery] string password,
        [FromServices] CompanyData companyData)
    {
        var isUserVerify = companyData.UserVerification(userName, password);

        ResultGenerator<IEnumerable<CompanyDto>> resultGenerator;

        if (!isUserVerify)
        {
            resultGenerator = new ResultGenerator<IEnumerable<CompanyDto>>(false, new List<CompanyDto>(), new List<ErrorMessage>
            {
                new() { Code = "401", Message = "User is not authorized", Title = "Login error message"}
            });

            return new JsonResult(resultGenerator.SelectingMethods());
        }

        var companies = companyData.GetCompanies(userName);
        var companiesDto = companies.Select(c =>
        {
            return new CompanyDto
            {
                Id = c.Id,
                Name = c.Name,
                Field = c.Field,
                Phone = c.Phone,
                ArCurrency = c.CurrencyTable?.ArName,
                EnCurrency = c.CurrencyTable?.EnName,
                Branches = c.CompanyBranches.Select(b =>
                {
                    return new BranchDto
                    {
                        Id = b.Id,
                        Num = b.Num,
                        Name = b.Name,
                        Stores = b.KindStocks.Select(s =>
                        {
                            return new StoreDto
                            {
                                Id = s.Id,
                                Num = s.Num,
                                Name = s.Stock
                            };
                        })
                    };
                })
            };
        });

        resultGenerator = new ResultGenerator<IEnumerable<CompanyDto>>(true, companiesDto, new List<ErrorMessage>());

        return new JsonResult(resultGenerator.SelectingMethods());
    }
}
