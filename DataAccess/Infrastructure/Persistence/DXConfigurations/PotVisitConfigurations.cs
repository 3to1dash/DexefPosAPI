using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PotVisitConfiguration : IEntityTypeConfiguration<PotVisit>
{


    public void Configure(EntityTypeBuilder<PotVisit> builder)
    {
        builder.ToTable("Pot_Visits");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Custid).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.IsDone).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsRevsion).HasDefaultValueSql("((0))");

        builder.Property(e => e.Iscurrent)
            .HasColumnName("ISCurrent")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Reason).HasDefaultValueSql("('')");

        builder.Property(e => e.Revisionby)
            .HasMaxLength(50)
            .HasColumnName("revisionby")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.VisitDate).HasColumnType("datetime");

        builder.Property(e => e.VisitTime).HasColumnType("datetime");

        builder.Property(e => e.Workid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("workid");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}