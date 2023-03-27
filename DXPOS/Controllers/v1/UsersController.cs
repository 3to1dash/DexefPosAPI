using DataAccess.Data;
using DXPOS.DTOs;
using DXPOS.Helpers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DXPOS.Controllers.v1;

[ApiController]
[ApiVersion("1")]
[Route("v{version:apiVersion}/[controller]/[action]")]
public class UsersController : ControllerBase
{
    [HttpGet]
    [Produces(typeof(ResultDto<UserDto>))]
    public IActionResult GetUsersData(
        [FromQuery] string userName,
        [FromQuery] string password,
        [FromServices] CompanyData companyData,
        [FromServices] UsersData usersData)
    {
        var isUserVerify = usersData.UserVerify(userName, password);

        ResultGenerator<UserDto> resultGenerator;

        if (!isUserVerify)
        {
            resultGenerator = new(false, new UserDto { Companies = new List<CompanyDto>(), Permissions = new List<UserPermissionDto>() } ,
                new List<ErrorMessage>
                {
                    new() {Code = "401", Message = "User is not authorized", Title = "Login error message"}
                });

            return new JsonResult(resultGenerator.SelectingMethods());
        }

        var companies = companyData.GetCompanies(userName);
        var companiesDto = companies.Select(c => new CompanyDto
        {
            Id = c.Id,
            Name = c.Name,
            Field = c.Field,
            Phone = c.Phone,
            ArCurrency = c.CurrencyTable?.ArName,
            EnCurrency = c.CurrencyTable?.EnName,
            Branches = c.CompanyBranches.Select(b => new BranchDto
            {
                Id = b.Id,
                Num = b.Num,
                Name = b.Name,
                Stores = b.KindStocks.Select(s => new StoreDto
                {
                    Id = s.Id,
                    Num = s.Num,
                    Name = s.Stock
                })
            })
        });

        var privileges = usersData.GetUsersPrivileges(userName);
        var permissionsDto = privileges.Select(p => new UserPermissionDto
        {
            PermissionID = p.PermissionId,
            PermissionName = p.Name,
            PermissionValue = p.EditorValue
        });

        resultGenerator = new(true, new UserDto { Companies = companiesDto, Permissions = permissionsDto }, new List<ErrorMessage>());

        return new JsonResult(resultGenerator.SelectingMethods());
    }
}