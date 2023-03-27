using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DataAccess.Domain.Models;

public class KindStock
{
    public int Id { get; set; }
    public string Num { get; set; } = null!;
    public string Stock { get; set; } = null!;
    public string? Mobile1 { get; set; }
    public string? Mobile2 { get; set; }
    public string? Mobile3 { get; set; }
    public string? Adress { get; set; }
    public bool? Active { get; set; }
    public decimal? Area { get; set; }
    public int? BranchId { get; set; }
    public decimal? WorkId { get; set; }
    public int? Countkind { get; set; }
    public DateTime? Dt { get; set; }
    public Guid Rowguid { get; set; }

    [NotMapped] public virtual string Branch { get; set; }
    [JsonIgnore] public virtual CompanyBranch CompanyBranch { get; set; }
}