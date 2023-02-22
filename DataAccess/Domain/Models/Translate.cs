namespace DataAccess.Domain.Models;

public partial class Translate
{
    public decimal Id { get; set; }
    public string? Arabic { get; set; }
    public string? English { get; set; }
    public string? Frensh { get; set; }
    public Guid Rowguid { get; set; }
}
