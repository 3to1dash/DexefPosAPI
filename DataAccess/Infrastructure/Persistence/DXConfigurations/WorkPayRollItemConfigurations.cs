using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkPayRollItemConfiguration : IEntityTypeConfiguration<WorkPayRollItem>
{
    public void Configure(EntityTypeBuilder<WorkPayRollItem> builder)
    {
        builder.ToTable("Work_PayRollItems");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Accountid).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Arb).HasMaxLength(50);

        builder.Property(e => e.Eng).HasMaxLength(50);

        builder.Property(e => e.Fre).HasMaxLength(50);

        builder.Property(e => e.FromDt).HasColumnType("datetime");

        builder.Property(e => e.IsAdd).HasDefaultValueSql("((1))");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ToDt).HasColumnType("datetime");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");
    }
}