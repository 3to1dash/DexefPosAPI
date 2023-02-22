using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class RepManConfiguration : IEntityTypeConfiguration<RepMan>
{


    public void Configure(EntityTypeBuilder<RepMan> builder)
    {
        builder.ToTable("RepMan");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.RepType).HasMaxLength(50);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SliceId).HasColumnName("SliceID");
    }
}