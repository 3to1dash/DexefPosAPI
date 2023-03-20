using DataAccess.Data;
using DataAccess.Domain.Models;
using DXPOS.DTOs;
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
        [FromServices] CompanyData companyData)
    {
        var user = companyData.GetUserVerification(userName);
        var userVerification = new UserDto
        {
            Password = user.Passward,
            SerialNumber = user.Sn,
            UserType = user.Type,
            ShowMyReportOnly = user.ShowMyReportOnly ?? false,
            Permission = user.Permission,
            PrivilegeID = user.PrivilegeId,
            BranchID = user.BranchId
        };

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

        return new JsonResult(companiesDto);
    }
}
