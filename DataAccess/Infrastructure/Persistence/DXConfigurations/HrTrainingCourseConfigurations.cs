using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrTrainingCourseConfiguration : IEntityTypeConfiguration<HrTrainingCourse>
{
    public void Configure(EntityTypeBuilder<HrTrainingCourse> builder)
    {
        builder.ToTable("HR_TrainingCourse");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Company).HasMaxLength(50);

        builder.Property(e => e.CourseId).HasColumnName("CourseID");

        builder.Property(e => e.DtEnd).HasColumnType("datetime");

        builder.Property(e => e.DtStart).HasColumnType("datetime");

        builder.Property(e => e.EmplId).HasColumnName("EmplID");

        builder.Property(e => e.Gpa)
            .HasMaxLength(50)
            .HasColumnName("GPA");

        builder.Property(e => e.Note).HasMaxLength(500);

        builder.Property(e => e.Specialization).HasMaxLength(50);
    }
}