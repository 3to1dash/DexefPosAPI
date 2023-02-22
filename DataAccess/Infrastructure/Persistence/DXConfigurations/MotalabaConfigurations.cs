using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class MotalabaConfiguration : IEntityTypeConfiguration<Motalaba>
{


    public void Configure(EntityTypeBuilder<Motalaba> builder)
    {
        builder.ToTable("Motalaba");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Custid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("custid");

        builder.Property(e => e.Days)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("days")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Dt1)
            .HasColumnType("datetime")
            .HasColumnName("dt1");

        builder.Property(e => e.Dt2)
            .HasColumnType("datetime")
            .HasColumnName("dt2");

        builder.Property(e => e.Dtrequire)
            .HasColumnType("datetime")
            .HasColumnName("dtrequire");

        builder.Property(e => e.Khasm)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("khasm")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Note).HasColumnName("note");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Optall)
            .HasColumnName("optall")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Optexist)
            .HasColumnName("optexist")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Optrecieved)
            .HasColumnName("optrecieved")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Perccheck)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("perccheck")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Percval)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("percval")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("total")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}