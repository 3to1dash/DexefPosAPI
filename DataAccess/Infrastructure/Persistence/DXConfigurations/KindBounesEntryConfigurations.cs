using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindBounesEntryConfiguration : IEntityTypeConfiguration<KindBounesEntry>
{
    public void Configure(EntityTypeBuilder<KindBounesEntry> builder)
    {
        builder.ToTable("Kind_BounesEntry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Amount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BounesId).HasColumnName("BounesID");

        builder.Property(e => e.Discount).HasColumnType("numeric(19, 5)");
    }
}