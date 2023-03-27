using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TempPurchaseAvgConfiguration : IEntityTypeConfiguration<TempPurchaseAvg>
{
    public void Configure(EntityTypeBuilder<TempPurchaseAvg> builder)
    {
        builder.HasNoKey();

        builder.ToTable("Temp_PurchaseAVG");

        builder.HasIndex(e => e.Id, "IX_Temp_PurchaseAVG_id_1AC50");

        builder.HasIndex(e => new {e.Itemid, e.Dt, e.AvailableQty},
            "IX_Temp_PurchaseAVG_itemid_dt_available_qty_96E72");

        builder.HasIndex(e => new {e.Dt, e.AvailableQty}, "idx_temp_puchase_perf_opt");

        builder.Property(e => e.AvailableQty)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("available_qty");

        builder.Property(e => e.AvgSellingprice)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("avg_sellingprice");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Itemcost).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Itemid).HasColumnName("itemid");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.OrgCost)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("org_cost");

        builder.Property(e => e.OrgQty)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("org_qty");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Trancode)
            .HasMaxLength(3)
            .IsUnicode(false)
            .HasColumnName("trancode");

        builder.Property(e => e.UpdatedCost).HasColumnType("decimal(38, 12)");
    }
}