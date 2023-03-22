namespace DataAccess.Domain.Models;

public class Company
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Field { get; set; }
    public string? Phone { get; set; }
    public string? Phone1 { get; set; }
    public string? Fax { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? Mail { get; set; }
    public byte[]? Logo { get; set; }
    public string? Tax { get; set; }
    public string? Trade { get; set; }
    public string? Currency { get; set; }
    public string? Subcurrency { get; set; }
    public decimal? CountryId { get; set; }
    public string? Manager { get; set; }
    public bool? IsOnline { get; set; }
    public Guid Rowguid { get; set; }
    public string? BuildingNumber { get; set; }
    public string? Governorate { get; set; }
    public string? Landmark { get; set; }
    public string? ActivityId { get; set; }
    public string? PostalNumber { get; set; }
    public string? AppNumber { get; set; }
    public string? AdditionalNumber { get; set; }

    public virtual List<CompanyBranch> CompanyBranches { get; set; }
    public virtual List<CompanyTaxToken> CompanyTaxTokens { get; set; }
    public virtual CurrencyTable CurrencyTable { get; set; }

}
