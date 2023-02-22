using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TempPurchaseConfiguration : IEntityTypeConfiguration<TempPurchase>
{


    public void Configure(EntityTypeBuilder<TempPurchase> builder)
    {
        builder.ToTable("temp_purchase");

        builder.HasIndex(e => new { e.Itemid, e.AvailableQty }, "IX_temp_purchase_itemid_available_qty_4F55D");

        builder.HasIndex(e => new { e.Trancode, e.Dealing }, "IX_temp_purchase_trancode_Dealing_E0D4B");

        builder.HasIndex(e => new { e.Trancode, e.Itemcost }, "IX_temp_purchase_trancode_Itemcost_04CEB");

        builder.HasIndex(e => new { e.Id, e.Itemid, e.Dt, e.Trancode, e.OrgQty, e.AvailableQty, e.OrgCost, e.Itemcost }, "NonClusteredIndex-20200520-234333");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");

        builder.Property(e => e.AvailableQty)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("available_qty");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Itemcost).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Itemid).HasColumnName("itemid");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.OrgCost)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("org_cost");

        builder.Property(e => e.OrgQty)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("org_qty");

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