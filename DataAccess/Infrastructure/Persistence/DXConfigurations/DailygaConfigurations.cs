using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DailygaConfiguration : IEntityTypeConfiguration<Dailyga>
{
    public void Configure(EntityTypeBuilder<Dailyga> builder)
    {
        builder.ToTable("dailygas");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Active)
            .HasColumnName("active")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Balance)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("balance")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Come)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("come")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Detail)
            .HasMaxLength(50)
            .HasColumnName("detail")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Go)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("go")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Price)
            .HasColumnType("money")
            .HasColumnName("price")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Tankid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("tankid")
            .HasDefaultValueSql("((0))");
    }
}