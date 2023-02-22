namespace DataAccess.Domain.Models;

public partial class HrProctionPercEntry
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public int? ProductionId { get; set; }
    public int? KindId { get; set; }
    public decimal? Cost { get; set; }
    public Guid Rowguid { get; set; }
}
