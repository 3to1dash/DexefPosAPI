using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CrmPotStatisticConfiguration : IEntityTypeConfiguration<CrmPotStatistic>
{


    public void Configure(EntityTypeBuilder<CrmPotStatistic> builder)
    {
        builder.ToTable("CRM_PotStatistics");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Description).HasMaxLength(2000);

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Num).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.ParentId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ParentID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Type).HasColumnType("numeric(18, 0)");
    }
}