namespace DataAccess.Domain.Models;

public partial class KindStyleColor
{
    public int Id { get; set; }
    public int? KindId { get; set; }
    public int? ItemId { get; set; }
    public string? ColorCode { get; set; }
    public int? ColorId { get; set; }
}
