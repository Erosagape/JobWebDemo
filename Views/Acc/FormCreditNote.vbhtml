@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.Title = "Credit Note Slip"
    ViewBag.ReportName = ""
End Code
<style>

    td {
        font-size: 12px;
    }

    table {
        border-width: thin;
        border-collapse: collapse;
    }
</style>
<div style="text-align:center">
    <h3><label id="lblDocType">CREDIT NOTE</label></h3>
</div>
<div style="display:flex">
    <div style="flex:3">

    </div>
    <div style="flex:1" align="right">
        เลขที่เอกสาร&nbsp;&nbsp;
    </div>
    <div style="flex:1">
        <label id="lblDocNo"></label>
    </div>
</div>
<br />
<div style="display:flex">
    <div style="flex:3">

    </div>
    <div style="flex:1" align="right">
        วันที่เอกสาร&nbsp;&nbsp;
    </div>
    <div style="flex:1">
        <label id="lblDocDate"></label>
    </div>
</div>
<div style="display:flex">
    <div style="flex:2">
        เลขประจำตัวผู้เสียภาษีอากร <label id="lblCustTaxNumber"></label>
    </div>
    <div style="flex:1">
        <label id="lblCustTaxBranch"></label>
    </div>
    <div style="flex:2" align="right">
        
    </div>
</div>
<div style="display:flex">
    <div style="flex:3">
        ชื่อลูกค้า <label id="lblCustNameThai"></label>
    </div>
    <div style="flex:2" align="right">
        
    </div>
</div>
<div style="display:flex">
    <div style="flex:1">
        <label id="lblCustAddress"></label>
    </div>
    <div style="flex:1">

    </div>
</div>
<br />
<div style="display:flex">
    <div style="flex:1">
        บริษัทได้ปรับปรุงรายการบันทึกบัญชีของท่าน ดังต่อไปนี้
    </div>

</div>
<br />
<table width="100%" border="1">
    <thead>
        <tr class="text-center">
            <th>รายการ</th>
            <th>ใบแจ้งหนี้</th>
            <th>ใบกำกับภาษี</th>
            <th>มูลค่าเดิม</th>
            <th>มูลค่าที่ถูกต้อง</th>
            <th>ผลต่างจำนวนเงิน</th>
        </tr>
    </thead>
    <tbody id="tbDetail">
    </tbody>
    <tfoot>
        <tr>
            <td colspan="5" rowspan="4">
                <div style="display:flex">
                    <div style="flex:4">

                    </div>

                    <div style="flex:1">
                        ผลต่าง <br />
                        ภาษีมูลค่าเพิ่ม <label id="lblVATRate"></label>% <br />
                        หัก ณ ที่จ่าย<br />
                        รวมทั้งสิ้น
                    </div>
                </div>
            </td>
            <td align="right"><label id="lblTotalDiff"></label></td>
        </tr>
        <tr>
            <td align="right"><label id="lblTotalVAT"></label></td>
        </tr>
        <tr>
            <td align="right"><label id="lblTotalWHT"></label></td>
        </tr>
        <tr>
            <td align="right"><label id="lblTotalNet"></label></td>
        </tr>
    </tfoot>
</table>
<br />
<br />
<div style="display:flex">
    <div style="flex:1">

    </div>
    <div style="flex:10 ;border:solid 1px ;" align="center">
        <label id="lblTotalBaht"></label>
    </div>
    <div style="flex:1">

    </div>



</div>
<br />
<div style="display:flex">
    <div style="flex:1">

    </div>
    <div style="flex:6 ">
        <label id="lblRemark"></label>
    </div>
    <div style="flex:1">

    </div>
</div>
<br /><br /><br /><br /><br /><br /><br /><br />
<div style="display:flex">
    <div style="flex:1">

    </div>
    <div style="flex:6 " align="right">
        ผู้อนุมัติ ______________________________
    </div>
    <div style="flex:1">

    </div>
</div>
<script type="text/javascript">
    const path = '@Url.Content("~")';
    let branch = getQueryString('branch');
    let docno = getQueryString('code');
    $.get(path + 'acc/getcreditnote?branch=' + branch + '&code=' + docno, function (r) {
        if (r.creditnote.header.length !== null) {
            ShowData(r.creditnote);
        }
    });
    function ShowData(dt) {
        let h = dt.header[0];
        let c = dt.customer;
        $('#lblCustNameThai').text(c.NameThai);
        $('#lblCustAddress').text(c.TAddress1 + '\n' + c.TAddress2);
        $('#lblCustTaxBranch').text(c.Branch);
        $('#lblCustTaxNumber').text(c.TaxNumber);

        let typeThai = h.DocType == 0 ? 'ลดหนี้' : 'เพิ่มหนี้';
        let typeEng = h.DocType == 0 ? 'CREDIT NOTE' : 'DEBIT NOTE';

        $('#lblDocNo').text(h.DocNo);
        $('#lblDocType').text(typeEng);
        $('#lblDocDate').text(ShowDate(CDateTH(h.DocDate)));
        $('#lblRemark').text('เหตุผลที่' + typeThai + ' ' + h.Remark);

        let html = '';
        let service = 0;
        let vat = 0;
        let wht = 0;
        let total = 0;

        for (let d of dt.detail) {

            html = '<tr>';
            html = '<td>' + d.SDescription + '</td>';
            html += '<td style="text-align:center">' + d.BillingNo + '</td>';
            html += '<td style="text-align:center">' + d.TaxInvNo + '</td>';
            html += '<td style="text-align:right">' + (d.OriginalAmt >0? ShowNumber(d.OriginalAmt,2):'0.00') + '</td>';
            html += '<td style="text-align:right">' + (d.CorrectAmt > 0 ? ShowNumber(d.CorrectAmt, 2) : '0.00') + '</td>';
            html += '<td style="text-align:right">' + (d.DiffAmt > 0 ? ShowNumber(d.DiffAmt, 2) : '0.00') + '</td>';
            html += '</tr>';

            $('#tbDetail').append(html);

            service += Number(d.DiffAmt);
            vat += Number(d.VATAmt);
            wht += Number(d.WHTAmt);
            total += Number(d.TotalNet);
        }
        $('#lblTotalDiff').text(ShowNumber(service, 2));
        $('#lblTotalVAT').text(ShowNumber(vat, 2));
        $('#lblTotalWHT').text(ShowNumber(wht, 2));
        $('#lblTotalNet').text(ShowNumber(total, 2));
        $('#lblTotalBaht').text(CNumThai(total));
    }
</script>
