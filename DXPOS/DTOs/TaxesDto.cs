using System.Text.Json.Serialization;

namespace DXPOS.DTOs;

public class TaxesDto
{
    [JsonPropertyName("tax_id")]
    public int? TaxId { get; set; }
    [JsonPropertyName("tax_name")]
    public string TaxName { get; set; }
    [JsonPropertyName("DATPerc")]
    public decimal? DATPerc { get; set; }
    [JsonPropertyName("DATID")]
    public int? DATID { get; set; }
    [JsonPropertyName("DATMinInvoice")]
    public decimal? DATMinInvoice { get; set; }
    [JsonPropertyName("entry_tax_id")]
    public int? EntryTaxId { get; set; }
    [JsonPropertyName("tax_perc")]
    public decimal? TaxPerc { get; set; }
}
