using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AccPayrollItemConfiguration : IEntityTypeConfiguration<AccPayrollItem>
{
    public void Configure(EntityTypeBuilder<AccPayrollItem> builder)
    {
        builder.ToTable("Acc_PayrollItems");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.ArName).HasMaxLength(150);

        builder.Property(e => e.CalcGroup).HasMaxLength(10);

        builder.Property(e => e.CalcType).HasMaxLength(50);

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.EnName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.FrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ParentId)
            .HasColumnName("ParentID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ResultType).HasMaxLength(50);

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Tags)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Type)
            .HasMaxLength(50)
            .HasColumnName("type");

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
    }
}