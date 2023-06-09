using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SrvcClassConfiguration : IEntityTypeConfiguration<SrvcClass>
{
    public void Configure(EntityTypeBuilder<SrvcClass> builder)
    {
        builder.ToTable("Srvc_Class");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Active).HasDefaultValueSql("((1))");

        builder.Property(e => e.Address).HasMaxLength(100);

        builder.Property(e => e.Name)
            .HasMaxLength(100)
            .HasColumnName("name");

        builder.Property(e => e.ParentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ParentID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}