namespace DataAccess.Domain.Models;

public partial class ExpensesBranch
{
    public int Id { get; set; }
    public int? ExpensesD { get; set; }
    public int? BranchId { get; set; }
    public Guid Rowguid { get; set; }
}
