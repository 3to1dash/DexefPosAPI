namespace DataAccess.Domain.Models;

public partial class Partner
{
    public long Id { get; set; }
    public int? BranchId { get; set; }
    public long? CustId { get; set; }
    public long? Num { get; set; }
    public string? Name { get; set; }
    public int? PartnerGroupId { get; set; }
    public string? Mob1 { get; set; }
    public string? Mob2 { get; set; }
    public string? Mob3 { get; set; }
    public string? Address { get; set; }
    public string? Employment { get; set; }
    public DateTime? Dt { get; set; }
    public string? Notes { get; set; }
    public byte[]? Logo { get; set; }
    public string? Txt1 { get; set; }
    public string? Txt2 { get; set; }
    public string? Txt3 { get; set; }
    public string? Txt4 { get; set; }
    public string? Txt5 { get; set; }
    public string? Txt6 { get; set; }
    public string? Txt7 { get; set; }
    public string? Txt8 { get; set; }
    public Guid Rowguid { get; set; }
}
