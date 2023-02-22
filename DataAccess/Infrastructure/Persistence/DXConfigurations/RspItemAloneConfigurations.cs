using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RspItemAloneConfiguration : IEntityTypeConfiguration<RspItemAlone>
{


    public void Configure(EntityTypeBuilder<RspItemAlone> builder)
    {
        builder.HasNoKey();

        builder.ToView("RspItemAlone");

        builder.Property(e => e.Code)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("code");

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Optkind).HasColumnName("optkind");
    }
}