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
        service.AddDbContext<IDbContext, DxdbContext>(opts =>
        {
            opts.ConfigureWarnings(w => w.Ignore(SqlServerEventId.DecimalTypeKeyWarning));
        });
        service.AddDbContext<IDbContext, DXDBFilesContext>(opts =>
        {
            opts.ConfigureWarnings(w => w.Ignore(SqlServerEventId.DecimalTypeKeyWarning));
        });
        service.AddScoped<ILoadMethods, LoadMethods>();
        service.AddScoped<IAddMethods, AddMethods>();
        service.AddScoped<IUpdateMethods, UpdateMethods>();
        service.AddScoped<ISoftDeleteMethods, SoftDeleteMethods>();
        service.AddScoped<ISaveChangesMethods, SaveChangesMethods>();
        service.AddScoped<BranchesData>();
        service.AddScoped<UsersData>();
        service.AddScoped<CompanyData>();
        service.AddScoped<CurrencyData>();
        service.AddScoped<AccountMainData>();
        service.AddScoped<ItemSearchData>();
        return service;
    }
}