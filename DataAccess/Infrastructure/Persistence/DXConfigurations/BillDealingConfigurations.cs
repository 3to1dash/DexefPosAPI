using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BillDealingConfiguration : IEntityTypeConfiguration<BillDealing>
{
    public void Configure(EntityTypeBuilder<BillDealing> builder)
    {
        builder.HasNoKey();

        builder.ToView("BillDealing");

        builder.Property(e => e.Bank).HasColumnType("money");

        builder.Property(e => e.BillIndex).HasColumnName("Bill_index");

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.BillTax).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BillTaxDiscount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BillTaxDiscountPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BillTaxPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.DonationAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("id");

        builder.Property(e => e.ItemCount).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Money).HasColumnType("money");

        builder.Property(e => e.Note).HasMaxLength(2000);

        builder.Property(e => e.OtherPayment).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ParentTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("ParentTaskID");

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.Pledge).HasColumnType("money");

        builder.Property(e => e.PoNumber).HasMaxLength(50);

        builder.Property(e => e.PrintedBy).HasMaxLength(50);

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.RecievedMoney).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Remain).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ReturnedRemain).HasColumnType("money");

        builder.Property(e => e.ReviewedBy).HasMaxLength(50);

        builder.Property(e => e.Ship).HasMaxLength(150);

        builder.Property(e => e.ShipAdress).HasMaxLength(150);

        builder.Property(e => e.ShipDue).HasColumnType("datetime");

        builder.Property(e => e.ShipManager).HasMaxLength(150);

        builder.Property(e => e.ShipPhone1).HasMaxLength(50);

        builder.Property(e => e.ShipPhone2).HasMaxLength(50);

        builder.Property(e => e.Status)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.StoreName).HasMaxLength(50);

        builder.Property(e => e.SumBill).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.ToStoreId).HasColumnName("ToStoreID");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TotalDiscount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TotalExtra).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TotalPay).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TransId).HasColumnName("TransID");

        builder.Property(e => e.Txt1)
            .HasMaxLength(150)
            .HasColumnName("txt1");

        builder.Property(e => e.Txt2)
            .HasMaxLength(150)
            .HasColumnName("txt2");

        builder.Property(e => e.Txt3)
            .HasMaxLength(150)
            .HasColumnName("txt3");

        builder.Property(e => e.Txt4)
            .HasMaxLength(150)
            .HasColumnName("txt4");

        builder.Property(e => e.Txt5)
            .HasMaxLength(150)
            .HasColumnName("txt5");

        builder.Property(e => e.Txt6)
            .HasMaxLength(150)
            .HasColumnName("txt6");

        builder.Property(e => e.Txt7)
            .HasMaxLength(150)
            .HasColumnName("txt7");

        builder.Property(e => e.Txt8)
            .HasMaxLength(150)
            .HasColumnName("txt8");

        builder.Property(e => e.UpdatedBy).HasMaxLength(50);

        builder.Property(e => e.Visa).HasColumnType("money");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}