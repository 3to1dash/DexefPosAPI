namespace DataAccess.Domain.Models;

public class CompanyTaxToken
{
    public int Id { get; set; }
    public int? CompanyId { get; set; }
    public string? Country { get; set; }
    public string? ClientId { get; set; }
    public string? ClientSecret1 { get; set; }
    public string? ClientSecret2 { get; set; }
    public string? Pin { get; set; }
    public bool? IsAutomaticSend { get; set; }
    public int? Days { get; set; }
    public bool? IsTrial { get; set; }

    public virtual Company? Company { get; set; }
}