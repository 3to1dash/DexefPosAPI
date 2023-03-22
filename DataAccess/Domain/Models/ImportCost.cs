namespace DataAccess.Domain.Models;

public class ImportCost
{
    public decimal Id { get; set; }
    public string? FileNo { get; set; }
    public DateTime? Date { get; set; }
    public string? Description { get; set; }
    public string? Importer { get; set; }
    public string? Address { get; set; }
    public decimal? Quantity { get; set; }
    public string? QuantityUnit { get; set; }
    public string? MainCurrency { get; set; }
    public decimal? QuantityCost { get; set; }
    public decimal? UnitCost { get; set; }
    public decimal? Fobvalue { get; set; }
    public string? Fobcurrency { get; set; }
    public decimal? Fobrate { get; set; }
    public decimal? TransportValue { get; set; }
    public string? TransportCurrency { get; set; }
    public decimal? TransportRate { get; set; }
    public decimal? InsuranceValue { get; set; }
    public string? InsuranceCurrency { get; set; }
    public decimal? InsuranceRate { get; set; }
    public decimal? PortFeeValue { get; set; }
    public string? PortFeeCurrency { get; set; }
    public decimal? PortFeeRate { get; set; }
    public decimal? CustomsPerUnit { get; set; }
    public string? CustomsCurrency { get; set; }
    public decimal? CustomsPercent { get; set; }
    public decimal? PurchaseDutyPerUnit { get; set; }
    public string? PurchaseDutyCurrency { get; set; }
    public decimal? PurchaseDutyRate { get; set; }
    public decimal? PurchaseDutyPercent { get; set; }
    public decimal? JaleelPercent { get; set; }
    public string? OtherDutyName { get; set; }
    public decimal? OtherDutyValue { get; set; }
    public string? OtherDutyCurrency { get; set; }
    public decimal? DutyManAmount { get; set; }
    public string? DutyManCurrency { get; set; }
    public decimal? DutyManRate { get; set; }
    public decimal? DutyManPercent { get; set; }
    public decimal? DutyFeeAmount { get; set; }
    public string? DutyFeeCurrency { get; set; }
    public decimal? DutyFeeRate { get; set; }
    public decimal? Vatrate1 { get; set; }
    public decimal? Vatrate2 { get; set; }
    public decimal? OtherPortFeeAmount { get; set; }
    public string? OtherPortFeeCurrency { get; set; }
    public decimal? OtherPortFeeRate { get; set; }
    public decimal? HealthAmount { get; set; }
    public string? HealthCurrency { get; set; }
    public decimal? HealthRate { get; set; }
    public decimal? BankFeeOn { get; set; }
    public decimal? BankFeePercentage { get; set; }
    public decimal? OtherBankFeeAmount { get; set; }
    public string? OtherBankFeeCurrency { get; set; }
    public decimal? OtherBankFeeRate { get; set; }
    public decimal? LocalCarryFeeAmount { get; set; }
    public string? LocalCarryFeeCurrency { get; set; }
    public decimal? LocalCarryFeeRate { get; set; }
    public decimal? TelFaxCostAmount { get; set; }
    public string? TelFaxCostCurrency { get; set; }
    public decimal? TelFaxCostRate { get; set; }
    public decimal? OtherCostAmount { get; set; }
    public string? OtherCostCurrency { get; set; }
    public decimal? OtherCostRate { get; set; }
    public Guid Rowguid { get; set; }
}
