using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PurchaseQuoteStepConfiguration : IEntityTypeConfiguration<PurchaseQuoteStep>
{


    public void Configure(EntityTypeBuilder<PurchaseQuoteStep> builder)
    {
        builder.ToTable("PurchaseQuote_Steps");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.ConfirmedDt)
            .HasColumnType("datetime")
            .HasColumnName("ConfirmedDT");

        builder.Property(e => e.ConfirmedUser).HasMaxLength(50);

        builder.Property(e => e.Role).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.UnderCheckDt)
            .HasColumnType("datetime")
            .HasColumnName("UnderCheckDT");

        builder.Property(e => e.UnderCheckUser).HasMaxLength(50);
    }
}