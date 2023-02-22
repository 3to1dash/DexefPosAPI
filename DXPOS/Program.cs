using DataAccess;
using Microsoft.AspNetCore.Mvc;
using DXPOS.Extensions;
using DXPOS.Swagger;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

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
