namespace DataAccess.Domain.Models;

public partial class KindImage
{
    public decimal Id { get; set; }
    public long? KindId { get; set; }
    public byte[]? Photo { get; set; }
    public int? ImageIndex { get; set; }
    public Guid Rowguid { get; set; }
}
