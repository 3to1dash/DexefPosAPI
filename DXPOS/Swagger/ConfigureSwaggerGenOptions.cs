using System.Reflection;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace DXPOS.Swagger;

public class ConfigureSwaggerGenOptions : IConfigureOptions<SwaggerGenOptions>
{
    private readonly IApiVersionDescriptionProvider _apiVersionDescriptionProvider;

    public ConfigureSwaggerGenOptions(IApiVersionDescriptionProvider apiVersionDescriptionProvider)
        => _apiVersionDescriptionProvider = apiVersionDescriptionProvider;

    public void Configure(SwaggerGenOptions options)
    {
        foreach (var description in _apiVersionDescriptionProvider.ApiVersionDescriptions)
        {
            options.SwaggerDoc(description.GroupName, CreateOpenApiInfo(description));
        }
    }

    private OpenApiInfo CreateOpenApiInfo(ApiVersionDescription description)
    {
        var info = new OpenApiInfo()
        {
            Title =
                $"{this.GetType().Assembly.GetCustomAttribute<AssemblyProductAttribute>()?.Product} {description.ApiVersion}",
            Version = description.ApiVersion.ToString(),
            Description = description.IsDeprecated
                ? $"{this.GetType().Assembly.GetCustomAttribute<AssemblyDescriptionAttribute>()?.Description} - DEPRECATED"
                : this.GetType().Assembly.GetCustomAttribute<AssemblyDescriptionAttribute>()?.Description
        };

        return info;
    }
}