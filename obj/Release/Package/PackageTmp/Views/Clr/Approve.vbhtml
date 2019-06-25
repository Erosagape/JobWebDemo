@Code
    ViewBag.Title = "อนุมัติใบปิดค่าใช้จ่าย"
End Code
<div class="panel-body">
    <div class="container">
        <div class="row">
            <div class="col-sm-4">
                Branch :<br />
                <input type="text" id="txtBranchCode" style="width:50px" />
                <button id="btnBrowseBranch" onclick="SearchData('branch')">...</button>
                <input type="text" id="txtBranchName" style="width:200px" disabled />
            </div>
            <div class="col-sm-2">
                Clear Date From:<br />
                <input type="date" id="txtClrDateF" />
            </div>
            <div class="col-sm-2">
                Clear Date To:<br />
                <input type="date" id="txtClrDateT" />
            </div>
            <div class="col-sm-2">
                Job Type: <br />
                <select id="cboJobType" class="form-control dropdown"></select>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                Clear By :<br />
                <input type="text" id="txtClrBy" style="width:100px" />
                <button id="btnBrowseEmp2" onclick="SearchData('reqby')">...</button>
                <input type="text" id="txtClrByName" style="width:300px" disabled />
            </div>
            <div class="col-sm-2">
                Clear From:<br />
                <select id="cboClrFrom" class="form-control dropdown"></select>
            </div>

            <div class="col-sm-2">
                Clear Type:<br />
                <select id="cboClrType" class="form-control dropdown"></select>
            </div>
            <div class="col-sm-2">
                <br/>
                <button class="btn btn-warning" id="btnRefresh" onclick="SetGridClr(true)">Show</button>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                Approve Document : <input type="text" id="txtListApprove" class="form-control" value="" disabled />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <table id="tbHeader" class="table table-responsive">
                    <thead>
                        <tr>
                            <th>Clr.No</th>
                            <th>Clr.date</th>
                            <th>Job No</th>
                            <th>Inv.No</th>
                            <th>Customer</th>
                            <th>Adv.No</th>
                            <th>Adv.Total</th>
                            <th>Clr.Total</th>
                            <th>WH-Tax</th>
                        </tr>
                    </thead>
                </table>
                Expenses Total : <input type="text" id="txtSumApprove" class="form-control" value="" />
                <br />
                <input type="button" class="btn btn-success" value="Approve" onclick="ApproveData()" />
            </div>
        </div>
    </div>
    <div id="dvLOVs"></div>
</div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    const path = '@Url.Content("~")';
    const user = '@ViewBag.User';
    let arr = [];
    //$(document).ready(function () {
    SetEvents();
    $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
    $('#txtBranchName').val('@ViewBag.PROFILE_DEFAULT_BRANCH_NAME'); 
    //});
    function SetEvents() {
        //Combos
        let lists = 'JOB_TYPE=#cboJobType';
        lists += ',CLR_TYPE=#cboClrType';
        lists += ',CLR_FROM=#cboClrFrom';

        loadCombos(path, lists);
        //Events
        $('#txtBranchCode').keydown(function (event) {
            if (event.which == 13) {
                $('#txtBranchName').val('');
                ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            }
        });
        $('#txtClrBy').keydown(function (event) {
            if (event.which == 13) {
                $('#txtClrByName').val('');
                ShowUser(path, $('#txtClrBy').val(), '#txtClrByName');
            }
        });

        //3 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv, '#frmSearchEmp', '#tbEmp', 'Clear By', response, 2);
            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response, 2);
        });
    }
    function SetGridClr(isAlert) {
        arr = [];
        ShowSummary();

        let w = '';
        if ($('#txtClrBy').val() !== "") {
            w = w + '&clrby=' + $('#txtClrBy').val();
        }

        if ($('#cboJobType').val() !== "") {
            w = w + '&jtype=' + $('#cboJobType').val();
        }
        if ($('#cboClrType').val() !== "") {
            w = w + '&ctype=' + $('#cboClrType').val();
        }
        if ($('#cboClrFrom').val() !== "") {
            w = w + '&cfrom=' + $('#cboClrFrom').val();
        }
        if ($('#txtClrDateF').val() !== "") {
            w = w + '&DateFrom=' + CDateEN($('#txtClrDateF').val());
        }
        if ($('#txtClrDateT').val() !== "") {
            w = w + '&DateTo=' + CDateEN($('#txtClrDateT').val());
        }
        w = w + '&Status=1';
        $.get(path + 'clr/getclearinggrid?branchcode=' + $('#txtBranchCode').val() + w, function (r) {
            if (r.clr.data.length == 0) {
                $('#tbHeader').DataTable().clear().draw();
                if (isAlert==true) alert('data not found');
                return;
            }
            let h = r.clr.data[0].Table;
            $('#tbHeader').DataTable({
                data: h,
                selected: true, //ให้สามารถเลือกแถวได้
                columns: [ //กำหนด property ของ header column
                    { data: "ClrNo", title: "Clearing No" },
                    {
                        data: "ClrDate", title: "Clear date ",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "JobNo", title: "Job Number" },
                    { data: "CustInvNo", title: "InvNo" },
                    { data: "CustCode", title: "Customer" },
                    { data: "AdvNO", title: "Adv.No" },
                    { data: "AdvTotal", title: "Total.Adv" },
                    { data: "ClrAmt", title: "Total.Clr" },
                    { data: "Clr50Tavi", title: "W/T" }
                ],
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            });
            $('#tbHeader tbody').on('click', 'tr', function () {
                if ($(this).hasClass('selected') == true) {
                    $(this).removeClass('selected');
                    let data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                    RemoveData(data); //callback function from caller
                    return;
                }
                $(this).addClass('selected');
                let data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                AddData(data); //callback function from caller
            });
            $('#tbHeader tbody').on('dblclick', 'tr', function () {
                let data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                window.open(path + 'clr/index?BranchCode=' + data.BranchCode + '&ClrNo=' + data.ClrNo,'','');
            });
        });
    }
    function AddData(o) {
        arr.push(o);
        ShowSummary();
    }
    function RemoveData(o) {
        let idx = arr.indexOf(o);
        if (idx < 0) {
            return;
        }
        arr.splice(idx, 1);
        ShowSummary();
    }
    function ShowSummary() {
        let tot = 0;
        let doc = '';
        for (let i = 0; i < arr.length; i++) {
            let o = arr[i];
            tot += o.ClrAmt;
            doc += (doc != '' ? ',' : '') + o.ClrNo;
        }
        $('#txtSumApprove').val(CDbl(tot, 2));
        $('#txtListApprove').val(doc);
    }
    function ApproveData() {
        if (arr.length < 0) {
            alert('no data to approve');
            return;
        }
        let dataApp = [];
        dataApp.push(user);
        for (let i = 0; i < arr.length; i++) {
            dataApp.push(arr[i].BranchCode + '|' + arr[i].ClrNo);
        }
        let jsonString = JSON.stringify({ data: dataApp });
        $.ajax({
            url: "@Url.Action("ApproveClearing", "Clr")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                SetGridClr(false);
                response ? alert("Approve Completed!") : alert("Cannot Approve");
            },
            error: function (e) {
                alert(e);
            }
        });
        return;
    }
    function SearchData(type) {
        switch (type) {
            case 'branch':
                SetGridBranch(path, '#tbBranch', '#frmSearchBranch', ReadBranch);
                break;
            case 'reqby':
                SetGridUser(path, '#tbEmp', '#frmSearchEmp', ReadReqBy);
                break;
        }
    }
    function ReadReqBy(dt) {
        $('#txtClrBy').val(dt.UserID);
        $('#txtClrByName').val(dt.TName);
        $('#txtClrBy').focus();
    }
    function ReadBranch(dt) {
        $('#txtBranchCode').val(dt.Code);
        $('#txtBranchName').val(dt.BrName);
        $('#txtBranchCode').focus();
    }
</script>