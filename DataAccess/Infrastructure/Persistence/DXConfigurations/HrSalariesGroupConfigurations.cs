using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrSalariesGroupConfiguration : IEntityTypeConfiguration<HrSalariesGroup>
{


    public void Configure(EntityTypeBuilder<HrSalariesGroup> builder)
    {
        builder.ToTable("HR_SalariesGroup");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}