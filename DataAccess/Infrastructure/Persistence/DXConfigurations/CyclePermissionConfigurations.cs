using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CyclePermissionConfiguration : IEntityTypeConfiguration<CyclePermission>
{
    public void Configure(EntityTypeBuilder<CyclePermission> builder)
    {
        builder.ToTable("cycle_Permission");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Permission).HasMaxLength(100);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}