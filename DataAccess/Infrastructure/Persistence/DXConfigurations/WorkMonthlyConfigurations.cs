using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkMonthlyConfiguration : IEntityTypeConfiguration<WorkMonthly>
{
    public void Configure(EntityTypeBuilder<WorkMonthly> builder)
    {
        builder.ToTable("Work_Monthly");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Fri)
            .HasColumnName("fri")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.IsPaid).HasDefaultValueSql("((0))");

        builder.Property(e => e.Mon)
            .HasColumnName("mon")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.MonthId).HasColumnName("MonthID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Sat)
            .HasColumnName("sat")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Sun)
            .HasColumnName("sun")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Thu)
            .HasColumnName("thu")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Tue)
            .HasColumnName("tue")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WeakId).HasColumnName("WeakID");

        builder.Property(e => e.Wed)
            .HasColumnName("wed")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Workid).HasColumnName("workid");
    }
}