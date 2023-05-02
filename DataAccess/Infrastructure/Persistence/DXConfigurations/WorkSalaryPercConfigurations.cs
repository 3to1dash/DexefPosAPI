using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkSalaryPercConfiguration : IEntityTypeConfiguration<WorkSalaryPerc>
{
    public void Configure(EntityTypeBuilder<WorkSalaryPerc> builder)
    {
        builder.ToTable("Work_SalaryPerc");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Arb).HasMaxLength(50);

        builder.Property(e => e.Eng).HasMaxLength(50);

        builder.Property(e => e.Fre).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Type).HasMaxLength(50);
    }
}