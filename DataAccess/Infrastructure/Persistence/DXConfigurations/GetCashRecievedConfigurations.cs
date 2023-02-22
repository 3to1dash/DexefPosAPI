using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class GetCashRecievedConfiguration : IEntityTypeConfiguration<GetCashRecieved>
{


    public void Configure(EntityTypeBuilder<GetCashRecieved> builder)
    {
        builder.HasNoKey();

        builder.ToView("GetCashRecieved");

        builder.Property(e => e.BankPayment).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CapitalId).HasColumnName("CapitalID");

        builder.Property(e => e.CashDiscount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.CashPayment).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dafter).HasMaxLength(20);

        builder.Property(e => e.DeletedBy).HasMaxLength(150);

        builder.Property(e => e.Discount).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.DiscountId).HasColumnName("DiscountID");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.Dthijri)
            .HasMaxLength(19)
            .IsUnicode(false)
            .HasColumnName("DTHijri")
            .IsFixedLength();

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("id");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Name).HasMaxLength(400);

        builder.Property(e => e.Note).HasMaxLength(500);

        builder.Property(e => e.PledgePayment).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.ReNum).HasMaxLength(50);

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.TargetPayment).HasMaxLength(150);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Tax).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.TaxPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.UpdateBy).HasMaxLength(50);

        builder.Property(e => e.Value).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.VisaPayment).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}