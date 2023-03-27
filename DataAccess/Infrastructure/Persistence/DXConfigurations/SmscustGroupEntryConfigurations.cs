using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SmscustGroupEntryConfiguration : IEntityTypeConfiguration<SmscustGroupEntry>
{
    public void Configure(EntityTypeBuilder<SmscustGroupEntry> builder)
    {
        builder.ToTable("SMSCustGroup_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.GroupId).HasColumnName("GroupID");

        builder.Property(e => e.Issetting).HasColumnName("ISSetting");

        builder.Property(e => e.ParentId).HasColumnName("ParentID");
    }
}