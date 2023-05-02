using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindAssemblyConfiguration : IEntityTypeConfiguration<KindAssembly>
{
    public void Configure(EntityTypeBuilder<KindAssembly> builder)
    {
        builder.ToTable("kind_Assembly");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Discount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.MainId).HasColumnName("MainID");

        builder.Property(e => e.Price).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Qty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasColumnName("unite");
    }
}