using DataAccess;
using Microsoft.AspNetCore.Mvc;
using DXPOS.Extensions;
using DXPOS.Swagger;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var configurations = builder.Configuration;

if (builder.Environment.IsDevelopment())
    configurations.AddJsonFile("appsettings.Debug.json");

// Add services to the container.
builder.Services.AddHealthChecks();
builder.Host.AddSerilog();
builder.Services.AddHttpContextAccessor();
builder.Services.AddControllers();

builder.Services.AddMediator();
builder.Services.AddDataAccessServices();

builder.Services.AddApiVersioning(opts =>
{
    opts.DefaultApiVersion = new ApiVersion(1, 0);
    opts.AssumeDefaultVersionWhenUnspecified = true;
    opts.ReportApiVersions = true;
    opts.ApiVersionReader = new UrlSegmentApiVersionReader();
});

builder.Services.AddVersionedApiExplorer(opts =>
{
    opts.GroupNameFormat = "'v'VVV";
    opts.SubstituteApiVersionInUrl = true;
});

builder.Services.AddSwaggerGen(opts =>
{
    opts.OperationFilter<SwaggerDefaultValues>();
    var filePath = Path.Combine(AppContext.BaseDirectory, "DXPOS.xml");
    opts.IncludeXmlComments(filePath);
    opts.AddSecurityDefinition(name: "Bearer", securityScheme: new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Description = "Enter the Bearer Authorization string as following: `Bearer Generated-JWT-Token`",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    opts.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Name = "Bearer",
                In = ParameterLocation.Header,
                Reference = new OpenApiReference
                {
                    Id = "Bearer",
                    Type = ReferenceType.SecurityScheme
                }
            },
            new List<string>()
        }
    });
});

builder.Services.AddAuthentication(opts =>
{
    opts.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opts.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    opts.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(opts =>
{
    opts.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = configurations["Jwt:Issuer"],
        ValidAudience = configurations["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configurations["Jwt:Key"]))
    };
});

builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerGenOptions>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())

app.UseSwagger();
app.UseSwaggerUI(opts =>
{
    opts.SwaggerEndpoint("/swagger/v1/swagger.json", "DXPOS API Version 1");
    opts.SwaggerEndpoint("/swagger/v2/swagger.json", "DXPOS API Version 2");

    opts.DefaultModelsExpandDepth(-1);
    //opts.ConfigObject.AdditionalItems["syntaxHighlight"] = new Dictionary<string, object>
    //{
    //    ["activated"] = false
    //};
});

app.UseHttpsRedirection();

app.MapControllers();

app.Map("/", () => Results.Redirect("/swagger"));

app.MapHealthChecks("/healthcheck").WithName("health").WithOpenApi();

app.Run();
