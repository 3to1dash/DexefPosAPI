using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class GrouplayoutConfiguration : IEntityTypeConfiguration<Grouplayout>
{
    public void Configure(EntityTypeBuilder<Grouplayout> builder)
    {
        builder.HasNoKey();

        builder.ToTable("grouplayout");

        builder.Property(e => e.Frm)
            .HasMaxLength(50)
            .HasColumnName("frm");

        builder.Property(e => e.Frmleft)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("frmleft");

        builder.Property(e => e.Groupmain)
            .HasMaxLength(50)
            .HasColumnName("groupmain");

        builder.Property(e => e.Locx)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("locx");

        builder.Property(e => e.Locy)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("locy");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Sizex)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("sizex");

        builder.Property(e => e.Sizey)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("sizey");
    }
}