using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ShMsgOpenConfiguration : IEntityTypeConfiguration<ShMsgOpen>
{


    public void Configure(EntityTypeBuilder<ShMsgOpen> builder)
    {
        builder.ToTable("Sh_MsgOpen");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Active).HasDefaultValueSql("((1))");

        builder.Property(e => e.Box).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.IsBill).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsBox).HasDefaultValueSql("((1))");

        builder.Property(e => e.IsPartner).HasDefaultValueSql("((0))");

        builder.Property(e => e.IsVendor).HasDefaultValueSql("((0))");

        builder.Property(e => e.Item).HasMaxLength(50);

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Note).HasMaxLength(2000);

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Price).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Qty).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.RegNum)
            .HasColumnType("numeric(18, 0)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Total).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}