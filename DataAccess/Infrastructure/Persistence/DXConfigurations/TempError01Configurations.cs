using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TempError01Configuration : IEntityTypeConfiguration<TempError01>
{


    public void Configure(EntityTypeBuilder<TempError01> builder)
    {
        builder.HasNoKey();

        builder.ToTable("TempError01");

        builder.Property(e => e.AssignedId).HasColumnName("AssignedID");

        builder.Property(e => e.Dealing)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("dealing");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("id");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");
    }
}