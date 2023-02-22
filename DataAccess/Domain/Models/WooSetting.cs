namespace DataAccess.Domain.Models;

public partial class WooSetting
{
    public int Id { get; set; }
    public string PropertyName { get; set; } = null!;
    public string PropertyValue { get; set; } = null!;
}
