using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TransGoConfiguration : IEntityTypeConfiguration<TransGo>
{
    public void Configure(EntityTypeBuilder<TransGo> builder)
    {
        builder.HasNoKey();

        builder.ToTable("trans_go");

        builder.Property(e => e.Adress)
            .HasMaxLength(50)
            .HasColumnName("adress")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.Checks)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("checks")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Code)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("code")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dafter)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("dafter")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.Detail)
            .HasMaxLength(50)
            .HasColumnName("detail")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.Discount)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("discount")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.DueDate)
            .HasMaxLength(50)
            .HasColumnName("due_date")
            .HasDefaultValueSql("(((1999)/(1))/(1))");

        builder.Property(e => e.DueNote)
            .HasColumnName("due_note")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Extra)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("extra")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Hesab)
            .HasMaxLength(50)
            .HasColumnName("hesab")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.Hesabcust)
            .HasMaxLength(50)
            .HasColumnName("hesabcust");

        builder.Property(e => e.Kind)
            .HasMaxLength(50)
            .HasColumnName("kind")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.KindGroup)
            .HasMaxLength(50)
            .HasColumnName("kind_group")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.Money)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("money");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.Note)
            .HasColumnName("note")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Pay)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("pay");

        builder.Property(e => e.Price)
            .HasColumnType("money")
            .HasColumnName("price")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PromotionGroup)
            .HasMaxLength(50)
            .HasColumnName("Promotion_group")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.PromotionVal)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("Promotion_val")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Remain)
            .HasColumnType("money")
            .HasColumnName("remain")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Represent)
            .HasMaxLength(50)
            .HasColumnName("represent")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Sadad)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("sadad")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Spend)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("spend")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Stock)
            .HasMaxLength(50)
            .HasColumnName("stock")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.Tax)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("tax")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxGroup)
            .HasMaxLength(50)
            .HasColumnName("tax_group")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.TaxValue)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("tax_value");

        builder.Property(e => e.TheUser)
            .HasMaxLength(50)
            .HasColumnName("the_user")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.Total)
            .HasColumnType("money")
            .HasColumnName("total")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Unite)
            .HasMaxLength(50)
            .HasColumnName("unite")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.Unite1)
            .HasMaxLength(50)
            .HasColumnName("unite1")
            .HasDefaultValueSql("('''')");

        builder.Property(e => e.Unite2)
            .HasMaxLength(50)
            .HasColumnName("unite2");

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
    }
}