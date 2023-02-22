using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CpuConfiguration : IEntityTypeConfiguration<Cpu>
{


    public void Configure(EntityTypeBuilder<Cpu> builder)
    {
        builder.ToTable("CPU");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.Cpu1)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CPU");

        builder.Property(e => e.IsOn).HasDefaultValueSql("((0))");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}