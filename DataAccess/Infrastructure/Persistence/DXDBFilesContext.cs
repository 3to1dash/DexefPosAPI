using DataAccess.Domain;
using DataAccess.Infrastructure.Persistence.DXFilesConfigurations;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Net.Http.Headers;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DataAccess.Domain.FilesModels;
using Microsoft.EntityFrameworkCore.Storage;

namespace DataAccess.Infrastructure.Persistence;

public class DXDBFilesContext : DbContext, IDbContext
{
    private readonly IConfiguration _configuration;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IPublisher _publisher;
    private readonly ILogger<DXDBFilesContext> _logger;
    private IDbContextTransaction? _currentTransaction;

    public DXDBFilesContext(
        DbContextOptions<DXDBFilesContext> options,
        IConfiguration configuration,
        IHttpContextAccessor httpContextAccessor,
        IPublisher publisher,
        ILogger<DXDBFilesContext> logger) : base(options)
    {
        _configuration = configuration;
        _httpContextAccessor = httpContextAccessor;
        _publisher = publisher;
        _logger = logger;
    }

    public DXDBFilesContext(
        IConfiguration configuration,
        IHttpContextAccessor httpContextAccessor,
        IPublisher publisher,
        ILogger<DXDBFilesContext> logger)
    {
        _configuration = configuration;
        _httpContextAccessor = httpContextAccessor;
        _publisher = publisher;
        _logger = logger;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var dbSecrets = _configuration.GetSection("DBSecrets").GetChildren().ToDictionary(k => k.Key, v => v.Value);

        var principal = ExtractJwtPayload();
        if (principal == null)
            throw new UnauthorizedAccessException("Please send JWT token in the request");

        var ip = principal.FindFirstValue("ip");
        var database = principal.FindFirstValue("database");

        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = ConnStringBuilder(ip, database,
                dbSecrets.GetValueOrDefault("Username"),
                dbSecrets.GetValueOrDefault("Password"));

            optionsBuilder.UseSqlServer(connectionString);
        }

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Arabic_CI_AS");

        modelBuilder.ApplyConfiguration(new AccountsFileConfigurations());
        modelBuilder.ApplyConfiguration(new AccountsGroupConfigurations());
        modelBuilder.ApplyConfiguration(new CashPaymentFileConfigurations());
        modelBuilder.ApplyConfiguration(new CashPaymentGroupConfigurations());
        modelBuilder.ApplyConfiguration(new ChequeFileConfigurations());
        modelBuilder.ApplyConfiguration(new ChequeGroupConfigurations());
        modelBuilder.ApplyConfiguration(new CustFileConfigurations());
        modelBuilder.ApplyConfiguration(new CustGroupConfigurations());
        modelBuilder.ApplyConfiguration(new CustomReportGroupConfigurations());
        modelBuilder.ApplyConfiguration(new EmployeesFileConfigurations());
        modelBuilder.ApplyConfiguration(new EmployeesGroupConfigurations());
        modelBuilder.ApplyConfiguration(new EmplSalaryCalcFileConfigurations());
        modelBuilder.ApplyConfiguration(new EmplSalaryCalcGroupConfigurations());
        modelBuilder.ApplyConfiguration(new EmplSalaryPayFileConfigurations());
        modelBuilder.ApplyConfiguration(new EmplSalaryPayGroupConfigurations());
        modelBuilder.ApplyConfiguration(new EmplTransactionFileConfigurations());
        modelBuilder.ApplyConfiguration(new EmplTransactionGroupConfigurations());
        modelBuilder.ApplyConfiguration(new ExpensesFileConfigurations());
        modelBuilder.ApplyConfiguration(new ExpensesGroupConfigurations());
        modelBuilder.ApplyConfiguration(new ExtraFieldDesignConfigurations());
        modelBuilder.ApplyConfiguration(new FixedAssetAreaFileConfigurations());
        modelBuilder.ApplyConfiguration(new FixedAssetAreaGroupConfigurations());
        modelBuilder.ApplyConfiguration(new FixedAssetCategoryFileConfigurations());
        modelBuilder.ApplyConfiguration(new FixedAssetCategoryGroupConfigurations());
        modelBuilder.ApplyConfiguration(new FixedAssetDailyDeprecateFileConfigurations());
        modelBuilder.ApplyConfiguration(new FixedAssetDailyDeprecateGroupConfigurations());
        modelBuilder.ApplyConfiguration(new FixedAssetDeprecationMethodFileConfigurations());
        modelBuilder.ApplyConfiguration(new FixedAssetDeprecationMethodGroupConfigurations());
        modelBuilder.ApplyConfiguration(new FixedAssetFileConfigurations());
        modelBuilder.ApplyConfiguration(new FixedAssetGroupConfigurations());
        modelBuilder.ApplyConfiguration(new IncomeFileConfigurations());
        modelBuilder.ApplyConfiguration(new IncomeGroupConfigurations());
        modelBuilder.ApplyConfiguration(new InvoiceFileConfigurations());
        modelBuilder.ApplyConfiguration(new InvoiceGroupConfigurations());
        modelBuilder.ApplyConfiguration(new ItemsFileConfigurations());
        modelBuilder.ApplyConfiguration(new ItemsGroupConfigurations());
        modelBuilder.ApplyConfiguration(new LayoutFileConfigurations());
        modelBuilder.ApplyConfiguration(new ReportDesignConfigurations());
        modelBuilder.ApplyConfiguration(new ReportDesignEntryConfigurations());
        modelBuilder.ApplyConfiguration(new ReportDesignPrefrenceConfigurations());
        modelBuilder.ApplyConfiguration(new ReportTemplateConfigurations());
        modelBuilder.ApplyConfiguration(new TouchLayoutColumnConfigurations());
        modelBuilder.ApplyConfiguration(new TouchLayoutConfigurations());
        modelBuilder.ApplyConfiguration(new TripContractFileConfigurations());
        modelBuilder.ApplyConfiguration(new TripContractGroupConfigurations());
        modelBuilder.ApplyConfiguration(new TripTicketFileConfigurations());
        modelBuilder.ApplyConfiguration(new TripTicketGroupConfigurations());
        modelBuilder.ApplyConfiguration(new ViewDesignConfigurations());
        modelBuilder.ApplyConfiguration(new WorkAbsentFileConfigurations());
        modelBuilder.ApplyConfiguration(new WorkAbsentGroupConfigurations());
        modelBuilder.ApplyConfiguration(new WorkExtradayFileConfigurations());
        modelBuilder.ApplyConfiguration(new WorkExtradayGroupConfigurations());
        modelBuilder.ApplyConfiguration(new WorkPermissionFileConfigurations());
        modelBuilder.ApplyConfiguration(new WorkPermissionGroupConfigurations());
        modelBuilder.ApplyConfiguration(new WorkPledgePayFileConfigurations());
        modelBuilder.ApplyConfiguration(new WorkPledgePayGroupConfigurations());
        modelBuilder.ApplyConfiguration(new WorkVacationFileConfigurations());
        modelBuilder.ApplyConfiguration(new WorkVacationGroupConfigurations());

        base.OnModelCreating(modelBuilder);

        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(DXDBFilesContext).Assembly);
    }

    public async Task BeginTransactionAsync()
    {
        if (_currentTransaction is not null)
        {
            _logger.LogInformation("A transaction with ID {ID} is already created", _currentTransaction.TransactionId);
            return;
        }


        _currentTransaction = await Database.BeginTransactionAsync();
        _logger.LogInformation("A new transaction was created with ID {ID}", _currentTransaction.TransactionId);
    }

    public async Task CommitTransactionAsync()
    {
        if (_currentTransaction is null)
        {
            return;
        }

        _logger.LogInformation("Commiting Transaction {ID}", _currentTransaction.TransactionId);

        await _currentTransaction.CommitAsync();

        _currentTransaction.Dispose();
        _currentTransaction = null;
    }

    public async Task RollbackTransaction()
    {
        if (_currentTransaction is null)
        {
            return;
        }

        _logger.LogDebug("Rolling back Transaction {ID}", _currentTransaction.TransactionId);

        await _currentTransaction.RollbackAsync();

        _currentTransaction.Dispose();
        _currentTransaction = null;
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var result = await base.SaveChangesAsync(cancellationToken);

        var events = ChangeTracker.Entries<IHasDomainEvent>()
            .Select(x => x.Entity.DomainEvents)
            .SelectMany(x => x)
            .Where(domainEvent => !domainEvent.IsPublished)
            .ToArray();

        foreach (var @event in events)
        {
            @event.IsPublished = true;

            _logger.LogInformation("New domain event {Event}", @event.GetType().Name);

            // Note: If an unhandled exception occurs, all the saved changes will be rolled back
            // by the TransactionBehavior. All the operations related to a domain event finish
            // successfully or none of them do.
            // Reference: https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/domain-events-design-implementation#what-is-a-domain-event
            await _publisher.Publish(@event);
        }

        return result;
    }

    private static string ConnStringBuilder(string? ip, string? dbName, string? userName, string? password)
    {
        string connString =
            string.Format(
                "Server={0};Database={1};User Id={2};Password={3};MultipleActiveResultSets=true;Integrated Security = false;TrustServerCertificate=True;",
                ip, dbName, userName, password);

        return connString;
    }

    /// <summary>
    /// Extract JWT payload from the HttpContext request
    /// </summary>
    /// <returns><see cref="ClaimsPrincipal"/></returns>
    /// <exception cref="ApplicationException"></exception>
    private ClaimsPrincipal? ExtractJwtPayload()
    {
        var secret = _configuration["Jwt:Key"];
        var issuer = _configuration["Jwt:Issuer"];
        if (secret == null || issuer == null)
            throw new ApplicationException("Jwt's secret and issuer in appsettings are not to be found");

        var token = _httpContextAccessor.HttpContext.Request.Headers[HeaderNames.Authorization].ToString()
            .Replace("Bearer ", "");

        if (string.IsNullOrEmpty(token))
            return null;

        var mySecret = Encoding.UTF8.GetBytes(secret);
        var mySecurityKey = new SymmetricSecurityKey(mySecret);
        var tokenHandler = new JwtSecurityTokenHandler();
        var principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidIssuer = issuer,
            ValidAudience = issuer,
            IssuerSigningKey = mySecurityKey,
        }, out SecurityToken validatedToken);

        return principal;
    }

    #region DbSets

    public virtual DbSet<AccountsFile> AccountsFiles { get; set; } = null!;
    public virtual DbSet<AccountsGroup> AccountsGroups { get; set; } = null!;
    public virtual DbSet<CashPaymentFile> CashPaymentFiles { get; set; } = null!;
    public virtual DbSet<CashPaymentGroup> CashPaymentGroups { get; set; } = null!;
    public virtual DbSet<ChequeFile> ChequeFiles { get; set; } = null!;
    public virtual DbSet<ChequeGroup> ChequeGroups { get; set; } = null!;
    public virtual DbSet<CustFile> CustFiles { get; set; } = null!;
    public virtual DbSet<CustGroup> CustGroups { get; set; } = null!;
    public virtual DbSet<CustomReportGroup> CustomReportGroups { get; set; } = null!;
    public virtual DbSet<EmplSalaryCalcFile> EmplSalaryCalcFiles { get; set; } = null!;
    public virtual DbSet<EmplSalaryCalcGroup> EmplSalaryCalcGroups { get; set; } = null!;
    public virtual DbSet<EmplSalaryPayFile> EmplSalaryPayFiles { get; set; } = null!;
    public virtual DbSet<EmplSalaryPayGroup> EmplSalaryPayGroups { get; set; } = null!;
    public virtual DbSet<EmplTransactionFile> EmplTransactionFiles { get; set; } = null!;
    public virtual DbSet<EmplTransactionGroup> EmplTransactionGroups { get; set; } = null!;
    public virtual DbSet<EmployeesFile> EmployeesFiles { get; set; } = null!;
    public virtual DbSet<EmployeesGroup> EmployeesGroups { get; set; } = null!;
    public virtual DbSet<ExpensesFile> ExpensesFiles { get; set; } = null!;
    public virtual DbSet<ExpensesGroup> ExpensesGroups { get; set; } = null!;
    public virtual DbSet<ExtraFieldDesign> ExtraFieldDesigns { get; set; } = null!;
    public virtual DbSet<FixedAssetAreaFile> FixedAssetAreaFiles { get; set; } = null!;
    public virtual DbSet<FixedAssetAreaGroup> FixedAssetAreaGroups { get; set; } = null!;
    public virtual DbSet<FixedAssetCategoryFile> FixedAssetCategoryFiles { get; set; } = null!;
    public virtual DbSet<FixedAssetCategoryGroup> FixedAssetCategoryGroups { get; set; } = null!;
    public virtual DbSet<FixedAssetDailyDeprecateFile> FixedAssetDailyDeprecateFiles { get; set; } = null!;
    public virtual DbSet<FixedAssetDailyDeprecateGroup> FixedAssetDailyDeprecateGroups { get; set; } = null!;
    public virtual DbSet<FixedAssetDeprecationMethodFile> FixedAssetDeprecationMethodFiles { get; set; } = null!;
    public virtual DbSet<FixedAssetDeprecationMethodGroup> FixedAssetDeprecationMethodGroups { get; set; } = null!;
    public virtual DbSet<FixedAssetFile> FixedAssetFiles { get; set; } = null!;
    public virtual DbSet<FixedAssetGroup> FixedAssetGroups { get; set; } = null!;
    public virtual DbSet<IncomeFile> IncomeFiles { get; set; } = null!;
    public virtual DbSet<IncomeGroup> IncomeGroups { get; set; } = null!;
    public virtual DbSet<InvoiceFile> InvoiceFiles { get; set; } = null!;
    public virtual DbSet<InvoiceGroup> InvoiceGroups { get; set; } = null!;
    public virtual DbSet<ItemsFile> ItemsFiles { get; set; } = null!;
    public virtual DbSet<ItemsGroup> ItemsGroups { get; set; } = null!;
    public virtual DbSet<LayoutFile> LayoutFiles { get; set; } = null!;
    public virtual DbSet<ReportDesign> ReportDesigns { get; set; } = null!;
    public virtual DbSet<ReportDesignEntry> ReportDesignEntries { get; set; } = null!;
    public virtual DbSet<ReportDesignPrefrence> ReportDesignPrefrences { get; set; } = null!;
    public virtual DbSet<ReportTemplate> ReportTemplates { get; set; } = null!;
    public virtual DbSet<TouchLayout> TouchLayouts { get; set; } = null!;
    public virtual DbSet<TouchLayoutColumn> TouchLayoutColumns { get; set; } = null!;
    public virtual DbSet<TripContractFile> TripContractFiles { get; set; } = null!;
    public virtual DbSet<TripContractGroup> TripContractGroups { get; set; } = null!;
    public virtual DbSet<TripTicketFile> TripTicketFiles { get; set; } = null!;
    public virtual DbSet<TripTicketGroup> TripTicketGroups { get; set; } = null!;
    public virtual DbSet<ViewDesign> ViewDesigns { get; set; } = null!;
    public virtual DbSet<WorkAbsentFile> WorkAbsentFiles { get; set; } = null!;
    public virtual DbSet<WorkAbsentGroup> WorkAbsentGroups { get; set; } = null!;
    public virtual DbSet<WorkExtradayFile> WorkExtradayFiles { get; set; } = null!;
    public virtual DbSet<WorkExtradayGroup> WorkExtradayGroups { get; set; } = null!;
    public virtual DbSet<WorkPermissionFile> WorkPermissionFiles { get; set; } = null!;
    public virtual DbSet<WorkPermissionGroup> WorkPermissionGroups { get; set; } = null!;
    public virtual DbSet<WorkPledgePayFile> WorkPledgePayFiles { get; set; } = null!;
    public virtual DbSet<WorkPledgePayGroup> WorkPledgePayGroups { get; set; } = null!;
    public virtual DbSet<WorkVacationFile> WorkVacationFiles { get; set; } = null!;
    public virtual DbSet<WorkVacationGroup> WorkVacationGroups { get; set; } = null!;

    #endregion
}