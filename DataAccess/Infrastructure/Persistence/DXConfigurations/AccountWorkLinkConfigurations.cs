using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AccountWorkLinkConfiguration : IEntityTypeConfiguration<AccountWorkLink>
{
    public void Configure(EntityTypeBuilder<AccountWorkLink> builder)
    {
        builder.ToTable("Account_WorkLink");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AbsentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("AbsentID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DayId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("DayID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DaySalary)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("DiscountID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DistributeId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("DistributeID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.HafezId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("HafezID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.HourId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("HourID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.HourSalary)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InstallmentsId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("InstallmentsID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ProduceId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ProduceID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RemainId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("RemainID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SolfaId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("SolfaID")
            .HasDefaultValueSql("((0))");
    }
}