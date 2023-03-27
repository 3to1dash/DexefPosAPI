using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class GetStorageSendMoneyConfiguration : IEntityTypeConfiguration<GetStorageSendMoney>
{
    public void Configure(EntityTypeBuilder<GetStorageSendMoney> builder)
    {
        builder.HasNoKey();

        builder.ToView("GetStorage_SendMoney");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Currency).HasMaxLength(3);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.FromBranch).HasMaxLength(50);

        builder.Property(e => e.FromId).HasColumnName("FromID");

        builder.Property(e => e.FromRate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.FromTotal).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Note).HasMaxLength(2000);

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.RefNumber).HasMaxLength(50);

        builder.Property(e => e.Ship).HasMaxLength(250);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.TaxPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Taxes).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ToBranch).HasMaxLength(50);

        builder.Property(e => e.ToBranchId).HasColumnName("ToBranchID");

        builder.Property(e => e.ToCurrency).HasMaxLength(3);

        builder.Property(e => e.ToId).HasColumnName("ToID");

        builder.Property(e => e.ToRate).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.ToTotal).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TransferId).HasColumnName("TransferID");

        builder.Property(e => e.TransferPerc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.TransferPercId).HasColumnName("TransferPercID");

        builder.Property(e => e.TransferValue).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.UpdateBy).HasMaxLength(50);

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("value");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}