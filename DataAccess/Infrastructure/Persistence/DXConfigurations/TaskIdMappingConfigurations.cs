using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TaskIdMappingConfiguration : IEntityTypeConfiguration<TaskIdMapping>
{


    public void Configure(EntityTypeBuilder<TaskIdMapping> builder)
    {
        builder.ToTable("TaskID_Mapping");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.NewTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("NewTaskID");

        builder.Property(e => e.OldTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("OldTaskID");
    }
}