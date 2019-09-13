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
function GetReportStatus(reportID) {
    let val = '';
    switch (reportID) {
        case 'JOBADV':
        case 'ADVDAILY':
            val = 'ADV_STATUS';
            break;
        case 'CLRDAILY':
            val = 'CLR_STATUS';
            break;
        case 'JOBDAILY':
        case 'JOBCS':
        case 'JOBSHP':
        case 'JOBTYPE':
        case 'JOBSHIPBY':
        case 'JOBCUST':
        case 'JOBPORT':
        case 'JOBSALES':
        case 'JOBCOMM':
        case 'RCPDAILY':
        case 'TAXDAILY':
        case 'INVDAILY':
        case 'BILLDAILY':
        case 'JOBCOST':
        case 'ACCINC':
        case 'JOBVOLUME':
        case 'JOBSTATUS':
        case 'ARBAL':
            val = 'JOB_STATUS';
            break;
        case 'EXPDAILY':
        case 'CASHDAILY':
        case 'BOOKBAL':
        case 'VATSALES':
        case 'VATBUY':
        case 'WHTAX':
        case 'ACCEXP':
        case 'APBAL':
        case 'CNDN':
        case 'TRIALBAL':
        case 'BALANCS':
        case 'PROFITLOSS':
        case 'CASHFLOW':
        case 'JOURNAL':
            val = '';
            break;
    }
    return val;
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
function LoadCliteria(reportID) {
    switch (reportID) {
        case 'JOBDAILY':
        case 'JOBCS':
        case 'JOBSHP':
        case 'JOBTYPE':
        case 'JOBSHIPBY':
        case 'JOBCUST':
        case 'JOBPORT':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').show();
            $('#tbStatus').show();
            $('#tbJob').show();
            $('#tbVend').hide();
            break;
        case 'JOBADV':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').show();
            $('#tbStatus').show();
            $('#tbJob').show();
            $('#tbVend').show();
            break;
        case 'JOBVOLUME':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').show();
            $('#tbStatus').show();
            $('#tbJob').hide();
            $('#tbVend').hide();
            break;
        case 'JOBSTATUS':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').show();
            $('#tbStatus').show();
            $('#tbJob').hide();
            $('#tbVend').hide();
            break;
        case 'JOBSALES':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').show();
            $('#tbStatus').show();
            $('#tbJob').show();
            $('#tbVend').hide();
            break;
        case 'JOBCOMM':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').show();
            $('#tbStatus').show();
            $('#tbJob').show();
            $('#tbVend').hide();
            break;
        case 'ADVDAILY':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').show();
            $('#tbStatus').show();
            $('#tbJob').show();
            $('#tbVend').show();
            break;
        case 'EXPDAILY':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').hide();
            $('#tbStatus').show();
            $('#tbJob').show();
            $('#tbVend').show();
            break;
        case 'RCPDAILY':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').show();
            $('#tbStatus').show();
            $('#tbJob').show();
            $('#tbVend').hide();
            break;
        case 'TAXDAILY':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').show();
            $('#tbStatus').show();
            $('#tbJob').show();
            $('#tbVend').hide();
            break;
        case 'CASHDAILY':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').show();
            $('#tbStatus').show();
            $('#tbJob').show();
            $('#tbVend').show();
            break;
        case 'CLRDAILY':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').show();
            $('#tbStatus').show();
            $('#tbJob').show();
            $('#tbVend').show();
            break;
        case 'INVDAILY':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').show();
            $('#tbStatus').show();
            $('#tbJob').show();
            $('#tbVend').hide();
            break;
        case 'BILLDAILY':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').show();
            $('#tbStatus').show();
            $('#tbJob').show();
            $('#tbVend').hide();
            break;
        case 'JOBCOST':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').show();
            $('#tbStatus').show();
            $('#tbJob').show();
            $('#tbVend').show();
            break;
        case 'BOOKBAL':
            $('#tbDate').show();
            $('#tbEmp').hide();
            $('#tbCust').hide();
            $('#tbStatus').hide();
            $('#tbJob').hide();
            $('#tbVend').hide();
            break;
        case 'VATSALES':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').show();
            $('#tbStatus').hide();
            $('#tbJob').show();
            $('#tbVend').hide();
            break;
        case 'VATBUY':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').hide();
            $('#tbStatus').hide();
            $('#tbJob').hide();
            $('#tbVend').show();
            break;
        case 'WHTAX':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').show();
            $('#tbStatus').hide();
            $('#tbJob').show();
            $('#tbVend').show();
            break;
        case 'ACCEXP':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').hide();
            $('#tbStatus').hide();
            $('#tbJob').hide();
            $('#tbVend').show();
            break;
        case 'ACCINC':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').show();
            $('#tbStatus').hide();
            $('#tbJob').hide();
            $('#tbVend').hide();
            break;
        case 'ARBAL':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').show();
            $('#tbStatus').hide();
            $('#tbJob').hide();
            $('#tbVend').hide();
            break;
        case 'APBAL':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').hide();
            $('#tbStatus').hide();
            $('#tbJob').hide();
            $('#tbVend').show();
            break;
        case 'CNDN':
            $('#tbDate').show();
            $('#tbEmp').show();
            $('#tbCust').show();
            $('#tbStatus').hide();
            $('#tbJob').hide();
            $('#tbVend').hide();
            break;
        case 'TRIALBAL':
            $('#tbDate').show();
            $('#tbEmp').hide();
            $('#tbCust').hide();
            $('#tbStatus').hide();
            $('#tbJob').hide();
            $('#tbVend').hide();
            break;
        case 'BALANCS':
            $('#tbDate').show();
            $('#tbEmp').hide();
            $('#tbCust').hide();
            $('#tbStatus').hide();
            $('#tbJob').hide();
            $('#tbVend').hide();
            break;
        case 'PROFITLOSS':
            $('#tbDate').show();
            $('#tbEmp').hide();
            $('#tbCust').hide();
            $('#tbStatus').hide();
            $('#tbJob').hide();
            $('#tbVend').hide();
            break;
        case 'CASHFLOW':
            $('#tbDate').show();
            $('#tbEmp').hide();
            $('#tbCust').hide();
            $('#tbStatus').hide();
            $('#tbJob').hide();
            $('#tbVend').hide();
            break;
        case 'JOURNAL':
            $('#tbDate').show();
            $('#tbEmp').hide();
            $('#tbCust').hide();
            $('#tbStatus').hide();
            $('#tbJob').hide();
            $('#tbVend').hide();
            break;
    }
}
function LoadReport(reportID, obj,lang) {
    let str = JSON.stringify(obj);
    $.ajax({
        url:'/Report/GetReport',
        type: "POST",
        contentType: "application/json",
        data: str,
        success: function (response) {
            let r = JSON.parse(response);
            if (r.msg !== "OK") {
                alert(r.msg);
                return;
            }
            if (r.result.length > 0) {
                var tb = r.result;
                //let html = ' < thead > <tr>';
                let html = '<tbody><tr>';
                $.each(tb[0], function (key, value) {
                    //html += '<th style="border:1px solid black;text-align:left;">' + key + '</th>';
                    html += '<td style="border:1px solid black;text-align:left;">' + GetColumnHeader(key,lang) + '</td>';
                });
                //html += '</tr></thead>';
                html += '</tr>';
                //html += '<tbody>';
                for (let r of tb) {
                    html += '<tr>';
                    for (let c in r) {               
                        if (c.indexOf('Date') > 0) {
                            html += '<td style="border:1px solid black;text-align:left;">' + ShowDate(r[c]) + '</td>';
                        } else {
                            if (r[c] !== null) {
                                if (Number.isInteger(Math.floor(r[c]))) {
                                    html += '<td style="border:1px solid black;text-align:right;">' + r[c] + '</td>';
                                } else {
                                    html += '<td style="border:1px solid black;text-align:left;">' + r[c] + '</td>';
                                }
                            } else {
                                html += '<td style="border:1px solid black;text-align:left;"></td>';
                            }
                        }                        
                    }
                    html += '</tr>';
                }
                html += '</tbody>';
                $('#tbResult').html(html);
            }
        }
    });   
}
function GetColumnHeader(id,langid) {
    let lang = {
        JNo: 'Job#|เลขงาน',
        DocDate: 'Open Date|วันที่เปิด',
        BranchCode: 'Branch|สาขา',
        ConfirmDate: 'Confirm Date|วันที่ยืนยัน',
        CustCode: 'Customer|ลูกค้า',
        CustContactName: 'Contact|ผู้ติดต่อ',
        QNo: 'Quotation#|ใบเสนอราคา',
        ManagerCode: 'Sales|ขายโดย',
        CSCode: 'CS|พนักงาน',
        Description: 'Description|รายละเอียด',
        TRemark: 'Remark|หมายเหตุ',
        JobStatusName: 'Status|สถานะ',
        JobStatus: 'Status|สถานะ',
        JobType: 'Type|ประเภท',
        JobTypeName: 'Type|ประเภท',
        ShipBy: 'ShipBy|ลักษณะ',
        ShipByName: 'ShipBy|ลักษณะ',
        InvNo: 'Invoice#|อินวอย',
        InvTotal: 'Total Inv.|ยอดอินวอย',
        InvProduct: 'Product|สินค้า',
        InvCountry: 'Origin Cty|ต้นทาง',
        InvFCountry: 'Dest Cty|ปลายทาง',
        InvInterPort: 'Inter Port|Port ตปท',
        InvProductQty: 'Qty|จำนวน',
        InvProductUnit: 'Unit|หน่วย',
        InvCurUnit: 'Currency|สกุลเงิน',
        InvCurRate: 'Rate|แลกเปลี่ยน',
        ImExDate: 'EDI Date|วันที่ทำEDI',
        BLNo: 'BL/AWB Status|สถานะ BL/AWB',
        BookingNo: 'Booking No|ใบจองพาหนะ',
        ClearPort: 'Clear Port|สถานที่ตรวจปล่อย',
        ClearPortNo: 'Port#|จุดตรวจปล่อย',
        ClearDate: 'Customs Date|วันที่ผ่านพิธีการ',
        LoadDate: 'Load Date|วันที่ลงของ',
        ForwarderCode: 'Agent|ตัวแทนเรือ/สายการบิน',
        AgentCode: 'Transport|ขนส่ง',
        VesselName: 'Vessel|ชื่อเรือ/เที่ยวบิน',
        ETDDate: 'ETD|วันออกจากท่า',
        ETADate: 'ETA|วันเทียบท่า',
        CancelReson: 'Cancel Reason|เหตุผลที่ยกเลิก',
        CancelDate: 'Cancel Date|วันที่ยกเลิก',
        CancelProve: 'Cancel By|ผู้ยกเลิก',
        CloseJobDate: 'Close Date|วันที่ปิดงาน',
        CloseJobBy: 'Close By|ผู้ปิดงาน',
        DeclareType: 'Decl.Type|ประเภทใบขน',
        DeclareNumber: 'Declare#|เลขที่ใบขน',
        EstDeliverDate: 'Delivery Date|วันที่ส่งของ',
        TotalContainer: 'Total CTN|จำนวนตู้',
        DutyDate: 'Shipment Date|วันที่ตรวจปล่อย',
        DutyAmount: 'Duty Amt|ภาษีอากร',
        ConfirmChqDate: 'Confirm Date|วันที่ยืนยัน',
        ShippingEmp: 'Shipping|ชิปปิ้ง',
        ShippingCmd: 'Caution|ข้อพึงระวัง',
        TotalGW: 'Gross WT|น้ำหนักสุทธิ',
        GWUnit: 'Unit|หน่วย',
        ReadyToClearDate: 'Ready Date|วันที่พร้อมตรวจปล่อย',
        Commission: 'Commission|คอมมิชชั่น',
        ProjectName: 'Project|ชื่อโครงการ',
        MVesselName: 'Mother Vsl|เรือแม่/เที่ยวบินขนถ่าย',
        TotalNW: 'Net WT|น้ำหนักสุทธิ',
        Measurement: 'M3|ปริมาตร',
        CustRefNO: 'RefNo|เลขที่อ้างอิง',
        TotalQty: 'Total Qty|จำนวนรวม',
        HAWB: 'House AWB/BL|House AWB/BL',
        MAWB: 'Master AWB/BL|Master AWB/BL',
        consigneecode: 'Consignee|ผู้ซื้อขาย',
        DeliveryNo: 'Delivery|ใบส่งของ',
        DeliveryTo: 'Delivery To|ส่งถึง',
        DeliveryAddr: 'Delivery Addr|ที่อยู่'
    }
    let str = id;
    if (lang[id] !== undefined) {
        switch (langid) {
            case 'EN':
                str = lang[id].split('|')[0].trim();
                break;
            case 'TH':
                str = lang[id].split('|')[1].trim();
                break;
        }
    }
    return str;
}

/*
function _LoadReport(reportID) {
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
*/