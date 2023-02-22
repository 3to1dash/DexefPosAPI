using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class TripTicketConfiguration : IEntityTypeConfiguration<TripTicket>
{


    public void Configure(EntityTypeBuilder<TripTicket> builder)
    {
        builder.ToTable("Trip_Ticket");

        builder.HasIndex(e => new { e.BranchId, e.CustId, e.CustPeriodId }, "IX_Trip_Ticket_BranchID_CustID_CustPeriodID_8E177");

        builder.HasIndex(e => new { e.BranchId, e.CustId, e.IssueDate }, "IX_Trip_Ticket_BranchID_CustID_IssueDate_AEF83");

        builder.HasIndex(e => new { e.BranchId, e.CustId, e.IssueDate }, "IX_Trip_Ticket_BranchID_CustID_IssueDate_E115B");

        builder.HasIndex(e => new { e.BranchId, e.CustomerCost, e.Dt }, "IX_Trip_Ticket_BranchID_CustomerCost_DT_0EDCC");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_14052");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_1F293");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_2FB8D");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_488C5");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_6DAC8");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_78B6D");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_78FD0");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_7A2C2");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_9410B");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_A9C61");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_B6FF1");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_CC91B");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_CE9F2");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Commision }, "IX_Trip_Ticket_BranchID_DT_Commision_5258F");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Commision }, "IX_Trip_Ticket_BranchID_DT_Commision_55A87");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Commision }, "IX_Trip_Ticket_BranchID_DT_Commision_94029");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Commision }, "IX_Trip_Ticket_BranchID_DT_Commision_E5444");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_D4895");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_D6C85");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_D6F38");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_E365B");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_F8B5E");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_F93B6");

        builder.HasIndex(e => new { e.BranchId, e.Dt }, "IX_Trip_Ticket_BranchID_DT_FF429");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_Ticket_BranchID_DT_IssueDate_059A2");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_Ticket_BranchID_DT_IssueDate_0C789");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_Ticket_BranchID_DT_IssueDate_16883");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_Ticket_BranchID_DT_IssueDate_19603");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_Ticket_BranchID_DT_IssueDate_42416");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_Ticket_BranchID_DT_IssueDate_713F0");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_Ticket_BranchID_DT_IssueDate_71CE5");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_Ticket_BranchID_DT_IssueDate_8280D");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_Ticket_BranchID_DT_IssueDate_A2DEF");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_Ticket_BranchID_DT_IssueDate_B2445");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_Ticket_BranchID_DT_IssueDate_D5660");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_Ticket_BranchID_DT_IssueDate_DE592");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.IssueDate }, "IX_Trip_Ticket_BranchID_DT_IssueDate_DE87E");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_Ticket_BranchID_DT_PNR_12BED");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_Ticket_BranchID_DT_PNR_2E584");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_Ticket_BranchID_DT_PNR_6220E");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_Ticket_BranchID_DT_PNR_878E4");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_Ticket_BranchID_DT_PNR_9458F");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_Ticket_BranchID_DT_PNR_A9477");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_Ticket_BranchID_DT_PNR_B1C29");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_Ticket_BranchID_DT_PNR_D0981");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Pnr }, "IX_Trip_Ticket_BranchID_DT_PNR_EB0F5");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Passenger }, "IX_Trip_Ticket_BranchID_DT_Passenger_C2A7D");

        builder.HasIndex(e => new { e.BranchId, e.Dt, e.Passenger }, "IX_Trip_Ticket_BranchID_DT_Passenger_DC26C");

        builder.HasIndex(e => e.BranchId, "IX_Trip_Ticket_BranchID_F6733");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.IssueDate }, "IX_Trip_Ticket_BranchID_GDS_IssueDate_135A2");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.IssueDate }, "IX_Trip_Ticket_BranchID_GDS_IssueDate_324A6");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.IssueDate }, "IX_Trip_Ticket_BranchID_GDS_IssueDate_6D26D");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.IssueDate }, "IX_Trip_Ticket_BranchID_GDS_IssueDate_E3A60");

        builder.HasIndex(e => new { e.BranchId, e.TripGdsId, e.IssueDate }, "IX_Trip_Ticket_BranchID_GDS_IssueDate_EA0B5");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate }, "IX_Trip_Ticket_BranchID_IssueDate_25853");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate }, "IX_Trip_Ticket_BranchID_IssueDate_2EB43");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate }, "IX_Trip_Ticket_BranchID_IssueDate_3C5C8");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate }, "IX_Trip_Ticket_BranchID_IssueDate_3C7EF");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate }, "IX_Trip_Ticket_BranchID_IssueDate_4F869");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate }, "IX_Trip_Ticket_BranchID_IssueDate_54E66");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate }, "IX_Trip_Ticket_BranchID_IssueDate_6512A");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate }, "IX_Trip_Ticket_BranchID_IssueDate_6F6DB");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate }, "IX_Trip_Ticket_BranchID_IssueDate_75117");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate }, "IX_Trip_Ticket_BranchID_IssueDate_7702B");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate }, "IX_Trip_Ticket_BranchID_IssueDate_7D92B");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate }, "IX_Trip_Ticket_BranchID_IssueDate_7FC82");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate }, "IX_Trip_Ticket_BranchID_IssueDate_8B944");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate }, "IX_Trip_Ticket_BranchID_IssueDate_97B41");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate }, "IX_Trip_Ticket_BranchID_IssueDate_A539F");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate }, "IX_Trip_Ticket_BranchID_IssueDate_BD3E8");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate }, "IX_Trip_Ticket_BranchID_IssueDate_BF470");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate }, "IX_Trip_Ticket_BranchID_IssueDate_D17CB");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate }, "IX_Trip_Ticket_BranchID_IssueDate_FB1BB");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate, e.Pnr }, "IX_Trip_Ticket_BranchID_IssueDate_PNR_2485F");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate, e.Pnr }, "IX_Trip_Ticket_BranchID_IssueDate_PNR_86252");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate, e.Pnr }, "IX_Trip_Ticket_BranchID_IssueDate_PNR_96B82");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate, e.Pnr }, "IX_Trip_Ticket_BranchID_IssueDate_PNR_A0196");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate, e.Pnr }, "IX_Trip_Ticket_BranchID_IssueDate_PNR_EF278");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate, e.Passenger }, "IX_Trip_Ticket_BranchID_IssueDate_Passenger_CE599");

        builder.HasIndex(e => new { e.BranchId, e.IssueDate, e.Passenger }, "IX_Trip_Ticket_BranchID_IssueDate_Passenger_EA143");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt }, "IX_Trip_Ticket_BranchID_Status_DT_10782");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt }, "IX_Trip_Ticket_BranchID_Status_DT_54B5A");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt }, "IX_Trip_Ticket_BranchID_Status_DT_8A104");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt }, "IX_Trip_Ticket_BranchID_Status_DT_A201B");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt }, "IX_Trip_Ticket_BranchID_Status_DT_CC102");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt }, "IX_Trip_Ticket_BranchID_Status_DT_D01C6");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt }, "IX_Trip_Ticket_BranchID_Status_DT_F0CC5");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt }, "IX_Trip_Ticket_BranchID_Status_DT_FD788");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.IssueDate }, "IX_Trip_Ticket_BranchID_Status_DT_IssueDate_BFD3E");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.IssueDate }, "IX_Trip_Ticket_BranchID_Status_DT_IssueDate_C456A");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.IssueDate }, "IX_Trip_Ticket_BranchID_Status_DT_IssueDate_CF5E6");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.IssueDate }, "IX_Trip_Ticket_BranchID_Status_DT_IssueDate_D0259");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.Dt, e.IssueDate }, "IX_Trip_Ticket_BranchID_Status_DT_IssueDate_D2672");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.TripGdsId, e.IssueDate }, "IX_Trip_Ticket_BranchID_Status_GDS_IssueDate_01C6C");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.TripGdsId, e.IssueDate }, "IX_Trip_Ticket_BranchID_Status_GDS_IssueDate_50A4E");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.IssueDate }, "IX_Trip_Ticket_BranchID_Status_IssueDate_0B08B");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.IssueDate }, "IX_Trip_Ticket_BranchID_Status_IssueDate_2337E");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.IssueDate }, "IX_Trip_Ticket_BranchID_Status_IssueDate_4B09F");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.IssueDate }, "IX_Trip_Ticket_BranchID_Status_IssueDate_DA226");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.IssueDate }, "IX_Trip_Ticket_BranchID_Status_IssueDate_EAAF9");

        builder.HasIndex(e => new { e.BranchId, e.Status, e.IssueDate }, "IX_Trip_Ticket_BranchID_Status_IssueDate_F6A96");

        builder.HasIndex(e => new { e.BranchId, e.TicketNumber, e.IssueDate }, "IX_Trip_Ticket_BranchID_TicketNumber_IssueDate_696FF");

        builder.HasIndex(e => new { e.BranchId, e.TicketNumber, e.IssueDate, e.Pnr }, "IX_Trip_Ticket_BranchID_TicketNumber_IssueDate_PNR_2734B");

        builder.HasIndex(e => new { e.BranchId, e.TicketNumber, e.IssueDate, e.Passenger }, "IX_Trip_Ticket_BranchID_TicketNumber_IssueDate_Passenger_68599");

        builder.HasIndex(e => new { e.BranchId, e.VendorCost, e.Dt }, "IX_Trip_Ticket_BranchID_VendorCost_DT_B059E");

        builder.HasIndex(e => new { e.BranchId, e.VendorId, e.Dt }, "IX_Trip_Ticket_BranchID_VendorID_DT_00F14");

        builder.HasIndex(e => new { e.BranchId, e.VendorId, e.Dt }, "IX_Trip_Ticket_BranchID_VendorID_DT_2CC21");

        builder.HasIndex(e => new { e.BranchId, e.VendorId, e.Dt }, "IX_Trip_Ticket_BranchID_VendorID_DT_48F98");

        builder.HasIndex(e => new { e.BranchId, e.VendorId, e.Dt }, "IX_Trip_Ticket_BranchID_VendorID_DT_8E63A");

        builder.HasIndex(e => new { e.BranchId, e.VendorId, e.Dt }, "IX_Trip_Ticket_BranchID_VendorID_DT_BFAA8");

        builder.HasIndex(e => new { e.BranchId, e.VendorId, e.IssueDate }, "IX_Trip_Ticket_BranchID_VendorID_IssueDate_3DC78");

        builder.HasIndex(e => new { e.BranchId, e.VendorId, e.IssueDate }, "IX_Trip_Ticket_BranchID_VendorID_IssueDate_80143");

        builder.HasIndex(e => new { e.BranchId, e.VendorId, e.IssueDate }, "IX_Trip_Ticket_BranchID_VendorID_IssueDate_F155B");

        builder.HasIndex(e => new { e.BranchId, e.VendorId, e.IssueDate }, "IX_Trip_Ticket_BranchID_VendorID_IssueDate_F76BE");

        builder.HasIndex(e => new { e.BranchId, e.VendorId, e.IssueDate, e.Pnr }, "IX_Trip_Ticket_BranchID_VendorID_IssueDate_PNR_3D69F");

        builder.HasIndex(e => new { e.BranchId, e.VendorId, e.IssueDate, e.Pnr }, "IX_Trip_Ticket_BranchID_VendorID_IssueDate_PNR_9771A");

        builder.HasIndex(e => new { e.BranchId, e.VendorId, e.IssueDate, e.Pnr }, "IX_Trip_Ticket_BranchID_VendorID_IssueDate_PNR_FF420");

        builder.HasIndex(e => new { e.BranchId, e.VendorId, e.IssueDate, e.Status }, "IX_Trip_Ticket_BranchID_VendorID_IssueDate_Status_B405B");

        builder.HasIndex(e => new { e.BranchId, e.VendorId, e.VendorPeriodId }, "IX_Trip_Ticket_BranchID_VendorID_VendorPeriodID_B0FAB");

        builder.HasIndex(e => new { e.CustId, e.IssueDate }, "IX_Trip_Ticket_CustID_IssueDate_91E80");

        builder.HasIndex(e => new { e.CustId, e.IssueDate }, "IX_Trip_Ticket_CustID_IssueDate_F7889");

        builder.HasIndex(e => e.CustPeriodId, "IX_Trip_Ticket_CustPeriodID_35B9A");

        builder.HasIndex(e => e.CustPeriodId, "IX_Trip_Ticket_CustPeriodID_CC5AF");

        builder.HasIndex(e => e.CustPeriodId, "IX_Trip_Ticket_CustPeriodID_F879D");

        builder.HasIndex(e => e.Pnr, "IX_Trip_Ticket_PNR_517E0");

        builder.HasIndex(e => new { e.Status, e.CustId }, "IX_Trip_Ticket_Status_CustID_8ECF0");

        builder.HasIndex(e => e.TaskId, "IX_Trip_Ticket_TaskID_AA598");

        builder.HasIndex(e => e.TicketNumber, "IX_Trip_Ticket_TicketNumber_D66D2");

        builder.HasIndex(e => new { e.TicketNumber, e.VendorId }, "IX_Trip_Ticket_TicketNumber_VendorID_4F6A5");

        builder.HasIndex(e => new { e.TicketNumber, e.VendorId }, "IX_Trip_Ticket_TicketNumber_VendorID_50DB5");

        builder.HasIndex(e => new { e.TicketNumber, e.VendorId }, "IX_Trip_Ticket_TicketNumber_VendorID_5EDBC");

        builder.HasIndex(e => new { e.TicketNumber, e.VendorId }, "IX_Trip_Ticket_TicketNumber_VendorID_8B491");

        builder.HasIndex(e => new { e.VendorId, e.IssueDate }, "IX_Trip_Ticket_VendorID_IssueDate_BE847");

        builder.HasIndex(e => new { e.VendorId, e.TicketNumber }, "IX_Trip_Ticket_VendorID_TicketNumber_2C782");

        builder.HasIndex(e => new { e.VendorId, e.Id, e.TicketNumber }, "IX_Trip_Ticket_VendorID_id_TicketNumber_584B8");

        builder.HasIndex(e => e.VendorPeriodId, "IX_Trip_Ticket_VendorPeriodID_2B565");

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.AirLineCustomerComm).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.AirLineCustomerId).HasColumnName("AirLineCustomerID");

        builder.Property(e => e.AirLineCustomerPerc).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.AirLineId).HasColumnName("AirLineID");

        builder.Property(e => e.AirLinePurchaseVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("AirLinePurchaseVAT");

        builder.Property(e => e.AirLineSellVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("AirLineSellVAT");

        builder.Property(e => e.AirLineVendorComm)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.AirLineVendorPerc)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Amount).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Amount1)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Amount2)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Amount3)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.ArriveCity).HasMaxLength(50);

        builder.Property(e => e.ArriveDate).HasMaxLength(50);

        builder.Property(e => e.ArriveTime).HasMaxLength(50);

        builder.Property(e => e.BillNum)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.BranchId).HasColumnName("BranchID");

        builder.Property(e => e.CancelFees).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.CarrierCode).HasMaxLength(50);

        builder.Property(e => e.Class).HasMaxLength(40);

        builder.Property(e => e.Commision).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.CommisionPerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.CommisionVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("CommisionVAT");

        builder.Property(e => e.CostId).HasColumnName("CostID");

        builder.Property(e => e.Cpu).HasColumnName("CPU");

        builder.Property(e => e.Currency).HasMaxLength(5);

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.CustPeriodId).HasColumnName("CustPeriodID");

        builder.Property(e => e.CustomerCost).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.DepartCity).HasMaxLength(50);

        builder.Property(e => e.DepartDate).HasMaxLength(50);

        builder.Property(e => e.DepartTime).HasMaxLength(50);

        builder.Property(e => e.Discount)
            .HasColumnType("numeric(18, 5)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.DiscountPerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.FileName).HasMaxLength(50);

        builder.Property(e => e.FlightNumber)
            .HasMaxLength(50)
            .HasColumnName("FLightNumber");

        builder.Property(e => e.IataNumber).HasMaxLength(50);

        builder.Property(e => e.IssueDate).HasColumnType("datetime");

        builder.Property(e => e.NetAmount)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.NetTotal).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Note).HasMaxLength(550);

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.OfficeId)
            .HasMaxLength(50)
            .HasColumnName("OfficeID");

        builder.Property(e => e.OldTicketNumber).HasDefaultValueSql("((0))");

        builder.Property(e => e.Paid).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Passenger).HasMaxLength(250);

        builder.Property(e => e.PassengerMail).HasMaxLength(150);

        builder.Property(e => e.PassengerPhone).HasMaxLength(100);

        builder.Property(e => e.PassengerType).HasMaxLength(50);

        builder.Property(e => e.PayAmount).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.PaymentId).HasColumnName("PaymentID");

        builder.Property(e => e.PeriodId).HasColumnName("PeriodID");

        builder.Property(e => e.Pnr)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("PNR");

        builder.Property(e => e.Prefix)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.PurchaseAirlineVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("PurchaseAirlineVAT");

        builder.Property(e => e.PurchaseComm).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.PurchaseCommId).HasColumnName("PurchaseCommID");

        builder.Property(e => e.PurchaseCommPerc).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.PurchaseSliceCommVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("PurchaseSliceCommVAT");

        builder.Property(e => e.PurchaseTicketVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("PurchaseTicketVAT");

        builder.Property(e => e.Rate).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Routes).HasMaxLength(350);

        builder.Property(e => e.Rowguid)
            .HasColumnName("rowguid")
            .HasDefaultValueSql("(newsequentialid())");

        builder.Property(e => e.SaleCostId).HasColumnName("SaleCostID");

        builder.Property(e => e.SaleId).HasColumnName("SaleID");

        builder.Property(e => e.SellAirLineVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("SellAirLineVAT");

        builder.Property(e => e.SellComm).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.SellCommId).HasColumnName("SellCommID");

        builder.Property(e => e.SellCommPerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.SellCommVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("SellCommVAT");

        builder.Property(e => e.SellSliceCommVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("SellSliceCommVAT");

        builder.Property(e => e.SellTicketVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("SellTicketVAT");

        builder.Property(e => e.Status)
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.Property(e => e.TaskId)
            .HasColumnType("numeric(19, 15)")
            .HasColumnName("TaskID");

        builder.Property(e => e.Tax1)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Tax2)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Tax3)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.Tax4)
            .HasColumnType("decimal(38, 12)")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.TaxPerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Total).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TotalAddittion).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TotalAfterComm).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.TotalAfterVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("TotalAfterVAT")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.TotalDiscount).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TotalTax).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TotalTaxes).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TripGdsId).HasColumnName("Trip_GdsId");

        builder.Property(e => e.TripUsersId).HasColumnName("Trip_UsersId");

        builder.Property(e => e.UserCode).HasMaxLength(50);

        builder.Property(e => e.Vat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("VAT")
            .HasDefaultValueSql("((0))");

        builder.Property(e => e.VendorCost).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.VendorId).HasColumnName("VendorID");

        builder.Property(e => e.VendorPeriodId).HasColumnName("VendorPeriodID");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);

        builder.HasOne(d => d.Branch)
            .WithMany(p => p.TripTickets)
            .HasForeignKey(d => d.BranchId)
            .HasConstraintName("FK_Trip_Ticket_Company_Branch");

        builder.HasOne(d => d.Cust)
            .WithMany(p => p.TripTicketCusts)
            .HasForeignKey(d => d.CustId)
            .HasConstraintName("FK_Trip_Ticket_Cust1");

        builder.HasOne(d => d.Tax)
            .WithMany(p => p.TripTickets)
            .HasForeignKey(d => d.TaxId)
            .HasConstraintName("FK_Trip_Ticket_Taxes");

        builder.HasOne(d => d.TripGds)
            .WithMany(p => p.TripTickets)
            .HasForeignKey(d => d.TripGdsId)
            .HasConstraintName("FK_Trip_Ticket_Trip_GDS");

        builder.HasOne(d => d.TripUsers)
            .WithMany(p => p.TripTickets)
            .HasForeignKey(d => d.TripUsersId)
            .HasConstraintName("FK_Trip_Ticket_Trip_Users");

        builder.HasOne(d => d.Vendor)
            .WithMany(p => p.TripTicketVendors)
            .HasForeignKey(d => d.VendorId)
            .HasConstraintName("FK_Trip_Ticket_Cust");
    }
}