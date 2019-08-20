@Code
    ViewBag.Title = "รับชำระจากใบแจ้งหนี้"
End Code
<div class="panel-body">
    <div class="container">
        <input type="hidden" id="txtControlNo" />
        <ul class="nav nav-tabs">
            <li class="active"><a data-toggle="tab" href="#tab1">Select Payment</a></li>
            <li><a data-toggle="tab" href="#tab2">Document Info</a></li>
            <li><a data-toggle="tab" href="#tab3">Receiving Details</a></li>
        </ul>
        <div class="tab-content">
            <div id="tab1" class="tab-pane fade in active">
                <div class="row">
                    <div class="col-sm-3 table-bordered" id="dvCash">
                        <label><input type="radio" name="optACType" id="chkCash" value="CA"><b>Cash/Transfer :</b></label>
                        <input type="text" id="txtAdvCash" class="form-control" value="" />
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
                        <label><input type="radio" name="optACType" id="chkChqCash" value="CU"><b>Customer Cheque :</b></label><input type="text" id="txtAdvChqCash" class="form-control" value="" />
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
                        <label><input type="radio" name="optACType" id="chkChq" value="CH"><b>Company Cheque :</b></label><input type="text" id="txtAdvChq" class="form-control" value="" />
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
                        <label><input type="radio" name="optACType" id="optCred" value="CR"><b>Credit :</b></label><input type="text" id="txtAdvCred" class="form-control" value="" />
                        <br />
                        Ref No:<input type="text" id="txtRefNoCred" class="form-control" value="" />
                        <br />
                        Ref Date:<input type="date" id="txtCredTranDate" class="form-control" />
                        Pay To:<input type="text" id="txtCredPayTo" class="form-control" />
                        <br />
                    </div>
                </div>
            </div>
            <div id="tab2" class="tab-pane fade">
                <div class="row">
                    <div class="col-sm-6">
                        Branch
                        <br />
                        <div style="display:flex;flex-direction:row">
                            <input type="text" class="form-control" id="txtBranchCode" style="width:15%" disabled />
                            <input type="button" class="btn btn-default" value="..." onclick="SearchData('branch');" />
                            <input type="text" class="form-control" id="txtBranchName" style="width:65%" disabled />
                        </div>
                    </div>
                    <div class="col-sm-6">
                        <input type="checkbox" id="chkUseDue" /> Select by Payment Due Date
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-6">
                        Customer :
                        <br />
                        <div style="display:flex;flex-direction:row">
                            <input type="text" class="form-control" id="txtCustCode" style="width:120px" />
                            <input type="text" class="form-control" id="txtCustBranch" style="width:50px" />
                            <button id="btnBrowseCust" class="btn btn-default" onclick="SearchData('customer')">...</button>
                            <input type="text" class="form-control" id="txtCustName" style="width:100%" disabled />
                        </div>                        
                    </div>
                    <div class="col-sm-2">
                        Date From:<br />
                        <input type="date" class="form-control" id="txtDocDateF" />
                    </div>
                    <div class="col-sm-2">
                        Date To:<br />
                        <input type="date" class="form-control" id="txtDocDateT" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-12">
                        Tax-Invoice:<input type="text" id="txtTaxInvNo" />
                        <a href="#" class="btn btn-primary" id="btnSearch" onclick="SetGridAdv(true)">
                            <i class="fa fa-lg fa-filter"></i>&nbsp;<b>Search</b>
                        </a>
                        <br />
                        <table id="tbHeader" class="table table-responsive">
                            <thead>
                                <tr>
                                    <th>Inv.No</th>
                                    <th class="desktop">Inv.date</th>
                                    <th class="desktop">Bill.No</th>
                                    <th class="desktop">Rec.No</th>
                                    <th class="all">Expenses</th>
                                    <th class="desktop">Advance</th>
                                    <th class="desktop">Charge</th>
                                    <th class="desktop">Amt</th>
                                    <th class="desktop">VAT</th>
                                    <th class="desktop">W-Tax</th>
                                    <th class="all">Net</th>
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
            <div id="tab3" class="tab-pane fade">
                <div class="row">
                    <div class="col-sm-12">
                        <table id="tbDetail" class="table table-responsive" style="width:100%">
                            <thead>
                                <tr>
                                    <th class="desktop">Type</th>
                                    <th class="all">Doc.No</th>
                                    <th class="desktop">Doc.Type</th>
                                    <th class="desktop">Doc.Date</th>
                                    <th class="desktop">Pay.Type</th>
                                    <th class="desktop">For</th>
                                    <th class="desktop">Branch</th>
                                    <th class="desktop">Doc.Total</th>
                                    <th class="all">Paid.Total</th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-2">
                        Receive Date : <input type="date" id="txtPaymentDate" class="form-control" value="" />
                    </div>
                    <div class="col-sm-2">
                        Receive Total : <input type="text" id="txtSumApprove" class="form-control" value="" />
                    </div>
                    <div class="col-sm-2">
                        W/T Total : <input type="text" id="txtSumWHTax" class="form-control" value="" />
                    </div>
                    <div class="col-sm-6">
                        Remark : <input type="text" id="txtTRemark" class="form-control" value="" />
                    </div>
                </div>
                <a href="#" class="btn btn-success" id="btnSave" onclick="ApproveData()">
                    <i class="fa fa-lg fa-save"></i>&nbsp;<b>Save Payment</b>
                </a>
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
    let list = [];
    let docno = '';
    //$(document).ready(function () {
        $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
        $('#txtBranchName').val('@ViewBag.PROFILE_DEFAULT_BRANCH_NAME');

        SetEvents();
    //});
    function SetEvents() {

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
        $('#chkCash').prop('checked', true);
        $('#chkChq').prop('checked', false);
        $('#chkChqCash').prop('checked', false);
        $('#chkCred').prop('checked', false);
    }
    function SetGridAdv(isAlert) {
        arr = [];
        ClearData();
        ShowSummary();
        docno = '';

        let w = '';
        if ($('#txtTaxInvNo').val() !== "") {
            w = w + '&recvno=' + $('#txtTaxInvNo').val();
        }
        if ($('#txtCustCode').val() !== "") {
            w = w + '&cust=' + $('#txtCustCode').val();
        }
        if ($('#chkUseDue').prop('checked') == true) {
            if ($('#txtDocDateF').val() !== "") {
                w = w + '&DueDateFrom=' + CDateEN($('#txtDocDateF').val());
            }
            if ($('#txtDocDateT').val() !== "") {
                w = w + '&DueDateTo=' + CDateEN($('#txtDocDateT').val());
            }
        } else {
            if ($('#txtDocDateF').val() !== "") {
                w = w + '&DateFrom=' + CDateEN($('#txtDocDateF').val());
            }
            if ($('#txtDocDateT').val() !== "") {
                w = w + '&DateTo=' + CDateEN($('#txtDocDateT').val());
            }
        }
        $.get(path + 'acc/getinvforreceive?show=OPEN&branch=' + $('#txtBranchCode').val() + w, function (r) {
            if (r.invdetail.data.length == 0) {
                $('#tbHeader').DataTable().clear().draw();
                if(isAlert==true) ShowMessage('data not found');
                return;
            }
            let h = r.invdetail.data;
            $('#tbHeader').DataTable().destroy();
            $('#tbHeader').empty();
            $('#tbHeader').DataTable({
                data: h,
                selected: true, //ให้สามารถเลือกแถวได้
                columns: [ //กำหนด property ของ header column
                    { data:"InvoiceNo", title: "Inv No" },
                    {
                        data: "InvoiceDate", title: "Payment date",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "ReceiptNo", title: "Receipt No" },
                    { data: "SICode", title: "Code" },
                    { data: "SDescription", title: "Expenses" },
                    { data: "AmtAdvance", title: "Advance" },
                    { data: "AmtCharge", title: "Charge" },
                    { data: "Amt", title: "Amt" },
                    { data: "AmtVAT", title: "Vat" },
                    { data: "Amt50Tavi", title: "WH-Tax" },
                    { data: "Net", title: "Net" }
                ],
                responsive:true,
                destroy:true
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
        let acType = $('input:radio[name=optACType]:checked').val();
        o.acType = acType;

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
        let wtax = 0;
        let doc = '';
        let sum_ca = 0;
        let sum_ch = 0;
        let sum_cu = 0;
        let sum_cr = 0;

        list = [];

        for (let i = 0; i < arr.length; i++) {

            let o = arr[i];
            wtax += Number(o.Amt50Tavi);
            tot += Number(o.Net);

            let obj = {
                BranchCode: $('#txtBranchCode').val(),
                ControlNo: null,
                ItemNo: i + 1,
                DocType: 'INV',
                CmpType: 'C',
                CmpCode: o.CustCode,
                CmpBranch: o.CustBranch,
                PaidAmount: CDbl(o.Net, 2),
                TotalAmount: CDbl((o.Net), 2),
                acType:o.acType
            };
            obj.DocNo = o.InvoiceNo + '#'+ o.InvoiceItemNo;
            obj.DocDate = CDateTH(o.InvoiceDate);
            if (o.acType == 'CA') sum_ca += Number(o.Net);
            if (o.acType == 'CH') sum_ch += Number(o.Net);
            if (o.acType == 'CU') sum_cu += Number(o.Net);
            if (o.acType == 'CR') sum_cr += Number(o.Net);

            list.push(obj);

        }
        //show selected details
        $('#tbDetail').DataTable({
            data: list,
            selected: true, //ให้สามารถเลือกแถวได้
            columns: [ //กำหนด property ของ header column
                { data: "acType", title: "RCV" },
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
            responsive:true,
            destroy:true
        });
        $('#txtAdvCash').val(CDbl(sum_ca, 2));
        $('#txtAdvChq').val(CDbl(sum_ch, 2));
        $('#txtAdvChqCash').val(CDbl(sum_cu, 2));
        $('#txtAdvCred').val(CDbl(sum_cr, 2));

        $('#txtSumApprove').val(CDbl(tot, 2));
        $('#txtSumWHTax').val(CDbl(wtax, 2));
        $('#txtListApprove').val(doc);

    }
    function GetSumPayment(type) {
        let filter_data = arr.filter(function (data) {
            return data.acType == type;
        });
        let filter_sum = {
            sumamount: 0,
            currencycode : '@ViewBag.PROFILE_CURRENCY',
            exchangerate : 1
        };
        for (let i = 0; i < filter_data.length; i++) {

            filter_sum.sumamount += Number(filter_data[i].Net);
        }
        return filter_sum;
    }
    function SavePayment() {
        let oData = [];
        let i = 0;
        let sum_cash = GetSumPayment('CA');
        if (sum_cash.sumamount !== 0) {
            i = i + 1;
            oData.push({
                BranchCode: $('#txtBranchCode').val(),
                ControlNo: docno,
                ItemNo: i,
                PRVoucher: '',
                PRType: sum_cash.sumamount > 0 ? 'R' : 'P',
                ChqNo: '',
                BookCode: $('#txtBookCash').val(),
                BankCode: $('#fldBankCodeCash').val(),
                BankBranch: $('#fldBankBranchCash').val(),
                ChqDate: '',
                CashAmount: Math.abs(sum_cash.sumamount),
                ChqAmount: 0,
                CreditAmount: 0,
                SumAmount: sum_cash.sumamount,
                CurrencyCode: sum_cash.currencycode,
                ExchangeRate: sum_cash.exchangerate,
                TotalAmount: Math.abs(sum_cash.sumamount),
                VatInc: 0,
                VatExc: 0,
                WhtInc: 0,
                WhtExc: 0,
                TotalNet: Math.abs(sum_cash.sumamount),
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
        let sum_chqcash = GetSumPayment('CU');
        if (sum_chqcash.sumamount !== 0) {
            i = i + 1;
            oData.push({
                BranchCode: $('#txtBranchCode').val(),
                ControlNo: docno,
                ItemNo: i,
                PRVoucher: '',
                PRType:sum_chqcash.sumamount > 0 ? 'R' : 'P',
                ChqNo: $('#txtRefNoChqCash').val(),
                BookCode: '',
                BankCode: '',
                BankBranch: '',
                ChqDate: CDateTH($('#txtChqCashTranDate').val()),
                CashAmount: 0,
                ChqAmount: Math.abs(sum_chqcash.sumamount),
                CreditAmount: 0,
                SumAmount:  Math.abs(sum_chqcash.sumamount),
                CurrencyCode: sum_chqcash.currencycode,
                ExchangeRate: sum_chqcash.exchangerate,
                TotalAmount:  Math.abs(sum_chqcash.sumamount),
                VatInc: 0,
                VatExc: 0,
                WhtInc: 0,
                WhtExc: 0,
                TotalNet: Math.abs(sum_chqcash.sumamount),
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
        let sum_chq = GetSumPayment('CH');
        if (sum_chq.sumamount !== 0) {
            i = i + 1;
            oData.push({
                BranchCode: $('#txtBranchCode').val(),
                ControlNo: docno,
                ItemNo: i,
                PRVoucher: '',
                PRType:sum_chq.sumamount> 0 ? 'R' : 'P',
                ChqNo: $('#txtRefNoChq').val(),
                BookCode: $('#txtBookChq').val(),
                BankCode: $('#fldBankCodeChqCash').val(),
                BankBranch: $('#fldBankBranchChqCash').val(),
                ChqDate: CDateTH($('#txtChqTranDate').val()),
                CashAmount: 0,
                ChqAmount: Math.abs(sum_chq.sumamount),
                CreditAmount: 0,
                SumAmount: Math.abs(sum_chq.sumamount),
                CurrencyCode: sum_chq.currencycode,
                ExchangeRate: sum_chq.exchangerate,
                TotalAmount: Math.abs(sum_chq.sumamount),
                VatInc: 0,
                VatExc: 0,
                WhtInc: 0,
                WhtExc: 0,
                TotalNet: Math.abs(sum_chq.sumamount),
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
        let sum_cr = GetSumPayment('CR');
        if (sum_cr.sumamount!== 0) {
            i = i + 1;
            oData.push({
                BranchCode: $('#txtBranchCode').val(),
                ControlNo: docno,
                ItemNo: i,
                PRVoucher: '',
                PRType: sum_cr.sumamount > 0 ? 'R' : 'P',
                ChqNo: '',
                BookCode: '',
                BankCode: '',
                BankBranch: '',
                ChqDate: CDateTH($('#txtCredTranDate').val()),
                CashAmount: 0,
                ChqAmount: 0,
                CreditAmount: Math.abs(sum_cr.sumamount),
                SumAmount:Math.abs(sum_cr.sumamount),
                CurrencyCode: sum_cr.currencycode,
                ExchangeRate: sum_cr.exchangerate,
                TotalAmount: Math.abs(sum_cr.sumamount),
                VatInc: 0,
                VatExc: 0,
                WhtInc: 0,
                WhtExc: 0,
                TotalNet: Math.abs(sum_cr.sumamount),
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
                        let vcno = '';
                        for (let o of response.result.data[0]) {
                            vcno += (vcno == '' ? o.PRVoucher : ',' + o.PRVoucher);
                        }
                        SaveDetail(vcno);
                    }
                },
                error: function (e) {
                    ShowMessage(e);
                }
            });
        }
    }
    function UpdateReceive(vcno) {
        let i = 0;
        let rows = [];
        for (let o of arr) {
            i += 1;
            rows.push({
                BranchCode: o.BranchCode,
                ReceiptNo: o.ReceiptNo,
                ItemNo: o.ItemNo,
                CreditAmount: o.CreditAmount,
                CashAmount: o.CashAmount,
                TransferAmount: o.TransferAmount,
                ChequeAmount: o.ChequeAmount,
                ControlNo: docno,
                VoucherNo: vcno,
                ControlItemNo: i,
                InvoiceNo: o.InvoiceNo,
                InvoiceItemNo: o.InvoiceItemNo,
                SICode: o.SICode,
                SDescription: o.SDescription,
                VATRate: o.VATRate,
                Rate50Tavi: o.Rate50Tavi,
                Amt: o.Amt,
                AmtVAT: o.AmtVAT,
                Amt50Tavi: o.Amt50Tavi,
                Net: o.Net,
                DCurrencyCode: o.DCurrencyCode,
                DExchangeRate: o.DExchangeRate,
                FAmt: o.FAmt,
                FAmtVAT: o.FAmtVAT,
                FAmt50Tavi: o.FAmt50Tavi,
                FNet:o.FNet
            });
        }
        let jsonText = JSON.stringify({ data: rows });
            //ShowMessage(jsonText);
        $.ajax({
            url: "@Url.Action("SaveRcpDetail", "Acc")",
            type: "POST",
            contentType: "application/json",
            data: jsonText,
            success: function (response) {
                if (response.result.data !== null) {
                    ShowMessage(response.result.msg+'\n->'+response.result.data);
                    return;
                }
                ShowMessage(response.result.msg);
            },
            error: function (e) {
                ShowMessage(e);
            }
        });
    }
    function SaveDetail(vcno) {
        if (list.length > 0) {
            for (let i = 0; i < list.length; i++) {
                let o = list[i];
                o.ControlNo = docno;
            }
            let jsonString = JSON.stringify({ data: list });
            UpdateReceive(vcno);
            $.ajax({
                url: "@Url.Action("SetVoucherDoc", "Acc")",
                type: "POST",
                contentType: "application/json",
                data: jsonString,
                success: function (response) {
                    if (response.result.data != null) {
                        SetGridAdv(false);
                        ShowMessage(response.result.msg);
                        PrintVoucher($('#txtBranchCode').val(), $('#txtControlNo').val());
                    }
                },
                error: function (e) {
                    ShowMessage(e);
                }
            });
        }
    }
    function ApproveData() {
        if (arr.length < 0) {
            ShowMessage('no data to approve');
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
                ShowMessage(e);
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
