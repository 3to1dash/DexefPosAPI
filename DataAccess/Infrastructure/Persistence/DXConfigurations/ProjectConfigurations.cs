using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ProjectConfiguration : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.ToTable("project");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("ID");

        builder.Property(e => e.Archived).HasColumnName("ARCHIVED");

        builder.Property(e => e.BaseEstimate)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("BASE_ESTIMATE");

        builder.Property(e => e.ClientId).HasColumnName("CLIENT_ID");

        builder.Property(e => e.CommittedCosts)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("COMMITTED_COSTS");

        builder.Property(e => e.DateAdded)
            .HasColumnType("smalldatetime")
            .HasColumnName("DATE_ADDED")
            .HasDefaultValueSql("(getdate())");

        builder.Property(e => e.DateModified)
            .HasColumnType("datetime")
            .HasColumnName("DATE_MODIFIED")
            .HasDefaultValueSql("(getdate())");

        builder.Property(e => e.EstActualCost)
            .HasMaxLength(50)
            .HasColumnName("EST_ACTUAL_COST");

        builder.Property(e => e.EstValue)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("EST_VALUE");

        builder.Property(e => e.InvoicedAmount)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("INVOICED_AMOUNT");

        builder.Property(e => e.LastAccessed)
            .HasColumnType("smalldatetime")
            .HasColumnName("LAST_ACCESSED")
            .HasDefaultValueSql("(getdate())");

        builder.Property(e => e.Lmod)
            .HasColumnType("datetime")
            .HasColumnName("LMOD")
            .HasDefaultValueSql("(getdate())");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("NAME");

        builder.Property(e => e.NumTasks).HasColumnName("NUM_TASKS");

        builder.Property(e => e.Number)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("NUMBER");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SchDuration)
            .HasMaxLength(50)
            .HasColumnName("SCH_DURATION");

        builder.Property(e => e.SchEndDate)
            .HasMaxLength(50)
            .HasColumnName("SCH_END_DATE");

        builder.Property(e => e.SchStartDate)
            .HasMaxLength(50)
            .HasColumnName("SCH_START_DATE");

        builder.Property(e => e.ScopeOfWork)
            .HasMaxLength(4000)
            .HasColumnName("SCOPE_OF_WORK");

        builder.Property(e => e.SpecialConditions)
            .HasMaxLength(4000)
            .HasColumnName("SPECIAL_CONDITIONS");

        builder.Property(e => e.StatId).HasColumnName("STAT_ID");

        builder.Property(e => e.TypeId).HasColumnName("TYPE_ID");

        builder.Property(e => e.Uid)
            .HasColumnName("UID")
            .HasDefaultValueSql("(newid())");

        builder.Property(e => e.Variance)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("VARIANCE")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Visibility)
            .HasColumnName("VISIBILITY")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.WfId).HasColumnName("WF_ID");
    }
}