using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkDiscountConfiguration : IEntityTypeConfiguration<WorkDiscount>
{
    public void Configure(EntityTypeBuilder<WorkDiscount> builder)
    {
        builder.ToTable("Work_Discount");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Branchid).HasColumnName("branchid");

        builder.Property(e => e.Closed).HasDefaultValueSql("((0))");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.Done).HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Note)
            .HasMaxLength(2000)
            .HasColumnName("note");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Type)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("type");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("value");

        builder.Property(e => e.Workid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("workid");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}