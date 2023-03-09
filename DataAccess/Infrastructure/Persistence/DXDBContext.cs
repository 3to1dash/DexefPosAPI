﻿using DataAccess.Domain;
using DataAccess.Infrastructure.Persistence.DXConfigurations;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Net.Http.Headers;

namespace DataAccess.Infrastructure.Persistence;

public partial class DxdbContext : DbContext
{
    private readonly IConfiguration _configuration;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IPublisher _publisher;
    private readonly ILogger<DxdbContext> _logger;
    private IDbContextTransaction? _currentTransaction;

    public DxdbContext(
        DbContextOptions<DxdbContext> options,
        IConfiguration configuration,
        IHttpContextAccessor httpContextAccessor,
        IPublisher publisher,
        ILogger<DxdbContext> logger) : base(options)
    {
        _configuration = configuration;
        _httpContextAccessor = httpContextAccessor;
        _publisher = publisher;
        _logger = logger;
    }

    public DxdbContext(
        IConfiguration configuration,
        IHttpContextAccessor httpContextAccessor,
        IPublisher publisher,
        ILogger<DxdbContext> logger)
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

            optionsBuilder.UseSqlServer(connectionString ?? "");
        }

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Arabic_CI_AS");

        modelBuilder.ApplyConfiguration(new AccPayrollItemConfiguration());
        modelBuilder.ApplyConfiguration(new AccountConfiguration());
        modelBuilder.ApplyConfiguration(new AccountMonthlyConfiguration());
        modelBuilder.ApplyConfiguration(new AccountOperandConfiguration());
        modelBuilder.ApplyConfiguration(new AccountTransactionConfiguration());
        modelBuilder.ApplyConfiguration(new AccountTransactionEntryConfiguration());
        modelBuilder.ApplyConfiguration(new AccountTypeConfiguration());
        modelBuilder.ApplyConfiguration(new AccountWorkLinkConfiguration());
        modelBuilder.ApplyConfiguration(new AccountmainConfiguration());
        modelBuilder.ApplyConfiguration(new AddressCostConfiguration());
        modelBuilder.ApplyConfiguration(new AlarmConfiguration());
        modelBuilder.ApplyConfiguration(new AlarmEndUserConfiguration());
        modelBuilder.ApplyConfiguration(new AlarmListConfiguration());
        modelBuilder.ApplyConfiguration(new AlarmsPostponedConfiguration());
        modelBuilder.ApplyConfiguration(new AppointmentConfiguration());
        modelBuilder.ApplyConfiguration(new ArchiveConfiguration());
        modelBuilder.ApplyConfiguration(new ArchiveRelConfiguration());
        modelBuilder.ApplyConfiguration(new AreaConfiguration());
        modelBuilder.ApplyConfiguration(new AreaLinkConfiguration());
        modelBuilder.ApplyConfiguration(new AssetConfiguration());
        modelBuilder.ApplyConfiguration(new AssetDestroyConfiguration());
        modelBuilder.ApplyConfiguration(new AssetImproveConfiguration());
        modelBuilder.ApplyConfiguration(new AssetInRentConfiguration());
        modelBuilder.ApplyConfiguration(new AssetPriceConfiguration());
        modelBuilder.ApplyConfiguration(new AssetRecalcConfiguration());
        modelBuilder.ApplyConfiguration(new AssetRentConfiguration());
        modelBuilder.ApplyConfiguration(new AssetRentAppointmentConfiguration());
        modelBuilder.ApplyConfiguration(new AssetRentEntryConfiguration());
        modelBuilder.ApplyConfiguration(new AssetRentLongConfiguration());
        modelBuilder.ApplyConfiguration(new AssetRentLongInstallConfiguration());
        modelBuilder.ApplyConfiguration(new AssetRentResourceConfiguration());
        modelBuilder.ApplyConfiguration(new AssetReserveConfiguration());
        modelBuilder.ApplyConfiguration(new AssetSaleConfiguration());
        modelBuilder.ApplyConfiguration(new AssetSpentConfiguration());
        modelBuilder.ApplyConfiguration(new AssetSpentEntryConfiguration());
        modelBuilder.ApplyConfiguration(new AttendanceLogConfiguration());
        modelBuilder.ApplyConfiguration(new AttentionConfiguration());
        modelBuilder.ApplyConfiguration(new BadgetItemConfiguration());
        modelBuilder.ApplyConfiguration(new BadgetItemsEntryConfiguration());
        modelBuilder.ApplyConfiguration(new BadgetMasterConfiguration());
        modelBuilder.ApplyConfiguration(new BadgetMasterEntryConfiguration());
        modelBuilder.ApplyConfiguration(new BadgetValueConfiguration());
        modelBuilder.ApplyConfiguration(new BadgetValueEntryConfiguration());
        modelBuilder.ApplyConfiguration(new BalanceConfiguration());
        modelBuilder.ApplyConfiguration(new BankConfiguration());
        modelBuilder.ApplyConfiguration(new BankDealingConfiguration());
        modelBuilder.ApplyConfiguration(new BarcodeItemConfiguration());
        modelBuilder.ApplyConfiguration(new BarcodeQrConfiguration());
        modelBuilder.ApplyConfiguration(new BarcodeScaleConfiguration());
        modelBuilder.ApplyConfiguration(new BatchNumberConfiguration());
        modelBuilder.ApplyConfiguration(new BatchNumberDeactivateConfiguration());
        modelBuilder.ApplyConfiguration(new BatchNumberTransferResultConfiguration());
        modelBuilder.ApplyConfiguration(new BatchNumberTransferTempConfiguration());
        modelBuilder.ApplyConfiguration(new BillApprovalConfiguration());
        modelBuilder.ApplyConfiguration(new BillClassConfiguration());
        modelBuilder.ApplyConfiguration(new BillCustDiscountConfiguration());
        modelBuilder.ApplyConfiguration(new BillDealingConfiguration());
        modelBuilder.ApplyConfiguration(new BillDeleteConfiguration());
        modelBuilder.ApplyConfiguration(new BillDeleteEntryConfiguration());
        modelBuilder.ApplyConfiguration(new BillEditConfiguration());
        modelBuilder.ApplyConfiguration(new BillEditEntryConfiguration());
        modelBuilder.ApplyConfiguration(new BillHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new BillItemsSearchViewConfiguration());
        modelBuilder.ApplyConfiguration(new BillPauseConfiguration());
        modelBuilder.ApplyConfiguration(new BillnoteConfiguration());
        modelBuilder.ApplyConfiguration(new BranchCycleConfiguration());
        modelBuilder.ApplyConfiguration(new BranchCycleEntryConfiguration());
        modelBuilder.ApplyConfiguration(new BuyConfiguration());
        modelBuilder.ApplyConfiguration(new BuyPhotoConfiguration());
        modelBuilder.ApplyConfiguration(new BuyincomeConfiguration());
        modelBuilder.ApplyConfiguration(new BuytempConfiguration());
        modelBuilder.ApplyConfiguration(new CStageConfiguration());
        modelBuilder.ApplyConfiguration(new CStageEntryConfiguration());
        modelBuilder.ApplyConfiguration(new CTenderConfiguration());
        modelBuilder.ApplyConfiguration(new CTenderAttachConfiguration());
        modelBuilder.ApplyConfiguration(new CTenderDatumConfiguration());
        modelBuilder.ApplyConfiguration(new CTenderStateConfiguration());
        modelBuilder.ApplyConfiguration(new CTenderTypeConfiguration());
        modelBuilder.ApplyConfiguration(new CalendarEventGeneratorConfiguration());
        modelBuilder.ApplyConfiguration(new CashLogConfiguration());
        modelBuilder.ApplyConfiguration(new CashPaidConfiguration());
        modelBuilder.ApplyConfiguration(new CashRecievedConfiguration());
        modelBuilder.ApplyConfiguration(new ChequeInConfiguration());
        modelBuilder.ApplyConfiguration(new ChequeInInfoConfiguration());
        modelBuilder.ApplyConfiguration(new ChequeInbankConfiguration());
        modelBuilder.ApplyConfiguration(new ChequeInbankDoneConfiguration());
        modelBuilder.ApplyConfiguration(new ChequeIncustConfiguration());
        modelBuilder.ApplyConfiguration(new ChequeIncustReturnConfiguration());
        modelBuilder.ApplyConfiguration(new ChequeInreturnConfiguration());
        modelBuilder.ApplyConfiguration(new ChequeOpeningOutConfiguration());
        modelBuilder.ApplyConfiguration(new ChequeOutConfiguration());
        modelBuilder.ApplyConfiguration(new ChequeOutDoneConfiguration());
        modelBuilder.ApplyConfiguration(new ChequeOutInfoConfiguration());
        modelBuilder.ApplyConfiguration(new ChequeOutReturnedConfiguration());
        modelBuilder.ApplyConfiguration(new CloseUserConfiguration());
        modelBuilder.ApplyConfiguration(new ColNameConfiguration());
        modelBuilder.ApplyConfiguration(new CompanyConfiguration());
        modelBuilder.ApplyConfiguration(new CompanyActivityConfiguration());
        modelBuilder.ApplyConfiguration(new CompanyBranchConfiguration());
        modelBuilder.ApplyConfiguration(new CompanyTaxTokenConfiguration());
        modelBuilder.ApplyConfiguration(new ContCashpaidConfiguration());
        modelBuilder.ApplyConfiguration(new ContCashrecieveConfiguration());
        modelBuilder.ApplyConfiguration(new ContSpentConfiguration());
        modelBuilder.ApplyConfiguration(new ContractConfiguration());
        modelBuilder.ApplyConfiguration(new ContractSubConfiguration());
        modelBuilder.ApplyConfiguration(new ContractSubitemConfiguration());
        modelBuilder.ApplyConfiguration(new ContractitemConfiguration());
        modelBuilder.ApplyConfiguration(new CostCenterConfiguration());
        modelBuilder.ApplyConfiguration(new CostCenterEntryConfiguration());
        modelBuilder.ApplyConfiguration(new CostCenterEstimateConfiguration());
        modelBuilder.ApplyConfiguration(new CostCenterGroupConfiguration());
        modelBuilder.ApplyConfiguration(new CostCenterItemConfiguration());
        modelBuilder.ApplyConfiguration(new CpuConfiguration());
        modelBuilder.ApplyConfiguration(new CrmPotCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new CrmPotPriorityConfiguration());
        modelBuilder.ApplyConfiguration(new CrmPotStatisticConfiguration());
        modelBuilder.ApplyConfiguration(new CrmPreVisitConfiguration());
        modelBuilder.ApplyConfiguration(new CurrencyConfiguration());
        modelBuilder.ApplyConfiguration(new CurrencyDiffConfiguration());
        modelBuilder.ApplyConfiguration(new CurrencyDiffEntryConfiguration());
        modelBuilder.ApplyConfiguration(new CurrencyPurchaseConfiguration());
        modelBuilder.ApplyConfiguration(new CurrencyRateConfiguration());
        modelBuilder.ApplyConfiguration(new CurrencySaleConfiguration());
        modelBuilder.ApplyConfiguration(new CurrencyTableConfiguration());
        modelBuilder.ApplyConfiguration(new CurrentPcConfiguration());
        modelBuilder.ApplyConfiguration(new CustConfiguration());
        modelBuilder.ApplyConfiguration(new CustAddressConfiguration());
        modelBuilder.ApplyConfiguration(new CustBouneConfiguration());
        modelBuilder.ApplyConfiguration(new CustCallConfiguration());
        modelBuilder.ApplyConfiguration(new CustContractConfiguration());
        modelBuilder.ApplyConfiguration(new CustContractEntryConfiguration());
        modelBuilder.ApplyConfiguration(new CustContractLogConfiguration());
        modelBuilder.ApplyConfiguration(new CustConvertConfiguration());
        modelBuilder.ApplyConfiguration(new CustDailyBalanceConfiguration());
        modelBuilder.ApplyConfiguration(new CustDealingConfiguration());
        modelBuilder.ApplyConfiguration(new CustDefaultConfiguration());
        modelBuilder.ApplyConfiguration(new CustDiscountConfiguration());
        modelBuilder.ApplyConfiguration(new CustDonationConfiguration());
        modelBuilder.ApplyConfiguration(new CustFieldConfiguration());
        modelBuilder.ApplyConfiguration(new CustImageConfiguration());
        modelBuilder.ApplyConfiguration(new CustInfoConfiguration());
        modelBuilder.ApplyConfiguration(new CustInstallmentConfiguration());
        modelBuilder.ApplyConfiguration(new CustInstallmentSliceConfiguration());
        modelBuilder.ApplyConfiguration(new CustNetConfiguration());
        modelBuilder.ApplyConfiguration(new CustNoteConfiguration());
        modelBuilder.ApplyConfiguration(new CustOpeningConfiguration());
        modelBuilder.ApplyConfiguration(new CustOpeningEntryConfiguration());
        modelBuilder.ApplyConfiguration(new CustOverviewConfiguration());
        modelBuilder.ApplyConfiguration(new CustPatientConfiguration());
        modelBuilder.ApplyConfiguration(new CustRatingConfiguration());
        modelBuilder.ApplyConfiguration(new CustRatingNameConfiguration());
        modelBuilder.ApplyConfiguration(new CustRatingSystemConfiguration());
        modelBuilder.ApplyConfiguration(new CustTypeConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerDropDownConfiguration());
        modelBuilder.ApplyConfiguration(new CycleConfiguration());
        modelBuilder.ApplyConfiguration(new CyclePermissionConfiguration());
        modelBuilder.ApplyConfiguration(new DailyAssetExpenseConfiguration());
        modelBuilder.ApplyConfiguration(new DailyBankConfiguration());
        modelBuilder.ApplyConfiguration(new DailyBatchNumberConfiguration());
        modelBuilder.ApplyConfiguration(new DailyCashPaidConfiguration());
        modelBuilder.ApplyConfiguration(new DailyCashRecievedConfiguration());
        modelBuilder.ApplyConfiguration(new DailyChargeConfiguration());
        modelBuilder.ApplyConfiguration(new DailyCheckRecievedConfiguration());
        modelBuilder.ApplyConfiguration(new DailyCheckpaidConfiguration());
        modelBuilder.ApplyConfiguration(new DailyChequeInConfiguration());
        modelBuilder.ApplyConfiguration(new DailyChequeOutConfiguration());
        modelBuilder.ApplyConfiguration(new DailyCostCenterConfiguration());
        modelBuilder.ApplyConfiguration(new DailyCustAgingConfiguration());
        modelBuilder.ApplyConfiguration(new DailyCustAgingEntryConfiguration());
        modelBuilder.ApplyConfiguration(new DailyCustServiceConfiguration());
        modelBuilder.ApplyConfiguration(new DailyDateConfiguration());
        modelBuilder.ApplyConfiguration(new DailyEserviceConfiguration());
        modelBuilder.ApplyConfiguration(new DailyFixedAssetConfiguration());
        modelBuilder.ApplyConfiguration(new DailyInsuranceConfiguration());
        modelBuilder.ApplyConfiguration(new DailyInvoiceExpenseConfiguration());
        modelBuilder.ApplyConfiguration(new DailyItemCostConfiguration());
        modelBuilder.ApplyConfiguration(new DailyItemDiscountConfiguration());
        modelBuilder.ApplyConfiguration(new DailyItemExtraConfiguration());
        modelBuilder.ApplyConfiguration(new DailyKindConfiguration());
        modelBuilder.ApplyConfiguration(new DailyMaintenanceConfiguration());
        modelBuilder.ApplyConfiguration(new DailyPledgeConfiguration());
        modelBuilder.ApplyConfiguration(new DailyPointConfiguration());
        modelBuilder.ApplyConfiguration(new DailyPotenialConfiguration());
        modelBuilder.ApplyConfiguration(new DailyQuotumConfiguration());
        modelBuilder.ApplyConfiguration(new DailyRentConfiguration());
        modelBuilder.ApplyConfiguration(new DailySalaryConfiguration());
        modelBuilder.ApplyConfiguration(new DailySerialConfiguration());
        modelBuilder.ApplyConfiguration(new DailySmConfiguration());
        modelBuilder.ApplyConfiguration(new DailyStorageConfiguration());
        modelBuilder.ApplyConfiguration(new DailyTaxConfiguration());
        modelBuilder.ApplyConfiguration(new DailyVisaConfiguration());
        modelBuilder.ApplyConfiguration(new DailyWorkPledgeConfiguration());
        modelBuilder.ApplyConfiguration(new DailyassetConfiguration());
        modelBuilder.ApplyConfiguration(new DailycontractConfiguration());
        modelBuilder.ApplyConfiguration(new DailycurrencyConfiguration());
        modelBuilder.ApplyConfiguration(new DailycustConfiguration());
        modelBuilder.ApplyConfiguration(new DailydatConfiguration());
        modelBuilder.ApplyConfiguration(new DailygaConfiguration());
        modelBuilder.ApplyConfiguration(new DailyopConfiguration());
        modelBuilder.ApplyConfiguration(new DailyuserConfiguration());
        modelBuilder.ApplyConfiguration(new DailyworkConfiguration());
        modelBuilder.ApplyConfiguration(new DailyworkHiConfiguration());
        modelBuilder.ApplyConfiguration(new DailyworkpercentConfiguration());
        modelBuilder.ApplyConfiguration(new DailyworkpercentTempConfiguration());
        modelBuilder.ApplyConfiguration(new DbdatumConfiguration());
        modelBuilder.ApplyConfiguration(new DbversionConfiguration());
        modelBuilder.ApplyConfiguration(new DealingConfiguration());
        modelBuilder.ApplyConfiguration(new DealingTableNameConfiguration());
        modelBuilder.ApplyConfiguration(new DefaultFilterPeriodConfiguration());
        modelBuilder.ApplyConfiguration(new DeliveryManConfiguration());
        modelBuilder.ApplyConfiguration(new DiscountAccelerateConfiguration());
        modelBuilder.ApplyConfiguration(new DiscountCashConfiguration());
        modelBuilder.ApplyConfiguration(new DiscountCouponConfiguration());
        modelBuilder.ApplyConfiguration(new DiscountCouponLogConfiguration());
        modelBuilder.ApplyConfiguration(new DiscountGroupConfiguration());
        modelBuilder.ApplyConfiguration(new DiscountItemConfiguration());
        modelBuilder.ApplyConfiguration(new DiscountItemItemConfiguration());
        modelBuilder.ApplyConfiguration(new DiscountQtyConfiguration());
        modelBuilder.ApplyConfiguration(new DiscountQtyItemConfiguration());
        modelBuilder.ApplyConfiguration(new DiscountQtySliceConfiguration());
        modelBuilder.ApplyConfiguration(new DiscountShippingConfiguration());
        modelBuilder.ApplyConfiguration(new DiscountTradeConfiguration());
        modelBuilder.ApplyConfiguration(new DiscountTradePermissionConfiguration());
        modelBuilder.ApplyConfiguration(new DropDownItemStoreConfiguration());
        modelBuilder.ApplyConfiguration(new EditHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new EgyptTaxMainConfiguration());
        modelBuilder.ApplyConfiguration(new EinvoiceMappingConfiguration());
        modelBuilder.ApplyConfiguration(new EmpDailyPayrollConfiguration());
        modelBuilder.ApplyConfiguration(new EmplContractTemplateConfiguration());
        modelBuilder.ApplyConfiguration(new EmplHiringConfiguration());
        modelBuilder.ApplyConfiguration(new EmplLoanConfiguration());
        modelBuilder.ApplyConfiguration(new EmplLoanEntryConfiguration());
        modelBuilder.ApplyConfiguration(new EmplSalariesSliceConfiguration());
        modelBuilder.ApplyConfiguration(new EmplSalariesSliceEntryConfiguration());
        modelBuilder.ApplyConfiguration(new EmplSalaryCalcConfiguration());
        modelBuilder.ApplyConfiguration(new EmplSalaryCalcEntryConfiguration());
        modelBuilder.ApplyConfiguration(new EmplSalaryCalcEntryAccountConfiguration());
        modelBuilder.ApplyConfiguration(new EmplSalaryPayConfiguration());
        modelBuilder.ApplyConfiguration(new EmplSalaryPayEntryConfiguration());
        modelBuilder.ApplyConfiguration(new EmplSalaryPeriodConfiguration());
        modelBuilder.ApplyConfiguration(new EmplSkillConfiguration());
        modelBuilder.ApplyConfiguration(new EmplTransactionConfiguration());
        modelBuilder.ApplyConfiguration(new EmplTransactionEntryConfiguration());
        modelBuilder.ApplyConfiguration(new EmplWorkShiftConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        modelBuilder.ApplyConfiguration(new EstimateConfiguration());
        modelBuilder.ApplyConfiguration(new EstimateDailyConfiguration());
        modelBuilder.ApplyConfiguration(new EstimateDealingConfiguration());
        modelBuilder.ApplyConfiguration(new EstimateDistributeConfiguration());
        modelBuilder.ApplyConfiguration(new EstimateEntryConfiguration());
        modelBuilder.ApplyConfiguration(new EstimateItemConfiguration());
        modelBuilder.ApplyConfiguration(new EstimateShipConfiguration());
        modelBuilder.ApplyConfiguration(new EstimateShipEntryConfiguration());
        modelBuilder.ApplyConfiguration(new EstimateShipItemConfiguration());
        modelBuilder.ApplyConfiguration(new EstimateShippingCompanyConfiguration());
        modelBuilder.ApplyConfiguration(new EstimateSpentItemConfiguration());
        modelBuilder.ApplyConfiguration(new EstimateTypeConfiguration());
        modelBuilder.ApplyConfiguration(new EticketConfiguration());
        modelBuilder.ApplyConfiguration(new EticketCustomerConfiguration());
        modelBuilder.ApplyConfiguration(new EticketDemandingConfiguration());
        modelBuilder.ApplyConfiguration(new EticketTempConfiguration());
        modelBuilder.ApplyConfiguration(new EticketUserConfiguration());
        modelBuilder.ApplyConfiguration(new ExpenseConfiguration());
        modelBuilder.ApplyConfiguration(new ExpensesBranchConfiguration());
        modelBuilder.ApplyConfiguration(new ExpensesClassConfiguration());
        modelBuilder.ApplyConfiguration(new ExpensesEntryConfiguration());
        modelBuilder.ApplyConfiguration(new ExpensesEntryItemConfiguration());
        modelBuilder.ApplyConfiguration(new ExpensesItemConfiguration());
        modelBuilder.ApplyConfiguration(new ExpensesItemsEntryConfiguration());
        modelBuilder.ApplyConfiguration(new ExportstockConfiguration());
        modelBuilder.ApplyConfiguration(new ExtraItemConfiguration());
        modelBuilder.ApplyConfiguration(new ExtraItemEntryConfiguration());
        modelBuilder.ApplyConfiguration(new FactoreComeConfiguration());
        modelBuilder.ApplyConfiguration(new FactoreGoConfiguration());
        modelBuilder.ApplyConfiguration(new FactoreInConfiguration());
        modelBuilder.ApplyConfiguration(new FactoreInEntryConfiguration());
        modelBuilder.ApplyConfiguration(new FactoreItemPriceConfiguration());
        modelBuilder.ApplyConfiguration(new FactoreMachineConfiguration());
        modelBuilder.ApplyConfiguration(new FactoreOutConfiguration());
        modelBuilder.ApplyConfiguration(new FactoreOutEntryConfiguration());
        modelBuilder.ApplyConfiguration(new FactoreStageConfiguration());
        modelBuilder.ApplyConfiguration(new FactoreStoreConfiguration());
        modelBuilder.ApplyConfiguration(new FavoriteConfiguration());
        modelBuilder.ApplyConfiguration(new FavoriteformConfiguration());
        modelBuilder.ApplyConfiguration(new FinalDatumConfiguration());
        modelBuilder.ApplyConfiguration(new FinalDayReportConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetAreaConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetAreaFileConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetAreaGroupConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetBranchTransferConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetCategoryFileConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetCategoryGroupConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetDailyDeprecateConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetDailyDeprecateFileConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetDailyDeprecateGroupConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetDeprecationMethodFileConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetDeprecationMethodGroupConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetDepreciationConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetExpenseConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetFileConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetGroupConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetMasterDepreciationConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetPremiumConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetPurchaseConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetPurchaseEntryConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetRecalcConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetRentCollectConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetRentCustConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetRentCustEntryConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetRentMethodConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetRentOptConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetRentOptEntryConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetSaleConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetSaleEntryConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetScrapConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetsCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new FixedAssetsMainConfiguration());
        modelBuilder.ApplyConfiguration(new FoodMealConfiguration());
        modelBuilder.ApplyConfiguration(new FoodlayoutConfiguration());
        modelBuilder.ApplyConfiguration(new FoodtempConfiguration());
        modelBuilder.ApplyConfiguration(new FrmlayoutConfiguration());
        modelBuilder.ApplyConfiguration(new FuelTypeConfiguration());
        modelBuilder.ApplyConfiguration(new GetCashPaidConfiguration());
        modelBuilder.ApplyConfiguration(new GetCashRecievedConfiguration());
        modelBuilder.ApplyConfiguration(new GetExpenseConfiguration());
        modelBuilder.ApplyConfiguration(new GetStorageSendMoneyConfiguration());
        modelBuilder.ApplyConfiguration(new GetStorageTransformConfiguration());
        modelBuilder.ApplyConfiguration(new GlIncomeConfiguration());
        modelBuilder.ApplyConfiguration(new GrouplayoutConfiguration());
        modelBuilder.ApplyConfiguration(new HrAllowanceConfiguration());
        modelBuilder.ApplyConfiguration(new HrAssetConfiguration());
        modelBuilder.ApplyConfiguration(new HrAttendPolicyConfiguration());
        modelBuilder.ApplyConfiguration(new HrAttendPolicyEntryConfiguration());
        modelBuilder.ApplyConfiguration(new HrAttendanceSettingConfiguration());
        modelBuilder.ApplyConfiguration(new HrContractTemplateConfiguration());
        modelBuilder.ApplyConfiguration(new HrContractTypeConfiguration());
        modelBuilder.ApplyConfiguration(new HrCreditCardConfiguration());
        modelBuilder.ApplyConfiguration(new HrDocumentConfiguration());
        modelBuilder.ApplyConfiguration(new HrExcelSettingConfiguration());
        modelBuilder.ApplyConfiguration(new HrExperienceConfiguration());
        modelBuilder.ApplyConfiguration(new HrFingerPrintSettingConfiguration());
        modelBuilder.ApplyConfiguration(new HrIndexConfiguration());
        modelBuilder.ApplyConfiguration(new HrInsuranceSettingConfiguration());
        modelBuilder.ApplyConfiguration(new HrJobInfoConfiguration());
        modelBuilder.ApplyConfiguration(new HrLoanItemConfiguration());
        modelBuilder.ApplyConfiguration(new HrLoanedAssetConfiguration());
        modelBuilder.ApplyConfiguration(new HrPayrollScheduleConfiguration());
        modelBuilder.ApplyConfiguration(new HrProctionPercConfiguration());
        modelBuilder.ApplyConfiguration(new HrProctionPercEntryConfiguration());
        modelBuilder.ApplyConfiguration(new HrSalariesEquationConfiguration());
        modelBuilder.ApplyConfiguration(new HrSalariesGroupConfiguration());
        modelBuilder.ApplyConfiguration(new HrSalaryConfiguration());
        modelBuilder.ApplyConfiguration(new HrSettingConfiguration());
        modelBuilder.ApplyConfiguration(new HrSkillConfiguration());
        modelBuilder.ApplyConfiguration(new HrTaskConfiguration());
        modelBuilder.ApplyConfiguration(new HrTaxSettingConfiguration());
        modelBuilder.ApplyConfiguration(new HrTaxSettingsEntryConfiguration());
        modelBuilder.ApplyConfiguration(new HrTimeOffConfiguration());
        modelBuilder.ApplyConfiguration(new HrTimeOffAgendaEntryConfiguration());
        modelBuilder.ApplyConfiguration(new HrTimeOffAgendumConfiguration());
        modelBuilder.ApplyConfiguration(new HrTimeOffEntryConfiguration());
        modelBuilder.ApplyConfiguration(new HrTimeOffPolicyConfiguration());
        modelBuilder.ApplyConfiguration(new HrTimeOffPolicyEntryConfiguration());
        modelBuilder.ApplyConfiguration(new HrTimeOffTypeConfiguration());
        modelBuilder.ApplyConfiguration(new HrTrainingCourseConfiguration());
        modelBuilder.ApplyConfiguration(new HrVacationTypeConfiguration());
        modelBuilder.ApplyConfiguration(new HrWorkShiftConfiguration());
        modelBuilder.ApplyConfiguration(new HrWorkTimeConfiguration());
        modelBuilder.ApplyConfiguration(new HrWorkTimeEntryConfiguration());
        modelBuilder.ApplyConfiguration(new ImportCostConfiguration());
        modelBuilder.ApplyConfiguration(new ImportorderConfiguration());
        modelBuilder.ApplyConfiguration(new IncomeConfiguration());
        modelBuilder.ApplyConfiguration(new Income1Configuration());
        modelBuilder.ApplyConfiguration(new IncomeItemConfiguration());
        modelBuilder.ApplyConfiguration(new IncomeItemsBranchConfiguration());
        modelBuilder.ApplyConfiguration(new IncomesEntryConfiguration());
        modelBuilder.ApplyConfiguration(new InstallmentConfiguration());
        modelBuilder.ApplyConfiguration(new InstallmentEntryConfiguration());
        modelBuilder.ApplyConfiguration(new InstallmentInvoiceConfiguration());
        modelBuilder.ApplyConfiguration(new InstallmentLogConfiguration());
        modelBuilder.ApplyConfiguration(new InstallmentSettingConfiguration());
        modelBuilder.ApplyConfiguration(new InsurancesCompanyConfiguration());
        modelBuilder.ApplyConfiguration(new InsurancesItemConfiguration());
        modelBuilder.ApplyConfiguration(new InsurancesItemsEntryConfiguration());
        modelBuilder.ApplyConfiguration(new InsurancesPercentConfiguration());
        modelBuilder.ApplyConfiguration(new InvTypeStatusConfiguration());
        modelBuilder.ApplyConfiguration(new InvoiceConfiguration());
        modelBuilder.ApplyConfiguration(new InvoiceDepartmentConfiguration());
        modelBuilder.ApplyConfiguration(new InvoiceDepartmentEntryConfiguration());
        modelBuilder.ApplyConfiguration(new InvoiceExpenseConfiguration());
        modelBuilder.ApplyConfiguration(new InvoiceExpensesLogConfiguration());
        modelBuilder.ApplyConfiguration(new InvoiceInstallmentConfiguration());
        modelBuilder.ApplyConfiguration(new InvoiceMustSaveConfiguration());
        modelBuilder.ApplyConfiguration(new InvoicePrefixConfiguration());
        modelBuilder.ApplyConfiguration(new InvoicePrefixListConfiguration());
        modelBuilder.ApplyConfiguration(new InvoicesSettingConfiguration());
        modelBuilder.ApplyConfiguration(new ItemAdjustmentConfiguration());
        modelBuilder.ApplyConfiguration(new ItemColorConfiguration());
        modelBuilder.ApplyConfiguration(new ItemRepaireDoneConfiguration());
        modelBuilder.ApplyConfiguration(new ItemRepaireMenuConfiguration());
        modelBuilder.ApplyConfiguration(new ItemRepaireTalabConfiguration());
        modelBuilder.ApplyConfiguration(new ItemReviewConfiguration());
        modelBuilder.ApplyConfiguration(new ItemSearchConfiguration());
        modelBuilder.ApplyConfiguration(new ItemSizeConfiguration());
        modelBuilder.ApplyConfiguration(new ItemStyleSearchConfiguration());
        modelBuilder.ApplyConfiguration(new ItemUniteConfiguration());
        modelBuilder.ApplyConfiguration(new ItemsRequestConfiguration());
        modelBuilder.ApplyConfiguration(new ItemsRequestEntryConfiguration());
        modelBuilder.ApplyConfiguration(new ItemsRequestLogConfiguration());
        modelBuilder.ApplyConfiguration(new KindConfiguration());
        modelBuilder.ApplyConfiguration(new KindActiveSubJectConfiguration());
        modelBuilder.ApplyConfiguration(new KindAntiUsageConfiguration());
        modelBuilder.ApplyConfiguration(new KindAssemblyConfiguration());
        modelBuilder.ApplyConfiguration(new KindBouneConfiguration());
        modelBuilder.ApplyConfiguration(new KindBounesEntryConfiguration());
        modelBuilder.ApplyConfiguration(new KindBounesItemConfiguration());
        modelBuilder.ApplyConfiguration(new KindColorConfiguration());
        modelBuilder.ApplyConfiguration(new KindCreatorConfiguration());
        modelBuilder.ApplyConfiguration(new KindDefaultConfiguration());
        modelBuilder.ApplyConfiguration(new KindDescriptionConfiguration());
        modelBuilder.ApplyConfiguration(new KindDrugConfiguration());
        modelBuilder.ApplyConfiguration(new KindEquationConfiguration());
        modelBuilder.ApplyConfiguration(new KindExprConfiguration());
        modelBuilder.ApplyConfiguration(new KindExprEditConfiguration());
        modelBuilder.ApplyConfiguration(new KindFreeConfiguration());
        modelBuilder.ApplyConfiguration(new KindGenericConfiguration());
        modelBuilder.ApplyConfiguration(new KindGpcConfiguration());
        modelBuilder.ApplyConfiguration(new KindGroupDefaultConfiguration());
        modelBuilder.ApplyConfiguration(new KindGroupEquationConfiguration());
        modelBuilder.ApplyConfiguration(new KindImageConfiguration());
        modelBuilder.ApplyConfiguration(new KindLocalConfiguration());
        modelBuilder.ApplyConfiguration(new KindNoteConfiguration());
        modelBuilder.ApplyConfiguration(new KindOptConfiguration());
        modelBuilder.ApplyConfiguration(new KindOrderConfiguration());
        modelBuilder.ApplyConfiguration(new KindPickConfiguration());
        modelBuilder.ApplyConfiguration(new KindPriceEquationConfiguration());
        modelBuilder.ApplyConfiguration(new KindQoutaEntryConfiguration());
        modelBuilder.ApplyConfiguration(new KindQoutumConfiguration());
        modelBuilder.ApplyConfiguration(new KindScientificConfiguration());
        modelBuilder.ApplyConfiguration(new KindSizeConfiguration());
        modelBuilder.ApplyConfiguration(new KindStockConfiguration());
        modelBuilder.ApplyConfiguration(new KindStorageConditionConfiguration());
        modelBuilder.ApplyConfiguration(new KindStyleColorConfiguration());
        modelBuilder.ApplyConfiguration(new KindStyleSizeConfiguration());
        modelBuilder.ApplyConfiguration(new KindTagConfiguration());
        modelBuilder.ApplyConfiguration(new KindUniteConfiguration());
        modelBuilder.ApplyConfiguration(new KindUsageConfiguration());
        modelBuilder.ApplyConfiguration(new KindUseWayConfiguration());
        modelBuilder.ApplyConfiguration(new LangConfiguration());
        modelBuilder.ApplyConfiguration(new LanguageConfiguration());
        modelBuilder.ApplyConfiguration(new LayoutConfiguration());
        modelBuilder.ApplyConfiguration(new LogHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new MailSettngConfiguration());
        modelBuilder.ApplyConfiguration(new MailTemplateConfiguration());
        modelBuilder.ApplyConfiguration(new MaindailyConfiguration());
        modelBuilder.ApplyConfiguration(new MaintenanceConfiguration());
        modelBuilder.ApplyConfiguration(new MaintenanceAccessoriesEntryConfiguration());
        modelBuilder.ApplyConfiguration(new MaintenanceAccessoryConfiguration());
        modelBuilder.ApplyConfiguration(new MaintenanceCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new MaintenanceDamageConfiguration());
        modelBuilder.ApplyConfiguration(new MaintenanceDeliveryConfiguration());
        modelBuilder.ApplyConfiguration(new MaintenanceEntryConfiguration());
        modelBuilder.ApplyConfiguration(new MaintenanceExtraConfiguration());
        modelBuilder.ApplyConfiguration(new MaintenanceItemConfiguration());
        modelBuilder.ApplyConfiguration(new MaintenanceItemsEntryConfiguration());
        modelBuilder.ApplyConfiguration(new MaintenanceTaskConfiguration());
        modelBuilder.ApplyConfiguration(new MenuConfiguration());
        modelBuilder.ApplyConfiguration(new MenuHideFromConfiguration());
        modelBuilder.ApplyConfiguration(new MenuHideReportConfiguration());
        modelBuilder.ApplyConfiguration(new MenuTileHomeConfiguration());
        modelBuilder.ApplyConfiguration(new MostvisitedConfiguration());
        modelBuilder.ApplyConfiguration(new MotalabaConfiguration());
        modelBuilder.ApplyConfiguration(new MyTableConfiguration());
        modelBuilder.ApplyConfiguration(new NethistoryConfiguration());
        modelBuilder.ApplyConfiguration(new NoteQuickConfiguration());
        modelBuilder.ApplyConfiguration(new OnlineUserConfiguration());
        modelBuilder.ApplyConfiguration(new OpOrderConfiguration());
        modelBuilder.ApplyConfiguration(new OrderSaleQtyConfiguration());
        modelBuilder.ApplyConfiguration(new OwnerConfiguration());
        modelBuilder.ApplyConfiguration(new PaidBillConfiguration());
        modelBuilder.ApplyConfiguration(new PartnerConfiguration());
        modelBuilder.ApplyConfiguration(new PartnerGroupConfiguration());
        modelBuilder.ApplyConfiguration(new PatientConfiguration());
        modelBuilder.ApplyConfiguration(new PaymentLogConfiguration());
        modelBuilder.ApplyConfiguration(new PaymentTermConfiguration());
        modelBuilder.ApplyConfiguration(new PhoneindexConfiguration());
        modelBuilder.ApplyConfiguration(new PledgeConfiguration());
        modelBuilder.ApplyConfiguration(new PluginConfiguration());
        modelBuilder.ApplyConfiguration(new PointCustConfiguration());
        modelBuilder.ApplyConfiguration(new PointCustomerConfiguration());
        modelBuilder.ApplyConfiguration(new PointPatnerPayConfiguration());
        modelBuilder.ApplyConfiguration(new PointPropertyConfiguration());
        modelBuilder.ApplyConfiguration(new PointScenarioConfiguration());
        modelBuilder.ApplyConfiguration(new PointsCardConfiguration());
        modelBuilder.ApplyConfiguration(new PointsCardSettingConfiguration());
        modelBuilder.ApplyConfiguration(new PointsSettingConfiguration());
        modelBuilder.ApplyConfiguration(new PointsSliceConfiguration());
        modelBuilder.ApplyConfiguration(new PosHallConfiguration());
        modelBuilder.ApplyConfiguration(new PosHallEntryConfiguration());
        modelBuilder.ApplyConfiguration(new PosPendingDeliveryConfiguration());
        modelBuilder.ApplyConfiguration(new PosPendingDeliveryEntryConfiguration());
        modelBuilder.ApplyConfiguration(new PosSaleConfiguration());
        modelBuilder.ApplyConfiguration(new PosSaleEntryConfiguration());
        modelBuilder.ApplyConfiguration(new PotCallConfiguration());
        modelBuilder.ApplyConfiguration(new PotDeleteLogConfiguration());
        modelBuilder.ApplyConfiguration(new PotDemoConfiguration());
        modelBuilder.ApplyConfiguration(new PotFeatureConfiguration());
        modelBuilder.ApplyConfiguration(new PotGroupConfiguration());
        modelBuilder.ApplyConfiguration(new PotMailConfiguration());
        modelBuilder.ApplyConfiguration(new PotRateConfiguration());
        modelBuilder.ApplyConfiguration(new PotServiceConfiguration());
        modelBuilder.ApplyConfiguration(new PotVisitConfiguration());
        modelBuilder.ApplyConfiguration(new PotentialCustomerConfiguration());
        modelBuilder.ApplyConfiguration(new PreGridEquationConfiguration());
        modelBuilder.ApplyConfiguration(new PreNameFieldConfiguration());
        modelBuilder.ApplyConfiguration(new PreNameFieldsListConfiguration());
        modelBuilder.ApplyConfiguration(new PreNameUniteConfiguration());
        modelBuilder.ApplyConfiguration(new PreferenceConfiguration());
        modelBuilder.ApplyConfiguration(new PrefrenceConfiguration());
        modelBuilder.ApplyConfiguration(new PrefrenceEntryConfiguration());
        modelBuilder.ApplyConfiguration(new PriceGroupConfiguration());
        modelBuilder.ApplyConfiguration(new PriceNameConfiguration());
        modelBuilder.ApplyConfiguration(new PriceScannerNewsConfiguration());
        modelBuilder.ApplyConfiguration(new PrintCustomertotalConfiguration());
        modelBuilder.ApplyConfiguration(new ProjectConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseConfirmConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseConfirmEntryConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseCycleConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseCycleEntryConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseEntryConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseImportConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseImportEntryConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseItemsCycleConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseOrderConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseOrderEntryConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseOrderItemConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseOrderQtyConfiguration());
        modelBuilder.ApplyConfiguration(new PurchasePaymentConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseQuoteConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseQuoteEntryConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseQuoteItemConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseQuoteRecieveConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseQuoteRecieveEntryConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseQuoteStepConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseServiceConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseServiceEntryConfiguration());
        modelBuilder.ApplyConfiguration(new QuickStartConfiguration());
        modelBuilder.ApplyConfiguration(new RFloorConfiguration());
        modelBuilder.ApplyConfiguration(new RKitchenConfiguration());
        modelBuilder.ApplyConfiguration(new RTableConfiguration());
        modelBuilder.ApplyConfiguration(new RePurchaseConfiguration());
        modelBuilder.ApplyConfiguration(new RePurchaseEntryConfiguration());
        modelBuilder.ApplyConfiguration(new RePurchasePaymentConfiguration());
        modelBuilder.ApplyConfiguration(new ReSaleConfiguration());
        modelBuilder.ApplyConfiguration(new ReSaleEntryConfiguration());
        modelBuilder.ApplyConfiguration(new ReSalePaymentConfiguration());
        modelBuilder.ApplyConfiguration(new RecieveConsignmentConfiguration());
        modelBuilder.ApplyConfiguration(new RecieveConsignmentEntryConfiguration());
        modelBuilder.ApplyConfiguration(new RecieveConsignmentQtyConfiguration());
        modelBuilder.ApplyConfiguration(new RefreshTokenConfiguration());
        modelBuilder.ApplyConfiguration(new RentAssetConfiguration());
        modelBuilder.ApplyConfiguration(new RentFormConfiguration());
        modelBuilder.ApplyConfiguration(new RentInstallmentConfiguration());
        modelBuilder.ApplyConfiguration(new RentOptConfiguration());
        modelBuilder.ApplyConfiguration(new RepManConfiguration());
        modelBuilder.ApplyConfiguration(new RepManEntryConfiguration());
        modelBuilder.ApplyConfiguration(new RepPercConfiguration());
        modelBuilder.ApplyConfiguration(new RepPercEntryConfiguration());
        modelBuilder.ApplyConfiguration(new RepSliceConfiguration());
        modelBuilder.ApplyConfiguration(new RepSliceEntryConfiguration());
        modelBuilder.ApplyConfiguration(new RepVendorPercConfiguration());
        modelBuilder.ApplyConfiguration(new RepVendorPercEntryConfiguration());
        modelBuilder.ApplyConfiguration(new ReportConfiguration());
        modelBuilder.ApplyConfiguration(new ReportCenterConfiguration());
        modelBuilder.ApplyConfiguration(new ReportCenterShortcutConfiguration());
        modelBuilder.ApplyConfiguration(new ReportFileConfiguration());
        modelBuilder.ApplyConfiguration(new ReportTableDatumConfiguration());
        modelBuilder.ApplyConfiguration(new ReportTemplateTableConfiguration());
        modelBuilder.ApplyConfiguration(new ReportsGroupConfiguration());
        modelBuilder.ApplyConfiguration(new ReportsTileConfiguration());
        modelBuilder.ApplyConfiguration(new ResFloorConfiguration());
        modelBuilder.ApplyConfiguration(new ResTableConfiguration());
        modelBuilder.ApplyConfiguration(new ResTableBookingConfiguration());
        modelBuilder.ApplyConfiguration(new ResTableBookingEntryConfiguration());
        modelBuilder.ApplyConfiguration(new ResTableOrderConfiguration());
        modelBuilder.ApplyConfiguration(new ResTableTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ResTransactionLogConfiguration());
        modelBuilder.ApplyConfiguration(new ResourceConfiguration());
        modelBuilder.ApplyConfiguration(new RestoreTransactionConfiguration());
        modelBuilder.ApplyConfiguration(new ReturnConsignmentConfiguration());
        modelBuilder.ApplyConfiguration(new ReturnConsignmentEntryConfiguration());
        modelBuilder.ApplyConfiguration(new RoleConfiguration());
        modelBuilder.ApplyConfiguration(new RpsAccountConfiguration());
        modelBuilder.ApplyConfiguration(new RpsBankConfiguration());
        modelBuilder.ApplyConfiguration(new RpsItemConfiguration());
        modelBuilder.ApplyConfiguration(new RpsItemIndexConfiguration());
        modelBuilder.ApplyConfiguration(new RpsItemIndexEnConfiguration());
        modelBuilder.ApplyConfiguration(new RpsItemIndexFrConfiguration());
        modelBuilder.ApplyConfiguration(new RsdBillMappingConfiguration());
        modelBuilder.ApplyConfiguration(new RsdBillMappingEntryConfiguration());
        modelBuilder.ApplyConfiguration(new RsdSettingConfiguration());
        modelBuilder.ApplyConfiguration(new RsdUserConfiguration());
        modelBuilder.ApplyConfiguration(new RspItemAloneConfiguration());
        modelBuilder.ApplyConfiguration(new RssConfiguration());
        modelBuilder.ApplyConfiguration(new RtlErrorConfiguration());
        modelBuilder.ApplyConfiguration(new RtlTileConfiguration());
        modelBuilder.ApplyConfiguration(new SadadServiceConfiguration());
        modelBuilder.ApplyConfiguration(new SadadServiceEntryConfiguration());
        modelBuilder.ApplyConfiguration(new SalariesCalcConfiguration());
        modelBuilder.ApplyConfiguration(new SalariesCalcAlertConfiguration());
        modelBuilder.ApplyConfiguration(new SalariesCalcEntryConfiguration());
        modelBuilder.ApplyConfiguration(new SalariesCalcPaidSolfaConfiguration());
        modelBuilder.ApplyConfiguration(new SalariesEntryConfiguration());
        modelBuilder.ApplyConfiguration(new SalariesPayConfiguration());
        modelBuilder.ApplyConfiguration(new SalariesPayEntryConfiguration());
        modelBuilder.ApplyConfiguration(new SalariesRepeatMethodConfiguration());
        modelBuilder.ApplyConfiguration(new SalariesSliceConfiguration());
        modelBuilder.ApplyConfiguration(new SalariesWorkConfiguration());
        modelBuilder.ApplyConfiguration(new SalariesWorkUpgradeConfiguration());
        modelBuilder.ApplyConfiguration(new SalaryCalcLogConfiguration());
        modelBuilder.ApplyConfiguration(new SalaryItemDefTypeConfiguration());
        modelBuilder.ApplyConfiguration(new SalaryItemTypeConfiguration());
        modelBuilder.ApplyConfiguration(new SalaryLevelConfiguration());
        modelBuilder.ApplyConfiguration(new SalaryPeriodConfiguration());
        modelBuilder.ApplyConfiguration(new SaleConfiguration());
        modelBuilder.ApplyConfiguration(new SaleConfirmConfiguration());
        modelBuilder.ApplyConfiguration(new SaleConfirmEntryConfiguration());
        modelBuilder.ApplyConfiguration(new SaleEntryConfiguration());
        modelBuilder.ApplyConfiguration(new SaleEstimateConfiguration());
        modelBuilder.ApplyConfiguration(new SaleEstimateEntryConfiguration());
        modelBuilder.ApplyConfiguration(new SaleOrderConfiguration());
        modelBuilder.ApplyConfiguration(new SaleOrderEntryConfiguration());
        modelBuilder.ApplyConfiguration(new SaleOrderItemConfiguration());
        modelBuilder.ApplyConfiguration(new SalePaymentConfiguration());
        modelBuilder.ApplyConfiguration(new SaleQouteConfiguration());
        modelBuilder.ApplyConfiguration(new SaleQouteEntryConfiguration());
        modelBuilder.ApplyConfiguration(new SaleTotalConfiguration());
        modelBuilder.ApplyConfiguration(new SaletempConfiguration());
        modelBuilder.ApplyConfiguration(new SavedocConfiguration());
        modelBuilder.ApplyConfiguration(new SerialConfiguration());
        modelBuilder.ApplyConfiguration(new ShBalance00Configuration());
        modelBuilder.ApplyConfiguration(new ShBoxOpeningConfiguration());
        modelBuilder.ApplyConfiguration(new ShBoxRecieveConfiguration());
        modelBuilder.ApplyConfiguration(new ShBoxSettingConfiguration());
        modelBuilder.ApplyConfiguration(new ShBoxTransferConfiguration());
        modelBuilder.ApplyConfiguration(new ShBranchDailyActionConfiguration());
        modelBuilder.ApplyConfiguration(new ShDailyBoxConfiguration());
        modelBuilder.ApplyConfiguration(new ShDailyMsgConfiguration());
        modelBuilder.ApplyConfiguration(new ShMsgBalanceConfiguration());
        modelBuilder.ApplyConfiguration(new ShMsgOpenConfiguration());
        modelBuilder.ApplyConfiguration(new ShMsgSaleConfiguration());
        modelBuilder.ApplyConfiguration(new ShMsgSaleAlarmConfiguration());
        modelBuilder.ApplyConfiguration(new ShMsgSettingConfiguration());
        modelBuilder.ApplyConfiguration(new ShMsgSpentConfiguration());
        modelBuilder.ApplyConfiguration(new ShPurchaseConfiguration());
        modelBuilder.ApplyConfiguration(new ShRentConfiguration());
        modelBuilder.ApplyConfiguration(new ShSaleConfiguration());
        modelBuilder.ApplyConfiguration(new ShippingCarConfiguration());
        modelBuilder.ApplyConfiguration(new ShippingCarUsageConfiguration());
        modelBuilder.ApplyConfiguration(new ShippingDriverConfiguration());
        modelBuilder.ApplyConfiguration(new ShippingFuelConfiguration());
        modelBuilder.ApplyConfiguration(new ShortCutConfiguration());
        modelBuilder.ApplyConfiguration(new SliceConfiguration());
        modelBuilder.ApplyConfiguration(new SliceDefaultConfiguration());
        modelBuilder.ApplyConfiguration(new SliceKindfactorConfiguration());
        modelBuilder.ApplyConfiguration(new SliceRepresentConfiguration());
        modelBuilder.ApplyConfiguration(new SliceWorkDayConfiguration());
        modelBuilder.ApplyConfiguration(new SmConfiguration());
        modelBuilder.ApplyConfiguration(new SmsSettingConfiguration());
        modelBuilder.ApplyConfiguration(new SmsalertConfiguration());
        modelBuilder.ApplyConfiguration(new SmsalertEntryConfiguration());
        modelBuilder.ApplyConfiguration(new SmscustGroupConfiguration());
        modelBuilder.ApplyConfiguration(new SmscustGroupEntryConfiguration());
        modelBuilder.ApplyConfiguration(new SmserrorConfiguration());
        modelBuilder.ApplyConfiguration(new SmsnotificationConfiguration());
        modelBuilder.ApplyConfiguration(new SmspatrolConfiguration());
        modelBuilder.ApplyConfiguration(new SmssendingConfiguration());
        modelBuilder.ApplyConfiguration(new SmssendingEntryConfiguration());
        modelBuilder.ApplyConfiguration(new SmstemplateConfiguration());
        modelBuilder.ApplyConfiguration(new SmsvariableConfiguration());
        modelBuilder.ApplyConfiguration(new SrvcClassConfiguration());
        modelBuilder.ApplyConfiguration(new SrvcItemConfiguration());
        modelBuilder.ApplyConfiguration(new SrvcRecieveConfiguration());
        modelBuilder.ApplyConfiguration(new SrvcStoreConfiguration());
        modelBuilder.ApplyConfiguration(new StorageConfiguration());
        modelBuilder.ApplyConfiguration(new StorageSendMoneyConfiguration());
        modelBuilder.ApplyConfiguration(new StorageTransformConfiguration());
        modelBuilder.ApplyConfiguration(new StoreAdjustmentConfiguration());
        modelBuilder.ApplyConfiguration(new StoreAdjustmentEntryConfiguration());
        modelBuilder.ApplyConfiguration(new StoreAssemblyConfiguration());
        modelBuilder.ApplyConfiguration(new StoreAssemblyEntryConfiguration());
        modelBuilder.ApplyConfiguration(new StoreCharityConfiguration());
        modelBuilder.ApplyConfiguration(new StoreCharityEntryConfiguration());
        modelBuilder.ApplyConfiguration(new StoreConvertConfiguration());
        modelBuilder.ApplyConfiguration(new StoreConvertEntryConfiguration());
        modelBuilder.ApplyConfiguration(new StoreDisAssemblyConfiguration());
        modelBuilder.ApplyConfiguration(new StoreDisAssemblyEntryConfiguration());
        modelBuilder.ApplyConfiguration(new StoreHalekConfiguration());
        modelBuilder.ApplyConfiguration(new StoreHalekEntryConfiguration());
        modelBuilder.ApplyConfiguration(new StoreInConfiguration());
        modelBuilder.ApplyConfiguration(new StoreInEntryConfiguration());
        modelBuilder.ApplyConfiguration(new StoreInTransferConfiguration());
        modelBuilder.ApplyConfiguration(new StoreInTransferEntryConfiguration());
        modelBuilder.ApplyConfiguration(new StoreIssueConfiguration());
        modelBuilder.ApplyConfiguration(new StoreIssueEntryConfiguration());
        modelBuilder.ApplyConfiguration(new StoreItemIdConfiguration());
        modelBuilder.ApplyConfiguration(new StoreItemIdStyleConfiguration());
        modelBuilder.ApplyConfiguration(new StoreOpeningConfiguration());
        modelBuilder.ApplyConfiguration(new StoreOpeningEntryConfiguration());
        modelBuilder.ApplyConfiguration(new StoreOutConfiguration());
        modelBuilder.ApplyConfiguration(new StoreOutEntryConfiguration());
        modelBuilder.ApplyConfiguration(new StoreOutTransferConfiguration());
        modelBuilder.ApplyConfiguration(new StoreOutTransferEntryConfiguration());
        modelBuilder.ApplyConfiguration(new StorePackingConfiguration());
        modelBuilder.ApplyConfiguration(new StorePackingCancelConfiguration());
        modelBuilder.ApplyConfiguration(new StorePackingCancelEntryConfiguration());
        modelBuilder.ApplyConfiguration(new StorePackingEntryConfiguration());
        modelBuilder.ApplyConfiguration(new StorePackingOrderConfiguration());
        modelBuilder.ApplyConfiguration(new StorePackingOrderEntryConfiguration());
        modelBuilder.ApplyConfiguration(new StoreRecieveConfiguration());
        modelBuilder.ApplyConfiguration(new StoreRecieveEntryConfiguration());
        modelBuilder.ApplyConfiguration(new StoreSendOrderConfiguration());
        modelBuilder.ApplyConfiguration(new StoreSendOrderEntryConfiguration());
        modelBuilder.ApplyConfiguration(new StoreTransactionTypeConfiguration());
        modelBuilder.ApplyConfiguration(new StoreTransferOrderConfiguration());
        modelBuilder.ApplyConfiguration(new StoreTransferOrderEntryConfiguration());
        modelBuilder.ApplyConfiguration(new SupportCommunicationConfiguration());
        modelBuilder.ApplyConfiguration(new SupportExtraFieldConfiguration());
        modelBuilder.ApplyConfiguration(new SupportLevelConfiguration());
        modelBuilder.ApplyConfiguration(new SupportNoteConfiguration());
        modelBuilder.ApplyConfiguration(new SupportPermissionConfiguration());
        modelBuilder.ApplyConfiguration(new SupportPriorityConfiguration());
        modelBuilder.ApplyConfiguration(new SupportProductConfiguration());
        modelBuilder.ApplyConfiguration(new SupportStatusConfiguration());
        modelBuilder.ApplyConfiguration(new SupportTicketConfiguration());
        modelBuilder.ApplyConfiguration(new SupportTypeConfiguration());
        modelBuilder.ApplyConfiguration(new SyncConfiguration());
        modelBuilder.ApplyConfiguration(new TableConfiguration());
        modelBuilder.ApplyConfiguration(new TahselBillConfiguration());
        modelBuilder.ApplyConfiguration(new TahselMotalbaConfiguration());
        modelBuilder.ApplyConfiguration(new TaskHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new TaskIdMappingConfiguration());
        modelBuilder.ApplyConfiguration(new TaskMapAppointmentConfiguration());
        modelBuilder.ApplyConfiguration(new TaskMapDependencyConfiguration());
        modelBuilder.ApplyConfiguration(new TaskMapResourceConfiguration());
        modelBuilder.ApplyConfiguration(new TaxEgyptHomeConfiguration());
        modelBuilder.ApplyConfiguration(new TaxEgyptSettingConfiguration());
        modelBuilder.ApplyConfiguration(new TaxValidationConfiguration());
        modelBuilder.ApplyConfiguration(new TaxValidationResultConfiguration());
        modelBuilder.ApplyConfiguration(new TaxValidationResultErrorConfiguration());
        modelBuilder.ApplyConfiguration(new TaxesAdjustConfiguration());
        modelBuilder.ApplyConfiguration(new TaxesDatConfiguration());
        modelBuilder.ApplyConfiguration(new TaxesGroupConfiguration());
        modelBuilder.ApplyConfiguration(new TaxesPayConfiguration());
        modelBuilder.ApplyConfiguration(new TaxesSubGroupConfiguration());
        modelBuilder.ApplyConfiguration(new TaxesConfiguration());
        modelBuilder.ApplyConfiguration(new TechnicianConfiguration());
        modelBuilder.ApplyConfiguration(new TechniciansEntryConfiguration());
        modelBuilder.ApplyConfiguration(new TeleSalesRevisionConfiguration());
        modelBuilder.ApplyConfiguration(new TempAccountcompaireConfiguration());
        modelBuilder.ApplyConfiguration(new TempConvertConfiguration());
        modelBuilder.ApplyConfiguration(new TempError01Configuration());
        modelBuilder.ApplyConfiguration(new TempFinalDatumConfiguration());
        modelBuilder.ApplyConfiguration(new TempInhanddataAvgConfiguration());
        modelBuilder.ApplyConfiguration(new TempInvoiceTableEntryConfiguration());
        modelBuilder.ApplyConfiguration(new TempProcessdatumConfiguration());
        modelBuilder.ApplyConfiguration(new TempPurchaseConfiguration());
        modelBuilder.ApplyConfiguration(new TempPurchaseAvgConfiguration());
        modelBuilder.ApplyConfiguration(new TempPurchaseIdusedForAvgConfiguration());
        modelBuilder.ApplyConfiguration(new TempSellConfiguration());
        modelBuilder.ApplyConfiguration(new TempSellAvgConfiguration());
        modelBuilder.ApplyConfiguration(new TempitemprofitConfiguration());
        modelBuilder.ApplyConfiguration(new Tempitemprofit1Configuration());
        modelBuilder.ApplyConfiguration(new TipConfiguration());
        modelBuilder.ApplyConfiguration(new TmpStoreTableConfiguration());
        modelBuilder.ApplyConfiguration(new TodayDateConfiguration());
        modelBuilder.ApplyConfiguration(new TransComeConfiguration());
        modelBuilder.ApplyConfiguration(new TransGoConfiguration());
        modelBuilder.ApplyConfiguration(new TransStockConfiguration());
        modelBuilder.ApplyConfiguration(new TranslateConfiguration());
        modelBuilder.ApplyConfiguration(new TripAirLineConfiguration());
        modelBuilder.ApplyConfiguration(new TripAirLineCommissionConfiguration());
        modelBuilder.ApplyConfiguration(new TripAirportConfiguration());
        modelBuilder.ApplyConfiguration(new TripCommissionConfiguration());
        modelBuilder.ApplyConfiguration(new TripCommissionEntryConfiguration());
        modelBuilder.ApplyConfiguration(new TripContractConfiguration());
        modelBuilder.ApplyConfiguration(new TripDateRangeConfiguration());
        modelBuilder.ApplyConfiguration(new TripDemandingConfiguration());
        modelBuilder.ApplyConfiguration(new TripDemanding1Configuration());
        modelBuilder.ApplyConfiguration(new TripDirectionTypeConfiguration());
        modelBuilder.ApplyConfiguration(new TripExcelSettingConfiguration());
        modelBuilder.ApplyConfiguration(new TripGdConfiguration());
        modelBuilder.ApplyConfiguration(new TripHomeConfiguration());
        modelBuilder.ApplyConfiguration(new TripIatumConfiguration());
        modelBuilder.ApplyConfiguration(new TripItineraryTypeConfiguration());
        modelBuilder.ApplyConfiguration(new TripRequireFieldConfiguration());
        modelBuilder.ApplyConfiguration(new TripStatusConfiguration());
        modelBuilder.ApplyConfiguration(new TripTicketConfiguration());
        modelBuilder.ApplyConfiguration(new TripTicketTempConfiguration());
        modelBuilder.ApplyConfiguration(new TripUserConfiguration());
        modelBuilder.ApplyConfiguration(new TtConfiguration());
        modelBuilder.ApplyConfiguration(new UnitConfiguration());
        modelBuilder.ApplyConfiguration(new UniteCodeConfiguration());
        modelBuilder.ApplyConfiguration(new UnitsEntryConfiguration());
        modelBuilder.ApplyConfiguration(new UpdateReSaleTranConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new UserAnyDeskSettingConfiguration());
        modelBuilder.ApplyConfiguration(new UserAttentionConfiguration());
        modelBuilder.ApplyConfiguration(new UserBranchConfiguration());
        modelBuilder.ApplyConfiguration(new UserDefaultAccountConfiguration());
        modelBuilder.ApplyConfiguration(new UserDefaultInvoiceConfiguration());
        modelBuilder.ApplyConfiguration(new UserDepartmentConfiguration());
        modelBuilder.ApplyConfiguration(new UserJobConfiguration());
        modelBuilder.ApplyConfiguration(new UserNotificationConfiguration());
        modelBuilder.ApplyConfiguration(new UserNotificationEntryConfiguration());
        modelBuilder.ApplyConfiguration(new UserOpenDayConfiguration());
        modelBuilder.ApplyConfiguration(new UserOpenDayEntryConfiguration());
        modelBuilder.ApplyConfiguration(new UserOptionConfiguration());
        modelBuilder.ApplyConfiguration(new UserPaymentMethodConfiguration());
        modelBuilder.ApplyConfiguration(new UserPermissionConfiguration());
        modelBuilder.ApplyConfiguration(new UserPropertyConfiguration());
        modelBuilder.ApplyConfiguration(new UserSettingConfiguration());
        modelBuilder.ApplyConfiguration(new UserStoreConfiguration());
        modelBuilder.ApplyConfiguration(new UsersLogConfiguration());
        modelBuilder.ApplyConfiguration(new UsersLogEntryConfiguration());
        modelBuilder.ApplyConfiguration(new UsersPrivilegeConfiguration());
        modelBuilder.ApplyConfiguration(new UsersPrivilegesEntryConfiguration());
        modelBuilder.ApplyConfiguration(new UsersResourceConfiguration());
        modelBuilder.ApplyConfiguration(new VisaConfiguration());
        modelBuilder.ApplyConfiguration(new WJobConfiguration());
        modelBuilder.ApplyConfiguration(new WTempattendanceConfiguration());
        modelBuilder.ApplyConfiguration(new WooCategoryMapperConfiguration());
        modelBuilder.ApplyConfiguration(new WooCustomerMapperConfiguration());
        modelBuilder.ApplyConfiguration(new WooKindMapperConfiguration());
        modelBuilder.ApplyConfiguration(new WooOrderConfiguration());
        modelBuilder.ApplyConfiguration(new WooOrderBillingConfiguration());
        modelBuilder.ApplyConfiguration(new WooOrderCouponLineConfiguration());
        modelBuilder.ApplyConfiguration(new WooOrderCouponLineMetumConfiguration());
        modelBuilder.ApplyConfiguration(new WooOrderFeeLineConfiguration());
        modelBuilder.ApplyConfiguration(new WooOrderLineItemConfiguration());
        modelBuilder.ApplyConfiguration(new WooOrderMapperConfiguration());
        modelBuilder.ApplyConfiguration(new WooOrderMetumConfiguration());
        modelBuilder.ApplyConfiguration(new WooOrderRefundLineConfiguration());
        modelBuilder.ApplyConfiguration(new WooOrderShippingConfiguration());
        modelBuilder.ApplyConfiguration(new WooOrderShippingLineConfiguration());
        modelBuilder.ApplyConfiguration(new WooOrderTaxLineConfiguration());
        modelBuilder.ApplyConfiguration(new WooSettingConfiguration());
        modelBuilder.ApplyConfiguration(new WooTaxItemConfiguration());
        modelBuilder.ApplyConfiguration(new WorkConfiguration());
        modelBuilder.ApplyConfiguration(new WorkAbsentConfiguration());
        modelBuilder.ApplyConfiguration(new WorkAbsentBalanceConfiguration());
        modelBuilder.ApplyConfiguration(new WorkAbsentCauseConfiguration());
        modelBuilder.ApplyConfiguration(new WorkAlarmConfiguration());
        modelBuilder.ApplyConfiguration(new WorkAttendConfiguration());
        modelBuilder.ApplyConfiguration(new WorkAttendanceConfiguration());
        modelBuilder.ApplyConfiguration(new WorkAttendanceInOutConfiguration());
        modelBuilder.ApplyConfiguration(new WorkBonuConfiguration());
        modelBuilder.ApplyConfiguration(new WorkDealingConfiguration());
        modelBuilder.ApplyConfiguration(new WorkDiscountConfiguration());
        modelBuilder.ApplyConfiguration(new WorkDiscountItemConfiguration());
        modelBuilder.ApplyConfiguration(new WorkEservicePayConfiguration());
        modelBuilder.ApplyConfiguration(new WorkEserviceReceiveConfiguration());
        modelBuilder.ApplyConfiguration(new WorkEvaluationConfiguration());
        modelBuilder.ApplyConfiguration(new WorkEvaluationItemConfiguration());
        modelBuilder.ApplyConfiguration(new WorkEvaluationRateConfiguration());
        modelBuilder.ApplyConfiguration(new WorkExtraItemConfiguration());
        modelBuilder.ApplyConfiguration(new WorkExtradayConfiguration());
        modelBuilder.ApplyConfiguration(new WorkExtrahourConfiguration());
        modelBuilder.ApplyConfiguration(new WorkFactoreConfiguration());
        modelBuilder.ApplyConfiguration(new WorkFactoreEntryConfiguration());
        modelBuilder.ApplyConfiguration(new WorkFileConfiguration());
        modelBuilder.ApplyConfiguration(new WorkFingerLogConfiguration());
        modelBuilder.ApplyConfiguration(new WorkGroupConfiguration());
        modelBuilder.ApplyConfiguration(new WorkIncentiveConfiguration());
        modelBuilder.ApplyConfiguration(new WorkIncentiveItemConfiguration());
        modelBuilder.ApplyConfiguration(new WorkInoutTempConfiguration());
        modelBuilder.ApplyConfiguration(new WorkInstallmentConfiguration());
        modelBuilder.ApplyConfiguration(new WorkInstallmentsEntryConfiguration());
        modelBuilder.ApplyConfiguration(new WorkInstallmentsItemEntryConfiguration());
        modelBuilder.ApplyConfiguration(new WorkInsuranceConfiguration());
        modelBuilder.ApplyConfiguration(new WorkInsuranceEntryConfiguration());
        modelBuilder.ApplyConfiguration(new WorkItineraryConfiguration());
        modelBuilder.ApplyConfiguration(new WorkItineraryEntryConfiguration());
        modelBuilder.ApplyConfiguration(new WorkLeaveConfiguration());
        modelBuilder.ApplyConfiguration(new WorkMonthlyConfiguration());
        modelBuilder.ApplyConfiguration(new WorkMoveConfiguration());
        modelBuilder.ApplyConfiguration(new WorkPaidSalaryConfiguration());
        modelBuilder.ApplyConfiguration(new WorkPayInsuranceConfiguration());
        modelBuilder.ApplyConfiguration(new WorkPayRollItemConfiguration());
        modelBuilder.ApplyConfiguration(new WorkPayTaxConfiguration());
        modelBuilder.ApplyConfiguration(new WorkPercentConfiguration());
        modelBuilder.ApplyConfiguration(new WorkPeriodConfiguration());
        modelBuilder.ApplyConfiguration(new WorkPeriodChangeConfiguration());
        modelBuilder.ApplyConfiguration(new WorkPeriodEntryConfiguration());
        modelBuilder.ApplyConfiguration(new WorkPermissionConfiguration());
        modelBuilder.ApplyConfiguration(new WorkPinkConfiguration());
        modelBuilder.ApplyConfiguration(new WorkPledgeConfiguration());
        modelBuilder.ApplyConfiguration(new WorkPledgeAdjustConfiguration());
        modelBuilder.ApplyConfiguration(new WorkPledgePayConfiguration());
        modelBuilder.ApplyConfiguration(new WorkPledgeReceiveConfiguration());
        modelBuilder.ApplyConfiguration(new WorkPledgeTypeConfiguration());
        modelBuilder.ApplyConfiguration(new WorkRefusalConfiguration());
        modelBuilder.ApplyConfiguration(new WorkSalaryPercConfiguration());
        modelBuilder.ApplyConfiguration(new WorkSalaryStopConfiguration());
        modelBuilder.ApplyConfiguration(new WorkSolfaConfiguration());
        modelBuilder.ApplyConfiguration(new WorkSolfarecieveConfiguration());
        modelBuilder.ApplyConfiguration(new WorkTaskConfiguration());
        modelBuilder.ApplyConfiguration(new WorkTaskDailyConfiguration());
        modelBuilder.ApplyConfiguration(new WorkTimeSheetConfiguration());
        modelBuilder.ApplyConfiguration(new WorkTraingItemConfiguration());
        modelBuilder.ApplyConfiguration(new WorkTransactionConfiguration());
        modelBuilder.ApplyConfiguration(new WorkTransactionEntryConfiguration());
        modelBuilder.ApplyConfiguration(new WorkUpgradeConfiguration());
        modelBuilder.ApplyConfiguration(new WorkUpgradeHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new WorkUsedEserviceConfiguration());
        modelBuilder.ApplyConfiguration(new WorkVacationConfiguration());
        modelBuilder.ApplyConfiguration(new WorkVacationOrderConfiguration());
        modelBuilder.ApplyConfiguration(new WorkVocConfiguration());
        modelBuilder.ApplyConfiguration(new WorkWorkDayConfiguration());
        modelBuilder.ApplyConfiguration(new WorksPhotoConfiguration());
        modelBuilder.ApplyConfiguration(new YearFinancialConfiguration());
        modelBuilder.ApplyConfiguration(new YearFinancialMasterConfiguration());
        modelBuilder.ApplyConfiguration(new YearFinancialRoleConfiguration());

        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DxdbContext).Assembly);
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
        string connString = string.Format("Server={0};Database={1};User Id={2};Password={3};MultipleActiveResultSets=true;Integrated Security = false;TrustServerCertificate=True;", ip, dbName, userName, password);

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
}
