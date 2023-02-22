namespace DataAccess.Domain.Models;

public partial class Cpu
{
    public int Id { get; set; }
    public decimal? Cpu1 { get; set; }
    public string? Name { get; set; }
    public decimal? BranchId { get; set; }
    public bool? IsOn { get; set; }
    public Guid Rowguid { get; set; }
}
