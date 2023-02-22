using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrTaskConfiguration : IEntityTypeConfiguration<HrTask>
{


    public void Configure(EntityTypeBuilder<HrTask> builder)
    {
        builder.ToTable("HR_Tasks");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AssignedToId).HasColumnName("AssignedToID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.DtEnd).HasColumnType("date");

        builder.Property(e => e.DtReminder).HasColumnType("date");

        builder.Property(e => e.DtStart).HasColumnType("date");

        builder.Property(e => e.Dthijri)
            .HasMaxLength(19)
            .IsUnicode(false)
            .HasColumnName("DTHijri")
            .IsFixedLength();

        builder.Property(e => e.LinkedToId).HasColumnName("LinkedToID");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Note).HasMaxLength(600);

        builder.Property(e => e.OwnerId).HasColumnName("OwnerID");

        builder.Property(e => e.Remindertime).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Subject).HasMaxLength(600);

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}