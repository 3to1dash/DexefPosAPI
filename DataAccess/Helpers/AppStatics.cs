namespace DataAccess.Helpers;

public static class AppStatics
{
    public static List<string> UserSelectedPermissions = new()
    {
        "Sale", "ReSale", "SaleQoute", "SaleEstimate", "Purchase", "RePurchase", "PurchaseQuote", "PurchaseOrder",
        "cash_recieved", "cash_paid", "spend", "income", "Cust", "Vendor", "items", "DeleteGridRow", "saleforbid",
        "EditNumber", "EditDate", "billclass", "choosecolum", "CurrencyEdit", "CurrencyEditRate", "SetInvoiceDiscount",
        "SaleBillExtra", "EditItemDiscountInBill", "salebillcost", "editbillbounes", "Quotacontrol", "CanSaleFree",
        "CanSelectItemSerial", "AccountingDashBoard", "BankDashboard", "BanksReportsDashboard", "cash_paidDashBoard",
        "cash_recievedDashBoard", "ConsignmentDashBoard", "CustDashboard", "incomeDashBoard", "IssueRequestsDashBoard",
        "itemassemblyDashBoard", "ItemDashBoard", "itemdisassemblyDashBoard", "itemgiftDashBoard", "ProfitDashBoard",
        "PurchaseConfirmDashBoard", "PurchaseDashBoard", "PurchaseOrderDashBoard", "PurchaseQuoteDashBoard",
        "PurchaseQuoteRecieveDashBoard", "ReceiveRequestsDashBoard", "RePurchaseDashBoard", "ReSaleDashBoard",
        "ReSaleReviewDashBoard", "rptBillDashBoard", "RptCashDashBoard", "RPtCashMainLevelDashboard",
        "RptCustDashBoard", "RptItemDashBoard", "SaleConfirmDashBoard", "SaleDashBoard", "SaleEstimateDashBoard",
        "SaleOrderDashBoard", "SaleQouteDashBoard", "SaleReviewDashBoard", "spendDashBoard", "storagedealDashBoard",
        "StoreCharityDashBoard", "StoreConvertDashBoard", "StoreDashBoard", "StoreHalekDashBoard", "StoreINDashBoard",
        "StoreInTransferDashBoard", "StoreIssueDashBoard", "StoreOutDashBoard", "StoreOutTransferDashBoard",
        "StorePackingCancelDashBoard", "StorePackingDashBoard", "StorePackingOrderDashBoard", "StoreRecieveDashBoard",
        "StoreRequestsDashBoard", "StoreSendOrderDashBoard", "StoreTransferOrderDashBoard", "VendorDashboard", "26",
        "14", "21", "33", "RPtCashMainLevel", "dailyfinalreport", "rptcompanydaily", "AccountingReports"
    };
}
