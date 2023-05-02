namespace DataAccess.Domain.Models;

public class InstallmentSetting
{
    public int Id { get; set; }
    public bool? UseMultipleInstall { get; set; }
    public int? MaxCount { get; set; }
    public bool? MustUseIncome { get; set; }
    public decimal? IncomePerc { get; set; }
    public decimal? MinInvoicePerc { get; set; }
    public int? UntrustedInstallCount { get; set; }
    public bool? SendSms { get; set; }
    public int? Smsprovidor { get; set; }
    public string? Sms { get; set; }
    public int? CalcWay { get; set; }
    public Guid Rowguid { get; set; }
}