using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailySerialConfiguration : IEntityTypeConfiguration<DailySerial>
{


    public void Configure(EntityTypeBuilder<DailySerial> builder)
    {
        builder.ToTable("DailySerial");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.ItemId).HasColumnName("ItemID");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.Price).HasColumnType("decimal(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SerialNumber)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.SerialTransaction)
            .HasMaxLength(4)
            .IsUnicode(false)
            .HasDefaultValueSql("((0))")
            .IsFixedLength();

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}