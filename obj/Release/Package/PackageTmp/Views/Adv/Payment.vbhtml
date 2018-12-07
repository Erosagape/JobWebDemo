@Code
    ViewBag.Title = "จ่ายเงินตามใบเบิกค่าใช้จ่าย"
End Code
<div class="panel-body">
    <div class="container">
        <ul class="nav nav-tabs">
            <li class="active"><a data-toggle="tab" href="#tab1">Select document</a></li>
            <li><a data-toggle="tab" href="#tab2">Payment Info</a></li>
            <li><a data-toggle="tab" href="#tab3">Payment Details</a></li>
        </ul>
        <div class="tab-content">
            <div id="tab1" class="tab-pane fade in active">
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
                        <input type="text" id="txtCustBranch" style="width:50px" />
                        <button id="btnBrowseCust" onclick="SearchData('customer')">...</button>
                        <input type="text" id="txtCustName" style="width:300px" disabled />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-2">
                        <button class="btn btn-warning" id="btnRefresh" onclick="SetGridAdv()">Show</button>
                    </div>
                    <div class="col-sm-10">
                        Payment Document : <input type="text" id="txtListApprove" class="form-control" value="" disabled />
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
                                    <th>Cash/Transfer</th>
                                    <th>Company Chq</th>
                                    <th>Customer Chq</th>
                                    <th>Credit</th>
                                    <th>Total</th>
                                    <th>W-Tax</th>
                                    <th>Req.By</th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
            </div>
            <div id="tab2" class="tab-pane fade">
                <div class="row">
                    <div class="col-sm-3 table-bordered">
                        Cash/Transfer : <input type="text" id="txtAdvCash" class="form-control" value="" />
                        <br />
                        A/C No:<input type="text" id="txtAccNoCash" class="form-control" value="" />
                        <br />
                        Ref No:<input type="text" id="txtRefNoCash" class="form-control" value="" />
                        <br />
                        Trans Date:<input type="date" id="txtCashTranDate" class="form-control" />
                        Trans Time:<input type="text" id="txtCashTranTime" class="form-control" value="" />
                        <br />
                        To Bank:<select id="cboBankCodeCash" class="form-control"></select>
                        To Branch:<input type="text" id="txtBankBranchCash" class="form-control" />
                        Pay To:<input type="text" id="txtCashPayTo" class="form-control" />
                    </div>
                    <div class="col-sm-3 table-bordered">
                        Company Chq : <input type="text" id="txtAdvChqCash" class="form-control" value="" />
                        <br />
                        A/C No:<input type="text" id="txtAccNoChqCash" class="form-control" value="" />
                        <br />
                        Chq No:<input type="text" id="txtRefNoChqCash" class="form-control" value="" />
                        <br />
                        Chq Date:<input type="date" id="txtChqCashTranDate" class="form-control" />
                        <br />
                        <input type="checkbox" id="chkStatusChq" />
                        <label for="chkStatusChq">Returned Cheque</label>
                        <br />
                        Issue Bank:<select id="cboBankCodeChqCash" class="form-control"></select>
                        Issue Branch:<input type="text" id="txtBankBranchChqCash" class="form-control" />
                        Pay To:<input type="text" id="txtChqCashPayTo" class="form-control" />
                    </div>
                    <div class="col-sm-3 table-bordered">
                        Customer Chq : <input type="text" id="txtAdvChq" class="form-control" value="" />
                        <br />
                        A/C No:<input type="text" id="txtAccNoChq" class="form-control" value="" />
                        <br />
                        Chq No:<input type="text" id="txtRefNoChq" class="form-control" value="" />
                        <br />
                        Chq Date:<input type="date" id="txtChqTranDate" class="form-control" />
                        <br />
                        <input type="checkbox" id="chkIsLocal" />
                        <label for="chkIsLocal">Local</label>
                        <br />
                        Issue Bank:<select id="cboBankCodeChq" class="form-control"></select>
                        Issue Branch:<input type="text" id="txtBankBranchChq" class="form-control" />
                        Pay To:<input type="text" id="txtChqPayTo" class="form-control" />

                    </div>
                    <div class="col-sm-3 table-bordered">
                        Credit : <input type="text" id="txtAdvCred" class="form-control" value="" />
                        <br />
                        A/C No:<input type="text" id="txtAccNoCred" class="form-control" value="" />
                        <br />
                        Ref No:<input type="text" id="txtRefNoCred" class="form-control" value="" />
                        <br />
                        C/N Date:<input type="date" id="txtCredTranDate" class="form-control" />
                        Pay To:<input type="text" id="txtCredPayTo" class="form-control" />
                    </div>
                </div>
            </div>
            <div id="tab3" class="tab-pane fade">
                <div class="row">
                    <div class="col-sm-12">
                        <table id="tbDetail" class="table table-responsive">
                            <thead>
                                <tr>
                                    <th>Doc.No</th>
                                    <th>Doc.Type</th>
                                    <th>Doc.Date</th>
                                    <th>Pay.Type</th>
                                    <th>For</th>
                                    <th>Branch</th>
                                    <th>Doc.Total</th>
                                    <th>Paid.Total</th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-3">
                        Payment Date : <input type="date" id="txtPaymentDate" class="form-control" value="" />
                    </div>
                    <div class="col-sm-3">
                        Payment Total : <input type="text" id="txtSumApprove" class="form-control" value="" />
                    </div>
                    <div class="col-sm-6">
                        Remark : <input type="text" id="txtTRemark" class="form-control" value="" />
                    </div>
                </div>
                <input type="button" class="btn btn-success" value="Payment" onclick="ApproveData()" />
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
        w = w + '&Status=2';
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
                    { data: "AdvDate", title: "Request date " },
                    { data: "JobNo", title: "Job Number" },
                    { data: "CustInvNo", title: "InvNo" },
                    { data: "CustCode", title: "Customer" },
                    { data: "AdvCash", title: "Cash/Transfer" },
                    { data: "AdvChqCash", title: "Company Chq" },
                    { data: "AdvChq", title: "Customer Chq" },
                    { data: "AdvCredit", title: "Credit" },
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
        var cash = 0;
        var chq = 0;
        var chqcust = 0;
        var cred = 0;
        var doc = '';
        for (var i = 0; i < arr.length; i++) {
            var o = arr[i];
            tot += o.TotalAdvance;
            cash += o.AdvCash;
            chq += o.AdvChqCash;
            chqcust += o.AdvChq;
            cred += o.AdvCred;
            doc += (doc != '' ? ',' : '') + o.AdvNo;
        }
        $('#txtSumApprove').val(CDbl(tot, 2));
        $('#txtAdvCash').val(CDbl(cash, 2));
        $('#txtAdvChqCash').val(CDbl(chq, 2));
        $('#txtAdvChq').val(CDbl(chqcust, 2));
        $('#txtAdvCred').val(CDbl(cred, 2));
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
            url: "@Url.Action("SetVoucher", "Acc")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                SetGridAdv();
                response ? alert("Payment Completed!") : alert("Cannot Payment");
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
