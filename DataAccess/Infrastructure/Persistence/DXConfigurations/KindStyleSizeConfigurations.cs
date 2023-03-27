using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindStyleSizeConfiguration : IEntityTypeConfiguration<KindStyleSize>
{
    public void Configure(EntityTypeBuilder<KindStyleSize> builder)
    {
        builder.ToTable("kind_StyleSize");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.ItemId).HasColumnName("ItemID");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.SizeCode).HasMaxLength(50);

        builder.Property(e => e.SizeId).HasColumnName("SizeID");
    }
}