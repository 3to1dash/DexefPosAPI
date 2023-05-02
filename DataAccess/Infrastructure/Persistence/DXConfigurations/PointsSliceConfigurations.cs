using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PointsSliceConfiguration : IEntityTypeConfiguration<PointsSlice>
{
    public void Configure(EntityTypeBuilder<PointsSlice> builder)
    {
        builder.ToTable("Points_Slice");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.MinPoints).HasDefaultValueSql("((0))");

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.Num)
            .HasColumnName("num")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}