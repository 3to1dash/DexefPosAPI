using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PrintCustomertotalConfiguration : IEntityTypeConfiguration<PrintCustomertotal>
{
    public void Configure(EntityTypeBuilder<PrintCustomertotal> builder)
    {
        builder.HasNoKey();

        builder.ToTable("Print_customertotal");

        builder.Property(e => e.Code)
            .HasMaxLength(50)
            .HasColumnName("code");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("id");

        builder.Property(e => e.Month1)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("month1");

        builder.Property(e => e.Month10)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("month10");

        builder.Property(e => e.Month11)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("month11");

        builder.Property(e => e.Month12)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("month12");

        builder.Property(e => e.Month2)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("month2");

        builder.Property(e => e.Month3)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("month3");

        builder.Property(e => e.Month4)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("month4");

        builder.Property(e => e.Month5)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("month5");

        builder.Property(e => e.Month6)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("month6");

        builder.Property(e => e.Month7)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("month7");

        builder.Property(e => e.Month8)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("month8");

        builder.Property(e => e.Month9)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("month9");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("total");
    }
}