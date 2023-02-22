using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AssetRecalcConfiguration : IEntityTypeConfiguration<AssetRecalc>
{


    public void Configure(EntityTypeBuilder<AssetRecalc> builder)
    {
        builder.ToTable("Asset_Recalc");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AssetId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("AssetID");

        builder.Property(e => e.BranchId).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.CostId).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Distroydiscoutid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("distroydiscoutid");

        builder.Property(e => e.Distroyid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("distroyid");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Newvalue)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("newvalue");

        builder.Property(e => e.Note)
            .HasColumnName("note")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Oldvalue)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("oldvalue");

        builder.Property(e => e.Regnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("regnum");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Value)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}