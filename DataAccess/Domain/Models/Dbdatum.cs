namespace DataAccess.Domain.Models;

public class Dbdatum
{
    public decimal Id { get; set; }
    public string? Dbname { get; set; }
    public string? DbPath { get; set; }
    public bool? AutoSave { get; set; }
    public bool? SaveInExit { get; set; }
    public int? EveryHours { get; set; }
    public Guid Rowguid { get; set; }
}
