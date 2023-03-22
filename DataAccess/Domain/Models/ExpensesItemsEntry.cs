namespace DataAccess.Domain.Models;

public class ExpensesItemsEntry
{
    public decimal Id { get; set; }
    public decimal? ExpensId { get; set; }
    public string? Value { get; set; }
    public Guid Rowguid { get; set; }
}
