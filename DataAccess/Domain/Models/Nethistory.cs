namespace DataAccess.Domain.Models;

public partial class Nethistory
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public string? Website { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public string? Quest { get; set; }
    public string? Answer { get; set; }
    public string? Note { get; set; }
    public Guid Rowguid { get; set; }
}
