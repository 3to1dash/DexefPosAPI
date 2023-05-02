using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TempSellAvgConfiguration : IEntityTypeConfiguration<TempSellAvg>
{
    public void Configure(EntityTypeBuilder<TempSellAvg> builder)
    {
        builder.HasNoKey();

        builder.ToTable("Temp_SellAVG");

        builder.HasIndex(e => e.NewCost, "IX_Temp_SellAVG_NewCost_23AB1");

        builder.HasIndex(e => e.SellId, "IX_Temp_SellAVG_SellId_D4CAC");

        builder.HasIndex(e => new {e.Itemid, e.TaskId, e.NewCost}, "IX_Temp_SellAVG_itemid_TaskID_NewCost_6681B");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Itemcost)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("itemcost");

        builder.Property(e => e.Itemid).HasColumnName("itemid");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.NewCost).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Qty)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("qty");

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
    }
}