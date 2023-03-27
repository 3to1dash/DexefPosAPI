using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AssetConfiguration : IEntityTypeConfiguration<Asset>
{
    public void Configure(EntityTypeBuilder<Asset> builder)
    {
        builder.ToTable("Asset");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Active)
            .HasColumnName("active")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Adress)
            .HasMaxLength(250)
            .HasColumnName("adress");

        builder.Property(e => e.Arname).HasMaxLength(150);

        builder.Property(e => e.Assetid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("assetid");

        builder.Property(e => e.Balance)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("balance")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Billnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("billnum")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.Capitalid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("capitalid");

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Cost)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("cost")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CostId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CostID");

        builder.Property(e => e.Credit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("credit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Custid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("custid");

        builder.Property(e => e.Days)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("days");

        builder.Property(e => e.Debit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("debit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Destroyid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("destroyid");

        builder.Property(e => e.Destroyperc)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("destroyperc")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Destroyval)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("destroyval")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DistroyDiscountId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("DistroyDiscountID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Dtstart)
            .HasColumnType("datetime")
            .HasColumnName("dtstart");

        builder.Property(e => e.EnName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.FixedPrice).HasDefaultValueSql("((0))");

        builder.Property(e => e.FrName).HasMaxLength(150);

        builder.Property(e => e.Fromtime)
            .HasColumnType("datetime")
            .HasColumnName("fromtime");

        builder.Property(e => e.IsRent).HasDefaultValueSql("((1))");

        builder.Property(e => e.IscustomerExpense)
            .HasColumnName("ISCustomerExpense")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Isnew).HasColumnName("ISNew");

        builder.Property(e => e.Lbl)
            .HasMaxLength(10)
            .HasColumnName("lbl");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.OpenCost)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OpenQty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Pay)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("pay")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PayType).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Payid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("payid");

        builder.Property(e => e.Price)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.QtyRent)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Regnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("regnum");

        builder.Property(e => e.Remain)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("remain")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Site)
            .HasMaxLength(250)
            .HasColumnName("site");

        builder.Property(e => e.State)
            .HasMaxLength(250)
            .HasColumnName("state");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("total")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalCost)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalVal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Totaldestroy)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("totaldestroy");

        builder.Property(e => e.Totime)
            .HasColumnType("datetime")
            .HasColumnName("totime");

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt1)
            .HasMaxLength(150)
            .HasColumnName("txt1")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt2)
            .HasMaxLength(150)
            .HasColumnName("txt2")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt3)
            .HasMaxLength(150)
            .HasColumnName("txt3")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt4)
            .HasMaxLength(150)
            .HasColumnName("txt4")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt5)
            .HasMaxLength(150)
            .HasColumnName("txt5")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt6)
            .HasMaxLength(150)
            .HasColumnName("txt6")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt7)
            .HasMaxLength(150)
            .HasColumnName("txt7")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt8)
            .HasMaxLength(150)
            .HasColumnName("txt8")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UniteCost)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Workid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("workid");
    }
}