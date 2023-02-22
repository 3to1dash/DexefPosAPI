namespace DataAccess.Domain.Models;

public partial class DealingTableName
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public string TableName { get; set; } = null!;
    public string? Dealing { get; set; }
    public int? Orders { get; set; }
    public Guid Rowguid { get; set; }
}
