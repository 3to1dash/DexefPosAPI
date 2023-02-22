using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class SrvcRecieveConfiguration : IEntityTypeConfiguration<SrvcRecieve>
{


    public void Configure(EntityTypeBuilder<SrvcRecieve> builder)
    {
        builder.ToTable("Srvc_Recieve");

        builder.Property(e => e.Id)
            .HasColumnType("numeric(18, 0)")
            .ValueGeneratedOnAdd()
            .HasColumnName("id");

        builder.Property(e => e.AccountId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("AccountID");

        builder.Property(e => e.Address).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Barcode).HasMaxLength(150);

        builder.Property(e => e.Branchid).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.CostId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CostID");

        builder.Property(e => e.Done).HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.DueDt).HasColumnType("datetime");

        builder.Property(e => e.GroupId).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.IsValid).HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemCost)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ItemId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("ItemID");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.Property(e => e.Note)
            .HasMaxLength(350)
            .HasColumnName("note");

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.PayType).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Phone1)
            .HasMaxLength(50)
            .HasColumnName("phone1");

        builder.Property(e => e.Phone2)
            .HasMaxLength(50)
            .HasColumnName("phone2");

        builder.Property(e => e.Refused).HasDefaultValueSql("((0))");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Repair).HasMaxLength(2000);

        builder.Property(e => e.RepairedBy)
            .HasMaxLength(50)
            .HasColumnName("Repaired_by");

        builder.Property(e => e.RepairedDt)
            .HasColumnType("datetime")
            .HasColumnName("Repaired_dt");

        builder.Property(e => e.RepairedNote)
            .HasMaxLength(350)
            .HasColumnName("Repaired_note");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.Serial).HasMaxLength(150);

        builder.Property(e => e.Ship).HasMaxLength(150);

        builder.Property(e => e.State).HasMaxLength(150);

        builder.Property(e => e.StorageId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("StorageID");

        builder.Property(e => e.Total)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("total")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Value).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Waiting).HasDefaultValueSql("((0))");

        builder.Property(e => e.Warranty).HasDefaultValueSql("((0))");

        builder.Property(e => e.WorkRegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}