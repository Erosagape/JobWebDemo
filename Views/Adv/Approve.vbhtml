@Code
    ViewBag.Title = "อนุมัติใบเบิกค่าใช้จ่าย"
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
                Request Date From:<br />
                <input type="date" id="txtAdvDateF" />
            </div>
            <div class="col-sm-2">
                Request Date To:<br />
                <input type="date" id="txtAdvDateT" />
            </div>
            <div class="col-sm-2">
                Job Type: <br />
                <select id="cboJobType" class="form-control dropdown"></select>
            </div>
            <div class="col-sm-2">
                Ship By:<br />
                <select id="cboShipBy" class="form-control dropdown"></select>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                Request By :<br />
                <input type="text" id="txtReqBy" style="width:100px" />
                <button id="btnBrowseEmp2" onclick="SearchData('reqby')">...</button>
                <input type="text" id="txtReqName" style="width:300px" disabled />
            </div>
            <div class="col-sm-6">
                Advance For :<br />
                <input type="text" id="txtCustCode" style="width:120px" />
                <input type="text" id="txtCustBranch" style="width:50px"  />
                <button id="btnBrowseCust" onclick="SearchData('customer')">...</button>
                <input type="text" id="txtCustName" style="width:300px" disabled />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-2">
                <button class="btn btn-warning" id="btnRefresh" onclick="SetGridAdv()">Show</button>
            </div>
            <div class="col-sm-10">
                Approve Document : <input type="text" id="txtListApprove" class="form-control" value="" disabled/>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <table id="tbHeader" class="table table-responsive">
                    <thead>
                        <tr>
                            <th>Adv.No</th>
                            <th>Req.date</th>
                            <th>Job No</th>
                            <th>Inv.No</th>
                            <th>customer</th>
                            <th>Total</th>
                            <th>W-Tax</th>
                            <th>Req.By</th>
                        </tr>
                    </thead>
                </table>
                Approve Total : <input type="text" id="txtSumApprove" class="form-control" value="" />
                <br />
                <input type="button" class="btn btn-success" value="Approve" onclick="ApproveData()" />
            </div>
        </div>
    </div>
    <div id="dvLOVs"></div>
</div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    var user = '@ViewBag.User';
    var arr = [];
    $(document).ready(function () {
        SetEvents();
    });
    function SetEvents() {
        //Combos
        var lists = 'JOB_TYPE=#cboJobType';
        lists += ',SHIP_BY=#cboShipBy';
        loadCombos(path, lists);
        //Events
        $('#txtBranchCode').keydown(function (event) {
            if (event.which == 13) {
                $('#txtBranchName').val('');
                ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            }
        });
        $('#txtReqBy').keydown(function (event) {
            if (event.which == 13) {
                $('#txtReqName').val('');
                ShowUser(path, $('#txtReqBy').val(), '#txtReqName');
            }
        });
        $('#txtCustBranch').keydown(function (event) {
            if (event.which == 13) {
                $('#txtCustName').val('');
                ShowCustomer(path, $('#txtCustCode').val(), $('#txtCustBranch').val(), '#txtCustName');
            }
        });

        //3 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            var dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv, '#frmSearchCust', '#tbCust', 'Customers', response, 3);
            CreateLOV(dv, '#frmSearchReq', '#tbReq', 'Request By', response, 2);
            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response, 2);
        });
    }
    function SetGridAdv() {
        arr = [];
        ShowSummary();

        var w = '';
        if ($('#txtReqBy').val() !== "") {
            w = w + '&reqby=' + $('#txtReqBy').val();
        }
        if ($('#txtCustCode').val() !== "") {
            w = w + '&custcode=' + $('#txtCustCode').val();
        }
        if ($('#txtCustBranch').val() !== "") {
            w = w + '&custbranch=' + $('#txtCustBranch').val();
        }
        if ($('#cboJobType').val() !== "") {
            w = w + '&jtype=' + $('#cboJobType').val();
        }
        if ($('#cboShipBy').val() !== "") {
            w = w + '&sby=' + $('#cboShipBy').val();
        }
        if ($('#txtAdvDateF').val() !== "") {
            w = w + '&DateFrom=' + CDateEN($('#txtAdvDateF').val());
        }
        if ($('#txtAdvDateT').val() !== "") {
            w = w + '&DateTo=' + CDateEN($('#txtAdvDateT').val());
        }
        w = w + '&Status=1';
        $.get(path + 'adv/getadvancegrid?branchcode=' + $('#txtBranchCode').val() + w, function (r) {
            if (r.adv.data.length == 0) {
                $('#tbHeader').DataTable().clear().draw();
                alert('data not found');
                return;
            }
            var h = r.adv.data[0].Table;
            $('#tbHeader').DataTable({
                data: h,
                selected: true, //ให้สามารถเลือกแถวได้
                columns: [ //กำหนด property ของ header column
                    { data: "AdvNo", title: "Advance No" },
                    {
                        data: "AdvDate", title: "Request date ",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "JobNo", title: "Job Number" },
                    { data: "CustInvNo", title: "InvNo" },
                    { data: "CustCode", title: "Customer" },
                    { data: "TotalAdvance", title: "Total" },
                    { data: "Total50Tavi", title: "W/T Amt" },
                    { data: "EmpCode", title: "Request By" }
                ],
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            });
            $('#tbHeader tbody').on('click', 'tr', function () {
                if ($(this).hasClass('selected') == true) {
                    $(this).removeClass('selected');
                    var data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                    RemoveData(data); //callback function from caller 
                    return;
                }
                $(this).addClass('selected');
                var data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                AddData(data); //callback function from caller 
            });
            $('#tbHeader tbody').on('dblclick', 'tr', function () {
                var data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                window.open(path + 'adv/index?BranchCode=' + data.BranchCode + '&AdvNo=' + data.AdvNo,'','');
            });
        });        
    }
    function AddData(o) {
        arr.push(o);
        ShowSummary();
    }
    function RemoveData(o) {
        var idx = arr.indexOf(o);
        if (idx < 0) {
            return;
        }
        arr.splice(idx, 1);
        ShowSummary();
    }
    function ShowSummary() {
        var tot = 0;
        var doc = '';
        for (var i = 0; i < arr.length; i++) {
            var o = arr[i];
            tot += o.TotalAdvance;
            doc += (doc != '' ? ',' : '') + o.AdvNo;
        }
        $('#txtSumApprove').val(CDbl(tot, 2));
        $('#txtListApprove').val(doc);
    }
    function ApproveData() {
        if (arr.length < 0) {
            alert('no data to approve');
            return;
        }
        var dataApp = [];
        dataApp.push(user);
        for (var i = 0; i < arr.length; i++) {
            dataApp.push(arr[0].BranchCode + '|' + arr[0].AdvNo);
        }
        var jsonString = JSON.stringify({ data: dataApp });
        $.ajax({
            url: "@Url.Action("ApproveAdvance", "Adv")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                SetGridAdv();
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
                SetGridUser(path, '#tbReq', '#frmSearchReq', ReadReqBy);
                break;
            case 'customer':
                SetGridCompany(path, '#tbCust', '#frmSearchCust', ReadCustomer);
                break;
        }
    }
    function ReadReqBy(dt) {
        $('#txtReqBy').val(dt.UserID);
        $('#txtReqName').val(dt.TName);
        $('#txtReqBy').focus();
    }
    function ReadBranch(dt) {
        $('#txtBranchCode').val(dt.Code);
        $('#txtBranchName').val(dt.BrName);
        $('#txtBranchCode').focus();
    }
    function ReadCustomer(dt) {
        $('#txtCustCode').val(dt.CustCode);
        $('#txtCustBranch').val(dt.Branch);
        ShowCustomer(path, dt.CustCode, dt.Branch, '#txtCustName');
        $('#txtCustCode').focus();
    }
</script>