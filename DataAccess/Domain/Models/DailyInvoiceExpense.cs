namespace DataAccess.Domain.Models;

public class DailyInvoiceExpense
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public string? BillNum { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dealing { get; set; }
    public int? ExpensesId { get; set; }
    public bool? IsCompanyExpense { get; set; }
    public bool? IsCust { get; set; }
    public bool? IsValue { get; set; }
    public bool? IsAllItems { get; set; }
    public string? Allocation { get; set; }
    public decimal? Value { get; set; }
    public decimal? Amount { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? NetAmount { get; set; }
    public decimal? InvoiceRate { get; set; }
    public decimal? InvoiceAmount { get; set; }
    public bool? Taxable { get; set; }
    public decimal? TaxPerc { get; set; }
    public decimal? Tax { get; set; }
    public string? Note { get; set; }
    public int? CustId { get; set; }
    public int? AccountId { get; set; }
    public decimal? Total { get; set; }
    public int? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public string? Writtenby { get; set; }
    public int? PeriodId { get; set; }
    public int? Cpu { get; set; }
    public Guid Rowguid { get; set; }
}