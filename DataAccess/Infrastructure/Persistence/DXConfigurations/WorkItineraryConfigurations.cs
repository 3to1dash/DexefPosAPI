using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkItineraryConfiguration : IEntityTypeConfiguration<WorkItinerary>
{


    public void Configure(EntityTypeBuilder<WorkItinerary> builder)
    {
        builder.ToTable("Work_Itinerary");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Address)
            .HasMaxLength(150)
            .HasColumnName("address");

        builder.Property(e => e.Area).HasColumnName("area");

        builder.Property(e => e.Branchid).HasColumnName("branchid");

        builder.Property(e => e.ChkIn).HasDefaultValueSql("((0))");

        builder.Property(e => e.ChkOut).HasDefaultValueSql("((0))");

        builder.Property(e => e.Closed).HasDefaultValueSql("((0))");

        builder.Property(e => e.Done).HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Dt1).HasColumnType("datetime");

        builder.Property(e => e.Dt2).HasColumnType("datetime");

        builder.Property(e => e.Note)
            .HasMaxLength(2000)
            .HasColumnName("note");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.OperatIndex).HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Target)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Type)
            .HasMaxLength(50)
            .HasColumnName("type");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("value")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Workid).HasColumnName("workid");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}