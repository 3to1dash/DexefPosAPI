namespace DataAccess.Domain.Models;

public partial class CStage
{
    public decimal? Id { get; set; }
    public decimal? TenderId { get; set; }
    public decimal? ParentId { get; set; }
    public decimal? SubId { get; set; }
    public string? Num { get; set; }
    public string? Name { get; set; }
    public bool? IsSubContract { get; set; }
    public Guid Rowguid { get; set; }
}
