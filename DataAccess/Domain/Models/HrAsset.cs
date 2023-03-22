namespace DataAccess.Domain.Models;

public class HrAsset
{
    public int Id { get; set; }
    public int? EmplId { get; set; }
    public string? Name { get; set; }
    public int? GroupId { get; set; }
    public string? Serial { get; set; }
    public DateTime? DtAssigned { get; set; }
    public DateTime? DtReturned { get; set; }
    public string? Note { get; set; }
}
