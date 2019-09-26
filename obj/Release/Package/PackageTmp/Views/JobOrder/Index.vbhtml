@Code
    ViewBag.Title = "Job List"
End Code
<div class="panel-body">
    <div class="row">
        <div class="col-sm-2">
            <label for="cboBranch" id="lblBranch">Branch</label>
            <select id="cboBranch" class="form-control dropdown"></select>
        </div>
        <div class="col-sm-2">
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
        <div class="col-sm-2">
            <div class="btn-group-vertical">
                <br />
                <a href="#" class="btn btn-default w3-purple" id="btnGenJob" onclick="CreateNewJob()">
                    <i class="fa fa-lg fa-file-o"></i> &nbsp;<b>Create Job</b>
                </a>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-12">
            <a href="#" class="btn btn-primary" id="btnRefresh" onclick="getJobdata()">
                <i class="fa fa-lg fa-filter"></i> &nbsp;<b>Search</b>
            </a>
            <table id="tblJob" class="table table-bordered">
                <thead>
                    <tr>
                        <th>JobNo</th>
                        <th class="desktop">DocDate</th>
                        <th class="desktop">JobStatus</th>
                        <th class="all">InspectDate</th>
                        <th class="all">Inv.Customer</th>
                        <th class="desktop">Customer</th>
                        <th>DeclareNo</th>
                        <th class="desktop">Commodity</th>
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
                <button id="btnJobSlip" class="btn btn-success" onclick="OpenJob()">Show</button>
                <a href="#" class="btn btn-info" id="btnPrnJob" onclick="PrintJob()">
                    <i class="fa fa-lg fa-print"></i>
                </a>
            </div>
        </div>
    </div>
</div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    const path = '@Url.Content("~")';
    const user = '@ViewBag.User';
    
    //$(document).ready(function () {
        loadCombo();
        getJobdata();
        SetEvents();
    //});    

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
        let lists = 'JOB_TYPE=#cboJobType';
        lists += ',SHIP_BY=#cboShipBy';
        lists += ',JOB_STATUS=#cboStatus';

        loadCombos(path, lists);
        loadBranch(path);
        loadYear(path);
        loadMonth('#cboMonth');
    }
    function getJobdata() {
        ShowWait();
        $.get(path + 'joborder/updatejobstatus' + GetCliteria(), function (r) {
            CloseWait();
            $('#tblJob').DataTable({
                "ajax": {
                    //"url": "joborder/getjobjson" + strParam,
                    "url": path+"joborder/getjobreport" + GetCliteria(),
                    "dataSrc": "job.data"
                },
                "destroy": true,
                "responsive":true,
                "columns": [
                    { "data": "JNo", "title": "Job Number" },
                    {
                        "data": "DocDate", "title": "Open Date",
                        "render" : function (data) {
                            return CDateEN(data);
                        }
                    },
                    {
                        "data": null, "title": "Job Status",
                        "render": function (data) {
                            return data.JobStatus;
                        }
                    },
                    {
                        "data": "DutyDate", "title": "Clearance Date",
                        "render" : function (data) {
                            return CDateEN(data);
                        }
                    },
                    { "data": "InvNo", "title": "Customer Inv." },
                    { "data": "CustTName", "title": "Customer" },
                    { "data": "DeclareNumber", "title": "Declare No." },
                    { "data": "InvProduct", "title": "Commodity" }
                ]
            });
            $('#tblJob tbody').on('click', 'tr', function () {
                $('#tblJob tbody > tr').removeClass('selected');
                $(this).addClass('selected');

                let data = $('#tblJob').DataTable().row(this).data();
                $('#txtJobNo').val(data.JNo);
            });
            $('#tblJob tbody').on('dblclick', 'tr', function () {
                OpenJob();
            });
            CloseWait();
        });            
    }
    function getJobdata_1() {
        $.get(path + 'joborder/updatejobstatus' + GetCliteria(), function (r) {
            $('#tblJob').DataTable({
                "ajax": {
                    //"url": "joborder/getjobjson" + strParam,
                    "url": path+"joborder/getjobreport" + GetCliteria(),
                    "dataSrc": "job.data"
                },
                "destroy": true,
                "responsive":true,
                "columns": [
                    { "data": "JNo", "title": "Job Number" },
                    {
                        "data": null, "title": "JobType",
                        "render": function (data) {
                            return data.JobTypeName + '/' + data.ShipByName;
                        }
                    },
                    {
                        "data": null, "title": "Job Status",
                        "render": function (data) {
                            return data.JobStatusName;
                        }
                    },
                    {
                        "data": "DutyDate", "title": "Clearance Date",
                        "render" : function (data) {
                            return CDateEN(data);
                        }
                    },
                    { "data": "InvNo", "title": "Customer Inv." },
                    { "data": "CustCode", "title": "Customer" },
                    { "data": "DeclareNumber", "title": "Declare No." },
                    { "data": "InvProduct", "title": "Commodity" }
                ]
            });
            $('#tblJob tbody').on('click', 'tr', function () {
                $('#tblJob tbody > tr').removeClass('selected');
                $(this).addClass('selected');

                let data = $('#tblJob').DataTable().row(this).data();
                $('#txtJobNo').val(data.JNo);
            });
            $('#tblJob tbody').on('dblclick', 'tr', function () {
                OpenJob();
            });
        });            
    }
    function GetCliteria() {
        let str = '';
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
        return '?NoLog=Y&' + str;
    }
    function OpenJob() {
        $.get(path + 'joborder/updatejobstatus?BranchCode=' + $('#cboBranch').val() + '&JNo=' + $('#txtJobNo').val(), function (r) {
            //ShowMessage(r);
            window.open(path + 'joborder/showjob?BranchCode=' + $('#cboBranch').val() + '&JNo=' + $('#txtJobNo').val());
        });
    }
    function PrintJob() {
        window.open(path +'joborder/formjob?BranchCode=' + $('#cboBranch').val() + '&JNo=' + $('#txtJobNo').val());
    }
    function CreateNewJob() {
        window.open(path +'joborder/createjob?JType=' + $('#cboJobType').val() + '&SBy=' + $('#cboShipBy').val() + '&Branch=' + $('#cboBranch').val());
    }

</script>