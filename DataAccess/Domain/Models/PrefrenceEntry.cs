namespace DataAccess.Domain.Models;

public class PrefrenceEntry
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? SubStr { get; set; }
    public Guid Rowguid { get; set; }

    public virtual Prefrence? NameNavigation { get; set; }
}