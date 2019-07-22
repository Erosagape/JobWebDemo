
@Code
    ViewBag.Title = "Budget Policy"
End Code
<div class="panel-body">
    <div id="dvForm" class="container">
        <div class="row">
            <div class="col-sm-6">
                Branch Code :<br />
                <div style="display:flex">
                    <input type="text" id="txtBranchCode" style="width:100px">
                    <input type="button" class="btn btn-default" style="width:50px" value="..." onclick="SearchData('branch')" />
                    <input type="text" id="txtBranchName" style="width:100%" disabled>
                </div>
            </div>
            <div class="col-sm-6">
                <div style="display:flex">
                    <div style="flex:1">
                        Job Type :<br /><select id="txtJobType" class="form-control" value="0"></select>
                    </div>
                    <div style="flex:1">
                        Ship By :<br /><select id="txtShipBy" class="form-control dropdown" value="0"></select>
                    </div>
                </div>
            </div>
        </div>
        <button class="btn btn-primary" onclick="ShowData()">Show Data</button>
        <table id="tbDetail" class="table table-responsive" style="width:100%">
            <thead>
                <tr>
                    <th>Code</th>
                    <th class="all">Description</th>
                    <th class="desktop">Max-Advance</th>
                    <th class="desktop">Max-Cost</th>
                    <th class="desktop">Min-charge</th>
                    <th class="desktop">Min-Profit</th>
                </tr>
            </thead>
            <tbody></tbody>
        </table>
        <div id="dvEditor" class="modal fade" role="dialog">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        Policy ID : <input type="text" id="txtID" value="0" disabled>
                        &nbsp; For &nbsp; <input type="text" id="txtJobTypeShipBy" value="" disabled>
                    </div>
                    <div class="modal-body">
                        <div style="display:flex;flex-wrap:wrap;">
                            <div style="flex:1">Code :<br /><input type="text" id="txtSICode" class="form-control" disabled></div>
                            <div style="flex:5">Description :<br /><input type="text" id="txtSDescription" class="form-control" disabled></div>
                        </div>
                        <div style="display:flex">
                            <div style="flex:1">Remark :<br /><input type="text" id="txtTRemark" class="form-control"></div>
                        </div>
                        <div style="display:flex">
                            <div style="flex:1">Max Advance :<br /><input type="number" id="txtMaxAdvance" class="form-control" value="0.00"></div>
                            <div style="flex:1">Max Cost :<br /><input type="number" id="txtMaxCost" class="form-control" value="0.00"></div>
                            <div style="flex:1">Min Charge :<br /><input type="number" id="txtMinCharge" class="form-control" value="0.00"></div>
                            <div style="flex:1">Min Profit :<br /><input type="number" id="txtMinProfit" class="form-control" value="0.00"></div>
                        </div>
                        <div style="display:flex">
                            <div style="flex:1">
                                Active
                                <br />
                                <select id="txtActive" class="form-control">
                                    <option value="1">Yes</option>
                                    <option value="0">No</option>
                                </select>
                            </div>
                            <div style="flex:1">LastUpdate :<br /><input type="date" id="txtLastUpdate" class="form-control" data-dismiss=""></div>
                            <div style="flex:1">UpdateBy :<br /><input type="text" id="txtUpdateBy" class="form-control" disabled></div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button id="btnSave" class="btn btn-success" onclick="SaveData()">Save</button>
                        <button id="btnDel" class="btn btn-danger" onclick="DeleteData()">Delete</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    let user = '@ViewBag.User';
    let row = {};
    //$(document).ready(function () {
    SetEvents();
    //});
    
    function SetEvents() {
        let lists = 'JOB_TYPE=#txtJobType,SHIP_BY=#txtShipBy';
        loadCombos(path, lists);
        $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
        $('#txtBranchName').val('@ViewBag.PROFILE_DEFAULT_BRANCH_NAME');
    }
    function ShowData() {
        $('#tbDetail').DataTable().clear().draw();
        $.get(path + 'Master/GetServiceBudget?Branch=' + $('#txtBranchCode').val() + '&JType=' + $('#txtJobType').val() + '&SBy=' + $('#txtShipBy').val())
            .done(function (r) {
                let dt = r.budgetpolicy.data;
                var table = $('#tbDetail').dataTable({
                    data: dt[0].Table,
                    columns: [
                        {                        
                            data: null, title: "SICode",
                            render: function (data, type, full, meta) {
                                let html = "<button class='btn btn-default'>" + data.SICode + "</button>";
                                return html;
                            }
                        },
                        { data: "NameThai", title: "Description" },
                        { data: "MaxAdvance", title: "Max-Advance" },
                        { data: "MaxCost", title: "Max-Cost" },
                        { data: "MinCharge", title: "Min-Charge" },
                        { data: "MinProfit", title: "Min-Profit" }
                    ],
                    responsive: true,
                    destroy:true
                });
                $('#tbDetail tbody').on('click', 'tr', function() {
                    $('#tbDetail tbody > tr').removeClass('selected');
                    $(this).addClass('selected');

                    row = $('#tbDetail').DataTable().row(this).data();
                });
                $('#tbDetail tbody').on('click', 'button', function () {
                    ClearData();
                    ReadData(row);
                    $('#dvEditor').modal('show');
                });
            });
    }
    //CRUD Functions used in HTML Java Scripts
    function DeleteData() {
        var code = $('#txtID').val();
        var ask = confirm("Do you need to Delete " + code + "?");
        if (ask == false) return;
            $.get(path + 'master/delbudgetpolicy?code=' + code, function (r) {
                alert(r.budgetpolicy.result);
                ClearData();
            });
    }
	function ReadData(dr){
        $('#txtID').val(CNum(dr.ID));
        $('#txtSICode').val(dr.SICode);
        $('#txtJobTypeShipBy').val($('#txtJobType :selected').text().split('/')[1].trim()+ '/' +$('#txtShipBy :selected').text().split('/')[1].trim());
        $('#txtSDescription').val(dr.NameThai);
        $('#txtTRemark').val(dr.TRemark);
        $('#txtMaxAdvance').val(dr.MaxAdvance);
        $('#txtMaxCost').val(dr.MaxCost);
        $('#txtMinCharge').val(dr.MinCharge);
        $('#txtMinProfit').val(dr.MinProfit);
        $('#txtActive').val(dr.Active);
        $('#txtLastUpdate').val(CDateEN(dr.LastUpdate));
        $('#txtUpdateBy').val(dr.UpdateBy);
	}
	function SaveData(){
		var obj={
            ID:$('#txtID').val(),
            BranchCode:row.BranchCode,
            JobType:row.JobType,
            ShipBy:row.ShipBy,
            SICode:$('#txtSICode').val(),
            SDescription:$('#txtSDescription').val(),
            TRemark:$('#txtTRemark').val(),
            MaxAdvance:CNum($('#txtMaxAdvance').val()),
            MaxCost:CNum($('#txtMaxCost').val()),
            MinCharge:CNum($('#txtMinCharge').val()),
            MinProfit:CNum($('#txtMinProfit').val()),
            Active:$('#txtActive').val(),
            LastUpdate:CDateTH($('#txtLastUpdate').val()),
            UpdateBy:user,
        };
        if (obj.ID !== "") {
            var ask = confirm("Do you need to Save " + obj.ID + "?");
            if (ask == false) return;
            var jsonText = JSON.stringify({ data: obj });
            //alert(jsonText);
            $.ajax({
                url: "@Url.Action("SetBudgetPolicy", "Master")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.data != null) {
                        $('#txtID').val(response.result.data);
                        $('#txtID').focus();
                        $('#dvEditor').modal('hide');
                        ShowData();
                    }
                    alert(response.result.msg);
                },
                error: function (e) {
                    alert(e);
                }
            });
        } else {
            alert('No data to save');
        }
	}
    function ClearData() {
        $('#txtID').val('0');
        $('#txtJobTypeShipBy').val('');
        $('#txtSICode').val('');
        $('#txtSDescription').val('');
        $('#txtTRemark').val('');
        $('#txtMaxAdvance').val('0.00');
        $('#txtMaxCost').val('0.00');
        $('#txtMinCharge').val('0.00');
        $('#txtMinProfit').val('0.00');
        $('#txtActive').val('1');
        $('#txtLastUpdate').val(GetToday());
        $('#txtUpdateBy').val(user);
	}
</script>