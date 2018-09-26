@Code
    ViewBag.Title = "Main Task"
End Code
<div class="panel-body">
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-primary">
                <div class="panel panel-body">
                    <div class="col-sm-2">
                        <label id="lblBranch">Branch</label>
                        <select id="cboBranch" class="form-control dropdown"></select>
                    </div>
                    <div class="col-sm-2">
                        <label id="lblJObType">Job Type</label>
                        <select id="cboJobType" class="form-control dropdown"></select>
                    </div>
                    <div class="col-sm-2">
                        <label id="lblShipBy">Ship By</label>
                        <select id="cboShipBy" class="form-control dropdown"></select>
                    </div>
                    <div class="col-sm-2">
                        <label id="lblYear">Year</label>
                        <select id="cboYear" class="form-control dropdown"></select>
                    </div>
                    <div class="col-sm-3">
                        <label id="lblStatus">Status</label>
                        <select id="cboStatus" class="form-control dropdown"></select>
                    </div>
                    <div class="col-sm-1">
                        <button class="btn btn-warning" id="btnRefresh" onclick="getJobdata()">แสดงข้อมูล</button>
                        <button class="btn btn-danger" id="btnGenJob" onclick="CreateNewJob()">สร้างงานใหม่</button>
                    </div>
                </div>
            </div>

        </div>
    </div>
    <div class="row">
        <div class="col-sm-12">
            <table id="tblJob" class="table">
                <thead>
                    <tr>
                        <th>JobNo</th>
                        <th>Inv.Customer</th>
                        <th>Customer</th>
                        <th>DeclareNo</th>
                        <th>Commodity</th>
                    </tr>
                </thead>
            </table>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-12">
            <div class="panel panel-primary">
                <div class="panel panel-heading">
                    <table>
                        <tr>
                            <td>
                                Enter Job >>
                            </td>
                            <td>
                                <input type="text" class="form-control" id="txtJobNo" />
                            </td>
                        </tr>
                    </table>

                </div>
                <div class="panel panel-body">
                    <button id="btnJobSlip" class="btn btn-info" onclick="PrintJob()">Print Slip</button>
                    <button class="btn btn-success" id="btnInfoJob" onclick="OpenJob()">View JOB</button>

                </div>
            </div>

        </div>
    </div>
</div>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    var user = '@ViewBag.User';
    $(document).ready(function () {
        loadCombo();
        getJobdata();
    });
    function loadCombo() {
        loadBranch();
        loadConfig('#cboJobType', 'JOB_TYPE');
        loadConfig('#cboShipBy', 'SHIP_BY');
        loadConfig('#cboStatus', 'JOB_STATUS');
        loadYear();
    }
    function getJobdata() {
        var strParam = GetCliteria();
        var table = $('#tblJob').DataTable({
            "ajax": {
                //"url": "joborder/getjobjson" + strParam,
                "url": path+"joborder/getjobsql" + strParam,
                "dataSrc": "job.data"
            },
            "destroy": true,
            "columns": [
                { "data": "JNo", "title": "Job Number" },
                { "data": "InvNo", "title": "Customer Inv." },
                { "data": "CustCode", "title": "Customer" },
                { "data": "DeclareNumber", "title": "Declare No." },
                { "data": "InvProduct", "title": "Commodity" }
            ]
        });
        $('#tblJob tbody').on('click', 'tr', function () {
            $('#tblJob tbody > tr').removeClass('selected');
            $(this).addClass('selected');

            var data = $('#tblJob').DataTable().row(this).data();
            $('#txtJobNo').val(data.JNo);
        });
    }
    function GetCliteria() {
        return '?JType=' + $('#cboJobType').val() + '&SBy=' + $('#cboShipBy').val() + '&Branch=' + $('#cboBranch').val() + '&Year=' + $('#cboYear').val() + '&Status=' + $('#cboStatus').val();
    }
    function OpenJob() {
        window.open(path +'joborder/showjob?BranchCode=' + $('#cboBranch').val() + '&JNo=' + $('#txtJobNo').val());
    }
    function PrintJob() {
        window.open(path +'PrintJob.html?BranchCode=' + $('#cboBranch').val() + '&JNo=' + $('#txtJobNo').val());
    }
    function CreateNewJob() {
        window.open(path +'joborder/createjob?JType=' + $('#cboJobType').val() + '&SBy=' + $('#cboShipBy').val() + '&Branch=' + $('#cboBranch').val());
    }
    function loadBranch() {
        $('#cboBranch').empty();
        $.get(path +'Config/getBranch').done(function (r) {
            var dr = r.branch.data;
            if (dr.length > 0) {
                for (var i = 0; i < dr.length; i++) {
                    $('#cboBranch')
                        .append($('<option>', { value: dr[i].Code })
                            .text(dr[i].Code + ' / ' + dr[i].BrName));
                }
            }
        });
    }
    function loadConfig(e, code) {
        $(e).empty();
        $.get(path +'Config/getConfig?Code=' + code).done(function (r) {
            var dr = r.config.data;
            if (dr.length > 0) {
                for (var i = 0; i < dr.length; i++) {
                    $(e).append($('<option>', { value: dr[i].ConfigKey })
                        .text(dr[i].ConfigKey + ' / ' + dr[i].ConfigValue));
                }
            }
        });
    }
    function loadYear() {
        $('#cboYear').empty();
        $.get(path +'joborder/getjobyear').done(function (r) {
            var dr = r[0].Table;
            if (dr.length > 0) {
                for (var i = 0; i < dr.length; i++) {
                    $('#cboYear')
                        .append($('<option>', { value: dr[i].JobYear })
                            .text(dr[i].JobYear));
                }
            }
        });
    }
</script>