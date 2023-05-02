using System.Text.Json.Serialization;

namespace DataAccess.Domain.Models;

public class CurrencyTable
{
    public decimal Id { get; set; }
    public string? ArNameCountry { get; set; }
    public string? ArName { get; set; }
    public string? ArNameSubName { get; set; }
    public string? Shortcut { get; set; }
    public string? EnName { get; set; }
    public string? EnNameCountry { get; set; }
    public string? EnNameSubName { get; set; }
    public string? FrName { get; set; }
    public string? FrNameCountry { get; set; }
    public string? FrNameSubName { get; set; }
    public string? RuName { get; set; }
    public string? RuNameCountry { get; set; }
    public string? RuNameSubName { get; set; }
    public string? TuName { get; set; }
    public string? TuNameCountry { get; set; }
    public string? TuNameSubName { get; set; }
    public string? ChName { get; set; }
    public string? ChNameCountry { get; set; }
    public string? ChNameSubName { get; set; }
    public string? RoName { get; set; }
    public string? RoNameCountry { get; set; }
    public string? RoNameSubName { get; set; }
    public string? Urname { get; set; }
    public string? UrnameCountry { get; set; }
    public string? UrnameSubName { get; set; }
    public Guid Rowguid { get; set; }
    public string? CountryCode { get; set; }

    [JsonIgnore] public virtual List<CompanyBranch> CompanyBranches { get; set; }
}