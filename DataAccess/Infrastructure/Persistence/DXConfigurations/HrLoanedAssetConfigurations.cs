using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrLoanedAssetConfiguration : IEntityTypeConfiguration<HrLoanedAsset>
{
    public void Configure(EntityTypeBuilder<HrLoanedAsset> builder)
    {
        builder.ToTable("HR_LoanedAssets");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AssetCost).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.Dtloaned)
            .HasColumnType("datetime")
            .HasColumnName("DTLoaned");

        builder.Property(e => e.Dtreturned)
            .HasColumnType("datetime")
            .HasColumnName("DTReturned");

        builder.Property(e => e.EmplId).HasColumnName("EmplID");

        builder.Property(e => e.GroupId).HasColumnName("GroupID");

        builder.Property(e => e.Name)
            .HasMaxLength(150)
            .HasColumnName("name");

        builder.Property(e => e.Note).HasMaxLength(500);

        builder.Property(e => e.Rate)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Serial).HasMaxLength(50);
    }
}