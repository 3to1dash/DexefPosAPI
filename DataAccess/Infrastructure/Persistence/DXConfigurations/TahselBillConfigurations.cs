using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TahselBillConfiguration : IEntityTypeConfiguration<TahselBill>
{


    public void Configure(EntityTypeBuilder<TahselBill> builder)
    {
        builder.ToTable("tahsel_bill");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Billid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("billid");

        builder.Property(e => e.Cashid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("cashid");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}