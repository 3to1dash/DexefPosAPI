﻿namespace DataAccess.Domain.Models;

public partial class WorkPledgeType
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? AccountId { get; set; }
    public Guid Rowguid { get; set; }
}
