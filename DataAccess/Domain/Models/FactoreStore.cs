namespace DataAccess.Domain.Models;

public class FactoreStore
{
    public decimal Id { get; set; }
    public decimal? StageId { get; set; }
    public decimal? CustId { get; set; }
    public decimal? KindId { get; set; }
    public decimal? GroupId { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Total { get; set; }
    public decimal? BeginQty { get; set; }
    public decimal? BeginVal { get; set; }
    public decimal? Inqty { get; set; }
    public decimal? InVal { get; set; }
    public decimal? OutQty { get; set; }
    public decimal? OutVal { get; set; }
    public Guid Rowguid { get; set; }
}
