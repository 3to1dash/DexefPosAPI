namespace DataAccess.Domain.Models;

public class InvTypeStatus
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Status { get; set; }
    public bool? IsMain { get; set; }
    public bool? Active { get; set; }
    public bool? IsDefault { get; set; }
    public string? DealingId { get; set; }
}