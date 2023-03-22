namespace DataAccess.Domain.Models;

public class BillClass
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public bool? OptBillType { get; set; }
    public bool? OptBillAutoNum { get; set; }
    public bool? OptBillTax { get; set; }
    public int? TaxId { get; set; }
    public bool? OptBillSummary { get; set; }
    public bool? OptBillCurrency { get; set; }
    public bool? OptBillShowCustInfo { get; set; }
    public bool? OptBillRep { get; set; }
    public bool? OptBillExtraFields { get; set; }
    public bool? OptBillCostCenter { get; set; }
    public bool? OptBillExtraCost { get; set; }
    public bool? OptBillDiscountAcc { get; set; }
    public bool? OptBillDiscountCash { get; set; }
    public bool? OptDueDt { get; set; }
    public bool? OptBillCust { get; set; }
    public bool? OptBillItem { get; set; }
    public string? Prefix { get; set; }
    public bool? Isdefault { get; set; }
    public bool? OptCostId { get; set; }
    public int? CostId { get; set; }
    public bool? DiscountBeforeTax { get; set; }
    public Guid Rowguid { get; set; }
    public int? OptPayIndex { get; set; }
    public int? InstallmentId { get; set; }
    public bool? UseDat { get; set; }
    public int? DatId { get; set; }
}
