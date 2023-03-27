using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class MenuTileHomeConfiguration : IEntityTypeConfiguration<MenuTileHome>
{
    public void Configure(EntityTypeBuilder<MenuTileHome> builder)
    {
        builder.ToTable("Menu_TileHome");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("ID");

        builder.Property(e => e.Frm).HasMaxLength(255);

        builder.Property(e => e.ReFrm).HasMaxLength(255);

        builder.Property(e => e.Xorder).HasColumnName("XOrder");
    }
}