using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class UpdateReSaleTranConfiguration : IEntityTypeConfiguration<UpdateReSaleTran>
{
    public void Configure(EntityTypeBuilder<UpdateReSaleTran> builder)
    {
        builder.HasNoKey();

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.Credit).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Debit).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.KindId).HasColumnName("KindID");

        builder.Property(e => e.NetAmount).HasColumnType("decimal(38, 6)");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");
    }
}