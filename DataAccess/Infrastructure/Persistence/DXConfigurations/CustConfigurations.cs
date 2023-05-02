using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class CustConfiguration : IEntityTypeConfiguration<Cust>
{
    public void Configure(EntityTypeBuilder<Cust> builder)
    {
        builder.ToTable("Cust");

        builder.HasIndex(e => new {e.BranchId, e.TypeIndex, e.Kind}, "IX_Cust_BranchID_TypeIndex_kind_C12EF");

        builder.HasIndex(e => new {e.OpeningBalance, e.TaskId}, "IX_Cust_OpeningBalance_TaskID_7D700");

        builder.HasIndex(e => e.Txt1, "IX_Cust_Txt1_2C3E4");

        builder.HasIndex(e => e.Txt2, "IX_Cust_Txt2_C3994");

        builder.HasIndex(e => e.Txt3, "IX_Cust_Txt3_11B08");

        builder.HasIndex(e => e.Txt4, "IX_Cust_Txt4_DC6EE");

        builder.HasIndex(e => e.Txt5, "IX_Cust_Txt5_E763F");

        builder.HasIndex(e => new {e.TypeIndex, e.ParentId, e.Active, e.BranchId},
            "IX_Cust_TypeIndex_ParentID_active_BranchID_B02F7");

        builder.HasIndex(e => new {e.TypeIndex, e.Active}, "IX_Cust_TypeIndex_active_924A3");

        builder.HasIndex(e => new {e.TypeIndex, e.Active, e.BranchId}, "IX_Cust_TypeIndex_active_BranchID_0740A");

        builder.HasIndex(e => new {e.TypeIndex, e.Active, e.BranchId}, "IX_Cust_TypeIndex_active_BranchID_623BD");

        builder.HasIndex(e => new {e.TypeIndex, e.Active, e.BranchId, e.Kind},
            "IX_Cust_TypeIndex_active_BranchID_kind_E1A08");

        builder.HasIndex(e => new {e.TypeIndex, e.Active}, "IX_Cust_TypeIndex_active_D5D3A");

        builder.HasIndex(e => new {e.TypeIndex, e.Active, e.Kind}, "IX_Cust_TypeIndex_active_kind_CAAC3");

        builder.HasIndex(e => new {e.TypeIndex, e.Num, e.BranchId}, "IX_Cust_TypeIndex_num_BranchID_2939C");

        builder.HasIndex(e => e.Accountid, "IX_Cust_accountid_5025F");

        builder.HasIndex(e => new {e.Active, e.Kind}, "IX_Cust_active_kind_DB02D");

        builder.HasIndex(e => new {e.Balance, e.CreditLimit}, "IX_Cust_balance_CreditLimit_10384");

        builder.HasIndex(e => e.Dt, "IX_Cust_dt_06127");

        builder.HasIndex(e => e.Name, "IX_Cust_name_CBD35");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.Accountid).HasColumnName("accountid");

        builder.Property(e => e.Active)
            .HasColumnName("active")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Adress)
            .HasColumnName("adress")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.AreaId).HasColumnName("AreaID");

        builder.Property(e => e.Balance)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("balance");

        builder.Property(e => e.Bankbranch)
            .HasMaxLength(50)
            .HasColumnName("bankbranch");

        builder.Property(e => e.Bankname)
            .HasMaxLength(50)
            .HasColumnName("bankname");

        builder.Property(e => e.Banknum)
            .HasMaxLength(50)
            .HasColumnName("banknum");

        builder.Property(e => e.BranchId)
            .HasColumnName("BranchID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CalcMode).HasDefaultValueSql("((0))");

        builder.Property(e => e.CashDiscount).HasDefaultValueSql("((0))");

        builder.Property(e => e.City).HasMaxLength(50);

        builder.Property(e => e.Company)
            .HasMaxLength(50)
            .HasColumnName("company");

        builder.Property(e => e.Contacttime)
            .HasColumnType("datetime")
            .HasColumnName("contacttime");

        builder.Property(e => e.ContractNum).HasMaxLength(50);

        builder.Property(e => e.CountryId)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("CountryID");

        builder.Property(e => e.Credit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("credit");

        builder.Property(e => e.CreditLimit).HasColumnType("numeric(19, 5)");

        builder.Property(e => e.Currency)
            .HasMaxLength(3)
            .HasColumnName("currency");

        builder.Property(e => e.CurrencyId).HasColumnType("decimal(18, 0)");

        builder.Property(e => e.CustIndex).HasDefaultValueSql("((0))");

        builder.Property(e => e.Debit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("debit");

        builder.Property(e => e.DefaultCash).HasDefaultValueSql("((0))");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("dt")
            .HasDefaultValueSql("(getdate())");

        builder.Property(e => e.FirstName).HasMaxLength(50);

        builder.Property(e => e.FromId)
            .HasColumnName("FromID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Gln)
            .HasMaxLength(50)
            .HasColumnName("GLN");

        builder.Property(e => e.Governorate).HasMaxLength(50);

        builder.Property(e => e.InPoints).HasDefaultValueSql("((0))");

        builder.Property(e => e.InsuranceCompanyId).HasColumnName("InsuranceCompanyID");

        builder.Property(e => e.InsuranceNum).HasMaxLength(50);

        builder.Property(e => e.InsurancePercentId).HasColumnName("InsurancePercentID");

        builder.Property(e => e.IsMix).HasDefaultValueSql("((0))");

        builder.Property(e => e.Isdebit)
            .HasColumnName("ISDebit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.IsloyaltyProgram).HasDefaultValueSql("((0))");

        builder.Property(e => e.Kind)
            .HasMaxLength(15)
            .HasColumnName("kind")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.LastCall).HasColumnType("datetime");

        builder.Property(e => e.LocalBalance)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.LocalCredit).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.LocalDebit).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.LstUpdate).HasColumnType("datetime");

        builder.Property(e => e.Lstoprdt)
            .HasColumnType("datetime")
            .HasColumnName("lstoprdt");

        builder.Property(e => e.Lstoprval)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("lstoprval");

        builder.Property(e => e.Mail)
            .HasMaxLength(50)
            .HasColumnName("mail")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Name)
            .HasMaxLength(400)
            .HasColumnName("name")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Nat)
            .HasMaxLength(3)
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Netpoints).HasDefaultValueSql("((0))");

        builder.Property(e => e.Note).HasColumnName("note");

        builder.Property(e => e.NoteIsImportant).HasDefaultValueSql("((0))");

        builder.Property(e => e.Num)
            .HasMaxLength(50)
            .HasColumnName("num");

        builder.Property(e => e.OpeningBalance)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.OutPoints).HasDefaultValueSql("((0))");

        builder.Property(e => e.PageNum).HasMaxLength(50);

        builder.Property(e => e.ParentCustId).HasColumnName("ParentCustID");

        builder.Property(e => e.ParentId)
            .HasColumnName("ParentID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Person)
            .HasMaxLength(50)
            .HasColumnName("person");

        builder.Property(e => e.PersonalId)
            .HasMaxLength(50)
            .HasColumnName("PersonalID");

        builder.Property(e => e.Phone1)
            .HasMaxLength(50)
            .HasColumnName("phone1")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Phone2)
            .HasMaxLength(50)
            .HasColumnName("phone2")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Phone3)
            .HasMaxLength(50)
            .HasColumnName("phone3")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.PostalNumber).HasMaxLength(50);

        builder.Property(e => e.Prefix)
            .HasMaxLength(20)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.PriceLevel).HasDefaultValueSql("((0))");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.RemainBill)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RemainIsstall)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RentBalance)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RentCredit)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RentDebit)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.RepId).HasColumnName("RepID");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.ShowInAll).HasDefaultValueSql("((1))");

        builder.Property(e => e.Street).HasMaxLength(450);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.TaxDoc).HasMaxLength(50);

        builder.Property(e => e.TaxFile).HasMaxLength(50);

        builder.Property(e => e.TaxGov).HasMaxLength(50);

        builder.Property(e => e.Tempuse)
            .HasMaxLength(50)
            .HasColumnName("tempuse");

        builder.Property(e => e.TotalIncome)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TradeRegister).HasMaxLength(50);

        builder.Property(e => e.Txt1).HasMaxLength(350);

        builder.Property(e => e.Txt2).HasMaxLength(350);

        builder.Property(e => e.Txt3).HasMaxLength(350);

        builder.Property(e => e.Txt4).HasMaxLength(350);

        builder.Property(e => e.Txt5).HasMaxLength(350);

        builder.Property(e => e.Txt6).HasMaxLength(350);

        builder.Property(e => e.Txt7).HasMaxLength(350);

        builder.Property(e => e.Txt8).HasMaxLength(350);

        builder.Property(e => e.Type).HasDefaultValueSql("((0))");

        builder.Property(e => e.UpdatedBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Val1)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("VAl1")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Val2)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("VAl2")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.WrittenBy)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");
    }
}