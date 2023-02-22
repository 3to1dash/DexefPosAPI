namespace DataAccess.Domain.Models;

public partial class AlarmList
{
    public long Id { get; set; }
    public int? RowIndex { get; set; }
    public bool? Isgroup { get; set; }
    public long? ParentId { get; set; }
    public string? ArName { get; set; }
    public string? ArDesc { get; set; }
    public string FiedName { get; set; } = null!;
    public string? AlarmType { get; set; }
    public string? AlarmGroup { get; set; }
    public string? EditorType { get; set; }
    public bool? YesNo { get; set; }
    public DateTime? Dt { get; set; }
    public int? Int { get; set; }
    public decimal? Qty { get; set; }
    public bool? IsMultiRow { get; set; }
    public string? FirstName { get; set; }
    public string? FirstFieldName { get; set; }
    public string? FirstEditorType { get; set; }
    public string? SecondName { get; set; }
    public string? SecondFieldName { get; set; }
    public string? SecondEditorType { get; set; }
    public Guid Rowguid { get; set; }
}
