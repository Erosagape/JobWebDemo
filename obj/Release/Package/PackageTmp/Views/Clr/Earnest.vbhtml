@Code
    ViewBag.Title = "เคลียร์เงินมัดจำ"
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
            <div class="col-sm-6">
                Expense Code:<br />
                <input type="text" id="txtSICode" style="width:100px" />
                <button id="btnBrowseEmp3" onclick="SearchData('servicecode')">...</button>
                <input type="text" id="txtSDescription" style="width:300px" disabled />
            </div>
        </div>
        <button class="btn btn-warning" id="btnRefresh" onclick="SetGridClr(true)">Show</button>
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
    <div id="dvDetail" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <div class="row">
                        <div class="col-sm-4">
                            Clearing No : <br /><input type="text" id="txtClrNo" class="form-control" disabled />
                        </div>
                        <div class="col-sm-3">
                            Earnest No : <br /><input type="text" id="txtSlipNo" class="form-control" disabled />
                        </div>
                        <div class="col-sm-4">
                            Job No: <br /><input type="text" id="txtExpJobNo" class="form-control" disabled />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-2">
                            Item<br /><input type="text" id="txtItemNo" class="form-control" disabled />
                        </div>
                        <div class="col-sm-10">
                            Vender:<br />
                            <input type="text" id="txtVenderName" class="form-control" disabled />
                        </div>
                    </div>
                    <label><input type="radio" value="dvInfo" name="showInfo" onchange="ShowInfo()" checked />Earnest Info</label>
                    <label><input type="radio" value="dvExp" name="showInfo" onchange="ShowInfo()" />Expenses</label>

                </div>                    
                <div class="modal-body">
                    <input type="hidden" id="txtExpVender" />
                    <input type="hidden" id="txtExpGroup" />
                    <input type="hidden" id="txtIsCost" />
                    <input type="hidden" id="txtVatType" />
                    <input type="hidden" id="txtVatRate" />
                    <input type="hidden" id="txtWhtRate" />
                    <div id="dvInfo">
                        <div class="row">
                            <div class="col-sm-3">
                                Earnest : <br /><input type="text" id="txtClrNet" class="form-control" disabled />
                            </div>
                            <div class="col-sm-3">
                                Expense : <br /><input type="text" id="txtExpSum" class="form-control" disabled />
                            </div>
                            <div class="col-sm-3">
                                Return : <br /><input type="text" id="txtTotalNet" class="form-control" disabled />
                            </div>
                            <div class="col-sm-3">
                                Type<br />
                                <select id="cboRefType" class="form-control dropdown"></select>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-sm-4">
                                <a href="#" onclick="SearchData('book')">Book Account</a><br />
                                <input type="text" class="form-control" id="txtRefBook" />
                                <input type="hidden" id="txtRecvBank" />
                                <input type="hidden" id="txtRecvBranch" />
                            </div>
                            <div class="col-sm-4">
                                Ref:<br/> <input type="text" class="form-control" id="txtRefNo" />
                            </div>
                            <div class="col-sm-4">
                                Date:<br /><input type="date" class="form-control" id="txtRefDate" />
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-sm-2">
                                <a href="#" onclick="SearchData('bank')">Bank</a><br />
                                <input type="text" id="txtRefBank" class="form-control" />
                            </div>
                            <div class="col-sm-6">
                                <br />
                                <input type="text" id="txtRefBankName" class="form-control" disabled />
                            </div>
                            <div class="col-sm-4">
                                Branch<br />
                                <input type="text" id="txtRefBranch" class="form-control" />
                            </div>
                        </div>
                    </div>
                    <div id="dvExp">
                        <div class="row">
                            <div class="col-sm-3">
                                <a href="#" onclick="SearchData('serviceexp')">Exp.Code</a><br />
                                <input type="text" id="txtExpCode" class="form-control" />
                            </div>
                            <div class="col-sm-6">
                                <br />
                                <input type="text" id="txtExpName" class="form-control" disabled />
                            </div>
                            <div class="col-sm-3">
                                Exp.Slip<br />
                                <input type="text" id="txtExpSlip" class="form-control" />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-3">
                                Amount <br /><input type="number" class="form-control" id="txtExpAmount" />
                            </div>
                            <div class="col-sm-3">
                                Vat <br /><input type="number" class="form-control" id="txtExpVat" onchange="CalTotal()" />
                            </div>
                            <div class="col-sm-3">
                                Wht <br /><input type="number" class="form-control" id="txtExpWht" onchange="CalTotal()" />
                            </div>
                            <div class="col-sm-3">
                                Net <br /><input type="number" class="form-control" id="txtExpNet" onchange="CalTotal()" />
                            </div>
                        </div>
                        <button id="btnAddExpCode" class="btn btn-primary" onclick="AddExpense()">Add</button>
                        <table id="dvExpense" class="table table-bordered" style="width:100%"></table>
                    </div>
                </div>
                <div class="modal-footer">         
                    <div class="row">
                        <div class="col-sm-4">
                            Container No:<br />
                            <input type="text" id="txtCTN_NO" class="form-control" />
                        </div>
                        <div class="col-sm-3">
                            <a href="#" onclick="SearchData('servunit')">Unit</a><br/>
                            <input type="text" id="txtExpUnit" class="form-control" />
                        </div>
                        <div class="col-sm-5">
                            <br />
                            <button class="btn btn-success" id="btnSaveExpenses" onclick="SaveExpense()">Confirm</button>
                            <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
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
    var dtl = [];
    var expsum = 0;
    $(document).ready(function () {
        SetEvents();
    });
    function SetEvents() {
        //Combos
        let lists = 'JOB_TYPE=#cboJobType';
        lists += ',PAYMENT_TYPE=#cboRefType';

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
        $('#txtSICode').keydown(function (event) {
            if (event.which == 13) {
                $('#txtSDescription').val('');
                CallBackQueryService(path, $('#txtSICode').val(), ReadService);
            }
        });
        $('#txtExpCode').focusout(function () {
            $('#txtExpName').val('');
            CallBackQueryService(path, $('#txtExpCode').val(), ReadExpense);
        });
        $('#txtExpAmount').keydown(function (event) {
            if (event.which == 13) {
                CalVATWHT();
            }
        });
        //3 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv, '#frmSearchEmp', '#tbEmp', 'Clear By', response, 2);
            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response, 2);
            //Services
            CreateLOV(dv, '#frmSearchServ', '#tbServ', 'Service Code', response, 2);
            CreateLOV(dv, '#frmSearchExp', '#tbExp', 'Service Code', response, 2);
            //Unit
            CreateLOV(dv, '#frmSearchUnit', '#tbUnit', 'Service Unit', response, 2);
            //bank
            CreateLOV(dv, '#frmSearchBank', '#tbBank', 'Bank', response, 2);
            //book account
            CreateLOV(dv, '#frmSearchBook', '#tbBook', 'Book Account', response, 2);
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
        if ($('#txtClrDateF').val() !== "") {
            w = w + '&DateFrom=' + CDateEN($('#txtClrDateF').val());
        }
        if ($('#txtClrDateT').val() !== "") {
            w = w + '&DateTo=' + CDateEN($('#txtClrDateT').val());
        }
        if ($('#txtSICode').val() !== "") {
            w = w + '&sicode=' + $('#txtSICode').val();
        }
        w = w + '&Condition=ERN';
        $.get(path + 'clr/getclearingreport?branch=' + $('#txtBranchCode').val() + w, function (r) {
            if (r.data.length == 0) {
                $('#tbHeader').DataTable().clear().draw();
                if (isAlert==true) alert('data not found');
                return;
            }
            let h = r.data[0].Table;
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
                    { data: "InvNo", title: "InvNo" },
                    { data: "CustCode", title: "Customer" },
                    { data: "AdvNO", title: "Adv.No" },
                    { data: "AdvNet", title: "Total.Adv" },
                    { data: "ClrNet", title: "Total.Clr" },
                    { data: "SlipNO", title: "Slip No" }
                ],
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            });
            $('#tbHeader tbody').on('click', 'tr', function () {
                $('#tbHeader tbody > tr').removeClass('selected');
                $(this).addClass('selected');

                let data = $('#tbHeader').DataTable().row(this).data(); //read current row selected                
                ShowExpense(data);
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
            tot += o.ClrNet;
            doc += (doc != '' ? ',' : '') + o.ClrNo;
        }
        $('#txtSumApprove').val(CDbl(tot, 2));
        $('#txtListApprove').val(doc);
    }
    function ApproveData(docno) {
        if (arr.length < 0) {
            alert('no data to approve');
            return;
        }
        let dataApp = [];
        dataApp.push(docno);
        for (let i = 0; i < arr.length; i++) {
            dataApp.push(arr[i].BranchCode + '|' + arr[i].ClrNo + '|' + arr[i].ItemNo);
        }
        let jsonString = JSON.stringify({ data: dataApp });
        $.ajax({
            url: "@Url.Action("ReceiveEarnest", "Clr")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                SetGridClr(false);
                response ? alert("Clearing Completed!") : alert("Cannot Approve");
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
            case 'servicecode':
                SetGridSICodeByGroup(path,'#tbServ','ERN' ,'#frmSearchServ', ReadService);
                break;
            case 'serviceexp':
                SetGridSICode(path,'#tbExp','','#frmSearchExp', ReadExpense);
                break;
            case 'servunit':
                SetGridServUnit(path, '#tbUnit', '#frmSearchUnit', ReadUnit);
                break;
            case 'book':
                SetGridBookAccount(path, '#tbBook', '#frmSearchBook', ReadBook);
                break;
            case 'bank':
                SetGridBank(path, '#tbBank', '#frmSearchBank', ReadBank);
                break;
        }
    }
    function ReadReqBy(dt) {
        $('#txtClrBy').val(dt.UserID);
        $('#txtClrByName').val(dt.TName);
        $('#txtClrBy').focus();
    }
    function ReadBank(dt) {
        $('#txtRefBank').val(dt.Code);
        $('#txtRefBankName').val(dt.BName);
    }
    function ReadUnit(dt) {
        $('#txtExpUnit').val(dt.UnitType);
    }
    function ReadBook(dt) {
        $('#txtRefBook').val(dt.BookCode);
        $('#txtRecvBank').val(dt.BankCode);
        $('#txtRecvBranch').val(dt.BankBranch);
    }
    function ReadBranch(dt) {
        $('#txtBranchCode').val(dt.Code);
        $('#txtBranchName').val(dt.BrName);
        $('#txtBranchCode').focus();
    }

    function ReadService(dt) {
        $('#txtSICode').val(dt.SICode);
        $('#txtSDescription').val(dt.NameThai);
    }
    function ReadExpense(dt) {
        $('#txtExpCode').val(dt.SICode);
        $('#txtExpGroup').val(dt.GroupCode);
        $('#txtExpName').val(dt.NameThai);
        $('#txtVatType').val(dt.IsTaxCharge);
        $('#txtIsCost').val(dt.IsExpense);
        $('#txtVatRate').val('@ViewBag.PROFILE_VATRATE');
        $('#txtWhtRate').val(dt.Rate50Tavi);
        CalVATWHT();
    }
    function ShowExpense(dr) {
        RemoveData(dr);
        $('#txtClrNo').val(dr.ClrNo); 
        $('#txtItemNo').val(dr.ItemNo);
        $('#txtSlipNo').val(dr.SlipNO);
        $('#txtExpCode').val('');
        $('#txtCTN_NO').val('');
        $('#txtExpName').val('');
        $('#txtExpSlip').val('');
        $('#txtExpJobNo').val(dr.JobNo);
        $('#txtExpUnit').val('');
        $('#txtExpVender').val(dr.VenderCode);
        $('#txtVenderName').val(dr.VenderName);
        $('#txtExpGroup').val('');
        $('#txtExpAmount').val(0);
        $('#txtIsCost').val(0);
        $('#txtVatType').val(0);
        $('#txtVatRate').val(0);
        $('#txtWhtRate').val(0);
        $('#txtExpVat').val(0);
        $('#txtExpWht').val(0);
        $('#txtExpNet').val(0);
        $('#dvExpense').empty();
        $('#txtClrNet').val(dr.ClrNet);
        $('#txtExpSum').val(0);
        $('#txtTotalNet').val(dr.ClrNet);
        $('#cboRefType').val('CA');
        $('#txtRefBook').val('');
        $('#txtRefBank').val('');
        $('#txtRefBranch').val('');
        $('#txtRefBankName').val('');
        $('#txtRefDate').val('');
        $('#txtRefNo').val('');
        $('#txtRecvBank').val('');
        $('#txtRecvBranch').val('');

        expsum = 0;
        dtl = [];
        AddData(dr); //callback function from caller
        ShowInfo();

        $('#dvDetail').modal('show');
    }
    function AddExpense() {
        let dv = document.getElementById("dvExpense");
        let desc = $('#txtExpCode').val() + '-' + $('#txtExpName').val() + ($('#txtExpSlip').val() !== '' ? '#' + $('#txtExpSlip').val() : '');

        let html = '<tr>';
        html += '<td style="width:80%">'+desc+'</td>';
        html += '<td style="width:20%">' + CDbl($('#txtExpNet').val(), 2) + '</td>';
        html += '</tr>';

        dv.insertAdjacentHTML('beforeend',html);

        expsum += Number($('#txtExpNet').val());
        $('#txtExpSum').val(CDbl(expsum, 2));
        $('#txtTotalNet').val(CDbl(Number($('#txtClrNet').val()) - expsum, 2));

        dtl.push(GetDataDetail());
    }
    function SaveEarnest() {
        let obj = {
            BranchCode:$('#txtBranchCode').val(),
            ControlNo:'',
            VoucherDate:CDateTH(GetToday()),
            TRemark:'**Earnest Clearing** ' + $('#txtClrNo').val() + '/' + $('#txtItemNo').val() + ' #'+$('#txtSlipNo').val(),
            RecUser: user,
            RecDate: CDateTH(GetToday()),
            RecTime: GetTime(),
            PostedBy:'',
            PostedDate:null,
            PostedTime:null,
            CancelReson:'',
            CancelProve:'',
            CancelDate:null,
            CancelTime: null,
            CustCode: '',
            CustBranch: ''
        };
        let jsonText = JSON.stringify({ data: obj });
        //alert(jsonText);
        $.ajax({
            url: "@Url.Action("SetVoucherHeader", "Acc")",
            type: "POST",
            contentType: "application/json",
            data: jsonText,
            success: function (response) {
                if (response.result.data != null) {
                    SavePayment(response.result.data);
                    return;
                }
                alert(response.result.msg);
            },
            error: function (e) {
                alert(e);
            }
        });

    }
    function SaveExpense() {
        let ask = confirm("Do you need to Save?");
        if (ask == false) return;

        if (Number($('#txtExpSum').val()) > 0) {
            SaveClearHeader();
        }
        if (Number($('#txtTotalNet').val()) > 0) {
            SaveEarnest();
        }
    }
    function CalTotal() {
        let amt = CDbl($('#txtExpAmount').val(),4);
        let vat = CDbl($('#txtExpVat').val(),4);
        let wht = CDbl($('#txtExpWht').val(),4);
        let net = CDbl($('#txtExpNet').val(),4);
        let type = $('#txtVatType').val();
        if (type == ''||type=='0') type = '1';
        if (type == '2') {
            $('#txtExpAmount').val(CDbl(CNum(net) - CNum(vat) + CNum(wht),4));
            $('#txtExpNet').val(CDbl(net,4));
        }
        if (type == '1') {
            $('#txtExpNet').val(CDbl(CNum(amt) + CNum(vat) - CNum(wht),4));
            $('#txtExpAmount').val(CDbl(amt,4));
        }
    }
    function CalVATWHT() {
        let type = $('#txtVatType').val();
        if (type == ''||type=='0') type = '1';
        let amt = CDbl($('#txtExpAmount').val(),4);
        if (type == '2') {
            amt = CDbl($('#txtExpNet').val(),4);
        }
        let vatrate = CDbl($('#txtVatRate').val(),4);
        let whtrate = CDbl($('#txtWhtRate').val(),4);
        let vat = 0;
        let wht = 0;
        if (type == "2") {
            let base = amt * 100 / (100 + (vatrate - whtrate));
            vat = base * vatrate * 0.01;
            wht = base * whtrate * 0.01;
        }
        if (type == "1") {
            vat = amt * vatrate * 0.01;
            wht = amt * whtrate * 0.01;
        }
        $('#txtExpVat').val(CDbl(vat,4));
        $('#txtExpWht').val(CDbl(wht,4));
        CalTotal();
    }
    function GetDataHeader() {
        let dt = {
            BranchCode: $('#txtBranchCode').val(),
            ClrNo: '',
            ClrDate: CDateTH(GetToday()),
            ClearanceDate: null,
            EmpCode: user,
            AdvRefNo: null,
            AdvTotal: 0,
            JobType: $('#cboJobType').val(),
            JNo: null,
            InvNo: null,
            ClearType: 2,
            ClearFrom: 0,
            DocStatus: 2,
            TotalExpense: 0,
            TRemark: '**Earnest clearing** ' + $('#txtSlipNo').val(),
            ApproveBy: user,
            ApproveDate: CDateTH(GetToday()),
            ApproveTime: GetTime(),
            ReceiveBy: '',
            ReceiveDate: null,
            ReceiveTime: null,
            ReceiveRef: '',
            CancelReson: '',
            CancelProve: '',
            CancelDate: null,
            CancelTime: null,
            CoPersonCode: '',
            CTN_NO: $('#txtCTN_NO').val(),
            ClearTotal: 0,
            ClearVat: 0,
            ClearWht: 0,
            ClearNet: 0,
            ClearBill: 0,
            ClearCost: 0
        };
        return dt;
    }
    function GetDataDetail() {
        let dt = {
            BranchCode: $('#txtBranchCode').val(),
            ClrNo: '',
            ItemNo: 0,
            LinkItem: 0,
            SICode: $('#txtExpCode').val(),
            STCode:  $('#txtExpGroup').val(),
            SDescription: $('#txtExpName').val(),
            VenderCode: $('#txtExpVender').val(),
            Qty: 1,
            UnitCode: $('#txtExpUnit').val(),
            CurrencyCode: '@ViewBag.PROFILE_CURRENCY',
            CurRate: 1,
            UnitPrice: $('#txtIsCost').val()=="1" ? 0 : $('#txtExpAmount').val(),
            FPrice: $('#txtIsCost').val()=="1" ? 0 : $('#txtExpAmount').val(),
            BPrice: $('#txtIsCost').val()=="1"  ? 0 : $('#txtExpAmount').val(),
            QUnitPrice: 0,
            QFPrice: 0,
            QBPrice: 0,
            UnitCost: $('#txtExpAmount').val(),
            FCost: $('#txtExpAmount').val(),
            BCost: $('#txtExpAmount').val(),
            ChargeVAT: $('#txtExpVat').val(),
            Tax50Tavi: $('#txtExpWht').val(),
            AdvNO: $('#txtClrNo').val(),
            AdvItemNo: $('#txtItemNo').val(),
            AdvAmount: 0,
            UsedAmount: $('#txtExpAmount').val(),
            IsQuoItem: 0,
            SlipNO: $('#txtExpSlip').val(),
            Remark: '**' + $('#txtSlipNo').val(),
            IsLtdAdv50Tavi: 0,
            Pay50TaviTo: '',
            NO50Tavi: '',
            Date50Tavi: null,
            VenderBillingNo: '',
            AirQtyStep: '',
            StepSub: '',
            LinkBillNo : '',
            JobNo : $('#txtExpJobNo').val(),
            VATType : $('#txtVatType').val(),
            VATRate: $('#txtVatRate').val(),
            Tax50TaviRate : $('#txtWhtRate').val(),
            IsDuplicate: 0,
            QNo: '',
            FNet: $('#txtExpNet').val(),
            BNet: $('#txtExpNet').val()
        };
        return dt;
    }
    function SavePayment(docno) {
        let obj = {
            BranchCode: $('#txtBranchCode').val(),
            ControlNo: docno,
            ItemNo: 0,
            PRVoucher:'',
            PRType:'R',
            ChqNo:$('#txtRefNo').val(),
            BookCode:$('#txtRefBook').val(),
            BankCode:$('#txtRefBank').val(),
            BankBranch:$('#txtRefBranch').val(),
            ChqDate:CDateTH($('#txtRefDate').val()),
            CashAmount: ($('#cboRefType').val() == "CA" ? CNum($('#txtTotalNet').val()) : 0),
            ChqAmount: ($('#cboRefType').val() == "CH" || $('#cboRefType').val() == "CU" ? CNum($('#txtTotalNet').val()) : 0),
            CreditAmount: ($('#cboRefType').val() == "CR" ? CNum($('#txtTotalNet').val()) : 0),
            SumAmount: CNum($('#txtTotalNet').val()),
            CurrencyCode: '@ViewBag.PROFILE_CURRENCY',
            ExchangeRate: 1,
            TotalAmount: CNum($('#txtTotalNet').val()),
            VatExc: 0,
            VatInc: 0,
            WhtExc: 0,
            WhtInc: 0,
            TotalNet: CNum($('#txtTotalNet').val()),
            IsLocal:0,
            ChqStatus:'C',
            TRemark:'**Auto Clearing Earnest** #' + $('#txtSlipNo').val(),
            PayChqTo:'',
            DocNo:$('#txtClrNo').val(),
            SICode:$('#txtSICode').val(),
            RecvBank:$('#txtRecvBank').val(),
            RecvBranch: $('#txtRecvBranch').val(),
            acType: $('#cboRefType').val(),
            ForJNo: $('#txtExpJobNo').val()
        };

            let jsonText = JSON.stringify({ data:[ obj ]});
            //alert(jsonText);
            $.ajax({
                url: "@Url.Action("SetVoucherSub", "Acc")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.data !== null) {
                        SaveDocument(response.result.data[0].ControlNo);
                        return;
                    }
                    alert(response.result.msg);
                },
                error: function (e) {
                    alert(e);
                }
            });
    }
    function SaveDocument(docno) {
        let obj = {
            BranchCode:$('#txtBranchCode').val(),
            ControlNo:docno,
            ItemNo:0,
            DocType:'CLR',
            DocNo:$('#txtClrNo').val()+ '#' + $('#txtItemNo').val(),
            DocDate:CDateTH(GetToday()),
            CmpType:'V',
            CmpCode:$('#txtExpVender').val(),
            CmpBranch:'',
            PaidAmount:CNum($('#txtTotalNet').val()),
            TotalAmount: CNum($('#txtTotalNet').val()),
            acType: $('#txtDocacType').val()
        };
        let jsonText = JSON.stringify({ data:[ obj ]});
        //alert(jsonText);
        $.ajax({
            url: "@Url.Action("SetVoucherDoc", "Acc")",
            type: "POST",
            contentType: "application/json",
            data: jsonText,
            success: function (response) {
                if (response.result.data !== null) {
                    ApproveData(response.result.data);
                    return;
                }
                alert(response.result.msg);
            },
            error: function (e) {
                alert(e);
            }
        });
    }
    function SaveClearHeader() {
        let obj = GetDataHeader();
        let jsonString = JSON.stringify({ data: obj });
        //alert(jsonString);
        $.ajax({
            url: "@Url.Action("SetClrHeader", "Clr")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                if (response.result.data !== null) {
                    SaveClearDetail(response.result.data);                    
                }
            },
            error: function (e) {
                alert(e);
            }
        });
        return;
    }
    function SaveClearDetail(docno) {
        for (let i = 0; i < dtl.length; i++) {
            dtl[i].ClrNo = docno;
        }
        let jsonString = JSON.stringify({ data: dtl });
        //alert(jsonString);
        $.ajax({
            url: "@Url.Action("SaveClearDetail", "Clr")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                if (response.result.data !== null) {
                    alert(response.result.msg);                    
                }
            },
            error: function (e) {
                alert(e);
            }
        });
    }
    function ShowInfo() {
        let chk = $('input:radio[name=showInfo]:checked').val();
        switch (chk) {
            case 'dvInfo':
                $('#dvInfo').show();
                $('#dvExp').hide();
                break;
            case 'dvExp':
                $('#dvInfo').hide();
                $('#dvExp').show();
                break;
        }
    }
</script>