using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SmspatrolConfiguration : IEntityTypeConfiguration<Smspatrol>
{


    public void Configure(EntityTypeBuilder<Smspatrol> builder)
    {
        builder.ToTable("SMSPatrol");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.GroupId).HasColumnName("GroupID");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.TemplateId).HasColumnName("TemplateID");
    }
}