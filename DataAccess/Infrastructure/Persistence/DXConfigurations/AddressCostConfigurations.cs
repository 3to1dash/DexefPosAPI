using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AddressCostConfiguration : IEntityTypeConfiguration<AddressCost>
{


    public void Configure(EntityTypeBuilder<AddressCost> builder)
    {
        builder.ToTable("Address_Cost");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AllInIt).HasDefaultValueSql("((0))");

        builder.Property(e => e.AreaId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("AreaID");

        builder.Property(e => e.CanEdit).HasDefaultValueSql("((1))");

        builder.Property(e => e.Note).HasMaxLength(250);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Value).HasColumnType("numeric(19, 5)");
    }
}