using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkDealingConfiguration : IEntityTypeConfiguration<WorkDealing>
{
    public void Configure(EntityTypeBuilder<WorkDealing> builder)
    {
        builder.HasNoKey();

        builder.ToTable("work_dealing");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("dealing")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Hour)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("hour")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Khasm)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("khasm")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("name")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Solfa)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("solfa")
            .HasDefaultValueSql("((0))");
    }
}