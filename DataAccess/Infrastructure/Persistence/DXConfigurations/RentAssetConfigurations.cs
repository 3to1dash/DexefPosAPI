using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RentAssetConfiguration : IEntityTypeConfiguration<RentAsset>
{


    public void Configure(EntityTypeBuilder<RentAsset> builder)
    {
        builder.ToTable("RentAsset");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.IncomeId).HasColumnName("IncomeID");

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.Note).HasMaxLength(450);

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.ParentId).HasColumnName("ParentID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SpendId).HasColumnName("SpendID");

        builder.Property(e => e.Txt1).HasMaxLength(150);

        builder.Property(e => e.Txt2).HasMaxLength(150);

        builder.Property(e => e.Txt3).HasMaxLength(150);

        builder.Property(e => e.Txt4).HasMaxLength(150);

        builder.Property(e => e.Txt5).HasMaxLength(150);

        builder.Property(e => e.Txt6).HasMaxLength(150);

        builder.Property(e => e.Txt7).HasMaxLength(150);

        builder.Property(e => e.Txt8).HasMaxLength(150);
    }
}