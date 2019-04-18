@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.Title = "Voucher Slip"
End Code
<table id="tbAdvInfo" width="100%">
    <tr>
        <td colspan="3" style="font-size:11px">
            <b>Voucher No : </b><label id="txtControlNo" style="text-decoration-line:underline"></label>
        </td>
        <td align="right" style="font-size:11px">
            <input type="text" id="txtVoucherType" value="VOUCHER" style="text-align:center;background-color:yellow;font:bold;font-size:large;" disabled />
        </td>
    </tr>
    <tr>
        <td colspan="3" style="font-size:11px">
            <b>Remark</b>
            <label id="txtRemark" style="text-decoration-line:underline;"></label>
        </td>
        <td align="right" style="font-size:11px">
            <b>Voucher Date : </b><label id="txtVoucherDate" style="text-decoration-line:underline;"></label>
        </td>
    </tr>
</table>
<br />
<table id="tbData" style="border-collapse:collapse;width:100%">
    <thead style="text-align:center;">
        <tr>
            <th style="border-style:solid;border-width:thin;font-size:11px">
                <b>Description</b>
            </th>
            <th style="border-style:solid;border-width:thin;font-size:11px" width="150px"><b>Amount</b></th>
            <th style="border-style:solid;border-width:thin;font-size:11px" width="100px"><b>Tax</b></th>
        </tr>
    </thead>
    <tbody></tbody>
</table>
<table style="border-collapse:collapse;width:100%">
    <tr>
        <td style="border-style:solid;border-width:thin;text-align:right;font-size:11px">Total</td>
        <td style="border-style:solid;border-width:thin;text-align:right;font-size:11px" width="150px">
            <input type="text" style="border:none;text-align:right;font-size:11px" id="txtSumAmount" />
        </td>
        <td style="border-style:solid;border-width:thin" width="100px">
            <input type="text" style="border:none;text-align:right;font-size:11px" id="txtSumTax" />
        </td>
    </tr>
</table>
<br />
TOTAL : <input type="text" id="txtTotalText" value="ZERO BAHT ONLY" style="font-size:11px;background-color:burlywood;font:bold;text-align:center;width:90%;" disabled />
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
            PAYER
        </td>
        <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:top">
            PAYEE
        </td>
    </tr>
    <tr>
        <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:bottom" height="100px">
            <label id="txtRecBy" style="font-size:10px">(__________________)</label><br />
            <label id="txtRecDate" style="font-size:9px">__/__/____</label>
        </td>
        <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:bottom">
            <label id="txtPostedBy" style="font-size:10px">(__________________)</label><br />
            <label id="txtPostedDate" style="font-size:9px">__/__/____</label>
        </td>
        <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:bottom">
            <label style="font-size:10px">(__________________)</label><br />
            <label style="font-size:9px">__/__/____</label>
        </td>
        <td style="border-style:solid;border-width:thin;text-align:center;vertical-align:bottom">
            <label style="font-size:9px">(__________________)</label><br />
            <label style="font-size:9px">__/__/____</label>
        </td>
    </tr>
</table>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    let vcType='P';
    $(document).ready(function () {
        ShowCompany('#divCompany');
        let branch = getQueryString('branch');
        let controlno = getQueryString('controlno');
        $.get(path + 'acc/getvoucher?branch=' + branch + '&code=' + controlno, function (r) {
            if (r.voucher.header !== null) {
                ShowData(r.voucher);
            }
        });
    });

    function ShowData(data) {
        let div=$('#tbData tbody');
        if (data.payment !== null) {
            for(let obj in data.payment) {
                if(vcType!==obj.PRType){
                    vcType=obj.PRType;
                }                
                let acType=obj.acType;
                let acTypeName=GetPaymentType(acType);
                if (data.document !== null) {
                    let doc=data.document.filter(function(r){
                        return r.acType==acType;
                    });
                    if(doc!==null) {
                        for(d in doc) {
                            let desc='';
                            desc+=acTypeName;
                            desc += ' ' + d.DocNo;

                            let html = '<tr><td style="border-style:solid;border-width:thin;font-size:11px">';
                            html += '<b>' + desc + '</b>';
                            html += '</td>';
                            html += '<td style="border-style:solid;border-width:thin;font-size:11px" width="150px">' + d.PaidAmount + '</td>';
                            html += '<td style="border-style:solid;border-width:thin;font-size:11px" width="100px">' + d.TotalAmount + '</td>';
                            html += '</tr>';

                            div.append(html);
                        }
                    }
                }
            }
        }
        if (data.header !== null) {
            $('#txtControlNo').text(data.header.ControlNo);
            $('#txtVoucherType').text(GetVoucherType() + ' VOUCHER');
            $('#txtVoucherDate').text(ShowDate(CDateTH(data.header.VoucherDate)));

        }
    }    
    function GetPaymentType(p) {
        switch(p){
            case 'CA':
                return 'Cash';
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
        switch(vcType){
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
</script>