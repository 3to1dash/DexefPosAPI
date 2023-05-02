using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CStageEntryConfiguration : IEntityTypeConfiguration<CStageEntry>
{
    public void Configure(EntityTypeBuilder<CStageEntry> builder)
    {
        builder.ToTable("C_Stage_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BillIndex)
            .HasColumnName("Bill_index")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Bounes)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.Class)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Currency)
            .HasMaxLength(50)
            .HasColumnName("currency");

        builder.Property(e => e.Custid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("custid");

        builder.Property(e => e.Dafter).HasDefaultValueSql("((0))");

        builder.Property(e => e.Discount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountAcc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountAccPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountableAcc).HasDefaultValueSql("((0))");

        builder.Property(e => e.DisountBounes)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DisountBounesPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.ExprDt)
            .HasColumnType("datetime")
            .HasColumnName("ExprDT");

        builder.Property(e => e.ExtraCost)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ExtraCostPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.IsdiscountPerc)
            .HasColumnName("ISDiscountPerc")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Isfree)
            .HasColumnName("ISFree")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemCost)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ItemID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Kindid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("kindid");

        builder.Property(e => e.Lenght)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Num).HasDefaultValueSql("((0))");

        builder.Property(e => e.Operate)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.PerfectCost)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PerfectCostIn)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("PerfectCostIN")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PreTotal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Price)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Price1)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Price2)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Qty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Quota)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.RowCost)
            .HasMaxLength(4000)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Store).HasMaxLength(50);

        builder.Property(e => e.Tax)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalQty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Weight)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");
    }
}