using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EstimateDailyConfiguration : IEntityTypeConfiguration<EstimateDaily>
{
    public void Configure(EntityTypeBuilder<EstimateDaily> builder)
    {
        builder.ToTable("Estimate_Daily");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Balance).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Credit).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Deal).HasMaxLength(50);

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Debit).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.EngDealing).HasMaxLength(50);

        builder.Property(e => e.EstimateId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("EstimateID");

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}