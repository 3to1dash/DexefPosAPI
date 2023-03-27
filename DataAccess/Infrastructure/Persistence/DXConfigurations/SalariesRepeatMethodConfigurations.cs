using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SalariesRepeatMethodConfiguration : IEntityTypeConfiguration<SalariesRepeatMethod>
{
    public void Configure(EntityTypeBuilder<SalariesRepeatMethod> builder)
    {
        builder.ToTable("Salaries_RepeatMethods");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.ItemType).HasMaxLength(50);

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SalaryId).HasColumnName("SalaryID");
    }
}