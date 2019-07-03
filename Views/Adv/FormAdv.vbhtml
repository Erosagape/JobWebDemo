@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.Title = "Advance Slip"
    ViewBag.ReportName = ""
End Code
<table id="tbAdvInfo" style="width:100%">
    <tr>
        <td colspan="3" style="font-size:11px">
            <b>Advance No : </b>
            <label id="lblAdvNo" style="text-decoration-line:underline"></label>
        </td>
        <td align="right" style="font-size:11px">
            <input type="text" value="ADVANCE" style="text-align:center;background-color:yellow;font:bold;font-size:large;" disabled />
        </td>
    </tr>
    <tr>
        <td colspan="3" style="font-size:11px">
            <b>Customer : </b>
            <label id="lblCustCode" style="text-decoration-line:underline;"></label>
            <br />
            <label id="lblCustName" style="text-decoration-line:underline;"></label>
        </td>
        <td align="right" style="font-size:11px">
            <b>Advance Date : </b>
            <label id="lblAdvDate" style="text-decoration-line:underline;"></label>
        </td>
    </tr>
    <tr>
        <td colspan="2" style="font-size:11px">
            <b>Job Type : </b>
            <label id="lblJobType" style="text-decoration-line:underline;"></label>
            <b>Ship By : </b>
            <label id="lblShipBy" style="text-decoration-line:underline;"></label>
        </td>
        <td align="right" colspan="2" style="font-size:11px">
            <b>Advance Type : </b>
            <label id="lblAdvType" style="text-decoration-line:underline;"></label>
        </td>
    </tr>
    <tr>
        <td colspan="3" style="font-size:11px">
            <b>Remark</b>
            <label id="lblRemark" style="text-decoration-line:underline;"></label>
        </td>
        <td align="right" style="font-size:11px">
            <b>Request Date : </b>
            <label id="lblReqDate" style="text-decoration-line:underline;"></label>
        </td>
    </tr>
</table>
<br />
<table style="border-collapse:collapse;width:100%">
    <tr style="text-align:center;">
        <td style="border-style:solid;border-width:thin;font-size:11px">
            <b>Advance Expenses</b>
        </td>
        <td style="border-style:solid;border-width:thin;font-size:11px">
            <b>Job Number</b>
        </td>
        <td style="border-style:solid;border-width:thin;font-size:11px">
            <b>Amount</b>
        </td>
    </tr>
    <tr style="height:450px;vertical-align:top">
        <td style="border-style:solid;border-width:thin;text-align:left">
            <div id="divDesc" style="font-size:12px"></div>
        </td>
        <td style="border-style:solid;border-width:thin;text-align:left">
            <div id="divJob" style="font-size:12px"></div>
        </td>
        <td style="border-style:solid;border-width:thin;text-align:right">
            <div id="divAmt" style="font-size:12px"></div>
        </td>
    </tr>
    <tr>
        <td style="text-align:left;font-size:11px">
            <input type="checkbox" id="chkCash" /> CASH/TRANSFER :
            <label id="lblAccNo">______________</label>
            <label id="txtAdvCash"></label>
        </td>
        <td style="border-style:solid;border-width:thin;text-align:right;font-size:11px" width="130px">Net Amount</td>
        <td style="border-style:solid;border-width:thin" width="150px">
            <input type="text" style="border:none;text-align:right;font-size:11px" id="txtTotalAmt" />
        </td>
    </tr>
    <tr>
        <td style="text-align:left;font-size:11px">
            <input type="checkbox" id="chkCustChq" /> CUST.CHQ NO :
            <label id="lblcustChqNo">__________</label> DEP.DATE :
            <label id="lblDepDate">________</label>
            <label id="txtAdvChqCash"></label>
        </td>
        <td style="border-style:solid;border-width:thin;text-align:right;font-size:11px" width="130px">
            VAT
        </td>
        <td style="border-style:solid;border-width:thin" width="150px">
            <input type="text" style="border:none;text-align:right;font-size:11px" id="txtVATAmt" />
        </td>
    </tr>
    <tr>
        <td style="text-align:left;font-size:11px">
            <input type="checkbox" id="chkCompChq" /> CHQ NO :
            <label id="lblCompChqNo">__________</label> CHQ.DATE :
            <label id="lblChqDate">________</label>
            <label id="txtAdvChq"></label>
        </td>
        <td style="border-style:solid;border-width:thin;text-align:right;font-size:11px" width="130px">WH-Tax</td>
        <td style="border-style:solid;border-width:thin" width="150px">
            <input type="text" style="border:none;text-align:right;font-size:11px" id="txtWHTAmt" />
        </td>
    </tr>
    <tr>
        <td style="text-align:left;font-size:11px;">
            <input type="checkbox" id="chkCredit" /> ACCOUNT PAYABLES :__________________ <label id="txtAdvCred"></label>
        </td>
        <td style="border-style:solid;border-width:thin;text-align:right;font-size:11px" width="130px">Total</td>
        <td style="border-style:solid;border-width:thin" width="150px">
            <input type="text" style="border:none;text-align:right;font-size:11px" id="txtNetAmt" />
        </td>
    </tr>
</table>
            **ADVANCE WAIT FOR CLEAR AT @DateTime.Now IS
            <label id="lblPendingAmount">0.00</label>**
            <br />
            TOTAL : <input type="text" id="txtTotalText" value="ZERO BAHT ONLY" style="font-size:11px;background-color:burlywood;font:bold;text-align:center;width:90%;" disabled />
            <br />
            PAY TO : <label id="lblPayTo" style="font-size:11px">________________________________________________________________________</label>
            <br />
            <table style="border-collapse:collapse;width:100%">
                <tr>
                    <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:top">
                        REQUEST.BY
                    </td>
                    <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:top">
                        APPROVE.BY
                    </td>
                    <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:top">
                        PAYMENT.BY
                    </td>
                    <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:top">
                        POSTED.BY
                    </td>
                    <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:top">
                        CLEARED.BY
                    </td>
                </tr>
                <tr>
                    <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:bottom" height="100px">
                        <label id="lblReqBy" style="font-size:10px">(__________________)</label>
                        <br />
                        <label id="lblRequestDate" style="font-size:9px">__/__/____</label>
                    </td>
                    <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:bottom">
                        <label id="lblAppBy" style="font-size:10px">(__________________)</label>
                        <br />
                        <label id="lblAppDate" style="font-size:9px">__/__/____</label>
                    </td>
                    <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:bottom">
                        <label id="lblPayBy" style="font-size:10px">(__________________)</label>
                        <br />
                        <label id="lblPayDate" style="font-size:9px">__/__/____</label>
                    </td>
                    <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:bottom">
                        <label id="lblPostBy" style="font-size:9px">(__________________)</label>
                        <br />
                        <label id="lblPostDate" style="font-size:9px">__/__/____</label>
                    </td>
                    <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:bottom">
                        <label id="lblClrBy" style="font-size:9px">(__________________)</label>
                        <br />
                        <label id="lblClrDate" style="font-size:9px">__/__/____</label>
                    </td>
                </tr>
            </table>
            <script type="text/javascript">
    const path = '@Url.Content("~")';
    let serv = [];
    //$(document).ready(function () {
        let branch = getQueryString('branch');
        let advno = getQueryString('advno');
        if (branch != "" && advno != "") {
            GetAdv(branch, advno);
        }
    //});
    function GetAdv(Branch, Doc) {
        $.get(path +'adv/getadvance?branchcode=' + Branch + '&advno=' + Doc)
            .done(function (r) {
                if (r.adv.header.length > 0) {
                    ShowData(r);
                    return;
                }
            });
    }
    function LoadServices(d,h) {
        $.get(path +'Master/GetServiceCode')
            .done(function (r) {
                serv = r.servicecode.data;
                ShowDetail(d,h);
            });
    }
                function ShowPendingAmount(branch, reqby) {
                    $.get(path + 'Clr/GetAdvForClear?show=NOCLR&branchcode=' + branch + '&reqby=' + reqby)
                        .done(function (r) {
                            if (r.clr.data.length > 0) {
                                let d = r.clr.data[0].Table;
                                let sum = d.map(item => item.AdvBalance).reduce((prev, next) => prev + next);
                                $('#lblPendingAmount').text(ShowNumber(sum, 2));
                            }
                        });
                }
    function ShowData(data) {
        //show headers
        let h = data.adv.header[0];
        $('#lblAdvNo').text(h.AdvNo);
        $('#lblReqDate').text(ShowDate(GetToday()));
        $('#lblCustCode').text(h.CustCode + '/' + h.CustBranch);
        $('#lblRemark').text(h.TRemark);
        $('#lblAdvDate').text(ShowDate(h.AdvDate));
        $('#lblPayTo').text(h.PayChqTo);
        ShowPendingAmount(h.BranchCode, h.EmpCode);
        ShowCustomer(h.CustCode, h.CustBranch);

        ShowUserSign(path,h.EmpCode, '#lblReqBy');
        ShowUserSign(path,h.ApproveBy, '#lblAppBy');
        ShowUserSign(path,h.PaymentBy, '#lblPayBy');

        $('#lblRequestDate').text(ShowDate(h.AdvDate));
        $('#lblAppDate').text(ShowDate(h.ApproveDate));
        $('#lblPayDate').text(ShowDate(h.PaymentDate));

        let jt = h.JobType;
        let sb = h.ShipBy;
        let at = h.AdvType;
        if (jt < 10) jt = '0' + jt;
        if (sb < 10) sb = '0' + sb;
        if (at < 10) at = '0' + at;
        ShowConfig(path,'JOB_TYPE', jt, '#lblJobType');
        ShowConfig(path,'SHIP_BY', sb, '#lblShipBy');
        ShowConfig(path,'ADV_TYPE', at, '#lblAdvType');
        if (h.AdvCash > 0) {
            $('#chkCash').prop('checked', true);
            $('#txtAdvCash').text(ShowNumber(h.AdvCash, 2) + ' ' + h.SubCurrency);
        }
        if (h.AdvChq > 0) {
            $('#chkCustChq').prop('checked', true);
            $('#txtAdvChq').text(ShowNumber(h.AdvChq, 2) + ' ' + h.SubCurrency);
        }
        if (h.AdvChqCash > 0) {
            $('#chkCompChq').prop('checked', true);
            $('#txtAdvChqCash').text(ShowNumber(h.AdvChqCash, 2) + ' ' + h.SubCurrency);
        }
        if (h.AdvCred > 0) {
            $('#chkCredit').prop('checked', true);
            $('#txtAdvCred').text(ShowNumber(h.AdvCred, 2) + ' ' + h.SubCurrency);
        }
        $('#txtNetAmt').val(CCurrency(h.TotalAdvance.toFixed(2)));
        $('#txtVATAmt').val(CCurrency(h.TotalVAT.toFixed(2)));
        $('#txtWHTAmt').val(CCurrency(h.Total50Tavi.toFixed(2)));
        $('#txtTotalAmt').val(CCurrency((h.TotalAdvance + h.TotalVAT - h.Total50Tavi).toFixed(2)));

        $('#txtTotalText').val(CNumEng(CCurrency((h.TotalAdvance + h.TotalVAT - h.Total50Tavi).toFixed(2))));
        //show details
        let d = data.adv.detail;
        LoadServices(d,h);
    }
    function ShowCustomer(Code, Branch) {
        $('#lblCustName').text('-');
        if ((Code + Branch).length > 0) {
            $.get(path +'Master/GetCompany?Code=' + Code + '&Branch=' + Branch)
                .done(function (r) {
                    if (r.company.data.length > 0) {
                        let c = r.company.data[0];
                        $('#lblCustName').text(c.NameThai);
                    }
                });
        }
    }
    function ShowDetail(r,h) {
        //Dummy Data
        let strDesc = '';
        let strJob = '';
        let strAmt = '';
        let totAmt = 0;
        //let vat = 0;
        //let wht = 0;
        for (i = 0; i < r.length; i++) {
            let d = r[i];
            if (serv.length > 0) {
                let c = $.grep(serv, function (data) {
                    return data.SICode === d.SICode;
                });
                if (c.length > 0) {
                    strDesc = strDesc + (d.SICode + '-' + d.SDescription + '<br/>');
                } else {
                    strDesc = strDesc + 'Not Assign Expenses<br/>';
                }
            } else {
                strDesc = strDesc + (d.SICode + '<br/>');
            }
            strJob = strJob + ((d.ForJNo == null||d.ForJNo=='' ? '' : d.ForJNo) + '<br/>');
            strAmt = strAmt + (CCurrency((d.AdvAmount).toFixed(2)) + '<br/>');
            totAmt += d.AdvAmount;
            //vat += d.ChargeVAT;
            //wht += d.Charge50Tavi;
        }
        $('#divDesc').html(strDesc);
        $('#divJob').html(strJob);
        $('#divAmt').html(strAmt);
    }

            </script>