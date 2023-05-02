using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SaleEstimateConfiguration : IEntityTypeConfiguration<SaleEstimate>
{
    public void Configure(EntityTypeBuilder<SaleEstimate> builder)
    {
        builder.ToTable("SaleEstimate");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Account)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Attarched).HasDefaultValueSql("((0))");

        builder.Property(e => e.Bank)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillDat)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("BillDAT")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillDiscount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BillDiscountPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BillExtraCost)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillIndex)
            .HasColumnName("Bill_index")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.BillTax)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillTaxDiscount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BillTaxDiscountId)
            .HasColumnName("BillTaxDiscountID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillTaxDiscountPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BillTaxId)
            .HasColumnName("BillTaxID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillTaxPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CashDiscount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CashDiscountId)
            .HasColumnName("CashDiscountID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CashDiscountPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.CreditLetterId).HasColumnName("CreditLetterID");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.CustId)
            .HasColumnName("CustID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("dealing");

        builder.Property(e => e.DeletedBy).HasMaxLength(50);

        builder.Property(e => e.DonationAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.DonationId).HasColumnName("DonationID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.FreeAccountId).HasColumnName("FreeAccountID");

        builder.Property(e => e.FreeDiscount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.InsuranceAccountId).HasColumnName("InsuranceAccountID");

        builder.Property(e => e.InsuranceDiscount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.InsurancePerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.ItemCount).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.ItemExtraCost).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Money)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Note).HasMaxLength(2000);

        builder.Property(e => e.Num).HasDefaultValueSql("((0))");

        builder.Property(e => e.OtherPayment)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ParentTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("ParentTaskID");

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.Pledge)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PoNumber).HasMaxLength(50);

        builder.Property(e => e.PointsDiscount)
            .HasColumnType("numeric(18, 5)")
            .HasColumnName("pointsDiscount")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Prefix)
            .HasMaxLength(20)
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

        builder.Property(e => e.Printed).HasDefaultValueSql("((0))");

        builder.Property(e => e.PrintedBy).HasMaxLength(50);

        builder.Property(e => e.ProductionId).HasColumnName("ProductionID");

        builder.Property(e => e.QtyDiscount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.QtyDiscountId)
            .HasColumnName("QtyDiscountID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RecievedMoney)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Remain)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RepDone).HasDefaultValueSql("((0))");

        builder.Property(e => e.RepId)
            .HasColumnName("RepID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RepTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("RepTaskID");

        builder.Property(e => e.ReturnedRemain)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Reviewed).HasDefaultValueSql("((0))");

        builder.Property(e => e.ReviewedBy).HasMaxLength(50);

        builder.Property(e => e.RewardPoints)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RoundAmount).HasColumnType("money");

        builder.Property(e => e.RoundId).HasColumnName("RoundID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(150);

        builder.Property(e => e.ShipAdress).HasMaxLength(150);

        builder.Property(e => e.ShipDue).HasColumnType("datetime");

        builder.Property(e => e.ShipManager).HasMaxLength(150);

        builder.Property(e => e.ShipPhone1).HasMaxLength(20);

        builder.Property(e => e.ShipPhone2).HasMaxLength(20);

        builder.Property(e => e.ShipVia).HasMaxLength(50);

        builder.Property(e => e.Status)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.StatusId).HasColumnName("StatusID");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.StyleId).HasColumnName("StyleID");

        builder.Property(e => e.SumBill).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TaxExtraPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ToBranchId)
            .HasColumnName("ToBranchID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ToStoreId)
            .HasColumnName("ToStoreID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalDiscount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalExtra)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalPay)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TransId).HasColumnName("TransID");

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

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UploadDate).HasColumnType("datetime");

        builder.Property(e => e.Uuid)
            .HasMaxLength(50)
            .HasColumnName("UUID");

        builder.Property(e => e.Uustatus)
            .HasMaxLength(50)
            .HasColumnName("UUStatus");

        builder.Property(e => e.Visa)
            .HasColumnType("money")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.VisitCost).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.VisitCostId).HasColumnName("VisitCostID");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}