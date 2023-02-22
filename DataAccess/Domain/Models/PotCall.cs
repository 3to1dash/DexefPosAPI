namespace DataAccess.Domain.Models;

public partial class PotCall
{
    public decimal Id { get; set; }
    public decimal? CustId { get; set; }
    public DateTime? Dt { get; set; }
    public string? Note { get; set; }
    public Guid Rowguid { get; set; }
}
