namespace DataAccess.Domain.Models;

public class Foodlayout
{
    public decimal Id { get; set; }
    public decimal? Reid { get; set; }
    public decimal? Groupid { get; set; }
    public string? Detail { get; set; }
    public string? Name { get; set; }
    public decimal? Locy { get; set; }
    public decimal? Locx { get; set; }
    public decimal? Sizey { get; set; }
    public decimal? Sizex { get; set; }
    public string? Kind { get; set; }
    public decimal? Kindid { get; set; }
    public string? Unite { get; set; }
    public string? Color { get; set; }
    public Guid Rowguid { get; set; }
}
