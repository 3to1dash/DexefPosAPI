using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PointPatnerPayConfiguration : IEntityTypeConfiguration<PointPatnerPay>
{
    public void Configure(EntityTypeBuilder<PointPatnerPay> builder)
    {
        builder.ToTable("Point_PatnerPay");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Num).HasDefaultValueSql("((0))");

        builder.Property(e => e.PartnerId).HasColumnName("Partner_Id");

        builder.Property(e => e.Points).HasColumnType("decimal(18, 0)");

        builder.Property(e => e.PointsIn)
            .HasColumnType("decimal(18, 0)")
            .HasColumnName("Points_In");

        builder.Property(e => e.PointsOut)
            .HasColumnType("decimal(18, 0)")
            .HasColumnName("Points_Out");

        builder.Property(e => e.PointsPerMoney).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SliceId).HasColumnName("SliceID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("Task_ID");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}