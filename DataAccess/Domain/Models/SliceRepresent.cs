namespace DataAccess.Domain.Models;

public class SliceRepresent
{
    public decimal Id { get; set; }
    public decimal? SliceId { get; set; }
    public string? Levels { get; set; }
    public decimal? Fromval { get; set; }
    public decimal? Toval { get; set; }
    public decimal? Perc { get; set; }
    public Guid Rowguid { get; set; }
}
