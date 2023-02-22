using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SmssendingEntryConfiguration : IEntityTypeConfiguration<SmssendingEntry>
{


    public void Configure(EntityTypeBuilder<SmssendingEntry> builder)
    {
        builder.ToTable("SMSSending_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.GroupId).HasColumnName("GroupID");

        builder.Property(e => e.Issuccessful).HasColumnName("ISSuccessful");

        builder.Property(e => e.PatrolId).HasColumnName("PatrolID");

        builder.Property(e => e.Phone).HasMaxLength(50);

        builder.Property(e => e.SendingId).HasColumnName("SendingID");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");
    }
}