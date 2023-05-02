namespace DataAccess.Domain.Models;

public class DeliveryMan
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public int? TypeIndex { get; set; }
    public bool? Active { get; set; }
    public decimal? Amount { get; set; }
    public bool? Taxable { get; set; }
    public string? Notes { get; set; }
    public int? CustId { get; set; }
    public int? EmplId { get; set; }
}