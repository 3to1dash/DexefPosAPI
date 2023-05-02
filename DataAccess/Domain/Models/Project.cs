namespace DataAccess.Domain.Models;

public class Project
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;
    public long? StatId { get; set; }
    public long? TypeId { get; set; }
    public byte Visibility { get; set; }
    public decimal EstValue { get; set; }
    public DateTime? DateAdded { get; set; }
    public long? ClientId { get; set; }
    public byte Archived { get; set; }
    public DateTime? LastAccessed { get; set; }
    public long? WfId { get; set; }
    public DateTime DateModified { get; set; }
    public string? ScopeOfWork { get; set; }
    public string? SpecialConditions { get; set; }
    public string? SchDuration { get; set; }
    public string? SchStartDate { get; set; }
    public string? SchEndDate { get; set; }
    public string? EstActualCost { get; set; }
    public string? Number { get; set; }
    public decimal? Variance { get; set; }
    public short? NumTasks { get; set; }
    public Guid Uid { get; set; }
    public DateTime Lmod { get; set; }
    public decimal? BaseEstimate { get; set; }
    public decimal? CommittedCosts { get; set; }
    public decimal? InvoicedAmount { get; set; }
    public Guid Rowguid { get; set; }
}