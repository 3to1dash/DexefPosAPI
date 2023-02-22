using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ExtraItemConfiguration : IEntityTypeConfiguration<ExtraItem>
{


    public void Configure(EntityTypeBuilder<ExtraItem> builder)
    {
        builder.ToTable("ExtraItem");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Dt1).HasColumnType("datetime");

        builder.Property(e => e.Dt2).HasColumnType("datetime");

        builder.Property(e => e.InDealing).HasMaxLength(50);

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Value).HasColumnType("numeric(19, 5)");
    }
}