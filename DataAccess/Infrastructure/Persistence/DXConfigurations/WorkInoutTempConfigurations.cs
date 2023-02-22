using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkInoutTempConfiguration : IEntityTypeConfiguration<WorkInoutTemp>
{


    public void Configure(EntityTypeBuilder<WorkInoutTemp> builder)
    {
        builder.ToTable("work_inout_temp");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Absent).HasDefaultValueSql("((0))");

        builder.Property(e => e.Chkin)
            .HasColumnName("chkin")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Chkout)
            .HasColumnName("chkout")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Countin)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("countin")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Countout)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("countout")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountFinger)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountLate)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("date")
            .HasColumnName("dt");

        builder.Property(e => e.ExtraDay).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ExtraHour)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.HasDublicate).HasDefaultValueSql("((0))");

        builder.Property(e => e.Movebefore)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("movebefore")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.NotCome).HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TimeOff)
            .HasColumnName("TImeOFF")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Timein).HasColumnName("timein");

        builder.Property(e => e.Timeout).HasColumnName("timeout");

        builder.Property(e => e.Vacation).HasDefaultValueSql("((0))");

        builder.Property(e => e.WorkId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("WorkID");
    }
}