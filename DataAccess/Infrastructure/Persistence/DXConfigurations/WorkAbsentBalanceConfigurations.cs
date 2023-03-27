using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkAbsentBalanceConfiguration : IEntityTypeConfiguration<WorkAbsentBalance>
{
    public void Configure(EntityTypeBuilder<WorkAbsentBalance> builder)
    {
        builder.ToTable("Work_AbsentBalance");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Cutout)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DelayHours)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DelayHoursVal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Departure)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("departure")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DepartureVal)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("departureVal")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Earlydeparture)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.EarlydepartureInDay)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.EarlydepartureVal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Extraday)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("extraday")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Extradayval)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("extradayval")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Extraworkhours)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("extraworkhours")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ExtraworkhoursInDay)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("extraworkhoursInDay")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ExtraworkhoursVal)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("extraworkhoursVal")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Personalvacation)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("personalvacation")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PersonalvacationSeq)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("personalvacationSeq")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PersonalvacationVal)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("personalvacationVal")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.WorkId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("WorkID");
    }
}