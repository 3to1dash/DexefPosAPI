using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TaxValidationConfiguration : IEntityTypeConfiguration<TaxValidation>
{


    public void Configure(EntityTypeBuilder<TaxValidation> builder)
    {
        builder.ToTable("TaxValidation");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Status)
            .HasMaxLength(50)
            .HasColumnName("status");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.UploadedDt)
            .HasColumnType("datetime")
            .HasColumnName("UploadedDT");

        builder.Property(e => e.Uuid)
            .HasMaxLength(50)
            .HasColumnName("UUID");
    }
}