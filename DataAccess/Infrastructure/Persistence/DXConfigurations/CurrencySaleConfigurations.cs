using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CurrencySaleConfiguration : IEntityTypeConfiguration<CurrencySale>
{
    public void Configure(EntityTypeBuilder<CurrencySale> builder)
    {
        builder.ToTable("Currency_Sale");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.CustType)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.FromId).HasColumnName("FromID");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.MidCur)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.MidRate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Note).HasMaxLength(450);

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.Paid).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Price).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Remain).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.ToId).HasColumnName("ToID");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TransferRate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UsedRate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Value).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}