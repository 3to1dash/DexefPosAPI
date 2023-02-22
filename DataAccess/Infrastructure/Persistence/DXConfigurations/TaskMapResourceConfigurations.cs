using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TaskMapResourceConfiguration : IEntityTypeConfiguration<TaskMapResource>
{


    public void Configure(EntityTypeBuilder<TaskMapResource> builder)
    {
        builder.ToTable("TaskMap_Resources");

        builder.Property(e => e.CustomField1).HasMaxLength(2000);

        builder.Property(e => e.Description).HasMaxLength(2000);

        builder.Property(e => e.Image).HasColumnType("image");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}