namespace DataAccess.Domain.Models;

public partial class CustomerDropDown
{
    public int Id { get; set; }
    public string? Num { get; set; }
    public string Name { get; set; } = null!;
    public decimal? Balance { get; set; }
    public bool? Isdebit { get; set; }
    public string? Currency { get; set; }
    public int? BranchId { get; set; }
    public string? Kind { get; set; }
    public bool? ShowInAll { get; set; }
}
