﻿@Code
    ViewBag.Title = "รับเคลียร์เงินตามใบปิดค่าใช้จ่าย"
End Code
<div class="panel-body">
    <div class="container">
        <input type="hidden" id="txtControlNo" />
        <ul class="nav nav-tabs">
            <li class="active"><a data-toggle="tab" href="#tab1">Select document</a></li>
            <li><a data-toggle="tab" href="#tab2">Clearing Info</a></li>
            <li><a data-toggle="tab" href="#tab3">Clearing Details</a></li>
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
                        Job Type: <br />
                        <select id="cboJobType" class="form-control dropdown"></select>
                    </div>
                    <div class="col-sm-6">
                        Clear By :<br />
                        <input type="text" id="txtReqBy" style="width:100px" />
                        <button id="btnBrowseEmp2" onclick="SearchData('reqby')">...</button>
                        <input type="text" id="txtReqName" style="width:300px" disabled />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-6">
                        Advance For :<br />
                        <input type="text" id="txtCustCode" style="width:120px" />
                        <input type="text" id="txtCustBranch" style="width:50px" />
                        <button id="btnBrowseCust" onclick="SearchData('customer')">...</button>
                        <input type="text" id="txtCustName" style="width:300px" disabled />
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
                        <br />
                        <button class="btn btn-warning" id="btnRefresh" onclick="SetGridAdv(true)">Show</button>
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
                                    <th>customer</th>
                                    <th>Adv.No</th>
                                    <th>Adv.Total</th>
                                    <th>Used</th>
                                    <th>Balance</th>
                                    <th>W-Tax</th>
                                    <th>Clr.By</th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-12">
                        Receive Document : <br /><input type="text" id="txtListApprove" class="form-control" value="" disabled />
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
                        <br />
                        <input type="hidden" id="fldBankCodeCash" />
                        <input type="hidden" id="fldBankBranchCash" />
                    </div>
                    <div class="col-sm-3 table-bordered" id="dvChqCash">
                        <b>Company Chq :</b><input type="text" id="txtAdvChqCash" class="form-control" value="" />
                        <br />
                        <table>
                            <tr>
                                <td>
                                    Book A/C:<br /><input type="text" id="txtBookChqCash" class="form-control" value="" />
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
                        <br />
                        <input type="hidden" id="fldBankCodeChqCash" />
                        <input type="hidden" id="fldBankBranchChqCash" />
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
                        <br />
                    </div>
                    <div class="col-sm-3 table-bordered" id="dvCred">
                        <b>Credit : </b><input type="text" id="txtAdvCred" class="form-control" value="" />
                        <br />
                        Ref No:<input type="text" id="txtRefNoCred" class="form-control" value="" />
                        <br />
                        Ref Date:<input type="date" id="txtCredTranDate" class="form-control" />
                        Pay To:<input type="text" id="txtCredPayTo" class="form-control" />
                        <br />
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
        let lists = 'JOB_TYPE=#cboJobType';
        loadCombos(path, lists);

        let cbos = ['#cboBankCash', '#cboBankChqCash', '#cboBankChq'];
        loadBank(cbos, path);
        //default values
        $('#txtCurrencyCode').val('THB');
        ShowCurrency(path, $('#txtCurrencyCode').val(), '#txtCurrencyName');

        //Events
        $('#txtBranchCode').focusout(function (event) {
            if (true) {
                $('#txtBranchName').val('');
                ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            }
        });
        $('#txtBookCash').focusout(function (event) {
            if (true) {
                $('#fldBankCodeCash').val('');
                $('#fldBankBranchCash').val('');
                CallBackQueryBookAccount(path, $('#txtBranchCode').val(), $('#txtBookCash').val(), ReadBookCash);
            }
        });
        $('#txtBookChqCash').focusout(function (event) {
            if (true) {
                $('#fldBankCodeChqCash').val('');
                $('#fldBankBranchChqCash').val('');
                CallBackQueryBookAccount(path, $('#txtBranchCode').val(), $('#txtBookChqCash').val(), ReadBookChq);
            }
        });
        $('#txtReqBy').focusout(function (event) {
            if (true) {
                $('#txtReqName').val('');
                ShowUser(path, $('#txtReqBy').val(), '#txtReqName');
            }
        });
        $('#txtCurrencyCode').focusout(function (event) {
            if (true) {
                $('#txtCurrencyName').val('');
                ShowCurrency(path, $('#txtCurrencyCode').val(), '#txtCurrencyName');
            }
        });
        $('#txtCustBranch').focusout(function (event) {
            if (true) {
                $('#txtCustName').val('');
                ShowCustomer(path, $('#txtCustCode').val(), $('#txtCustBranch').val(), '#txtCustName');
            }
        });

        //3 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("dvLOVs");

            CreateLOV(dv, '#frmSearchCust', '#tbCust', 'Customers', response, 3);
            CreateLOV(dv, '#frmSearchReq', '#tbReq', 'Request By', response, 2);
            CreateLOV(dv, '#frmSearchCurr', '#tbCurr', 'Currency', response, 2);
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
    function SetGridAdv(isAlert) {
        arr = [];
        ClearData();
        ShowSummary();
        docno = '';

        let w = '';
        if ($('#txtReqBy').val() !== "") {
            w = w + '&clrby=' + $('#txtReqBy').val();
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
        if ($('#txtAdvDateF').val() !== "") {
            w = w + '&DateFrom=' + CDateEN($('#txtAdvDateF').val());
        }
        if ($('#txtAdvDateT').val() !== "") {
            w = w + '&DateTo=' + CDateEN($('#txtAdvDateT').val());
        }
        w = w + '&Status=2';
        $.get(path + 'adv/getclearinggrid?branchcode=' + $('#txtBranchCode').val() + w, function (r) {
            if (r.adv.data.length == 0) {
                $('#tbHeader').DataTable().clear().draw();
                if(isAlert==true) alert('data not found');
                return;
            }
            let h = r.adv.data[0].Table;
            $('#tbHeader').DataTable().destroy();
            $('#tbHeader').empty();
            $('#tbHeader').DataTable({
                data: h,
                selected: true, //ให้สามารถเลือกแถวได้
                columns: [ //กำหนด property ของ header column
                    { data: "ClrNo", title: "Clearing No" },
                    {
                        data: "ClrDate", title: "Request date ",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "JobNo", title: "Job Number" },
                    { data: "CustInvNo", title: "InvNo" },
                    { data: "CustCode", title: "Customer" },
                    { data: "AdvNO", title: "Advance No" },
                    { data: "AdvTotal", title: "Adv Total" },
                    { data: "ClrAmt", title: "Clear" },
                    { data: "ClrVat", title: "VAT" },
                    { data: "Clr50Tavi", title: "WT" },
                    { data: "EmpCode", title: "Request By" }
                ]
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
    function SetStatusInput(d, bl, ctl) {
        if (bl == false) {
            $(d).css("background-color", "darkgrey");
            $(d + ' :input').attr('disabled', true);
        } else {
            $(d).css("background-color", "lightgreen");
            $(d + ' :input').removeAttr('disabled');
            if (ctl !== null) {
                $(ctl).attr('disabled', true);
            }
        }
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
        let cash = 0;
        let chq = 0;
        let chqcust = 0;
        let cred = 0;
        let wtax = 0;
        let doc = '';
        list = [];

        for (let i = 0; i < arr.length; i++) {

            let o = arr[i];
            wtax += (o.Clr50Tavi > 0 ? o.Clr50Tavi : 0);
            tot += (o.ClrNet > 0 ? o.ClrNet+o.Clr50Tavi : 0);
            cash += (o.AdvCash > 0 ? o.AdvCash : 0);
            chq += (o.AdvChqCash > 0 ? o.AdvChqCash : 0);
            chqcust += (o.AdvChq > 0 ? o.AdvChq : 0);
            cred += (o.AdvCred > 0 ? o.AdvCred : 0);
            doc += (doc != '' ? ',' : '') + o.AdvNo;
            if (o.AdvCash > 0) {
                let obj = {
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
                    TotalAmount: CDbl((o.TotalAdvance+o.TotalVAT), 2),
                    acType:'CA'
                };
                list.push(obj);
            }
            if (o.AdvChqCash > 0) {
                let obj = {
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
                let obj = {
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
                let obj = {
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

        SetStatusInput('#dvCash', (cash > 0 ? true : false),'#txtAdvCash');
        SetStatusInput('#dvChqCash', (chq > 0 ? true : false), '#txtAdvChqCash');
        SetStatusInput('#dvChq', (chqcust > 0 ? true : false), '#txtAdvChq');
        SetStatusInput('#dvCred', (cred > 0 ? true : false), '#txtAdvCred');

        $('#txtSumApprove').val(CDbl(tot, 2));
        $('#txtSumWHTax').val(CDbl(wtax, 2));
        $('#txtAdvCash').val(CDbl(cash, 2));
        $('#txtAdvChqCash').val(CDbl(chq, 2));
        $('#txtAdvChq').val(CDbl(chqcust, 2));
        $('#txtAdvCred').val(CDbl(cred, 2));
        $('#txtListApprove').val(doc);
    }
    function GetSumPayment(type) {
        let filter_data = arr.filter(function (data) {
            return data[type] > 0
        });
        let filter_sum = {
            sumamount: 0,
            currencycode: '',
            exchangerate: 1,
            totalamount: 0,
            vatinc: 0,
            vatexc: 0,
            whtinc: 0,
            whtexc: 0,
            totalnet: 0
        };
        for (let i = 0; i < filter_data.length; i++) {
            filter_sum.currencycode = filter_data[i].SubCurrency;
            filter_sum.exchangerate = filter_data[i].ExchangeRate;
            filter_sum.sumamount += Number(filter_data[i][type]);
            filter_sum.totalamount += Number(filter_data[i].BaseAmount);
            filter_sum.totalnet += Number(filter_data[i].TotalNet);
            filter_sum.vatinc += Number(filter_data[i].VATInc);
            filter_sum.vatexc += Number(filter_data[i].VATExc);
            filter_sum.whtinc += Number(filter_data[i].WHTInc);
            filter_sum.whtexc += Number(filter_data[i].WHTExc);
        }
        return filter_sum;
    }
    function SavePayment() {
        let oData = [];
        let i = 0;
        if ($('#txtAdvCash').val() > 0) {
            i = i + 1;
            let sum_cash = GetSumPayment('AdvCash');
            oData.push({
                BranchCode: $('#txtBranchCode').val(),
                ControlNo: docno,
                ItemNo: i,
                PRVoucher: '',
                PRType: 'P',
                ChqNo: '',
                BookCode: $('#txtBookCash').val(),
                BankCode: $('#fldBankCodeCash').val(),
                BankBranch: $('#fldBankBranchCash').val(),
                ChqDate: '',
                CashAmount: CNum($('#txtAdvCash').val()),
                ChqAmount: 0,
                CreditAmount: 0,
                SumAmount: sum_cash.sumamount,
                CurrencyCode: sum_cash.currencycode,
                ExchangeRate: sum_cash.exchangerate,
                TotalAmount: sum_cash.totalamount,
                VatInc: sum_cash.vatinc,
                VatExc: sum_cash.vatexc,
                WhtInc: sum_cash.whtinc,
                WhtExc: sum_cash.whtexc,
                TotalNet: sum_cash.totalnet,
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
            let sum_chqcash = GetSumPayment('AdvChqCash');
            oData.push({
                BranchCode: $('#txtBranchCode').val(),
                ControlNo: docno,
                ItemNo: i,
                PRVoucher: '',
                PRType: 'P',
                ChqNo: $('#txtRefNoChqCash').val(),
                BookCode: '',
                BankCode: '',
                BankBranch: '',
                ChqDate: CDateTH($('#txtChqCashTranDate').val()),
                CashAmount: 0,
                ChqAmount: CNum($('#txtAdvChqCash').val()),
                CreditAmount: 0,
                SumAmount: sum_chqcash.sumamount,
                CurrencyCode: sum_chqcash.currencycode,
                ExchangeRate: sum_chqcash.exchangerate,
                TotalAmount: sum_chqcash.totalamount,
                VatInc: sum_chqcash.vatinc,
                VatExc: sum_chqcash.vatexc,
                WhtInc: sum_chqcash.whtinc,
                WhtExc: sum_chqcash.whtexc,
                TotalNet: sum_chqcash.totalnet,
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
            i = i + 1;
            let sum_chq = GetSumPayment('AdvChq');
            oData.push({
                BranchCode: $('#txtBranchCode').val(),
                ControlNo: docno,
                ItemNo: i,
                PRVoucher: '',
                PRType: 'P',
                ChqNo: $('#txtRefNoChq').val(),
                BookCode: $('#txtBookChq').val(),
                BankCode: $('#fldBankCodeChqCash').val(),
                BankBranch: $('#fldBankBranchChqCash').val(),
                ChqDate: CDateTH($('#txtChqTranDate').val()),
                CashAmount: 0,
                ChqAmount: CNum($('#txtAdvChq').val()),
                CreditAmount: 0,
                SumAmount: sum_chq.sumamount,
                CurrencyCode: sum_chq.currencycode,
                ExchangeRate: sum_chq.exchangerate,
                TotalAmount: sum_chq.totalamount,
                VatInc: sum_chq.vatinc,
                VatExc: sum_chq.vatexc,
                WhtInc: sum_chq.whtinc,
                WhtExc: sum_chq.whtexc,
                TotalNet: sum_chq.totalnet,
                IsLocal: $('#chkIsLocal').prop('checked') == true ? 'P' : '',
                ChqStatus: '',
                TRemark: '',
                PayChqTo: $('#txtChqPayTo').val(),
                DocNo: '',
                SICode: '',
                RecvBank: $('#cboBankChq').val(),
                RecvBranch: $('#txtBankBranchChq').val(),
                acType: 'CH'
            });
        }
        if ($('#txtAdvCred').val() > 0) {
            i = i + 1;
            let sum_cr = GetSumPayment('AdvCred');
            oData.push({
                BranchCode: $('#txtBranchCode').val(),
                ControlNo: docno,
                ItemNo: i,
                PRVoucher: '',
                PRType: 'P',
                ChqNo: '',
                BookCode: '',
                BankCode: '',
                BankBranch: '',
                ChqDate: CDateTH($('#txtCredTranDate').val()),
                CashAmount: 0,
                ChqAmount: 0,
                CreditAmount: CNum($('#txtAdvCred').val()),
                SumAmount: sum_cr.sumamount,
                CurrencyCode: sum_cr.currencycode,
                ExchangeRate: sum_cr.exchangerate,
                TotalAmount: sum_cr.totalamount,
                VatInc: sum_cr.vatinc,
                VatExc: sum_cr.vatexc,
                WhtInc: sum_cr.whtinc,
                WhtExc: sum_cr.whtexc,
                TotalNet: sum_cr.totalnet,
                IsLocal: 0,
                ChqStatus: '',
                TRemark: '',
                PayChqTo: $('#txtCredPayTo').val(),
                DocNo: $('#txtRefNoCred').val(),
                SICode: '',
                RecvBank: '',
                RecvBranch: '',
                acType: 'CR',
                ForJNo: ''
            });
        }
        if (oData.length > 0) {
            let jsonString = JSON.stringify({ data: oData });
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
            for (let i = 0; i < list.length; i++) {
                let o = list[i];
                o.ControlNo = docno;
            }
            let jsonString = JSON.stringify({ data: list });
            $.ajax({
                url: "@Url.Action("SetVoucherDoc", "Acc")",
                type: "POST",
                contentType: "application/json",
                data: jsonString,
                success: function (response) {
                    if (response.result.data != null) {
                        ReceiveClearing(response.result.data);
                    }
                },
                error: function (e) {
                    alert(e);
                }
            });
        }
    }
    function ReceiveClearing(cno) {
        let msg = "Clear Document " + cno + " Completed!";

        let dataApp = [];
        dataApp.push(user + '|' + cno);
        for (let i = 0; i < list.length; i++) {
            dataApp.push(list[i].BranchCode + '|' + list[i].DocNo);
        }

        let jsonString = JSON.stringify({ data: dataApp });
        $.ajax({
            url: "@Url.Action("ReceiveClearing", "Clr")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                response ? alert(msg) : alert("Cannot Clear Document");
                if (response) {
                    PrintVoucher($('#txtBranchCode').val(), $('#txtControlNo').val());
                }
                SetGridAdv(false);
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
        let oHeader = {
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
            CancelTime: '',
            CustCode: $('#txtCustCode').val(),
            CustBranch: $('#txtCustBranch').val()
        };
        docno = '';
        let jsonString = JSON.stringify({ data: oHeader });
        $.ajax({
            url: "@Url.Action("SetVoucherHeader", "Acc")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                if (response.result.data != null) {
                    docno = response.result.data;
                    if (docno != '') {
                        $('#txtControlNo').val(docno);
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
            case 'currency':
                SetGridCurrency(path, '#tbCurr', '#frmSearchCurr', ReadCurrency);
                break;
        }
    }
    function ReadCurrency(dt) {
        $('#txtCurrencyCode').val(dt.Code);
        $('#txtCurrencyName').val(dt.TName);
    }
    function ReadBookCash(dt) {
        $('#txtBookCash').val(dt.BookCode);
        $('#fldBankCodeCash').val(dt.BankCode);
        $('#fldBankBranchCash').val(dt.BankBranch);
    }
    function ReadBookChq(dt) {
        $('#txtBookChqCash').val(dt.BookCode);
        $('#fldBankCodeChqCash').val(dt.BankCode);
        $('#fldBankBranchChqCash').val(dt.BankBranch);
    }
    function ReadReqBy(dt) {
        $('#txtReqBy').val(dt.UserID);
        $('#txtReqName').val(dt.TName);
    }
    function ReadBranch(dt) {
        $('#txtBranchCode').val(dt.Code);
        $('#txtBranchName').val(dt.BrName);
    }
    function ReadCustomer(dt) {
        $('#txtCustCode').val(dt.CustCode);
        $('#txtCustBranch').val(dt.Branch);
        ShowCustomer(path, dt.CustCode, dt.Branch, '#txtCustName');
    }
    function PrintVoucher(br, cno) {
        window.open(path + 'Acc/FormVoucher?branch=' + $('#txtBranchCode').val() + '&controlno=' + $('#txtControlNo').val());
    }
</script>
