@Code
    ViewBag.Title = "Clearing Information"
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
                <b>Clearing No:</b>
                <br />
                <div style="display:flex;flex-direction:row">
                    <input type="text" class="form-control" id="txtClrNo" style="font-weight:bold;font-size:20px;text-align:center;background-color:navajowhite;color:brown" tabindex="1" />
                    <input type="button" class="btn btn-default" value="..." onclick="SearchData('clearing')" />
                </div>
            </div>
            <div class="col-sm-3">
                Document Date :
                <input type="date" class="form-control" id="txtClrDate" tabindex="1" disabled />
            </div>

        </div>
        <ul class="nav nav-tabs">
            <li class="active"><a data-toggle="tab" href="#tabHeader">Clearing Header</a></li>
            <li><a data-toggle="tab" href="#tabDetail">Clearing Detail</a></li>
        </ul>
        <div class="tab-content">
            <div id="tabHeader" class="tab-pane fade in active">
                <div class="row">
                    <div class="col-sm-7">
                        <table style="width:100%">
                            <tr>
                                <td>
                                    Clear By :
                                </td>
                                <td style="display:flex;flex-direction:row">
                                    <input type="text" id="txtEmpCode" class="form-control" style="width:100px" disabled />
                                    <button id="btnBrowseEmp1" class="btn btn-default" onclick="SearchData('clrby')" tabindex="2">...</button>
                                    <input type="text" id="txtEmpName" class="form-control" style="width:100%" disabled />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Clear Type :
                                </td>
                                <td>
                                    <select id="cboClrType" style="width:200px;" class="form-control dropdown"></select>
                                </td>
                            </tr>
                        </table>
                        <table style="width:100%">
                            <tr>
                                <td>
                                    Container No:
                                </td>
                                <td style="display:flex;flex-direction:row">
                                    <input type="text" id="txtCTN_NO" class="form-control" tabindex="6" />
                                </td>
                                <td>
                                    Clearance Date :
                                </td>
                                <td style="display:flex;flex-direction:row">
                                    <input type="date" id="txtClearanceDate" class="form-control" />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div class="col-sm-5">
                        <table style="width:100%">
                            <tr>
                                <td>
                                    Job Type :
                                </td>
                                <td style="display:flex;flex-direction:row">
                                    <select id="cboJobType" class="form-control dropdown" tabindex="8"></select>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Clear From :
                                </td>
                                <td style="display:flex;flex-direction:row">
                                    <select id="cboClrFrom" class="form-control dropdown" tabindex="9"></select>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Status :
                                </td>
                                <td style="display:flex;flex-direction:row">
                                    <select id="cboDocStatus" class="form-control dropdown" disabled></select>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-7">
                        Co-person Reference:<br/>
                        <div style="display:flex;flex-direction:row">
                            <input type="text" class="form-control" id="txtCoPersonCode" />
                        </div>
                        Remark:
                        <br />
                        <div style="display:flex;flex-direction:row">
                            <textarea id="txtTRemark" class="form-control" tabindex="11"></textarea>
                        </div>
                    </div>
                    <div class="col-sm-5">
                        <table>
                            <tr>
                                <td>
                                    <label>Advance Total</label>
                                </td>
                                <td style="display:flex;flex-direction:row">
                                    <input type="text" id="txtAdvTotal" class="form-control" style="width:100%;text-align:right" disabled />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label>Expenses Total</label>
                                </td>
                                <td style="display:flex;flex-direction:row">
                                    <input type="text" id="txtTotalExpense" class="form-control" style="width:100%;text-align:right" disabled />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label>Clear Total</label>
                                </td>
                                <td style="display:flex;flex-direction:row">
                                    <input type="text" id="txtClearTotal" class="form-control" style="width:100%;text-align:right" disabled />
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
                        <input type="checkbox" id="chkReceive" disabled />
                        <label for="chkReceive">Receive By</label>
                        <input type="text" id="txtReceiveBy" style="width:250px" disabled />
                        <br />
                        Date:
                        <input type="date" id="txtReceiveDate" disabled />
                        Time:
                        <input type="text" id="txtReceiveTime" style="width:80px" disabled />
                        <br />
                        R/V Ref:<input type="text" id="txtReceiveRef" style="width:200px" disabled />
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
                <a href="#" class="btn btn-default w3-purple" id="btnAdd" onclick="AddDetail()">
                    <i class="fa fa-lg fa-file-o"></i>&nbsp;<b>Add Detail</b>
                </a>
                <a href="#" class="btn btn-warning" id="btnChooseAdv" onclick="LoadAdvance()">
                    <i class="fa fa-lg fa-filter"></i>&nbsp;<b>Choose Advance</b>
                </a>
                <div class="row">
                    <div class="col-sm-12">
                        <table id="tbDetail" class="table table-responsive">
                            <thead>
                                <tr>
                                    <th>
                                    <th class="all">SICode</th>
                                    <th>Description</th>
                                    <th class="desktop">Job.No</th>
                                    <th class="desktop">Adv.No</th>
                                    <th class="desktop">Advance</th>
                                    <th class="desktop">Clear</th>
                                    <th class="desktop">Vat</th>
                                    <th class="desktop">WH-Tax</th>
                                    <th class="all">Net</th>
                                    <th class="desktop">Currency</th>
                                    <th class="desktop">Remark</th>
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
                        <p>
                            Customers Chargable :
                            <input type="text" id="txtSumCharge" style="width:100px;text-align:right" /><br />
                            Company Cost :
                            <input type="text" id="txtSumCost" style="width:100px;text-align:right" /><br />
                        </p>
                    </div>
                    <div class="col-sm-3" style="text-align:right">
                        Amount :
                        <input type="text" id="txtClrAmount" style="width:100px;text-align:right" /><br />
                        VAT :
                        <input type="text" id="txtVatAmount" style="width:100px;text-align:right" /><br />
                        WHT :
                        <input type="text" id="txtWhtAmount" style="width:100px;text-align:right" /><br />
                        Total :
                        <input type="text" id="txtNetAmount" style="width:100px;text-align:right" />
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
                            <h4 class="modal-title"><label id="lblHeader">Clear Detail</label></h4>
                        </div>
                        <div class="modal-body">
                            <label for="txtItemNo">No :</label>
                            <input type="text" id="txtItemNo" style="width:40px" disabled />
                            <select id="cboSTCode" class="dropdown"></select>
                            <input type="checkbox" id="chkDuplicate" disabled />
                            <label for="chkDuplicate">Partial Clear</label>
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
                            Quotation No : <input type="text" id="txtQNo" style="width:230px" disabled />
                            <input type="button" id="btnBrowseQ" value="..." onclick="SearchData('quotation')" />
                            <br />
                            <a onclick="SearchData('detcurrency')">Currency :</a>
                            <input type="text" id="txtCurrencyCode" style="width:50px" tabindex="15" />
                            <input type="text" id="txtCurrencyName" style="width:200px" disabled />
                            <label for="txtCurRate">Rate :</label>
                            <input type="text" id="txtCurRate" style="width:80px;text-align:right" tabindex="16" />
                            <br />
                            <label for="txtQty">Qty:</label>
                            <input type="text" id="txtQty" style="width:100px;text-align:right" tabindex="17" />
                            <label for="txtUnitcode"><a onclick="SearchData('servunit')">Unit:</a></label>
                            <input type="text" id="txtUnitCode" style="width:50px" tabindex="18" />
                            <label id="lblUnitPrice" for="txtUnitPrice">Price :</label>
                            <input type="text" id="txtUnitPrice" style="width:100px;text-align:right" tabindex="19" />
                            <br />
                            <label id="lblAmount" for="txtAmount">Amount :</label>
                            <input type="text" id="txtAMT" style="width:100px;text-align:right" tabindex="20" />
                            <label id="lblVATRate" for="txtVATRate">VAT :</label>
                            <input type="text" id="txtVATRate" style="width:50px;text-align:right" tabindex="21" />
                            Type :
                            <select id="txtVatType" class="dropdown" disabled>
                                <option value="0">NO</option>
                                <option value="1">EX</option>
                                <option value="2">IN</option>
                            </select>
                            <input type="text" id="txtVAT" style="width:100px;text-align:right" tabindex="22" />
                            <br />
                            <label id="lblWHTRate" for="txtWHTRate">WH-Tax :</label>
                            <input type="text" id="txtWHTRate" style="width:50px;text-align:right" tabindex="23" />
                            <input type="text" id="txtWHT" style="width:100px;text-align:right" tabindex="24" />
                            <label id="lblNETAmount" for="txtNETAmount">Net Amount :</label>
                            <input type="text" id="txtNET" style="width:100px;text-align:right" tabindex="25" />
                            <br />
                            Slip No :
                            <input type="text" id="txtSlipNo" style="width:150px" tabindex="26" />
                            WH-Tax No :
                            <input type="text" id="txt50Tavi" style="width:150px" tabindex="27" />
                            <br />
                            Pay To Vender :
                            <input type="text" id="txtVenCode" style="width:50px" tabindex="28" />
                            <input type="button" id="btnBrowseVen" onclick="SearchData('vender')" value="..." />
                            <input type="text" id="txtPayChqTo" style="width:200px" tabindex="29" />
                            <br />
                            Remark :
                            <textarea id="txtRemark" style="width:100%;height:80px" tabindex="30"></textarea>
                            <br />
                            <input type="checkbox" id="chkIsCost" disabled />
                            <label for="chkIscost">Is Company Cost (Cannot Charge)</label>
                            <br />
                            <label for="txtAdvItemNo">Clear From Adv Item.No :</label>
                            <input type="text" id="txtAdvItemNo" style="width:40px" disabled />
                            <label for="txtAdvNo">Adv.No :</label>
                            <input type="text" id="txtAdvNo" style="width:150px" disabled /> Net
                            <input type="text" id="txtAdvAmount" style="width:60px" disabled />
                            <input type="hidden" id="txtJobType" />
                            <input type="hidden" id="txtShipBy" />
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
                            <h4 class="modal-title"><label id="lblHeader">Clearing List</label></h4>
                        </div>
                        <div class="modal-body">
                            <table id="tbHeader" class="table table-responsive">
                                <thead>
                                    <tr>
                                        <th>ClrNo</th>
                                        <th class="desktop">ClrDate</th>
                                        <th class="desktop">CustCode</th>
                                        <th class="desktop">ReqBy</th>
                                        <th>Job</th>
                                        <th class="desktop">Inv No</th>
                                        <th class="desktop">Status</th>
                                        <th class="all">ClrAmount</th>
                                        <th class="desktop">Currency</th>
                                        <th class="desktop">AdvNo</th>
                                        <th class="all">AdvAmount</th>
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
            <div id="frmAdvance" class="modal modal-lg fade">
                <div class="modal-dialog-lg">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h4 class="modal-title"><label id="lblHeader">Advance List</label></h4>
                        </div>
                        <div class="modal-body">
                            <table id="tbAdvance" class="table table-responsive">
                                <thead>
                                    <tr>
                                        <th>AdvNo</th>
                                        <th class="desktop">AdvDate</th>
                                        <th class="all">ItemNo</th>
                                        <th class="desktop">SICode</th>
                                        <th>Description</th>
                                        <th class="desktop">JobNo</th>
                                        <th class="desktop">Currency</th>
                                        <th class="desktop">ExcRate</th>
                                        <th class="desktop">Qty</th>
                                        <th class="desktop">Unit</th>
                                        <th class="all">AdvNet</th>
                                        <th class="all">50Tavi</th>
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
    <div id="frmSearchQuo" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    Select Quotation<br />
                    Customer :<input type="text" id="txtCustCode" style="width:100px" disabled />
                    <input type="text" id="txtCustBranch" style="width:50px" disabled />
                    <input type="text" id="txtCustName" style="width:400px" disabled />
                </div>
                <div class="modal-body">
                    <table id="tbQuo" class="table table-responsive">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Q.No</th>
                                <th>QtyBegin</th>
                                <th>QtyEnd</th>
                                <th>Unit Price</th>
                                <th class="desktop">Vender</th>
                                <th class="desktop">Cost</th>
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
        if (br.length > 0) {
            $('#txtBranchCode').val(br);
            ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            let ano = getQueryString('ClrNo');
            if (ano.length > 0) {
                $('#txtClrNo').val(ano);
                ShowData(br, $('#txtClrNo').val());
            } else {
                job = getQueryString('JNo');
                $('#dvJob').html('<h4>***For Job ' + job.toUpperCase() + '***</h4>');
                if (job.length > 0) {
                    isjobmode = true;
                    $('#txtClrNo').attr('disabled', 'disabled');
                    CallBackQueryJob(path, $('#txtBranchCode').val(), job, LoadJob);
                }
            }

        } else {
            $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
            $('#txtBranchName').val('@ViewBag.PROFILE_DEFAULT_BRANCH_NAME'); 
        }
    }
    function LoadJob(dt) {
        if (dt.length > 0) {
            let dr = dt[0];
            $('#txtForJNo').val(dr.JNo);
            $('#txtInvNo').val(dr.InvNo);
            $('#cboJobType').val(CCode(dr.JobType));
            $('#cboDocStatus').val('01');

            $('#btnBrowseCust').attr('disabled', 'disabled');
            $('#txtForJNo').attr('disabled', 'disabled');
            $('#btnBrowseJ').attr('disabled', 'disabled');
            $('#cboJobType').attr('disabled', 'disabled');            

            $('#txtEmpCode').val(user);
            CallBackQueryUser(path, $('#txtEmpCode').val(), ReadClrBy);

            //$('#txtEmpCode').focus();
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

        $('#chkApprove').on('click', function () {
            chkmode = this.checked;
            CallBackAuthorize(path, 'MODULE_CLR', 'Approve',(chkmode ? 'I':'D'), SetApprove);
        });

        $('#chkCancel').on('click', function () {
            chkmode = this.checked;
            CallBackAuthorize(path, 'MODULE_CLR', 'Index', 'D', SetCancel);
        });

        $('#txtCurrencyCode').keydown(function (event) {
            if (event.which == 13) {
                ShowCurrency(path, $('#txtCurrencyCode').val(), '#txtCurrencyName');
                ShowCaption();
            }
        });

        $('#txtBranchCode').keydown(function (event) {
            if (event.which == 13) {
                ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            }
        });

        $('#txtClrNo').keydown(function (event) {
            if (event.which == 13) {
                ShowData($('#txtBranchCode').val(),$('#txtClrNo').val());
            }
        });

        $('#txtEmpCode').keydown(function (event) {
            if (event.which == 13) {
                CallBackQueryUser(path, $('#txtEmpCode').val(), ReadClrBy);
            }
        });

        $('#txtSICode').keydown(function (event) {
            if (event.which == 13) {
                let dt = FindService($('#txtSICode').val())
                ReadService(dt);
            }
        });

        $('#txtQty').keydown(function (event) {
            if (event.which == 13) {
                CalAmount();
            }
        });

        $('#txtUnitPrice').keydown(function (event) {
            if (event.which == 13) {
                CalAmount();
            }
        });

        $('#txtCurRate').keydown(function (event) {
            if (event.which == 13) {
                CalAmount();
            }
        });

        $('#txtAMT').keydown(function (event) {
            if (event.which == 13) {
                CalVATWHT();
            }
        });

        $('#txtVATRate').keydown(function (event) {
            if (event.which == 13) {
                CalVATWHT();
            }
        });

        $('#txtWHTRate').keydown(function (event) {
            if (event.which == 13) {
                CalVATWHT();
            }
        });

        $('#txtVAT').keydown(function (event) {
            if (event.which == 13) {
                CalTotal();
            }
        });

        $('#txtWHT').keydown(function (event) {
            if (event.which == 13) {
                CalTotal();
            }
        });

        $('#txtForJNo').keydown(function (event) {
            if (event.which == 13) {
                //ShowInvNo(path, $('#txtBranchCode').val(), $('#txtForJNo').val(), '#txtInvNo');
                $('#txtInvNo').val('');
                $('#txtQNo').val('');
                $('#txtCustCode').val('');
                $('#txtCustBranch').val('');
                $('#txtCustName').val('');
                $('#txtJobType').val('0');
                $('#txtShipBy').val('0');
                CallBackQueryJob(path, $('#txtBranchCode').val(), $('#txtForJNo').val(), ReadJob);
            }
        });

        $('#txtNET').keydown(function (event) {
            if (event.which == 13) {
                let type = $('#txtVatType').val();
                if (type == ''||type=='0') type = "1";
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
                let dataApp = [];
                dataApp.push(user);
                dataApp.push($('#txtBranchCode').val() + '|' + $('#txtClrNo').val());
                let jsonString = JSON.stringify({ data: dataApp });
                $.ajax({
                    url: "@Url.Action("ApproveClearing", "Clr")",
                    type: "POST",
                    contentType: "application/json",
                    data: jsonString,
                    success: function (response) {
                        if (response) {
                            ShowData($('#txtBranchCode').val(), $('#txtClrNo').val());
                            ShowMessage("Approve Completed!");
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

    function SetClear(b) {
        if (b == true) {
            $('#txtReceiveBy').val(chkmode ? user : '');
            $('#txtReceiveDate').val(chkmode ? CDateEN(GetToday()) : '');
            $('#txtReceiveTime').val(chkmode ? ShowTime(GetTime()) : '');
            return;
        }
        ShowMessage('You are not allow to ' + (b ? 'Clear!' : 'cancel clear!'));
        $('#chkReceive').prop('checked', !chkmode);
    }

    function SetCancel(b) {
        if (b == true) {
            if (chkmode) $('#cboDocStatus').val('99');
            $('#txtCancelProve').val(chkmode ? user : '');
            $('#txtCancelDate').val(chkmode ? CDateEN(GetToday()) : '');
            $('#txtCancelTime').val(chkmode ? ShowTime(GetTime()) : '');
            return;
        }
        ShowMessage('You are not allow to ' + (b ? 'cancel Advance!' : 'do this!'));
        $('#chkCancel').prop('checked', !chkmode);
    }

    function SetLOVs() {
        //Combos
        let lists = 'JOB_TYPE=#cboJobType';
        lists += ',CLR_STATUS=#cboDocStatus|01';
        lists += ',CLR_TYPE=#cboClrType|1';
        lists += ',CLR_FROM=#cboClrFrom';

        loadCombos(path, lists);
        loadServiceGroup(path, '#cboSTCode',false);
        LoadService();

        //3 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Venders
            CreateLOV(dv, '#frmSearchVend', '#tbVend', 'Venders', response,4);
            //Job
            CreateLOV(dv, '#frmSearchJob', '#tbJob', 'Job List', response, 3);
            //Users
            CreateLOV(dv, '#frmSearchClr', '#tbClr', 'Clear By', response,4);            
            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response,4);
            //SICode
            CreateLOV(dv, '#frmSearchSICode', '#tbServ', 'Service Code', response,4);
            //Currency
            CreateLOV(dv, '#frmSearchExpCur', '#tbExpCur', 'Currency Code', response, 4);
            //Unit
            CreateLOV(dv, '#frmSearchUnit', '#tbUnit', 'Unit Code', response, 2);
        });
    }
    function ShowData(branchcode, clrno) {
        if (branchcode == '') {
            ShowMessage('Please select branch');
            return;
        }
        if (clrno == '') {
            ShowMessage('Please enter clear no');
            return;
        }
        if (userRights.indexOf('R') < 0) {
            ShowMessage('you are not authorize to view data');
            return;
        }
        ClearHeader();
        $.get(path + 'clr/getclearing?branch=' + branchcode + '&code=' + clrno, function (r) {
            if (r.clr !== undefined) {
                let h = r.clr.header[0];
                ReadClrHeader(h);
                let d = r.clr.detail;
                ReadClrDetail(d);
            }
        });
    }
    function PrintData() {
        if (userRights.indexOf('P') < 0) {
            ShowMessage('you are not authorize to print');
            return;
        }
        window.open(path + 'Clr/FormClr?branch=' + $('#txtBranchCode').val() + '&code=' + $('#txtClrNo').val());
    }
    function SaveHeader() {
        if (hdr != undefined) {
            if ($('#txtBranchName').val() == '') {
                ShowMessage('please select branch code');
                $('#txtBranchCode').focus();
                return;
            }
            if ($('#cboJobType').val() == 0) {
                ShowMessage('please select job type');
                $('#cboJobType').focus();
                return;
            }
            if ($('#cboClrType').val() == 0) {
                ShowMessage('please select clear type');
                $('#cboClrType').focus();
                return;
            }
            if ($('#cboClrFrom').val() == 0) {
                ShowMessage('please select clear from');
                $('#cboClrFrom').focus();
                return;
            }
            if (userRights.indexOf('E') < 0) {
                ShowMessage('you are not authorize to save');
                return;
            }
            let obj = GetDataHeader();
            if (obj.ClrNo == '') {
                if (userRights.indexOf('I') < 0) {
                    ShowMessage('you are not authorize to add');
                    return;
                }
            }
            let jsonString = JSON.stringify({ data: obj });
            //ShowMessage(jsonString);
            $.ajax({
                url: "@Url.Action("SetClrHeader", "Clr")",
                type: "POST",
                contentType: "application/json",
                data: jsonString,
                success: function (response) {
                    ShowMessage(response.result.msg);
                    if (response.result.data !== null) {
                        $('#txtClrNo').val(response.result.data);
                        ShowData($('#txtBranchCode').val(), $('#txtClrNo').val());
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
            ClrNo : $('#txtClrNo').val(),
            ClrDate: CDateTH($('#txtClrDate').val()),
            ClearanceDate: CDateTH($('#txtClearanceDate').val()),
            EmpCode: $('#txtEmpCode').val(),
            AdvRefNo: null,
            AdvTotal: CNum($('#txtAdvTotal').val()),
            JobType: $('#cboJobType').val(),
            JNo: null,
            InvNo: null,
            ClearType: $('#cboClrType').val(),
            ClearFrom: $('#cboClrFrom').val(),
            DocStatus: $('#cboDocStatus').val(),
            TotalExpense: CNum($('#txtTotalExpense').val()),
            TRemark: $('#txtTRemark').val(),
            ApproveBy: $('#txtApproveBy').val(),
            ApproveDate: CDateTH($('#txtApproveDate').val()),
            ApproveTime: $('#txtApproveTime').val(),
            ReceiveBy: $('#txtReceiveBy').val(),
            ReceiveDate: CDateTH($('#txtReceiveDate').val()),
            ReceiveTime: $('#txtReceiveTime').val(),
            ReceiveRef: $('#txtReceiveRef').val(),
            CancelReson: $('#txtCancelReson').val(),
            CancelProve: $('#txtCancelProve').val(),
            CancelDate: CDateTH($('#txtCancelDate').val()),
            CancelTime: $('#txtCancelTime').val(),
            CoPersonCode: $('#txtCoPersonCode').val(),
            CTN_NO: $('#txtCTN_NO').val(),
            ClearTotal: CNum($('#txtClearTotal').val()),
            ClearVat: CNum($('#txtVatAmount').val()),
            ClearWht: CNum($('#txtWhtAmount').val()),
            ClearNet: CNum($('#txtNetAmount').val()),
            ClearBill: CNum($('#txtSumCharge').val()),
            ClearCost: CNum($('#txtSumCost').val())
        };

        return dt;
    }
    function ReadClrHeader(dt) {
        if (dt != undefined) {
            hdr = dt;
            //$('#txtBranchCode').val(dt.BranchCode);
            $('#txtClrNo').val(dt.ClrNo);
            $('#txtClrDate').val(CDateEN(dt.ClrDate));
            $('#txtClearanceDate').val(CDateEN(dt.ClearanceDate));
            
            $('#txtEmpCode').val(dt.EmpCode);
            $('#txtAdvTotal').val(CDbl(dt.AdvTotal, 4));
            if (isjobmode == false) {
                $('#cboJobType').val(CCode(dt.JobType));
            }
            //Combos
            $('#cboClrType').val(dt.ClearType);
            $('#cboClrFrom').val(dt.ClearFrom);
            $('#cboDocStatus').val(CCode(dt.DocStatus));
            $('#txtTotalExpense').val(CDbl(dt.TotalExpense, 4));
            $('#txtTRemark').val(dt.TRemark);
            $('#txtApproveBy').val(dt.ApproveBy);
            $('#txtApproveDate').val(CDateEN(dt.ApproveDate));
            $('#txtApproveTime').val(ShowTime(dt.ApproveTime));
            $('#txtReceiveBy').val(dt.ReceiveBy);
            $('#txtReceiveDate').val(CDateEN(dt.ReceiveDate));
            $('#txtReceiveTime').val(ShowTime(dt.ReceiveTime));
            $('#txtReceiveRef').val(dt.ReceiveRef);
            $('#txtCancelProve').val(dt.CancelProve);
            $('#txtCancelReson').val(dt.CancelReson);
            $('#txtCancelDate').val(CDateEN(dt.CancelDate));
            $('#txtCancelTime').val(ShowTime(dt.CancelTime));

            $('#txtCTN_NO').val(dt.CTN_NO);
            $('#txtCoPersonCode').val(dt.CoPersonCode);
            $('#txtClearTotal').val(CDbl(dt.ClearTotal, 4));
            $('#txtClrAmount').val(CDbl(dt.ClearNet+dt.ClearWht-dt.ClearVat, 4));
            $('#txtVatAmount').val(CDbl(dt.ClearVat, 4));
            $('#txtWhtAmount').val(CDbl(dt.ClearWht, 4));
            $('#txtNetAmount').val(CDbl(dt.ClearNet, 4));
            $('#txtSumCharge').val(CDbl(dt.ClearBill, 4));
            $('#txtSumCost').val(CDbl(dt.ClearCost,4));

            $('#chkCancel').prop('checked', $('#txtCancelProve').val() == '' ? false : true);
            $('#chkApprove').prop('checked', $('#txtApproveBy').val() == '' ? false : true);
            $('#chkReceive').prop('checked', $('#txtReceiveBy').val() == '' ? false : true);
            
            CallBackQueryUser(path, $('#txtEmpCode').val(), ReadClrBy);
            ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');

            if (dt.DocStatus > 2) {
                $('#chkApprove').attr('disabled', 'disabled');
                //if document paymented/cancelled/cleared then disable save button
                EnableSave(false);
            } else {
                //if document approved by this user or not then check authorized to unlock
                if (dt.DocStatus == 2 && user == dt.ApproveBy && userRights.indexOf('E') >= 0) {
                    EnableSave(true);
                } else {
                    if (dt.DocStatus == 2) {
                        $('#chkApprove').attr('disabled', 'disabled');
                        EnableSave(false);
                    }
                }
            }
            $('#cboClrType').attr('disabled', 'disabled');
            $('#cboClrFrom').attr('disabled', 'disabled');
            return;
        }
    }
    function EnableSave(b) {
        $('#btnSave').removeAttr('disabled');
        $('#btnDel').removeAttr('disabled');
        $('#btnUpdate').removeAttr('disabled');

        if (b == false) {
            $('#btnSave').attr('disabled', 'disabled');
            $('#btnDel').attr('disabled', 'disabled');
            $('#btnUpdate').attr('disabled', 'disabled');
        }
    }
    function AddHeader() {
        if (userRights.indexOf('I') < 0) {
            ShowMessage('you are not authorize to add');
            return;
        }
        $('#txtClrNo').val('');
        ClearHeader();
        ClearDetail();
        $.get(path + 'clr/getnewclearheader?branchcode=' + $('#txtBranchCode').val() , function (r) {
            let h = r.clr.header;
            ReadClrHeader(h);
            if (isjobmode == false) {
                $('#cboJobType').val('');
            }
            $('#cboDocStatus').val('01');
            $('#cboClrType').val('1');
            $('#cboClrFrom').val('1');
            $('#txtEmpCode').val(user);
            $('#txtClrDate').val(GetToday());

            $('#cboClrType').removeAttr('disabled');
            $('#cboClrFrom').removeAttr('disabled');

            CallBackQueryUser(path, $('#txtEmpCode').val(), ReadClrBy);
            let d = r.clr.detail;
            ReadClrDetail(d);
            $('#txtClrNo').focus();
        });
    }
    function AddDetail() {
        ClearDetail();
        $.get(path + 'clr/getnewcleardetail?branchcode=' + $('#txtBranchCode').val() + '&clrno=' + $('#txtClrNo').val(), function (r) {
            let d = r.clr.detail[0];
            LoadDetail(d);

            $('#frmDetail').modal('show');
            $('#txtSICode').focus();
        });
    }
    function DeleteDetail() {
        if (dtl != undefined) {
            if (userRights.indexOf('D') < 0) {
                ShowMessage('you are not authorize to delete');
                return;
            }
            $.get(path + 'clr/delclrdetail?branch=' + $('#txtBranchCode').val() + '&code=' + $('#txtClrNo').val() + '&item=' + dtl.ItemNo, function (r) {
                ShowMessage(r.clr.result);
                ShowData($('#txtBranchCode').val(), $('#txtClrNo').val());
            });
        } else {
            ShowMessage('No data to delete');
        }
    }
    function ClearHeader() {
        hdr = {};
        $('#txtClrDate').val(GetToday());
        $('#txtClearanceDate').val('');
        $('#txtEmpCode').val(user);
        if (isjobmode == false) {
            $('#cboJobType').val('');
        }
        $('#txtCoPersonCode').val('');
        $('#txtCTN_NO').val('');
        $('#txtTRemark').val('');

        $('#txtCancelProve').val('');
        $('#txtCancelReson').val('');
        $('#txtCancelDate').val('');
        $('#txtCancelTime').val('');

        $('#txtReceiveBy').val('');
        $('#txtReceiveDate').val('');
        $('#txtReceiveTime').val('');
        $('#txtReceiveRef').val('');

        $('#txtApproveBy').val('');
        $('#txtApproveDate').val('');
        $('#txtApproveTime').val('');

        $('#txtAdvTotal').val('0.00');
        $('#txtTotalExpense').val('0.00');
        $('#txtClearTotal').val('0.00');

        $('#txtClrAmount').val('0.00');
        $('#txtVatAmount').val('0.00');
        $('#txtWhtAmount').val('0.00');
        $('#txtNetAmount').val('0.00');

        $('#txtSumCharge').val('0.00');
        $('#txtSumCost').val('0.00');

        $('#chkCancel').prop('checked', $('#txtCancelProve').val() == '' ? false : true);
        $('#chkApprove').prop('checked', $('#txtApproveBy').val() == '' ? false : true);
        $('#chkReceive').prop('checked', $('#txtReceiveBy').val() == '' ? false : true);

        $('#chkApprove').removeAttr('disabled');
        //Combos
        $('#cboClrType').val('1');
        $('#cboClrFrom').val('1');
        $('#cboDocStatus').val('01');

        CallBackQueryUser(path, $('#txtEmpCode').val(), ReadClrBy);

        $('#btnPrint').attr('disabled', 'disabled');
        $('#btnAdd').attr('disabled', 'disabled');
        $('#btnDel').attr('disabled', 'disabled');
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
        $('#cboClrType').removeAttr('disabled');
        $('#cboClrFrom').removeAttr('disabled');
    }
    function SaveDetail() {

        if (hdr == undefined) {
            ShowMessage('Please add header before');
            return;
        }
        if (hdr.ClrNo == '') {
            ShowMessage('Please save header first');
            return;
        }
        if ($('#txtUnitCode').val() == '') {
            ShowMessage('Please select unit');
            return;
        }
        if ($('#txtSlipNo').val().length<2 && $('#txtSlipNo').prop('disabled')==false) {
            ShowMessage('Please enter slip number');
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
            let jsonString = JSON.stringify({ data: obj });
            //ShowMessage(jsonString);
            $.ajax({
                url: "@Url.Action("SetClrDetail", "Clr")",
                type: "POST",
                contentType: "application/json",
                data: jsonString,
                success: function (response) {
                    ShowMessage(response.result.msg);
                    ShowData($('#txtBranchCode').val(), $('#txtClrNo').val());
                    $('#frmDetail').modal('hide');
                }
            });
            return;
        }
        ShowMessage('No data to save');
    }

    function ReadClrDetail(dt) {
        $('#tbDetail').DataTable({
            data:dt,
            selected: true, //ให้สามารถเลือกแถวได้
            columns: [ //กำหนด property ของ header column
                { data: null, title: "Edit" },                
                { data: "JobNo", title: "Job" },
                { data: "SICode", title: "Service" },
                { data: "SDescription", title: "Description" },
                { data: "AdvNO", title: "Adv.No" },
                { data: "AdvAmount", title: "Advance" },
                { data: "UsedAmount", title: "Clear" },
                { data: "ChargeVAT", title: "VAT" },
                { data: "Tax50Tavi", title: "WH-Tax" },
                { data: "BNet", title: "Net" },
                { data: "CurrencyCode", title: "Currency" },
                { data: "SlipNO", title: "Slip No" }
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
            ClearDetail();
            LoadDetail(data); //callback function from caller
        });
        $('#tbDetail tbody').on('click', 'button', function () {
            $('#frmDetail').modal('show');
            $('#txtSICode').focus();
        });
    }
    function GetDataDetail() {
        let dt = {
            BranchCode: $('#txtBranchCode').val(),
            ClrNo: $('#txtClrNo').val(),
            ItemNo: $('#txtItemNo').val(),
            LinkItem: dtl.LinkItem,
            SICode: $('#txtSICode').val(),
            STCode: $('#cboSTCode').val(),
            SDescription: $('#txtSDescription').val(),
            VenderCode: $('#txtVenCode').val(),
            Qty: $('#txtQty').val(),
            UnitCode: $('#txtUnitCode').val(),
            CurrencyCode: $('#txtCurrencyCode').val(),
            CurRate: $('#txtCurRate').val(),
            UnitPrice: $('#chkIsCost').prop('checked') == true ? 0 : $('#txtUnitPrice').val(),
            FPrice: $('#chkIsCost').prop('checked') == true ? 0 : CDbl(Number($('#txtUnitPrice').val()) * Number($('#txtQty').val()),4),
            BPrice: $('#chkIsCost').prop('checked') == true ? 0 : CDbl(Number($('#txtCurRate').val()) * Number($('#txtUnitPrice').val()) * Number($('#txtQty').val()), 4),
            QUnitPrice: dtl.QUnitPrice,
            QFPrice: CDbl(CNum(dtl.QUnitPrice) * CNum($('#txtQty').val()), 4),
            QBPrice: CDbl(CNum($('#txtCurRate').val())*CNum(dtl.QUnitPrice) * CNum($('#txtQty').val()), 4),
            UnitCost: $('#txtUnitPrice').val(),
            FCost: CDbl(Number($('#txtUnitPrice').val()) * Number($('#txtQty').val()), 4),
            BCost: CDbl(Number($('#txtCurRate').val()) * Number($('#txtUnitPrice').val()) * Number($('#txtQty').val()), 4),
            ChargeVAT: $('#txtVAT').val(),
            Tax50Tavi: $('#txtWHT').val(),
            AdvNO: $('#txtAdvNo').val(),
            AdvItemNo: $('#txtAdvItemNo').val(),
            AdvAmount: ($('#chkDuplicate').prop('checked') == true ? $('#txtNET').val() : $('#txtAdvAmount').val()),
            UsedAmount: $('#txtAMT').val(),
            IsQuoItem: dtl.IsQuoItem,
            SlipNO: $('#txtSlipNo').val(),
            Remark: $('#txtRemark').val(),
            IsLtdAdv50Tavi: dtl.IsLtdAdv50Tavi,
            Pay50TaviTo: $('#txtPayChqTo').val(),
            NO50Tavi: $('#txt50Tavi').val(),
            Date50Tavi: dtl.Date50Tavi,
            VenderBillingNo: dtl.VenderBillingNo,
            AirQtyStep: dtl.AirQtyStep,
            StepSub: dtl.StepSub,
            LinkBillNo : dtl.LinkBillNo,
            JobNo : $('#txtForJNo').val(),
            VATType : $('#txtVatType').val(),
            VATRate: $('#txtVATRate').val(),
            Tax50TaviRate : $('#txtWHTRate').val(),
            IsDuplicate: ($('#chkDuplicate').prop('checked') == true ? 1 : 0),
            QNo: $('#txtQNo').val(),
            FNet: Number($('#txtNET').val())/Number($('#txtCurRate').val()),
            BNet: $('#txtNET').val()
        };
        return dt;
    }
    function LoadDetail(dt) {
        if (dt != undefined) {
            dtl = dt;
            $('#txtItemNo').val(dt.ItemNo);
            $('#txtSICode').val(dt.SICode);
            $('#cboSTCode').val(dt.STCode);
            let r = FindService($('#txtSICode').val())
            ReadService(r);
            if (isjobmode == false) {
                $('#txtForJNo').val(dt.JobNo);
                $('#txtInvNo').val('');
                if ($('#txtForJNo').val()!= '') {
                    //ShowInvNo(path, $('#txtBranchCode').val(), $('#txtForJNo').val(), '#txtInvNo');
                    CallBackQueryJob(path, $('#txtBranchCode').val(), $('#txtForJNo').val(), ReadJob);
                }
            }
            $('#txtQty').val(dt.Qty);
            $('#txtCurRate').val(dt.CurRate);
            $('#txtUnitPrice').val(dt.UnitCost);
            $('#txtUnitCode').val(dt.UnitCode);
            CalAmount();
            $('#txtRemark').val(dt.Remark);
            $('#txtSlipNo').val(dt.SlipNO);
            $('#txt50Tavi').val(dt.NO50Tavi);
            $('#txtPayChqTo').val(dt.Pay50TaviTo);
            $('#txtSDescription').val(dt.SDescription);
            $('#txtVatType').val(dt.VATType);
            $('#txtVATRate').val(CDbl(dt.VATRate,0));
            $('#txtWHTRate').val(dt.Tax50TaviRate);
            $('#txtAMT').val(dt.UsedAmount);
            $('#txtVAT').val(dt.ChargeVAT);
            $('#txtWHT').val(dt.Tax50Tavi);
            $('#txtNET').val(dt.BNet);
            $('#txtVenCode').val(dt.VenderCode);
            $('#chkDuplicate').prop('checked', dt.IsDuplicate == 1 ? true : false);
            $('#txtCurrencyCode').val(dt.CurrencyCode);
            $('#txtAdvNo').val(dt.AdvNO);
            $('#txtQNo').val(dt.QNo);
            $('#txtAdvItemNo').val(dt.AdvItemNo);
            $('#txtAdvAmount').val(dt.AdvAmount);
            ShowCurrency(path, $('#txtCurrencyCode').val(), '#txtCurrencyName');
            ShowCaption();
            return;
        }
    }
    function LoadDetailFromAdv(dt) {
        if (dt != undefined) {
            dtl = dt;
            $('#txtItemNo').val(dt.ItemNo);
            $('#txtSICode').val(dt.SICode);
            $('#cboSTCode').val(dt.STCode);
            let r = FindService($('#txtSICode').val())
            ReadService(r);
            $('#txtForJNo').val(dt.JobNo);
            $('#txtInvNo').val('');
            if ($('#txtForJNo').val() != '') {
                //ShowInvNo(path, $('#txtBranchCode').val(), $('#txtForJNo').val(), '#txtInvNo');
                CallBackQueryJob(path, $('#txtBranchCode').val(), $('#txtForJNo').val(), ReadJob);
            }
            $('#txtQty').val(dt.Qty);
            $('#txtCurRate').val(dt.CurRate);
            $('#txtUnitPrice').val(dt.UnitCost);
            $('#txtUnitCode').val(dt.UnitCode);            
            $('#txtRemark').val(dt.Remark);
            $('#txtSlipNo').val(dt.SlipNO);
            $('#txt50Tavi').val(dt.NO50Tavi);
            $('#txtPayChqTo').val(dt.Pay50TaviTo);
            $('#txtSDescription').val(dt.SDescription);
            $('#txtVatType').val(dt.VATType);
            $('#txtVATRate').val(dt.VATRate);
            $('#txtWHTRate').val(dt.Tax50TaviRate);
            $('#txtAMT').val(dt.AdvBalance / CDbl(1 + ((dt.VATRate - dt.Tax50TaviRate) * 0.01),2));
            $('#txtVAT').val(CNum($('#txtAMT').val())*(dt.VATRate*0.01));
            $('#txtWHT').val(CNum($('#txtAMT').val())*(dt.Tax50TaviRate*0.01));
            $('#txtNET').val(CNum($('#txtAMT').val()) + (CNum($('#txtAMT').val()) * (dt.VATRate * 0.01)) - (CNum($('#txtAMT').val()) * (dt.Tax50TaviRate * 0.01)));
            $('#txtVenCode').val(dt.VenderCode);
            $('#chkDuplicate').prop('checked', dt.IsDuplicate == 1 ? true : false);
            $('#txtCurrencyCode').val(dt.CurrencyCode);
            $('#chkIsCost').prop('checked', dt.IsExpense == 1 ? true : false);
            $('#txtAdvNo').val(dt.AdvNO);
            $('#txtAdvItemNo').val(dt.AdvItemNo);
            $('#txtAdvAmount').val(dt.AdvBalance);
            $('#txtQNo').val(dt.QNo);
            ShowCurrency(path, $('#txtCurrencyCode').val(), '#txtCurrencyName');
            ShowCaption();
            return;
        }
    }
    function ClearDetail() {
        dtl = {};
        $('#txtItemNo').val('0');
        $('#txtSICode').val('');
        $('#cboSTCode').val('');
        $('#txtUnitCode').val('');
        if (isjobmode == false) {
            $('#txtForJNo').val('');
            $('#txtInvNo').val('');
            $('#txtQNo').val('');
        }
        $('#txtRemark').val('');
        $('#txt50Tavi').val('');
        $('#txtPayChqTo').val('');
        $('#txtSDescription').val('');
        $('#txtVatType').val('1');
        $('#txtVATRate').val(0);
        $('#txtWHTRate').val(0);
        $('#txtAMT').val(0);
        $('#txtVAT').val(0);
        $('#txtWHT').val(0);
        $('#txtNET').val(0);
        $('#txtQty').val(1);
        $('#txtCurRate').val(1);
        $('#txtUnitPrice').val(0);
        $('#txtCurrencyCode').val($('#txtSubCurrency').val());
        ShowCurrency(path, $('#txtSubCurrency').val(), '#txtCurrencyName');
        ShowCaption();
        $('#txtVenCode').val('');
        $('#txtAdvNo').val('');
        $('#txtAdvAmount').val('0');
        $('#txtSlipNo').val('');
        $('#txtAdvItemNo').val('0');

        $('#chkDuplicate').prop('checked', false);
        $('#txtSlipNo').removeAttr('disabled');
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
    function SetGridClr() {
        let w = $('#txtBranchCode').val();
        if (job.length > 0) {
            w += '&jobno=' + job;
        }

        $.get(path + 'clr/getclearinggrid?branchcode=' +  w, function (r) {
            if (r.clr.data.length == 0) {
                ShowMessage('data not found on this branch');
                return;
            }
            let h = r.clr.data[0].Table;
            $('#tbHeader').DataTable({
                data: h,
                selected: true, //ให้สามารถเลือกแถวได้
                columns: [ //กำหนด property ของ header column
                    { data: "ClrNo", title: "Clear No" },
                    {
                        data: "ClrDate", title: "Date",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "CustCode", title: "Customer" },
                    { data: "EmpCode", title: "Request By" },
                    { data: "JobNo", title: "Job Number" },
                    { data: "CustInvNo", title: "Cust Inv" },
                    { data: "DocStatus", title: "Status" },
                    { data: "ClrNet", title: "Clr.Total" },
                    { data: "CurrencyCode", title: "Currency" },
                    { data: "AdvNO", title: "Adv No" },
                    { data: "AdvNet", title: "Adv.Total" },
                    { data: "TRemark", title: "Remark" },
                ],
                responsive:true,
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            });
            $('#tbHeader tbody').on('click', 'tr', function () {
                $('#tbHeader tbody > tr').removeClass('selected');
                $(this).addClass('selected');
                let data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                ShowData(data.BranchCode, data.ClrNo); //callback function from caller
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
            case 'clearing':
                SetGridClr();
                break;
            case 'branch':
                SetGridBranch(path, '#tbBranch', '#frmSearchBranch', ReadBranch);
                break;
            case 'clrby':
                SetGridUser(path, '#tbClr', '#frmSearchClr', ReadClrBy);
                break;
            case 'servicecode':
                let q = GetClrType($('#cboClrType').val());
                if ($('#cboSTCode').val() !== '') {
                    q += '&group=' + $('#cboSTCode').val();
                }
                SetGridSICodeFilter(path, '#tbServ', q, '#frmSearchSICode', ReadService);
                break;
            case 'job':
                SetGridJob(path, '#tbJob', '#frmSearchJob', GetParam(), ReadJob);
                break;
            case 'detcurrency':
                SetGridCurrency(path, '#tbExpCur', '#frmSearchExpCur', ReadCurrencyD);
                break;
            case 'vender':
                SetGridVender(path, '#tbVend', '#frmSearchVend', ReadVender);
                break;
            case 'servunit':
                SetGridServUnit(path, '#tbUnit', '#frmSearchUnit', ReadUnit);
                break;
            case 'quotation':
                let qry = '?branch=' + $('#txtBranchCode').val() + '&cust=' + $('#txtCustCode').val() + '&code=' + $('#txtSICode').val() + '&jtype=' + $('#txtJobType').val() + '&sby=' + $('#txtShipBy').val();
                SetGridQuotation(path, '#tbQuo', qry, '#frmSearchQuo', ReadQuotation);
                break;
        }
    }
    function GetClrType(type) {
        switch (type) {
            case "1":
                return "?type=A";
            case "2":
                return "?type=C";
            case "3":
                return "?type=S";
            default:
                return "";
        }
    }
    function GetClrFrom(type) {
        switch (type) {
            case "1":
                return "&cfrom=MKT";
            case "2":
                return "&cfrom=CS";
            case "3":
                return "&cfrom=SP";
            case "4":
                return "&cfrom=FIN";
            case "5":
                return "&cfrom=ACC";
            case "6":
                return "&cfrom=IT";
            default:
                return "";
        }
    }

    function GetParam() {
        let strParam = '?Status=0,1,2,3,4,5,6';
        strParam += '&Branch=' + $('#txtBranchCode').val();
        strParam += '&JType=' + $('#cboJobType').val().substr(0, 2);
        return strParam;
    }
    function ShowCaption() {
        $('#lblUnitPrice').text("Price (" + $('#txtCurrencyCode').val() + "):");
        $('#lblAmount').text("Amount (" + $('#txtCurrencyCode').val() + "):");
        $('#lblVATRate').text("VAT (" + $('#txtCurrencyCode').val() + "):");
        $('#lblWHTRate').text("WHT (" + $('#txtCurrencyCode').val() + "):");
        $('#lblNETAmount').text("Net (" + $('#txtCurrencyCode').val() + "):");
    }
    function ReadUnit(dt) {
        $('#txtUnitCode').val(dt.UnitType);
    }
    function ReadVender(dt) {
        $('#txtVenCode').val(dt.VenCode);
        $('#txtPayChqTo').val(dt.TName);
        $('#txtPayChqTo').focus();
    }
    function ReadCurrencyD(dt) {
        $('#txtCurrencyCode').val(dt.Code);
        $('#txtCurrencyName').val(dt.TName);
        $('#txtCurRate').val(1);
        CalAmount();
        ShowCaption();
        $('#txtCurRate').focus();
    }
    function ReadCurrencyH(dt) {
        $('#txtSubCurrency').val(dt.Code);
        $('#txtExchangeRate').focus();
    }
    function ReadClrBy(dt) {
        $('#txtEmpCode').val(dt.UserID);
        $('#txtEmpName').val(dt.TName);
        $('#cboClrFrom').val(dt.DeptID);
        //$('#txtEmpCode').focus();
    }
    function ReadBranch(dt) {
        $('#txtBranchCode').val(dt.Code);
        $('#txtBranchName').val(dt.BrName);
        $('#txtBranchCode').focus();
    }
    function ReadService(dt) {
        $('#txtSICode').focus();
        if (dt != undefined) {
            $('#txtSICode').val(dt.SICode);
            $('#cboSTCode').val(dt.GroupCode);
            $('#txtSDescription').val(dt.NameThai);
            $('#txtVatType').val(dt.IsTaxCharge);
            $('#txtVATRate').val(dt.IsTaxCharge == "0" ? "0" : CDbl(@ViewBag.PROFILE_VATRATE*100,0));
            $('#txtWHTRate').val(dt.Is50Tavi == "0" ? "0" : dt.Rate50Tavi);
            if (dt.IsTaxCharge == "2") {
                $('#txtAMT').attr('disabled', 'disabled');
                $('#txtVATRate').attr('disabled', 'disabled');
                $('#txtWHTRate').attr('disabled', 'disabled');
                $('#txtVAT').attr('disabled', 'disabled');
                $('#txtWHT').attr('disabled', 'disabled');
            } else {
                $('#txtAMT').removeAttr('disabled');
                $('#txtVATRate').removeAttr('disabled');
                $('#txtWHTRate').removeAttr('disabled');
                $('#txtVAT').removeAttr('disabled');
                $('#txtWHT').removeAttr('disabled');
            }
            $('#chkIsCost').prop('checked', dt.IsExpense == 1 ? true : false);
            if (dt.IsHaveSlip == 0) {
                $('#txtSlipNo').attr('disabled', 'disabled');
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
    function ReadJob(r) {
        let dt = r;
        if (r.length > 0) {
            dt = r[0];
        }
        $('#txtForJNo').val(dt.JNo);
        $('#txtInvNo').val(dt.InvNo);
        $('#txtQNo').val(dt.QNo);
        $('#txtCustCode').val(dt.CustCode);
        $('#txtCustBranch').val(dt.CustBranch);
        $('#txtJobType').val(dt.JobType);
        $('#txtShipBy').val(dt.ShipBy);
        ShowCustomer(path, dt.CustCode, dt.CustBranch, '#txtCustName');
        $('#txtForJNo').focus();
    }
    
    function GetTotal() {
        return CDbl(CNum($('#txtTotalClear').val()) / CNum($('#txtExchangeRate').val()) ,4);
    }
    function CalAmount() {
        let price = CDbl($('#txtUnitPrice').val(),4);
        let qty = CDbl($('#txtQty').val(),4);
        let rate = CDbl($('#txtCurRate').val(),4); //rate ของ detail
        let type = $('#txtVatType').val();
        if (type == '' || type == '0') type = '1';
        if (qty > 0) {
            let amt = CNum(qty) * CNum(price);
            //let exc = CDbl($('#txtExchangeRate').val(), 4); //rate ของ header
            //let total = CDbl(CNum(amt) / CNum(exc),4);
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
        if (type == ''||type=='0') type = '1';
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
        if (type == ''||type=='0') type = '1';
        let amt = CDbl($('#txtAMT').val(),4);
        if (type == '2') {
            amt = CDbl($('#txtNET').val(),4);
        }
        let vatrate = CDbl($('#txtVATRate').val(),0);
        let whtrate = CDbl($('#txtWHTRate').val(),0);
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
    function LoadAdvance() {
        let jtype = $('#cboJobType').val();
        let branch = $('#txtBranchCode').val();
        if (job !== "") {
            jtype += '&jobno=' + job;
        }
        //$.get(path + 'Clr / GetAdvForClear ? branchcode = '+branch+' & jtype=' + jtype + GetClrFrom(cfrom), function (r) {
        $.get(path + 'Clr/GetAdvForClear?branchcode=' + branch + '&jtype=' + jtype, function (r) {
            if (r.clr.data.length > 0) {
                let d = r.clr.data[0].Table;
                $('#tbAdvance').DataTable({
                    data: d,
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: "AdvNO", title: "Adv.No" },
                        {
                            data: "AdvDate", title: "Adv.Date",
                            render: function (data) {
                                return CDateEN(data);
                            }
                        },
                        { data: "ItemNo", title: "#" },
                        { data: "SICode", title: "Code" },
                        { data: "SDescription", title: "Expense Name" },
                        { data: "JobNo", title: "Job" },
                        { data: "CurrencyCode", title: "Currency" },
                        { data: "CurRate", title: "Rate" },
                        { data: "Qty", title: "Qty" },
                        { data: "AdvNO", title: "Unit" },
                        { data: "AdvBalance", title: "Balance" },
                        { data: "UsedAmount", title: "Used" },
                    ],
                    responsive:true,
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                $('#tbAdvance tbody').on('click', 'tr', function () {
                    $('#tbAdvance tbody > tr').removeClass('selected');
                    $(this).addClass('selected');

                    let dt = $('#tbAdvance').DataTable().row(this).data(); //read current row selected

                    dt.BranchCode = $('#txtBranchCode').val();
                    dt.ClrNo = $('#txtClrNo').val();
                    dtl = dt;
                    $('#frmAdvance').modal('hide');
                    ClearDetail();
                    LoadDetailFromAdv(dt);
                    $('#frmDetail').modal('show');

                });
                $('#frmAdvance').modal('show');
            } else {
                ShowMessage("Not found data for clear");
            }
        });
    }
    function ReadQuotation(dt) {
        $('#txtSICode').val(dt.SICode);
        $('#cboSTCode').val('QUO');
        $('#txtSDescription').val(dt.DescriptionThai);
        $('#txtVatType').val(dt.Isvat);
        $('#txtVATRate').val(dt.VatRate);
        $('#txtWHTRate').val(dt.IsTax == "0" ? "0" : dt.TaxRate);
        if (dt.Isvat == "2") {
            $('#txtAMT').attr('disabled', 'disabled');
            $('#txtVATRate').attr('disabled', 'disabled');
            $('#txtWHTRate').attr('disabled', 'disabled');
            $('#txtVAT').attr('disabled', 'disabled');
            $('#txtWHT').attr('disabled', 'disabled');
        } else {
            $('#txtAMT').removeAttr('disabled');
            $('#txtVATRate').removeAttr('disabled');
            $('#txtWHTRate').removeAttr('disabled');
            $('#txtVAT').removeAttr('disabled');
            $('#txtWHT').removeAttr('disabled');
        }
        $('#txtCurrencyCode').val(dt.CurrencyCode);
        ShowCurrency(path, dt.CurrencyCode, '#txtCurrencyName');
        $('#txtCurRate').val(dt.CurrencyRate);
        $('#txtUnitPrice').val(dt.ChargeAmt);
        $('#txtUnitCode').val(dt.UnitCheck);            
        $('#txtVenCode').val(dt.VenderCode);           
        ShowVender(path, dt.VenderCode, '#txtPayChqTo');
        CalAmount();
    }
</script>