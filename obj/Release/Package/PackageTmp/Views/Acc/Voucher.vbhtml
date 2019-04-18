@Code
    ViewBag.Title = "P/R Voucher"
End Code
<div class="panel-body">
    <div class="container">
        <div id="dvForm">
            <div class="row">
                <div class="col-xs-5">
                    Branch<br />
                    <input type="text" id="txtBranchCode" style="width:50px" tabindex="2" />
                    <button id="btnBrowseBranch" onclick="SearchData('branch')">...</button>
                    <input type="text" id="txtBranchName" style="width:200px" disabled />
                </div>
                <div class="col-xs-3">
                    Voucher Date<br /> <input type="date" id="txtVoucherDate" class="form-control" tabIndex="3">
                </div>
                <div class="col-xs-4">
                    <table border="1">
                        <tr>
                            <td>
                                <b><a onclick="SearchData('controlno')">Reference No:</a></b>
                                <br />
                                <input type="text" id="txtControlNo" style="font-style:bold;font-size:20px;text-align:center" tabindex="1" />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-12">
                    Note<br /><input type="text" id="txtTRemark" class="form-control" tabIndex="4">
                </div>
            </div>
            <ul class="nav nav-tabs">
                <li class="active"><a data-toggle="tab" href="#tabHeader">Payment Info</a></li>
                <li><a data-toggle="tab" href="#tabDetail">Reference Documents</a></li>
            </ul>
            <div class="tab-content">
                <div id="tabHeader" class="tab-pane fade in active">
                    <div>
                        <button id="btnAddPay" class="btn btn-warning" onclick="AddPayment()">Add</button>
                    </div>

                    <table id="tbHeader" class="table table-bordered">
                        <thead>
                            <tr>
                                <th>Chq</th>
                                <th>Cash</th>
                                <th>Credit</th>
                                <th>VCNo</th>
                                <th>BookAcc</th>
                                <th>RefChqNo</th>
                                <th>RefDate</th>
                                <th>Bank</th>
                                <th>Branch</th>
                                <th>PayChqTo</th>
                            </tr>
                        </thead>
                    </table>
                </div>
                <div id="tabDetail" class="tab-pane fade">
                    <div>
                        <button id="btnAddDoc" class="btn btn-warning" onclick="AddDocument()">Add</button>
                    </div>
                    <table id="tbDetail" class="table table-bordered">
                        <thead>
                            <tr>
                                <th>DocNo</th>
                                <th>DocType</th>
                                <th>DocDate</th>
                                <th>CmpType</th>
                                <th>CmpCode</th>
                                <th>CmpBranch</th>
                                <th>TotalDoc</th>
                                <th>TotalPaid</th>
                            </tr>
                        </thead>
                    </table>

                </div>
            </div>
            <div class="row">
                <div class="col-xs-4" style="border-style:solid;border-width:1px">
                    <label>Record By</label>
                    <br />
                    <input type="text" id="txtRecUser" style="width:250px" disabled />
                    <br />
                    Date:
                    <input type="date" id="txtRecDate" disabled />
                    Time:
                    <input type="text" id="txtRecTime" style="width:80px" disabled />
                </div>
                <div class="col-xs-4" style="border-style:solid;border-width:1px">
                    <input type="checkbox" id="chkPosted" />
                    <label for="chkPosted">Posted By</label><br />
                    <input type="text" id="txtPostedBy" style="width:250px" disabled />
                    <br />
                    Date:
                    <input type="date" id="txtPostedDate" disabled />
                    Time:
                    <input type="text" id="txtPostedTime" style="width:80px" disabled />
                </div>
                <div class="col-xs-4" style="border-style:solid;border-width:1px;color:red">
                    <input type="checkbox" id="chkCancel" />
                    <label for="chkCancel">Cancel By</label>
                    <input type="text" id="txtCancelProve" style="width:250px" disabled />
                    <br />
                    Date:
                    <input type="date" id="txtCancelDate" disabled />
                    Time:
                    <input type="text" id="txtCancelTime" style="width:80px" disabled />
                    <br />
                    Cancel Reason<input type="text" id="txtCancelReson" style="width:250px" />
                </div>
            </div>
        </div>
        <div id="frmHeader" class="modal modal-lg fade">
            <div class="modal-dialog-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal"></button>
                        <h4 class="modal-title"><label id="lblHeader">Voucher List</label></h4>
                    </div>
                    <div class="modal-body">
                        <table id="tbControl" class="table table-responsive">
                            <thead>
                                <tr>
                                    <th>ControlNo</th>
                                    <th>VoucherDate</th>
                                    <th>CustCode</th>
                                    <th>Remark</th>
                                    <th>VoucherNo</th>
                                    <th>ChqNo</th>
                                    <th>ChqDate</th>
                                    <th>ChqAmount</th>
                                    <th>CashAmount</th>
                                    <th>CreditAmount</th>
                                    <th>Currency</th>
                                    <th>DocNo</th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                    <div class="modal-footer">
                        <button id="btnHide" class="btn btn-danger" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>
        <div id="frmPayment" class="modal fade">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal"></button>
                        <h4 class="modal-title"><label id="lblHeader">Voucher Info</label></h4>
                        <label><input type="radio" id="optShowPay" value="dvPayInfo" name="showInfo" onchange="ShowInfo()" checked /> Payment Info</label>
                        <label><input type="radio" id="optShowTax" value="dvPayTax" name="showInfo" onchange="ShowInfo()" /> VAT/Tax info</label>
                    </div>
                    <div class="modal-body">
                        <div id="dvPayInfo">
                            <div class="row">
                                <div class="col-md-2">
                                    No<br /><input type="text" id="txtItemNo" class="form-control" disabled>
                                </div>
                                <div class="col-md-3">
                                    P/R<br /><input type="hidden" id="txtPRType" class="form-control">
                                    <select id="cboPRType" class="form-control dropdown" onchange="SetPRType()"></select>
                                </div>
                                <div class="col-md-4">
                                    Voucher No:<br /><input type="text" id="txtPRVoucher" class="form-control">
                                </div>
                                <div class="col-md-3">
                                    Type:<br /><input type="hidden" id="txtacType" class="form-control">
                                    <select id="cboacType" class="form-control dropdown" onchange="SetACType('cboacType','txtacType')"></select>
                                </div>
                            </div>
                            <div id="dvBookInfo">
                                <div class="row">
                                    <div class="col-md-3">
                                        <a onclick="SearchData('bookacc')">Book A/C</a><br /><input type="text" id="txtBookCode" class="form-control">
                                    </div>
                                    <div class="col-md-9">
                                        Book Name<br /><input type="text" id="txtBookName" class="form-control" disabled>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-2">
                                        Bank<br /><input type="text" id="txtBankCode" class="form-control" disabled>
                                    </div>
                                    <div class="col-md-6">
                                        Bank Name<br /><input type="text" id="txtBankName" class="form-control" disabled>
                                    </div>
                                    <div class="col-md-4">
                                        Branch<br /><input type="text" id="txtBankBranch" class="form-control" disabled>
                                    </div>
                                </div>
                            </div>

                            <div id="dvChqInfo">
                                <div class="row">
                                    <div class="col-md-3">
                                        Cheque No<br /><input type="text" id="txtChqNo" class="form-control">
                                    </div>
                                    <div class="col-md-4">
                                        C.Date<br /><input type="date" id="txtChqDate" class="form-control">
                                    </div>
                                    <div class="col-md-3">
                                        CLR<br /><input type="hidden" id="txtChqStatus" class="form-control">
                                        <select id="cboChqStatus" class="form-control dropdown" onchange="SetChqStatus()"></select>
                                    </div>
                                    <div class="col-md-2">
                                        Local Cheque
                                        <br />
                                        <input type="hidden" id="txtIsLocal" class="form-control" value="0">
                                        <input type="checkbox" id="chkIsLocal" onclick="SetIsLocal()" />
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-2">
                                        <a onclick="SearchData('bank')">Ref.Bank</a><br /><input type="text" id="txtRecvBank" class="form-control">
                                    </div>
                                    <div class="col-md-6">
                                        Ref.Bank Name<br /><input type="text" id="txtRecvBankName" class="form-control" disabled>
                                    </div>
                                    <div class="col-md-4">
                                        Ref.Branch<br /><input type="text" id="txtRecvBranch" class="form-control">
                                    </div>

                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4">
                                    <label id="lblCashAmount">CashAmount<br /><input type="number" id="txtCashAmount" class="form-control" value="0.00"></label>
                                </div>
                                <div class="col-md-4">
                                    <label id="lblChqAmount">ChqAmount<br /><input type="number" id="txtChqAmount" class="form-control" value="0.00"></label>
                                </div>
                                <div class="col-md-4">
                                    <label id="lblCreditAmount">CreditAmount<br /><input type="number" id="txtCreditAmount" class="form-control" value="0.00"></label>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-3">
                                    Ref.No<br /><input type="text" id="txtDocNo" class="form-control">
                                </div>
                                <div class="col-md-9">
                                    Paid To<br /><input type="text" id="txtPayChqTo" class="form-control">
                                </div>
                            </div>
                        </div>
                        <div id="dvPayTax">
                            <div class="row">
                                <div class="col-md-3">
                                    <label><a href="#" onclick="SearchData('currency');">Currency</a></label><br />
                                    <input type="text" id="txtCurrencyCode" class="form-control" />
                                </div>
                                <div class="col-md-9">
                                    Currency Name<br />
                                    <input type="text" id="txtCurrencyName" class="form-control" disabled />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4">
                                    Amount Base<br />
                                    <input type="text" id="txtSumAmt" class="form-control" onchange="CalculateTotal()" />
                                </div>
                                <div class="col-md-3">
                                    Exchange Rate<br />
                                    <input type="text" id="txtExchangeRate" class="form-control" onchange="CalculateTotal()"/>
                                </div>
                                <div class="col-md-4">
                                    Total Amount<br />
                                    <input type="text" id="txtTotalAmt" class="form-control" onchange="CalculateTotal()"/>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-3">
                                    Vat(Include)<br />
                                    <input type="text" id="txtVatInc" class="form-control" onchange="CalculateTotal()"/>
                                </div>
                                <div class="col-md-3">
                                    Vat(Exclude)<br />
                                    <input type="text" id="txtVatExc" class="form-control" onchange="CalculateTotal()"/>
                                </div>
                                <div class="col-md-3">
                                    Wht(Include)<br />
                                    <input type="text" id="txtWhtInc" class="form-control" onchange="CalculateTotal()"/>
                                </div>
                                <div class="col-md-3">
                                    Wht(Exclude)<br />
                                    <input type="text" id="txtWhtExc" class="form-control" onchange="CalculateTotal()"/>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-3">
                                    Total Net<br />
                                    <input type="text" id="txtTotalNet" class="form-control" disabled/>
                                </div>
                                <div class="col-md-3">
                                    <a onclick="SearchData('servicecode')">Exp.Code</a><br /><input type="text" id="txtSICode" class="form-control">
                                </div>
                                <div class="col-md-6">
                                    <br />
                                    <input type="text" id="txtSDescription" class="form-control" disabled />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    Note<br /><input type="text" id="txtDTRemark" class="form-control">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button id="btnUpdatePay" class="btn btn-primary" onclick="SavePayment()">Save</button>
                        <button id="btnDelPay" class="btn btn-warning" onclick="DeletePayment()">Delete</button>
                        <button id="btnHide" class="btn btn-danger" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>
        <div id="frmDocument" class="modal fade">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal"></button>
                        <h4 class="modal-title"><label id="lblHeader">Document Info</label></h4>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-md-2">
                                No<br /><input type="text" id="txtDocItemNo" class="form-control">
                            </div>
                            <div class="col-md-4">
                                Type<br /><input type="hidden" id="txtCmpType" class="form-control">
                                <select id="cboCmpType" class="form-control dropdown" onchange="SetCmpType()">
                                    <option value="">N/A</option>
                                    <option value="C">Customers</option>
                                    <option value="V">Venders</option>
                                </select>
                            </div>
                            <div class="col-md-4">
                                <a onclick="SearchData(GetCmpType())">Company</a><br /><input type="text" id="txtCmpCode" class="form-control">
                            </div>
                            <div class="col-md-2">
                                Branch<br /><input type="text" id="txtCmpBranch" class="form-control">
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-7">
                                Name<br /><input type="text" id="txtCmpName" class="form-control" disabled>
                            </div>
                            <div class="col-md-5">
                                Doc.Type<br /><input type="hidden" id="txtDocType" class="form-control">
                                <select id="cboDocType" class="form-control dropdown" onchange="SetDocType()"></select>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                Doc.No<br /><input type="text" id="txtDDocNo" class="form-control">
                            </div>
                            <div class="col-md-4">
                                Doc.Date<br /><input type="date" id="txtDocDate" class="form-control">
                            </div>
                            <div class="col-md-4">
                                Pay.Type<br /><input type="hidden" id="txtDocacType" class="form-control">
                                <select id="cboDocacType" class="form-control dropdown" onchange="SetACType('cboDocacType','txtDocacType')"></select>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-5">
                                Total<br /><input type="number" id="txtTotalAmount" class="form-control" value="0.00">
                            </div>
                            <div class="col-md-5">
                                Amount<br /><input type="number" id="txtPaidAmount" class="form-control" value="0.00">
                            </div>

                        </div>
                    </div>
                    <div class="modal-footer">
                        <button id="btnUpdateDoc" class="btn btn-primary" onclick="SaveDocument()">Save</button>
                        <button id="btnDelDoc" class="btn btn-warning" onclick="DeleteDocument()">Delete</button>
                        <button id="btnHide" class="btn btn-danger" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>
        <div id="dvCommand">
            <button id="btnAdd" class="btn btn-default" onclick="ClearForm()">Clear Data</button>
            <button id="btnSave" class="btn btn-success" onclick="SaveData()">Save Data</button>
            <button id="btnPrint" class="btn btn-info" onclick="PrintData()">Print Data</button>
        </div>
    </div>
</div>
<div id="dvLOVs"></div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    var user = '@ViewBag.User';
    var userRights = '@ViewBag.UserRights';
    $(document).ready(function () {
        SetEvents();
        SetLOVs();
        SetEnterToTab();
    });
    function SetIsLocal() {
        $('#txtIsLocal').val($('#chkIsLocal').prop('checked') ? '1' : '0');
    }
    function SetPRType() {
        $('#txtPRType').val($('#cboPRType').val());
    }
    function SetACType(n, d) {
        let typ = $('#' + n).val();
        $('#' + d).val(typ);

        if (n == 'cbodocacType') {
            return;
        }
        let cashfld = 'CashAmount';
        let chqfld = 'ChqAmount';
        let credfld = 'CreditAmount';
        let sumval = Number($('#txtCashAmount').val()) + Number($('#txtChqAmount').val()) + Number($('#txtCreditAmount').val());

        $('#txt' + cashfld).attr('disabled', 'disabled');
        $('#txt' + credfld).attr('disabled', 'disabled');
        $('#txt' + chqfld).attr('disabled', 'disabled');
        $('#dvChqInfo').show();
        $('#dvBookInfo').hide();
        switch (typ) {
            case 'CR':
                $('#txt' + chqfld).val(0);
                $('#txt' + cashfld).val(0);
                $('#txt' + credfld).val(sumval);
                $('#txt' + credfld).removeAttr('disabled');
                $('#dvChqInfo').hide();
                break;
            case 'CA':
                $('#txt' + chqfld).val(0);
                $('#txt' + credfld).val(0);
                $('#txt' + cashfld).val(sumval);
                $('#txt' + cashfld).removeAttr('disabled');
                $('#dvChqInfo').hide();
                $('#dvBookInfo').show();
                break;
            case 'CU':
                $('#txt' + cashfld).val(0);
                $('#txt' + credfld).val(0);
                $('#txt' + chqfld).val(sumval);
                $('#txt' + chqfld).removeAttr('disabled');
                break;
            case 'CH':
                $('#txt' + cashfld).val(0);
                $('#txt' + credfld).val(0);
                $('#txt' + chqfld).val(sumval);
                $('#txt' + chqfld).removeAttr('disabled');
                $('#dvBookInfo').show();
                break;
            default:
                $('#txt' + cashfld).val(0);
                $('#txt' + credfld).val(0);
                $('#txt' + chqfld).val(0);
                $('#dvChqInfo').hide();
                break;
        }
    }
    function SetCmpType() {
        $('#txtCmpType').val($('#cboCmpType').val());
        if ($('#cboCmpType').val() == '') {
            $('#txtCmpCode').attr('disabled', 'disabled');
            $('#txtCmpBranch').attr('disabled', 'disabled');
        } else {
            $('#txtCmpCode').removeAttr('disabled');
            $('#txtCmpBranch').removeAttr('disabled');
        }
    }
    function SetChqStatus() {
        $('#txtChqStatus').val($('#cboChqStatus').val());
    }
    function SetDocType() {
        $('#txtDocType').val($('#cboDocType').val());
    }
    function SetEvents() {
        $('#txtControlNo').keydown(function (event) {
            if (event.which == 13) {
                var code = $('#txtControlNo').val();
                var branch = $('#txtBranchCode').val();
                $('#txtBranchCode').val(branch);
                $('#txtControlNo').val(code);
                CallBackQueryVoucher(path, branch,code, ReadData);
            }
        });
        $('#txtSICode').keydown(function (event) {
            if (event.which == 13) {
                $('#txtSDescription').val('');
                CallBackQueryService(path, $('#txtSICode').val(), ReadService);
            }
        });
        $('#txtCmpBranch').keydown(function (event) {
            if (event.which == 13) {
                $('#txtCmpName').val('');
                if (GetCmpType() == "cust") {
                    ShowCustomer(path, $('#txtCmpCode').val(), $('#txtCmpBranch').val(), '#txtCmpName');
                    return;
                }
                if (GetCmpType() == "vender") {
                    ShowVender(path, $('#txtCmpCode').val(), '#txtCmpName');
                    return;
                }
            }
        });
        $('#txtBookCode').keydown(function (event) {
            if (event.which == 13) {
                $('#txtBookName').val('');
                $('#txtBankCode').val('');
                $('#txtBankName').val('');
                $('#txtBankBranch').val('');
                $('#chkIsLocal').prop('checked', false);

                CallBackQueryBookAccount(path, $('#txtBranchCode').val(), $('#txtBookCode').val(), ReadBookAccount);
            }
        });
        $('#txtRecvBank').keydown(function (event) {
            if (event.which == 13) {
                $('#txtRecvBankName').val('');
                CallBackQueryBank(path, $('#txtRecvBank').val(), ReadBank);
            }
        });
        $('#txtCurrencyCode').keydown(function (event) {
            if (event.which == 13) {
                $('#txtCurrencyName').val('');
                CallBackQueryCurrency(path, $('#txtCurrencyCode').val(), ReadCurrency);
            }
        });
        $('#txtBranchCode').keydown(function (event) {
            if (event.which == 13) {
                $('#txtBranchName').val('');
                ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            }
        });
    }
    function SetEnterToTab() {
        //Set enter to tab
        $("input[tabindex], select[tabindex], textarea[tabindex]").each(function () {
            $(this).on("keypress", function (e) {
                if (e.keyCode === 13) {
                    var idx = (this.tabIndex + 1);
                    var nextElement = $('[tabindex="' + idx + '"]');
                    while (nextElement.length) {
                        if (nextElement.prop('disabled') == false) {
                            $('[tabindex="' + idx + '"]').focus();
                            e.preventDefault();
                            return;
                        } else {
                            idx = idx + 1;
                            nextElement = $('[tabindex="' + idx + '"]');
                        }
                    }
                    $('[tabindex="1"]').focus();
                }
            });
        });
    }
    function SetLOVs() {
        var lists = 'PAYMENT_TYPE=#cboDocacType';
        lists += ',PAYMENT_TYPE=#cboacType';
        lists += ',DOCUMENT_TYPE=#cboDocType';
        lists += ',DOCUMENT_ACC=#cboPRType';
        lists += ',CHQ_STATUS=#cboChqStatus';

        loadCombos(path,lists)

        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            var dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv, '#frmSearchCust', '#tbCust', 'Customer List', response, 3);
            //Venders
            CreateLOV(dv, '#frmSearchVend', '#tbVend', 'Venders', response, 3);
            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response, 2);
            //Bank
            CreateLOV(dv, '#frmSearchBank', '#tbBank', 'Bank', response, 2);
            //Service Code
            CreateLOV(dv, '#frmSearchExp', '#tbExp', 'Expenses Code', response, 2);
            //BookAccount
            CreateLOV(dv, '#frmSearchBookAcc', '#tbBookAcc', 'Book Accounts', response, 2);
            //Currency
            CreateLOV(dv, '#frmSearchCurr', '#tbCurr', 'Currency', response, 2);
        });
    }
    function SearchData(type) {
        switch (type) {
            case 'bookacc':
                SetGridBookAccount(path, '#tbBookAcc', '#frmSearchBookAcc', ReadBookAccount);
                break;
            case 'bank':
                SetGridBank(path, '#tbBank', '#frmSearchBank', ReadBank);
                break;
            case 'branch':
                SetGridBranch(path, '#tbBranch', '#frmSearchBranch', ReadBranch);
                break;
            case 'controlno':
                SetGridControl();
                break;
            case 'cust':
                SetGridCompany(path, '#tbCust', '#frmSearchCust', ReadCustomer);
                break;
            case 'vender':
                SetGridVender(path, '#tbVend', '#frmSearchVend', ReadVender);
                break;
            case 'servicecode':
                SetGridSICode(path, '#tbExp','','#frmSearchExp', ReadService);
                break;
            case 'currency':
                SetGridCurrency(path, '#tbCurr', '#frmSearchCurr', ReadCurrency);
                break;
        }
    }
    function ClearForm() {
        $('#txtBranchCode').val('');
        $('#txtBranchName').val('');
        $('#txtControlNo').val('');
        $('#txtVoucherDate').val('');
        $('#txtTRemark').val('');
        $('#txtRecUser').val('');
        $('#txtRecDate').val('');
        $('#txtRecTime').val('');
        $('#chkPosted').prop('checked',false);
        $('#txtPostedBy').val('');
        $('#txtPostedDate').val('');
        $('#txtPostedTime').val('');
        $('#chkCancel').prop('checked', false);
        $('#txtCancelReson').val('');
        $('#txtCancelProve').val('');
        $('#txtCancelDate').val('');
        $('#txtCancelTime').val('');

        $('#tbHeader').empty();
        $('#tbDetail').empty();

        ClearPayment();
        ClearDocument();
    }
    function AddPayment() {
        if (userRights.indexOf('I') < 0) {
            alert('you are not authorize to add payment');
            return;
        }
        ClearPayment();
        $('#frmPayment').modal('show');
    }
    function AddDocument() {
        if (userRights.indexOf('I') < 0) {
            alert('you are not authorize to add document');
            return;
        }
        ClearDocument();
        $('#frmDocument').modal('show');
    }
    function DeletePayment() {
        if (userRights.indexOf('D') < 0) {
            alert('you are not authorize to delete');
            return;
        }
        $.get(path + 'acc/delvouchersub?branch=' + $('#txtBranchCode').val() + '&code=' + $('#txtControlNo').val() + '&item=' + $('#txtItemNo').val(), function (r) {
            SetGridPayment(r.voucher.data);            
            alert(r.voucher.result);
            $('#frmPayment').modal('hide');
        });
    }
    function DeleteDocument() {
        if (userRights.indexOf('D') < 0) {
            alert('you are not authorize to delete');
            return;
        }
        $.get(path + 'acc/delvoucherdoc?branch=' + $('#txtBranchCode').val() + '&code=' + $('#txtControlNo').val() + '&item=' + $('#txtDocItemNo').val(), function (r) {
            SetGridDocument(r.voucher.data);
            alert(r.voucher.result);
            $('#frmDocument').modal('hide');
        });
    }
    function ReadData(dt) {
        ClearForm();
        if (dt.header.length > 0) {
            ReadHeader(dt.header[0]);
        }
        if (dt.payment.length > 0) {
            SetGridPayment(dt.payment);
        }
        if (dt.document.length > 0) {
            SetGridDocument(dt.document);
        }
    }
    function SaveData() {
        var obj = {
            BranchCode:$('#txtBranchCode').val(),
            ControlNo:$('#txtControlNo').val(),
            VoucherDate:CDateTH($('#txtVoucherDate').val()),
            TRemark:$('#txtTRemark').val(),
            RecUser:$('#txtRecUser').val(),
            RecDate:CDateTH($('#txtRecDate').val()),
            RecTime:CDateTH($('#txtRecTime').val()),
            PostedBy:$('#txtPostedBy').val(),
            PostedDate:CDateTH($('#txtPostedDate').val()),
            PostedTime:CDateTH($('#txtPostedTime').val()),
            CancelReson:$('#txtCancelReson').val(),
            CancelProve:$('#txtCancelProve').val(),
            CancelDate:CDateTH($('#txtCancelDate').val()),
            CancelTime: CDateTH($('#txtCancelTime').val())
        };
        if (obj.ControlNo != "") {
            var ask = confirm("Do you need to Save " + obj.ControlNo + "?");
            if (ask == false) return;
            var jsonText = JSON.stringify({ data: obj });
            //alert(jsonText);
            $.ajax({
                url: "@Url.Action("SetVoucherHeader", "Acc")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.data != null) {
                        $('#txtControlNo').val(response.result.data);
                        $('#txtControlNo').focus();
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
    function SetGridControl() {
        var code = $('#txtBranchCode').val();
        $.get(path + 'acc/getvouchergrid?branch=' + code, function (r) {
            if (r.voucher.data.length == 0) {
                alert('data not found on this branch');
                return;
            }
            var h = r.voucher.data[0].Table;
            $('#tbControl').DataTable({
                data: h,
                selected: true, //ให้สามารถเลือกแถวได้
                columns: [ //กำหนด property ของ header column
                    { data: "ControlNo", title: "Control No" },
                    {
                        data: "VoucherDate", title: "Date",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "CmpCode", title: "Customer" },
                    { data: "TRemark", title: "Remark" },
                    { data: "PRVoucher", title: "Voucher" },
                    { data: "ChqNo", title: "Cheque No" },
                    {
                        data: "ChqDate", title: "Chq Date",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "ChqAmount", title: "Chq Total" },
                    { data: "CashAmount", title: "Cash Total" },
                    { data: "CreditAmount", title: "Credit Total" },
                    { data: "CurrencyCode", title: "Currency" },
                    { data: "DocNo", title: "Doc No" }
                ],
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            });
            $('#tbControl tbody').on('click', 'tr', function () {
                $('#tbControl tbody > tr').removeClass('selected');
                $(this).addClass('selected');
                var data = $('#tbControl').DataTable().row(this).data(); //read current row selected

                CallBackQueryVoucher(path, data.BranchCode, data.ControlNo, ReadData); //callback function from caller 

                $('#frmHeader').modal('hide');
            });
            $('#frmHeader').on('shown.bs.modal', function () {
                $('#tbControl_filter input').focus();
            });
            $('#frmHeader').modal('show');
        });
    }
    function SetGridPayment(list) {
        //show selected details
        $('#tbHeader').DataTable({
            data: list,
            selected: true, //ให้สามารถเลือกแถวได้
            columns: [ //กำหนด property ของ header column
                { data: "ChqAmount", title: "Cheque" },
                { data: "CashAmount", title: "Cash" },
                { data: "CreditAmount", title: "Credit" },
                { data: "CurrencyCode", title: "Currency" },
                { data: "PRVoucher", title: "Voucher" },
                { data: "ChqNo", title: "Chq.No" },
                {
                    data: "ChqDate", title: "Chq.Date",
                    render: function (data) {
                        return CDateEN(data);
                    }
                },
                { data: "BankCode", title: "Bank" },
                { data: "BankBranch", title: "Branch" },
                { data: "PayChqTo", title: "Pay From/To" }
            ],
            destroy: true
        });
        $('#tbHeader tbody').on('click', 'tr', function () {
            $('#tbHeader tbody > tr').removeClass('selected');
            $(this).addClass('selected');
            if (userRights.indexOf('E') > 0) {
                var data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                ReadPayment(data); //callback function from caller 
                $('#frmPayment').modal('show');
            }
            
        });
    }
    function ShowInfo() {
        let chk = $('input:radio[name=showInfo]:checked').val();
        switch (chk) {
            case 'dvPayInfo':
                $('#dvPayInfo').show();
                $('#dvPayTax').hide();
                break;
            case 'dvPayTax':
                $('#dvPayInfo').hide();
                $('#dvPayTax').show();
                break;
        }
    }
    function SetGridDocument(list) {
        //show selected details
        $('#tbDetail').DataTable({
            data: list,
            selected: true, //ให้สามารถเลือกแถวได้
            columns: [ //กำหนด property ของ header column
                { data: "DocNo", title: "Doc.No" },
                { data: "DocType", title: "Type " },
                { data: "DocDate", title: "Date" },
                { data: "CmpType", title: "For" },
                { data: "CmpCode", title: "Customer" },
                { data: "CmpBranch", title: "Branch" },
                { data: "TotalAmount", title: "Doc.Total" },
                { data: "PaidAmount", title: "Paid" }
            ],
            destroy: true
        });
        $('#tbDetail tbody').on('click', 'tr', function () {
            $('#tbDetail tbody > tr').removeClass('selected');
            $(this).addClass('selected');
            if (userRights.indexOf('E') > 0) {
                var data = $('#tbDetail').DataTable().row(this).data(); //read current row selected
                ReadDocument(data); //callback function from caller 
                $('#frmDocument').modal('show');
            }
        });
    }
    function ReadHeader(dr) {
        if (dr !== undefined) {
            $('#txtBranchCode').val(dr.BranchCode);
            ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            $('#txtControlNo').val(dr.ControlNo);
            $('#txtVoucherDate').val(CDateEN(dr.VoucherDate));
            $('#txtTRemark').val(dr.TRemark);
            $('#txtRecUser').val(dr.RecUser);
            $('#txtRecDate').val(CDateEN(dr.RecDate));
            $('#txtRecTime').val(CDateEN(dr.RecTime));
            $('#txtPostedBy').val(dr.PostedBy);
            $('#txtPostedDate').val(CDateEN(dr.PostedDate));
            $('#txtPostedTime').val(CDateEN(dr.PostedTime));
            $('#txtCancelReson').val(dr.CancelReson);
            $('#txtCancelProve').val(dr.CancelProve);
            $('#txtCancelDate').val(CDateEN(dr.CancelDate));
            $('#txtCancelTime').val(CDateEN(dr.CancelTime));
        }
    }
    function ReadPayment(dr) {
        ClearPayment();
        if (dr !== undefined) {
            $('#txtItemNo').val(dr.ItemNo);
            $('#txtPRVoucher').val(dr.PRVoucher);
            $('#txtPRType').val(dr.PRType);
            $('#cboPRType').val(dr.PRType);
            $('#txtChqNo').val(dr.ChqNo);
            $('#txtBankCode').val(dr.BankCode);
            $('#txtBookCode').val(dr.BookCode);
            $('#txtBankBranch').val(dr.BankBranch);
            $('#txtChqDate').val(CDateEN(dr.ChqDate));
            $('#txtCashAmount').val(dr.CashAmount);
            $('#txtChqAmount').val(dr.ChqAmount);
            $('#txtCreditAmount').val(dr.CreditAmount);
            $('#txtSumAmt').val(dr.SumAmount);
            $('#txtCurrencyCode').val(dr.CurrencyCode);
            ShowCurrency(path, dr.CurrencyCode, '#txtCurrencyName');
            $('#txtExchangeRate').val(dr.ExchangeRate);
            $('#txtTotalAmt').val(dr.TotalAmount);        
            $('#txtVatExc').val(dr.VatExc);
            $('#txtWhtExc').val(dr.WhtExc);
            $('#txtVatInc').val(dr.VatInc);
            $('#txtWhtInc').val(dr.WhtInc);
            $('#txtTotalNet').val(dr.TotalNet);
            $('#txtIsLocal').val(dr.IsLocal);
            $('#chkIsLocal').prop('checked', dr.IsLocal == 1 ? true : false);
            $('#txtChqStatus').val(dr.ChqStatus);
            $('#cboChqStatus').val(dr.ChqStatus);
            $('#txtDTRemark').val(dr.TRemark);
            $('#txtPayChqTo').val(dr.PayChqTo);
            $('#txtDocNo').val(dr.DocNo);
            $('#txtSICode').val(dr.SICode);            
            $('#txtRecvBank').val(dr.RecvBank);
            $('#txtRecvBranch').val(dr.RecvBranch);
            $('#txtacType').val(dr.acType);
            $('#cboacType').val(dr.acType);
            $('#cboacType').change();
            if (dr.BankCode !== null) {
                ShowBookAccount(path, dr.BookCode, '#txtBookName');
                ShowBank(path, dr.BankCode, '#txtBankName');
            } else {
                CallBackQueryBookAccount(path, dr.BranchCode, dr.BookCode, ReadBookAccount);
            }
            CallBackQueryService(path, dr.SICode, ReadService);
            ShowBank(path, dr.RecvBank, '#txtRecvBankName');
        }
    }
    function ReadDocument(dr) {
        if (dr !== undefined) {
            $('#txtDocType').val(dr.DocType);
            $('#cboDocType').val(dr.DocType);
            $('#txtDocItemNo').val(dr.ItemNo);
            $('#txtDDocNo').val(dr.DocNo);
            $('#txtDocDate').val(CDateEN(dr.DocDate));
            $('#txtCmpType').val(dr.CmpType);
            $('#cboCmpType').val(dr.CmpType);
            $('#txtCmpCode').val(dr.CmpCode);
            $('#txtCmpBranch').val(dr.CmpBranch);
            if (dr.CmpType == "C") {
                ShowCustomer(path, dr.CmpCode, dr.CmpBranch, '#txtCmpName');
            }
            if (dr.cmpType == "V") {
                ShowVender(path, dr.CmpCode, '#txtCmpName');
            }
            $('#txtPaidAmount').val(dr.PaidAmount);
            $('#txtTotalAmount').val(dr.TotalAmount);
            $('#txtDocacType').val(dr.acType);
            $('#cboDocacType').val(dr.acType);
        }
    }
    function ClearPayment() {
        $('#txtPRVoucher').val('');
        $('#txtItemNo').val('0');
        $('#txtPRType').val('');
        $('#cboPRType').val('');
        $('#txtChqNo').val('');
        $('#txtBookCode').val('');
        $('#txtBankCode').val('');
        $('#txtBankName').val('');
        $('#txtBankBranch').val('');
        $('#txtChqDate').val('');
        $('#txtCashAmount').val('0.00');
        $('#txtChqAmount').val('0.00');
        $('#txtCreditAmount').val('0.00');
        $('#txtSumAmt').val('0.00');
        $('#txtTotalAmt').val('0.00');
        $('#txtTotalNet').val('0.00');
        $('#txtVatExc').val('0.00');
        $('#txtWhtExc').val('0.00');
        $('#txtVatInc').val('0.00');
        $('#txtWhtInc').val('0.00');
        $('#txtCurrencyCode').val('');
        $('#txtCurrencyName').val('');
        $('#txtExchangeRate').val('0.00');
        $('#txtIsLocal').val('');
        $('#txtChqStatus').val('');
        $('#cboChqStatus').val('');
        $('#txtDTRemark').val('');
        $('#txtPayChqTo').val('');
        $('#txtRecvBank').val('');
        $('#txtRecvBankName').val('');
        $('#txtRecvBranch').val('');
        $('#txtSICode').val('');
        $('#txtSDescription').val('');
        $('#txtDocNo').val('');
        $('#txtacType').val('');
        $('#cboacType').val('');
        $('#cboacType').change();
        ShowInfo();
    }
    function ClearDocument() {
        $('#txtDocType').val('');
        $('#cboDocType').val('');
        $('#txtDDocNo').val('');
        $('#txtDocItemNo').val('0');
        $('#txtDocDate').val('');
        $('#txtCmpType').val('');
        $('#cboCmpType').val('');
        $('#cboCmpType').change();
        $('#txtCmpCode').val('');
        $('#txtCmpName').val('');
        $('#txtCmpBranch').val('');
        $('#txtPaidAmount').val('0.00');
        $('#txtTotalAmount').val('0.00');
        $('#txtDocacType').val('');
        $('#cboDocacType').val('');
    }
    function SavePayment() {
        var obj = {
            BranchCode: $('#txtBranchCode').val(),
            ControlNo: $('#txtControlNo').val(),
            ItemNo: $('#txtItemNo').val(),
            PRVoucher:$('#txtPRVoucher').val(),
            PRType:$('#txtPRType').val(),
            ChqNo:$('#txtChqNo').val(),
            BookCode:$('#txtBookCode').val(),
            BankCode:$('#txtBankCode').val(),
            BankBranch:$('#txtBankBranch').val(),
            ChqDate:CDateTH($('#txtChqDate').val()),
            CashAmount:CNum($('#txtCashAmount').val()),
            ChqAmount:CNum($('#txtChqAmount').val()),
            CreditAmount: CNum($('#txtCreditAmount').val()),
            SumAmount: CNum($('#txtSumAmt').val()),
            CurrencyCode: $('#txtCurrencyCode').val(),
            ExchangeRate: CNum($('#txtExchangeRate').val()),
            TotalAmount: CNum($('#txtTotalAmt').val()),
            VatExc: CNum($('#txtVatExc').val()),
            VatInc: CNum($('#txtVatInc').val()),
            WhtExc: CNum($('#txtWhtExc').val()),
            WhtInc: CNum($('#txtWhtInc').val()),
            TotalNet: CNum($('#txtTotalNet').val()),
            IsLocal:$('#txtIsLocal').val(),
            ChqStatus:$('#txtChqStatus').val(),
            TRemark:$('#txtDTRemark').val(),
            PayChqTo:$('#txtPayChqTo').val(),
            DocNo:$('#txtDocNo').val(),
            SICode:$('#txtSICode').val(),
            RecvBank:$('#txtRecvBank').val(),
            RecvBranch: $('#txtRecvBranch').val(),
            acType: $('#txtacType').val()
        };
        if (obj.PRVoucher != "") {
            var ask = confirm("Do you need to Save " + obj.PRVoucher + "?");
            if (ask == false) return;
            var jsonText = JSON.stringify({ data:[ obj ]});
            //alert(jsonText);
            $.ajax({
                url: "@Url.Action("SetVoucherSub", "Acc")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.data !== null) {
                        SetGridPayment(response.result.data[0]);
                    }
                    alert("Save " + response.result.msg +"!");
                },
                error: function (e) {
                    alert(e);
                }
            });
        } else {
            alert('No data to save');
        }
    }
    function SaveDocument() {
        var obj = {
            BranchCode:$('#txtBranchCode').val(),
            ControlNo:$('#txtControlNo').val(),
            ItemNo:$('#txtDocItemNo').val(),
            DocType:$('#txtDocType').val(),
            DocNo:$('#txtDDocNo').val(),
            DocDate:CDateTH($('#txtDocDate').val()),
            CmpType:$('#txtCmpType').val(),
            CmpCode:$('#txtCmpCode').val(),
            CmpBranch:$('#txtCmpBranch').val(),
            PaidAmount:CNum($('#txtPaidAmount').val()),
            TotalAmount: CNum($('#txtTotalAmount').val()),
            acType: $('#txtDocacType').val()
        };
        if (obj.DocNo!= "") {
            var ask = confirm("Do you need to Save " + obj.DocNo + "?");
            if (ask == false) return;
            var jsonText = JSON.stringify({ data:[ obj ]});
            //alert(jsonText);
            $.ajax({
                url: "@Url.Action("SetVoucherDoc", "Acc")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.document !== null) {
                        SetGridDocument(response.result.document[0]);
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
    function ReadVender(dt) {
        $('#txtCmpCode').val(dt.VenCode);
        $('#txtCmpName').val(dt.TName);
        $('#txtCmpBranch').val('');
        $('#txtCmpCode').focus();
    }
    function ReadCustomer(dt) {
        $('#txtCmpCode').val(dt.CustCode);
        $('#txtCmpBranch').val(dt.Branch);
        $('#txtCmpName').val(dt.NameThai);
        $('#txtCmpCode').focus();
    }
    function ReadBranch(dt) {
        $('#txtBranchCode').val(dt.Code);
        $('#txtBranchName').val(dt.BrName);
        $('#txtBranchCode').focus();
    }
    function ReadBank(dt) {
        $('#txtRecvBank').val(dt.Code);
        $('#txtRecvBankName').val(dt.BName);
    }
    function ReadService(dt) {
        $('#txtSICode').val(dt.SICode);
        $('#txtSDescription').val(dt.NameThai);
    }
    function ReadBookAccount(dt) {
        $('#txtBookCode').val(dt.BookCode);
        $('#txtBookName').val(dt.BookName);
        $('#txtBankCode').val(dt.BankCode);
        ShowBank(path, dt.BankCode, '#txtBankName');
        $('#txtBankBranch').val(dt.BankBranch);
        $('#chkIsLocal').prop('checked', dt.IsLocal = 1 ? true : false);
    }
    function ReadCurrency(dt) {
        $('#txtCurrencyCode').val(dt.Code);
        $('#txtCurrencyName').val(dt.TName);
    }
    function GetCmpType() {
        var v = '';
        switch ($('#cboCmpType').val()) {
            case 'C':
                v = 'cust';
                break;
            case 'V':
                v = 'vender';
                break;
            default:
                break;
        }
        return v;
    }
    function CalculateTotal() {
        let amtbase = Number($('#txtSumAmt').val());
        let excrate = Number($('#txtExchangeRate').val());
        let totalamt = amtbase * excrate;
        $('#txtTotalAmt').val(CDbl(totalamt, 4));
        //calculate for exclude vat/wht
        totalamt = Number($('#txtTotalAmt').val());
        let vatexc = Number($('#txtVatExc').val());
        let whtexc = Number($('#txtWhtExc').val());
        totalamt += vatexc;
        totalamt -= whtexc;
        $('#txtTotalNet').val(CDbl(totalamt, 4));

        //calculate base for included vat/wht
        let vatinc = Number($('#txtVatInc').val());
        let whtinc = Number($('#txtWhtInc').val());        
        totalamt += whtinc;
        totalamt -= vatinc;
        $('#txtTotalAmt').val(CDbl(totalamt, 4));
    }
    function PrintData() {
        if (userRights.indexOf('P') < 0) {
            alert('you are not authorize to print');
            return;
        }
        window.open(path + 'Acc/FormVoucher?branch=' + $('#txtBranchCode').val() + '&controlno=' + $('#txtControlNo').val());
    }

</script>