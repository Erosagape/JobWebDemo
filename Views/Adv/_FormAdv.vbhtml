@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.Title = "Advance Slip"
End Code
<div class="page" contenteditable="false">
    <table id="tblHeader" width="100%">
        <tr>
            <td>
                <img id="imgLogo" src="~/Resource/logo-idl.jpg" width="80%" />
            </td>
            <td>
                <div id="divCompany" style="text-align:left;color:darkblue;"></div>
            </td>
        </tr>
    </table>
    <hr />
    <table id="tbAdvInfo" width="100%">
        <tr>
            <td colspan="3" style="font-size:11px">
                <b>Advance No : </b><label id="lblAdvNo" style="text-decoration-line:underline"></label>
            </td>
            <td align="right" style="font-size:11px">
                <input type="text" value="ADVANCE" style="text-align:center;background-color:yellow;font:bold;font-size:large;" disabled />
            </td>
        </tr>
        <tr>
            <td colspan="3" style="font-size:11px">
                <b>Customer : </b><label id="lblCustCode" style="text-decoration-line:underline;"></label>
                <br /><label id="lblCustName" style="text-decoration-line:underline;"></label>
            </td>
            <td align="right" style="font-size:11px">
                <b>Advance Date : </b><label id="lblAdvDate" style="text-decoration-line:underline;"></label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size:11px">
                <b>Job Type : </b><label id="lblJobType" style="text-decoration-line:underline;"></label>
                <b>Ship By : </b><label id="lblShipBy" style="text-decoration-line:underline;"></label>
            </td>
            <td align="right" colspan="2" style="font-size:11px">
                <b>Advance Type : </b><label id="lblAdvType" style="text-decoration-line:underline;"></label>
            </td>
        </tr>
        <tr>
            <td colspan="3" style="font-size:11px">
                <b>Remark</b>
                <label id="lblRemark" style="text-decoration-line:underline;"></label>
            </td>
            <td align="right" style="font-size:11px">
                <b>Request Date : </b><label id="lblReqDate" style="text-decoration-line:underline;"></label>
            </td>
        </tr>
    </table>
    <br />
    <table width="100%" style="border-collapse:collapse;">
        <tr style="text-align:center;">
            <td style="border-style:solid;border-width:thin;font-size:11px">
                <b>Advance Expenses</b>
            </td>
            <td style="border-style:solid;border-width:thin;font-size:11px"><b>Job Number</b></td>
            <td style="border-style:solid;border-width:thin;font-size:11px"><b>Amount</b></td>
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
                <input type="checkbox" id="chkCash" /> CASH/TRANSFER : <label id="lblAccNo">______________</label>
            </td>
            <td style="border-style:solid;border-width:thin;text-align:right;font-size:11px" width="130px">Net Amount</td>
            <td style="border-style:solid;border-width:thin" width="150px">
                <input type="text" style="border:none;text-align:right;font-size:11px" id="txtNetAmt" />
            </td>
        </tr>
        <tr>
            <td style="text-align:left;font-size:11px">
                <input type="checkbox" id="chkCustChq" /> CUST.CHQ NO : <label id="lblcustChqNo">__________</label> DEP.DATE : <label id="lblDepDate">________</label>
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
                <input type="checkbox" id="chkCompChq" /> CHQ NO : <label id="lblCompChqNo">__________</label> CHQ.DATE : <label id="lblChqDate">________</label>
            </td>
            <td style="border-style:solid;border-width:thin;text-align:right;font-size:11px" width="130px">WH-Tax</td>
            <td style="border-style:solid;border-width:thin" width="150px">
                <input type="text" style="border:none;text-align:right;font-size:11px" id="txtWHTAmt" />
            </td>
        </tr>
        <tr>
            <td style="text-align:left;font-size:11px;">
                <input type="checkbox" id="chkCredit" /> ACCOUNT PAYABLES :
            </td>
            <td style="border-style:solid;border-width:thin;text-align:right;font-size:11px" width="130px">Total</td>
            <td style="border-style:solid;border-width:thin" width="150px">
                <input type="text" style="border:none;text-align:right;font-size:11px" id="txtTotalAmt" />
            </td>
        </tr>
    </table>
    <br />
    TOTAL : <input type="text" id="txtTotalText" value="ZERO BAHT ONLY" style="font-size:11px;background-color:burlywood;font:bold;text-align:center;width:90%;" disabled />
    <br />
    PAY TO : <label id="lblPayTo" style="font-size:11px">________________________________________________________________________</label>
    <br />
    <br />
    <table width="100%" style="border-collapse:collapse;">
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
                <label id="lblReqBy" style="font-size:10px">(__________________)</label><br />
                <label id="lblRequestDate" style="font-size:9px">__/__/____</label>
            </td>
            <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:bottom">
                <label id="lblAppBy" style="font-size:10px">(__________________)</label><br />
                <label id="lblAppDate" style="font-size:9px">__/__/____</label>
            </td>
            <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:bottom">
                <label id="lblPayBy" style="font-size:10px">(__________________)</label><br />
                <label id="lblPayDate" style="font-size:9px">__/__/____</label>
            </td>
            <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:bottom">
                <label id="lblPostBy" style="font-size:9px">(__________________)</label><br />
                <label id="lblPostDate" style="font-size:9px">__/__/____</label>
            </td>
            <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:bottom">
                <label id="lblClrBy" style="font-size:9px">(__________________)</label><br />
                <label id="lblClrDate" style="font-size:9px">__/__/____</label>
            </td>
        </tr>
    </table>
    <p style="text-align:right">Printed By : @ViewBag.User Printed Date : @DateTime.Now &copy; @DateTime.Now.Year - Tawan Technology Co.,ltd</p>
</div>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    let serv = [];
    //$(document).ready(function () {
        ShowCompany('#divCompany');
        var branch = getQueryString('branch');
        var advno = getQueryString('advno');
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
    
    function ShowData(data) {
        //show headers
        var h = data.adv.header[0];
        $('#lblAdvNo').text(h.AdvNo);
        $('#lblReqDate').text(ShowDate(GetToday()));
        $('#lblCustCode').text(h.CustCode + '/' + h.CustBranch);
        $('#lblRemark').text(h.TRemark);
        $('#lblAdvDate').text(ShowDate(h.AdvDate));
        $('#lblPayTo').text(h.PayChqTo);

        ShowCustomer(h.CustCode, h.CustBranch);

        ShowUserSign(path,h.EmpCode, '#lblReqBy');
        ShowUserSign(path,h.ApproveBy, '#lblAppBy');
        ShowUserSign(path,h.PaymentBy, '#lblPayBy');

        $('#lblRequestDate').text(ShowDate(h.AdvDate));
        $('#lblAppDate').text(ShowDate(h.ApproveDate));
        $('#lblPayDate').text(ShowDate(h.PaymentDate));

        var jt = h.JobType;
        var sb = h.ShipBy;
        var at = h.AdvType;
        if (jt < 10) jt = '0' + jt;
        if (sb < 10) sb = '0' + sb;
        if (at < 10) at = '0' + at;
        ShowConfig(path,'JOB_TYPE', jt, '#lblJobType');
        ShowConfig(path,'SHIP_BY', sb, '#lblShipBy');
        ShowConfig(path,'ADV_TYPE', at, '#lblAdvType');
        if (h.AdvCash > 0) {
            $('#chkCash').prop('checked', true);
        }
        if (h.AdvChq > 0) {
            $('#chkCustChq').prop('checked', true);
        }
        if (h.AdvChqCash > 0) {
            $('#chkCompChq').prop('checked', true);
        }
        if (h.AdvCred > 0) {
            $('#chkCredit').prop('checked', true);
        }
        $('#txtNetAmt').val(CCurrency(h.TotalAdvance.toFixed(2)));
        $('#txtVATAmt').val(CCurrency(h.TotalVAT.toFixed(2)));
        $('#txtWHTAmt').val(CCurrency(h.Total50Tavi.toFixed(2)));
        $('#txtTotalAmt').val(CCurrency((h.TotalAdvance + h.TotalVAT - h.Total50Tavi).toFixed(2)));

        $('#txtTotalText').val(CNumEng(CCurrency((h.TotalAdvance + h.TotalVAT - h.Total50Tavi).toFixed(2))));
        //show details
        var d = data.adv.detail;
        LoadServices(d,h);
    }
    function ShowCustomer(Code, Branch) {
        $('#lblCustName').text('-');
        if ((Code + Branch).length > 0) {
            $.get(path +'Master/GetCompany?Code=' + Code + '&Branch=' + Branch)
                .done(function (r) {
                    if (r.company.data.length > 0) {
                        var c = r.company.data[0];
                        $('#lblCustName').text(c.NameThai);
                    }
                });
        }
    }    
    function ShowDetail(r,h) {
        //Dummy Data
        var strDesc = '';
        var strJob = '';
        var strAmt = '';
        var totAmt = 0;
        //var vat = 0;
        //var wht = 0;
        for (i = 0; i < r.length; i++) {
            var d = r[i];
            if (serv.length > 0) {
                var c = $.grep(serv, function (data) {
                    return data.SICode === d.SICode;
                });
                if (c.length > 0) {
                    strDesc = strDesc + (d.SICode + '-' + c[0].NameThai + '<br/>');
                } else {
                    strDesc = strDesc + (d.SICode + '-Not found Expenses<br/>');
                }
            } else {
                strDesc = strDesc + (d.SICode + '<br/>');
            }
            strJob = strJob + (d.ForJNo + '<br/>');
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