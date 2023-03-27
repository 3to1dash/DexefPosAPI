namespace DataAccess.Domain.Models;

public class IncomeItemsBranch
{
    public int Id { get; set; }
    public int? IncomeId { get; set; }
    public int? BranchId { get; set; }
    public Guid Rowguid { get; set; }
}