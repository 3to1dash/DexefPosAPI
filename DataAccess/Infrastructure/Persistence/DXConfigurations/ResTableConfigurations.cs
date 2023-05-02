using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ResTableConfiguration : IEntityTypeConfiguration<ResTable>
{
    public void Configure(EntityTypeBuilder<ResTable> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

        builder.Property(e => e.FloorId).HasColumnName("FloorID");

        builder.Property(e => e.ImgIndex)
            .HasMaxLength(10)
            .IsFixedLength();

        builder.Property(e => e.Note).HasMaxLength(500);

        builder.Property(e => e.Status).HasDefaultValueSql("((0))");
    }
}