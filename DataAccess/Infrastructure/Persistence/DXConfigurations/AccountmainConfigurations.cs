using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class AccountmainConfiguration : IEntityTypeConfiguration<Accountmain>
{
    public void Configure(EntityTypeBuilder<Accountmain> builder)
    {
        builder.ToTable("Accountmain");

        builder.ToTable(t => t.HasComment("كل التعاملات اللي بتحصل على الحسابات"));


        builder.HasIndex(e => new {e.AccountId, e.Deleted, e.Updated},
            "IX_Accountmain_AccountID_Deleted_Updated_2A5AB");

        builder.HasIndex(e => new {e.AccountId, e.Deleted, e.Updated},
            "IX_Accountmain_AccountID_Deleted_Updated_3B4AF");

        builder.HasIndex(e => new {e.AccountId, e.Deleted, e.Updated, e.BranchId},
            "IX_Accountmain_AccountID_Deleted_Updated_BranchID_3D42F");

        builder.HasIndex(e => new {e.AccountId, e.Deleted, e.Updated, e.ItemId},
            "IX_Accountmain_AccountID_Deleted_Updated_ItemID_C7C67");

        builder.HasIndex(e => new {e.AccountId, e.Deleted, e.Updated, e.KindId},
            "IX_Accountmain_AccountID_Deleted_Updated_KindID_CE5EC");

        builder.HasIndex(e => new {e.AccountId, e.Deleted, e.Updated, e.Dt},
            "IX_Accountmain_AccountID_Deleted_Updated_dt_06524");

        builder.HasIndex(e => new {e.AccountId, e.Deleted, e.Updated, e.Dt},
            "IX_Accountmain_AccountID_Deleted_Updated_dt_23BAD");

        builder.HasIndex(e => new {e.AccountId, e.Deleted, e.Updated, e.Dt},
            "IX_Accountmain_AccountID_Deleted_Updated_dt_3D18C");

        builder.HasIndex(e => new {e.AccountId, e.TaskId}, "IX_Accountmain_AccountID_TaskID_7B173");

        builder.HasIndex(e => new {e.BranchId, e.Deleted, e.Updated, e.Dt},
            "IX_Accountmain_BranchID_Deleted_Updated_dt_4B7A6");

        builder.HasIndex(e => e.BranchId, "IX_Accountmain_BranchID_EE54E");

        builder.HasIndex(e => new {e.Deleted, e.DeletedBy, e.Updated},
            "IX_Accountmain_Deleted_DeletedBy_Updated_A4B47");

        builder.HasIndex(e => new {e.Deleted, e.Updated}, "IX_Accountmain_Deleted_Updated_0BA31");

        builder.HasIndex(e => new {e.Deleted, e.Updated}, "IX_Accountmain_Deleted_Updated_1EB04");

        builder.HasIndex(e => new {e.Deleted, e.Updated}, "IX_Accountmain_Deleted_Updated_704AA");

        builder.HasIndex(e => new {e.Deleted, e.Updated}, "IX_Accountmain_Deleted_Updated_7338D");

        builder.HasIndex(e => new {e.Deleted, e.Updated}, "IX_Accountmain_Deleted_Updated_7CB13");

        builder.HasIndex(e => new {e.Deleted, e.Updated, e.AccountId},
            "IX_Accountmain_Deleted_Updated_AccountID_6B917");

        builder.HasIndex(e => new {e.Deleted, e.Updated, e.BranchId}, "IX_Accountmain_Deleted_Updated_BranchID_55F1C");

        builder.HasIndex(e => new {e.Deleted, e.Updated}, "IX_Accountmain_Deleted_Updated_C51AC");

        builder.HasIndex(e => new {e.Deleted, e.Updated, e.ItemId}, "IX_Accountmain_Deleted_Updated_ItemID_739E0");

        builder.HasIndex(e => new {e.Deleted, e.Updated, e.Dealing}, "IX_Accountmain_Deleted_Updated_dealing_29961");

        builder.HasIndex(e => new {e.Deleted, e.Updated, e.Dt}, "IX_Accountmain_Deleted_Updated_dt_99610");

        builder.HasIndex(e => e.TaskId, "IX_Accountmain_TaskID_A0B84");

        builder.HasIndex(e => e.TaskId, "IX_Accountmain_TaskID_A9AD6");

        builder.HasIndex(e => new {e.TaskId, e.Deleted, e.Updated}, "IX_Accountmain_TaskID_Deleted_Updated_B2B2D");

        builder.HasIndex(e => new {e.TaskId, e.Updated}, "IX_Accountmain_TaskID_Updated_0D3C5");

        builder.HasIndex(e => e.Dealing, "IX_Accountmain_dealing_3173D");

        builder.HasIndex(e => e.Dealing, "IX_Accountmain_dealing_A00CC");

        builder.HasIndex(e => new {e.Dealing, e.Deleted, e.Updated}, "IX_Accountmain_dealing_Deleted_Updated_8E010");

        builder.HasIndex(e => e.Dealing, "IX_Accountmain_dealing_FC2B9");

        builder.HasIndex(e => new {e.Dealing, e.ItemId}, "IX_Accountmain_dealing_ItemID_387A8");

        builder.HasIndex(e => e.Debit, "IX_Accountmain_debit_6C5E3");

        builder.HasIndex(e => e.Num, "IX_Accountmain_num_31251");

        builder.HasIndex(
            e => new
            {
                e.AccountId, e.Dealing, e.BranchId, e.RegNum, e.TaskId, e.PeriodId, e.Deleted, e.Updated, e.ItemId,
                e.KindId
            }, "NonClusteredIndex-20200213-143818");

        builder.HasIndex(e => e.ItemCostRow, "missing_index_1293_1292_Accountmain");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AccountId).HasColumnName("AccountID");

        builder.Property(e => e.ActualRate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.BranchId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("BranchID");

        builder.Property(e => e.CostId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CostID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Cpu)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CPU");

        builder.Property(e => e.Credit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("credit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .IsUnicode(false)
            .IsFixedLength();

        builder.Property(e => e.Dealing)
            .HasMaxLength(50)
            .HasColumnName("dealing");

        builder.Property(e => e.Debit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("debit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Deleted).HasDefaultValueSql("((0))");

        builder.Property(e => e.DeletedBy)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.DeletedCredit).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.DeletedLocalCredit).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.DeletedLocalDebit).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Deleteddebit).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt");

        builder.Property(e => e.ItemId)
            .HasColumnName("ItemID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.KindId)
            .HasColumnName("KindID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LocalCredit)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LocalDebit)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Note).HasColumnName("note");

        builder.Property(e => e.Num)
            .HasMaxLength(50)
            .HasColumnName("num");

        builder.Property(e => e.PeriodId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("PeriodID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.RegNum).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Updated).HasDefaultValueSql("((0))");

        builder.Property(e => e.Value)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}