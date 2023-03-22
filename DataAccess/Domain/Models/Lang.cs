namespace DataAccess.Domain.Models;

public class Lang
{
    public decimal Id { get; set; }
    public bool? Arabic { get; set; }
    public bool? English { get; set; }
    public bool? French { get; set; }
    public bool? Turkish { get; set; }
    public bool? Urdu { get; set; }
    public bool? Romanian { get; set; }
    public bool? China { get; set; }
    public bool? Russian { get; set; }
    public bool? IsMultiLang { get; set; }
    public Guid Rowguid { get; set; }
}
