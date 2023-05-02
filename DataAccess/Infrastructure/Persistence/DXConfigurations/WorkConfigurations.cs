using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class WorkConfiguration : IEntityTypeConfiguration<Work>
{
    public void Configure(EntityTypeBuilder<Work> builder)
    {
        builder.ToTable(t => t.HasComment("اسماء و بيانات الموظفين"));

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AbsentRate)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Address)
            .HasMaxLength(150)
            .HasColumnName("address");

        builder.Property(e => e.ArName).HasMaxLength(150);

        builder.Property(e => e.Balance)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("balance")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.BankAccount).HasMaxLength(50);

        builder.Property(e => e.BloodTypeId).HasColumnName("BloodTypeID");

        builder.Property(e => e.BornDt)
            .HasColumnType("datetime")
            .HasColumnName("BornDT");

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CapitalId)
            .HasColumnName("CapitalID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.CarKind).HasMaxLength(50);

        builder.Property(e => e.CarNum).HasMaxLength(50);

        builder.Property(e => e.ChName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.ContractState).HasMaxLength(50);

        builder.Property(e => e.CostId)
            .HasColumnName("CostID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Credit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("credit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Debit)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("debit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DeliveryStatus).HasDefaultValueSql("((0))");

        builder.Property(e => e.DepartmentId)
            .HasColumnName("DepartmentID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Dependents).HasColumnName("dependents");

        builder.Property(e => e.DirectManagerId).HasColumnName("DirectManagerID");

        builder.Property(e => e.DriverLicense).HasMaxLength(50);

        builder.Property(e => e.EnName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.FacLevel).HasDefaultValueSql("((0))");

        builder.Property(e => e.FacultyId).HasColumnName("FacultyID");

        builder.Property(e => e.Fixedsale).HasColumnName("fixedsale");

        builder.Property(e => e.FrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Gasraseed)
            .HasColumnType("money")
            .HasColumnName("gasraseed");

        builder.Property(e => e.GpagradeId).HasColumnName("GPAGradeID");

        builder.Property(e => e.GroupId).HasColumnName("GroupID");

        builder.Property(e => e.HasAttendance).HasDefaultValueSql("((0))");

        builder.Property(e => e.HiringDate).HasColumnType("datetime");

        builder.Property(e => e.Hisbalance)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("hisbalance")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Hiscredit)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("hiscredit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Hisdebit)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("hisdebit")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InsurancType).HasDefaultValueSql("((0))");

        builder.Property(e => e.InsuranceCo).HasMaxLength(50);

        builder.Property(e => e.InsuranceCoChanged)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InsuranceCoFixed)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InsuranceNum).HasMaxLength(50);

        builder.Property(e => e.InsurancePreChangedValue)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InsurancePreFixValue)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InsuranceWorkChanged)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.InsuranceWorkFixed)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.IsRep).HasDefaultValueSql("((0))");

        builder.Property(e => e.Iscredit).HasDefaultValueSql("((0))");

        builder.Property(e => e.Isinsurance).HasColumnName("ISInsurance");

        builder.Property(e => e.IssalePercent).HasColumnName("ISsalePercent");

        builder.Property(e => e.Istax)
            .HasColumnName("ISTax")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.JobId).HasColumnName("JobID");

        builder.Property(e => e.JobState).HasMaxLength(50);

        builder.Property(e => e.Leave).HasDefaultValueSql("((0))");

        builder.Property(e => e.Mail)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("mail");

        builder.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");

        builder.Property(e => e.Mobile1)
            .HasMaxLength(20)
            .HasColumnName("mobile1");

        builder.Property(e => e.Mobile2)
            .HasMaxLength(20)
            .HasColumnName("mobile2");

        builder.Property(e => e.NationalityId).HasColumnName("NationalityID");

        builder.Property(e => e.Num).HasColumnName("num");

        builder.Property(e => e.PaymentMethod).HasDefaultValueSql("((0))");

        builder.Property(e => e.PayrollScheduleId)
            .HasColumnName("PayrollScheduleID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.PeriodGroup)
            .HasMaxLength(50)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.PersonalId)
            .HasMaxLength(50)
            .HasColumnName("PersonalID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Phone)
            .HasMaxLength(20)
            .HasColumnName("phone");

        builder.Property(e => e.Raseed)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("raseed");

        builder.Property(e => e.Raseedkhasm)
            .HasColumnType("money")
            .HasColumnName("raseedkhasm");

        builder.Property(e => e.Rate)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Refusal).HasDefaultValueSql("((0))");

        builder.Property(e => e.Regnum)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("regnum");

        builder.Property(e => e.Rent)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("rent")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ResidencePeriod).HasColumnType("numeric(18, 0)");

        builder.Property(e => e.RoName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.RuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.SalaryGroupId).HasColumnName("SalaryGroupID");

        builder.Property(e => e.SalaryId)
            .HasColumnName("SalaryID")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Salepercent)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("salepercent");

        builder.Property(e => e.SectorId).HasColumnName("SectorID");

        builder.Property(e => e.ServiceCredit)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ServiceDebit)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Sex)
            .HasMaxLength(20)
            .IsUnicode(false);

        builder.Property(e => e.Sons).HasColumnName("sons");

        builder.Property(e => e.StopSalary).HasDefaultValueSql("((0))");

        builder.Property(e => e.Students).HasColumnName("students");

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Timevalue)
            .HasColumnType("numeric(19, 5)")
            .HasColumnName("timevalue")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalDebit)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalPledgeCredit)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalPledgeDebit)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalSalary)
            .HasColumnType("numeric(19, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TuName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt1)
            .HasMaxLength(150)
            .HasColumnName("txt1")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt2)
            .HasMaxLength(150)
            .HasColumnName("txt2")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt3)
            .HasMaxLength(150)
            .HasColumnName("txt3")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt4)
            .HasMaxLength(150)
            .HasColumnName("txt4")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt5)
            .HasMaxLength(150)
            .HasColumnName("txt5")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt6)
            .HasMaxLength(150)
            .HasColumnName("txt6")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt7)
            .HasMaxLength(150)
            .HasColumnName("txt7")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.Txt8)
            .HasMaxLength(150)
            .HasColumnName("txt8")
            .HasDefaultValueSql("('')");

        builder.Property(e => e.UrName)
            .HasMaxLength(150)
            .HasDefaultValueSql("('')");

        builder.Property(e => e.WorkIn).HasDefaultValueSql("((0))");
    }
}