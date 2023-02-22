using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyPotenialConfiguration : IEntityTypeConfiguration<DailyPotenial>
{


    public void Configure(EntityTypeBuilder<DailyPotenial> builder)
    {
        builder.ToTable("Daily_Potenial");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.FollowWith).HasMaxLength(50);

        builder.Property(e => e.Note).HasMaxLength(2000);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(550);

        builder.Property(e => e.StatusId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("StatusID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TicketId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("TicketID");

        builder.Property(e => e.Type).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}