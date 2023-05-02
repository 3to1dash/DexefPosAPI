namespace DataAccess.Domain.Models;

public class CustAddress
{
    public decimal Id { get; set; }
    public int? CustId { get; set; }
    public bool? IsDefault { get; set; }
    public int? AreaId { get; set; }
    public string? Adress { get; set; }
    public string? Phone1 { get; set; }
    public string? Phone2 { get; set; }
    public string? Phone3 { get; set; }
    public string? Mail { get; set; }
    public string? Person { get; set; }
    public string? Company { get; set; }
    public DateTime? Contacttime { get; set; }
    public string? BuildingNumber { get; set; }
    public string? LevelNumber { get; set; }
    public string? AppNumber { get; set; }
    public string? Street { get; set; }
    public string? LandMark { get; set; }
    public string? Governorate { get; set; }
    public string? City { get; set; }
    public string? GlobalLocationNumber { get; set; }
    public Guid Rowguid { get; set; }
    public string? Num { get; set; }
    public string? AdditionalNumber { get; set; }
    public string? PostalNumber { get; set; }

    public virtual Cust? Cust { get; set; }
}