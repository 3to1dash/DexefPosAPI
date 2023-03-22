namespace DataAccess.Domain.Models;

public class Layout
{
    public int Id { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public bool? IsPrivate { get; set; }
    public string? WrittenBy { get; set; }
    public string? Frmname { get; set; }
    public bool? Active { get; set; }
    public string? UpdatedBy { get; set; }
    public bool? IsDefault { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public string? Tags { get; set; }
    public bool? ColumnChooser { get; set; }
    public bool? PrintPreview { get; set; }
    public bool? ExportData { get; set; }
    public bool? CopyData { get; set; }
    public bool? UpdateDesign { get; set; }
    public bool? AddNewDesign { get; set; }
    public string? NumberFormat { get; set; }
    public string? DateFormat { get; set; }
    public DateTime? CreatedDate { get; set; }
}
