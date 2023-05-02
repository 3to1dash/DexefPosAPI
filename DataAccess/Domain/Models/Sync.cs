namespace DataAccess.Domain.Models;

public class Sync
{
    public int Id { get; set; }
    public bool? Chk { get; set; }
    public string? CmpName { get; set; }
    public string? TargetDataBase { get; set; }
    public string? TargetServer { get; set; }
    public DateTime? LastUpdate { get; set; }
}