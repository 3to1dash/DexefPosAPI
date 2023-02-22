using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindTagConfiguration : IEntityTypeConfiguration<KindTag>
{


    public void Configure(EntityTypeBuilder<KindTag> builder)
    {
        builder.ToTable("Kind_Tags");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.TagId).HasColumnName("TagID");
    }
}