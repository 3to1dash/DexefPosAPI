using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ExtraItemEntryConfiguration : IEntityTypeConfiguration<ExtraItemEntry>
{


    public void Configure(EntityTypeBuilder<ExtraItemEntry> builder)
    {
        builder.ToTable("ExtraItem_Entry");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.DiscountId).HasColumnName("DiscountID");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}