using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RsdUserConfiguration : IEntityTypeConfiguration<RsdUser>
{


    public void Configure(EntityTypeBuilder<RsdUser> builder)
    {
        builder.ToTable("RSD_Users");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.DoctorId)
            .HasMaxLength(50)
            .HasColumnName("DoctorID");

        builder.Property(e => e.Password).HasMaxLength(150);

        builder.Property(e => e.UserName).HasMaxLength(150);
    }
}