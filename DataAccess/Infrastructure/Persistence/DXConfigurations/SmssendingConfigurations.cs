using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SmssendingConfiguration : IEntityTypeConfiguration<Smssending>
{


    public void Configure(EntityTypeBuilder<Smssending> builder)
    {
        builder.ToTable("SMSSending");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Smsid).HasColumnName("SMSID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TemplateId).HasColumnName("TemplateID");
    }
}