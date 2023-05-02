using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FrmlayoutConfiguration : IEntityTypeConfiguration<Frmlayout>
{
    public void Configure(EntityTypeBuilder<Frmlayout> builder)
    {
        builder.HasNoKey();

        builder.ToTable("frmlayout");

        builder.Property(e => e.F)
            .HasMaxLength(640)
            .HasColumnName("f")
            .IsFixedLength();

        builder.Property(e => e.Frmcolor)
            .HasMaxLength(50)
            .HasColumnName("frmcolor");

        builder.Property(e => e.Frmtext)
            .HasMaxLength(50)
            .HasColumnName("frmtext");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}