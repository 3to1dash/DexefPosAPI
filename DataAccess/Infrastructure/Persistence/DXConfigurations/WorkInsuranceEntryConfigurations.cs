using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkInsuranceEntryConfiguration : IEntityTypeConfiguration<WorkInsuranceEntry>
{
    public void Configure(EntityTypeBuilder<WorkInsuranceEntry> builder)
    {
        builder.ToTable("Work_Insurance_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.ReTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("ReTaskID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");
    }
}