using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EmplTransactionConfiguration : IEntityTypeConfiguration<EmplTransaction>
{


    public void Configure(EntityTypeBuilder<EmplTransaction> builder)
    {
        builder.ToTable("Empl_Transaction");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.ItemType).HasMaxLength(50);

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.SalaryPeriodId).HasColumnName("SalaryPeriodID");

        builder.Property(e => e.Ship).HasMaxLength(150);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.UpdatedBy).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}