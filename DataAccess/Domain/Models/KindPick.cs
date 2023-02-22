namespace DataAccess.Domain.Models;

public partial class KindPick
{
    public long Id { get; set; }
    public int? KindId { get; set; }
    public int? KindOrder { get; set; }
    public string? WrittenBy { get; set; }
}
