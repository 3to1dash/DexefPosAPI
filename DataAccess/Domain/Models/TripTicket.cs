namespace DataAccess.Domain.Models;

public class TripTicket
{
    public int Id { get; set; }
    public string? Prefix { get; set; }
    public decimal? Num { get; set; }
    public string? BillNum { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public string? Status { get; set; }
    public long? TicketNumber { get; set; }
    public long? OldTicketNumber { get; set; }
    public DateTime? IssueDate { get; set; }
    public string? Pnr { get; set; }
    public int? TripGdsId { get; set; }
    public int? Itinerary { get; set; }
    public int? SegmentCount { get; set; }
    public int? TripDirection { get; set; }
    public int? TripUsersId { get; set; }
    public int? VendorId { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Tax1 { get; set; }
    public decimal? Tax2 { get; set; }
    public decimal? Tax3 { get; set; }
    public decimal? Tax4 { get; set; }
    public decimal? TotalTax { get; set; }
    public decimal? NetAmount { get; set; }
    public bool? IsAirLineVendorPerc { get; set; }
    public decimal? AirLineVendorPerc { get; set; }
    public decimal? AirLineVendorComm { get; set; }
    public int? AirLineCustomerId { get; set; }
    public bool? IsAirLineCustomerPerc { get; set; }
    public decimal? AirLineCustomerPerc { get; set; }
    public decimal? AirLineCustomerComm { get; set; }
    public decimal? AirLinePurchaseVat { get; set; }
    public decimal? AirLineSellVat { get; set; }
    public decimal? CancelFees { get; set; }
    public int? PurchaseCommId { get; set; }
    public decimal? PurchaseCommPerc { get; set; }
    public decimal? PurchaseComm { get; set; }
    public decimal? VendorCost { get; set; }
    public int? CustId { get; set; }
    public bool? IsCommisionPerc { get; set; }
    public decimal? CommisionPerc { get; set; }
    public decimal? Commision { get; set; }
    public decimal? CommisionVat { get; set; }
    public int? SellCommId { get; set; }
    public decimal? SellCommPerc { get; set; }
    public decimal? SellComm { get; set; }
    public bool? IsDiscountPerc { get; set; }
    public decimal? DiscountPerc { get; set; }
    public decimal? Discount { get; set; }
    public decimal? CustomerCost { get; set; }
    public int? TaxId { get; set; }
    public decimal? TaxPerc { get; set; }
    public decimal? PurchaseTicketVat { get; set; }
    public decimal? PurchaseAirlineVat { get; set; }
    public decimal? PurchaseSliceCommVat { get; set; }
    public decimal? SellTicketVat { get; set; }
    public decimal? SellSliceCommVat { get; set; }
    public decimal? SellCommVat { get; set; }
    public decimal? SellAirLineVat { get; set; }
    public decimal? Vat { get; set; }
    public decimal? TotalAfterVat { get; set; }
    public decimal? TotalAfterComm { get; set; }
    public string? WrittenBy { get; set; }
    public string? FlightNumber { get; set; }
    public decimal? TaskId { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public string? FileName { get; set; }
    public string? Note { get; set; }
    public int? AirLineId { get; set; }
    public string? CarrierCode { get; set; }
    public string? UserCode { get; set; }
    public int? SaleId { get; set; }
    public int? SaleCostId { get; set; }
    public int? RegNum { get; set; }
    public int? CostId { get; set; }
    public Guid Rowguid { get; set; }
    public string? OfficeId { get; set; }
    public string? IataNumber { get; set; }
    public int? PayIndex { get; set; }
    public int? PaymentId { get; set; }
    public decimal? Paid { get; set; }
    public long? CustPeriodId { get; set; }
    public long? VendorPeriodId { get; set; }
    public decimal? Amount1 { get; set; }
    public decimal? Amount2 { get; set; }
    public decimal? Amount3 { get; set; }
    public string? Class { get; set; }
    public string? Passenger { get; set; }
    public string? PassengerType { get; set; }
    public string? PassengerPhone { get; set; }
    public string? PassengerMail { get; set; }
    public string? DepartCity { get; set; }
    public string? DepartDate { get; set; }
    public string? DepartTime { get; set; }
    public string? ArriveCity { get; set; }
    public string? ArriveDate { get; set; }
    public string? ArriveTime { get; set; }
    public string? Routes { get; set; }
    public int? MotalbaId { get; set; }
    public decimal? PayAmount { get; set; }
    public int? PeriodId { get; set; }
    public int? Cpu { get; set; }
    public decimal? Total { get; set; }
    public decimal? TotalDiscount { get; set; }
    public decimal? TotalAddittion { get; set; }
    public decimal? TotalTaxes { get; set; }
    public decimal? NetTotal { get; set; }
    public bool? Attach { get; set; }

    public virtual CompanyBranch? Branch { get; set; }
    public virtual Cust? Cust { get; set; }
    public virtual Taxes? Tax { get; set; }
    public virtual TripGd? TripGds { get; set; }
    public virtual TripUser? TripUsers { get; set; }
    public virtual Cust? Vendor { get; set; }
}