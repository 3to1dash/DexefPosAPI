using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TransStockConfiguration : IEntityTypeConfiguration<TransStock>
{


    public void Configure(EntityTypeBuilder<TransStock> builder)
    {
        builder.HasNoKey();

        builder.ToTable("trans_stock");

        builder.Property(e => e.AttentionVal)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("attention_val")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Buy)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("buy")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Buy1)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("buy1")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Buy2)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("buy2")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Code)
            .HasMaxLength(50)
            .HasColumnName("code");

        builder.Property(e => e.Detail)
            .HasMaxLength(50)
            .HasColumnName("detail")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Enterdate)
            .HasColumnType("datetime")
            .HasColumnName("enterdate");

        builder.Property(e => e.ExpDate)
            .HasColumnType("datetime")
            .HasColumnName("exp_date")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Fill).HasColumnName("fill");

        builder.Property(e => e.GroupKind)
            .HasMaxLength(50)
            .HasColumnName("group_kind")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.GroupLink)
            .HasMaxLength(50)
            .HasColumnName("group_link");

        builder.Property(e => e.Kind)
            .HasMaxLength(50)
            .HasColumnName("kind")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Minbuy)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("minbuy")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Minsale)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("minsale")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.RequireVal)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("require_val")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Sale)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("sale")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Sale1)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("sale1")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Sale2)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("sale2")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.StockAdress)
            .HasMaxLength(50)
            .HasColumnName("stock_adress")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.StockName)
            .HasMaxLength(50)
            .HasColumnName("stock_name")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.StockNum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("stock_num");

        builder.Property(e => e.Type)
            .HasMaxLength(50)
            .HasColumnName("type");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasColumnName("unite")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Unite1)
            .HasMaxLength(50)
            .HasColumnName("unite1")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Unite2)
            .HasMaxLength(50)
            .HasColumnName("unite2")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ValUnite)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("val_unite")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ValUnite1)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("val_unite1")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ValUnite2)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("val_unite2")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Valsub1)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("valsub1")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Valsub2)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("valsub2")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WorkNum)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("work_num");
    }
}