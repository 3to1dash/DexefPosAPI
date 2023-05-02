using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TaxValidationResultConfiguration : IEntityTypeConfiguration<TaxValidationResult>
{
    public void Configure(EntityTypeBuilder<TaxValidationResult> builder)
    {
        builder.ToTable("TaxValidationResult");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Error)
            .HasMaxLength(50)
            .HasColumnName("error");

        builder.Property(e => e.ErrorAr)
            .HasMaxLength(50)
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

        builder.Property(e => e.Status)
            .HasMaxLength(50)
            .HasColumnName("status");

        builder.Property(e => e.StepId).HasColumnName("stepId");

        builder.Property(e => e.StepName)
            .HasMaxLength(150)
            .HasColumnName("stepName");

        builder.HasOne(d => d.TaxValidtion)
            .WithMany(p => p.TaxValidationResults)
            .HasForeignKey(d => d.TaxValidtionId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_Taxes_ValidationResults_Taxes_Validation");
    }
}