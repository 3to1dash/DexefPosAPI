using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RtlErrorConfiguration : IEntityTypeConfiguration<RtlError>
{
    public void Configure(EntityTypeBuilder<RtlError> builder)
    {
        builder.ToTable("RTL_Error");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Ar).HasMaxLength(2000);

        builder.Property(e => e.En).HasMaxLength(2000);

        builder.Property(e => e.Fr).HasMaxLength(2000);

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}