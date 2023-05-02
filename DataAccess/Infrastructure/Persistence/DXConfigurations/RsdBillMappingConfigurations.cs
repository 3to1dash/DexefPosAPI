using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RsdBillMappingConfiguration : IEntityTypeConfiguration<RsdBillMapping>
{
    public void Configure(EntityTypeBuilder<RsdBillMapping> builder)
    {
        builder.ToTable("RSD_BillMapping");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.DoctorId)
            .HasMaxLength(50)
            .HasColumnName("DoctorID");

        builder.Property(e => e.Gtn)
            .HasMaxLength(50)
            .HasColumnName("GTN");

        builder.Property(e => e.NotificationId)
            .HasMaxLength(50)
            .HasColumnName("NotificationID");

        builder.Property(e => e.Patientnationalid)
            .HasMaxLength(50)
            .HasColumnName("PATIENTNATIONALID");

        builder.Property(e => e.Prescriptiondate)
            .HasMaxLength(50)
            .HasColumnName("PRESCRIPTIONDATE");

        builder.Property(e => e.Status).HasMaxLength(50);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.UploadDt)
            .HasColumnType("datetime")
            .HasColumnName("UploadDT");

        builder.Property(e => e.UserId).HasColumnName("UserID");
    }
}