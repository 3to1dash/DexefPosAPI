using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ChequeOutInfoConfiguration : IEntityTypeConfiguration<ChequeOutInfo>
{


    public void Configure(EntityTypeBuilder<ChequeOutInfo> builder)
    {
        builder.ToTable("Cheque_OutInfo");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Amount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.BankDone).HasDefaultValueSql("((0))");

        builder.Property(e => e.BankDoneDt)
            .HasColumnType("datetime")
            .HasColumnName("BankDoneDT");

        builder.Property(e => e.BankId).HasColumnName("BankID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CheckNumber).HasMaxLength(50);

        builder.Property(e => e.ChequeTotal).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Ctype)
            .HasMaxLength(50)
            .HasColumnName("CType");

        builder.Property(e => e.Currency).HasMaxLength(3);

        builder.Property(e => e.DueDate).HasColumnType("datetime");

        builder.Property(e => e.FromId).HasColumnName("FromID");

        builder.Property(e => e.Note).HasMaxLength(550);

        builder.Property(e => e.Owner).HasMaxLength(450);

        builder.Property(e => e.Rate).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Recieve).HasDefaultValueSql("((0))");

        builder.Property(e => e.Returned).HasDefaultValueSql("((0))");

        builder.Property(e => e.ReturnedDt)
            .HasColumnType("datetime")
            .HasColumnName("ReturnedDT");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ShipTo).HasMaxLength(450);

        builder.Property(e => e.Status).HasMaxLength(50);

        builder.Property(e => e.ToId).HasColumnName("ToID");
    }
}