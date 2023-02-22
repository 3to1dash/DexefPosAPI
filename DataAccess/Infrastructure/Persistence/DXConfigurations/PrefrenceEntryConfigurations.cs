using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class PrefrenceEntryConfiguration : IEntityTypeConfiguration<PrefrenceEntry>
{


    public void Configure(EntityTypeBuilder<PrefrenceEntry> builder)
    {
        builder.ToTable("Prefrence_Entry");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SubStr).HasMaxLength(50);

        builder.HasOne(d => d.NameNavigation)
            .WithMany(p => p.PrefrenceEntries)
            .HasForeignKey(d => d.Name)
            .HasConstraintName("FK_Prefrence_Entry_Prefrence");
    }
}