@Code
    ViewBag.Title = "Cheque Management"
End Code
<div class="panel-body">
    <div class="container">
        <div id="dvForm">
            <div class="row">
                <div class="col-sm-4">
                    Branch:
                    <br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" class="form-control" id="txtBranchCode" style="width:15%" disabled />
                        <input type="button" class="btn btn-default" value="..." onclick="SearchData('branch');" />
                        <input type="text" class="form-control" id="txtBranchName" style="width:65%" disabled />
                    </div>
                </div>
                <div class="col-sm-4">
                    <b>Reference No:</b>
                    <br />
                    <div style="display:flex;flex-direction:row">
                        <input type="text" class="form-control" id="txtControlNo" style="font-weight:bold;font-size:20px;text-align:center;background-color:navajowhite;color:brown" tabindex="1" />
                        <input type="button" class="btn btn-default" value="..." onclick="SearchData('controlno')" />
                    </div>
                </div>
                <div class="col-sm-2">
                    Record Date<br /> <input type="date" id="txtVoucherDate" class="form-control" tabIndex="3">
                </div>
                <div class="col-sm-2">
                    Cheque Type<br />
                    <select id="cboPRType" class="form-control dropdown">
                        <option value="P">Paid</option>
                        <option value="R">Received</option>
                    </select>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6">
                    Cheque Note<br /><input type="text" id="txtTRemark" class="form-control" tabIndex="4">
                </div>
                <div class="col-sm-6">
                    Cheque Issue by:
                    <br/>
                    <div style="display:flex;flex-direction:row">
                        <input type="text" id="txtCustCode" style="width:120px" />
                        <input type="text" id="txtCustBranch" style="width:50px" />
                        <button id="btnBrowseCust" class="btn btn-default" onclick="SearchData('customer')">...</button>
                        <input type="text" id="txtCustName" style="width:100%" disabled />
                    </div>
                </div>
            </div>
            <div>
                <a href="#" class="btn btn-warning w3-purple" id="btnAdd" onclick="AddPayment()">
                    <i class="fa fa-lg fa-file-o"></i>&nbsp;<b>Add Detail</b>
                </a>
            </div>
            <table id="tbHeader" class="table table-responsive table-bordered">
                <thead>
                    <tr>
                        <th>Chq</th>
                        <th class="desktop">VCNo</th>
                        <th class="desktop">BookAcc</th>
                        <th class="desktop">RefChqNo</th>
                        <th class="all">RefDate</th>
                        <th class="all">Bank</th>
                        <th class="desktop">Branch</th>
                        <th class="desktop">PayChqTo</th>
                    </tr>
                </thead>
            </table>
            <div class="row">
                <div class="col-xs-4" style="border-style:solid;border-width:1px;background:white;">
                    <label>Issue By</label>
                    <br />
                    <input type="text" id="txtRecUser" style="width:250px" disabled />
                    <br />
                    Date:
                    <input type="date" id="txtRecDate" disabled />
                    Time:
                    <input type="text" id="txtRecTime" style="width:80px" disabled />
                </div>
                <div class="col-xs-4" style="border-style:solid;border-width:1px;background:lightgreen;">
                    <input type="checkbox" id="chkPosted" />
                    <label for="chkPosted">Posted By</label><br />
                    <input type="text" id="txtPostedBy" style="width:250px" disabled />
                    <br />
                    Date:
                    <input type="date" id="txtPostedDate" disabled />
                    Time:
                    <input type="text" id="txtPostedTime" style="width:80px" disabled />
                </div>
                <div class="col-xs-4" style="border-style:solid;border-width:1px;color:red;background:lightyellow;">
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
                        <h4 class="modal-title"><label id="lblHeader">Cheque List</label></h4>
                    </div>
                    <div class="modal-body">
                        <table id="tbControl" class="table table-responsive">
                            <thead>
                                <tr>
                                    <th>ControlNo</th>
                                    <th class="desktop">VoucherDate</th>
                                    <th class="all">CustCode</th>
                                    <th class="desktop">Remark</th>
                                    <th class="desktop">VoucherNo</th>
                                    <th class="all">ChqNo</th>
                                    <th class="desktop">ChqDate</th>
                                    <th class="all">ChqAmount</th>
                                    <th class="desktop">Currency</th>
                                    <th class="desktop">DocNo</th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                    <div class="modal-footer">
                        <button id="btnHide" class="btn btn-danger" data-dismiss="modal">X</button>
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
                        <label><input type="radio" id="optShowPay" value="dvPayInfo" name="showInfo" onchange="ShowInfo()" checked /> Cheque Info</label>
                        <label><input type="radio" id="optShowTax" value="dvPayTax" name="showInfo" onchange="ShowInfo()" /> VAT/Tax info</label>
                    </div>
                    <div class="modal-body">
                        <div id="dvPayInfo">
                            <div class="row">
                                <div class="col-md-2">
                                    No<br /><input type="text" id="txtItemNo" class="form-control" disabled>
                                </div>
                                <div class="col-md-5">
                                    Voucher No:<br /><input type="text" id="txtPRVoucher" class="form-control" disabled>
                                </div>
                                <div class="col-md-5">
                                    Issuer:<br /><input type="hidden" id="txtacType" class="form-control">
                                    <select id="cboacType" class="form-control dropdown" onchange="SetACType('cboacType')">
                                        <option value="CH">Company</option>
                                        <option value="CU">Customer</option>
                                    </select>
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
                                <div class="col-md-3">
                                    <label id="lblChqAmount">ChqAmount</label>
                                    <br /><input type="number" id="txtChqAmount" class="form-control" value="0.00" />
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
                                <div class="col-md-3">
                                    <a onclick="SearchData('document')">Doc.Type</a><br />
                                    <select id="txtDocType" class="form-control dropdown">
                                    </select>
                                </div>
                                <div class="col-md-4">
                                    Ref.No<br /><input type="text" id="txtDocNo" class="form-control">
                                </div>
                                <div class="col-md-5">
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
                                    <input type="text" id="txtExchangeRate" class="form-control" onchange="CalculateTotal()" />
                                </div>
                                <div class="col-md-4">
                                    Total Amount<br />
                                    <input type="text" id="txtTotalAmt" class="form-control" onchange="CalculateTotal()" />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-3">
                                    Vat(Include)<br />
                                    <input type="text" id="txtVatInc" class="form-control" onchange="CalculateTotal()" />
                                </div>
                                <div class="col-md-3">
                                    Vat(Exclude)<br />
                                    <input type="text" id="txtVatExc" class="form-control" onchange="CalculateTotal()" />
                                </div>
                                <div class="col-md-3">
                                    Wht(Include)<br />
                                    <input type="text" id="txtWhtInc" class="form-control" onchange="CalculateTotal()" />
                                </div>
                                <div class="col-md-3">
                                    Wht(Exclude)<br />
                                    <input type="text" id="txtWhtExc" class="form-control" onchange="CalculateTotal()" />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-3">
                                    Total Net<br />
                                    <input type="text" id="txtTotalNet" class="form-control" disabled />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-8">
                                    Note<br /><input type="text" id="txtDTRemark" class="form-control">
                                </div>
                                <div class="col-md-4">
                                    Job No.<br /><input type="text" id="txtForJNo" class="form-control">
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-4">
                                    <input type="hidden" id="txtJobType">
                                    <input type="hidden" id="txtShipBy">
                                    Job Type<br />
                                    <input type="text" id="txtJobTypeName" class="form-control" disabled />
                                </div>
                                <div class="col-md-4">
                                    Ship By<br />
                                    <input type="text" id="txtShipByName" class="form-control" disabled />
                                </div>
                                <div class="col-md-4">
                                    Inv.No<br />
                                    <input type="text" id="txtInvNo" class="form-control" disabled />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <div style="float:left">
                            <a href="#" class="btn btn-success" id="btnUpdatePay" onclick="SavePayment()">
                                <i class="fa fa-lg fa-save"></i>&nbsp;<b>Save Detail</b>
                            </a>
                            <a href="#" class="btn btn-danger" id="btnDelPay" onclick="DeletePayment()">
                                <i class="fa fa-lg fa-trash"></i>&nbsp;<b>Delete Detail</b>
                            </a>
                        </div>
                        <button id="btnHide" class="btn btn-danger" data-dismiss="modal">X</button>
                    </div>
                </div>
            </div>
        </div>
        <div id="dvCommand">
            <a href="#" class="btn btn-default w3-purple" id="btnAdd" onclick="ClearForm()">
                <i class="fa fa-lg fa-file-o"></i>&nbsp;<b>Clear Data</b>
            </a>
            <a href="#" class="btn btn-success" id="btnSave" onclick="SaveData()">
                <i class="fa fa-lg fa-save"></i>&nbsp;<b>Save Data</b>
            </a>
            <a href="#" class="btn btn-info" id="btnPrint" onclick="PrintData()">
                <i class="fa fa-lg fa-print"></i>&nbsp;<b>Print Data</b>
            </a>
        </div>
    </div>
</div>
<div id="dvLOVs"></div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    const path = '@Url.Content("~")';
    const user = '@ViewBag.User';
    const userRights = '@ViewBag.UserRights';
    //$(document).ready(function () {
    let branch = getQueryString("BranchCode");
    let job = getQueryString("JNo");
    if (branch !== '' && job !== '') {
        $('#txtBranchCode').val(branch);
        $('#txtForJNo').val(job);
        $('#txtForJNo').attr('disabled', 'disabled');
        ShowBranch(path, branch, '#txtBranchName');
        CallBackQueryJob(path, $('#txtBranchCode').val(), $('#txtForJNo').val(), ReadJob);        
    } else {
        $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
        $('#txtBranchName').val('@ViewBag.PROFILE_DEFAULT_BRANCH_NAME'); 
    }
    SetEvents();
    SetLOVs();
    SetEnterToTab();
    //});
    function SetIsLocal() {
        $('#txtIsLocal').val($('#chkIsLocal').prop('checked') ? '1' : '0');
    }
    function SetACType(n) {
        let typ = $('#' + n).val();

        $('#dvChqInfo').show();
        $('#dvBookInfo').hide();
        switch (typ) {
            case 'CU':
                break;
            case 'CH':
                $('#dvBookInfo').show();
                break;
            default:
                $('#dvChqInfo').hide();
                break;
        }
    }

    function SetChqStatus() {
        $('#txtChqStatus').val($('#cboChqStatus').val());
    }
    function SetEvents() {
        $('#txtControlNo').keydown(function (event) {
            if (event.which == 13) {
                LoadData();
            }
        });
        $('#txtSICode').keydown(function (event) {
            if (event.which == 13) {
                $('#txtSDescription').val('');
                CallBackQueryService(path, $('#txtSICode').val(), ReadService);
            }
        });
        $('#txtCustBranch').keydown(function (event) {
            if (event.which == 13) {
                $('#txtCustName').val('');
                ShowCustomer(path, $('#txtCustCode').val(), $('#txtCustBranch').val(), '#txtCustName');
                return;
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
        $('#txtChqAmount').focusout(function (event) {
            $('#txtSumAmt').val($('#txtChqAmount').val());
            CalculateTotal();
        });
        $('#txtBranchCode').keydown(function (event) {
            if (event.which == 13) {
                $('#txtBranchName').val('');
                ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            }
        });
        $('#txtForJNo').keydown(function (event) {
            if (event.which == 13) {
                $('#txtJobType').val('');
                $('#txtShipBy').val('');
                $('#txtJobType').val('');
                $('#txtShipBy').val('');
                $('#txtInvNo').val('');

                CallBackQueryJob(path, $('#txtBranchCode').val(), $('#txtForJNo').val(), ReadJob);
            }
        });
        $('#chkPosted').on('click', function () {
            chkmode = this.checked;
            CallBackAuthorize(path, 'MODULE_ADV', 'CreditAdv',(chkmode ? 'I':'D'), SetApprove);
        });

        $('#chkCancel').on('click', function () {
            chkmode = this.checked;
            CallBackAuthorize(path, 'MODULE_ADV', 'CreditAdv', 'D', SetCancel);
        });
    }
    function SetEnterToTab() {
        $('#txtVoucherDate').val(GetToday());

        //Set enter to tab
        $("input[tabindex], select[tabindex], textarea[tabindex]").each(function () {
            $(this).on("keypress", function (e) {
                if (e.keyCode === 13) {
                    let idx = (this.tabIndex + 1);
                    let nextElement = $('[tabindex="' + idx + '"]');
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
        let lists = 'CHQ_STATUS=#cboChqStatus';
        lists += ',DOCUMENT_TYPE=#txtDocType';

        loadCombos(path,lists)

        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("dvLOVs");
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
    function SetApprove(b) {
        if (b == true) {
            $('#txtPostedBy').val(chkmode ? user : '');
            $('#txtPostedDate').val(chkmode ? CDateEN(GetToday()) : '');
            $('#txtPostedTime').val(chkmode ? ShowTime(GetTime()) : '');
            return;
        }
        ShowMessage('You are not allow to ' + (b ? 'Post voucher!' : 'cancel post!'));
        $('#chkPosted').prop('checked', !chkmode);
    }
    function SetCancel(b) {
        if (b == true) {
            $('#txtCancelProve').val(chkmode ? user : '');
            $('#txtCancelDate').val(chkmode ? CDateEN(GetToday()) : '');
            $('#txtCancelTime').val(chkmode ? ShowTime(GetTime()) : '');
            return;
        }
        ShowMessage('You are not allow to ' + (b ? 'cancel voucher!' : 'do this!'));
        $('#chkCancel').prop('checked', !chkmode);
    }
    function LoadData() {
        let code = $('#txtControlNo').val();
        let branch = $('#txtBranchCode').val();
        $('#txtBranchCode').val(branch);
        $('#txtControlNo').val(code);
        CallBackQueryVoucher(path, branch,code, ReadData);
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
            case 'customer':
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
        //$('#txtBranchCode').val('');
        //$('#txtBranchName').val('');
        $('#txtControlNo').val('');
        $('#txtVoucherDate').val(GetToday());
        $('#txtTRemark').val('');
        $('#txtCustCode').val('');
        $('#txtCustBranch').val('');
        $('#txtCustName').val('');
        $('#txtRecUser').val(user);
        $('#txtRecDate').val(GetToday());
        $('#txtRecTime').val(GetTime());
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

        $('#btnAdd').removeAttr('disabled');
        $('#btnSave').removeAttr('disabled');
        if (userRights.indexOf('I') < 0) {
            $('#btnAdd').attr('disabled', 'disabled');
        }
        if (userRights.indexOf('E') < 0) {
            $('#btnSave').attr('disabled', 'disabled');
        }
        ClearPayment();
    }
    function AddPayment() {
        if (userRights.indexOf('I') < 0) {
            ShowMessage('you are not authorize to add payment');
            return;
        }
        ClearPayment();
        $('#frmPayment').modal('show');
    }
    function ReadData(dt) {
        ClearForm();
        if (dt.header.length > 0) {
            ReadHeader(dt.header[0]);
        }
        if (dt.payment.length > 0) {
            let data = dt.payment.filter(function (d) {
                return d.PRType=$('#cboPRType').val() && d.ChqAmount>0
            });
            SetGridPayment(data);
        }
    }
    function SaveData() {
        ShowConfirm("Do you need to Save " + $('#txtControlNo').val() + "?", function (ask) {
            if (ask == false) return;
            let obj = {
                BranchCode:$('#txtBranchCode').val(),
                ControlNo:$('#txtControlNo').val(),
                VoucherDate:CDateTH($('#txtVoucherDate').val()),
                TRemark:$('#txtTRemark').val(),
                RecUser: user,
                RecDate: CDateTH(GetToday()),
                RecTime: GetTime(),
                PostedBy:$('#txtPostedBy').val(),
                PostedDate:CDateTH($('#txtPostedDate').val()),
                PostedTime:$('#txtPostedTime').val(),
                CancelReson:$('#txtCancelReson').val(),
                CancelProve:$('#txtCancelProve').val(),
                CancelDate:CDateTH($('#txtCancelDate').val()),
                CancelTime: $('#txtCancelTime').val(),
                CustCode: $('#txtCustCode').val(),
                CustBranch: $('#txtCustBranch').val()
            };
            let jsonText = JSON.stringify({ data: obj });
            //ShowMessage(jsonText);
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
                    ShowMessage(response.result.msg);
                },
                error: function (e) {
                    ShowMessage(e);
                }
            });
        });
    }
    function SetGridControl() {
        let code = $('#txtBranchCode').val();
        if (job !== "") {
            code += '&job=' + job;
        }
        $.get(path + 'acc/getvouchergrid?branch=' + code + '&type=CHQ' + $('#cboPRType').val(), function (r) {
            if (r.voucher.data.length == 0) {
                ShowMessage('data not found on this branch');
                return;
            }
            let h = r.voucher.data[0].Table;
            $('#tbControl').DataTable({
                data: h,
                selected: true, //ให้สามารถเลือกแถวได้
                columns: [ //กำหนด property ของ header column
                    { data: "DRefNo", title: "Doc No" },
                    {
                        data: "VoucherDate", title: "Date",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "CustCode", title: "Customer" },
                    { data: "TRemark", title: "Remark" },
                    { data: "ForJNo", title: "JobNo" },
                    { data: "ChqNo", title: "Cheque No" },
                    {
                        data: "ChqDate", title: "Chq Date",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "ChqAmount", title: "Chq Total" },
                    { data: "CurrencyCode", title: "Currency" },
                    { data: "ControlNo", title: "Control No" }
                ],
                responsive:true,
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            });
            $('#tbControl tbody').on('click', 'tr', function () {
                $('#tbControl tbody > tr').removeClass('selected');
                $(this).addClass('selected');
                let data = $('#tbControl').DataTable().row(this).data(); //read current row selected

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
            responsive:true,
            destroy: true
        });
        $('#tbHeader tbody').on('click', 'tr', function () {
            $('#tbHeader tbody > tr').removeClass('selected');
            $(this).addClass('selected');
            if (userRights.indexOf('E') > 0) {
                let data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
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

    function ReadHeader(dr) {
        if (dr !== undefined) {
            $('#txtBranchCode').val(dr.BranchCode);
            ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            $('#txtControlNo').val(dr.ControlNo);
            $('#txtVoucherDate').val(CDateEN(dr.VoucherDate));
            $('#txtTRemark').val(dr.TRemark);
            $('#txtRecUser').val(dr.RecUser);
            $('#txtRecDate').val(CDateEN(dr.RecDate));
            $('#txtRecTime').val(ShowTime(dr.RecTime));
            $('#txtPostedBy').val(dr.PostedBy);
            if (dr.PostedBy !== null) {
                $('#chkPosted').prop('checked', true);
                DisableSave();
            }
            $('#txtCustCode').val(dr.CustCode);
            $('#txtCustBranch').val(dr.CustBranch);
            ShowCustomer(path, $('#txtCustCode').val(), $('#txtCustBranch').val(), '#txtCustName');
            $('#txtPostedDate').val(CDateEN(dr.PostedDate));
            $('#txtPostedTime').val(ShowTime(dr.PostedTime));
            $('#txtCancelReson').val(dr.CancelReson);
            $('#txtCancelProve').val(dr.CancelProve);
            if (dr.CancelProve !== null) {
                $('#chkCancel').prop('checked', true);
                DisableSave();
            }
            $('#txtCancelDate').val(CDateEN(dr.CancelDate));
            $('#txtCancelTime').val(ShowTime(dr.CancelTime));
        }
    }
    function ReadPayment(dr) {
        ClearPayment();
        if (dr !== undefined) {
            $('#txtItemNo').val(dr.ItemNo);
            $('#txtPRVoucher').val(dr.PRVoucher);
            //$('#txtPRType').val(dr.PRType);
            //$('#cboPRType').val(dr.PRType);
            $('#txtChqNo').val(dr.ChqNo);
            $('#txtBankCode').val(dr.BankCode);
            $('#txtBookCode').val(dr.BookCode);
            $('#txtBankBranch').val(dr.BankBranch);
            $('#txtChqDate').val(CDateEN(dr.ChqDate));
            $('#txtChqAmount').val(CNum(dr.ChqAmount));
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
            $('#txtForJNo').val(dr.ForJNo);
            CallBackQueryJob(path, $('#txtBranchCode').val(), $('#txtForJNo').val(), ReadJob);
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
    function DisableSave() {
        $('#btnSave').attr('disabled', 'disabled');
        $('#btnUpdatePay').attr('disabled', 'disabled');
        $('#btnDelPay').attr('disabled', 'disabled');
    }
    function ClearPayment() {
        $('#txtPRVoucher').val('');
        $('#txtItemNo').val('0');
        $('#txtChqNo').val('');
        $('#txtBookCode').val('');
        $('#txtBankCode').val('');
        $('#txtBankName').val('');
        $('#txtBankBranch').val('');
        $('#txtChqDate').val('');
        $('#txtChqAmount').val('0.00');
        $('#txtSumAmt').val('0.00');
        $('#txtTotalAmt').val('0.00');
        $('#txtTotalNet').val('0.00');
        $('#txtVatExc').val('0.00');
        $('#txtWhtExc').val('0.00');
        $('#txtVatInc').val('0.00');
        $('#txtWhtInc').val('0.00');
        $('#txtCurrencyCode').val('@ViewBag.PROFILE_CURRENCY');
        $('#txtCurrencyName').val('THAI BAHT');
        $('#txtExchangeRate').val('1');
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
        $('#txtDocType').val('');
        $('#txtDocNo').val('');
        $('#txtJobType').val('');
        $('#txtShipBy').val('');
        $('#txtJobTypeName').val('');
        $('#txtShipByName').val('');
        $('#txtInvNo').val('');
        if (job == '') {
            $('#txtForJNo').val('');
        }
        $('#txtacType').val('');
        $('#cboacType').val('CU');
        $('#cboacType').change();

        $('#btnAddPay').removeAttr('disabled');
        $('#btnUpdatePay').removeAttr('disabled');
        $('#btnDelPay').removeAttr('disabled');
        if ($('#chkPosted').prop('checked') == true || $('#chkCancel').prop('checked') == true) {
            $('#btnAddPay').attr('disabled', 'disabled');
            $('#btnUpdatePay').attr('disabled', 'disabled');
            $('#btnDelPay').attr('disabled', 'disabled');
        }
        ShowInfo();
    }
    function SavePayment() {
        let obj = {
            BranchCode: $('#txtBranchCode').val(),
            ControlNo: $('#txtControlNo').val(),
            ItemNo: $('#txtItemNo').val(),
            PRVoucher:$('#txtPRVoucher').val(),
            PRType:$('#cboPRType').val(),
            ChqNo:$('#txtChqNo').val(),
            BookCode:$('#txtBookCode').val(),
            BankCode:$('#txtBankCode').val(),
            BankBranch:$('#txtBankBranch').val(),
            ChqDate:CDateTH($('#txtChqDate').val()),
            CashAmount:0,
            ChqAmount:CNum($('#txtChqAmount').val()),
            CreditAmount: 0,
            SumAmount: CNum($('#txtSumAmt').val()),
            CurrencyCode: $('#txtCurrencyCode').val(),
            ExchangeRate: CNum($('#txtExchangeRate').val()),
            TotalAmount: CNum($('#txtSumAmt').val()),
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
            acType: $('#cboacType').val(),
            ForJNo:$('#txtForJNo').val()
        };
        let jsonText = JSON.stringify({ data:[ obj ]});
        //ShowMessage(jsonText);
        $.ajax({
            url: "@Url.Action("SetVoucherSub", "Acc")",
            type: "POST",
            contentType: "application/json",
            data: jsonText,
            success: function (response) {
                LoadData();
            },
            error: function (e) {
                ShowMessage(e);
            }
        });
    }

    function DeletePayment() {
        let itemno = $('#txtItemNo').val();
        let code = $('#txtControlNo').val();
        let branch = $('#txtBranchCode').val();

        $.get(path + 'acc/delvouchersub?branch=' + branch + '&code=' + code + '&item=' + itemno, function (r) {
            ShowMessage(r.voucher.result);
        });
    }

    function ReadCustomer(dt) {
        $('#txtCustCode').val(dt.CustCode);
        $('#txtCustBranch').val(dt.Branch);
        $('#txtCustName').val(dt.NameThai);
        $('#txtCustCode').focus();
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
    function ReadJob(dt) {
        $('#txtJobType').val(dt[0].JobType);
        $('#txtShipBy').val(dt[0].ShipBy);
        $('#txtInvNo').val(dt[0].InvNo);
        ShowJobTypeShipBy(path, dt[0].JobType, dt[0].ShipBy, '', '#txtJobTypeName', '#txtShipByName', '');
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
            ShowMessage('you are not authorize to print');
            return;
        }
        window.open(path + 'Acc/FormVoucher?branch=' + $('#txtBranchCode').val() + '&controlno=' + $('#txtControlNo').val());
    }

</script>