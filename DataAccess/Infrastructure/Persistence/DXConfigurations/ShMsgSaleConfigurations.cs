using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ShMsgSaleConfiguration : IEntityTypeConfiguration<ShMsgSale>
{


    public void Configure(EntityTypeBuilder<ShMsgSale> builder)
    {
        builder.ToTable("Sh_MsgSale");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BillTotal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Box)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BoxRegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.BoxRent)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BoxRentTotal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BoxSum)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BoxTotal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchBoxId)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("BranchBoxID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CustBoxId)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("CustBoxID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.IncomeId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("IncomeID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.IsBox).HasDefaultValueSql("((1))");

        builder.Property(e => e.IsBoxed).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsPaid).HasDefaultValueSql("((0))");

        builder.Property(e => e.MsgId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("MsgID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.MsgIsBox).HasDefaultValueSql("((1))");

        builder.Property(e => e.MsgName).HasMaxLength(50);

        builder.Property(e => e.Note).HasDefaultValueSql("('')");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Paid)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PaidValue)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Perc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PercId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("PercID");

        builder.Property(e => e.PercValue)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Price)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Qty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ReBox)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ReBoxRent)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RegNum)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Remain)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RemainBox)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RemainBoxRent)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("RentID");

        builder.Property(e => e.RentPrice)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RentValue)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Root)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RootTotal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ShipDue).HasColumnType("datetime");

        builder.Property(e => e.StorageId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("StorageID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.StorageRentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("StorageRentID");

        builder.Property(e => e.TermId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("TermID");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalBillBox)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.VendorId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("VendorID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.VendorRemain)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.VendorTotal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.VendorValue)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WorkId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("WorkID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}