﻿namespace DataAccess.Domain.Models;

public partial class WorkPayInsurance
{
    public decimal Id { get; set; }
    public bool? Iscompany { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? WorkId { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public DateTime? MonthDt { get; set; }
    public string? Ship { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? Fixed { get; set; }
    public decimal? Changed { get; set; }
    public bool? Done { get; set; }
    public decimal? Total { get; set; }
    public decimal? Remain { get; set; }
    public decimal? PaidValue { get; set; }
    public decimal? RegNum { get; set; }
    public bool? IsSelect { get; set; }
    public int? AccountId { get; set; }
    public int? ExpenseId { get; set; }
    public Guid Rowguid { get; set; }
}
