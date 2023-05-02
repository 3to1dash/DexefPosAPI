using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkVacationOrderConfiguration : IEntityTypeConfiguration<WorkVacationOrder>
{
    public void Configure(EntityTypeBuilder<WorkVacationOrder> builder)
    {
        builder.ToTable("Work_VacationOrder");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Answer)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.AnswerBy).HasMaxLength(50);

        builder.Property(e => e.AnswerNote).HasMaxLength(2000);

        builder.Property(e => e.Branchid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("branchid");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.FromDt).HasColumnType("date");

        builder.Property(e => e.HasDiscount).HasDefaultValueSql("((0))");

        builder.Property(e => e.Note).HasMaxLength(2000);

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Period).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(50);

        builder.Property(e => e.ToDt).HasColumnType("date");

        builder.Property(e => e.WorkId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("WorkID");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}