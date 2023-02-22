namespace DataAccess.Domain.Models;

public partial class ResTableType
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? WrittenBy { get; set; }
    public string? UpdateBy { get; set; }
    public DateTime? LstUpdate { get; set; }
}
