﻿namespace DataAccess.Domain.Models;

public partial class TaxesGroup
{
    public TaxesGroup()
    {
        Taxes = new HashSet<Taxis>();
        TaxesDats = new HashSet<TaxesDat>();
        TaxesSubGroups = new HashSet<TaxesSubGroup>();
    }

    public string Code { get; set; } = null!;
    public string? EnName { get; set; }
    public string? ArName { get; set; }
    public bool? Taxable { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public bool? Active { get; set; }
    public bool? IsDefault { get; set; }

    public virtual ICollection<Taxis> Taxes { get; set; }
    public virtual ICollection<TaxesDat> TaxesDats { get; set; }
    public virtual ICollection<TaxesSubGroup> TaxesSubGroups { get; set; }
}
