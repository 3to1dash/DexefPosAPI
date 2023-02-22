namespace DataAccess.Domain.Models;

public partial class Plugin
{
    public int Id { get; set; }
    public string? DealingId { get; set; }
    public string? DesciptionId { get; set; }
    public string? CategoryId { get; set; }
    public string? Type { get; set; }
    public int? ImageIndex { get; set; }
    public bool? Active { get; set; }
    public int? VisibleIndex { get; set; }
    public string? Xcolor { get; set; }
    public string? Ximage { get; set; }
    public string? ShortCut { get; set; }
    public string? Sn { get; set; }
    public string? Snconfirm { get; set; }
    public Guid Rowguid { get; set; }
}
