namespace DataAccess.Domain.Models;

public partial class KindGroupEquation
{
    public int Id { get; set; }
    public decimal? GroupId { get; set; }
    public int? EquationId { get; set; }
    public Guid Rowguid { get; set; }
}
