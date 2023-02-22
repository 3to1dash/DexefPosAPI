using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkItineraryEntryConfiguration : IEntityTypeConfiguration<WorkItineraryEntry>
{


    public void Configure(EntityTypeBuilder<WorkItineraryEntry> builder)
    {
        builder.ToTable("Work_Itinerary_Entry");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.CustId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CustID");

        builder.Property(e => e.FromTime).HasColumnType("datetime");

        builder.Property(e => e.Note).HasMaxLength(250);

        builder.Property(e => e.OperatIndex).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Ship).HasMaxLength(250);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.ToTime).HasColumnType("datetime");
    }
}