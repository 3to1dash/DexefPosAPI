namespace DataAccess.Domain.Models;

public class InvoiceMustSave
{
    public int Id { get; set; }
    public string? Dealing { get; set; }
    public bool? Cust { get; set; }
    public bool? Address { get; set; }
    public bool? Phone { get; set; }
    public bool? CostCenter { get; set; }
    public bool? Rep { get; set; }
    public bool? Terms { get; set; }
    public bool? DueDt { get; set; }
    public bool? Tax { get; set; }
    public bool? Ship { get; set; }
    public bool? Txt1 { get; set; }
    public bool? Txt2 { get; set; }
    public bool? Txt3 { get; set; }
    public bool? Txt4 { get; set; }
    public bool? Txt5 { get; set; }
    public bool? Txt6 { get; set; }
    public bool? Txt7 { get; set; }
    public bool? Txt8 { get; set; }
    public int? ParentId { get; set; }
    public bool? Dattax { get; set; }
}