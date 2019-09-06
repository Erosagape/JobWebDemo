
@Code
    Layout = "~/Views/Shared/_Report.vbhtml"
    ViewBag.Title = "Journal Entry Note"
End Code
<style>
    body {
        font-size: 11px;
    }

    #tbDetail {
        border: solid;
        border-width: thin;
        border-collapse: collapse;
    }

        #tbDetail td, th {
            border: solid;
            border-width: thin;
        }
</style>
<div style="text-align:center;width:100%">
    <h2>G/L Batch Entry</h2>
</div>
<div>
    <b>Batch Reference ID : </b>
    <label id="lblGLRefNo"></label>                                
    <div style="float:right">    
        <b>Record Date :</b>  <label id="lblRecordDate"></label>        
    </div>
</div>
<table id="tbDetail" style="width:100%">
    <thead>
        <tr>
            <th>Item No</th>
            <th>GL Code</th>
            <th>GL Description</th>
            <th>Ref.No</th>
            <th style="text-align:right">Debit</th>
            <th style="text-align:right">Credit</th>
        </tr>
    </thead>
    <tbody></tbody>
    <tfoot>
        <tr>
            <td colspan="4" style="text-align:right;font-weight:bold">Total</td>
            <td style="text-align:right;font-weight:bold">
                <label id="lblTotalDebit"></label>
            </td>
            <td style="text-align:right;font-weight:bold">
                <label id="lblTotalCredit"></label>
            </td>
        </tr>
    </tfoot>
</table>

<script type="text/javascript">
    const path = '@Url.Content("~")';
    let branch = getQueryString('branch');
    let code = getQueryString('code');
    $.get(path + 'Acc/GetJournalEntry?Branch=' + branch + '&Code=' + code, function (data) {
        if (data.journal.header.length > 0) {
            let h = data.journal.header[0];
            $('#lblGLRefNo').text(h.GLRefNo);
            $('#lblRecordDate').text(ShowDate(h.LastupDate));
            $('#lblTotalCredit').text(ShowNumber(h.TotalCredit,2));
            $('#lblTotalDebit').text(ShowNumber(h.TotalDebit,2));
        }
        let html = '';
        if (data.journal.detail.length > 0) {
            for (let d of data.journal.detail) {
                html += '<tr>';
                html += '<td>' + d.ItemNo + '</td>';
                html += '<td>' + d.GLAccountCode + '</td>';
                html += '<td>' + d.GLDescription + '</td>';
                html += '<td>' + d.SourceDocument + '</td>';
                html += '<td style="text-align:right">' + ShowNumber(d.DebitAmt,2) + '</td>';
                html += '<td style="text-align:right">' + ShowNumber(d.CreditAmt,2) + '</td>';
                html += '</tr>';
            }
            $('#tbDetail tbody').html(html);
        }
    });
</script>