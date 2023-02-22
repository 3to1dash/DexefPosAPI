using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EstimateSpentItemConfiguration : IEntityTypeConfiguration<EstimateSpentItem>
{


    public void Configure(EntityTypeBuilder<EstimateSpentItem> builder)
    {
        builder.ToTable("EstimateSpent_Item");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("AccountID");

        builder.Property(e => e.ArName).HasDefaultValueSql("('')");

        builder.Property(e => e.ChName).HasDefaultValueSql("('')");

        builder.Property(e => e.EnName).HasDefaultValueSql("('')");

        builder.Property(e => e.Note).HasMaxLength(2000);

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.RoName).HasDefaultValueSql("('')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.RuName).HasDefaultValueSql("('')");

        builder.Property(e => e.TuName).HasDefaultValueSql("('')");

        builder.Property(e => e.UrName).HasDefaultValueSql("('')");
    }
}