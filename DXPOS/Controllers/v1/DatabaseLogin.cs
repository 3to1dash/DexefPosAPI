using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DXPOS.Controllers.v1;

[ApiController]
[ApiVersion("1")]
[Route("v{version:apiVersion}/[controller]/[action]")]
public class DatabaseLogin : ControllerBase
{
    private readonly IConfiguration _configuration;

    public DatabaseLogin(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet]
    public IActionResult Login(
        [FromQuery] [Required] string ip,
        [FromQuery] [Required] string database)
    {
        var dataBaseClaims = new[]
        {
            new Claim("ip", ip),
            new Claim("database", database)
        };

        var secret = _configuration["Jwt:Key"];
        var issuer = _configuration["Jwt:Issuer"];

        if (secret == null || issuer == null)
            throw new ApplicationException();

        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
        var tokenDescriptor = new JwtSecurityToken(issuer: issuer, audience: issuer, claims: dataBaseClaims,
            expires: DateTime.Now.AddDays(30), signingCredentials: credentials);

        var token = new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);

        return new JsonResult(new {Token = token});
    }
}