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
            <th style="border-style:solid;border-width:thin;font-size:11px" width="150px"><b>Debit</b></th>
            <th style="border-style:solid;border-width:thin;font-size:11px" width="100px"><b>Credit</b></th>
        </tr>
    </thead>
    <tbody></tbody>
</table>
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
    //$(document).ready(function () {
        let branch = getQueryString('branch');
        let controlno = getQueryString('controlno');
        $.get(path + 'acc/getvoucher?branch=' + branch + '&code=' + controlno, function (r) {
            if (r.voucher.header !== null) {
                ShowData(r.voucher);
            }
        });
    //});

    function ShowData(data) {
        let div = $('#tbData tbody');
        let vcTypeName = '';
        if (data.payment !== null) {
            for(let obj of data.payment) {
                if(vcType!==obj.PRType){
                    vcType=obj.PRType;
                }           
                vcTypeName = GetVoucherType(vcType);
                let acType=obj.acType;
                let acTypeName = GetPaymentType(acType);
                let payType = '';
                let desc = '';

                
                appendLine(div, '<b>' + vcTypeName + ' BY ' + acTypeName + '</b>','','');
                desc0 = '<b>TOTAL ' + obj.PRVoucher +'=' + CCurrency(CDbl(Number(obj.SumAmount),2)) + ' ' + obj.CurrencyCode + '</b>';
                debit = '';
                credit = '';
                switch (acType) {
                    case 'CA':
                        payType = 'เงินสดย่อย';
                        if (obj.RecvBank !== null) {
                            payType = 'เงินฝากธนาคารหมุนเวียน';
                        }
                        desc0 += obj.PayChqTo !== null ? '<br/>ออกให้กับ ' + obj.PayChqTo : '';
                        desc0 += obj.RecvBank != null ? '<br/>โอนไปยังบัญชีธนาคาร ' + obj.RecvBank + ' สาขา ' + obj.RecvBranch : '';
                        desc0 += obj.BookCode != null ? '<br/>จากเลขที่บัญชี ' + obj.BookCode + ' เลขที่อ้างอิง ' + obj.DocNo : '';
                        desc0 += obj.TRemark != null ? '<br/>วันเวลาที่ทำรายการ : ' + obj.TRemark : '';
                        break;
                    case 'CH':
                        payType = 'เช็คเงินสด';
                    case 'CU':
                        payType = 'เช็ครับล่วงหน้า';
                        desc0 += obj.ChqNo !== null ? '<br/>เช็คเลขที่ ' + obj.ChqNo + ' ลงวันที่ ' + ShowDate(CDateTH(obj.ChqDate)) : '';
                        desc0 += obj.BankCode != null ? '<br/>เช็คธนาคาร ' + obj.BankCode + ' สาขา ' + obj.BankBranch : '';
                        desc0 += obj.PayChqTo !== null ? '<br/>ออกให้กับ ' + obj.PayChqTo : '';
                        desc0 += obj.TRemark != null ? '<br/>หมายเหตุ : ' + obj.TRemark : '';
                        desc0 += obj.RecvBank != null ? '<br/>นำฝากไปยังบัญชีธนาคาร ' + obj.RecvBank + ' สาขา ' + obj.RecvBranch : '';
                        break;
                    case 'CR':
                        payType = 'ลูกหนี้';
                        desc0 += obj.DocNo !== null ? '<br/>ตามเอกสารเลขที่ ' + obj.DocNo + ' ลงวันที่ ' + ShowDate(CDateTH(obj.ChqDate)) : '';
                        desc0 += obj.PayChqTo !== null ? '<br/>ออกให้กับ ' + obj.PayChqTo : '';
                        break;
                }
                switch (vcType) {
                    case 'P':
                        desc += '<table style="text-align:left;width:100%">';
                        desc += '<tr><td>ค่าใช้จ่ายในการปฏิบัติงาน</td></tr>';
                        desc += '<tr><td>ภาษีหัก ณ ที่จ่ายค้างจ่าย</td></tr>';
                        desc += '<tr><td>เจ้าหนี้กรมสรรพากร</td></tr>';
                        desc += '<tr><td>'+payType+'</td></tr>';
                        desc += '</table>';

                        debit += '<table style="text-align:right;width:100%">';
                        debit += '<tr><td>' + CCurrency(CDbl(Number(obj.TotalAmount) + Number(obj.VatExc) + Number(obj.VatInc), 2)) + '</td></tr>';
                        debit += '<tr><td>' + CCurrency(CDbl(Number(obj.WhtExc) + Number(obj.WhtInc), 2)) + '</td></tr>';
                        debit += '<tr><td><br/></td></tr>';
                        debit += '<tr><td><br/></td></tr>';
                        debit += '</table>';

                        credit += '<table style="text-align:right;width:100%">';
                        credit += '<tr><td><br/></td></tr>';
                        credit += '<tr><td><br/></td></tr>';
                        credit += '<tr><td>' + CCurrency(CDbl(Number(obj.WhtExc) + Number(obj.WhtInc), 2)) + '</td></tr>';
                        credit += '<tr><td>' + CCurrency(CDbl(Number(obj.TotalNet) + Number(obj.WhtExc) + Number(obj.WhtInc), 2)) + '</td></tr>';
                        credit += '</table>';
                        break;
                    case 'R':
                        desc += '<table style="text-align:left;width:100%">';
                        desc += '<tr><td>' + payType + '</td></tr>';
                        desc += '<tr><td>ภาษีขาย</td></tr>';
                        desc += '<tr><td>เจ้าหนี้กรมสรรพากร</td></tr>';
                        desc += '<tr><td>ภาษีหัก ณ ที่จ่ายค้างจ่าย</td></tr>';                        
                        desc += '<tr><td>รายได้จากการปฏิบัติงาน</td></tr>';                        
                        desc += '</table>';

                        debit += '<table style="text-align:right;width:100%">';
                        debit += '<tr><td>' + CCurrency(CDbl(Number(obj.TotalAmount), 2)) + '</td></tr>';
                        debit += '<tr><td>' + CCurrency(CDbl(Number(obj.VatExc) + Number(obj.VatInc), 2)) + '</td></tr>';
                        debit += '<tr><td>' + CCurrency(CDbl(Number(obj.WhtExc) + Number(obj.WhtInc), 2)) + '</td></tr>';
                        debit += '<tr><td><br/></td></tr>';
                        debit += '<tr><td><br/></td></tr>';
                        debit += '</table>';

                        credit += '<table style="text-align:right;width:100%">';
                        credit += '<tr><td><br/></td></tr>';
                        credit += '<tr><td><br/></td></tr>';
                        credit += '<tr><td><br/></td></tr>';
                        credit += '<tr><td>' + CCurrency(CDbl(Number(obj.WhtExc) + Number(obj.WhtInc), 2)) + '</td></tr>';
                        credit += '<tr><td>' + CCurrency(CDbl(Number(obj.TotalNet) + Number(obj.WhtExc) + Number(obj.WhtInc), 2)) + '</td></tr>';
                        credit += '</table>';
                        break;
                }
                appendLine(div, desc, debit, credit);
                appendLine(div, '<b>รายการเอกสาร</b>', '<b>ยอดตามเอกสาร</b>', '<b>ยอดที่ชำระ</b>');
                if (data.document !== null) {
                    let doc=data.document.filter(function(r){
                        return r.acType==acType;
                    });
                    if (doc !== undefined) {
                        let count = 0;
                        for(d of doc) {
                            count++;
                            desc = count + '. ' + d.DocNo +' ('+ d.DocType +' By ' + d.CmpCode + ')';

                            appendLine(div, desc, CDbl(d.PaidAmount/CNum(obj.ExchangeRate),2) + ' ' + obj.CurrencyCode + ' (Rate='+ obj.ExchangeRate +')', CCurrency(CDbl(d.TotalAmount,2)));
                        }
                    }
                }                
                desc0 += obj.SICode !== null ? '<br/>สำหรับค่าใช้จ่าย ' + obj.SICode : '';

                //summary section
                desc1 = '<table width="100%">';
                desc1 += '<tr>';
                desc1 += '<td style="text-align:right">';
                desc1 += '<b>AMOUNT</b>';
                desc1 += '</td>';
                desc1 += '</tr>';
                desc1 += '<tr>';
                desc1 += '<td style="text-align:right">';
                desc1 += '<b>VAT' + (obj.VatInc > 0 ? ' Incl=' + CCurrency(CDbl(Number(obj.VatInc),2)) + '' : '') + '</b>';
                desc1 += '</td>';
                desc1 += '</tr>';
                desc1 += '<tr>';
                desc1 += '<td width="80%" style="text-align:right">';
                desc1 += '<b>Tax' + (obj.WhtInc > 0 ? ' Incl=' + CCurrency(CDbl(Number(obj.WhtInc),2)) + '' : '') + '</b>';
                desc1 += '</td>';
                desc1 += '</tr>';
                desc1 += '<tr>';
                desc1 += '<td width="80%" style="text-align:right">';
                desc1 += '<b>TOTAL</b>';
                desc1 += '</td>';
                desc1 += '</tr>';
                desc1 += '</table>';

                desc2 = '<table width="100%">';
                desc2 += '<tr>';
                desc2 += '<td width="20%" style="text-align:right">';
                desc2 += CCurrency(CDbl(Number(obj.TotalAmount),2));
                desc2 += '</td>';
                desc2 += '</tr>';
                desc2 += '<tr>';
                desc2 += '<td width="20%" style="text-align:right">';
                desc2 += CCurrency(CDbl(Number(obj.VatExc),2));
                desc2 += '</td>';
                desc2 += '</tr>';
                desc2 += '<tr>';
                desc2 += '<td width="20%" style="text-align:right">';
                desc2 += CCurrency(CDbl(Number(obj.WhtExc),2));
                desc2 += '</td>';
                desc2 += '</tr>';
                desc2 += '<tr>';
                desc2 += '<td width="20%" style="text-align:right">';
                desc2 += CCurrency(CDbl(Number(obj.TotalNet) + Number(obj.WhtExc) + Number(obj.WhtInc), 2));
                desc2 += '</td>';
                desc2 += '</tr>';
                desc2 += '</table>';

                appendLine(div, desc0, desc1, desc2);
                
            }
        }
        if (data.header !== null) {
            $('#txtControlNo').text(data.header[0].ControlNo);
            $('#txtVoucherType').val(vcTypeName + ' VOUCHER');
            $('#txtVoucherDate').text(ShowDate(CDateTH(data.header[0].VoucherDate)));
            $('#txtRemark').text(data.header[0].TRemark);
        }
    }    
    function appendLine(dv,data,col1,col2) {
        let html = '<tr><td style="border-style:solid;border-width:thin;font-size:11px">';
        html += data;
        html += '</td>';
        html += '<td style="border-style:solid;border-width:thin;font-size:11px;text-align:right" width="150px">' + col1 + '</td>';
        html += '<td style="border-style:solid;border-width:thin;font-size:11px;text-align:right" width="100px">' + col2 + '</td>';
        html += '</tr>';

        dv.append(html);
    }
</script>