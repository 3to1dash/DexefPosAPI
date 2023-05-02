using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SupportTicketConfiguration : IEntityTypeConfiguration<SupportTicket>
{
    public void Configure(EntityTypeBuilder<SupportTicket> builder)
    {
        builder.ToTable("Support_Ticket");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AlarmDt).HasColumnType("datetime");

        builder.Property(e => e.AnswerPeriod)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.AnswerShip).HasMaxLength(50);

        builder.Property(e => e.AnswerTime).HasColumnType("datetime");

        builder.Property(e => e.AnswerUser)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.CallId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CallID");

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.HasAlarm).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsCust).HasDefaultValueSql("((0))");

        builder.Property(e => e.Note).HasMaxLength(2000);

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Phone1).HasMaxLength(50);

        builder.Property(e => e.Phone2).HasMaxLength(50);

        builder.Property(e => e.PriorityId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("priorityID");

        builder.Property(e => e.ProblemId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ProblemID");

        builder.Property(e => e.ProductId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ProductID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(2050);

        builder.Property(e => e.StartTime).HasColumnType("datetime");

        builder.Property(e => e.StatusId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("StatusID");

        builder.Property(e => e.Subject).HasMaxLength(50);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.ToMe).HasMaxLength(50);

        builder.Property(e => e.Txt)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt1)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt2)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt3)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt4)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt5)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt6)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt7)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt8)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}