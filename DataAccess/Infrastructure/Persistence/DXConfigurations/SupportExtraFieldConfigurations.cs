using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SupportExtraFieldConfiguration : IEntityTypeConfiguration<SupportExtraField>
{


    public void Configure(EntityTypeBuilder<SupportExtraField> builder)
    {
        builder.ToTable("Support_ExtraField");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Txt1)
            .HasMaxLength(50)
            .HasColumnName("txt1");

        builder.Property(e => e.Txt2)
            .HasMaxLength(50)
            .HasColumnName("txt2");

        builder.Property(e => e.Txt3)
            .HasMaxLength(50)
            .HasColumnName("txt3");

        builder.Property(e => e.Txt4)
            .HasMaxLength(50)
            .HasColumnName("txt4");

        builder.Property(e => e.Txt5)
            .HasMaxLength(50)
            .HasColumnName("txt5");

        builder.Property(e => e.Txt6)
            .HasMaxLength(50)
            .HasColumnName("txt6");

        builder.Property(e => e.Txt7)
            .HasMaxLength(50)
            .HasColumnName("txt7");

        builder.Property(e => e.Txt8)
            .HasMaxLength(50)
            .HasColumnName("txt8");
    }
}