using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DropDownItemStoreConfiguration : IEntityTypeConfiguration<DropDownItemStore>
{
    public void Configure(EntityTypeBuilder<DropDownItemStore> builder)
    {
        builder.HasNoKey();

        builder.ToView("DropDownItemStore");

        builder.Property(e => e.Code)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("code");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.Optkind).HasColumnName("optkind");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.TotalVal).HasColumnType("numeric(19, 5)");
    }
}