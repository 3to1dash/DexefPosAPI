using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PreNameFieldsListConfiguration : IEntityTypeConfiguration<PreNameFieldsList>
{


    public void Configure(EntityTypeBuilder<PreNameFieldsList> builder)
    {
        builder.ToTable("PreNameFields_List");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Name).HasMaxLength(150);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Type).HasMaxLength(50);

        builder.Property(e => e.TypeId).HasColumnName("TypeID");
    }
}