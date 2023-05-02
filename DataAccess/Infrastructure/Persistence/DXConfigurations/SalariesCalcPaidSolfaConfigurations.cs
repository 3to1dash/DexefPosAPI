using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SalariesCalcPaidSolfaConfiguration : IEntityTypeConfiguration<SalariesCalcPaidSolfa>
{
    public void Configure(EntityTypeBuilder<SalariesCalcPaidSolfa> builder)
    {
        builder.ToTable("SalariesCalc_PaidSolfa");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Value).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.WorkId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("WorkID");
    }
}