using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrSalariesEquationConfiguration : IEntityTypeConfiguration<HrSalariesEquation>
{


    public void Configure(EntityTypeBuilder<HrSalariesEquation> builder)
    {
        builder.ToTable("HR_SalariesEquation");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AfterIf)
            .HasMaxLength(500)
            .HasColumnName("AfterIF");

        builder.Property(e => e.AfterOperand).HasMaxLength(500);

        builder.Property(e => e.AfterThen).HasMaxLength(500);

        builder.Property(e => e.IsAdd).HasDefaultValueSql("((0))");

        builder.Property(e => e.Operand).HasMaxLength(10);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SalaryId).HasColumnName("SalaryID");

        builder.Property(e => e.SubId).HasColumnName("SubID");
    }
}