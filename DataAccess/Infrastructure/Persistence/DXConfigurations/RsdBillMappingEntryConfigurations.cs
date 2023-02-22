using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RsdBillMappingEntryConfiguration : IEntityTypeConfiguration<RsdBillMappingEntry>
{


    public void Configure(EntityTypeBuilder<RsdBillMappingEntry> builder)
    {
        builder.ToTable("RSD_BillMappingEntry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BatchNumber).HasMaxLength(50);

        builder.Property(e => e.Code).HasMaxLength(50);

        builder.Property(e => e.ErrorCode).HasMaxLength(50);

        builder.Property(e => e.ExprDt)
            .HasColumnType("datetime")
            .HasColumnName("ExprDT");

        builder.Property(e => e.ItemId).HasColumnName("ItemID");

        builder.Property(e => e.MappingId).HasColumnName("MappingID");

        builder.Property(e => e.Sn)
            .HasMaxLength(50)
            .HasColumnName("SN");
    }
}