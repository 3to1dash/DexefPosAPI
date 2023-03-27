using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PreNameFieldConfiguration : IEntityTypeConfiguration<PreNameField>
{
    public void Configure(EntityTypeBuilder<PreNameField> builder)
    {
        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.CtrlType).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Text)
            .HasMaxLength(50)
            .HasColumnName("TEXT");

        builder.Property(e => e.Type).HasMaxLength(50);

        builder.Property(e => e.TypeId).HasColumnName("TypeID");
    }
}