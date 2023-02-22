﻿namespace DataAccess.Domain.Models;

public partial class WorkSolfarecieve
{
    public int Id { get; set; }
    public int? StorageId { get; set; }
    public int? Accountid { get; set; }
    public DateTime? Dt { get; set; }
    public byte? CashType { get; set; }
    public int? Num { get; set; }
    public int? Workid { get; set; }
    public decimal? Value { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public int? Regnum { get; set; }
    public int? BillIndex { get; set; }
    public decimal? TaskId { get; set; }
    public int? BranchId { get; set; }
    public int? CostId { get; set; }
    public bool? Done { get; set; }
    public bool? Closed { get; set; }
    public Guid Rowguid { get; set; }
}
