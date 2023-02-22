using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class BarcodeQrConfiguration : IEntityTypeConfiguration<BarcodeQr>
{


    public void Configure(EntityTypeBuilder<BarcodeQr> builder)
    {
        builder.ToTable("BarcodeQR");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.BatchAi)
            .HasMaxLength(10)
            .HasColumnName("BatchAI");

        builder.Property(e => e.CodeAi)
            .HasMaxLength(10)
            .HasColumnName("CodeAI");

        builder.Property(e => e.ExpireAi)
            .HasMaxLength(10)
            .HasColumnName("ExpireAI");

        builder.Property(e => e.Qrsorting).HasColumnName("QRSorting");

        builder.Property(e => e.Snai)
            .HasMaxLength(50)
            .HasColumnName("SNAI");

        builder.Property(e => e.Snlength).HasColumnName("SNLength");
    }
}