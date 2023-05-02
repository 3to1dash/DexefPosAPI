using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindNoteConfiguration : IEntityTypeConfiguration<KindNote>
{
    public void Configure(EntityTypeBuilder<KindNote> builder)
    {
        builder.ToTable("Kind_Note");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("id");

        builder.Property(e => e.Active).HasColumnName("active");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.ItemId).HasColumnName("ItemID");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.Note)
            .HasMaxLength(50)
            .HasColumnName("note");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");
    }
}