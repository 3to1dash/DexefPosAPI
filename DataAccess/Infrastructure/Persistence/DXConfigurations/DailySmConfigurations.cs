using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailySmConfiguration : IEntityTypeConfiguration<DailySm>
{
    public void Configure(EntityTypeBuilder<DailySm> builder)
    {
        builder.ToTable("DailySMS");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Dt).HasColumnType("datetime");

        builder.Property(e => e.GroupId).HasColumnName("GroupID");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Number).HasMaxLength(50);

        builder.Property(e => e.PatrolId).HasColumnName("PatrolID");

        builder.Property(e => e.Smsid).HasColumnName("SMSID");

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}