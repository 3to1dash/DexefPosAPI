namespace DXPOS.DTOs;

public class CurrencyDto
{
    public decimal Id { get; set; }
    public string? Num { get; set; }
    public string Name { get; set; }
    public decimal? Value { get; set; }
    public decimal? LocalRate { get; set; }
    public bool? SubOne { get; set; }

}
