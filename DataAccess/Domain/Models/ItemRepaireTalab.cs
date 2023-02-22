namespace DataAccess.Domain.Models;

public partial class ItemRepaireTalab
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public string? Item { get; set; }
    public string? Name { get; set; }
    public string? Phone1 { get; set; }
    public string? Phone2 { get; set; }
    public string? State { get; set; }
    public string? City { get; set; }
    public string? Street { get; set; }
    public string? Build { get; set; }
    public string? Note { get; set; }
    public decimal? Billindex { get; set; }
    public bool? Done { get; set; }
    public bool? IsNew { get; set; }
    public Guid Rowguid { get; set; }
}
