namespace DataAccess.Domain.Models;

public partial class Dbversion
{
    public decimal CurrentVer { get; set; }
    public Guid Rowguid { get; set; }
}
