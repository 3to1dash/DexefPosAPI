using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UserOpenDayConfiguration : IEntityTypeConfiguration<UserOpenDay>
{


    public void Configure(EntityTypeBuilder<UserOpenDay> builder)
    {
        builder.ToTable("UserOpenDay");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Balance)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CloseBalance)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CloseTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("CLoseTaskID");

        builder.Property(e => e.CloseTime).HasColumnType("datetime");

        builder.Property(e => e.Credit)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Debit)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Extra)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.IsClosed).HasDefaultValueSql("((0))");

        builder.Property(e => e.OpenTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("OpenTaskID");

        builder.Property(e => e.OpeningBalance)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Shortage)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Username).HasMaxLength(50);
    }
}