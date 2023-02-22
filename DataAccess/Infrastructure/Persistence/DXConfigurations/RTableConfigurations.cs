using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RTableConfiguration : IEntityTypeConfiguration<RTable>
{


    public void Configure(EntityTypeBuilder<RTable> builder)
    {
        builder.ToTable("R_Tables");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.FloorId).HasColumnName("FloorID");

        builder.Property(e => e.IsBusy).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsLink).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsReserved).HasDefaultValueSql("((0))");

        builder.Property(e => e.Link).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.RegNum)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");
    }
}