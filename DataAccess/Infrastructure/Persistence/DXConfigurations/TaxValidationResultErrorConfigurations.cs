using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TaxValidationResultErrorConfiguration : IEntityTypeConfiguration<TaxValidationResultError>
{


    public void Configure(EntityTypeBuilder<TaxValidationResultError> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Error)
            .HasMaxLength(150)
            .HasColumnName("error");

        builder.Property(e => e.ErrorAr)
            .HasMaxLength(150)
            .HasColumnName("errorAr");

        builder.Property(e => e.ErrorCode)
            .HasMaxLength(50)
            .HasColumnName("errorCode");

        builder.Property(e => e.PropertyName)
            .HasMaxLength(50)
            .HasColumnName("propertyName");

        builder.Property(e => e.PropertyPath)
            .HasMaxLength(50)
            .HasColumnName("propertyPath");

        builder.HasOne(d => d.ValidtionResult)
            .WithMany(p => p.TaxValidationResultErrors)
            .HasForeignKey(d => d.ValidtionResultId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_Taxes_ValidationErrors_Taxes_ValidationResults");
    }
}