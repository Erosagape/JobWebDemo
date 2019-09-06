
@Code
    ViewBag.Title = "Advance Information"
End Code
<div class="panel-body">
    <div id="dvHeader" class="container">
        <div class="row">
            <div class="col-sm-5">
                Branch:
                <br />
                <div style="display:flex;flex-direction:row">
                    <input type="text" class="form-control" id="txtBranchCode" style="width:15%" disabled />
                    <input type="button" class="btn btn-default" value="..." onclick="SearchData('branch');" />
                    <input type="text" class="form-control" id="txtBranchName" style="width:65%" disabled />
                </div>
                <div id="dvJob"></div>
            </div>
            <div class="col-sm-4" style="text-align:left">
                <b>Advance No:</b>
                <br />
                <div style="display:flex;flex-direction:row">
                    <input type="text" class="form-control" id="txtAdvNo" style="font-weight:bold;font-size:20px;text-align:center;background-color:navajowhite;color:brown" tabindex="1" />
                    <input type="button" class="btn btn-default" value="..." onclick="SearchData('advance')" />
                </div>
            </div>
            <div class="col-sm-3">
                Request Date :<br />
                <input type="date" class="form-control" id="txtAdvDate" tabindex="1" disabled />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <ul class="nav nav-tabs">
                    <li class="active"><a data-toggle="tab" href="#tabHeader">Advance Header</a></li>
                    <li><a data-toggle="tab" href="#tabDetail">Advance Detail</a></li>
                </ul>
                <div class="tab-content">
                    <div id="tabHeader" class="tab-pane fade in active" style="width:100%">
                        <div class="row">
                            <div class="col-sm-7">
                                <table>
                                    <tr>
                                        <td>
                                            Advance By :
                                        </td>
                                        <td style="display:flex;flex-direction:row">
                                            <input type="text" id="txtAdvBy" class="form-control" style="width:120px" tabindex="2" />
                                            <button id="btnBrowseEmp1" class="btn btn-default" onclick="SearchData('advby')">...</button>
                                            <input type="text" id="txtAdvName" class="form-control" style="width:100%" disabled />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Request By :
                                        </td>
                                        <td style="display:flex;flex-direction:row">
                                            <input type="text" id="txtReqBy" class="form-control" style="width:120px" tabindex="3" />
                                            <button id="btnBrowseEmp2" class="btn btn-default" onclick="SearchData('reqby')">...</button>
                                            <input type="text" id="txtReqName" class="form-control" style="width:100%" disabled />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Advance For :
                                        </td>
                                        <td style="display:flex;flex-direction:row">
                                            <input type="text" id="txtCustCode" class="form-control" style="width:130px" tabindex="4" />
                                            <input type="text" id="txtCustBranch" class="form-control" style="width:70px" tabindex="5" />
                                            <button id="btnBrowseCust" class="btn btn-default" onclick="SearchData('customer')">...</button>
                                            <input type="text" id="txtCustName" class="form-control" style="width:100%" disabled />
                                        </td>
                                    </tr>
                                </table>
                                <table>
                                    <tr>
                                        <td>
                                            WH-Tax No:
                                        </td>
                                        <td style="display:flex;flex-direction:row">
                                            <input type="text" id="txtDoc50Tavi" class="form-control" style="width:100%" tabindex="6" />
                                            <input type="button" class="btn btn-default" value="Add" onclick="AutoGenWHTax()" />
                                        </td>
                                        <td>
                                            Bill A/P:
                                        </td>
                                        <td style="display:flex;flex-direction:row">
                                            <input type="text" id="txtPaymentNo" class="form-control" style="width:200px" tabindex="7" disabled />
                                            <button id="btnBrowsePay" class="btn btn-default" onclick="SearchData('payment')">...</button>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div class="col-sm-5">
                                <table>
                                    <tr>
                                        <td>
                                            Job Type :
                                        </td>
                                        <td>
                                            <select id="cboJobType" style="width:200px" class="form-control dropdown" tabindex="8"></select>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Ship By :
                                        </td>
                                        <td>
                                            <select id="cboShipBy" style="width:200px" class="form-control dropdown" tabindex="9"></select>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Status :
                                        </td>
                                        <td>
                                            <select id="cboDocStatus" style="width:200px;" class="form-control dropdown" disabled></select>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-7">
                                Advance Type:
                                <select id="cboAdvType" class="form-control dropdown" style="width:100%" tabindex="10"></select>
                                <br />
                                Remark:
                                <textarea id="txtTRemark" class="form-control-lg" style="width:100%;height:80px" tabindex="11"></textarea>
                            </div>
                            <div class="col-sm-5">
                                <table>
                                    <tr>
                                        <td>
                                            Request Currency:
                                        </td>
                                        <td style="display:flex;flex-direction:row">
                                            <input type="text" id="txtSubCurrency" style="width:100%" value="@ViewBag.PROFILE_CURRENCY" disabled />
                                            <input type="button" class="btn btn-default" value="..." onclick="SearchData('subcurrency')" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            Payment Total:
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <input type="checkbox" id="chkCash" />
                                            <label for="chkCash">Cash</label>
                                        </td>
                                        <td style="display:flex;flex-direction:row">
                                            <input type="text" id="txtAdvCash" class="form-control" style="width:100%;text-align:right" disabled />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <input type="checkbox" id="chkChq" />
                                            <label for="chkChq">Cashier Chq</label>
                                        </td>
                                        <td style="display:flex;flex-direction:row">
                                            <input type="text" id="txtAdvChq" class="form-control" style="width:100%;text-align:right" disabled />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <input type="checkbox" id="chkChqCash" />
                                            <label for="chkChqCash">Customer Chq</label>
                                        </td>
                                        <td style="display:flex;flex-direction:row">
                                            <input type="text" id="txtAdvChqCash" class="form-control" style="width:100%;text-align:right" disabled />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <input type="checkbox" id="chkCred" />
                                            <label for="chkCred">Credit</label>
                                        </td>
                                        <td style="display:flex;flex-direction:row">
                                            <input type="text" id="txtAdvCred" class="form-control" style="width:100%;text-align:right" disabled />
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-4" style="border-style:solid;border-width:1px">
                                <input type="checkbox" id="chkApprove" />
                                <label for="chkApprove">Approve By</label>
                                <br />
                                <input type="text" id="txtApproveBy" style="width:250px" disabled />
                                <br />
                                Date:
                                <input type="date" id="txtApproveDate" disabled />
                                Time:
                                <input type="text" id="txtApproveTime" style="width:80px" disabled />
                            </div>
                            <div class="col-sm-4" style="border-style:solid;border-width:1px">
                                <input type="checkbox" id="chkPayment" disabled />
                                <label for="chkPayment">Payment By</label>
                                <input type="text" id="txtPaymentBy" style="width:250px" disabled />
                                <br />
                                Date:
                                <input type="date" id="txtPaymentDate" disabled />
                                Time:
                                <input type="text" id="txtPaymentTime" style="width:80px" disabled />
                                <br />
                                Payment Ref:<input type="text" id="txtPaymentRef" style="width:200px" disabled />
                            </div>
                            <div class="col-sm-4" style="border-style:solid;border-width:1px;color:red">
                                <input type="checkbox" id="chkCancel" />
                                <label for="chkCancel">Cancel By</label>
                                <input type="text" id="txtCancelProve" style="width:250px" disabled />
                                <br />
                                Date:
                                <input type="date" id="txtCancelDate" disabled />
                                Time:
                                <input type="text" id="txtCancelTime" style="width:80px" disabled />
                                <br />
                                Cancel Reason :<input type="text" id="txtCancelReson" style="width:250px" />
                            </div>
                        </div>
                        <div id="dvCommand">
                            <a href="#" class="btn btn-default w3-purple" id="btnNew" onclick="AddHeader()">
                                <i class="fa fa-lg fa-file-o"></i>&nbsp;<b>New Document</b>
                            </a>
                            <a href="#" class="btn btn-success" id="btnSave" onclick="SaveHeader()">
                                <i class="fa fa-lg fa-save"></i>&nbsp;<b>Save Document</b>
                            </a>
                            <a href="#" class="btn btn-info" id="btnPrint" onclick="PrintData()">
                                <i class="fa fa-lg fa-print"></i>&nbsp;<b>Print Document</b>
                            </a>
                        </div>
                    </div>
                    <div id="tabDetail" class="tab-pane fade">
                        <div class="row">
                            <div class="col-sm-12">
                                <a href="#" class="btn btn-default w3-purple" id="btnAdd" onclick="AddDetail()">
                                    <i class="fa fa-lg fa-file-o"></i>&nbsp;<b>Add Detail</b>
                                </a>
                                <table id="tbDetail" class="table table-responsive">
                                    <thead>
                                        <tr>
                                            <th>
                                            <th class="desktop">SICode</th>
                                            <th class="all">Description</th>
                                            <th>Job No</th>
                                            <th class="all">Currency</th>
                                            <th class="desktop">Rate</th>
                                            <th class="desktop">Qty</th>
                                            <th class="desktop">Price</th>
                                            <th class="desktop">Amount</th>
                                            <th class="desktop">Vat</th>
                                            <th class="desktop">WH-Tax</th>
                                            <th class="all">Net</th>
                                        </tr>
                                    </thead>
                                </table>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-9">
                                <a href="#" class="btn btn-danger" id="btnDel" onclick="DeleteDetail()">
                                    <i class="fa fa-lg fa-trash"></i>&nbsp;<b>Delete Detail</b>
                                </a>
                                Main Currency:
                                <input type="text" id="txtMainCurrency" style="width:50px" value="@ViewBag.PROFILE_CURRENCY" disabled />
                                Exchange Rate:
                                <input type="text" id="txtExchangeRate" style="width:50px" value="1" />
                                <buttom id="btnGetExcRate" class="btn btn-success" onclick="GetExchangeRate()">Get Rate</buttom>
                            </div>
                            <div class="col-sm-3" style="text-align:right">
                                Amount :
                                <input type="text" id="txtAdvAmount" style="width:100px;text-align:right" /><br />
                                VAT :
                                <input type="text" id="txtVatAmount" style="width:100px;text-align:right" /><br />
                                WHT :
                                <input type="text" id="txtWhtAmount" style="width:100px;text-align:right" /><br />
                                Total :
                                <input type="text" id="txtTotalAmount" style="width:100px;text-align:right" />
                            </div>
                        </div>
                        <a href="#" class="btn btn-info" id="btnPrint" onclick="PrintData()">
                            <i class="fa fa-lg fa-print"></i>&nbsp;<b>Print Document</b>
                        </a>
                    </div>
                    <div id="frmDetail" class="modal fade" role="dialog">
                        <div class="modal-dialog">
                            <div class="modal-content">
                                <div class="modal-header">                                    
                                    <h4 class="modal-title"><label id="lblHeader">Advance Detail</label></h4>
                                </div>
                                <div class="modal-body">
                                    <label for="txtItemNo">No :</label>
                                    <input type="text" id="txtItemNo" style="width:40px" disabled />
                                    <select id="cboSTCode" class="dropdown"></select>
                                    <input type="checkbox" id="chkDuplicate" />
                                    <label for="chkDuplicate">Can Partial Clear</label>
                                    <br />
                                    <label for="txtSICode">Code :</label>
                                    <input type="text" id="txtSICode" style="width:80px" tabindex="12" />
                                    <input type="button" id="btnBrowseS" value="..." onclick="SearchData('servicecode')" />
                                    Description : <input type="text" id="txtSDescription" style="width:230px" tabindex="13" />
                                    <br />
                                    <label for="txtForJNo">Job No :</label>
                                    <input type="text" id="txtForJNo" style="width:120px" tabindex="14" />
                                    <input type="button" id="btnBrowseJ" value="..." onclick="SearchData('job')" />
                                    Cust.Inv : <input type="text" id="txtInvNo" style="width:230px" disabled />
                                    <br />
                                    <a onclick="SearchData('detcurrency')">Currency :</a>
                                    <input type="text" id="txtCurrencyCode" style="width:50px" tabindex="15" />
                                    <input type="text" id="txtCurrencyName" style="width:200px" disabled />
                                    <label for="txtExcRate">Rate :</label>
                                    <input type="text" id="txtDetCurrency" style="width:50px" disabled />
                                    <input type="text" id="txtExcRate" style="width:80px;text-align:right" tabindex="16" />
                                    <br />
                                    <label for="txtAdvQty">Qty:</label>
                                    <input type="text" id="txtAdvQty" style="width:100px;text-align:right" tabindex="17" />
                                    <label id="lblUnitPrice" for="txtUnitPrice">Price :</label>
                                    <input type="text" id="txtUnitPrice" style="width:100px;text-align:right" tabindex="18" />
                                    <label id="lblAMTCal" for="txtAMTCal">Amount :</label>
                                    <input type="text" id="txtAMTCal" style="width:100px;text-align:right" disabled />
                                    <br />
                                    <label id="lblAmount" for="txtAmount">Amount :</label>
                                    <input type="text" id="txtAMT" style="width:100px;text-align:right" tabindex="19" />
                                    <label id="lblVATRate" for="txtVATRate">VAT :</label>
                                    <input type="text" id="txtVATRate" style="width:50px;text-align:right" tabindex="20" />
                                    Type :
                                    <select id="txtVatType" class="dropdown" disabled>
                                        <option value="0">NO</option>
                                        <option value="1">EX</option>
                                        <option value="2">IN</option>
                                    </select>
                                    <input type="text" id="txtVAT" style="width:100px;text-align:right" tabindex="21" />
                                    <br />
                                    <label id="lblWHTRate" for="txtWHTRate">WH-Tax :</label>
                                    <input type="text" id="txtWHTRate" style="width:50px;text-align:right" tabindex="22" />
                                    <input type="text" id="txtWHT" style="width:100px;text-align:right" tabindex="23" />
                                    <label id="lblNETAmount" for="txtNETAmount">Net Amount :</label>
                                    <input type="text" id="txtNET" style="width:100px;text-align:right" tabindex="24" />
                                    <br />
                                    WH-Tax No :
                                    <input type="text" id="txt50Tavi" style="width:200px" tabindex="25" />
                                    <br />
                                    Pay To Vender :
                                    <input type="text" id="txtVenCode" style="width:50px" tabindex="26" />
                                    <input type="button" id="btnBrowseVen" onclick="SearchData('vender')" value="..." />
                                    <input type="text" id="txtPayChqTo" style="width:200px" tabindex="27" />
                                    <br />
                                    Remark :
                                    <textarea id="txtRemark" style="width:100%;height:80px" tabindex="28"></textarea>
                                </div>
                                <div class="modal-footer">
                                    <div style="float:left">
                                        <a href="#" class="btn btn-default w3-purple" id="btnAdd" onclick="AddDetail()">
                                            <i class="fa fa-lg fa-file-o"></i>&nbsp;<b>New</b>
                                        </a>
                                        <a href="#" class="btn btn-success" id="btnUpdate" onclick="SaveDetail()">
                                            <i class="fa fa-lg fa-save"></i>&nbsp;<b>Save</b>
                                        </a>
                                    </div>
                                    <button id="btnHide" class="btn btn-danger" data-dismiss="modal">X</button>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div id="frmHeader" class="modal modal-lg fade">
                        <div class="modal-dialog-lg">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal"></button>
                                    <h4 class="modal-title"><label id="lblHeader">Advance List</label></h4>
                                </div>
                                <div class="modal-body">
                                    <table id="tbHeader" class="table table-responsive">
                                        <thead>
                                            <tr>
                                                <th>AdvNo</th>
                                                <th class="all">AdvDate</th>
                                                <th class="desktop">CustCode</th>
                                                <th class="desktop">ReqBy</th>
                                                <th>Job</th>
                                                <th class="desktop">Inv No</th>
                                                <th class="desktop">Status</th>
                                                <th class="all">Amount</th>
                                                <th class="all">WT</th>
                                                <th class="desktop">WTDoc</th>
                                                <th class="desktop">APDoc</th>
                                                <th class="desktop">Remark</th>
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
                </div>
            </div>
        </div>
    </div>
    <div id="dvLOVs"></div>
</div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    const path = '@Url.Content("~")';
    const user = '@ViewBag.User';
    const userRights = '@ViewBag.UserRights';
    let serv = []; //must be array of object
    let hdr = {}; //simple object
    let dtl = {}; //simple object
    let job = '';
    let isjobmode = false;
    let chkmode = false;
    //$(document).ready(function () {       
    SetLOVs();
    SetEvents();
    SetEnterToTab();
    CheckParam();
    //});
    function CheckParam() {
        ClearHeader();
        //read query string parameters
        let br = getQueryString('BranchCode');
        if (br.length>0) {
            $('#txtBranchCode').val(br);
            ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            let ano = getQueryString('AdvNo');
            if (ano.length > 0) {
                $('#txtAdvNo').val(ano);
                ShowData(br, $('#txtAdvNo').val());
            } else {
                job = getQueryString('JNo');
                if (job.length > 0) {
                    isjobmode = true;
                    $('#dvJob').html('<h4>***For Job ' + job.toUpperCase() + '***</h4>');
                    $('#txtAdvNo').attr('disabled', 'disabled');
                    CallBackQueryJob(path, $('#txtBranchCode').val(), job, LoadJob);
                }
            }

        } else {
            $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
            $('#txtBranchName').val('@ViewBag.PROFILE_DEFAULT_BRANCH_NAME');
        }
        $('#txtAdvDate').val(GetToday());
    }
    function LoadJob(dt) {
        if (dt.length > 0) {
            let dr = dt[0];
            $('#txtForJNo').val(dr.JNo);
            $('#txtCustCode').val(dr.CustCode);
            $('#txtCustBranch').val(dr.CustBranch);
            $('#txtInvNo').val(dr.InvNo);
            $('#cboJobType').val(CCode(dr.JobType));
            $('#cboShipBy').val(CCode(dr.ShipBy));
            $('#cboDocStatus').val('01');

            ShowCustomer(path, $('#txtCustCode').val(), $('#txtCustBranch').val(), '#txtCustName');
            
            $('#txtCustCode').attr('disabled', 'disabled');
            $('#txtCustBranch').attr('disabled', 'disabled');
            $('#btnBrowseCust').attr('disabled', 'disabled');
            $('#txtForJNo').attr('disabled', 'disabled');
            $('#btnBrowseJ').attr('disabled', 'disabled');
            $('#cboJobType').attr('disabled', 'disabled');
            $('#cboShipBy').attr('disabled', 'disabled');

            $('#txtAdvBy').val(user);
            ShowUser(path, $('#txtAdvBy').val(), '#txtAdvName');

            $('#txtAdvBy').focus();
        }
    }
    function SetEnterToTab() {
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
                    $('[tabindex="0"]').focus();
                }
            });
        });
    }
    function SetEvents() {        
        if (userRights.indexOf('I') < 0) $('#btnNew').attr('disabled', 'disabled');
        if (userRights.indexOf('I') < 0) $('#btnAdd').attr('disabled', 'disabled');
        if (userRights.indexOf('E') < 0) $('#btnSave').attr('disabled', 'disabled');
        if (userRights.indexOf('E') < 0) $('#btnUpdate').attr('disabled', 'disabled');
        if (userRights.indexOf('D') < 0) $('#btnDel').attr('disabled', 'disabled');
        if (userRights.indexOf('P') < 0) $('#btnPrint').attr('disabled', 'disabled');

        $('#frmDetail').on('shown.bs.modal', function () {
            $('#txtSICode').focus();
        });
        $('#cboSTCode').on('change', function () {
            if ($('#cboSTCode').val() == '') {
                $('#txtSICode').val('');
                $('#txtSDescription').val('');

                $('#txtSICode').attr('disabled', 'disabled');
                $('#txtSDescription').attr('disabled', 'disabled');
                $('#chkDuplicate').prop('checked', true);
                return;
            }
            $('#chkDuplicate').prop('checked', false);
            $('#txtSICode').removeAttr('disabled');
            $('#txtSDescription').removeAttr('disabled');
        });
        $('#chkCash,#chkChq,#chkChqCash,#chkCred').on('click', function () {
            let id = this.id;
            let chk = this.checked;
            if (this.checked == false) {
                $('#txtAdv' + id.substr(3)).val(0);
                $('#txtAdv' + id.substr(3)).attr('disabled', 'disabled');
                return;
            }
            let val = GetTotal();
            if (val < 0) {
                ShowMessage('Total not Balance,Please check');
                $('#txtAdv' + id.substr(3)).val(0);
                $('#txtAdv' + id.substr(3)).attr('disabled', 'disabled');
                this.checked = false;
                return;
            }
            $('#txtAdv' + id.substr(3)).val(val);
            $('#txtAdv' + id.substr(3)).removeAttr('disabled');
            return;
        });
        $('#txtAdvCash,#txtAdvChq,#txtAdvChqCash,#txtAdvCred').keydown(function (e) {
            if (e.which == 13) {
                if (GetTotal() < 0) {
                    ShowMessage('Total not Balance,Please check');
                    $('#' + this.id).val(0);
                }
                let amt = $('#' + this.id).val();
                $('#chk' + this.id.substr(6)).prop('checked', amt > 0 ? true : false);
            }
        });
        $('#txtAdvCash,#txtAdvChq,#txtAdvChqCash,#txtAdvCred').on('blur', function () {
            let amt = $('#' + this.id).val();
            if (amt > 0) {
                if ($('#chk' + this.id.substr(6)).prop('checked') == false) {
                    $('#' + this.id).val(0);
                    $('#' + this.id).attr('disabled', 'disabled');
                } else {
                    if (GetTotal() < 0) {
                        $('#' + this.id).val(0);
                        $('#chk' + this.id.substr(6)).prop('checked', false);
                        $('#' + this.id).attr('disabled', 'disabled');
                        ShowMessage('Total not Balance,Please check');
                    }
                }
                return;
            }
            $('#' + this.id).attr('disabled', 'disabled');
            $('#chk' + this.id.substr(6)).prop('checked', false);
        });
        $('#chkApprove').on('click', function () {
            chkmode = this.checked;
            CallBackAuthorize(path, 'MODULE_ADV', 'Approve',(chkmode ? 'I':'D'), SetApprove);
        });
        /*
        $('#chkPayment').on('click', function () {
            chkmode = this.checked;
            CallBackAuthorize(path, 'MODULE_ADV', 'Payment', (chkmode ? 'I' : 'D'), SetPayment);
        });
        */
        $('#chkCancel').on('click', function () {
            chkmode = this.checked;
            CallBackAuthorize(path, 'MODULE_ADV', 'Index', 'D', SetCancel);
        });
        $('#txtCurrencyCode').focusout(function (event) {
            if (true) {
                ShowCurrency(path, $('#txtCurrencyCode').val(), '#txtCurrencyName');  
                ShowCaption();
            }
        });
        $('#txtBranchCode').focusout(function (event) {
            if (true) {
                ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            }
        });
        $('#txtAdvNo').focusout(function (event) {
            if (true) {
                ShowData($('#txtBranchCode').val(),$('#txtAdvNo').val());
            }
        });
        $('#txtAdvBy').change(function (event) {
            if (true) {
                ShowUser(path, $('#txtAdvBy').val(), '#txtAdvName');
            }
        });
        $('#txtReqBy').change(function (event) {
            if (true) {
                ShowUser(path, $('#txtReqBy').val(), '#txtReqName');
            }
        });
        $('#txtCustBranch').change(function (event) {
            if (true) {
                ShowCustomer(path, $('#txtCustCode').val(), $('#txtCustBranch').val(), '#txtCustName');
            }
        });
        $('#txtSICode').change(function (event) {
            if (true) {
                let dt = FindService($('#txtSICode').val())
                ReadService(dt);
            }
        });
        $('#txtAdvQty').change(function (event) {
            if (true) {
                CalAmount();
            }
        });
        $('#txtUnitPrice').change(function (event) {
            if (true) {
                CalAmount();
            }
        });
        $('#txtExcRate').change(function (event) {
            if (true) {
                CalAmount();
            }
        });
        $('#txtAMT').change(function (event) {
            if (true) {
                CalVATWHT();
            }
        });
        $('#txtVATRate').change(function (event) {
            if (true) {
                CalVATWHT();
            }
        });
        $('#txtWHTRate').change(function (event) {
            if (true) {                
                CalVATWHT();
            }
        });
        $('#txtVAT').change(function (event) {
            if (true) {
                CalTotal();
            }
        });
        $('#txtWHT').change(function (event) {
            if (true) {
                CalTotal();
            }
        });
        $('#txtForJNo').change(function (event) {
            if (true) {
                ShowInvNo(path, $('#txtBranchCode').val(), $('#txtForJNo').val(), '#txtInvNo');
            }
        });
        $('#txtNET').change(function (event) {
            if (true) {
                let type = $('#txtVatType').val();
                if (type == '0'||type=='') type = "1";
                if (type == "2") {
                    CalVATWHT();
                } else {
                    CalTotal();
                }
            }
        });
    }
    function SetApprove(b) {
        if (b == true) {
            if (chkmode) {
                if ($('#cboDocStatus').val().substr(0, 2) == '01') {
                    let dataApp = [];
                    dataApp.push(user);
                    dataApp.push($('#txtBranchCode').val() + '|' + $('#txtAdvNo').val());
                    let jsonString = JSON.stringify({ data: dataApp });
                    $.ajax({
                        url: "@Url.Action("ApproveAdvance", "Adv")",
                        type: "POST",
                        contentType: "application/json",
                        data: jsonString,
                        success: function (response) {
                            if (response) {
                                ShowMessage("Approve Completed!");
                                ShowData($('#txtBranchCode').val(), $('#txtAdvNo').val());
                            } else {
                                ShowMessage("Cannot Approve");
                            }
                            return;
                        },
                        error: function (e) {
                            ShowMessage(e);
                            return;
                        }
                    });
                    return;
                }
            } else {
                if ($('#cboDocStatus').val().substr(0, 2) == '02') {
                    $('#cboDocStatus').val('01');
                }
            }
            $('#txtApproveBy').val(chkmode ? user : '');
            $('#txtApproveDate').val(chkmode ? CDateEN(GetToday()) : '');
            $('#txtApproveTime').val(chkmode ? ShowTime(GetTime()) : '');
            return;
        }
        ShowMessage('You are not allow to ' + (b ? 'approve Advance!' : 'cancel approve!'));
        $('#chkApprove').prop('checked', !chkmode);
    }
    function GetStatus() {
        let status = 1;
        if ($('#txtPaymentBy').val() !== '') {
            status = 3;
        } else if ($('#txtApproveBy').val() !== '') {
            status = 2;
        }
        return status;
    }
    function SetCancel(b) {
        if (b == true) {
            ShowConfirm("Do you want to " + (chkmode ? 'cancel' : 're-open') + "?", function (result) {
                if (result == true) {
                    $('#cboDocStatus').val(chkmode ? '99' : GetStatus());
                    $('#txtCancelProve').val(chkmode ? user : '');
                    $('#txtCancelDate').val(chkmode ? CDateEN(GetToday()) : '');
                    $('#txtCancelTime').val(chkmode ? ShowTime(GetTime()) : '');
                    return;
                }
                $('#chkCancel').prop('checked', !chkmode);
            });
            return;
        }
        ShowMessage('You are not allow to ' + (b ? 'cancel Advance!' : 'do this!'));
        $('#chkCancel').prop('checked', !chkmode);
    }
    function SetLOVs() {
        //Combos
        let lists = 'JOB_TYPE=#cboJobType';
        lists += ',SHIP_BY=#cboShipBy';
        lists += ',ADV_STATUS=#cboDocStatus';
        lists += ',ADV_TYPE=#cboAdvType';

        loadCombos(path, lists);
        loadServiceGroup(path, '#cboSTCode',true);
        LoadService();        

        //3 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name,desc1,desc2', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv, '#frmSearchCust', '#tbCust', 'Customers', response, 3);
            //Payment
            CreateLOV(dv, '#frmSearchPay', '#tbPay', 'Payment Bills', response, 5);
            //Venders
            CreateLOV(dv, '#frmSearchVend', '#tbVend', 'Venders', response,4);
            //Job
            CreateLOV(dv, '#frmSearchJob', '#tbJob', 'Job List', response, 3);
            //Users
            CreateLOV(dv, '#frmSearchAdv', '#tbAdv', 'Advance By', response,4);
            CreateLOV(dv, '#frmSearchReq', '#tbReq', 'Request By', response,4);
            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response,4);
            //SICode
            CreateLOV(dv, '#frmSearchSICode', '#tbServ', 'Service Code', response,4);
            //Currency
            CreateLOV(dv, '#frmSearchSubCur', '#tbSubCur', 'Currency Code', response,4);
            CreateLOV(dv, '#frmSearchExpCur', '#tbExpCur', 'Currency Code', response,4);
        });
    }
    function ShowData(branchcode, advno) {
        if (branchcode == '') {
            //ShowMessage('Please select branch');
            return;
        }
        if (advno == '') {
            //ShowMessage('Please enter advance no');
            return;
        }
        if (userRights.indexOf('R') < 0) {
            ShowMessage('you are not authorize to view data');
            return;
        }
        $.get(path + 'adv/getadvance?branchcode='+branchcode+'&advno='+ advno, function (r) {
            let h = r.adv.header[0];
            ReadAdvHeader(h);
            let d = r.adv.detail;
            ReadAdvDetail(d);
        });
    }
    function PrintData() {
        if (userRights.indexOf('P') < 0) {
            ShowMessage('you are not authorize to print');
            return;
        }
        window.open(path + 'Adv/FormAdv?branch=' + $('#txtBranchCode').val() + '&advno=' + $('#txtAdvNo').val());
    }
    function SaveHeader() {
        if (hdr != undefined) {
            let obj = GetDataHeader(hdr);
            if (obj.AdvNo == '') {
                if (userRights.indexOf('I') < 0) {
                    ShowMessage('you are not authorize to add');
                    return;
                }
            }
            if (userRights.indexOf('E') < 0) {
                ShowMessage('you are not authorize to save');
                return;
            }
            if (Number($('#txtTotalAmount').val())!==Number(SumTotal())) {
                if (Number($('#txtTotalAmount').val()) > 0) {
                    if (Number(SumTotal()) == 0) {
                        $('#chkCash').checked = true;
                    } else {
                        ShowMessage('Total not balance,Please check on payment total');
                        return;
                    }                    
                }
            }
            if ($('#cboJobType').val() == 0) {
                ShowMessage('please select job type');
                $('#cboJobType').focus();
                return;
            }
            if ($('#cboShipBy').val() == 0) {
                ShowMessage('please select ship by');
                $('#cboShipBy').focus();
                return;
            }
            if ($('#cboAdvType').val() == 0) {
                ShowMessage('please select advance type');
                $('#cboAdvType').focus();
                return;
            }
            let jsonString = JSON.stringify({ data: obj });
            //ShowMessage(jsonString);
            $.ajax({
                url: "@Url.Action("SaveAdvanceHeader", "Adv")",
                type: "POST",
                contentType: "application/json",
                data: jsonString,
                success: function (response) {                
                    ShowMessage(response.result.msg);
                    if (response.result.data !== null) {
                        $('#txtAdvNo').val(response.result.data);
                        ShowData($('#txtBranchCode').val(), $('#txtAdvNo').val());
                    }
                },
                error: function (e) {
                    ShowMessage(e);
                }
            });
            return;
        }
        ShowMessage('No data to save');
    }
    function GetDataHeader() {
        let dt = {
            BranchCode : $('#txtBranchCode').val(),
            AdvNo : $('#txtAdvNo').val(),
            AdvDate : CDateTH($('#txtAdvDate').val()),
            EmpCode : $('#txtReqBy').val(),
            AdvBy : $('#txtAdvBy').val(),
            CustCode : $('#txtCustCode').val(),
            CustBranch : $('#txtCustBranch').val(),
            Doc50Tavi : $('#txtDoc50Tavi').val(),
            PaymentNo : $('#txtPaymentNo').val(),
            TRemark : $('#txtTRemark').val(),

            CancelProve : $('#txtCancelProve').val(),
            CancelReson : $('#txtCancelReson').val(),
            CancelDate : CDateTH($('#txtCancelDate').val()),
            CancelTime : $('#txtCancelTime').val(),

            PaymentBy : $('#txtPaymentBy').val(),
            PaymentDate : CDateTH($('#txtPaymentDate').val()),
            PaymentTime : $('#txtPaymentTime').val(),
            PaymentRef : $('#txtPaymentRef').val(),

            ApproveBy : $('#txtApproveBy').val(),
            ApproveDate : CDateTH($('#txtApproveDate').val()),
            ApproveTime : $('#txtApproveTime').val(),

            AdvCash : CNum($('#txtAdvCash').val()),
            AdvChq : CNum($('#txtAdvChq').val()),
            AdvChqCash : CNum($('#txtAdvChqCash').val()),
            AdvCred : CNum($('#txtAdvCred').val()),

            TotalAdvance : CNum($('#txtTotalAmount').val()),
            TotalVAT : CNum($('#txtVatAmount').val()),
            Total50Tavi : CNum($('#txtWhtAmount').val()),

            JobType : $('#cboJobType').val(),
            ShipBy : $('#cboShipBy').val(),
            AdvType : $('#cboAdvType').val(),
            DocStatus: $('#cboDocStatus').val(),

            JNo: null,
            InvNo: null,
            VATRate: 0,
            PayChqTo: null,
            PayChqDate: '',

            MainCurrency: $('#txtMainCurrency').val(),
            SubCurrency: $('#txtSubCurrency').val(),
            ExchangeRate: $('#txtExchangeRate').val()
        };

        return dt;
    }
    function ReadAdvHeader(dt) {
        if (dt != undefined) {
            ClearHeader();
            hdr = dt;
            $('#txtBranchCode').val(dt.BranchCode);
            $('#txtAdvNo').val(dt.AdvNo);
            $('#txtAdvDate').val(CDateEN(dt.AdvDate));
            $('#txtAdvBy').val(dt.AdvBy);
            $('#txtReqBy').val(dt.EmpCode);
            if (isjobmode == false) {
                $('#txtCustCode').val(dt.CustCode);
                $('#txtCustBranch').val(dt.CustBranch);
                $('#cboJobType').val(CCode(dt.JobType));
                $('#cboShipBy').val(CCode(dt.ShipBy));
                ShowCustomer(path, $('#txtCustCode').val(), $('#txtCustBranch').val(), '#txtCustName');
            }
            $('#txtDoc50Tavi').val(dt.Doc50Tavi);
            $('#txtPaymentNo').val(dt.PaymentNo);
            $('#txtTRemark').val(dt.TRemark);

            $('#txtCancelProve').val(dt.CancelProve);
            $('#txtCancelReson').val(dt.CancelReson);
            $('#txtCancelDate').val(CDateEN(dt.CancelDate));
            $('#txtCancelTime').val(ShowTime(dt.CancelTime));

            $('#txtPaymentBy').val(dt.PaymentBy);
            $('#txtPaymentDate').val(CDateEN(dt.PaymentDate));
            $('#txtPaymentTime').val(ShowTime(dt.PaymentTime));
            $('#txtPaymentRef').val(dt.PaymentRef);

            $('#txtApproveBy').val(dt.ApproveBy);
            $('#txtApproveDate').val(CDateEN(dt.ApproveDate));
            $('#txtApproveTime').val(ShowTime(dt.ApproveTime));

            $('#txtAdvCash').val(CDbl(dt.AdvCash,4));
            $('#txtAdvChq').val(CDbl(dt.AdvChq, 4));
            $('#txtAdvChqCash').val(CDbl(dt.AdvChqCash,4));
            $('#txtAdvCred').val(CDbl(dt.AdvCred,4));

            $('#txtAdvAmount').val(CDbl(dt.TotalAdvance-dt.TotalVAT+dt.Total50Tavi,4));
            $('#txtVatAmount').val(CDbl(dt.TotalVAT,4));
            $('#txtWhtAmount').val(CDbl(dt.Total50Tavi,4));
            $('#txtTotalAmount').val(CDbl((dt.TotalAdvance),4));

            $('#chkCancel').prop('checked', $('#txtCancelProve').val() == '' ? false : true);
            $('#chkApprove').prop('checked', $('#txtApproveBy').val() == '' ? false : true);
            $('#chkPayment').prop('checked', $('#txtPaymentBy').val() == '' ? false : true);

            $('#chkCash').prop('checked', dt.AdvCash > 0 ? true : false);
            $('#chkChq').prop('checked', dt.AdvChq > 0 ? true : false);
            $('#chkChqCash').prop('checked', dt.AdvChqCash > 0 ? true : false);
            $('#chkCred').prop('checked', dt.AdvCred > 0 ? true : false);

            $('#txtMainCurrency').val(dt.MainCurrency);
            $('#txtSubCurrency').val(dt.SubCurrency);
            $('#txtExchangeRate').val(CDbl(dt.ExchangeRate,4));
            //Combos
            $('#cboAdvType').val(CCode(dt.AdvType));
            $('#cboDocStatus').val(CCode(dt.DocStatus));

            ShowUser(path, $('#txtAdvBy').val(), '#txtAdvName');
            ShowUser(path, $('#txtReqBy').val(), '#txtReqName');

            ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');

            if (dt.DocStatus > 2) {
                //if document is paymented/cancelled/cleared then disable save button
                $('#chkApprove').attr('disabled', 'disabled');
                $('#txtApproveDate').attr('disabled', 'disabled');
                $('#txtApproveBy').attr('disabled', 'disabled');
                $('#txtApproveTime').attr('disabled', 'disabled');

                $('#chkPayment').attr('disabled', 'disabled');
                $('#txtPaymentDate').attr('disabled', 'disabled');
                $('#txtPaymentBy').attr('disabled', 'disabled');
                $('#txtPaymentTime').attr('disabled', 'disabled');
                $('#txtPaymentRef').attr('disabled', 'disabled');

                $('#chkCancel').attr('disabled', 'disabled');
                $('#txtCancelDate').attr('disabled', 'disabled');
                $('#txtCancelBy').attr('disabled', 'disabled');
                $('#txtCancelTime').attr('disabled', 'disabled');

                $('#btnSave').attr('disabled', 'disabled');
                $('#btnUpdate').attr('disabled', 'disabled');
                $('#btnDel').attr('disabled', 'disabled');
            } else {
                //if document approved by this user or not then check authorized to unlock 
                if (dt.DocStatus == 2 && user == dt.ApproveBy && userRights.indexOf('E') >= 0) {
                    $('#txtApproveDate').removeAttr('disabled');
                    $('#txtApproveBy').removeAttr('disabled');
                    $('#txtApproveTime').removeAttr('disabled');
                    $('#chkApprove').removeAttr('disabled');

                    $('#btnSave').removeAttr('disabled');
                    $('#btnDel').removeAttr('disabled');
                    $('#btnUpdate').removeAttr('disabled');
                } else {
                    if (dt.DocStatus == 2) {
                        $('#chkApprove').attr('disabled', 'disabled');
                        $('#txtApproveDate').attr('disabled', 'disabled');
                        $('#txtApproveBy').attr('disabled', 'disabled');
                        $('#txtApproveTime').attr('disabled', 'disabled');

                        $('#btnSave').attr('disabled', 'disabled');
                        $('#btnUpdate').attr('disabled', 'disabled');
                        $('#btnDel').attr('disabled', 'disabled');
                    } 
                }
            }                
            return;
        } 
        ClearHeader();
    }
    function AddHeader() {
        if (userRights.indexOf('I') < 0) {
            ShowMessage('you are not authorize to add');
            return;
        }
        $('#txtAdvNo').val('');
        $.get(path + 'adv/getnewadvanceheader?branchcode=' + $('#txtBranchCode').val() , function (r) {
            let h = r.adv.header;
            ReadAdvHeader(h);
            if (isjobmode == false) {
                $('#cboJobType').val('');
                $('#cboShipBy').val('');
            }
            $('#cboDocStatus').val('01');
            $('#cboAdvType').val('01');
            $('#txtAdvBy').val(user);
            $('#txtMainCurrency').val('@ViewBag.PROFILE_CURRENCY');
            $('#txtSubCurrency').val('@ViewBag.PROFILE_CURRENCY');
            $('#txtExchangeRate').val(1);
            $('#txtExcRate').val(1);

            ShowUser(path, $('#txtAdvBy').val(), '#txtAdvName');
            let d = r.adv.detail;
            ReadAdvDetail(d);
            ClearDetail();
            $('#txtAdvNo').focus();
        });
    }
    function AddDetail() {
        if ($('#txtAdvNo').val() == '') {
            ShowMessage('Please save document before add detail');
            return;
        }
        $.get(path + 'adv/getnewadvancedetail?branchcode=' + $('#txtBranchCode').val() + '&advno=' + $('#txtAdvNo').val(), function (r) {
            let d = r.adv.detail[0];
            LoadDetail(d);
            $('#txtSICode').attr('disabled', 'disabled');
            $('#txtSDescription').attr('disabled', 'disabled');

            $('#frmDetail').modal('show');
            $('#txtCurrencyCode').val($('#txtSubCurrency').val());
            $('#txtExcRate').val($('#txtExchangeRate').val());
            $('#txtSICode').focus();
        });
    }
    function DeleteDetail() {
        if (dtl != undefined) {
            if (userRights.indexOf('D') < 0) {
                ShowMessage('you are not authorize to delete');
                return;
            }
            $.get(path + 'adv/deladvancedetail?branchcode=' + $('#txtBranchCode').val() + '&advno=' + $('#txtAdvNo').val() + '&itemno=' + dtl.ItemNo, function (r) {
                ShowMessage(r.adv.result);
                ShowData($('#txtBranchCode').val(), $('#txtAdvNo').val());
            });
        } else {
            ShowMessage('No data to delete');
        }
    }
    function ClearHeader() {
        hdr = {};
        $('#txtAdvDate').val(GetToday());
        $('#txtAdvBy').val(user);
        $('#txtReqBy').val('');
        if (isjobmode == false) {
            $('#txtCustCode').val('');
            $('#txtCustBranch').val('');
            $('#cboJobType').val('');
            $('#cboShipBy').val('');
            ShowCustomer(path, '', $('#txtCustBranch').val(), '#txtCustName');
        }
        $('#txtDoc50Tavi').val('');
        $('#txtPaymentNo').val('');
        $('#txtTRemark').val('');

        $('#txtCancelProve').val('');
        $('#txtCancelReson').val('');
        $('#txtCancelDate').val('');
        $('#txtCancelTime').val('');

        $('#txtPaymentBy').val('');
        $('#txtPaymentDate').val('');
        $('#txtPaymentTime').val('');
        $('#txtPaymentRef').val('');

        $('#txtApproveBy').val('');
        $('#txtApproveDate').val('');
        $('#txtApproveTime').val('');

        $('#txtAdvCash').val('');
        $('#txtAdvChq').val('');
        $('#txtAdvChqCash').val('');
        $('#txtAdvCred').val('');

        $('#txtAdvAmount').val('');
        $('#txtVatAmount').val('');
        $('#txtWhtAmount').val('');
        $('#txtTotalAmount').val('');

        $('#chkCancel').prop('checked', $('#txtCancelProve').val() == '' ? false : true);
        $('#chkApprove').prop('checked', $('#txtApproveBy').val() == '' ? false : true);
        $('#chkPayment').prop('checked', $('#txtPaymentBy').val() == '' ? false : true);

        $('#chkCash').prop('checked', true);
        $('#chkChq').prop('checked', false);
        $('#chkChqCash').prop('checked', false);
        $('#chkCred').prop('checked', false);

        //Combos
        $('#cboAdvType').val('01');
        $('#cboDocStatus').val('01');

        ShowUser(path, $('#txtAdvBy').val(), '#txtAdvName');
        ShowUser(path, '', '#txtReqName');

        $('#chkApprove').removeAttr('disabled');
        $('#chkCancel').removeAttr('disabled');

        $('#btnPrint').attr('disabled', 'disabled');
        $('#txtAdvCash').attr('disabled', 'disabled');
        $('#txtAdvChq').attr('disabled', 'disabled');
        $('#txtAdvChqCash').attr('disabled', 'disabled');
        $('#txtAdvCred').attr('disabled', 'disabled');
        $('#btnAdd').attr('disabled', 'disabled');
        $('#btnDel').attr('disabled', 'disabled');
        $('#btnSave').attr('disabled', 'disabled');
        $('#btnUpdate').attr('disabled', 'disabled');

        if (userRights.indexOf('E') >= 0){
            $('#btnSave').removeAttr('disabled');
            $('#btnUpdate').removeAttr('disabled');
        }
        if (userRights.indexOf('I') >= 0) {
            $('#btnSave').removeAttr('disabled');
            $('#btnUpdate').removeAttr('disabled');
            $('#btnAdd').removeAttr('disabled');    
        }
        if (userRights.indexOf('D') >= 0) {
            $('#btnDel').removeAttr('disabled');    
        }        
        if (userRights.indexOf('P') >= 0) {
            $('#btnPrint').removeAttr('disabled');
        }        
    }
    function SaveDetail() {

        if (hdr == undefined) {
            ShowMessage('Please add header before');
            return;
        }
        if (hdr.AdvNo == '') {
            ShowMessage('Please save header first');
            return;
        }
        if (dtl != undefined) {
            let obj = GetDataDetail();
            if (obj.ItemNo == 0) {
                if (userRights.indexOf('I') < 0) {
                    ShowMessage('you are not authorize to add');
                    return;
                }
            }
            if (userRights.indexOf('E') < 0) {
                ShowMessage('you are not authorize to edit');
                return;
            }
            if (CheckDuplicate(obj) == true) {
                ShowMessage('This data is duplicate!');
                return;
            }
            let jsonString = JSON.stringify({ data: obj });
            //ShowMessage(jsonString);
            $.ajax({
                url: "@Url.Action("SaveAdvanceDetail", "Adv")",
                type: "POST",
                contentType: "application/json",
                data: jsonString,
                success: function (response) {                
                    ShowMessage(response.result.msg);
                    ShowData($('#txtBranchCode').val(), $('#txtAdvNo').val());
                }
            });
            return;
        }
        ShowMessage('No data to save');
    }
    function CheckDuplicate(o) {
        let rows = $('#tbDetail').DataTable().rows().data();
        let filter = rows.filter(function (row) {
            return CStr(row.ForJNo) == o.ForJNo && row.SICode == o.SICode && Number(row.ItemNo)!==Number(o.ItemNo);
        });
        return (filter.length > 0);
    }
    function ReadAdvDetail(dt) {
        $('#tbDetail').DataTable({
            data:dt,
            selected: true, //ให้สามารถเลือกแถวได้
            columns: [ //กำหนด property ของ header column
                { data: null, title: "Edit" },
                { data: "SICode", title: "Service" },
                { data: "SDescription", title: "Description" },
                { data: "ForJNo", title: "Job" },
                { data: "CurrencyCode", title: "Currency" },
                { data: "ExchangeRate", title: "Rate" },
                { data: "AdvQty", title: "Qty" },
                { data: "UnitPrice", title: "Price" },
                { data: "AdvAmount", title: "Amount" },
                { data: "ChargeVAT", title: "VAT" },
                { data: "Charge50Tavi", title: "WH-Tax" },
                { data: "AdvNet", title: "Net" }
            ],
            "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                {
                    "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                    "data": null,
                    "render": function (data, type, full, meta) {
                        let html = "<button class='btn btn-warning'>Edit</button>";
                        return html;
                    }
                }
            ],
            responsive:true,
            destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
        });
        $('#tbDetail tbody').on('click', 'tr', function () {
            $('#tbDetail tbody > tr').removeClass('selected');
            $(this).addClass('selected');            
            let data = $('#tbDetail').DataTable().row(this).data(); //read current row selected
            LoadDetail(data); //callback function from caller 
        });
        $('#tbDetail tbody').on('click', 'button', function () {
            $('#frmDetail').modal('show');
            $('#txtSICode').focus();
        });
    }
    function GetAdvDetail(list) {
        let rows = [];
        let header = list.header[0];
        for (let row of list.detail) {
            let dt = {
                BranchCode : $('#txtBranchCode').val(),
                AdvNo : $('#txtAdvNo').val(),
                ItemNo : 0,
                SICode : row.SICode,
                STCode : 'EXP',
                ForJNo : row.ForJNo,
                TRemark : row.SRemark,
                Doc50Tavi : '',
                PayChqTo : '',
                SDescription : row.SDescription,
                IsChargeVAT : row.IsTaxCharge,
                VATRate: header.VATRate,
                Is50Tavi: row.Is50Tavi,
                Rate50Tavi : header.TaxRate,
                AdvAmount : CDbl(CNum(row.Amt/header.ExchangeRate),2),
                ChargeVAT : CDbl(CNum(row.AmtVAT/header.ExchangeRate),2),
                Charge50Tavi : CDbl(CNum(row.AmtWHT/header.ExchangeRate),2),
                AdvNet: row.FTotal,
                AdvQty: row.Qty,
                UnitPrice: row.UnitPrice,
                CurrencyCode: header.CurrencyCode,
                ExchangeRate: header.ExchangeRate,
                VenCode: header.VenCode,
                IsDuplicate: 0
            };
            rows.push(dt);    
        }
        return rows;
    }
    function GetDataDetail() {
        let dt = {
            BranchCode : $('#txtBranchCode').val(),
            AdvNo : $('#txtAdvNo').val(),
            ItemNo : $('#txtItemNo').val(),
            SICode : $('#txtSICode').val(),
            STCode : $('#cboSTCode').val(),
            ForJNo : $('#txtForJNo').val(),
            TRemark : $('#txtRemark').val(),
            Doc50Tavi : $('#txt50Tavi').val(),
            PayChqTo : $('#txtPayChqTo').val(),
            SDescription : $('#txtSDescription').val(),
            IsChargeVAT : $('#txtVatType').val(),
            VATRate: $('#txtVATRate').val(),
            Is50Tavi: ($('#txtWHTRate').val() >0? 1:0),
            Rate50Tavi : $('#txtWHTRate').val(),
            AdvAmount : $('#txtAMT').val(),
            ChargeVAT : $('#txtVAT').val(),
            Charge50Tavi : $('#txtWHT').val(),
            AdvNet: $('#txtNET').val(),
            AdvQty: $('#txtAdvQty').val(),
            UnitPrice: $('#txtUnitPrice').val(),
            CurrencyCode: $('#txtCurrencyCode').val(),
            ExchangeRate: $('#txtExcRate').val(),
            VenCode: $('#txtVenCode').val(),
            IsDuplicate: ($('#chkDuplicate').prop('checked')==true? 1:0)
        };
        return dt;
    }
    function LoadDetail(dt) {        
        if (dt != undefined) {
            ClearDetail();
            dtl = dt;
            $('#txtItemNo').val(dt.ItemNo);
            $('#txtSICode').val(dt.SICode);
            $('#cboSTCode').val(dt.STCode);
            $('#cboSTCode').change();
            //let r = FindService($('#txtSICode').val())
            //ReadService(r);
            $('#txtSDescription').val(dt.SDescription);
            if (isjobmode == false) {
                $('#txtForJNo').val(dt.ForJNo);
                $('#txtInvNo').val('');
                if ($('#txtForJNo').val()!= '') {
                    ShowInvNo(path, $('#txtBranchCode').val(), $('#txtForJNo').val(), '#txtInvNo');
                }
            }                
            $('#txtAdvQty').val(dt.AdvQty);
            $('#txtExcRate').val(dt.ExchangeRate);
            $('#txtUnitPrice').val(dt.UnitPrice);
            CalAmount();
            $('#txtRemark').val(dt.TRemark);
            $('#txt50Tavi').val(dt.Doc50Tavi);
            $('#txtPayChqTo').val(dt.PayChqTo);
            $('#txtSDescription').val(dt.SDescription);
            $('#txtVatType').val(dt.IsChargeVAT);
            $('#txtVATRate').val(dt.VATRate);
            $('#txtWHTRate').val(dt.Rate50Tavi);
            $('#txtAMT').val(dt.AdvAmount);
            $('#txtVAT').val(dt.ChargeVAT);
            $('#txtWHT').val(dt.Charge50Tavi);
            $('#txtNET').val(dt.AdvNet);
            $('#txtVenCode').val(dt.VenCode);
            $('#chkDuplicate').prop('checked', dt.IsDuplicate > 0 ? true : false);
            $('#txtCurrencyCode').val(dt.CurrencyCode);
            ShowCurrency(path, $('#txtCurrencyCode').val(), '#txtCurrencyName');
            ShowCaption();
            return;
        }
        ClearDetail();
    }
    function ClearDetail() {
        dtl = {};
        $('#txtItemNo').val('0');
        $('#txtSICode').val('');
        $('#cboSTCode').val('');
        $('#chkDuplicate').prop('checked', true);
        if (isjobmode == false) {
            $('#txtForJNo').val('');
            $('#txtInvNo').val('');
        }            
        $('#txtRemark').val('');
        $('#txt50Tavi').val('');
        $('#txtPayChqTo').val('');
        $('#txtSDescription').val('');
        $('#txtVatType').val('1');
        $('#txtVATRate').val('');
        $('#txtWHTRate').val('');
        $('#txtAMT').val(0);
        $('#txtVAT').val(0);
        $('#txtWHT').val(0);
        $('#txtNET').val(0);
        $('#txtAMTCal').val(0);
        $('#txtAdvQty').val(1);
        $('#txtExcRate').val($('#txtExchangeRate').val());
        $('#txtUnitPrice').val('');
        $('#txtCurrencyCode').val($('#txtSubCurrency').val());
        ShowCurrency(path, $('#txtSubCurrency').val(), '#txtCurrencyName');
        ShowCaption();
        $('#txtDetCurrency').val($('#txtMainCurrency').val());
        $('#txtVenCode').val('');

        $('#chkDuplicate').prop('checked', true);
        $('#txtAMT').removeAttr('disabled');
        $('#txtVATRate').removeAttr('disabled');
        $('#txtWHTRate').removeAttr('disabled');
        $('#txtVAT').removeAttr('disabled');
        $('#txtWHT').removeAttr('disabled');
    }
    function LoadService() {
        if (serv.length==0) {
            $.get(path + 'master/getservicecode')
                .done(function (r) {
                    if (r.servicecode.data.length > 0) {
                        serv = r.servicecode.data;
                    }
                });
        }
    }
    function FindService(Code) {
        let c = $.grep(serv, function (data) {
            return data.SICode === Code;
        });
        return c[0];
    }
    function SetGridAdv() {
        let w = $('#txtBranchCode').val();
        if (job.length > 0) {
            w += '&jobno=' + job;
        } else {
            if ($('#txtCustCode').val()!=='') {
                w += '&custcode=' + $('#txtCustCode').val();
            }
            if ($('#txtCustBranch').val() !== '') {
                w += '&custbranch=' + $('#txtCustBranch').val();
            }
            if ($('#cboJobType').val() !== '') {
                w += '&jtype=' + $('#cboJobType').val();
            }
            if ($('#cboShipBy').val() !== '') {
                w += '&sby=' + $('#cboShipBy').val();
            }
        }
        if ($('#txtReqBy').val() !== '') {
            w += '&reqby=' + $('#txtReqBy').val();
        }
        $.get(path + 'adv/getadvancegrid?branchcode=' +  w, function (r) {
            if (r.adv.data.length == 0) {
                ShowMessage('data not found on this branch');
                return;
            }
            let h = r.adv.data[0].Table;
            $('#tbHeader').DataTable({
                data: h,
                selected: true, //ให้สามารถเลือกแถวได้
                columns: [ //กำหนด property ของ header column
                    { data: "AdvNo", title: "Advance No" },
                    {
                        data: "AdvDate", title: "Date",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "CustCode", title: "Customer" },
                    { data: "EmpCode", title: "Request By" },
                    { data: "JobNo", title: "Job Number" },
                    { data: "CustInvNo", title: "Cust Inv" },
                    { data: "DocStatus", title: "Status" },
                    { data: "TotalAdvance", title: "Total" },
                    { data: "Total50Tavi", title: "W/T" },
                    { data: "Doc50Tavi", title: "W/T No" },
                    { data: "PaymentNo", title: "A/P No" },
                    {
                        data: null, title: "Request Amt",
                        render: function (data) {
                            return CDbl(Number(data.AdvCash) + Number(data.AdvChqCash) + Number(data.AdvChq) + Number(data.AdvCred), 2) + '' + data.SubCurrency;
                        }
                    },
                ],
                responsive:true,
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            });
            $('#tbHeader tbody').on('click', 'tr', function () {
                $('#tbHeader tbody > tr').removeClass('selected');
                $(this).addClass('selected');
                let data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                ShowData(data.BranchCode, data.AdvNo); //callback function from caller 
                $('#frmHeader').modal('hide');
            });
            $('#frmHeader').on('shown.bs.modal', function () {
                $('#tbHeader_filter input').focus();
            });
            $('#frmHeader').modal('show');
        });

    }
    function SearchData(type) {
        switch (type) {
            case 'advance':
                SetGridAdv();
                break;
            case 'payment':
                SetGridPayment(path, '#tbPay', '?branch='+ $('#txtBranchCode').val() +'&type=NOPAY', '#frmSearchPay', ReadPayment);
                break;
            case 'branch':
                SetGridBranch(path, '#tbBranch', '#frmSearchBranch', ReadBranch);
                break;
            case 'advby':
                SetGridUser(path, '#tbAdv', '#frmSearchAdv', ReadAdvBy);
                break;
            case 'reqby':
                SetGridUser(path, '#tbReq', '#frmSearchReq', ReadReqBy);
                break;
            case 'customer':
                SetGridCompany(path, '#tbCust', '#frmSearchCust', ReadCustomer);
                break;
            case 'servicecode':
                SetGridSICodeByGroup(path, '#tbServ', $('#cboSTCode').val(), '#frmSearchSICode', ReadService);
                break;
            case 'job':
                SetGridJob(path, '#tbJob', '#frmSearchJob', GetParam(), ReadJob);
                break;
            case 'subcurrency':
                SetGridCurrency(path, '#tbSubCur', '#frmSearchSubCur', ReadCurrencyH);
                break;
            case 'detcurrency':
                SetGridCurrency(path, '#tbExpCur', '#frmSearchExpCur', ReadCurrencyD);
                break;
            case 'vender':
                SetGridVender(path, '#tbVend', '#frmSearchVend', ReadVender);
                break;
        }
    }
    function GetParam() {
        let strParam = '?Status=0,1,2,3,4,5,6';
        strParam += '&Branch=' + $('#txtBranchCode').val();
        strParam += '&JType=' + $('#cboJobType').val().substr(0, 2);
        strParam += '&SBy=' + $('#cboShipBy').val().substr(0, 2);
        strParam += '&CustCode=' + $('#txtCustCode').val();
        return strParam;
    }
    function ShowCaption() {
        $('#lblUnitPrice').text("Price (" + $('#txtCurrencyCode').val() + "):");
        $('#lblAMTCal').text("Amount (" + $('#txtCurrencyCode').val() + "):");
        $('#lblAmount').text("Amount (" + $('#txtMainCurrency').val() + "):");
        $('#lblVATRate').text("VAT (" + $('#txtMainCurrency').val() + "):");
        $('#lblWHTRate').text("WHT (" + $('#txtMainCurrency').val() + "):");
        $('#lblNETAmount').text("Net (" + $('#txtMainCurrency').val() + "):");
    }
    function ReadVender(dt) {
        $('#txtVenCode').val(dt.VenCode);
        $('#txtPayChqTo').val(dt.TName);
        $('#txtPayChqTo').focus();
    }
    function ReadCurrencyD(dt) {
        $('#txtCurrencyCode').val(dt.Code);
        $('#txtCurrencyName').val(dt.TName);
        $('#txtExcRate').val(0);
        CalAmount();
        ShowCaption();
        $('#txtExcRate').focus();
    }
    function ReadCurrencyH(dt) {
        $('#txtSubCurrency').val(dt.Code);
        $('#txtExchangeRate').focus();
    }
    function ReadAdvBy(dt) {
        $('#txtAdvBy').val(dt.UserID);
        $('#txtAdvName').val(dt.TName);
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
    function ReadService(dt) {
        if (dt != undefined) {
            $('#txtSICode').val(dt.SICode);
            $('#cboSTCode').val(dt.GroupCode);
            $('#cboSTCode').change();
            $('#txtSDescription').val(dt.NameThai);
            $('#txtVatType').val(dt.IsTaxCharge);
            $('#txtVATRate').val(dt.IsTaxCharge == "0" ? "0" : CDbl(@ViewBag.PROFILE_VATRATE*100,0));
            $('#txtWHTRate').val(dt.Is50Tavi == "0" ? "0" : dt.Rate50Tavi);
            if (CNum($('#txtUnitPrice').val) == 0) {
                $('#txtUnitPrice').val(dt.StdPrice);
                CalAmount();            
            }
            if (dt.IsTaxCharge == "2") {
                $('#txtAMT').attr('disabled', 'disabled');
                $('#txtVAT').attr('disabled', 'disabled');
                $('#txtWHT').attr('disabled', 'disabled');
            } else {
                $('#txtAMT').removeAttr('disabled');
                $('#txtVAT').removeAttr('disabled');
                $('#txtWHT').removeAttr('disabled');
            }
            CalVATWHT();
            return;
        }
        $('#txtSDescription').val('');
        $('#txtVatType').val(1);
        $('#txtVATRate').val(0);
        $('#txtWHTRate').val(0);
        $('#txtAMT').removeAttr('disabled');
        $('#txtVATRate').removeAttr('disabled');
        $('#txtWHTRate').removeAttr('disabled');
        $('#txtVAT').removeAttr('disabled');
        $('#txtWHT').removeAttr('disabled');
        CalVATWHT();
    }
    function ReadJob(dt) {
        if (ShowDate(dt.CloseJobDate) !== '-') {
            ShowMessage('This job is closed,Please re-open first!');
            return;
        }
        $('#txtForJNo').val(dt.JNo);
        $('#txtInvNo').val(dt.InvNo);
    }
    function ReadPayment(dt) {
        SaveHeader();
        let docno = dt.DocNo;
        let branch = dt.BranchCode;
        $('#txtPaymentNo').val(docno);
        $.get(path + 'acc/getpayment?branch=' + branch + '&code=' + docno)
            .done(function (r) {
                if (r.payment.detail.length > 0) {
                    let dt = GetAdvDetail(r.payment);
                    SaveAdvFromPay(dt);
                }
            });
    }
    function SaveAdvFromPay(obj) {
        let jsonString = JSON.stringify({ data: obj });
        $.ajax({
            url: "@Url.Action("SetAdvDetail", "Adv")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {                
                ShowMessage(response.result.msg);
                ShowData($('#txtBranchCode').val(), $('#txtAdvNo').val());
            }
        });
        return;
    }
    function SumTotal() {
        let cash = CDbl($('#txtAdvCash').val(),4);
        let chq = CDbl($('#txtAdvChq').val(),4);
        let chqcash = CDbl($('#txtAdvChqCash').val(),4);
        let cred = CDbl($('#txtAdvCred').val(),4);
        return CDbl(Number(cash) + Number(chq) + Number(chqcash) + Number(cred),4);
    }
    function GetTotal() {
        let total = SumTotal();
        let sum = CNum($('#txtTotalAmount').val());
        return CDbl(sum / CNum($('#txtExchangeRate').val()) - total,4);
    }
    function CalAmount() {
        let price = CDbl($('#txtUnitPrice').val(),4);
        let qty = CDbl($('#txtAdvQty').val(),4);
        let rate = CDbl($('#txtExcRate').val(),4); //rate ของ detail
        let type = $('#txtVatType').val();
        if (qty > 0) {
            let amt = CNum(qty) * CNum(price);
            $('#txtAMTCal').val(CDbl(CNum(amt), 4));
            //let exc = CDbl($('#txtExchangeRate').val(), 4); //rate ของ header
            //let total = CDbl(CNum(amt) / CNum(exc),4);
            if (type == '0' || type == '') type = '1';
            if (type == '2') {
                //$('#txtNET').val(CDbl(CNum(total),4));
                $('#txtNET').val(CDbl(CNum(amt) * CNum(rate), 4));
            }
            if (type == '1') {
                //$('#txtAMT').val(CDbl(CNum(total),4));
                $('#txtAMT').val(CDbl(CNum(amt) * CNum(rate),4));
            }
            CalVATWHT();
        } else {
            $('#txtUnitPrice').val(0);
            $('#txtAMT').val(0);
            $('#txtNET').val(0);
            $('#txtVAT').val(0);
            $('#txtWHT').val(0);
        }
    }
    function CalTotal() {
        let amt = CDbl($('#txtAMT').val(),4);
        let vat = CDbl($('#txtVAT').val(),4);
        let wht = CDbl($('#txtWHT').val(),4);
        let net = CDbl($('#txtNET').val(),4);
        let type = $('#txtVatType').val();
        if (type == '0'||type=='') type = '1';
        if (type == '2') {
            $('#txtAMT').val(CDbl(CNum(net) - CNum(vat) + CNum(wht),4));
            $('#txtNET').val(CDbl(net,4));
        }
        if (type == '1') {
            $('#txtNET').val(CDbl(CNum(amt) + CNum(vat) - CNum(wht),4));
            $('#txtAMT').val(CDbl(amt,4));
        }
    }
    function CalVATWHT() {
        let type = $('#txtVatType').val();
        if (type == '' || type == '0') {
            type = '1';
            $('#txtVatType').val(type);
        }
        let amt = CDbl($('#txtAMT').val(),4);
        if (type == '2') {
            amt = CDbl($('#txtNET').val(),4);
        }
        let vatrate = CDbl($('#txtVATRate').val(),4);
        let whtrate = CDbl($('#txtWHTRate').val(),4);
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
        $('#txtVAT').val(CDbl(vat,4));
        $('#txtWHT').val(CDbl(wht,4));
        CalTotal();
    } 
    function GetExchangeRate() {
        $.get('https://free.currencyconverterapi.com/api/v6/convert?q=' + $('#txtSubCurrency').val() + '_' + $('#txtMainCurrency').val() + '&compact=ultra&apiKey=6210d55b79170a4a7da2', function (r) {
            let rate = CDbl(r[$('#txtSubCurrency').val() + '_' + $('#txtMainCurrency').val()], 4);
            $('#txtExchangeRate').val(rate);
        });
    }
    function AutoGenWHTax() {
        if ($('#txtDoc50Tavi').val() !== '') {
            window.open(path + 'Acc/WHTax?branch=' + $('#txtBranchCode').val() + '&code=' + $('#txtDoc50Tavi').val());
            return;
        }
        $.get(path + 'master/getcompany?Code=' + $('#txtCustCode').val() + '&Branch' + $('#txtCustBranch').val()).done(function (r) {
            let dr = r.company.data;
            if (dr.length > 0) {
                SaveWHTax(dr[0]);
            }
        });
    }
    function SaveWHTax(dt) {
        if ($('#btnSave').attr('disabled') == 'disabled') {
            ShowMessage('Cannot Save WH-Tax because document has been locked');
            return;
        }
        let obj = GetWHTaxHeader(dt);
        let jsonText = JSON.stringify({ data: obj });
        //ShowMessage(jsonText);
        $.ajax({
            url: "@Url.Action("SetWHTaxHeader", "Acc")",
            type: "POST",
            contentType: "application/json",
            data: jsonText,
            success: function (response) {
                if (response.result.data != null) {
                    SetWHTaxDetail(response.result.data);
                    ShowMessage(response.result.msg);
                    $('#txtDoc50Tavi').val(response.result.data);
                    $('#txtDoc50Tavi').focus();
                    return;
                }
                ShowMessage(response.result.msg);
            },
            error: function (e) {
                ShowMessage(e);
            }
        });
    }
    function SetWHTaxDetail(docno) {
        $.get(path + 'adv/getadvancedetail?branchcode=' + $('#txtBranchCode').val() + '&advno=' + $('#txtAdvNo').val(), function (r) {
            let dt = r.adv.detail.filter(function (data) {
                return data.Charge50Tavi > 0;
            });
            let i = 0;
            let j = 0;
            for (let d of dt) {
                i += 1;
                let obj={			
                    BranchCode:$('#txtBranchCode').val(),
                    DocNo:docno,
                    ItemNo:i,
                    IncType:14,
                    PayDate:CDateTH($('#txtAdvDate').val()),
                    PayAmount:d.AdvAmount,
                    PayTax:d.Charge50Tavi,
                    PayTaxDesc:d.SDescription,
                    JNo:d.ForJNo,
                    DocRefType:1,
                    DocRefNo:$('#txtAdvNo').val(),
                    PayRate:d.Rate50Tavi
                };

                SaveWHTaxDetail(obj);
            }
        });
    }
    function SaveWHTaxDetail(obj) {
        let jsonText = JSON.stringify({ data: obj });
        //ShowMessage(jsonText);
        $.ajax({
            url: "@Url.Action("SetWHTaxDetail", "Acc")",
            type: "POST",
            contentType: "application/json",
            data: jsonText,
            success: function (response) {
                if (response.result.data != null) {
                    j = response.result.data;
                    return;
                }                                
            },
            error: function (e) {
                ShowMessage(e);
            }
        });
    }
    function GetWHTaxHeader(dt) {
        let obj = {
            BranchCode: $('#txtBranchCode').val(),
            DocNo: '',
            DocDate: CDateTH($('#txtAdvDate').val()),
            TaxNumber1: dt.TaxNumber,
            TName1: dt.NameThai,
            TAddress1: dt.TAddress1 + ' ' +dt.TAddress2,
            TaxNumber2: '@ViewBag.PROFILE_TAXNUMBER',
            TName2: '@ViewBag.PROFILE_COMPANY_NAME',
            TAddress2: '@ViewBag.PROFILE_COMPANY_ADDR1' + '' + '@ViewBag.PROFILE_COMPANY_ADDR2',
            TaxNumber3: '',
            TName3: '',
            TAddress3: '',
            IDCard1: '',
            IDCard2: '',
            IDCard3: '',
            SeqInForm: 0,
            FormType: 7,
            TaxLawNo: 5,
            IncRate: 3,
            IncOther: '',
            UpdateBy: user,
            TotalPayAmount: 0,
            TotalPayTax: 0,
            SoLicenseNo: '',
            SoLicenseAmount: 0,
            SoAccAmount: 0,
            PayeeAccNo: '',
            SoTaxNo: '',
            PayTaxType: '',
            PayTaxOther: '',
            CancelProve: '',
            CancelReason: '',
            CancelDate: null,
            LastUpdate: CDateTH(GetToday()),
            TeacherAmt: 0,
            Branch1: '',
            Branch2: '',
            Branch3: ''
        };
        return obj;
    }



</script>