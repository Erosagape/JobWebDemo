﻿@Code
    ViewBag.Title = "Clearing Information"
End Code
<div class="panel-body">
    <div id="dvHeader" class="container">
        <div class="row">
            <div class="col-sm-5">
                Branch :
                <input type="text" id="txtBranchCode" style="width:50px" />
                <button id="btnBrowseBranch" onclick="SearchData('branch')">...</button>
                <input type="text" id="txtBranchName" style="width:200px" disabled />
            </div>
            <div class="col-sm-3">
                Document Date :
                <input type="date" id="txtClrDate" tabindex="1" />
            </div>
            <div class="col-sm-4" style="text-align:left">
                <table border="1">
                    <tr>
                        <td>
                            <b><a onclick="SearchData('clearing')">Clearing No:</a></b>
                            <br />
                            <input type="text" id="txtClrNo" style="font-style:bold;font-size:20px;text-align:center" tabindex="0" />
                        </td>
                    </tr>
                </table>
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
                        <table>
                            <tr>
                                <td>
                                    Clear By :
                                </td>
                                <td>
                                    <input type="text" id="txtEmpCode" style="width:100px" tabindex="2" />
                                    <button id="btnBrowseEmp1" onclick="SearchData('clrby')">...</button>
                                    <input type="text" id="txtEmpName" style="width:300px" disabled />
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
                        <table>
                            <tr>
                                <td>
                                    Container No:
                                </td>
                                <td>
                                    <input type="text" id="txtCTN_NO" style="width:200px" tabindex="6" />
                                </td>
                                <td>
                                    Clearance Date :
                                </td>
                                <td>
                                    <input type="date" id="txtClearanceDate" />
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
                                    Clear From :
                                </td>
                                <td>
                                    <select id="cboClrFrom" style="width:200px" class="form-control dropdown" tabindex="9"></select>
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
                        Co-person Reference:
                        <input type="text" id="txtCoPersonCode" />
                        <br />
                        Remark:
                        <textarea id="txtTRemark" style="width:100%;height:80px" tabindex="11"></textarea>
                    </div>
                    <div class="col-sm-5">
                        <table>
                            <tr>
                                <td>
                                    <label>Advance Total</label>
                                </td>
                                <td>
                                    <input type="text" id="txtAdvTotal" style="width:100px;text-align:right" disabled />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label>Expenses Total</label>
                                </td>
                                <td>
                                    <input type="text" id="txtTotalExpense" style="width:100px;text-align:right" disabled />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label>Clear Total</label>
                                </td>
                                <td>
                                    <input type="text" id="txtClearTotal" style="width:100px;text-align:right" disabled />
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
                        <input type="checkbox" id="chkReceive" />
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
                <button id="btnNew" class="btn btn-default" onclick="AddHeader()">New Document</button>
                <button id="btnSave" class="btn btn-success" onclick="SaveHeader()">Save Document</button>
                <button id="btnPrint" class="btn btn-info" onclick="PrintData()" disabled>Print Data</button>
            </div>
            <div id="tabDetail" class="tab-pane fade">
                <div class="row">
                    <div class="col-sm-12">
                        <table id="tbDetail" class="table table-responsive">
                            <thead>
                                <tr>
                                    <th>
                                    <th>SICode</th>
                                    <th>Description</th>
                                    <th>Job No</th>
                                    <th>Advance</th>
                                    <th>Clear</th>
                                    <th>Vat</th>
                                    <th>WH-Tax</th>
                                    <th>Net</th>
                                    <th>Currency</th>
                                    <th>Remark</th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-9">
                        <button id="btnAdd" class="btn btn-default" onclick="AddDetail()" disabled>Add</button>
                        <button id="btnDel" class="btn btn-danger" onclick="DeleteDetail()" disabled>Delete</button>
                        Customers Chargable :
                        <input type="text" id="txtSumCharge" style="width:100px;text-align:right" /><br />
                        Company Expenses :
                        <input type="text" id="txtSumCost" style="width:100px;text-align:right" /><br />
                    </div>
                    <div class="col-sm-3" style="text-align:right">
                        Amount :
                        <input type="text" id="txtClrAmount" style="width:100px;text-align:right" /><br />
                        VAT :
                        <input type="text" id="txtVatAmount" style="width:100px;text-align:right" /><br />
                        WHT :
                        <input type="text" id="txtWhtAmount" style="width:100px;text-align:right" /><br />
                        Total :
                        <input type="text" id="txtTotalAmount" style="width:100px;text-align:right" />
                    </div>
                </div>

            </div>
            <div id="frmDetail" class="modal fade" role="dialog">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal"></button>
                            <h4 class="modal-title"><label id="lblHeader">Clear Detail</label></h4>
                        </div>
                        <div class="modal-body">
                            <label for="txtItemNo">No :</label>
                            <input type="text" id="txtItemNo" style="width:40px" disabled />
                            <select id="cboSTCode" class="dropdown">
                                <option value="ADV">N/A</option>
                                <option value="STD">STD</option>
                                <option value="INC">INC</option>
                                <option value="EXP">EXP</option>
                            </select>
                            <input type="checkbox" id="chkDuplicate" />
                            <label for="chkDuplicate">Additional Advance</label>
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
                            <label for="txtQty">Qty:</label>
                            <input type="text" id="txtQty" style="width:100px;text-align:right" tabindex="17" />
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
                            Slip No :
                            <input type="text" id="txtSlipNo" style="width:200px" tabindex="25" />
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
                            <button id="btnUpdate" class="btn btn-primary" onclick="SaveDetail()">Save</button>
                            <button id="btnHide" class="btn btn-danger" data-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
            </div>
            <div id="frmHeader" class="modal modal-lg fade">
                <div class="modal-dialog-lg">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal"></button>
                            <h4 class="modal-title"><label id="lblHeader">Clearing List</label></h4>
                        </div>
                        <div class="modal-body">
                            <table id="tbHeader" class="table table-responsive">
                                <thead>
                                    <tr>
                                        <th>ClrNo</th>
                                        <th>ClrDate</th>
                                        <th>CustCode</th>
                                        <th>ReqBy</th>
                                        <th>Job</th>
                                        <th>Inv No</th>
                                        <th>Status</th>
                                        <th>ClrAmount</th>
                                        <th>Currency</th>
                                        <th>AdvNo</th>
                                        <th>AdvAmount</th>
                                        <th>Remark</th>
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
        </div>
    </div>
    <div id="dvLOVs"></div>
</div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    var user = '@ViewBag.User';
    var userRights = '@ViewBag.UserRights';
    var serv = []; //must be array of object
    var hdr = {}; //simple object
    var dtl = {}; //simple object
    var job = '';
    var isjobmode = false;
    var chkmode = false;
    $(document).ready(function () {
        SetLOVs();
        SetEvents();
        SetEnterToTab();
        CheckParam();
    });
    function CheckParam() {
        //read query string parameters
        var br = getQueryString('BranchCode');
        if (br.length > 0) {
            $('#txtBranchCode').val(br);
            ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            var ano = getQueryString('ClrNo');
            if (ano.length > 0) {
                $('#txtClrNo').val(ano);
                ShowData(br, $('#txtClrNo').val());
            } else {
                job = getQueryString('JNo');
                if (job.length > 0) {
                    isjobmode = true;
                    $('#txtClrNo').attr('disabled', 'disabled');
                    CallBackQueryJob(path, $('#txtBranchCode').val(), job, LoadJob);
                }
            }

        }
    }
    function LoadJob(dt) {
        if (dt.length > 0) {
            var dr = dt[0];
            $('#txtForJNo').val(dr.JNo);
            $('#txtInvNo').val(dr.InvNo);
            $('#cboJobType').val(CCode(dr.JobType));
            $('#cboDocStatus').val('01');

            $('#btnBrowseCust').attr('disabled', 'disabled');
            $('#txtForJNo').attr('disabled', 'disabled');
            $('#btnBrowseJ').attr('disabled', 'disabled');
            $('#cboJobType').attr('disabled', 'disabled');            

            $('#txtEmpCode').val(user);
            ShowUser(path, $('#txtEmpCode').val(), '#txtEmpName');

            $('#txtEmpCode').focus();
        }
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
            if ($('#cboSTCode').val() == 'ADV') {
                $('#txtSICode').attr('disabled', 'disabled');
                $('#txtSDescription').attr('disabled', 'disabled');
                $('#btnBrowseS').attr('disabled', 'disabled');
                return;
            }
            $('#txtSICode').removeAttr('disabled');
            $('#txtSDescription').removeAttr('disabled');
            $('#btnBrowseS').removeAttr('disabled');
        });
        
        $('#chkApprove').on('click', function () {
            chkmode = this.checked;
            CallBackAuthorize(path, 'MODULE_CLR', 'Approve',(chkmode ? 'I':'D'), SetApprove);
        });
        $('#chkReceive').on('click', function () {
            chkmode = this.checked;
            CallBackAuthorize(path, 'MODULE_CLR', 'Receive', (chkmode ? 'I' : 'D'), SetClear);
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
                ShowUser(path, $('#txtEmpCode').val(), '#txtEmpName');
            }
        });
        $('#txtSICode').keydown(function (event) {
            if (event.which == 13) {
                var dt = FindService($('#txtSICode').val())
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
        $('#txtExcRate').keydown(function (event) {
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
                ShowInvNo(path, $('#txtBranchCode').val(), $('#txtForJNo').val(), '#txtInvNo');
            }
        });
        $('#txtNET').keydown(function (event) {
            if (event.which == 13) {
                var type = $('#txtVatType').val();
                if (type == '') type = "1";
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
            $('#txtApproveBy').val(chkmode ? user : '');
            $('#txtApproveDate').val(chkmode ? CDateEN(GetToday()) : '');
            $('#txtApproveTime').val(chkmode ? ShowTime(GetTime()) : '');
            return;
        }
        alert('You are not allow to ' + (b ? 'approve Advance!' : 'cancel approve!'));
        $('#chkApprove').prop('checked', !chkmode);
    }
    function SetClear(b) {
        if (b == true) {
            $('#txtReceiveBy').val(chkmode ? user : '');
            $('#txtReceiveDate').val(chkmode ? CDateEN(GetToday()) : '');
            $('#txtReceiveTime').val(chkmode ? ShowTime(GetTime()) : '');
            return;
        }
        alert('You are not allow to ' + (b ? 'Clear!' : 'cancel clear!'));
        $('#chkReceive').prop('checked', !chkmode);
    }
    function SetCancel(b) {
        if (b == true) {
            $('#txtCancelProve').val(chkmode ? user : '');
            $('#txtCancelDate').val(chkmode ? CDateEN(GetToday()) : '');
            $('#txtCancelTime').val(chkmode ? ShowTime(GetTime()) : '');
            return;
        }
        alert('You are not allow to ' + (b ? 'cancel Advance!' : 'do this!'));
        $('#chkCancel').prop('checked', !chkmode);
    }
    function SetLOVs() {
        //Combos
        var lists = 'JOB_TYPE=#cboJobType';
        lists += ',SHIP_BY=#cboShipBy';
        lists += ',CLR_STATUS=#cboDocStatus';
        lists += ',CLR_TYPE=#cboClrType';
        lists += ',CLR_FROM=#cboClrFrom';

        loadCombos(path, lists);

        LoadService();

        //3 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            var dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv, '#frmSearchCust', '#tbCust', 'Customers', response, 3);
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
            CreateLOV(dv, '#frmSearchExpCur', '#tbExpCur', 'Currency Code', response,4);
        });
    }
    function ShowData(branchcode, clrno) {
        if (branchcode == '') {
            alert('Please select branch');
            return;
        }
        if (clrno == '') {
            alert('Please enter clear no');
            return;
        }
        if (userRights.indexOf('R') < 0) {
            alert('you are not authorize to view data');
            return;
        }
        $.get(path + 'adv/getclearing?branchcode='+branchcode+'&clrno='+ advno, function (r) {
            var h = r.clr.header[0];
            ReadClrHeader(h);
            var d = r.clr.detail;
            ReadClrDetail(d);
        });
    }
    function PrintData() {
        if (userRights.indexOf('P') < 0) {
            alert('you are not authorize to print');
            return;
        }
        window.open(path + 'Clr/FormClr?branch=' + $('#txtBranchCode').val() + '&clrno=' + $('#txtClrNo').val());
    }
    function SaveHeader() {
        if (hdr != undefined) {
            var obj = GetDataHeader(hdr);
            if (obj.ClrNo == '') {
                if (userRights.indexOf('I') < 0) {
                    alert('you are not authorize to add');
                    return;
                }
            }
            if (userRights.indexOf('E') < 0) {
                alert('you are not authorize to save');
                return;
            }
            var jsonString = JSON.stringify({ data: obj });
            //alert(jsonString);
            $.ajax({
                url: "@Url.Action("SetClrHeader", "Clr")",
                type: "POST",
                contentType: "application/json",
                data: jsonString,
                success: function (response) {
                    alert(response.result.msg);
                    if (response.result.data !== null) {
                        $('#txtClrNo').val(response.result.data);
                        ShowData($('#txtBranchCode').val(), $('#txtClrNo').val());
                    }
                },
                error: function (e) {
                    alert(e);
                }
            });
            return;
        }
        alert('No data to save');
    }
    function GetDataHeader() {
        var dt = {
            BranchCode : $('#txtBranchCode').val(),
            ClrNo : $('#txtClrNo').val(),
            ClrDate: CDateTH($('#txtClrDate').val()),
            ClearanceDate: CDateTH($('#txtClearanceDate').val()),
            EmpCode : $('#txtEmpCode').val(),
            Doc50Tavi : $('#txtDoc50Tavi').val(),
            CTN_NO : $('#txtCTN_NO').val(),
            TRemark: $('#txtTRemark').val(),
            CoPersonCode: $('#txtCoPersonCode').val(),

            CancelProve : $('#txtCancelProve').val(),
            CancelReson : $('#txtCancelReson').val(),
            CancelDate : CDateTH($('#txtCancelDate').val()),
            CancelTime : $('#txtCancelTime').val(),

            ReceiveBy : $('#txtReceiveBy').val(),
            ReceiveDate : CDateTH($('#txtReceiveDate').val()),
            ReceiveTime : $('#txtReceiveTime').val(),
            ReceiveRef : $('#txtReceiveRef').val(),

            ApproveBy : $('#txtApproveBy').val(),
            ApproveDate : CDateTH($('#txtApproveDate').val()),
            ApproveTime : $('#txtApproveTime').val(),

            AdvTotal : CNum($('#txtAdvTotal').val()),
            TotalExpense : CNum($('#txtTotalExpense').val()),
            ClearTotal : CNum($('#txtClearTotal').val()),

            JobType : $('#cboJobType').val(),
            ClearType: $('#cboClrType').val(),
            ClearFrom: $('#cboClrFrom').val(),
            DocStatus: $('#cboDocStatus').val(),

            JNo: null,
            InvNo: null,
            AdvRefNo :null
        };

        return dt;
    }
    function ReadClrHeader(dt) {
        if (dt != undefined) {
            ClearHeader();
            hdr = dt;
            $('#txtBranchCode').val(dt.BranchCode);
            $('#txtClrNo').val(dt.ClrNo);
            $('#txtClrDate').val(CDateEN(dt.ClrDate));
            $('#txtClearanceDate').val(CDateEN(dt.ClearanceDate));
            
            $('#txtEmpCode').val(dt.EmpCode);
            $('#cboJobType').val(CCode(dt.JobType));
            $('#txtCTN_NO').val(dt.CTN_NO);
            $('#txtCoPersonCode').val(dt.CoPersonCode);
            $('#txtTRemark').val(dt.TRemark);

            $('#txtCancelProve').val(dt.CancelProve);
            $('#txtCancelReson').val(dt.CancelReson);
            $('#txtCancelDate').val(CDateEN(dt.CancelDate));
            $('#txtCancelTime').val(ShowTime(dt.CancelTime));

            $('#txtReceiveBy').val(dt.ReceiveBy);
            $('#txtReceiveDate').val(CDateEN(dt.ReceiveDate));
            $('#txtReceiveTime').val(ShowTime(dt.ReceiveTime));
            $('#txtReceiveRef').val(dt.ReceiveRef);

            $('#txtApproveBy').val(dt.ApproveBy);
            $('#txtApproveDate').val(CDateEN(dt.ApproveDate));
            $('#txtApproveTime').val(ShowTime(dt.ApproveTime));

            $('#txtAdvTotal').val(CDbl(dt.AdvTotal,4));
            $('#txtTotalExpense).val(CDbl(dt.TotalExpense, 4));
            $('#txtClearTotal').val(CDbl(dt.ClearTotal,4));

            $('#chkCancel').prop('checked', $('#txtCancelProve').val() == '' ? false : true);
            $('#chkApprove').prop('checked', $('#txtApproveBy').val() == '' ? false : true);
            $('#chkReceive').prop('checked', $('#txtReceiveBy').val() == '' ? false : true);

            //Combos
            $('#cboClrType').val(CCode(dt.ClearType));
            $('#cboClrFrom').val(CCode(dt.ClearFrom));
            $('#cboDocStatus').val(CCode(dt.DocStatus));

            ShowUser(path, $('#txtEmpCode').val(), '#txtEmpName');

            ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');

            if (dt.DocStatus > 2) {
                //if document paymented/cancelled/cleared then disable save button
                $('#btnSave').attr('disabled', 'disabled');
            } else {
                //if document approved by this user or not then check authorized to unlock
                if (dt.DocStatus == 2 && user == dt.ApproveBy && userRights.indexOf('E') >= 0) {
                    $('#btnSave').removeAttr('disabled');
                } else {
                    if (dt.DocStatus == 2) {
                        $('#btnSave').attr('disabled', 'disabled');
                    }
                }
            }
            return;
        }
        ClearHeader();
    }
    function AddHeader() {
        if (userRights.indexOf('I') < 0) {
            alert('you are not authorize to add');
            return;
        }
        $('#txtClrNo').val('');
        $.get(path + 'clr/getnewclearheader?branchcode=' + $('#txtBranchCode').val() , function (r) {
            var h = r.clr.header;
            ReadClrHeader(h);
            if (isjobmode == false) {
                $('#cboJobType').val('');
                $('#cboDocStatus').val('01');
                $('#cboClrType').val('01');
                $('#cboClrFrom').val('01');
            }
            $('#txtEmpCode').val(user);

            ShowUser(path, $('#txtEmpCode').val(), '#txtEmpName');
            var d = r.clr.detail;
            ReadClrDetail(d);
            ClearDetail();
            $('#txtClrNo').focus();
        });
    }
    function AddDetail() {
        $.get(path + 'clr/getnewcleardetail?branchcode=' + $('#txtBranchCode').val() + '&clrno=' + $('#txtClrNo').val(), function (r) {
            var d = r.clr.detail[0];
            LoadDetail(d);
            $('#frmDetail').modal('show');
            $('#txtSICode').focus();
        });
    }
    function DeleteDetail() {
        if (dtl != undefined) {
            if (userRights.indexOf('D') < 0) {
                alert('you are not authorize to delete');
                return;
            }
            $.get(path + 'clr/delclrdetail?branchcode=' + $('#txtBranchCode').val() + '&clrno=' + $('#txtClrNo').val() + '&itemno=' + dtl.ItemNo, function (r) {
                alert(r.clr.result);
                ShowData($('#txtBranchCode').val(), $('#txtClrNo').val());
            });
        } else {
            alert('No data to delete');
        }
    }
    function ClearHeader() {
        hdr = {};
        $('#txtClrDate').val('');
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

        $('#txtAdvTotal').val('');
        $('#txtTotalExpense').val('');
        $('#txtClearTotal').val('');

        $('#chkCancel').prop('checked', $('#txtCancelProve').val() == '' ? false : true);
        $('#chkApprove').prop('checked', $('#txtApproveBy').val() == '' ? false : true);
        $('#chkReceive').prop('checked', $('#txtReceiveBy').val() == '' ? false : true);


        //Combos
        $('#cboClrType').val('01');
        $('#cboClrFrom').val('01');
        $('#cboDocStatus').val('01');

        ShowUser(path, $('#txtEmpCode').val(), '#txtEmpName');

        $('#btnPrint').attr('disabled', 'disabled');
        $('#btnAdd').attr('disabled', 'disabled');
        $('#btnDel').attr('disabled', 'disabled');

        if (userRights.indexOf('E') >= 0){
            $('#btnSave').removeAttr('disabled');
        }
        if (userRights.indexOf('I') >= 0) {
            $('#btnSave').removeAttr('disabled');
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
            alert('Please add header before');
            return;
        }
        if (hdr.AdvNo == '') {
            alert('Please save header first');
            return;
        }
        if (dtl != undefined) {
            var obj = GetDataDetail();
            if (obj.ItemNo == 0) {
                if (userRights.indexOf('I') < 0) {
                    alert('you are not authorize to add');
                    return;
                }
            }
            if (userRights.indexOf('E') < 0) {
                alert('you are not authorize to edit');
                return;
            }
            var jsonString = JSON.stringify({ data: obj });
            //alert(jsonString);
            $.ajax({
                url: "@Url.Action("SetClrDetail", "Clr")",
                type: "POST",
                contentType: "application/json",
                data: jsonString,
                success: function (response) {
                    alert(response.result.msg);
                    ShowData($('#txtBranchCode').val(), $('#txtClrNo').val());
                }
            });
            return;
        }
        alert('No data to save');
    }

    function ReadClrDetail(dt) {
        $('#tbDetail').DataTable({
            data:dt,
            selected: true, //ให้สามารถเลือกแถวได้
            columns: [ //กำหนด property ของ header column
                { data: null, title: "Edit" },
                { data: "SICode", title: "Service" },
                { data: "SDescription", title: "Description" },
                { data: "JobNo", title: "Job" },
                { data: "AdvAmount", title: "Advance" },
                { data: "UsedAmount", title: "Clear" },
                { data: "ChargeVAT", title: "VAT" },
                { data: "Tax50Tavi", title: "WH-Tax" },
                { data: "BCost", title: "Net" },
                { data: "CurrencyCode", title: "Currency" },
                { data: "SlipNo", title: "Slip No" }
            ],
            "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                {
                    "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                    "data": null,
                    "render": function (data, type, full, meta) {
                        var html = "<button class='btn btn-warning'>Edit</button>";
                        return html;
                    }
                }
            ],
            destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
        });
        $('#tbDetail tbody').on('click', 'tr', function () {
            $('#tbDetail tbody > tr').removeClass('selected');
            $(this).addClass('selected');
            var data = $('#tbDetail').DataTable().row(this).data(); //read current row selected
            LoadDetail(data); //callback function from caller
        });
        $('#tbDetail tbody').on('click', 'button', function () {
            $('#frmDetail').modal('show');
            $('#txtSICode').focus();
        });
    }
    function GetDataDetail() {
        var dt = {
            BranchCode: $('#txtBranchCode').val(),
            ClrNo: $('#txtClrNo').val(),
            ItemNo: $('#txtItemNo').val(),
            LinkItem: dtl.LinkItem,
            SICode: $('#txtSICode').val(),
            STCode: $('#cboSTCode').val(),
            SDescription: $('#txtSDescription').val(),
            VenderCode: $('#txtVenCode').val(),
            Qty: $('#txtAdvQty').val(),
            UnitCode: dtl.UnitCode,
            CurrencyCode: $('#txtCurrencyCode').val(),
            CurRate: $('#txtExcRate').val(),
            UnitPrice: $('#txtUnitPrice').val(),
            FPrice: dtl.FPrice,
            BPrice: dtl.BPrice,
            QUnitPrice: dtl.QUnitPrice,
            QFPrice: dtl.QFPrice,
            QBPrice: dtl.QBPrice,
            UnitCost: dtl.UnitCost,
            FCost: dtl.FCost,
            BCost: dtl.BCost,
            ChargeVAT: $('#txtVAT').val(),
            Tax50Tavi: $('#txtWHT').val(),
            AdvNo: dtl.AdvNo,
            AdvItemNo: dtl.AdvItemNo,
            AdvAmount: dtl.AdvAmount,
            UsedAmount: $('#txtNET').val(),
            IsQuoItem: dtl.IsQuoItem,
            SlipNo: dtl.SlipNo,
            Remark: $('#txtRemark').val(),
            IsLtdAdv50Tavi: dtl.IsLtdAdv50Tavi,
            Pay50TaviTo: dtl.Pay50TaviTo,
            ForJNo: $('#txtForJNo').val(),
            NO50Tavi: dtl.NO50Tavi,
            Date50Tavi: dtl.Date50Tavi,
            VenderBillingNo: $('#VenderBillingNo').val(),
            AirQtyStep: dtl.AirQtyStep,
            StepSub: dtl.StepSub,
            LinkBillNo : dtl.LinkBillNo,
            JobNo : $('#txtForJNo').val(),
            VATType : $('#txtVatType').val(),
            VATRate: $('#txtVATRate').val(),
            Tax50TaviRate : $('#txtWHTRate').val(),
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
            var r = FindService($('#txtSICode').val())
            ReadService(r);
            if (isjobmode == false) {
                $('#txtForJNo').val(dt.JobNo);
                $('#txtInvNo').val('');
                if ($('#txtForJNo').val()!= '') {
                    ShowInvNo(path, $('#txtBranchCode').val(), $('#txtForJNo').val(), '#txtInvNo');
                }
            }
            $('#txtQty').val(dt.Qty);
            $('#txtExcRate').val(dt.ExcRate);
            $('#txtUnitPrice').val(dt.UnitPrice);
            CalAmount();
            $('#txtRemark').val(dt.Remark);
            $('#txt50Tavi').val(dt.NO50Tavi);
            $('#txtPayChqTo').val(dt.Pay50TaviTo);
            $('#txtSDescription').val(dt.SDescription);
            $('#txtVatType').val(dt.VATType);
            $('#txtVATRate').val(dt.VATRate);
            $('#txtWHTRate').val(dt.Tax50TaviRate);
            $('#txtAMT').val(dt.BCost);
            $('#txtVAT').val(dt.ChargeVAT);
            $('#txtWHT').val(dt.Tax50Tavi);
            $('#txtNET').val(dt.UsedAmount);
            $('#txtVenCode').val(dt.VenderCode);
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
        $('#cboSTCode').val('STD');
        if (isjobmode == false) {
            $('#txtForJNo').val('');
            $('#txtInvNo').val('');
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
        $('#txtAMTCal').val(0);
        $('#txtQty').val(1);
        $('#txtExcRate').val($('#txtExchangeRate').val());
        $('#txtUnitPrice').val(0);
        $('#txtCurrencyCode').val($('#txtSubCurrency').val());
        ShowCurrency(path, $('#txtSubCurrency').val(), '#txtCurrencyName');
        ShowCaption();
        $('#txtVenCode').val('');

        $('#chkDuplicate').prop('checked', false);
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
        var c = $.grep(serv, function (data) {
            return data.SICode === Code;
        });
        return c[0];
    }
    function SetGridClr() {
        var w = $('#txtBranchCode').val();
        if (job.length > 0) {
            w += '&jobno=' + job;
        }
        if ($('#cboJobType').val() !== '') {
            w += '&jtype=' + $('#cboJobType').val();
        }
        if ($('#cboShipBy').val() !== '') {
            w += '&sby=' + $('#cboShipBy').val();
        }
        $.get(path + 'clr/getclearinggrid?branchcode=' +  w, function (r) {
            if (r.clr.data.length == 0) {
                alert('data not found on this branch');
                return;
            }
            var h = r.clr.data[0].Table;
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
                    { data: "TotalExpense", title: "Total" },
                    { data: "CurrencyCode", title: "Currency" },
                    { data: "AdvNo", title: "Adv No" },
                    { data: "AdvTotal", title: "Adv Total" },
                    { data: "TRemark", title: "Remark" },
                ],
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            });
            $('#tbHeader tbody').on('click', 'tr', function () {
                $('#tbHeader tbody > tr').removeClass('selected');
                $(this).addClass('selected');
                var data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
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
            case 'clearing':
                SetGridAdv();
                break;
            case 'branch':
                SetGridBranch(path, '#tbBranch', '#frmSearchBranch', ReadBranch);
                break;
            case 'clrby':
                SetGridUser(path, '#tbClr', '#frmSearchClr', ReadClrBy);
                break;
            case 'customer':
                SetGridCompany(path, '#tbCust', '#frmSearchCust', ReadCustomer);
                break;
            case 'servicecode':
                SetGridSICode(path, '#tbServ', "", '#frmSearchSICode', ReadService);
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
        }
    }
    function GetParam() {
        var strParam = '?';
        strParam += 'Branch=' + $('#txtBranchCode').val();
        strParam += '&JType=' + $('#cboJobType').val().substr(0, 2);
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
    function ReadClrBy(dt) {
        $('#txtEmpCode').val(dt.UserID);
        $('#txtEmpName').val(dt.TName);
        $('#txtEmpCode').focus();
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
            $('#txtSDescription').val(dt.NameThai);
            $('#txtVatType').val(dt.IsTaxCharge);
            $('#txtVATRate').val(dt.IsTaxCharge == "0" ? "0" : "7");
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
        $('#txtForJNo').val(dt.JNo);
        $('#txtInvNo').val(dt.InvNo);
        $('#txtForJNo').focus();
    }
    
    function GetTotal() {
        return CDbl(CNum($('#txtTotalClear').val()) / CNum($('#txtExchangeRate').val()) ,4);
    }
    function CalAmount() {
        var price = CDbl($('#txtUnitPrice').val(),4);
        var qty = CDbl($('#txtAdvQty').val(),4);
        var rate = CDbl($('#txtExcRate').val(),4); //rate ของ detail
        var type = $('#txtVatType').val();
        if (qty > 0) {
            var amt = CNum(qty) * CNum(price);
            $('#txtAMTCal').val(CDbl(CNum(amt), 4));
            //var exc = CDbl($('#txtExchangeRate').val(), 4); //rate ของ header
            //var total = CDbl(CNum(amt) / CNum(exc),4);
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
        var amt = CDbl($('#txtAMT').val(),4);
        var vat = CDbl($('#txtVAT').val(),4);
        var wht = CDbl($('#txtWHT').val(),4);
        var net = CDbl($('#txtNET').val(),4);
        var type = $('#txtVatType').val();
        if (type == '') type = '1';
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
        var type = $('#txtVatType').val();
        if (type == '') type = '1';
        var amt = CDbl($('#txtAMT').val(),4);
        if (type == '2') {
            amt = CDbl($('#txtNET').val(),4);
        }
        var vatrate = CDbl($('#txtVATRate').val(),4);
        var whtrate = CDbl($('#txtWHTRate').val(),4);
        var vat = 0;
        var wht = 0;
        if (type == "2") {
            var base = amt * 100 / (100 + (vatrate - whtrate));
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
</script>