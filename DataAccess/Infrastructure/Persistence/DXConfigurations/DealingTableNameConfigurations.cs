using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class DealingTableNameConfiguration : IEntityTypeConfiguration<DealingTableName>
{


    public void Configure(EntityTypeBuilder<DealingTableName> builder)
    {
        builder.HasKey(e => e.TableName)
            .HasName("PK_Dealing_TableName_1");

        builder.ToTable("Dealing_TableName");

        builder.Property(e => e.TableName).HasMaxLength(50);

        builder.Property(e => e.Dealing).HasMaxLength(50);

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.ParentId)
            .HasColumnName("ParentID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");
    }
}