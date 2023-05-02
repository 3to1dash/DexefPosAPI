using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PurchaseImportConfiguration : IEntityTypeConfiguration<PurchaseImport>
{
    public void Configure(EntityTypeBuilder<PurchaseImport> builder)
    {
        builder.ToTable("PurchaseImport");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Account)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Accountid).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Bank)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BankId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BankID");

        builder.Property(e => e.BillDat)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("BillDAT")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillDatid)
            .HasColumnName("BillDATID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillDatperc)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("BillDATPerc")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillDiscount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillDiscountId)
            .HasColumnName("BillDiscountID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillExtraCost)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillExtraCostId)
            .HasColumnName("BillExtraCostID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillIndex)
            .HasColumnName("Bill_index")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillItemExtraCost)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillItemExtraCostId)
            .HasColumnName("BillItemExtraCostID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillItemExtraCostPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillTax)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillTaxId)
            .HasColumnName("BillTaxID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BillTaxPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.CheckBankId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CheckBankID");

        builder.Property(e => e.Checks)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ClassId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ClassID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.CurrencyTotal)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("Currency_total")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CustId)
            .HasColumnName("CustID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dafter).HasDefaultValueSql("((0))");

        builder.Property(e => e.DayIndex)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountAcc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountDue)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountItem).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.DiscountItemBounes)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountItemBounesId)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("DiscountItemBounesID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountItemId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("DiscountItemID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.Installment)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.IsDone).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsIn).HasColumnName("IsIN");

        builder.Property(e => e.Isacc)
            .HasColumnName("ISAcc")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemCount).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.ItemTotal)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Money)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.MoneyId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("MoneyID");

        builder.Property(e => e.MoneyRemain)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.MoneyTotalPaid)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Note).HasMaxLength(2000);

        builder.Property(e => e.Num).HasDefaultValueSql("((0))");

        builder.Property(e => e.OtherPayment)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PaidDisount)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PaidDt).HasColumnType("date");

        builder.Property(e => e.PaidNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.PaidRegNum)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PaidValue)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.Pledge)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PoNumber).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.PointsDiscount)
            .HasColumnType("numeric(18, 5)")
            .HasColumnName("pointsDiscount")
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

        builder.Property(e => e.Renum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rep2).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rep3).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.RepDone).HasDefaultValueSql("((0))");

        builder.Property(e => e.RepId)
            .HasColumnName("RepID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RepTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("RepTaskID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(150);

        builder.Property(e => e.ShipAdress).HasMaxLength(150);

        builder.Property(e => e.ShipDue).HasColumnType("datetime");

        builder.Property(e => e.ShipManager).HasMaxLength(150);

        builder.Property(e => e.ShipPhone1).HasMaxLength(20);

        builder.Property(e => e.ShipPhone2).HasMaxLength(20);

        builder.Property(e => e.ShipTerms).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.ShipVia).HasMaxLength(50);

        builder.Property(e => e.StoreId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("StoreID")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.SumBill).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TaxExtra)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxExtraPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxExtraid)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxType).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Totaldiscount)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("totaldiscount")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Totalextra)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("totalextra")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Totalmoney)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("totalmoney")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Txt1)
            .HasMaxLength(50)
            .HasColumnName("txt1")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt2)
            .HasMaxLength(50)
            .HasColumnName("txt2")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt3)
            .HasMaxLength(50)
            .HasColumnName("txt3")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt4)
            .HasMaxLength(50)
            .HasColumnName("txt4")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt5)
            .HasMaxLength(50)
            .HasColumnName("txt5")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt6)
            .HasMaxLength(50)
            .HasColumnName("txt6")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt7)
            .HasMaxLength(50)
            .HasColumnName("txt7")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt8)
            .HasMaxLength(50)
            .HasColumnName("txt8")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Type)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Visa)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.VisaId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("VisaID");

        builder.Property(e => e.WorkRegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}