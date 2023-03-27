namespace DataAccess.Domain.Models;

public class KindEquation
{
    public int Id { get; set; }
    public decimal? KindId { get; set; }
    public int? EquationId { get; set; }
    public Guid Rowguid { get; set; }
}