using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BillClassConfiguration : IEntityTypeConfiguration<BillClass>
{


    public void Configure(EntityTypeBuilder<BillClass> builder)
    {
        builder.ToTable("Bill_Class");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Active)
            .HasColumnName("active")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.DatId).HasColumnName("DatID");

        builder.Property(e => e.InstallmentId).HasColumnName("InstallmentID");

        builder.Property(e => e.Isdefault)
            .HasColumnName("ISDefault")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.OptBillAutoNum).HasDefaultValueSql("((0))");

        builder.Property(e => e.OptBillCostCenter).HasDefaultValueSql("((0))");

        builder.Property(e => e.OptBillCurrency).HasDefaultValueSql("((0))");

        builder.Property(e => e.OptBillCust).HasDefaultValueSql("((0))");

        builder.Property(e => e.OptBillDiscountAcc).HasDefaultValueSql("((0))");

        builder.Property(e => e.OptBillDiscountCash).HasDefaultValueSql("((0))");

        builder.Property(e => e.OptBillExtraCost).HasDefaultValueSql("((0))");

        builder.Property(e => e.OptBillExtraFields).HasDefaultValueSql("((0))");

        builder.Property(e => e.OptBillItem).HasDefaultValueSql("((0))");

        builder.Property(e => e.OptBillRep).HasDefaultValueSql("((0))");

        builder.Property(e => e.OptBillShowCustInfo).HasDefaultValueSql("((0))");

        builder.Property(e => e.OptBillSummary).HasDefaultValueSql("((0))");

        builder.Property(e => e.OptBillTax).HasDefaultValueSql("((0))");

        builder.Property(e => e.OptBillType).HasDefaultValueSql("((0))");

        builder.Property(e => e.OptCostId).HasColumnName("OptCostID");

        builder.Property(e => e.OptDueDt)
            .HasColumnName("OptDueDT")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Prefix)
            .HasMaxLength(20)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaxId)
            .HasColumnName("TaxID")
            .HasDefaultValueSql("((0))");
    }
}