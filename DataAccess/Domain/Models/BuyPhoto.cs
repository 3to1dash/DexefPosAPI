﻿namespace DataAccess.Domain.Models;

public partial class BuyPhoto
{
    public string? Dafter { get; set; }
    public decimal? Num { get; set; }
    public byte[]? Photo { get; set; }
    public Guid Rowguid { get; set; }
}
