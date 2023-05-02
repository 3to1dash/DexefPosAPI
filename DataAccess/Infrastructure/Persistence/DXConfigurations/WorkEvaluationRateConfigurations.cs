using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkEvaluationRateConfiguration : IEntityTypeConfiguration<WorkEvaluationRate>
{
    public void Configure(EntityTypeBuilder<WorkEvaluationRate> builder)
    {
        builder.ToTable("Work_EvaluationRate");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Renum)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("renum");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Value).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Workid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("workid");
    }
}