using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EmplSalaryPeriodConfiguration : IEntityTypeConfiguration<EmplSalaryPeriod>
{
    public void Configure(EntityTypeBuilder<EmplSalaryPeriod> builder)
    {
        builder.ToTable("Empl_SalaryPeriod");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.CalcAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Calced).HasDefaultValueSql("((0))");

        builder.Property(e => e.EndTime).HasColumnType("datetime");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Paid).HasDefaultValueSql("((0))");

        builder.Property(e => e.PaidAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.RemainAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.StartTime).HasColumnType("datetime");

        builder.Property(e => e.Status)
            .HasMaxLength(50)
            .IsUnicode(false);
    }
}