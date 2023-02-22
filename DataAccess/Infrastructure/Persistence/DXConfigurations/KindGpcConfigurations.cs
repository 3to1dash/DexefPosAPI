using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindGpcConfiguration : IEntityTypeConfiguration<KindGpc>
{


    public void Configure(EntityTypeBuilder<KindGpc> builder)
    {
        builder.ToTable("Kind_GPC");

        builder.Property(e => e.Id)
            .HasMaxLength(50)
            .HasColumnName("id");

        builder.Property(e => e.ArName).HasMaxLength(150);

        builder.Property(e => e.Code).HasMaxLength(50);

        builder.Property(e => e.EnName).HasMaxLength(150);

        builder.Property(e => e.EnnameDesc).HasColumnName("ENNameDesc");

        builder.Property(e => e.Isparent).HasColumnName("isparent");

        builder.Property(e => e.ParentId)
            .HasMaxLength(50)
            .HasColumnName("ParentID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}