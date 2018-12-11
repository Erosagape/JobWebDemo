@Code
    ViewBag.Title = "Job List"
End Code
<div class="panel-body">
    <div class="row">
        <div class="col-sm-2">
            <label for="cboBranch" id="lblBranch">Branch</label>
            <select id="cboBranch" class="form-control dropdown"></select>
        </div>
        <div class="col-sm-3">
            <label for="cboStatus" id="lblStatus">Status</label>
            <select id="cboStatus" class="form-control dropdown"></select>
        </div>
        <div class="col-sm-2">
            <label for="cboJobType" id="lblJObType">Job Type</label>
            <select id="cboJobType" class="form-control dropdown"></select>
        </div>
        <div class="col-sm-2">
            <label for="cboShipBy" id="lblShipBy">Ship By</label>
            <select id="cboShipBy" class="form-control dropdown"></select>
        </div>
        <div class="col-sm-1">
            <label for="cboYear" id="lblYear">Year</label>
            <select id="cboYear" class="form-control dropdown"></select>
        </div>
        <div class="col-sm-1">
            <label for="cboMonth" id="lblMonth">Month</label>
            <select id="cboMonth" class="form-control dropdown"></select>
        </div>
        <div class="col-sm-1">
            <div class="btn-group-vertical">
                <button class="btn btn-warning" id="btnRefresh" onclick="getJobdata()">Show</button>
                <button class="btn btn-danger" id="btnGenJob" onclick="CreateNewJob()">New</button>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-12">
            <table id="tblJob" class="table table-bordered">
                <thead>
                    <tr>
                        <th>JobNo</th>
                        <th>InspectDate</th>
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
        <div class="col-sm-2">
            <label for="txtJobNo" id="lblJob">Enter Job >></label>
            <input type="text" id="txtJobNo" class="form-control" />
        </div>
        <div class="col-sm-2">
            <br />
            <div class="btn-group">
                <button id="btnJobSlip" class="btn btn-success" onclick="OpenJob()">View</button>
                <button class="btn btn-info" id="btnPrnJob" onclick="PrintJob()">Print</button>
            </div>
        </div>
    </div>
</div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    var user = '@ViewBag.User';
    $(document).ready(function () {
        loadCombo();
        getJobdata();
        SetEvents();
    });
    function SetEvents() {
        $('#txtJobNo').keydown(function (e) {
            if (e.which === 13) {
                if ($('#txtJobNo').val() !== '') {
                    OpenJob();
                }
            }
        });
    }
    function loadCombo() {
        var lists = 'JOB_TYPE=#cboJobType';
        lists += ',SHIP_BY=#cboShipBy';
        lists += ',JOB_STATUS=#cboStatus';

        loadCombos(path, lists);
        loadBranch(path);
        loadYear(path);
        loadMonth('#cboMonth');
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
                {
                    "data": "DutyDate", "title": "Clearance Date",
                    "render" : function (data) {
                        return CDateEN(data);
                    }
                }
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
        $('#tblJob tbody').on('dblclick', 'tr', function () {
            OpenJob();
        });
    }
    function GetCliteria() {
        var str = '';
        if ($('#cboJobType').val() > '') {
            if (str.length > 0) str += '&';
            str += 'JType=' + $('#cboJobType').val();
        }
        if ($('#cboShipBy').val() > '') {
            if (str.length > 0) str += '&';
            str += 'SBy=' + $('#cboShipBy').val();
        }
        if ($('#cboBranch').val() >= '00') {
            if (str.length > 0) str += '&';
            str += 'Branch=' + $('#cboBranch').val();
        }
        if ($('#cboYear').val() > '') {
            if (str.length > 0) str += '&';
            str += 'Year=' + $('#cboYear').val();
        }
        if ($('#cboMonth').val() > '') {
            if (str.length > 0) str += '&';
            str += 'Month=' + $('#cboMonth').val();
        }
        if ($('#cboStatus').val() > '') {
            if (str.length > 0) str += '&';
            str += 'Status=' + $('#cboStatus').val();
        }
        return '?' + str;
    }
    function OpenJob() {
        window.open(path +'joborder/showjob?BranchCode=' + $('#cboBranch').val() + '&JNo=' + $('#txtJobNo').val());
    }
    function PrintJob() {
        window.open(path +'joborder/formjob?BranchCode=' + $('#cboBranch').val() + '&JNo=' + $('#txtJobNo').val());
    }
    function CreateNewJob() {
        window.open(path +'joborder/createjob?JType=' + $('#cboJobType').val() + '&SBy=' + $('#cboShipBy').val() + '&Branch=' + $('#cboBranch').val());
    }

</script>