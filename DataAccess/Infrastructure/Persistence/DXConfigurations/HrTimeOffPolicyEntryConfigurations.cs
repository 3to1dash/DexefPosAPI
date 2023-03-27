using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class HrTimeOffPolicyEntryConfiguration : IEntityTypeConfiguration<HrTimeOffPolicyEntry>
{
    public void Configure(EntityTypeBuilder<HrTimeOffPolicyEntry> builder)
    {
        builder.ToTable("Hr_TimeOffPolicy_Entry");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.PolicyId).HasColumnName("PolicyID");

        builder.Property(e => e.TimeOffId).HasColumnName("TimeOffID");
    }
}