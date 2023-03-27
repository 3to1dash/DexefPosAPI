using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FavoriteformConfiguration : IEntityTypeConfiguration<Favoriteform>
{
    public void Configure(EntityTypeBuilder<Favoriteform> builder)
    {
        builder.HasNoKey();

        builder.ToTable("favoriteform");

        builder.Property(e => e.Memo).HasMaxLength(50);

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}