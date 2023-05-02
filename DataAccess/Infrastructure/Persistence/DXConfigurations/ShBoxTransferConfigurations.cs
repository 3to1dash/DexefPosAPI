using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ShBoxTransferConfiguration : IEntityTypeConfiguration<ShBoxTransfer>
{
    public void Configure(EntityTypeBuilder<ShBoxTransfer> builder)
    {
        builder.ToTable("Sh_BoxTransfer");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Box).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BoxRent).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BoxSum).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.FromCustid).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.FromName).HasMaxLength(50);

        builder.Property(e => e.Note).HasMaxLength(2000);

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(50);

        builder.Property(e => e.ToCustid).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.ToName).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}