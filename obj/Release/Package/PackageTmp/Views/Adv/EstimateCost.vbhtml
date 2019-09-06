
@Code
    ViewBag.Title = "Estimate Cost"
End Code
<!-- HTML CONTROLS -->
    <div class="row">
        <div class="col-sm-6">
            <label id="lblBranch">Branch</label>
            <br/>
            <div style="display:flex">
                <input type="text" class="form-control" style="width:60px" id="txtBranchCode" disabled />
                <input type="button" class="btn btn-default" id="btnBrowseBranch" value="..." onclick="SearchData('branch')" />
                <input type="text" class="form-control" style="width:100%" id="txtBranchName" disabled />
            </div>
        </div>
        <div class="col-sm-4">
            <label id="lblJNo">Job No :</label>
            <br />
            <div style="display:flex">
                <input type="text" id="txtJNo" class="form-control">
                <input type="button" class="btn btn-default" id="btnBrowseJob" value="..." onclick="SearchData('job')" />
            </div>
        </div>
        <div class="col-sm-2">
            Status :<br />
            <div style="display:flex">
                <select id="txtStatus" class="form-control dropdown">
                    <option value="R">Required</option>
                    <option value="O">Optional</option>
                </select>
            </div>
        </div>
    </div>
<div class="row">
    <div class="col-sm-6">
        <label for="txtSICode">Code  :</label>
        <br/>
        <div style="display:flex">
            <input type="text" id="txtSICode" class="form-control" style="width:100px" />
            <input type="button" id="btnBrowseS" class="btn btn-default" value="..." onclick="SearchData('service')" />
            <input type="text" id="txtSDescription" class="form-control" style="width:100%" />
        </div>
    </div>
    <div class="col-sm-4">
        Remark :<br />
        <div style="display:flex">
            <input type="text" id="txtTRemark" class="form-control">
        </div>
    </div>
    <div class="col-sm-2">
        Amount :<br />
        <div style="display:flex">
            <input type="number" id="txtAmountCharge" class="form-control" value="0.00">
        </div>
    </div>
</div>
<div id="dvCommand">
    <a href="#" class="btn btn-default w3-purple" id="btnAdd" onclick="ClearData()">
        <i class="fa fa-lg fa-file-o"></i>&nbsp;<b>New</b>
    </a>
    <a href="#" class="btn btn-success" id="btnSave" onclick="SaveData()">
        <i class="fa fa-lg fa-save"></i>&nbsp;<b>Save</b>
    </a>
    <a href="#" class="btn btn-danger" id="btnDelete" onclick="DeleteData()">
        <i class="fa fa-lg fa-trash"></i>&nbsp;<b>Delete</b>
    </a>
    <a href="#" class="btn btn-warning" id="btnCopy" onclick="CopyData()">
        <i class="fa fa-lg fa-copy"></i>&nbsp;<b>Copy From Job</b>
    </a>
    <input type="text" id="txtJobCopyFrom" value="" />
</div>
<p>
    <table id="tbData" class="table table-responsive">
        <thead>
            <tr>
                <th>Code</th>
                <th class="all">Description</th>
                <th class="desktop">Status</th>
                <th>JNo</th>
                <th>AmountCharge</th>
                <th>Clear.No</th>
            </tr>
        </thead>
        <tbody></tbody>
    </table>
</p>

<div id="dvLOVs"></div>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    let branch = getQueryString("BranchCode");
    let job = getQueryString("JNo");
    if (job !== '') {
        $('#txtBranchCode').val(branch);
        ShowBranch(path, branch, '#txtBranchName');
        $('#txtJNo').val(job);
        RefreshGrid();
    } else {
        $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
        $('#txtBranchName').val('@ViewBag.PROFILE_DEFAULT_BRANCH_NAME');
        $('#txtJNo').focus();
    }
    SetEvents();
    function SetEvents() {
        $('#txtSICode').keydown(function (event) {
            if (event.which == 13) {
                let branch = $('#txtBranchCode').val();
                let code = $('#txtSICode').val();
                let job = $('#txtJNo').val();
                ClearData();
                $('#txtSICode').val(code);
                CallBackQueryClearExp(path, branch, code, job, ReadData);
            }
        });
        $('#txtJNo').keydown(function (event) {
            if (event.which == 13) {
                RefreshGrid();
            }
        });
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name,desc1,desc2', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Job
            CreateLOV(dv, '#frmSearchJob', '#tbJob', 'Job List', response, 3);
            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response,4);
            //SICode
            CreateLOV(dv, '#frmSearchSICode', '#tbServ', 'Service Code', response,4);
        });
    }
    //CRUD Functions used in HTML Java Scripts
    function DeleteData() {
        let branch = $('#txtBranchCode').val();
        let code = $('#txtSICode').val();
        let job = $('#txtJNo').val();
        ShowConfirm("Do you need to Delete " + code + "?", function (ask) {
            if (ask == false) return;
            $.get(path + 'adv/delclearexp?branch=' + branch + '&code=' + code + '&job=' + job, function (r) {
                ShowMessage(r.estimate.result);
                ClearData();
            });
        });
    }
    function ReadData(dr) {
        $('#txtBranchCode').val(dr.BranchCode);
        $('#txtJNo').val(dr.JNo);
        $('#txtSICode').val(dr.SICode);
        $('#txtSDescription').val(dr.SDescription);
        $('#txtTRemark').val(dr.TRemark);
        $('#txtAmountCharge').val(dr.AmountCharge);
        $('#txtStatus').val(dr.Status);
    }
    function SaveData() {
        let obj = {
            BranchCode: $('#txtBranchCode').val(),
            JNo:$('#txtJNo').val(),
            SICode:$('#txtSICode').val(),
            SDescription:$('#txtSDescription').val(),
            TRemark:$('#txtTRemark').val(),
            AmountCharge:CNum($('#txtAmountCharge').val()),
            Status:$('#txtStatus').val()
        };
        if (obj.SICode != "") {
            ShowConfirm("Do you need to Save " + obj.SICode + "?", function (ask) {
                if (ask == false) return;
                let jsonText = JSON.stringify({ data: obj });
                //alert(jsonText);
                $.ajax({
                    url: "@Url.Action("SetClearExp", "Adv")",
                    type: "POST",
                    contentType: "application/json",
                    data: jsonText,
                    success: function (response) {
                        if (response.result.data != null) {
                            $('#txtSICode').val(response.result.data);
                            $('#txtSICode').focus();
                        }
                        RefreshGrid();
                        ShowMessage(response.result.msg);
                    },
                    error: function (e) {
                        ShowMessage(e);
                    }
                });
            });
        } else {
            ShowMessage('No data to save');
        }
    }
    function ClearData() {
        //$('#txtJNo').val('');
        $('#txtSICode').val('');
        $('#txtSDescription').val('');
        $('#txtTRemark').val('');
        $('#txtAmountCharge').val('0.00');
        $('#txtStatus').val('R');
    }
    function RefreshGrid() {
        let w = '?Branch=' + $('#txtBranchCode').val();
        if ($('#txtJNo').val() !== '') {
            w += '&Job=' + $('#txtJNo').val();
        }
        $.get(path + 'Adv/GetClearExpReport' + w, function (r) {
            if (r.estimate.data.length == 0) {
                $('#tbData').DataTable().clear().draw();
                return;
            }
            $('#tbData').dataTable({
                data: r.estimate.data,
                columns: [
                    { data: "SICode", title: "Code" },
                    { data: "SDescription", title: "Name" },
                    {
                        data: null, title: "Status",
                        render: function (data) {
                            switch (data.Status) {
                                case 'R':
                                    return 'Required';
                                case 'O':
                                    return 'Optional';
                                default:
                                    return 'N/A';
                            }
                        }
                    },
                    { data: "JNo", title: "Job No" },
                    { data: "AmountCharge", title: "Charge" },
                    { data: "ClrNo", title: "Clearing No" }
                ],
                destroy: true,
                responsive:true
            });
            $('#tbData tbody').on('click', 'tr', function () {
                SetSelect('#tbData', this);
                row = $('#tbData').DataTable().row(this).data(); //read current row selected
                ClearData();
                ReadData(row);
            });
        });
    }
    function SearchData(type) {
        switch (type) {
            case 'code':
                RefreshGrid();
                break;
            case 'branch':
                SetGridBranch(path, '#tbBranch', '#frmSearchBranch', ReadBranch);
                break;
            case 'service':
                SetGridSICodeFilter(path, '#tbServ', '', '#frmSearchSICode', ReadService);
                break;
            case 'job':
                SetGridJob(path, '#tbJob', '#frmSearchJob','', ReadJob);
                break;
        }
    }
    function ReadBranch(dt) {
        $('#txtBranchCode').val(dt.Code);
        $('#txtBranchName').val(dt.BrName);
    }
    function ReadJob(dt) {
        $('#txtJNo').val(dt.JNo);
        RefreshGrid();
    }
    function ReadService(dt) {
        $('#txtSICode').val(dt.SICode);
        $('#txtSDescription').val(dt.NameThai);
    }

    function CopyData() {
        if ($('#txtJobCopyFrom').val() == '') {
            ShowMessage('Please Enter Job To Copy Data From');
            return;
        }
        let w = $('#txtBranchCode').val() + '|' + $('#txtJobCopyFrom').val() + '=' + $('#txtBranchCode').val() + '|' + $('#txtJNo').val();
        $.get(path + 'Adv/CopyClearExp?cliteria=' + w, function (msg) {
            RefreshGrid();
            ShowMessage(msg);
        });
    }
</script>