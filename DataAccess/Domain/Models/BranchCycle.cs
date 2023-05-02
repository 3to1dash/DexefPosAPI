namespace DataAccess.Domain.Models;

public class BranchCycle
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public string? PurchaseCycle { get; set; }
    public string? SaleCycle { get; set; }
    public string? StoreCycle { get; set; }
    public Guid Rowguid { get; set; }
}