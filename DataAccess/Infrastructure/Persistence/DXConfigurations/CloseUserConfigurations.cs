using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CloseUserConfiguration : IEntityTypeConfiguration<CloseUser>
{


    public void Configure(EntityTypeBuilder<CloseUser> builder)
    {
        builder.ToTable("Close_User");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Branchid)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("branchid");

        builder.Property(e => e.Cpu)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CPU");

        builder.Property(e => e.Diff)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("diff")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.Note).HasColumnName("note");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.StorageId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("StorageID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ToStorageId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ToStorageID");

        builder.Property(e => e.Value)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("value")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}