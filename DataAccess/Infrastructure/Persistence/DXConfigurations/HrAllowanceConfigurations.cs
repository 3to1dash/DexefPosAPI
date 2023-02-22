using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrAllowanceConfiguration : IEntityTypeConfiguration<HrAllowance>
{


    public void Configure(EntityTypeBuilder<HrAllowance> builder)
    {
        builder.ToTable("Hr_Allowance");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountIdco)
            .HasColumnName("AccountIDCo")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.AccountIdwork)
            .HasColumnName("AccountIDWork")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Amount).HasColumnType("money");

        builder.Property(e => e.ArName).HasMaxLength(50);

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.CostId)
            .HasColumnName("CostID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.EnName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.FrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.HasIf)
            .HasColumnName("HasIF")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.HasMax).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsEdit).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsWork).HasDefaultValueSql("((0))");

        builder.Property(e => e.MaxAmount)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.MinRepeat).HasDefaultValueSql("((0))");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.PercCo)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PercWork)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RepeatPerYear).HasDefaultValueSql("((0))");

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