using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RepSliceConfiguration : IEntityTypeConfiguration<RepSlice>
{
    public void Configure(EntityTypeBuilder<RepSlice> builder)
    {
        builder.ToTable("RepSlice");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.CalcType).HasMaxLength(10);

        builder.Property(e => e.IsReturn).HasDefaultValueSql("((0))");

        builder.Property(e => e.MaxSlice).HasColumnType("decimal(18, 5)");

        builder.Property(e => e.MinSlice).HasColumnType("decimal(18, 5)");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Note).HasMaxLength(450);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}