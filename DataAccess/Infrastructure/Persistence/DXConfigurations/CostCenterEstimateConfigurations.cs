using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CostCenterEstimateConfiguration : IEntityTypeConfiguration<CostCenterEstimate>
{


    public void Configure(EntityTypeBuilder<CostCenterEstimate> builder)
    {
        builder.ToTable("CostCenter_Estimate");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Credit).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Debit).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.FromDate).HasColumnType("date");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ToDate).HasColumnType("date");
    }
}