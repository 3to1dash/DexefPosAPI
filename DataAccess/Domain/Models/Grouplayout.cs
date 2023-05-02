namespace DataAccess.Domain.Models;

public class Grouplayout
{
    public string? Frm { get; set; }
    public string? Name { get; set; }
    public string? Groupmain { get; set; }
    public decimal? Sizex { get; set; }
    public decimal? Sizey { get; set; }
    public decimal? Locx { get; set; }
    public decimal? Locy { get; set; }
    public decimal? Frmleft { get; set; }
    public Guid Rowguid { get; set; }
}