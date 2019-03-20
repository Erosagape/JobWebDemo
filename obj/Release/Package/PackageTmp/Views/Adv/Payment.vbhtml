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
                        <br/>
                        <button class="btn btn-warning" id="btnRefresh" onclick="SetGridAdv()">Show</button>
                    </div>
                    <div class="col-sm-10">
                        Payment Document : <br/><input type="text" id="txtListApprove" class="form-control" value="" disabled />
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
                    <div class="col-sm-3 table-bordered" id="dvCash">
                        <b>Cash/Transfer :</b><input type="text" id="txtAdvCash" class="form-control" value="" />
                        <br />
                        <table>
                            <tr>
                                <td>
                                    Book A/C:<br /><input type="text" id="txtBookCash" class="form-control" value="" />
                                </td>
                                <td>
                                    <br />
                                    <input type="button" class="btn btn-default" onclick="SearchData('cashacc')" value="..." />
                                </td>
                            </tr>
                        </table>
                        <br />
                        Trans.No:<input type="text" id="txtRefNoCash" class="form-control" value="" />
                        <br />
                        Trans.Date:<input type="date" id="txtCashTranDate" class="form-control" />
                        Trans.Time:<input type="text" id="txtCashTranTime" class="form-control" value="" />
                        <br />
                        To Bank:<select id="cboBankCash" class="form-control"></select>
                        To Branch:<input type="text" id="txtBankBranchCash" class="form-control" />
                        Pay To:<input type="text" id="txtCashPayTo" class="form-control" />
                    </div>
                    <div class="col-sm-3 table-bordered" id="dvChqCash">
                        <b>Company Chq :</b><input type="text" id="txtAdvChqCash" class="form-control" value="" />
                        <br />
                        <table>
                            <tr>
                                <td>
                                    Book A/C:<br/><input type="text" id="txtBookChqCash" class="form-control" value="" />
                                </td>
                                <td>
                                    <br />
                                    <input type="button" class="btn btn-default" onclick="SearchData('chqacc')" value="..." />
                                </td>
                            </tr>
                        </table>
                        <br />
                        Chq No:<input type="text" id="txtRefNoChqCash" class="form-control" value="" />
                        <br />
                        Chq Date:<input type="date" id="txtChqCashTranDate" class="form-control" />
                        <br />
                        <input type="checkbox" id="chkStatusChq" />
                        <label for="chkStatusChq">Returned Cheque</label>
                        <br />
                        Chq Bank:<select id="cboBankChqCash" class="form-control"></select>
                        Chq Branch:<input type="text" id="txtBankBranchChqCash" class="form-control" />
                        Pay To:<input type="text" id="txtChqCashPayTo" class="form-control" />
                    </div>
                    <div class="col-sm-3 table-bordered" id="dvChq">
                        <b>Customer Chq : </b><input type="text" id="txtAdvChq" class="form-control" value="" />
                        <br />
                        Chq No:<input type="text" id="txtRefNoChq" class="form-control" value="" />
                        <br />
                        Chq Date:<input type="date" id="txtChqTranDate" class="form-control" />
                        <br />
                        <input type="checkbox" id="chkIsLocal" />
                        <label for="chkIsLocal">Local</label>
                        <br />
                        Issue Bank:<select id="cboBankChq" class="form-control"></select>
                        Issue Branch:<input type="text" id="txtBankBranchChq" class="form-control" />
                        Pay To:<input type="text" id="txtChqPayTo" class="form-control" />

                    </div>
                    <div class="col-sm-3 table-bordered" id="dvCred">
                        <b>Credit : </b><input type="text" id="txtAdvCred" class="form-control" value="" />
                        <br />
                        Ref No:<input type="text" id="txtRefNoCred" class="form-control" value="" />
                        <br />
                        Ref Date:<input type="date" id="txtCredTranDate" class="form-control" />
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
                    <div class="col-sm-2">
                        Payment Date : <input type="date" id="txtPaymentDate" class="form-control" value="" />
                    </div>
                    <div class="col-sm-2">
                        Payment Total : <input type="text" id="txtSumApprove" class="form-control" value="" />
                    </div>
                    <div class="col-sm-2">
                        W/T Total : <input type="text" id="txtSumWHTax" class="form-control" value="" />
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
    var list = [];
    var docno = '';
    $(document).ready(function () {
        SetEvents();
    });
    function SetEvents() {
        //Combos
        var lists = 'JOB_TYPE=#cboJobType';
        lists += ',SHIP_BY=#cboShipBy';
        loadCombos(path, lists);

        var cbos = ['#cboBankCash', '#cboBankChqCash', '#cboBankChq'];
        loadBank(cbos, path);
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
            CreateLOV(dv, '#frmSearchBookCash', '#tbBookCash', 'Book Accounts', response, 2);
            CreateLOV(dv, '#frmSearchBookChq', '#tbBookChq', 'Book Accounts', response, 2);
        });
    }
    function ClearData() {
        $('#txtAdvCash').val('');
        $('#txtBookCash').val('');
        $('#txtRefNoCash').val('');
        $('#txtCashTranDate').val('');
        $('#txtCashTranTime').val('');
        $('#cboBankCash').val('');
        $('#txtBankBranchCash').val('');
        $('#txtCashPayTo').val('');
        $('#txtAdvChqCash').val('');
        $('#txtBookChqCash').val('');
        $('#txtRefNoChqCash').val('');
        $('#txtChqCashTranDate').val('');
        $('#chkStatusChq').prop('checked', false);
        $('#cboBankChqCash').val('');
        $('#txtBankBranchChqCash').val('');
        $('#txtChqCashPayTo').val('');
        $('#txtAdvChq').val('');
        $('#txtRefNoChq').val('');
        $('#txtChqTranDate').val('');
        $('#chkIsLocal').prop('checked', false);
        $('#cboBankChq').val('');
        $('#txtBankBranchChq').val('');
        $('#txtChqPayTo').val('');
        $('#txtAdvCred').val('');
        $('#txtRefNoCred').val('');
        $('#txtCredTranDate').val('');
        $('#txtCredPayTo').val('');
        $('#txtPaymentDate').val(CDateEN(GetToday()));
        $('#txtSumApprove').val('');
        $('#txtSumWHTax').val('');
        $('#txtTRemark').val('');
    }
    function SetGridAdv() {
        arr = [];
        ClearData();
        ShowSummary();
        docno = '';

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
            $('#tbHeader').DataTable().destroy();
            $('#tbHeader').empty();
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
                    { data: "AdvCash", title: "Cash/Transfer" },
                    { data: "AdvChqCash", title: "Company Chq" },
                    { data: "AdvChq", title: "Customer Chq" },
                    { data: "AdvCred", title: "Credit" },
                    { data: "TotalAdvance", title: "Total" },
                    { data: "Total50Tavi", title: "W/T Amt" },
                    { data: "EmpCode", title: "Request By" }
                ]
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
    function SetStatusInput(d,bl) {
        if (bl==false) {
            $(d + ' :input').attr('disabled', true);
        } else {
            $(d + ' :input').removeAttr('disabled');
        }
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
        var wtax = 0;
        var doc = '';
        list = [];

        for (var i = 0; i < arr.length; i++) {

            var o = arr[i];
            wtax += (o.Total50Tavi > 0 ? o.Total50Tavi : 0);
            tot += (o.TotalAdvance > 0 ? o.TotalAdvance+o.TotalVAT-o.Total50Tavi : 0);
            cash += (o.AdvCash > 0 ? o.AdvCash : 0);
            chq += (o.AdvChqCash > 0 ? o.AdvChqCash : 0);
            chqcust += (o.AdvChq > 0 ? o.AdvChq : 0);
            cred += (o.AdvCred > 0 ? o.AdvCred : 0);
            doc += (doc != '' ? ',' : '') + o.AdvNo;
            if (o.AdvCash > 0) {
                var obj = {
                    BranchCode: $('#txtBranchCode').val(),
                    ControlNo: null,
                    ItemNo: i + 1,
                    DocType: 'ADV',
                    DocNo: o.AdvNo,
                    DocDate: CDateTH(o.AdvDate),
                    CmpType: 'C',
                    CmpCode: o.CustCode,
                    CmpBranch: o.CustBranch,
                    PaidAmount: CDbl(o.AdvCash, 2),
                    TotalAmount: CDbl((o.TotalAdvance + o.TotalVAT), 2),
                    acType:'CA'
                };
                list.push(obj);
            }
            if (o.AdvChqCash > 0) {
                var obj = {
                    BranchCode: $('#txtBranchCode').val(),
                    ControlNo: null,
                    ItemNo: i + 1,
                    DocType: 'ADV',
                    DocNo: o.AdvNo,
                    DocDate: CDateTH(o.AdvDate),
                    CmpType: 'C',
                    CmpCode: o.CustCode,
                    CmpBranch: o.CustBranch,
                    PaidAmount: CDbl(o.AdvChqCash, 2),
                    TotalAmount: CDbl((o.TotalAdvance + o.TotalVAT), 2),
                    acType:'CU'
                };
                list.push(obj);
            }
            if (o.AdvChq > 0) {
                var obj = {
                    BranchCode: $('#txtBranchCode').val(),
                    ControlNo: null,
                    ItemNo: i + 1,
                    DocType: 'ADV',
                    DocNo: o.AdvNo,
                    DocDate: CDateTH(o.AdvDate),
                    CmpType: 'C',
                    CmpCode: o.CustCode,
                    CmpBranch: o.CustBranch,
                    PaidAmount: CDbl(o.AdvChq, 2),
                    TotalAmount: CDbl((o.TotalAdvance + o.TotalVAT), 2),
                    acType:'CH'
                };
                list.push(obj);
            }
            if (o.AdvCred > 0) {
                var obj = {
                    BranchCode: $('#txtBranchCode').val(),
                    ControlNo: null,
                    ItemNo: i + 1,
                    DocType: 'ADV',
                    DocNo: o.AdvNo,
                    DocDate: CDateTH(o.AdvDate),
                    CmpType: 'C',
                    CmpCode: o.CustCode,
                    CmpBranch: o.CustBranch,
                    PaidAmount: CDbl(o.AdvCred, 2),
                    TotalAmount: CDbl((o.TotalAdvance + o.TotalVAT), 2),
                    acType:'CR'
                };
                list.push(obj);
            }
        }
        //show selected details
        $('#tbDetail').DataTable({
            data: list,
            selected: true, //ให้สามารถเลือกแถวได้
            columns: [ //กำหนด property ของ header column
                { data: "DocNo", title: "Doc.No" },
                { data: "DocType", title: "Type " },
                {
                    data: "DocDate", title: "Date",
                    render: function (data) {
                        return CDateEN(data);
                    }
                },
                { data: "CmpType", title: "For" },
                { data: "CmpCode", title: "Customer" },
                { data: "CmpBranch", title: "Branch" },
                { data: "TotalAmount", title: "Doc.Total" },
                { data: "PaidAmount", title: "Paid" }
            ],
            destroy:true
        });

        SetStatusInput('#dvCash', (cash > 0 ? true : false));
        SetStatusInput('#dvChqCash', (chq > 0 ? true : false));
        SetStatusInput('#dvChq', (chqcust > 0 ? true : false));
        SetStatusInput('#dvCred', (cred > 0 ? true : false));

        $('#txtSumApprove').val(CDbl(tot, 2));
        $('#txtSumWHTax').val(CDbl(wtax, 2));
        $('#txtAdvCash').val(CDbl(cash, 2));
        $('#txtAdvChqCash').val(CDbl(chq, 2));
        $('#txtAdvChq').val(CDbl(chqcust, 2));
        $('#txtAdvCred').val(CDbl(cred, 2));
        $('#txtListApprove').val(doc);
    }
    function SavePayment() {
        var oData = [];
        var i = 0;
        if ($('#txtAdvCash').val() > 0) {
            i = i + 1;
            oData.push({
                BranchCode: $('#txtBranchCode').val(),
                ControlNo: docno,
                ItemNo: i,
                PRVoucher: '',
                PRType: 'P',
                ChqNo: '',
                BookCode: $('#txtBookCash').val(),
                BankCode: '',
                BankBranch: '',
                ChqDate: '',
                CashAmount: CNum($('#txtAdvCash').val()),
                ChqAmount: 0,
                CreditAmount: 0,
                IsLocal: 0,
                ChqStatus: '',
                TRemark: $('#txtCashTranDate').val() + '-' + $('#txtCashTranTime').val(),
                PayChqTo: $('#txtCashPayTo').val(),
                DocNo: $('#txtRefNoCash').val(),
                SICode: '',
                RecvBank: $('#cboBankCash').val(),
                RecvBranch: $('#txtBankBranchCash').val(),
                acType : 'CA'
            });
        }
        if ($('#txtAdvChqCash').val() > 0) {
            i = i + 1;
            oData.push({
                BranchCode: $('#txtBranchCode').val(),
                ControlNo: docno,
                ItemNo: i,
                PRVoucher: '',
                PRType: 'P',
                ChqNo: $('#txtRefNoChqCash').val(),
                BookCode: $('#txtBookChqCash').val(),
                BankCode: '',
                BankBranch: '',
                ChqDate: CDateTH($('#txtChqCashTranDate').val()),
                CashAmount: 0,
                ChqAmount: CNum($('#txtAdvChqCash').val()),
                CreditAmount: 0,
                IsLocal: 0,
                ChqStatus: $('#chkStatusChq').prop('checked')==true? 'P':'',
                TRemark: '',
                PayChqTo: $('#txtChqCashPayTo').val(),
                DocNo: '',
                SICode: '',
                RecvBank: $('#cboBankChqCash').val(),
                RecvBranch: $('#txtBankBranchChqCash').val(),
                acType: 'CU'
            });
        }
        if ($('#txtAdvChq').val() > 0) {
            oData.push({
                BranchCode: $('#txtBranchCode').val(),
                ControlNo: docno,
                ItemNo: i,
                PRVoucher: '',
                PRType: 'P',
                ChqNo: $('#txtRefNoChq').val(),
                BookCode: $('#txtBookChq').val(),
                BankCode: $('#cboBankChq').val(),
                BankBranch: $('#txtBankBranchChq').val(),
                ChqDate: CDateTH($('#txtChqTranDate').val()),
                CashAmount: 0,
                ChqAmount: CNum($('#txtAdvChq').val()),
                CreditAmount: 0,
                IsLocal: $('#chkIsLocal').prop('checked') == true ? 'P' : '',
                ChqStatus: '',
                TRemark: '',
                PayChqTo: $('#txtChqPayTo').val(),
                DocNo: '',
                SICode: '',
                RecvBank: '',
                RecvBranch: '',
                acType: 'CH'
            });
        }
        if ($('#txtAdvCred').val() > 0) {
            i = i + 1;
            oData.push({
                BranchCode: $('#txtBranchCode').val(),
                ControlNo: docno,
                ItemNo: i,
                PRVoucher: '',
                PRType: 'P',
                ChqNo: '',
                BookCode: $('#txtBookCred').val(),
                BankCode: '',
                BankBranch: '',
                ChqDate: CDateTH($('#txtCredTranDate').val()),
                CashAmount: 0,
                ChqAmount: 0,
                CreditAmount: CNum($('#txtAdvCred').val()),
                IsLocal: 0,
                ChqStatus: '',
                TRemark: '',
                PayChqTo: $('#txtCredPayTo').val(),
                DocNo: $('#txtRefNoCred').val(),
                SICode: '',
                RecvBank: '',
                RecvBranch: '',
                acType: 'CR'
            });
        }
        if (oData.length > 0) {
            var jsonString = JSON.stringify({ data: oData });
            $.ajax({
                url: "@Url.Action("SetVoucherSub", "Acc")",
                type: "POST",
                contentType: "application/json",
                data: jsonString,
                success: function (response) {
                    if (response.result.data != null) {
                        SaveDetail();
                    }
                },
                error: function (e) {
                    alert(e);
                }
            });
        } else {
            alert('No data need to payment');
        }
    }
    function SaveDetail() {
        if (list.length > 0) {
            for (var i = 0; i < list.length; i++) {
                var o = list[i];
                o.ControlNo = docno;
            }
            var jsonString = JSON.stringify({ data: list });
            $.ajax({
                url: "@Url.Action("SetVoucherDoc", "Acc")",
                type: "POST",
                contentType: "application/json",
                data: jsonString,
                success: function (response) {
                    if (response.result.data != null) {
                        UpdateAdvance(response.result.data);
                    }
                },
                error: function (e) {
                    alert(e);
                }
            });
        }
    }
    function UpdateAdvance(cno) {
        var msg = "Payment " + cno + " Completed!";

        var dataApp = [];
        dataApp.push(user + '|' + cno);
        for (var i = 0; i < list.length; i++) {
            dataApp.push(list[i].BranchCode + '|' + list[i].DocNo);
        }

        var jsonString = JSON.stringify({ data: dataApp });
        $.ajax({
            url: "@Url.Action("PaymentAdvance", "Adv")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                SetGridAdv();
                response ? alert(msg) : alert("Cannot Payment");
            },
            error: function (e) {
                alert(e);
            }
        });
    }
    function ApproveData() {
        if (arr.length < 0) {
            alert('no data to approve');
            return;
        }
        var oHeader = {
            BranchCode: $('#txtBranchCode').val(),
            ControlNo: '',
            VoucherDate: CDateTH($('#txtPaymentDate').val()),
            TRemark: $('#txtTRemark').val(),
            RecUser: user,
            RecDate: CDateTH(GetToday()),
            RecTime: CDateTH(GetTime()),
            PostedBy: '',
            PostedDate: '',
            PostedTime: '',
            CancelReson: '',
            CancelProve: '',
            CancelDate: '',
            CancelTime: ''
        };
        docno = '';
        var jsonString = JSON.stringify({ data: oHeader });
        $.ajax({
            url: "@Url.Action("SetVoucherHeader", "Acc")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                if (response.result.data != null) {
                    docno = response.result.data;
                    if (docno != '') {
                        SavePayment();
                    }
                }
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
            case 'cashacc':
                SetGridBookAccount(path, '#tbBookCash', '#frmSearchBookCash', ReadBookCash);
                break;
            case 'chqacc':
                SetGridBookAccount(path, '#tbBookChq', '#frmSearchBookChq', ReadBookChq);
                break;
        }
    }
    function ReadBookCash(dt) {
        $('#txtBookCash').val(dt.BookCode);
        $('#txtBookCash').focus();
    }
    function ReadBookChq(dt) {
        $('#txtBookChqCash').val(dt.BookCode);
        $('#txtBookChqCash').focus();
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
