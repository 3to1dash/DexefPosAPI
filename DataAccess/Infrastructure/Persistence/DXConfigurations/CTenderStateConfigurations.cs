using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CTenderStateConfiguration : IEntityTypeConfiguration<CTenderState>
{


    public void Configure(EntityTypeBuilder<CTenderState> builder)
    {
        builder.ToTable("C_TenderState");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.NameEn)
            .HasMaxLength(50)
            .HasColumnName("NameEN");

        builder.Property(e => e.Note).HasMaxLength(250);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}