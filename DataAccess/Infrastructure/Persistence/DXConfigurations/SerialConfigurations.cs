using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SerialConfiguration : IEntityTypeConfiguration<Serial>
{
    public void Configure(EntityTypeBuilder<Serial> builder)
    {
        builder.ToTable("Serial");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Available).HasDefaultValueSql("((1))");

        builder.Property(e => e.CurrentState)
            .HasMaxLength(4)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.ItemId).HasColumnName("ItemID");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SerialNumber)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");
    }
}