using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindImageConfiguration : IEntityTypeConfiguration<KindImage>
{


    public void Configure(EntityTypeBuilder<KindImage> builder)
    {
        builder.ToTable("Kind_Image");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.Photo).HasColumnName("photo");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}