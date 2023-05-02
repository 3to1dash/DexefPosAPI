using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AreaConfiguration : IEntityTypeConfiguration<Area>
{
    public void Configure(EntityTypeBuilder<Area> builder)
    {
        builder.ToTable("Area");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Active)
            .HasColumnName("active")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Amount)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Note).HasMaxLength(450);

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.ParentId)
            .HasColumnName("ParentID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}