using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class IncomeItemsBranchConfiguration : IEntityTypeConfiguration<IncomeItemsBranch>
{
    public void Configure(EntityTypeBuilder<IncomeItemsBranch> builder)
    {
        builder.ToTable("IncomeItems_Branches");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.IncomeId).HasColumnName("IncomeID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}