using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkAttendConfiguration : IEntityTypeConfiguration<WorkAttend>
{
    public void Configure(EntityTypeBuilder<WorkAttend> builder)
    {
        builder.ToTable("Work_Attend");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Absent).HasDefaultValueSql("((0))");

        builder.Property(e => e.AbsentVal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Alarm).HasDefaultValueSql("((0))");

        builder.Property(e => e.Award).HasDefaultValueSql("((0))");

        builder.Property(e => e.AwardVal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CheckInTime).HasColumnType("datetime");

        builder.Property(e => e.CheckOutTime).HasColumnType("datetime");

        builder.Property(e => e.Delay).HasDefaultValueSql("((0))");

        builder.Property(e => e.DelayVal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Departure).HasDefaultValueSql("((0))");

        builder.Property(e => e.DepartureVal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Discount).HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountVal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt).HasColumnType("date");

        builder.Property(e => e.ExtraDay)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ExtraHour)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Incentive).HasDefaultValueSql("((0))");

        builder.Property(e => e.IncentiveVal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.IsPaid).HasDefaultValueSql("((0))");

        builder.Property(e => e.Itinerary).HasDefaultValueSql("((0))");

        builder.Property(e => e.ItineraryChkIn).HasDefaultValueSql("((0))");

        builder.Property(e => e.ItineraryChkOut).HasDefaultValueSql("((0))");

        builder.Property(e => e.ItineraryVal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LogIn)
            .HasColumnName("LogIN")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LogOut).HasDefaultValueSql("((0))");

        builder.Property(e => e.LoginVal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LogoutVal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Personalvacation)
            .HasColumnName("personalvacation")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ProductItems)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SalesPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Solfa)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TimeOff).HasDefaultValueSql("((0))");

        builder.Property(e => e.Vacation).HasDefaultValueSql("((0))");

        builder.Property(e => e.VacationDiscount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.VacationIndex).HasColumnType("numeric(19, 15)");

        builder.Property(e => e.VacationPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WorkHours)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WorkId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("WorkID");
    }
}