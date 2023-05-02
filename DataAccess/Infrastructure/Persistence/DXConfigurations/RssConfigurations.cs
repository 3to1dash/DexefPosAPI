using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RssConfiguration : IEntityTypeConfiguration<Rss>
{
    public void Configure(EntityTypeBuilder<Rss> builder)
    {
        builder.ToTable("RSS");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Active)
            .HasColumnName("active")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.FromDt).HasColumnType("datetime");

        builder.Property(e => e.Note)
            .HasColumnName("note")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Object)
            .HasMaxLength(250)
            .HasColumnName("object");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ToDt).HasColumnType("datetime");
    }
}