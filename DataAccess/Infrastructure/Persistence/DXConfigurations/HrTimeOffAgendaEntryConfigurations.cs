using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrTimeOffAgendaEntryConfiguration : IEntityTypeConfiguration<HrTimeOffAgendaEntry>
{


    public void Configure(EntityTypeBuilder<HrTimeOffAgendaEntry> builder)
    {
        builder.ToTable("Hr_TimeOffAgenda_Entry");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.AgendaId).HasColumnName("AgendaID");

        builder.Property(e => e.FromDate).HasColumnType("datetime");

        builder.Property(e => e.TimeOffId).HasColumnName("TimeOffID");

        builder.Property(e => e.Todate).HasColumnType("datetime");
    }
}