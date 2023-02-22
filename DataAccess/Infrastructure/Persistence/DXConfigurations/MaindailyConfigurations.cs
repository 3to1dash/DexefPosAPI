using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class MaindailyConfiguration : IEntityTypeConfiguration<Maindaily>
{


    public void Configure(EntityTypeBuilder<Maindaily> builder)
    {
        builder.HasNoKey();

        builder.ToTable("maindaily");

        builder.Property(e => e.Credit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("credit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dafter)
            .HasMaxLength(20)
            .HasColumnName("dafter");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.Debit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("debit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Fromaccount)
            .HasMaxLength(50)
            .HasColumnName("fromaccount");

        builder.Property(e => e.Fromnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("fromnum");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Toaccount)
            .HasMaxLength(50)
            .HasColumnName("toaccount");

        builder.Property(e => e.Tonum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("tonum");
    }
}