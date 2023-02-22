using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class FavoriteConfiguration : IEntityTypeConfiguration<Favorite>
{


    public void Configure(EntityTypeBuilder<Favorite> builder)
    {
        builder.HasNoKey();

        builder.ToTable("favorite");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("dealing");

        builder.Property(e => e.F1)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("f1")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.F2)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("f2")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.F3)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("f3")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.F4)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("f4")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.F5)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("f5")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.F6)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("f6")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.F7)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("f7")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.F8)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("f8")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.F9)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("f9")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.WrittenBy).HasColumnType("numeric(18, 0)");
    }
}