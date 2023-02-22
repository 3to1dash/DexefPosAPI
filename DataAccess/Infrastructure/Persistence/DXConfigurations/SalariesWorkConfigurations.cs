using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SalariesWorkConfiguration : IEntityTypeConfiguration<SalariesWork>
{


    public void Configure(EntityTypeBuilder<SalariesWork> builder)
    {
        builder.ToTable("Salaries_Work");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.CalcType).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.FixedSalary).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Salary)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("salary");

        builder.Property(e => e.SalaryId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("SalaryID");

        builder.Property(e => e.WorkId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("WorkID");
    }
}