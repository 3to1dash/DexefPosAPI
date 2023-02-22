using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UserDepartmentConfiguration : IEntityTypeConfiguration<UserDepartment>
{


    public void Configure(EntityTypeBuilder<UserDepartment> builder)
    {
        builder.ToTable("User_Department");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Active).HasColumnName("active");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Manager).HasMaxLength(50);

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Note).HasMaxLength(450);

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.ParentId).HasColumnName("ParentID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}