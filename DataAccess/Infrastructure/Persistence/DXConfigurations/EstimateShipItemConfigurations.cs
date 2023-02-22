using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EstimateShipItemConfiguration : IEntityTypeConfiguration<EstimateShipItem>
{


    public void Configure(EntityTypeBuilder<EstimateShipItem> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.EstimateId).HasColumnName("EstimateID");

        builder.Property(e => e.IsClosed).HasDefaultValueSql("((0))");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ShipDt).HasColumnType("datetime");

        builder.Property(e => e.Spent)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.UpdateBy).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}