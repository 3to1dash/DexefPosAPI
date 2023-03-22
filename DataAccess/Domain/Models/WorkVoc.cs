namespace DataAccess.Domain.Models;

public class WorkVoc
{
    public string? Name { get; set; }
    public string? Groups { get; set; }
    public bool? Forall { get; set; }
    public Guid Rowguid { get; set; }
}
