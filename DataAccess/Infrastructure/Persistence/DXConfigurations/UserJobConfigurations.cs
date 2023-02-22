using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UserJobConfiguration : IEntityTypeConfiguration<UserJob>
{


    public void Configure(EntityTypeBuilder<UserJob> builder)
    {
        builder.ToTable("User_Jobs");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.Note).HasMaxLength(550);

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.ParentId).HasColumnName("ParentID");
    }
}