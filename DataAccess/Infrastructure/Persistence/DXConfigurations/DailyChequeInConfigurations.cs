using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyChequeInConfiguration : IEntityTypeConfiguration<DailyChequeIn>
{
    public void Configure(EntityTypeBuilder<DailyChequeIn> builder)
    {
        builder.ToTable("Daily_ChequeIn");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.AccountType).HasMaxLength(50);

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.ChequeId).HasColumnName("ChequeID");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.DeletedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Status).HasMaxLength(50);

        builder.Property(e => e.TargetOwner).HasMaxLength(450);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}