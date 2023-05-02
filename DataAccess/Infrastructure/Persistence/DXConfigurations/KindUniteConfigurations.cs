using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class KindUniteConfiguration : IEntityTypeConfiguration<KindUnite>
{
    public void Configure(EntityTypeBuilder<KindUnite> builder)
    {
        builder.HasKey(e => e.MyId);

        builder.ToTable("Kind_Unite");

        builder.HasIndex(e => e.Code, "IX_Kind_Unite_code_251D2");

        builder.HasIndex(e => e.Levels, "IX_Kind_Unite_levels_01907");

        builder.HasIndex(e => e.Levels, "IX_Kind_Unite_levels_AE53D");

        builder.HasIndex(e => new {e.Sale, e.Levels}, "IX_Kind_Unite_sale_levels_D9686");

        builder.HasIndex(e => e.Unite, "IX_Kind_Unite_unite_BF448");

        builder.HasIndex(e => new {e.KindId, e.Code, e.Unite, e.Currency, e.Qty}, "NonClusteredIndex-20200113-222314");

        builder.HasIndex(e => new {e.Levels, e.Code}, "missing_index_4107_4106_Kind_Unite");

        builder.Property(e => e.MyId)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("MyID");

        builder.Property(e => e.Active).HasDefaultValueSql("((1))");

        builder.Property(e => e.Buy)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("buy")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Calc)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Calc1)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Calc2)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Calc3)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Calc4)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Calc5)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Calc6)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Calc7)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Calc8)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Code)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("code");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.IsUpload).HasDefaultValueSql("((0))");

        builder.Property(e => e.Isselect)
            .HasColumnName("ISSelect")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.Levels)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("levels");

        builder.Property(e => e.Masterbuy)
            .HasColumnName("masterbuy")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Mastersale)
            .HasColumnName("mastersale")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Price1)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("price1")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Price2)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("price2")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Price3)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("price3")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Price4)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("price4")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Price5)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("price5")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Price6)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("price6")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Price7)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("price7")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Price8)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("price8")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Qty)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Quota)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Sale)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("sale")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasColumnName("unite");

        builder.Property(e => e.UniteCode).HasMaxLength(50);

        builder.Property(e => e.VendorCode)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.HasOne(d => d.Kind)
            .WithMany(p => p.KindUnites)
            .HasForeignKey(d => d.KindId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_Kind_Unite_kind");
    }
}