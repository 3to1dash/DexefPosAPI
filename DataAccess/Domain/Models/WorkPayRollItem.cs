namespace DataAccess.Domain.Models;

public partial class WorkPayRollItem
{
    public decimal Id { get; set; }
    public string? Arb { get; set; }
    public string? Eng { get; set; }
    public string? Fre { get; set; }
    public decimal? Value { get; set; }
    public bool? IsAdd { get; set; }
    public decimal? RegNum { get; set; }
    public DateTime? FromDt { get; set; }
    public DateTime? ToDt { get; set; }
    public decimal? Accountid { get; set; }
    public Guid Rowguid { get; set; }
}
