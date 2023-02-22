using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindQoutaEntryConfiguration : IEntityTypeConfiguration<KindQoutaEntry>
{


    public void Configure(EntityTypeBuilder<KindQoutaEntry> builder)
    {
        builder.ToTable("Kind_QoutaEntry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.FromDt)
            .HasColumnType("datetime")
            .HasColumnName("FromDT");

        builder.Property(e => e.Isall).HasColumnName("ISAll");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.QoutaId).HasColumnName("QoutaID");

        builder.Property(e => e.Qty).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ToDt)
            .HasColumnType("datetime")
            .HasColumnName("ToDT");

        builder.Property(e => e.TotalQty).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Unite).HasMaxLength(50);

        builder.Property(e => e.UniteQty).HasColumnType("numeric(18, 5)");
    }
}