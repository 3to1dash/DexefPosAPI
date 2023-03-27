namespace DataAccess.Domain.Models;

public class EmplTransactionEntry
{
    public int Id { get; set; }
    public int? TransactionId { get; set; }
    public int? PayrollItemId { get; set; }
    public int? EmpId { get; set; }
    public decimal? Value { get; set; }
    public bool? CanEdit { get; set; }
    public bool? IsfixedAmount { get; set; }
}