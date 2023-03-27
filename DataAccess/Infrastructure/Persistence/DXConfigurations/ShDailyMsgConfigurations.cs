using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ShDailyMsgConfiguration : IEntityTypeConfiguration<ShDailyMsg>
{
    public void Configure(EntityTypeBuilder<ShDailyMsg> builder)
    {
        builder.ToTable("Sh_DailyMsg");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.Custid).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.InBox).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.InQty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.InTotal).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Inprice)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("INPrice");

        builder.Property(e => e.MsgId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("MsgID");

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.OutBox).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.OutPrice).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.OutQty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.OutTotal).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.OutVendor).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Perc).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Root).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}