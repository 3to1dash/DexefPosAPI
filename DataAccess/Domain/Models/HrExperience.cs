namespace DataAccess.Domain.Models;

public partial class HrExperience
{
    public int Id { get; set; }
    public int? EmplId { get; set; }
    public string? Company { get; set; }
    public int? JobId { get; set; }
    public string? Description { get; set; }
    public DateTime? DtStart { get; set; }
    public DateTime? DtEnd { get; set; }
    public string? Note { get; set; }
}
