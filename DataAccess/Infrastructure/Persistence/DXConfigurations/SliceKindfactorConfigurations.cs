using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SliceKindfactorConfiguration : IEntityTypeConfiguration<SliceKindfactor>
{
    public void Configure(EntityTypeBuilder<SliceKindfactor> builder)
    {
        builder.ToTable("Slice_kindfactor");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Kindindex)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("kindindex");

        builder.Property(e => e.Price)
            .HasColumnType("money")
            .HasColumnName("price");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SliceId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("SliceID");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasColumnName("unite");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("value");
    }
}