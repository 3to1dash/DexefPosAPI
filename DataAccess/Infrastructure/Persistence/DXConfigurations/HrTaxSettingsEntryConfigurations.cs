using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrTaxSettingsEntryConfiguration : IEntityTypeConfiguration<HrTaxSettingsEntry>
{
    public void Configure(EntityTypeBuilder<HrTaxSettingsEntry> builder)
    {
        builder.ToTable("HR_TaxSettings_Entry");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.DiscountPerc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.FromValue)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Num).HasDefaultValueSql("((0))");

        builder.Property(e => e.Perc)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.ToValue)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");
    }
}