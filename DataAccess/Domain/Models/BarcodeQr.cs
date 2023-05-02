namespace DataAccess.Domain.Models;

public class BarcodeQr
{
    public int Id { get; set; }
    public bool? Active { get; set; }
    public string? CodeAi { get; set; }
    public int? CodeLength { get; set; }
    public string? ExpireAi { get; set; }
    public int? ExpireLength { get; set; }
    public string? BatchAi { get; set; }
    public int? BatchLength { get; set; }
    public string? Snai { get; set; }
    public int? Snlength { get; set; }
    public bool? Qrsorting { get; set; }
}