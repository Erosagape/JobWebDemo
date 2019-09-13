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
                <tbody></tbody>
            </table>
        </div>
        <div class="col-sm-6" style="background-color:aliceblue">
            <label id="lblBranch">Branch</label>
            <br />
            <div style="display:flex">
                <input type="text" class="form-control" style="width:60px" id="txtBranchCode" disabled />
                <input type="button" class="btn btn-default" id="btnBrowseBranch" value="..." onclick="BrowseCliteria('branch')" />
                <input type="text" class="form-control" style="width:100%" id="txtBranchName" disabled />
            </div>
            <br/>
            <b>Report Cliteria:</b><br />
            <div style="display:flex;width:100%;flex-direction:column" id="tbDate">
                <div style="display:flex;">
                    <div style="flex:1">
                        Date From
                    </div>
                    <div style="flex:2">
                        <input type="date" id="txtDateFrom" />
                    </div>
                </div>
                <div style="display:flex;">
                    <div style="flex:1">
                        Date To
                    </div>
                    <div style="flex:2">
                        <input type="date" id="txtDateTo" />
                    </div>
                </div>
            </div>
            <div style="display:flex;width:100%;flex-direction:column" id="tbCust">
                <div style="display:flex;">
                    <div style="flex:1">
                        Customer:
                    </div>
                    <div style="flex:2">
                        <textarea id="txtCustCliteria"></textarea>
                        <input type="button" class="btn btn-default" onclick="BrowseCliteria('cust')" value="..." />
                    </div>
                </div>
            </div>
            <div style="display:flex;width:100%;flex-direction:column" id="tbJob">
                <div style="display:flex;">
                    <div style="flex:1">
                        Job Number:
                    </div>
                    <div style="flex:2">
                        <textarea id="txtJobCliteria"></textarea>
                        <input type="button" class="btn btn-default" onclick="BrowseCliteria('job')" value="..." />
                    </div>
                </div>
            </div>
            <div style="display:flex;width:100%;flex-direction:column" id="tbStatus">
                <div style="display:flex;">
                    <div style="flex:1">
                        Status:
                    </div>
                    <div style="flex:2">
                        <textarea id="txtStatusCliteria"></textarea>
                        <input type="button" class="btn btn-default" onclick="BrowseCliteria('status')" value="..." />
                    </div>
                </div>
            </div>
            <div style="display:flex;width:100%;flex-direction:column" id="tbEmp">
                <div style="display:flex;">
                    <div style="flex:1">
                        Employee:
                    </div>
                    <div style="flex:2">
                        <textarea id="txtEmpCliteria"></textarea>
                        <input type="button" class="btn btn-default" onclick="BrowseCliteria('emp')" value="..." />
                    </div>
                </div>
            </div>
            <div style="display:flex;width:100%;flex-direction:column" id="tbVend">
                <div style="display:flex;">
                    <div style="flex:1">
                        Vender:
                    </div>
                    <div style="flex:2">
                        <textarea id="txtVendCliteria"></textarea>
                        <input type="button" class="btn btn-default" onclick="BrowseCliteria('vend')" value="..." />
                    </div>
                </div>
            </div>
        </div>
        <br/>
        <a href="#" class="btn btn-info" id="btnPrnJob" onclick="PrintReport()">
            <i class="fa fa-lg fa-print"><b>Print Report</b></i>
        </a>
        <div id="dvCliteria" class="modal fade">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <label id="lblCliteria">Select Cliteria of xxx</label>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-sm-4">
                                <select id="selCliteria" class="form-control dropdown">
                                    <option value="=">Equal</option>
                                    <option value="&gt=">Greater/Equal</option>
                                    <option value="&lt=">Less than/Equal</option>
                                    <option value="&lt&gt">Not Equal</option>
                                    <option value="Like%">Contain</option>
                                </select>
                            </div>
                            <div class="col-sm-8" style="display:flex">                                
                                <input type="text" id="txtValue" class="form-control" style="width:100%" />
                                <input type="button" class="btn btn-default" onclick="SearchData()" value="..." />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3">
                                <select id="selOption" class="form-control dropdown">
                                    <option value="AND">AND</option>
                                    <option value="OR">OR</option>
                                </select>
                            </div>
                            <div class="col-sm-3">
                                <input type="button" class="btn btn-warning" onclick="SetData()" value="Add Clieria" />
                            </div>
                            <div class="col-sm-6">
                                <label>Your Cliteria is:</label>
                                <div id="dvSql"></div>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <div style="float:left">
                            <input type="button" class="btn btn-success" onclick="AddData()" value="Apply Cliteria" />
                        </div>
                        <button type="button" class="btn btn-danger" data-dismiss="modal">X</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
<div id="dvLOVs"></div>
<script type="text/javascript" src="~/Scripts/Func/reports.js"></script>
<script type="text/javascript">
    let reportID = '';
    let browseWhat = '';
    let cliterias = [];
    let data = {};
    ChangeLanguageForm('@ViewBag.Module');
    SetEvents();
    $('#tbReportList tbody').on('click', 'tr', function () {
        SetSelect('#tbReportList', this);
        data = $('#tbReportList').DataTable().row(this).data();
        reportID = data.ReportCode;
        
        LoadCliteria(reportID);
    });
    function GetCliteria() {
        let obj = {
            branch: '[BRANCH]=' + $('#txtBranchCode').val(),
            dateFrom: '[DATE]>=' + $('#txtDateFrom').val(),
            dateTo: '[DATE]<=' + $('#txtDateTo').val(),
            custWhere: $('#txtCustCliteria').val(),
            jobWhere: $('#txtJobCliteria').val(),
            empWhere: $('#txtEmpCliteria').val(),
            vendWhere: $('#txtVendCliteria').val(),
            statusWhere: $('#txtStatusCliteria').val(),
        };
        let str = JSON.stringify(obj);
        return '?data=' + JSON.stringify(data) + '&cliteria=' + encodeURIComponent(str);
    }
    function SetEvents() {
        $.get('/Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("dvLOVs");
            CreateLOV(dv, '#frmSearchBranch', '#tblBranch', 'Search Branch', response, 2);
            CreateLOV(dv, '#frmSearchCust', '#tblCust', 'Search Customers', response, 3);
            CreateLOV(dv, '#frmSearchJob', '#tblJob', 'Search Job', response, 3);
            CreateLOV(dv, '#frmSearchVend', '#tblVend', 'Search Venders', response, 2);
            CreateLOV(dv, '#frmSearchEmp', '#tblEmp', 'Search Employee', response, 2);
            CreateLOV(dv, '#frmSearchStatus', '#tblStatus', 'Search Status', response, 3);
        });
    }
    function BrowseCliteria(what) {
        browseWhat = what;
        switch (browseWhat) {
            case 'branch':
                SearchData();
                return;
            case 'cust':             
                $('#lblCliteria').text('Filter Data For Customer');
                break;
            case 'job':
                $('#lblCliteria').text('Filter Data For Job');
                break;
            case 'vend':
                $('#lblCliteria').text('Filter Data For Vender');
                break;
            case 'emp':
                $('#lblCliteria').text('Filter Data For Staff');
                break;
            case 'status':
                let type = GetReportStatus(reportID);
                if (type !== '') {
                    $('#lblCliteria').text('Filter Data For ' + type);
                }
                break;
        }
        $('#dvSql').html('');
        $('#txtValue').val('');
        cliterias = [];
        $('#dvCliteria').modal('show');
    }
    function SearchData() {        
        switch (browseWhat) {
            case 'branch':
                SetGridBranch('/', '#tblBranch', '#frmSearchBranch', ReadBranch);
                break;
            case 'cust':             
                SetGridCompany('/', '#tblCust', '#frmSearchCust',ReadData);
                break;
            case 'job':
                SetGridJob('/', '#tblJob', '#frmSearchJob', '', ReadData);
                break;
            case 'vend':
                SetGridVender('/', '#tblVend', '#frmSearchVend', ReadData);
                break;
            case 'emp':
                SetGridUser('/', '#tblEmp', '#frmSearchEmp', ReadData);
                break;
            case 'status':
                let type = GetReportStatus(reportID);
                if (type !== '') {
                    SetGridConfigVal('/', '#tblStatus', type, '#frmSearchStatus', ReadData);
                }
                break;
        }
    }
    function ReadBranch(dt) {
        $('#txtBranchCode').val(dt.Code);
        $('#txtBranchName').val(dt.BrName);
    }
    function ReadData(dr) {
        switch (browseWhat) {
            case 'cust':
                $('#txtValue').val(dr.CustCode);
                break;
            case 'job':
                $('#txtValue').val(dr.JNo);
                break;
            case 'vend':
                $('#txtValue').val(dr.VenCode);
                break;
            case 'emp':
                $('#txtValue').val(dr.UserID);
                break;
            case 'status':
                $('#txtValue').val(dr.ConfigKey);
                break;
        }
    }
    function SetData() {        
        let str = '[' + browseWhat + ']';
        if (cliterias.length > 0 && $('#selOption').val() == "OR") {
            str = $('#selOption').val() + str;
        }
        cliterias.push(str + '' + $('#selCliteria').val() + $('#txtValue').val());
        $('#dvSql').html(cliterias.toString());
        $('#txtValue').val('');
    }
    function AddData() {
        if ($('#txtValue').val() !== '') {
            SetData();
        }
        let cliteria=$('#dvSql').html();
        switch (browseWhat) {
            case 'cust':
                $('#txtCustCliteria').val(cliteria);
                break;
            case 'job':
                $('#txtJobCliteria').val(cliteria);
                break;
            case 'vend':
                $('#txtVendCliteria').val(cliteria);
                break;
            case 'emp':
                $('#txtEmpCliteria').val(cliteria);
                break;
            case 'status':
                $('#txtStatusCliteria').val(cliteria);
                break;
        }
        $('#dvCliteria').modal('hide');
    }
    function PrintReport() {
        window.open('/Report/Preview' + GetCliteria(), '', '');
    }
</script>
