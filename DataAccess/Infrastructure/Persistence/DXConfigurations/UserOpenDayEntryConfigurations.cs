using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UserOpenDayEntryConfiguration : IEntityTypeConfiguration<UserOpenDayEntry>
{


    public void Configure(EntityTypeBuilder<UserOpenDayEntry> builder)
    {
        builder.ToTable("UserOpenDay_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Balance)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CloseAccountId)
            .HasColumnName("CloseAccountID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CloseBalance)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CloseTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("CloseTaskID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Credit)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Currency)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.DayId).HasColumnName("DayID");

        builder.Property(e => e.Debit)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Extra)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ExtraId)
            .HasColumnName("ExtraID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OpenTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("OPenTaskID");

        builder.Property(e => e.OpeningBalance)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PaymentId).HasColumnName("PaymentID");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.RegNum).HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Shortage)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ShortageId)
            .HasColumnName("ShortageID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Username).HasMaxLength(50);
    }
}