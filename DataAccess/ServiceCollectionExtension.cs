using DataAccess.Data;
using DataAccess.DataAccess;
using DataAccess.IDataAccess;
using DataAccess.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection service)
    {
        service.AddDbContext<DxdbContext>(opts =>
        {
            opts.ConfigureWarnings(w => w.Ignore(SqlServerEventId.DecimalTypeKeyWarning));
        });
        service.AddScoped<ILoadMethods, LoadMethods>();
        service.AddScoped<UsersData>();
        return service;
    }
}
