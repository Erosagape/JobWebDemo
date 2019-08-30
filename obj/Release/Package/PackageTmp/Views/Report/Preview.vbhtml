@Code
    Layout = "~/Views/Shared/_ReportLandscape.vbhtml"
End Code
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
    let reportID = getQueryString("id");
    let dateFrom = getQueryString("datefrom");
    let dateTo = getQueryString("dateto");
    let custWhere = getQueryString("cust");
    let empWhere = getQueryString("emp");
    let vendWhere = getQueryString("vend");
    let jobWhere = getQueryString("job");
    let statusWhere = getQueryString("status");
    let user = '@ViewBag.User';
    $('#rptCliteria').html(GetCliteria());
    function GetCliteria() {
        let w = 'Date From:' + dateFrom + ',';
        w += 'Date To:' + dateTo + ',';
        w += 'Customer:' + custWhere + ',';
        w += 'Employee:' + empWhere + ',';
        w += 'Vender:' + vendWhere + ',';
        w += 'Status:' + statusWhere + ',';
        w += 'Job:' + jobWhere + '';
    }
    
</script>