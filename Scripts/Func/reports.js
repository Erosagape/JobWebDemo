//this function bind for label using in reports
function ShowCompany(d) {
    let c = DummyCompanyData();
    $(d).html('<b>' + c.CompanyName + '</b>'
        + '<br/>' + c.CompanyAddress1
        + ' '
        + c.CompanyAddress2);
}
function ShowCountry(path, CountryID, ControlID) {
    $(ControlID).text('-');
    if (CountryID != "") {
        $.get(path + 'Master/GetCountry?Code=' + CountryID)
            .done(function (r) {
                if (r.country.data.length > 0) {
                    let b = r.country.data[0];
                    $(ControlID).text(b.CTYName);
                }
            });
    }
}
function ShowInterPort(path, CountryID, PortCode, ControlID) {
    $(ControlID).text('-');
    $.get(path + 'Master/GetInterPort?Code=' + PortCode + '&Key=' + CountryID)
        .done(function (r) {
            if (r.interport.data.length > 0) {
                let b = r.interport.data[0];
                $(ControlID).text(b.PortName);
            }
        });
}
function ShowReleasePort(path, Code, ControlID) {
    $(ControlID).text('-');
    $.get(path + 'Master/GetCustomsPort?Code=' + Code)
        .done(function (r) {
            if (r.RFARS.data.length > 0) {
                let b = r.RFARS.data[0];
                $(ControlID).text(b.AreaName);
            }
        });
}
function ShowVender(path, VenderID, ControlID) {
    $(ControlID).text('-');
    if (VenderID != "") {
        $.get(path + 'Master/GetVender?Code=' + VenderID)
            .done(function (r) {
                if (r.vender.data.length > 0) {
                    let b = r.vender.data[0];
                    $(ControlID).text(b.TName);
                }
            });
    }
}
function ShowDeclareType(path, Code, ControlID) {
    $(ControlID).text('-');
    $.get(path + 'Master/GetDeclareType?Code=' + Code)
        .done(function (r) {
            if (r.RFDCT.data.length > 0) {
                let b = r.RFDCT.data[0];
                $(ControlID).text(b.Description);
            }
        });
}
function ShowUser(path, UserID, ControlID) {
    $(ControlID).text('-');
    if (UserID != "") {
        $.get(path + 'Master/GetUser?Code=' + UserID)
            .done(function (r) {
                if (r.user.data.length > 0) {
                    let b = r.user.data[0];
                    $(ControlID).text(b.TName);
                }
            });
    }
}
function ShowConfig(path, Code, Key, ControlID) {
    $.get(path + 'Config/GetConfig?Code=' + Code + '&Key=' + Key)
        .done(function (r) {
            let b = r.config.data;
            if (b.length > 0) {
                $(ControlID).text(b[0].ConfigValue);
            }
        });
}
function ShowUserSign(path, UserID, ControlID) {
    if (UserID != "") {
        $.get(path + 'Master/GetUser?Code=' + UserID)
            .done(function (r) {
                if (r.user.data.length > 0) {
                    let b = r.user.data[0];
                    $(ControlID).text('(' + b.TName + ')');
                }
            });
    }
}
function GetPaymentType(p) {
    switch (p) {
        case 'CA':
            return 'Cash/Transfer';
            break;
        case 'CH':
            return 'Cashier Cheque';
            break;
        case 'CU':
            return 'Customer Cheque';
            break;
        case 'CR':
            return 'Credit';
            break;
    }
}
function GetVoucherType() {
    switch (vcType) {
        case 'P':
            return 'PAYMENT';
            break;
        case 'R':
            return 'RECEIVE';
            break;
        default:
            return '';
            break;
    }
}
function ShowCustomer(path, Code, Branch, ControlID) {
    $(ControlID).val('');
    if ((Code + Branch).length > 0) {
        $.get(path + 'Master/GetCompany?Code=' + Code + '&Branch=' + Branch)
            .done(function (r) {
                if (r.company.data.length > 0) {
                    let c = r.company.data[0];
                    $(ControlID).text(c.NameThai);
                }
            });
    }
}
function LoadReport(reportID) {
    switch (reportID) {
        case 'AccruedSum':
            break;
        case 'Adjustment':
            break;
        case 'AdvBalance':
            break;
        case 'AdvBilled':
            break;
        case 'AdvCleared':
            break;
        case 'AdvDailyPay':
            break;
        case 'AdvDailyReq':
            break;
        case 'AdvFollow':
            break;
        case 'AdvMonthly':
            break;
        case 'AdvOnclear':
            break;
        case 'AdvOngoing':
            break;
        case 'AdvSumClear':
            break;
        case 'AdvWeekly':
            break;
        case 'APDaily':
            break;
        case 'APDetail':
            break;
        case 'ARDetail':
            break;
        case 'ARSummary':
            break;
        case 'BalanceSheet':
            break;
        case 'BillDaily':
            break;
        case 'BillDue':
            break;
        case 'BillOverdue':
            break;
        case 'BillSummary':
            break;
        case 'BookFlow':
            break;
        case 'CashFlow':
            break;
        case 'CashPredict':
            break;
        case 'ChqPayDaily':
            break;
        case 'ChqRcvDaily':
            break;
        case 'ClrBilled':
            break;
        case 'ClrDaily':
            break;
        case 'ClrOngoing':
            break;
        case 'CNDNDaily':
            break;
        case 'CostingDetail':
            break;
        case 'GLBatch':
            break;
        case 'InvBilled':
            break;
        case 'InvDaily':
            break;
        case 'InvOnhold':
            break;
        case 'InvStatus':
            break;
        case 'InvSummary':
            break;
        case 'JobClearing':
            break;
        case 'JobCosting':
            break;
        case 'JobKPI':
            break;
        case 'JobOperComplete':
            break;
        case 'JobOperDaily':
            break;
        case 'JobOperEmp':
            break;
        case 'JobOperMonthly':
            break;
        case 'JobOperSum':
            break;
        case 'JobOperWeekly':
            break;
        case 'JobPending':
            break;
        case 'JobProfit':
            break;
        case 'JobStatusMonthly':
            break;
        case 'JobStatusWeekly':
            break;
        case 'JobTracking':
            break;
        case 'PayDaily':
            break;
        case 'PettyCash':
            break;
        case 'PODetail':
            break;
        case 'ProfitLoss':
            break;
        case 'RcpDaily':
            break;
        case 'RcpTaxFollow':
            break;
        case 'RcpTaxOngoing':
            break;
        case 'RcpTaxPayment':
            break;
        case 'RcpTaxSum':
            break;
        case 'RcvDaily':
            break;
        case 'SalesTax':
            break;
        case 'SODetail':
            break;
        case 'TaxDaily':
            break;
        case 'TrialBalance':
            break;
        case 'VATMonthly':
            break;
        case 'WHTMonthly':
            break;
    }
}