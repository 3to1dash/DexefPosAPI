namespace DataAccess.Domain.Models;

public class WorkUsedEservice
{
    public decimal Id { get; set; }
    public int? WorkId { get; set; }
    public int? ServiceId { get; set; }
    public decimal? Amount { get; set; }
    public decimal? PercCo { get; set; }
    public decimal? PercWork { get; set; }
    public Guid Rowguid { get; set; }
}
