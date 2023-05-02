using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrSalaryConfiguration : IEntityTypeConfiguration<HrSalary>
{
    public void Configure(EntityTypeBuilder<HrSalary> builder)
    {
        builder.ToTable("HR_Salaries");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.ArName).HasMaxLength(150);

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.EnName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.FrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.GroupId).HasColumnName("GroupID");

        builder.Property(e => e.HasIfcondition)
            .HasColumnName("HasIFCondition")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.IncrementPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.IsActive).HasDefaultValueSql("((1))");

        builder.Property(e => e.IsAdd).HasDefaultValueSql("((1))");

        builder.Property(e => e.IsEquation).HasDefaultValueSql("((0))");

        builder.Property(e => e.MaxValue)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.MaximumTaxes)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.MinValue)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Note).HasMaxLength(150);

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
    }
}