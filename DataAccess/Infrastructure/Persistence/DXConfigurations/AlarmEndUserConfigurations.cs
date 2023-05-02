using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AlarmEndUserConfiguration : IEntityTypeConfiguration<AlarmEndUser>
{
    public void Configure(EntityTypeBuilder<AlarmEndUser> builder)
    {
        builder.ToTable("Alarm_EndUser");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId)
            .HasColumnName("AccountID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.AlarmType).HasMaxLength(50);

        builder.Property(e => e.BranchId)
            .HasColumnName("BranchID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.FiedName).HasMaxLength(50);

        builder.Property(e => e.Important).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsRead).HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemId).HasColumnName("ItemID");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SolveDt)
            .HasColumnType("datetime")
            .HasColumnName("SolveDT");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.UserName).HasMaxLength(50);
    }
}