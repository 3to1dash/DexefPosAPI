using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustDealingConfiguration : IEntityTypeConfiguration<CustDealing>
{


    public void Configure(EntityTypeBuilder<CustDealing> builder)
    {
        builder.ToTable("CustDealing");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Amount).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.BillNum).HasMaxLength(50);

        builder.Property(e => e.Branchid).HasColumnName("branchid");

        builder.Property(e => e.CapitalId).HasColumnName("CapitalID");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .HasColumnName("currency");

        builder.Property(e => e.CustType).HasMaxLength(20);

        builder.Property(e => e.Custid).HasColumnName("custid");

        builder.Property(e => e.Dafter).HasMaxLength(50);

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Iscredit).HasColumnName("iscredit");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Note)
            .HasColumnName("note")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(50);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.TaxPerc).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Taxes).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Total)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("total");

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Value)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("value");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}