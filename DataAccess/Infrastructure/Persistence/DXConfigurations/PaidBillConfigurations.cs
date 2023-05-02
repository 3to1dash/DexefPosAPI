using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PaidBillConfiguration : IEntityTypeConfiguration<PaidBill>
{
    public void Configure(EntityTypeBuilder<PaidBill> builder)
    {
        builder.HasNoKey();

        builder.ToTable("paid_bill");

        builder.Property(e => e.Billindex)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("billindex");

        builder.Property(e => e.Billnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("billnum");

        builder.Property(e => e.Billregnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("billregnum");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Regnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("regnum");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}