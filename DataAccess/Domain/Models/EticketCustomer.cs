﻿namespace DataAccess.Domain.Models;

public partial class EticketCustomer
{
    public int Id { get; set; }
    public string? Num { get; set; }
    public string Name { get; set; } = null!;
    public int? BranchId { get; set; }
}
