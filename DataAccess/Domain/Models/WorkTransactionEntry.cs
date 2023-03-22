namespace DataAccess.Domain.Models;

public class WorkTransactionEntry
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? SalaryId { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Value { get; set; }
    public decimal? Total { get; set; }
    public string? Note { get; set; }
    public decimal? WorkId { get; set; }
    public decimal? OperatIndex { get; set; }
    public bool? Done { get; set; }
    public bool? Closed { get; set; }
    public Guid Rowguid { get; set; }
}
