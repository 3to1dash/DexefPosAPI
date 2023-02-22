namespace DataAccess.Domain.Models;

public partial class UpdateReSaleTran
{
    public int? KindId { get; set; }
    public int? AccountId { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? TaskId { get; set; }
    public long? ItemCostRow { get; set; }
    public decimal? NetAmount { get; set; }
    public long CostRow { get; set; }
}
