namespace DataAccess.Domain.Models;

public class BarcodeScale
{
    public int Id { get; set; }
    public bool? UseScaleBarcode { get; set; }
    public int? ScaleLength { get; set; }
    public int? ScalePreDigit { get; set; }
    public int? ScalePreValue { get; set; }
    public int? ScaleCode { get; set; }
    public int? ScaleWieght { get; set; }
    public Guid Rowguid { get; set; }
}
