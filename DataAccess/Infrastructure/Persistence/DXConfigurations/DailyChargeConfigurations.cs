using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyChargeConfiguration : IEntityTypeConfiguration<DailyCharge>
{
    public void Configure(EntityTypeBuilder<DailyCharge> builder)
    {
        builder.ToTable("DailyCharge");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Amount)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CarNumber).HasMaxLength(50);

        builder.Property(e => e.Currency).HasMaxLength(50);

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.DiscountId).HasColumnName("DiscountID");

        builder.Property(e => e.DiscountPerc)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Driver).HasMaxLength(50);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.EndDate).HasColumnType("datetime");

        builder.Property(e => e.Ended).HasDefaultValueSql("((0))");

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.Rate)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ReturnMoney)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StartDate).HasColumnType("datetime");

        builder.Property(e => e.Started).HasDefaultValueSql("((0))");

        builder.Property(e => e.SumBill)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TotalAmount)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");
    }
}