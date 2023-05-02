using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SalaryLevelConfiguration : IEntityTypeConfiguration<SalaryLevel>
{
    public void Configure(EntityTypeBuilder<SalaryLevel> builder)
    {
        builder.ToTable("Salary_Levels");

        builder.Property(e => e.AlsoCalcAmount)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.AlsoCalcPerc)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.AlsoCalcSalaryId).HasColumnName("AlsoCalcSalaryID");

        builder.Property(e => e.AlsoCalcType).HasMaxLength(50);

        builder.Property(e => e.AlsoUse).HasMaxLength(50);

        builder.Property(e => e.AndThen).HasDefaultValueSql("((0))");

        builder.Property(e => e.CalcAmount)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CalcPerc)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CalcSalaryId).HasColumnName("CalcSalaryID");

        builder.Property(e => e.CalcType).HasMaxLength(50);

        builder.Property(e => e.Condition).HasMaxLength(50);

        builder.Property(e => e.FromAmount)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PredefinedId).HasColumnName("PredefinedID");

        builder.Property(e => e.RowId).HasColumnName("RowID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SalaryId).HasColumnName("SalaryID");

        builder.Property(e => e.ToAmount)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");
    }
}