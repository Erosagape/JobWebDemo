﻿@Code
    ViewBag.Title = "Job List"
End Code
<div class="panel-body">
    <div class="row">
        <div class="panel-group">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h4 class="panel-title">
                        Main Task
                    </h4>
                </div>
                <div class="panel-body">
                    <div class="col-sm-12">
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
    </div>
    <div class="row">
        <div class="col-sm-3">
            <div id="navbar" class="navbar navbar-collapse">
                <div class="panel-group" id="accordion">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <h4 class="panel-title">
                                <a data-toggle="collapse" data-parent="#accordion" href="#mnuMkt">
                                    Marketing Works
                                </a>
                            </h4>
                        </div>
                        <div id="mnuMkt" class="panel-collapse collapse">
                            <div class="panel-body">
                                <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuMkt">จัดการใบเสนอราคา</a>
                            </div>
                        </div>
                    </div>
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <h4 class="panel-title">
                                <a data-toggle="collapse" data-parent="#accordion" href="#mnuShp">
                                    Shipping Works
                                </a>
                            </h4>
                        </div>
                        <div id="mnuShp" class="panel-collapse collapse">
                            <div class="panel-body">
                                <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuShp">ใบเบิกหลาย job</a>
                                <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuShp">ใบปิดหลาย job</a>
                                <br />
                                <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuShp">ใบเบิกค่าใช้จ่าย</a>
                                <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuShp">ใบปิดค่าใช้จ่าย</a>
                            </div>
                        </div>
                    </div>
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <h4 class="panel-title">
                                <a data-toggle="collapse" data-parent="#accordion" href="#mnuFin">
                                    Finance & Accounting Works
                                </a>
                            </h4>
                        </div>
                        <div id="mnuFin" class="panel-collapse collapse">
                            <div class="panel-body">
                                <a href="#mnuSubFin" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuFin">งานการเงิน</a>
                                <div class="collapse" id="mnuSubFin">
                                    <a href="#" class="list-group-item glyphicon-minus">จ่ายเงินตามใบเบิก</a>
                                    <a href="#" class="list-group-item glyphicon-minus">รับเคลียร์เงินตามใบปิด</a>
                                </div>
                                <a href="#mnuSubAcc" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuFin">งานบัญชี</a>
                                <div class="collapse" id="mnuSubAcc">
                                    <a href="#" class="list-group-item glyphicon-minus">ใบแจ้งหนี้</a>
                                    <a href="#" class="list-group-item glyphicon-minus">ใบเสร็จรับเงิน</a>
                                    <a href="#" class="list-group-item glyphicon-minus">ใบกำกับภาษี</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <div class="panel-title">
                                <a data-toggle="collapse" data-parent="#accordion" href="#mnuAppr">
                                    Approving Documents
                                </a>
                            </div>
                        </div>
                        <div id="mnuAppr" class="panel-collapse collapse">
                            <div class="panel-body">
                                <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuAppr">อนุมัติใบเบิก</a>
                                <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuAppr">อนุมัติใบปิด</a>
                            </div>
                        </div>
                    </div>
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <div class="panel-title">
                                <a data-toggle="collapse" data-parent="#accordion" href="#mnuTrack">
                                    Tracking Information
                                </a>
                            </div>
                        </div>
                        <div id="mnuTrack" class="panel-collapse collapse">
                            <div class="panel-body">
                                <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuTrack">รายงานต่างๆ</a>
                                <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuTrack">ตรวจสอบการทำงาน</a>
                            </div>
                        </div>
                    </div>
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <div class="panel-title">
                                <a data-toggle="collapse" data-parent="#accordion" href="#mnuMas">
                                    Master Files
                                </a>
                            </div>
                        </div>
                        <div id="mnuMas" class="panel-collapse collapse">
                            <div class="panel-body">
                                <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuMas">ข้อมูลทั่วไป</a>
                                <a href="#" class="list-group-item list-group-item-success" data-toggle="collapse" data-parent="#mnuMas" onclick="window.open('Config/Index');">ค่าคงที่ต่างๆ</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-sm-9">
            <div class="panel panel-heading">
                <table>
                    <tr>
                        <td>
                            Enter Job >>
                        </td>
                        <td>
                            <input type="text" class="form-control" id="txtJobNo" />
                        </td>
                        <td>
                            <button id="btnJobSlip" class="btn btn-info" onclick="PrintJob()">Print Slip</button>
                        </td>
                        <td>
                            <button class="btn btn-success" id="btnInfoJob" onclick="OpenJob()">View JOB</button>
                        </td>
                    </tr>
                </table>
                <button class="btn btn-default" id="btnAdvJob">Advance</button>
                <button class="btn btn-default" id="btnClrJob">Clearance</button>
                <button class="btn btn-default" id="btnInvJob">Invoices</button>
                <button class="btn btn-default" id="btnRcvJob">Receipts</button>
            </div>
            <table id="tblJob" class="table display table-bordered table-responsive small">
                <thead>
                    <tr>
                        <th>JobNo</th>
                        <th>Customer</th>
                        <th>Inv.Customer</th>
                        <th>DeclareNo</th>
                        <th>Commodity</th>
                    </tr>
                </thead>
            </table>
        </div>
    </div>
</div>
<script type="text/javascript">
    var path = '@Url.Content("~")';
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
                { "data": "CustCode", "title": "Customer" },
                { "data": "InvNo", "title": "Customer Inv." },
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