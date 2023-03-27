using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SmstemplateConfiguration : IEntityTypeConfiguration<Smstemplate>
{
    public void Configure(EntityTypeBuilder<Smstemplate> builder)
    {
        builder.ToTable("SMSTemplate");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.ParentId).HasColumnName("ParentID");
    }
}