using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class ItemRepaireTalabConfiguration : IEntityTypeConfiguration<ItemRepaireTalab>
{


    public void Configure(EntityTypeBuilder<ItemRepaireTalab> builder)
    {
        builder.ToTable("Item_Repaire_talab");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.Billindex)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("billindex");

        builder.Property(e => e.Build)
            .HasMaxLength(50)
            .HasColumnName("build");

        builder.Property(e => e.City)
            .HasMaxLength(50)
            .HasColumnName("city");

        builder.Property(e => e.Done)
            .HasColumnName("done")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.IsNew).HasDefaultValueSql("((1))");

        builder.Property(e => e.Item)
            .HasMaxLength(250)
            .HasColumnName("item");

        builder.Property(e => e.Name)
            .HasMaxLength(250)
            .HasColumnName("name");

        builder.Property(e => e.Note)
            .HasMaxLength(2500)
            .HasColumnName("note");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.Phone1)
            .HasMaxLength(50)
            .HasColumnName("phone1");

        builder.Property(e => e.Phone2)
            .HasMaxLength(50)
            .HasColumnName("phone2");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.State)
            .HasMaxLength(50)
            .HasColumnName("state");

        builder.Property(e => e.Street)
            .HasMaxLength(50)
            .HasColumnName("street");
    }
}