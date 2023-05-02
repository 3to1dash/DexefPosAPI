using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyworkpercentTempConfiguration : IEntityTypeConfiguration<DailyworkpercentTemp>
{
    public void Configure(EntityTypeBuilder<DailyworkpercentTemp> builder)
    {
        builder.ToTable("dailyworkpercent_temp");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BillIndex)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("bill_index");

        builder.Property(e => e.Come)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("come")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Deal)
            .HasMaxLength(50)
            .HasColumnName("deal");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.EnDealing)
            .HasMaxLength(50)
            .HasColumnName("en_dealing");

        builder.Property(e => e.Go)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("go")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Perc)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("perc")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Percval)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("percval")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Regnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("regnum");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Workid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("workid");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}