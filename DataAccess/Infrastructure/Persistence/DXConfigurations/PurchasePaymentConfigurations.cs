using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PurchasePaymentConfiguration : IEntityTypeConfiguration<PurchasePayment>
{
    public void Configure(EntityTypeBuilder<PurchasePayment> builder)
    {
        builder.ToTable("Purchase_Payment");

        builder.HasIndex(e => e.TaskId, "IX_Purchase_Payment_TaskID_1599E");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Amount)
            .HasColumnType("decimal(32, 17)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Currency)
            .HasMaxLength(5)
            .IsUnicode(false);

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.InvoiceCurrency)
            .HasMaxLength(5)
            .IsUnicode(false);

        builder.Property(e => e.InvoiceRate)
            .HasColumnType("decimal(32, 17)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.PayTaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("PayTaskID");

        builder.Property(e => e.PaymentId).HasColumnName("PaymentID");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(32, 17)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RecievedMoney)
            .HasColumnType("decimal(32, 17)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RemainMoney)
            .HasColumnType("decimal(32, 17)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ReturnedMoney)
            .HasColumnType("decimal(32, 17)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Total)
            .HasColumnType("decimal(32, 17)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalRecievedMoney)
            .HasColumnType("decimal(32, 17)")
            .HasDefaultValueSql("((0))");
    }
}