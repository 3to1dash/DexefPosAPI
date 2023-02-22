using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SrvcStoreConfiguration : IEntityTypeConfiguration<SrvcStore>
{


    public void Configure(EntityTypeBuilder<SrvcStore> builder)
    {
        builder.ToTable("Srvc_Store");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Address).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Code).HasMaxLength(150);

        builder.Property(e => e.ItemId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ItemID");

        builder.Property(e => e.ParentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ParentID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}