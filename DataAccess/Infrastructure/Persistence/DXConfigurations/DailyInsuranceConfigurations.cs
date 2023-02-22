using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailyInsuranceConfiguration : IEntityTypeConfiguration<DailyInsurance>
{


    public void Configure(EntityTypeBuilder<DailyInsurance> builder)
    {
        builder.ToTable("DailyInsurance");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.CompanyInsuranceId).HasColumnName("CompanyInsuranceID");

        builder.Property(e => e.Credit).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Debit).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.DiscountAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.InvoiceAmount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Num).HasMaxLength(50);

        builder.Property(e => e.PatientId).HasColumnName("PatientID");

        builder.Property(e => e.Perc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");
    }
}