using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ChequeInInfoConfiguration : IEntityTypeConfiguration<ChequeInInfo>
{
    public void Configure(EntityTypeBuilder<ChequeInInfo> builder)
    {
        builder.ToTable("Cheque_InInfo");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Amount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.BankDone).HasDefaultValueSql("((0))");

        builder.Property(e => e.BankDoneDt)
            .HasColumnType("datetime")
            .HasColumnName("BankDoneDT");

        builder.Property(e => e.BankDoneId).HasColumnName("BankDoneID");

        builder.Property(e => e.BankName)
            .HasMaxLength(150)
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CheckNumber).HasMaxLength(50);

        builder.Property(e => e.ChequeTotal).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Ctype)
            .HasMaxLength(50)
            .HasColumnName("CType");

        builder.Property(e => e.Currency).HasMaxLength(3);

        builder.Property(e => e.CustReturn).HasDefaultValueSql("((0))");

        builder.Property(e => e.DeletedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.DueDate).HasColumnType("datetime");

        builder.Property(e => e.FromId).HasColumnName("FromID");

        builder.Property(e => e.GoBank).HasDefaultValueSql("((0))");

        builder.Property(e => e.GoBankCapitalId).HasColumnName("GoBankCapitalID");

        builder.Property(e => e.GoBankId)
            .HasColumnName("GoBankID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.GoCust).HasDefaultValueSql("((0))");

        builder.Property(e => e.GoCustId)
            .HasColumnName("GoCustID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Note).HasMaxLength(550);

        builder.Property(e => e.Owner).HasMaxLength(450);

        builder.Property(e => e.Rate).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Recieve).HasDefaultValueSql("((0))");

        builder.Property(e => e.RecieveDt)
            .HasColumnType("datetime")
            .HasColumnName("RecieveDT");

        builder.Property(e => e.Returned).HasDefaultValueSql("((0))");

        builder.Property(e => e.ReturnedAccountId).HasColumnName("ReturnedAccountID");

        builder.Property(e => e.ReturnedBankId).HasColumnName("ReturnedBankID");

        builder.Property(e => e.ReturnedDt)
            .HasColumnType("datetime")
            .HasColumnName("ReturnedDT");

        builder.Property(e => e.ReturnedId).HasColumnName("ReturnedID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ShipTo).HasMaxLength(450);

        builder.Property(e => e.Status).HasMaxLength(50);

        builder.Property(e => e.ToId).HasColumnName("ToID");
    }
}