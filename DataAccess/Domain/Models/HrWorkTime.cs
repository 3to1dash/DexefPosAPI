namespace DataAccess.Domain.Models;

public class HrWorkTime
{
    public int Id { get; set; }
    public int? Num { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public DateTime? LogIn { get; set; }
    public string? LogOut { get; set; }
    public bool? Active { get; set; }
    public string? Notes { get; set; }
    public Guid Rowguid { get; set; }

    public virtual List<User> Users { get; set; }
}