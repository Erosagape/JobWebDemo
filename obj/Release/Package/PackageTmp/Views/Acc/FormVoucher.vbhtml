@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.Title = "Voucher Slip"
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
                <b>Voucher No : </b><label id="lblVoucherNo" style="text-decoration-line:underline"></label>
            </td>
            <td align="right" style="font-size:11px">
                <input type="text" id="txtVoucherType" value="VOUCHER" style="text-align:center;background-color:yellow;font:bold;font-size:large;" disabled />
            </td>
        </tr>
        <tr>
            <td colspan="3" style="font-size:11px">
                <b>For : </b><label id="lblCmpCode" style="text-decoration-line:underline;"></label>
                <br /><label id="lblCmpName" style="text-decoration-line:underline;"></label>
            </td>
            <td align="right" style="font-size:11px">
                <b>Transaction Date : </b><label id="lblChqDate" style="text-decoration-line:underline;"></label>
            </td>
        </tr>
        <tr>
            <td colspan="3" style="font-size:11px">
                <b>Remark</b>
                <label id="lblRemark" style="text-decoration-line:underline;"></label>
            </td>
            <td align="right" style="font-size:11px">
                <b>Voucher Date : </b><label id="lblVoucherDate" style="text-decoration-line:underline;"></label>
            </td>
        </tr>
    </table>
    <br />
    <table width="100%" style="border-collapse:collapse;">
        <tr style="text-align:center;">
            <td style="border-style:solid;border-width:thin;font-size:11px">
                <b>Description</b>
            </td>
            <td style="border-style:solid;border-width:thin;font-size:11px"><b>Debit</b></td>
            <td style="border-style:solid;border-width:thin;font-size:11px"><b>Credit</b></td>
        </tr>
        <tr style="height:450px;vertical-align:top">
            <td style="border-style:solid;border-width:thin;text-align:left">
                <div id="divDesc" style="font-size:12px"></div>
            </td>
            <td style="border-style:solid;border-width:thin;text-align:left">
                <div id="divDebit" style="font-size:12px"></div>
            </td>
            <td style="border-style:solid;border-width:thin;text-align:right">
                <div id="divCredit" style="font-size:12px"></div>
            </td>
        </tr>
        <tr>
            <td style="border-style:solid;border-width:thin;text-align:right;font-size:11px">Total</td>
            <td style="border-style:solid;border-width:thin;text-align:right;font-size:11px" width="130px">
                <input type="text" style="border:none;text-align:right;font-size:11px" id="txtSumDebit" />
            </td>
            <td style="border-style:solid;border-width:thin" width="150px">
                <input type="text" style="border:none;text-align:right;font-size:11px" id="txtSumCredit" />
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
                <input type="checkbox" id="chkCredit" /> ACCRUED EXPENSES:
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
                CREATED.BY
            </td>
            <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:top">
                APPROVE.BY
            </td>
            <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:top">
                RECEIVE.BY
            </td>
            <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:top">
                POSTED.BY
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
        </tr>
    </table>
    <p style="text-align:right">Printed By : @ViewBag.User Printed Date : @DateTime.Now &copy; @DateTime.Now.Year - Tawan Technology Co.,ltd</p>
</div>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    var serv = [];
    $(document).ready(function () {
        ShowCompany('#divCompany');
        var branch = getQueryString('branch');
        var controlno = getQueryString('advno');
    });

    function ShowData(data) {
    }
    function ShowDetail(r,h) {

    }

</script>