using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UserDefaultAccountConfiguration : IEntityTypeConfiguration<UserDefaultAccount>
{
    public void Configure(EntityTypeBuilder<UserDefaultAccount> builder)
    {
        builder.HasNoKey();

        builder.ToTable("User_DefaultAccounts");

        builder.Property(e => e.BankId).HasColumnName("BankID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Currency).HasMaxLength(5);

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.PledgeId).HasColumnName("PledgeID");

        builder.Property(e => e.StorageId).HasColumnName("StorageID");

        builder.Property(e => e.StoreId).HasColumnName("StoreID");

        builder.Property(e => e.ToStoreId).HasColumnName("ToStoreID");

        builder.Property(e => e.UserName).HasMaxLength(50);

        builder.Property(e => e.VisaId).HasColumnName("VisaID");
    }
}