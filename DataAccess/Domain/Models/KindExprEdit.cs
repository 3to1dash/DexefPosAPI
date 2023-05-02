namespace DataAccess.Domain.Models;

public class KindExprEdit
{
    public decimal Id { get; set; }
    public decimal? Kindid { get; set; }
    public decimal? Valnew { get; set; }
    public decimal? Valnow { get; set; }
    public decimal? Valdiff { get; set; }
    public DateTime? Exprdt { get; set; }
    public string? Operate { get; set; }
    public Guid Rowguid { get; set; }
}