using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkPledgeConfiguration : IEntityTypeConfiguration<WorkPledge>
{
    public void Configure(EntityTypeBuilder<WorkPledge> builder)
    {
        builder.ToTable("Work_Pledges");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Amount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Credit)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.Debit)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.EmpId).HasColumnName("EmpID");

        builder.Property(e => e.PledgeId).HasColumnName("PledgeID");

        builder.Property(e => e.Rate)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Remain).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Total).HasColumnType("numeric(18, 5)");
    }
}