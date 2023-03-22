namespace DataAccess.Domain.Models;

public class YearFinancial
{
    public int Id { get; set; }
    public int? PeriodState { get; set; }
    public string? Caption { get; set; }
    public DateTime? FromDt { get; set; }
    public DateTime? ToDt { get; set; }
    public DateTime? UpdateDt { get; set; }
    public DateTime? ArchieveDt { get; set; }
    public bool? AutoClose { get; set; }
    public Guid Rowguid { get; set; }
    public int? MasterId { get; set; }
    public int? SalesDays { get; set; }
    public int? PurchaseDays { get; set; }
    public bool? SpecialInvoiceCondition { get; set; }
    public bool? CanEditAfterClose { get; set; }

    public virtual YearFinancialMaster? Master { get; set; }
    public virtual List<YearFinancialRole> YearFinancialRoles { get; set; }
}
