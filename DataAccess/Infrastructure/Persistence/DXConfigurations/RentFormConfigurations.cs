using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RentFormConfiguration : IEntityTypeConfiguration<RentForm>
{


    public void Configure(EntityTypeBuilder<RentForm> builder)
    {
        builder.HasNoKey();

        builder.ToTable("RentForm");

        builder.Property(e => e.AssetId).HasColumnName("AssetID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}