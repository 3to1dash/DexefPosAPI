using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyDateConfiguration : IEntityTypeConfiguration<DailyDate>
{


    public void Configure(EntityTypeBuilder<DailyDate> builder)
    {
        builder.ToTable("dailyDates");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.DateId).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Note)
            .HasMaxLength(350)
            .HasColumnName("note");

        builder.Property(e => e.Renum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("renum");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Salesman).HasMaxLength(50);

        builder.Property(e => e.Telesales).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}