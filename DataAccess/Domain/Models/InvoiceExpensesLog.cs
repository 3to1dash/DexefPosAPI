namespace DataAccess.Domain.Models;

public class InvoiceExpensesLog
{
    public int Id { get; set; }
    public decimal? TaskId { get; set; }
    public int? RowIndex { get; set; }
    public int? ExpenseId { get; set; }
    public decimal? Value { get; set; }
    public string? Allocation { get; set; }
    public string? CostPaying { get; set; }
    public bool? IsAllItems { get; set; }
    public string? SelectedItems { get; set; }
    public decimal? Rate { get; set; }
    public string? Currency { get; set; }
    public int? AccountId { get; set; }
    public string? Note { get; set; }
    public string? Taxable { get; set; }
    public int? TaxId { get; set; }
    public decimal? Tax { get; set; }
    public decimal? TaxPerc { get; set; }
    public decimal? NetAmount { get; set; }
    public decimal? Total { get; set; }
    public decimal? InvoiceAmount { get; set; }
    public decimal? InvoiceRate { get; set; }
    public decimal? InvoiceExpenses { get; set; }
    public decimal? CoExpenses { get; set; }
    public decimal? OtherCustExpenses { get; set; }
    public decimal? InvoiceTaxes { get; set; }
    public byte? CostCenterType { get; set; }
    public int? CostId { get; set; }
    public string? InvoiceCurrency { get; set; }
    public decimal? MainInvoiceRate { get; set; }
    public Guid Rowguid { get; set; }
}