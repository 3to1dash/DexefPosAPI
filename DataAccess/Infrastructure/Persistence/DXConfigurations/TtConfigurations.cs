using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TtConfiguration : IEntityTypeConfiguration<Tt>
{


    public void Configure(EntityTypeBuilder<Tt> builder)
    {
        builder.HasNoKey();

        builder.ToView("tt");

        builder.Property(e => e.Id).HasColumnName("id");
    }
}