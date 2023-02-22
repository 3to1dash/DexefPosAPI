using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailycontractConfiguration : IEntityTypeConfiguration<Dailycontract>
{


    public void Configure(EntityTypeBuilder<Dailycontract> builder)
    {
        builder.HasNoKey();

        builder.ToTable("dailycontract");

        builder.Property(e => e.Active).HasColumnName("active");

        builder.Property(e => e.Balance)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("balance");

        builder.Property(e => e.Billnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("billnum");

        builder.Property(e => e.Credit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("credit");

        builder.Property(e => e.Cust)
            .HasMaxLength(50)
            .HasColumnName("cust");

        builder.Property(e => e.Custnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("custnum");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.Debit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("debit");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Item)
            .HasMaxLength(50)
            .HasColumnName("item");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}