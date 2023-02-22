using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SalaryItemTypeConfiguration : IEntityTypeConfiguration<SalaryItemType>
{


    public void Configure(EntityTypeBuilder<SalaryItemType> builder)
    {
        builder.ToTable("SalaryItem_Types");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.CalcFor).HasMaxLength(50);

        builder.Property(e => e.CalcId).HasColumnName("CalcID");

        builder.Property(e => e.ItemType).HasMaxLength(50);

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Note).HasMaxLength(450);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Sdays).HasColumnName("SDays");

        builder.Property(e => e.Speriod)
            .HasMaxLength(50)
            .HasColumnName("SPeriod");
    }
}