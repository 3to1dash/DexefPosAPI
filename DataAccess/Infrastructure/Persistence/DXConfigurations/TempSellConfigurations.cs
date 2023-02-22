using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TempSellConfiguration : IEntityTypeConfiguration<TempSell>
{


    public void Configure(EntityTypeBuilder<TempSell> builder)
    {
        builder.HasNoKey();

        builder.ToTable("temp_sell");

        builder.HasIndex(e => new { e.Id, e.Itemid, e.Dt, e.Trancode, e.Qty, e.Itemcost }, "ClusteredIndex-20200520-233935")
            .IsClustered();

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Itemcost)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("itemcost");

        builder.Property(e => e.Itemid).HasColumnName("itemid");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.Qty)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("qty");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Trancode)
            .HasMaxLength(3)
            .IsUnicode(false)
            .HasColumnName("trancode");
    }
}