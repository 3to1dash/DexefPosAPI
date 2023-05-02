using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TeleSalesRevisionConfiguration : IEntityTypeConfiguration<TeleSalesRevision>
{
    public void Configure(EntityTypeBuilder<TeleSalesRevision> builder)
    {
        builder.ToTable("TeleSales_revision");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Active)
            .HasColumnName("active")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Call)
            .HasColumnName("call")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Custid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("custid");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Groupid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("groupid");

        builder.Property(e => e.Note)
            .HasMaxLength(150)
            .HasColumnName("note")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Remain)
            .HasColumnName("remain")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Talab)
            .HasColumnName("talab")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Time)
            .HasMaxLength(50)
            .HasColumnName("time");

        builder.Property(e => e.Workid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("workid");
    }
}