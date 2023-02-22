using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SalaryCalcLogConfiguration : IEntityTypeConfiguration<SalaryCalcLog>
{


    public void Configure(EntityTypeBuilder<SalaryCalcLog> builder)
    {
        builder.ToTable("SalaryCalc_Log");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.Note).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.WorkId).HasColumnName("WorkID");
    }
}