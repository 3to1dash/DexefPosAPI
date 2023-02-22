using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class NoteQuickConfiguration : IEntityTypeConfiguration<NoteQuick>
{


    public void Configure(EntityTypeBuilder<NoteQuick> builder)
    {
        builder.ToTable("NoteQuick");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.Note).HasMaxLength(350);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);

        builder.Property(e => e.Xcolor)
            .HasMaxLength(50)
            .HasColumnName("XColor");
    }
}