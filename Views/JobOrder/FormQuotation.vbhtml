@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.ReportName = "QUOTATION"
    ViewBag.Title = "Quotation Form"
End Code
<style>
    * {
        font-family: Tahoma;
        font-size: 11px;
    }

    td {
        font-size: 11px;
    }

    th {
        text-align: center;
    }

    .number {
        text-align: right;
    }

    tr {
        vertical-align: top;
    }

    table {
        border-width: thin;
        border-collapse: collapse;
    }
</style>
<div style="display:flex">
    <div style="flex:1">
        CUSTOMER : <label id="lblCustName"></label>
    </div>
    <div style="flex:1">
        <div style="flex:1;text-align:right">
            REF : <label id="lblQNo"></label>
        </div>
    </div>
</div>

<div style="display:flex">
    <div style="flex:1">
        <label id="lblCustAddress"></label>
    </div>
    <div style="flex:1">
        <div style="flex:1;text-align:right">
            DATE : <label id="lblDocDate"></label>
        </div>
    </div>
</div>

<div style="display:flex">
    <div style="flex:1">
        <label id="lblCustTelFax"></label>
    </div>
    <div style="flex:1">
        <div style="flex:1;text-align:right">
            OFFERED TO : <label id="lblContactName"></label>
        </div>
    </div>
</div>
<br/>
<div style="display:flex">
    <div style="flex:1">
        <label id="lblDescriptionH"></label>
    </div>    
</div>

<table style="" border="1" width="100%">
    <thead>
        <tr>
            <th width="5%">NO.</th>
            <th width="45%">DESCRIPTION</th>
            <th width="5%">UNIT</th>
            <th width="5%">QTY</th>
            <th width="15%">UNIT PRICE</th>
            <th width="5%">XRT</th>
            <th width="10%">AMOUNT<br />(FC)</th>
            <th width="10%">NET<br />(THB)</th>
        </tr>
    </thead>
    <tbody id="tbDetail">
    </tbody>
    <tfoot>
        <tr>
            <td colspan="6" class="number">GRAND TOTAL (THB)</td>
            <td colspan="2" style="text-align:right"><label id="lblTotalCharge"></label></td>
        </tr>
    </tfoot>
</table>
<p>
    <br />
    <div style="display:flex">
        <div style="flex:1">
            <label id="lblTRemark"></label>
        </div>
    </div>
    <br/>
    <label id="lblDescriptionF"></label>
</p>
<p>
    Best Regards,
    <br/><br /><br /><br />
    <label id="lblManagerName"></label>
</p>
<script type="text/javascript">
    const path = '@Url.Content("~")';
    let branch = getQueryString('branch');
    let docno = getQueryString('docno');
    $.get(path + 'joborder/getquotation?branch=' + branch + '&code=' + docno, function (r) {
        if (r.quotation.header !== null) {
            ShowData(r.quotation);
        }
    });
    function LoadCustomer(cde, br) {
        $.get(path + 'master/getcompany?code=' + cde + '&branch=' + br, function (r) {
            if (r.company.data.length > 0) {
                let c = r.company.data[0];
                $('#lblCustName').text(c.NameThai);
                $('#lblCustAddress').text(c.TAddress1 + '\n' + c.TAddress2);
                $('#lblCustTelFax').text((CStr(c.Phone) == '' ? '' : 'Tel :' + CStr(c.Phone)) + (CStr(c.FaxNumber) == '' ? '' : ' Fax :' + CStr(c.FaxNumber)));
            }
        });
    }
    function ShowData(dt) {
        let h = dt.header[0];
        LoadCustomer(h.CustCode, h.CustBranch);

        $('#lblQNo').text(h.QNo);
        $('#lblDocDate').text(ShowDate(CDateTH(h.DocDate)));
        $('#lblTRemark').text(h.TRemark);
        $('#lblContactName').text(h.ContactName);
        $('#lblDescriptionH').text(h.DescriptionH);
        $('#lblDescriptionF').text(h.DescriptionF);

        ShowUser(path, h.ManagerCode, '#lblManagerName');

        let html = '';
        let service = 0;

        for (let d of dt.detail) {

            html = '<tr><td>' + d.SeqNo + '</td>';
            html += '<td colspan="3">' + d.Description + '</td>';
            html += '<td colspan="2">' + d.JobTypeName + '</td>';
            html += '<td colspan="2">' + d.ShipByName + '</td>';
            html += '</tr>';

            $('#tbDetail').append(html);
            let items = dt.item.filter(function (data) {
                return data.SeqNo == d.SeqNo;
            });
            for (let i of items) {
                let desc = i.DescriptionThai;
                desc += i.UnitDiscntAmt > 0 ? '<br/>Discount (Rate=' + i.UnitDiscntPerc + '%)=' + i.UnitDiscntAmt : '';
                html = '<tr><td></td>';
                html += '<td>' + d.SeqNo + '.' + i.ItemNo + ' ' + desc + '</td>';
                html += '<td>' + i.UnitCheck + '</td>';
                html += '<td>' + i.QtyBegin + '-' + i.QtyEnd + '</td>';
                html += '<td style="text-align:right">' + ShowNumber(i.ChargeAmt, 2) + ' ' + i.CurrencyCode + '</td>';
                html += '<td style="text-align:center">' + i.CurrencyRate + '</td>';                
                html += '<td style="text-align:right">' + ShowNumber(i.TotalAmt,2) + '</td>';
                html += '<td style="text-align:right">' + ShowNumber(i.TotalCharge,2) + '</td>';
                html += '<tr></tr>';

                $('#tbDetail').append(html);
                service += Number(i.TotalCharge);
            }
        }
        $('#lblTotalCharge').text(ShowNumber(service, 2));
    }
</script>