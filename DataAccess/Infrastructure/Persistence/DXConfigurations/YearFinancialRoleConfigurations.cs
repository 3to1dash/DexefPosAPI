using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class YearFinancialRoleConfiguration : IEntityTypeConfiguration<YearFinancialRole>
{


    public void Configure(EntityTypeBuilder<YearFinancialRole> builder)
    {
        builder.ToTable("YearFinancial_Roles");

        builder.Property(e => e.Id).HasColumnName("ID");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.Name).HasMaxLength(50);

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.RoleId).HasColumnName("RoleID");

        builder.Property(e => e.UseAdd).HasMaxLength(10);

        builder.Property(e => e.UseDelete).HasMaxLength(10);

        builder.Property(e => e.UseEdit).HasMaxLength(10);

        builder.Property(e => e.UsePrint).HasMaxLength(10);

        builder.Property(e => e.WrittenBy).HasMaxLength(50);

        builder.HasOne(d => d.Period)
            .WithMany(p => p.YearFinancialRoles)
            .HasForeignKey(d => d.PeriodId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_YearFinancial_Roles_YearFinancial");
    }
}