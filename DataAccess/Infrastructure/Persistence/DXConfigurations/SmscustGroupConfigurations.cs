using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SmscustGroupConfiguration : IEntityTypeConfiguration<SmscustGroup>
{
    public void Configure(EntityTypeBuilder<SmscustGroup> builder)
    {
        builder.ToTable("SMSCustGroup");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.GroupId).HasColumnName("GroupID");

        builder.Property(e => e.Ismanuel).HasColumnName("ISManuel");

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.ParentId).HasColumnName("ParentID");
    }
}