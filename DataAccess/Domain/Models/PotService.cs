namespace DataAccess.Domain.Models;

public class PotService
{
    public decimal Id { get; set; }
    public decimal? CustId { get; set; }
    public decimal? ServiceId { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? AreaId { get; set; }
    public Guid Rowguid { get; set; }
}
