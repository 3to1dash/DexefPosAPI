using DataAccess.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Infrastructure.Persistence.DXConfigurations;

public class EticketTempConfiguration : IEntityTypeConfiguration<EticketTemp>
{


    public void Configure(EntityTypeBuilder<EticketTemp> builder)
    {
        builder.HasNoKey();

        builder.ToView("ETicketTemp");

        builder.Property(e => e.AirLine).HasMaxLength(150);

        builder.Property(e => e.AirLineCode).HasMaxLength(5);

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

        builder.Property(e => e.AirLineVendorComm).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.AirLineVendorPerc).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Amount).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Amount1).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Amount2).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Amount3).HasColumnType("numeric(18, 5)");

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

        builder.Property(e => e.CustGroup).HasMaxLength(400);

        builder.Property(e => e.CustId).HasColumnName("CustID");

        builder.Property(e => e.CustPeriodId).HasColumnName("CustPeriodID");

        builder.Property(e => e.Customer).HasMaxLength(400);

        builder.Property(e => e.CustomerCost).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.DepartCity).HasMaxLength(50);

        builder.Property(e => e.DepartDate).HasMaxLength(50);

        builder.Property(e => e.DepartTime).HasMaxLength(50);

        builder.Property(e => e.Discount).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.DiscountPerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.Dt)
            .HasColumnType("datetime")
            .HasColumnName("DT");

        builder.Property(e => e.FileName).HasMaxLength(50);

        builder.Property(e => e.FlightNumber)
            .HasMaxLength(50)
            .HasColumnName("FLightNumber");

        builder.Property(e => e.IataNumber).HasMaxLength(50);

        builder.Property(e => e.Id).HasColumnName("id");

        builder.Property(e => e.IssueDate).HasColumnType("datetime");

        builder.Property(e => e.NetAmount).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.NetTotal).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Note).HasMaxLength(550);

        builder.Property(e => e.Num)
            .HasColumnType("numeric(18, 0)")
            .HasColumnName("num");

        builder.Property(e => e.OfficeId)
            .HasMaxLength(50)
            .HasColumnName("OfficeID");

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

        builder.Property(e => e.ProvidorName).HasMaxLength(50);

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

        builder.Property(e => e.Rowguid).HasColumnName("rowguid");

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

        builder.Property(e => e.Tax1).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Tax2).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Tax3).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.Tax4).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TaxId).HasColumnName("TaxID");

        builder.Property(e => e.TaxPerc).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.TicketItenrary)
            .HasMaxLength(3)
            .IsUnicode(false);

        builder.Property(e => e.Total).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TotalAddittion).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TotalAfterComm).HasColumnType("numeric(18, 5)");

        builder.Property(e => e.TotalAfterVat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("TotalAfterVAT");

        builder.Property(e => e.TotalDiscount).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TotalTax).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TotalTaxes).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.TripGdsId).HasColumnName("Trip_GdsId");

        builder.Property(e => e.TripUsersId).HasColumnName("Trip_UsersId");

        builder.Property(e => e.UserCode).HasMaxLength(50);

        builder.Property(e => e.UserName).HasMaxLength(50);

        builder.Property(e => e.Vat)
            .HasColumnType("decimal(38, 12)")
            .HasColumnName("VAT");

        builder.Property(e => e.Vendor).HasMaxLength(400);

        builder.Property(e => e.VendorCost).HasColumnType("decimal(38, 12)");

        builder.Property(e => e.VendorId).HasColumnName("VendorID");

        builder.Property(e => e.VendorPeriodId).HasColumnName("VendorPeriodID");

        builder.Property(e => e.WrittenBy).HasMaxLength(50);
    }
}