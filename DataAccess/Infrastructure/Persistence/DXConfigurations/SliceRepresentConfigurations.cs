using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SliceRepresentConfiguration : IEntityTypeConfiguration<SliceRepresent>
{
    public void Configure(EntityTypeBuilder<SliceRepresent> builder)
    {
        builder.ToTable("Slice_represent");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Fromval)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("fromval");

        builder.Property(e => e.Levels)
            .HasMaxLength(50)
            .HasColumnName("levels");

        builder.Property(e => e.Perc)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("perc");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SliceId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("SliceID");

        builder.Property(e => e.Toval)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("toval");
    }
}