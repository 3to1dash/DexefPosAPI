namespace DataAccess.Domain.Models;

public partial class KindTag
{
    public int Id { get; set; }
    public int? KindId { get; set; }
    public int? TagId { get; set; }
}
