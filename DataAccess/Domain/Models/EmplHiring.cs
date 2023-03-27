namespace DataAccess.Domain.Models;

public class EmplHiring
{
    public int Id { get; set; }
    public int? EmplId { get; set; }
    public DateTime? Dt { get; set; }
    public string? PrevStatus { get; set; }
    public string? Status { get; set; }
    public string? Description { get; set; }
}