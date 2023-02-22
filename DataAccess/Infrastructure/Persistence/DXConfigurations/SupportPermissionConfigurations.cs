using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SupportPermissionConfiguration : IEntityTypeConfiguration<SupportPermission>
{


    public void Configure(EntityTypeBuilder<SupportPermission> builder)
    {
        builder.ToTable("Support_Permission");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.ProblemId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ProblemID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.UserName).HasMaxLength(50);

        builder.Property(e => e.Workid).HasColumnType("numeric(18, 0)");
    }
}