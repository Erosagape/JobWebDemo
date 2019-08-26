@Code
    ViewData("Title") = "Reports"
    End Code
    <div class="row">
        <div class="col-sm-6">
            <div style="display:flex">
                <label style="display:block;width:200px">Group Report</label>
                <select id="cboReportGroup" class="form-control dropdown" onchange="ChangeLanguageForm('@ViewBag.Module');" style="width:100%"></select>
            </div>
            <table id="tbReportList" class="table table-responsive">
                <thead>
                    <tr>
                        <th class="desktop">
                            Report Code
                        </th>
                        <th class="all">
                            Report Name
                        </th>
                    </tr>
                </thead>
                <tbody>
               </tbody>
            </table>
        </div>
        <div class="col-sm-6">
            Report Cliteria:<br />
            <table id="tbFields">
                <tr>
                    <td>
                        Date From
                    </td>
                    <td>
                        <input type="date" id="txtDateFrom" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Date To
                    </td>
                    <td>
                        <input type="date" id="txtDateTo" />
                    </td>
                </tr>
            </table>
            <a href="#" class="btn btn-info" id="btnPrnJob" onclick="PrintReport()">
                <i class="fa fa-lg fa-print">Preview Report</i>
            </a>
        </div>
   </div>
<script type="text/javascript" src="~/Scripts/Func/reports.js"></script>
<script type="text/javascript">
    let reportID = '';
    ChangeLanguageForm('@ViewBag.Module');
    $('#tbReportList tbody').on('click', 'tr', function () {
        SetSelect('#tbReportList', this);
        let data = $('#tbReportList').DataTable().row(this).data();
        //alert(data.ReportCode);
        reportID = data.ReportCode;
    });
    function GetCliteria() {
        let w = '?DateFrom=' + $('#txtDateFrom').val();
        w += '&DateTo=' + $('#txtDateTo').val();
        return w;
    }
    function PrintReport() {
        alert(reportID + '\n' + GetCliteria());
    }
</script>
