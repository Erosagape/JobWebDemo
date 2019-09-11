@Code
    Layout = "~/Views/Shared/_ReportLandscape.vbhtml"
End Code
<style>
    #tbData td {
        border:1px solid black;
        text-align:left;
    }
</style>
<h3><label id="rptTitle">Report Title</label></h3>
<table id="tbData" width="100%">
    <thead></thead>
    <tbody>
    </tbody>
    <tfoot></tfoot>
</table>
<div id="rptCliteria">Report Cliteria</div>
<script type="text/javascript" src="~/Scripts/Func/reports.js"></script>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    let data = getQueryString("data");
    let cliteria = getQueryString("cliteria");
    let user = '@ViewBag.User';
    let lang = '@ViewBag.PROFILE_DEFAULT_LANG';
    let row = {};
    if (data !== '') {
        row = JSON.parse(data);
        let obj = JSON.parse(cliteria);
        html = '';
        if (obj.DATEFROM !== '') html += 'Date From:' + obj.DATEFROM + ',';
        if (obj.DATETO !== '') html += 'Date To:' + obj.DATETO + ',';
        if (obj.CUSTWHERE !== '') html += obj.CUSTWHERE + ',';
        if (obj.JOBWHERE !== '') html += obj.JOBWHERE + ',';
        if (obj.VENDWHERE !== '') html += obj.VENDWHERE + ',';
        if (obj.STATUSWHERE !== '') html += obj.STATUSWHERE + ',';
        if (obj.EMPWHERE !== '') html += obj.EMPWHERE + ',';
        $('#rptCliteria').html(html);
        switch (lang) {
            case 'TH':
                $('#rptTitle').text(row.REPORTNAMETH);
                break;
            case 'EN':
                $('#rptTitle').text(row.REPORTNAMEEN);
                break;
        }
        if (row.ReportCode !== '') {
            LoadReport(row.REPORTCODE);
        }

    }
   
</script>