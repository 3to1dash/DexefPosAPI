using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindPickConfiguration : IEntityTypeConfiguration<KindPick>
{
    public void Configure(EntityTypeBuilder<KindPick> builder)
    {
        builder.ToTable("Kind_Pick");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.KindOrder).HasColumnName("Kind_Order");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}