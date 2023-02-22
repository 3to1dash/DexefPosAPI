using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{


    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(e => e.Name);

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Address).HasMaxLength(50);

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CurrentState).HasDefaultValueSql("((0))");

        builder.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Email).HasMaxLength(50);

        builder.Property(e => e.FullName).HasMaxLength(50);

        builder.Property(e => e.IsnewPass)
            .HasColumnName("ISNewPass")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.JobId).HasColumnName("JobID");

        builder.Property(e => e.LastOpenTime).HasColumnType("datetime");

        builder.Property(e => e.Manager).HasMaxLength(50);

        builder.Property(e => e.Mobile1).HasMaxLength(50);

        builder.Property(e => e.Mobile2).HasMaxLength(50);

        builder.Property(e => e.MustClose).HasDefaultValueSql("((0))");

        builder.Property(e => e.NotificationId).HasColumnName("NotificationID");

        builder.Property(e => e.Passward)
            .HasMaxLength(50)
            .HasColumnName("passward");

        builder.Property(e => e.Permission).HasMaxLength(50);

        builder.Property(e => e.PrivilegeId).HasColumnName("privilegeID");

        builder.Property(e => e.ReportTemplateId).HasColumnName("ReportTemplateID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ShiftId)
            .HasColumnName("ShiftID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Sn)
            .HasMaxLength(150)
            .HasColumnName("SN")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Type).HasMaxLength(50);

        builder.Property(e => e.UpdatedBy).HasMaxLength(50);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);

        builder.HasOne(d => d.Department)
            .WithMany(p => p.Users)
            .HasForeignKey(d => d.DepartmentId)
            .HasConstraintName("FK_Users_User_Department");

        builder.HasOne(d => d.Job)
            .WithMany(p => p.Users)
            .HasForeignKey(d => d.JobId)
            .HasConstraintName("FK_Users_User_Jobs");

        builder.HasOne(d => d.Notification)
            .WithMany(p => p.Users)
            .HasForeignKey(d => d.NotificationId)
            .HasConstraintName("FK_Users_User_Notification");

        builder.HasOne(d => d.Privilege)
            .WithMany(p => p.Users)
            .HasForeignKey(d => d.PrivilegeId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_Users_Users_Privileges");

        builder.HasOne(d => d.Shift)
            .WithMany(p => p.Users)
            .HasForeignKey(d => d.ShiftId)
            .HasConstraintName("FK_Users_Hr_WorkTime");
    }
}