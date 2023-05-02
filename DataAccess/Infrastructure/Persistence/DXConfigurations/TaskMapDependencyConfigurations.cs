using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TaskMapDependencyConfiguration : IEntityTypeConfiguration<TaskMapDependency>
{
    public void Configure(EntityTypeBuilder<TaskMapDependency> builder)
    {
        builder.ToTable("TaskMap_Dependencies");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}