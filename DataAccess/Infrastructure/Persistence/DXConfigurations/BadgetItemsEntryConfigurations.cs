using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BadgetItemsEntryConfiguration : IEntityTypeConfiguration<BadgetItemsEntry>
{


    public void Configure(EntityTypeBuilder<BadgetItemsEntry> builder)
    {
        builder.ToTable("Badget_ItemsEntry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.BadgetItemId).HasColumnName("BadgetItemID");

        builder.Property(e => e.Code).HasMaxLength(50);
    }
}