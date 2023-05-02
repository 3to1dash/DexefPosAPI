using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Address).HasMaxLength(250);

        builder.Property(e => e.AnnualIncrease).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.ArName).HasMaxLength(150);

        builder.Property(e => e.BloodTypeId).HasColumnName("BloodTypeID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ChangedSalary).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT")
            .HasDefaultValueSql("(getdate())");

        builder.Property(e => e.EnName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.FacultyId).HasColumnName("FacultyID");

        builder.Property(e => e.FingerPrintNumber).HasMaxLength(50);

        builder.Property(e => e.FrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.HiringStatus).HasMaxLength(50);

        builder.Property(e => e.Insurances).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.JobId).HasColumnName("JobID");

        builder.Property(e => e.Mail).HasMaxLength(150);

        builder.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");

        builder.Property(e => e.Mob1).HasMaxLength(50);

        builder.Property(e => e.Mob2).HasMaxLength(50);

        builder.Property(e => e.NationalityId).HasColumnName("NationalityID");

        builder.Property(e => e.Num)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Salary).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Sex).HasMaxLength(50);

        builder.Property(e => e.Status)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.Taxes).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Writtenby).HasMaxLength(50);
    }
}