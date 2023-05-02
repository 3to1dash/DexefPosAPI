using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustomerDropDownConfiguration : IEntityTypeConfiguration<CustomerDropDown>
{
    public void Configure(EntityTypeBuilder<CustomerDropDown> builder)
    {
        builder.HasNoKey();

        builder.ToView("CustomerDropDown");

        builder.Property(e => e.Balance)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("balance");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Currency).HasMaxLength(3);

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Isdebit).HasColumnName("ISDebit");

        builder.Property(e => e.Kind)
            .HasMaxLength(15)
            .HasColumnName("kind");

        builder.Property(e => e.Name)
            .HasMaxLength(400)
            .HasColumnName("name");

        builder.Property(e => e.Num)
            .HasMaxLength(50)
            .HasColumnName("num");
    }
}