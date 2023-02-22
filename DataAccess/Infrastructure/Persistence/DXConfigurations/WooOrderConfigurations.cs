using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WooOrderConfiguration : IEntityTypeConfiguration<WooOrder>
{


    public void Configure(EntityTypeBuilder<WooOrder> builder)
    {
        builder.ToTable("WooOrder");

        builder.HasIndex(e => e.Billingid, "IX_WooOrder_billingid");

        builder.HasIndex(e => e.Shippingid, "IX_WooOrder_shippingid");

        builder.Property(e => e.Id)
            .HasColumnType("decimal(20, 0)")
            .HasColumnName("id");

        builder.Property(e => e.Billingid).HasColumnName("billingid");

        builder.Property(e => e.CartHash).HasColumnName("cart_hash");

        builder.Property(e => e.CartTax)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("cart_tax");

        builder.Property(e => e.CreatedVia).HasColumnName("created_via");

        builder.Property(e => e.Currency).HasColumnName("currency");

        builder.Property(e => e.CustomerId)
            .HasColumnType("decimal(20, 0)")
            .HasColumnName("customer_id");

        builder.Property(e => e.CustomerIpAddress).HasColumnName("customer_ip_address");

        builder.Property(e => e.CustomerNote).HasColumnName("customer_note");

        builder.Property(e => e.CustomerUserAgent).HasColumnName("customer_user_agent");

        builder.Property(e => e.DateCompleted).HasColumnName("date_completed");

        builder.Property(e => e.DateCompletedGmt).HasColumnName("date_completed_gmt");

        builder.Property(e => e.DateCreated).HasColumnName("date_created");

        builder.Property(e => e.DateCreatedGmt).HasColumnName("date_created_gmt");

        builder.Property(e => e.DateModified).HasColumnName("date_modified");

        builder.Property(e => e.DateModifiedGmt).HasColumnName("date_modified_gmt");

        builder.Property(e => e.DatePaid).HasColumnName("date_paid");

        builder.Property(e => e.DatePaidGmt).HasColumnName("date_paid_gmt");

        builder.Property(e => e.DiscountTax)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("discount_tax");

        builder.Property(e => e.DiscountTotal)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("discount_total");

        builder.Property(e => e.Number).HasColumnName("number");

        builder.Property(e => e.OrderKey).HasColumnName("order_key");

        builder.Property(e => e.ParentId)
            .HasColumnType("decimal(20, 0)")
            .HasColumnName("parent_id");

        builder.Property(e => e.PaymentMethod).HasColumnName("payment_method");

        builder.Property(e => e.PaymentMethodTitle).HasColumnName("payment_method_title");

        builder.Property(e => e.PricesIncludeTax).HasColumnName("prices_include_tax");

        builder.Property(e => e.SetPaid).HasColumnName("set_paid");

        builder.Property(e => e.ShippingTax)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("shipping_tax");

        builder.Property(e => e.ShippingTotal)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("shipping_total");

        builder.Property(e => e.Shippingid).HasColumnName("shippingid");

        builder.Property(e => e.Status).HasColumnName("status");

        builder.Property(e => e.Total)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("total");

        builder.Property(e => e.TotalTax)
            .HasColumnType("decimal(18, 2)")
            .HasColumnName("total_tax");

        builder.Property(e => e.TransactionId).HasColumnName("transaction_id");

        builder.Property(e => e.Version).HasColumnName("version");

        builder.HasOne(d => d.Billing)
            .WithMany(p => p.WooOrders)
            .HasForeignKey(d => d.Billingid);

        builder.HasOne(d => d.Shipping)
            .WithMany(p => p.WooOrders)
            .HasForeignKey(d => d.Shippingid);
    }
}