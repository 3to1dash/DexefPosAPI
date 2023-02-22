using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AssetInRentConfiguration : IEntityTypeConfiguration<AssetInRent>
{


    public void Configure(EntityTypeBuilder<AssetInRent> builder)
    {
        builder.ToTable("Asset_InRent");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Assetid).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.Custid).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Fromdt)
            .HasColumnType("datetime")
            .HasColumnName("fromdt");

        builder.Property(e => e.Qty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Todt)
            .HasColumnType("datetime")
            .HasColumnName("todt");
    }
}