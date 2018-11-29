
@Code
    ViewBag.Title = "Advance Information"
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
                Request Date :
                <input type="date" id="txtAdvDate" tabindex="1"/>
            </div>
            <div class="col-sm-4" style="text-align:left">
                <table border="1">
                    <tr>
                        <td>
                            <b><a onclick="SearchData('advance')">Advance No:</a></b>
                            <br />
                            <input type="text" id="txtAdvNo" style="font-style:bold;font-size:20px;text-align:center" tabindex="0" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <ul class="nav nav-tabs">
            <li class="active"><a data-toggle="tab" href="#tabHeader">Advance Header</a></li>
            <li><a data-toggle="tab" href="#tabDetail">Advance Detail</a></li>
        </ul>
        <div class="tab-content">
            <div id="tabHeader" class="tab-pane fade in active">
                <div class="row">
                    <div class="col-sm-7">
                        <table>
                            <tr>
                                <td>
                                    Advance By :
                                </td>
                                <td>
                                    <input type="text" id="txtAdvBy" style="width:100px" tabindex="2" />
                                    <button id="btnBrowseEmp1" onclick="SearchData('advby')">...</button>
                                    <input type="text" id="txtAdvName" style="width:300px" disabled />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Request By :
                                </td>
                                <td>
                                    <input type="text" id="txtReqBy" style="width:100px" tabindex="3" />
                                    <button id="btnBrowseEmp2" onclick="SearchData('reqby')">...</button>
                                    <input type="text" id="txtReqName" style="width:300px" disabled />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Advance For :
                                </td>
                                <td>
                                    <input type="text" id="txtCustCode" style="width:120px" tabindex="4" />
                                    <input type="text" id="txtCustBranch" style="width:50px" tabindex="5" />
                                    <button id="btnBrowseCust" onclick="SearchData('customer')">...</button>
                                    <input type="text" id="txtCustName" style="width:300px" disabled />
                                </td>
                            </tr>
                        </table>
                        <table>
                            <tr>
                                <td>
                                    WH-Tax No:
                                </td>
                                <td>
                                    <input type="text" id="txtDoc50Tavi" style="width:200px" tabindex="6" />
                                </td>
                                <td>
                                    Bill A/P:
                                </td>
                                <td>
                                    <input type="text" id="txtPaymentNo" style="width:200px" tabindex="7" />
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
                        <textarea id="txtTRemark" style="width:100%;height:80px" tabindex="11"></textarea>
                    </div>
                    <div class="col-sm-5">
                        <br />
                        Payment Method:
                        <table>
                            <tr>
                                <td>
                                    <input type="checkbox" id="chkCash" />
                                    <label for="chkCash">Cash</label>
                                </td>
                                <td>
                                    <input type="text" id="txtAdvCash" style="width:100px;text-align:right" disabled/>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <input type="checkbox" id="chkChq" />
                                    <label for="chkChq">Cashier Chq</label>
                                </td>
                                <td>
                                    <input type="text" id="txtAdvChq" style="width:100px;text-align:right" disabled/>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <input type="checkbox" id="chkChqCash" />
                                    <label for="chkChqCash">Customer Chq</label>
                                </td>
                                <td>
                                    <input type="text" id="txtAdvChqCash" style="width:100px;text-align:right" disabled/>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <input type="checkbox" id="chkCred" />
                                    <label for="chkCred">Credit</label>
                                </td>
                                <td>
                                    <input type="text" id="txtAdvCred" style="width:100px;text-align:right" disabled/>
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
                        <input type="checkbox" id="chkPayment" />
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
                                    <th>Amount</th>
                                    <th>Vat</th>
                                    <th>WH-Tax</th>
                                    <th>Net</th>
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

            </div>
            <div id="frmDetail" class="modal fade" role="dialog">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal"></button>
                            <h4 class="modal-title"><label id="lblHeader">Advance Detail</label></h4>
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
                            <label for="txtAmount">Amount :</label>
                            <input type="text" id="txtAMT" style="width:100px;text-align:right" tabindex="15" />
                            <label for="txtVATRate">VAT :</label>
                            <input type="text" id="txtVATRate" style="width:50px;text-align:right" tabindex="16" />
                            Type :
                            <select id="txtVatType" class="dropdown" disabled>
                                <option value="0">NO</option>
                                <option value="1">EX</option>
                                <option value="2">IN</option>
                            </select>
                            <input type="text" id="txtVAT" style="width:100px;text-align:right" tabindex="17" />
                            <br />
                            <label for="txtWHTRate">WH-Tax :</label>
                            <input type="text" id="txtWHTRate" style="width:50px;text-align:right" tabindex="18" />
                            <input type="text" id="txtWHT" style="width:100px;text-align:right" tabindex="19" />
                            Reference No :
                            <input type="text" id="txt50Tavi" style="width:200px" />
                            <br />
                            <label for="txtNETAmount">Net Amount :</label>
                            <input type="text" id="txtNET" style="width:100px;text-align:right" tabindex="20" />
                            Pay To Vender :
                            <input type="text" id="txtPayChqTo" style="width:220px" />
                            <br />
                            Remark : 
                            <textarea id="txtRemark" style="width:100%;height:80px" tabindex="21"></textarea>
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
                            <h4 class="modal-title"><label id="lblHeader">Advance List</label></h4>
                        </div>
                        <div class="modal-body">
                            <table id="tbHeader" class="table table-responsive">
                                <thead>
                                    <tr>
                                        <th>AdvNo</th>
                                        <th>AdvDate</th>
                                        <th>CustCode</th>
                                        <th>ReqBy</th>
                                        <th>Job</th>
                                        <th>Status</th>
                                        <th>Amount</th>
                                        <th>WTDoc</th>
                                        <th>APDoc</th>
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
        var ano = getQueryString('AdvNo');
        var jno = getQueryString('JNo');
        var jt = getQueryString('JType');
        var sb = getQueryString('SBy');

        //Combos
        var lists = 'JOB_TYPE=#cboJobType';
        lists += ',SHIP_BY=#cboShipBy';
        lists += ',ADV_STATUS=#cboDocStatus';
        lists += ',ADV_TYPE=#cboAdvType';

        loadCombos(path, lists);

        LoadService();        
        if (br.length > 0) {
            $('#txtBranchCode').val(br);
        }
        ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName')
        if (jno.length > 0) {
            job = jno;
            isjobmode = true;

            CallBackQueryJob(path, $('#txtBranchCode').val(), jno, LoadJob);
        } else {
            AddHeader();
        }
        if (ano.length > 0) {
            $('#txtAdvNo').val(ano);
            ShowData($('#txtBranchCode').val(), $('#txtAdvNo').val());
        } 
    }
    function LoadJob(dt) {
        if (dt.length > 0) {
            var dr = dt[0];
            $('#txtForJNo').val(dr.JNo);
            $('#txtCustCode').val(dr.CustCode);
            $('#txtCustBranch').val(dr.CustBranch);
            $('#txtInvNo').val(dr.InvNo);
            $('#cboJobType').val(CCode(dr.JobType));
            $('#cboShipBy').val(CCode(dr.ShipBy));

            ShowCustomer(path, $('#txtCustCode').val(), $('#txtCustBranch').val(), '#txtCustName');
            
            $('#txtCustCode').attr('disabled', 'disabled');
            $('#txtCustBranch').attr('disabled', 'disabled');
            $('#btnBrowseCust').attr('disabled', 'disabled');
            $('#txtForJNo').attr('disabled', 'disabled');
            $('#btnBrowseJ').attr('disabled', 'disabled');
            $('#cboJobType').attr('disabled', 'disabled');
            $('#cboShipBy').attr('disabled', 'disabled');
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
        if (userRights.indexOf('E') < 0) $('#btnSave').attr('disabled', 'disabled');
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
        $('#chkCash,#chkChq,#chkChqCash,#chkCred').on('click', function () {
            var id = this.id;
            var chk = this.checked;
            if (this.checked == false) {
                $('#txtAdv' + id.substr(3)).val(0);
                $('#txtAdv' + id.substr(3)).attr('disabled', 'disabled');
                return;
            }
            var val = GetTotal();
            if (val <= 0) {
                alert('Total not Balance,Please check');
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
                    alert('Total not Balance,Please check');
                    $('#' + this.id).val(0);
                }
                var amt = $('#' + this.id).val();
                $('#chk' + this.id.substr(6)).prop('checked', amt > 0 ? true : false);
            }
        });
        $('#txtAdvCash,#txtAdvChq,#txtAdvChqCash,#txtAdvCred').on('blur', function () {
            var amt = $('#' + this.id).val();
            if (amt > 0) {
                if ($('#chk' + this.id.substr(6)).prop('checked') == false) {
                    $('#' + this.id).val(0);
                    $('#' + this.id).attr('disabled', 'disabled');
                } else {
                    if (GetTotal() < 0) {
                        $('#' + this.id).val(0);
                        $('#chk' + this.id.substr(6)).prop('checked', false);
                        $('#' + this.id).attr('disabled', 'disabled');
                        alert('Total not Balance,Please check');
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
        $('#chkPayment').on('click', function () {
            chkmode = this.checked;
            CallBackAuthorize(path, 'MODULE_ADV', 'Payment', (chkmode ? 'I' : 'D'), SetPayment);
        });
        $('#chkCancel').on('click', function () {
            chkmode = this.checked;
            CallBackAuthorize(path, 'MODULE_ADV', 'Index', 'D', SetCancel);
        });
        $('#txtBranchCode').keydown(function (event) {
            if (event.which == 13) {
                ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            }
        });
        $('#txtAdvNo').keydown(function (event) {
            if (event.which == 13) {
                isjobmode = false;
                ShowData($('#txtBranchCode').val(),$('#txtAdvNo').val());
            }
        });
        $('#txtAdvBy').keydown(function (event) {
            if (event.which == 13) {
                ShowUser(path, $('#txtAdvBy').val(), '#txtAdvName');
            }
        });
        $('#txtReqBy').keydown(function (event) {
            if (event.which == 13) {
                ShowUser(path, $('#txtReqBy').val(), '#txtReqName');
            }
        });
        $('#txtCustBranch').keydown(function (event) {
            if (event.which == 13) {
                ShowCustomer(path, $('#txtCustCode').val(), $('#txtCustBranch').val(), '#txtCustName');
            }
        });
        $('#txtSICode').keydown(function (event) {
            if (event.which == 13) {
                var dt = FindService($('#txtSICode').val())
                ReadService(dt);
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
    function SetPayment(b) {
        if (b == true) {
            $('#txtPaymentBy').val(chkmode ? user : '');
            $('#txtPaymentDate').val(chkmode ? CDateEN(GetToday()) : '');
            $('#txtPaymentTime').val(chkmode ? ShowTime(GetTime()) : '');
            return;
        }
        alert('You are not allow to ' + (b ? 'payment Advance!' : 'cancel payment!'));
        $('#chkPayment').prop('checked', !chkmode);
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
        //3 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            var dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv, '#frmSearchCust', '#tbCust', 'Customers', response, 3);
            //Job
            CreateLOV(dv, '#frmSearchJob', '#tbJob', 'Job List', response, 3);
            //Users
            CreateLOV(dv, '#frmSearchAdv', '#tbAdv', 'Advance By', response, 2);
            CreateLOV(dv, '#frmSearchReq', '#tbReq', 'Request By', response, 2);
            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response, 2);
            //SICode
            CreateLOV(dv, '#frmSearchSICode', '#tbServ', 'Service Code', response, 2);
        });
    }
    function ShowData(branchcode,advno) {
        $.get(path + 'adv/getadvance?branchcode='+branchcode+'&advno='+ advno, function (r) {
            var h = r.adv.header[0];
            ReadAdvHeader(h);
            var d = r.adv.detail;
            ReadAdvDetail(d);
        });
    }
    function PrintData() {
        window.open(path + 'Adv/FormAdv?branch=' + $('#txtBranchCode').val() + '&advno=' + $('#txtAdvNo').val());
    }
    function SaveHeader() {
        if (hdr != undefined) {
            var obj = GetDataHeader(hdr);
            var jsonString = JSON.stringify({ data: obj });
            //alert(jsonString);
            $.ajax({
                url: "@Url.Action("SaveAdvanceHeader", "Adv")",
                type: "POST",
                contentType: "application/json",
                data: jsonString,
                success: function (response) {                
                    alert(response.result.msg);
                    if (response.result.data !== null) {
                        $('#txtAdvNo').val(response.result.data);
                        ShowData($('#txtBranchCode').val(), $('#txtAdvNo').val());
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
            AdvNo : $('#txtAdvNo').val(),
            AdvDate : CDateTH($('#txtAdvDate').val()),
            EmpCode : $('#txtAdvBy').val(),
            AdvBy : $('#txtReqBy').val(),
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

            TotalAdvance : CNum($('#txtAdvAmount').val()),
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
            PayChqDate: ''
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
            $('#txtAdvBy').val(dt.EmpCode);
            $('#txtReqBy').val(dt.AdvBy);
            if (isjobmode == false) {
                $('#txtCustCode').val(dt.CustCode);
                $('#txtCustBranch').val(dt.CustBranch);
                $('#cboJobType').val(CCode(dt.JobType));
                $('#cboShipBy').val(CCode(dt.ShipBy));
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

            $('#txtAdvCash').val(CDbl(dt.AdvCash,2));
            $('#txtAdvChq').val(CDbl(dt.AdvChq, 2));
            $('#txtAdvChqCash').val(CDbl(dt.AdvChqCash, 2));
            $('#txtAdvCred').val(CDbl(dt.AdvCred, 2));

            $('#txtAdvAmount').val(CDbl(dt.TotalAdvance, 2));
            $('#txtVatAmount').val(CDbl(dt.TotalVAT, 2));
            $('#txtWhtAmount').val(CDbl(dt.Total50Tavi, 2));
            $('#txtTotalAmount').val(CDbl((dt.TotalAdvance+dt.TotalVAT-dt.Total50Tavi),2));

            $('#chkCancel').prop('checked', $('#txtCancelProve').val() == '' ? false : true);
            $('#chkApprove').prop('checked', $('#txtApproveBy').val() == '' ? false : true);
            $('#chkPayment').prop('checked', $('#txtPaymentBy').val() == '' ? false : true);

            $('#chkCash').prop('checked', dt.AdvCash > 0 ? true : false);
            $('#chkChq').prop('checked', dt.AdvChq > 0 ? true : false);
            $('#chkChqCash').prop('checked', dt.AdvChqCash > 0 ? true : false);
            $('#chkCred').prop('checked', dt.AdvCred > 0 ? true : false);

            //Combos

            $('#cboAdvType').val(CCode(dt.AdvType));
            $('#cboDocStatus').val(CCode(dt.DocStatus));

            ShowUser(path, $('#txtAdvBy').val(), '#txtAdvName');
            ShowUser(path, $('#txtReqBy').val(), '#txtReqName');

            ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            ShowCustomer(path, $('#txtCustCode').val(), $('#txtCustBranch').val(), '#txtCustName');
            $('#btnSave').removeAttr('disabled');
            $('#btnPrint').removeAttr('disabled');
            $('#btnAdd').removeAttr('disabled');
            $('#btnDel').removeAttr('disabled');
            return;
        } 
        ClearHeader();
    }
    function AddHeader() {
        $('#txtAdvNo').val('');
        $.get(path + 'adv/getnewadvanceheader?branchcode=' + $('#txtBranchCode').val() , function (r) {
            var h = r.adv.header;
            ReadAdvHeader(h);
            if (isjobmode == false) {
                $('#cboJobType').val('01');
                $('#cboShipBy').val('01');
                $('#cboDocStatus').val('01');
                $('#cboAdvType').val('01');

            }
            var d = r.adv.detail;
            ReadAdvDetail(d);
            ClearDetail();
            $('#txtAdvNo').focus();
        });
    }
    function AddDetail() {
        $.get(path + 'adv/getnewadvancedetail?branchcode=' + $('#txtBranchCode').val() + '&advno=' + $('#txtAdvNo').val(), function (r) {
            var d = r.adv.detail[0];
            LoadDetail(d);
            $('#frmDetail').modal('show');
            $('#txtSICode').focus();
        });
    }
    function DeleteDetail() {
        if (dtl != undefined) {
            $.get(path + 'adv/deladvancedetail?branchcode=' + $('#txtBranchCode').val() + '&advno=' + $('#txtAdvNo').val() + '&itemno=' + dtl.ItemNo, function (r) {
                alert(r.adv.result);
                ShowData($('#txtBranchCode').val(), $('#txtAdvNo').val());
            });
        } else {
            alert('No data to delete');
        }
    }
    function ClearHeader() {
        hdr = {};
        $('#txtAdvDate').val('');
        $('#txtAdvBy').val('');
        $('#txtReqBy').val('');
        if (isjobmode == false) {
            $('#txtCustCode').val('');
            $('#txtCustBranch').val('');
            $('#cboJobType').val('');
            $('#cboShipBy').val('');
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

        $('#chkCash').prop('checked', false);
        $('#chkChq').prop('checked', false);
        $('#chkChqCash').prop('checked', false);
        $('#chkCred').prop('checked', false);

        //Combos

        $('#cboAdvType').val('');
        $('#cboDocStatus').val('');

        ShowUser(path, '', '#txtAdvName');
        ShowUser(path, '', '#txtReqName');

        ShowCustomer(path, '', $('#txtCustBranch').val(), '#txtCustName');
        $('#btnSave').removeAttr('disabled');
        $('#btnPrint').attr('disabled', 'disabled');

        $('#txtAdvCash').attr('disabled', 'disabled');
        $('#txtAdvChq').attr('disabled', 'disabled');
        $('#txtAdvChqCash').attr('disabled', 'disabled');
        $('#txtAdvCred').attr('disabled', 'disabled');
        $('#btnAdd').attr('disabled', 'disabled');
        $('#btnDel').attr('disabled', 'disabled');
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
            var jsonString = JSON.stringify({ data: obj });
            //alert(jsonString);
            $.ajax({
                url: "@Url.Action("SaveAdvanceDetail", "Adv")",
                type: "POST",
                contentType: "application/json",
                data: jsonString,
                success: function (response) {                
                    alert(response.result.msg);
                    ShowData($('#txtBranchCode').val(), $('#txtAdvNo').val());
                }
            });
            return;
        }
        alert('No data to save');
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
                { data: "AdvAmount", title: "Amount" },
                { data: "ChargeVAT", title: "VAT" },
                { data: "Charge50Tavi", title: "WH-Tax" },
                { data: "AdvNet", title: "Net" },
                { data: "TRemark", title: "Remark" }
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
            if (isjobmode == false)
                $('#txtForJNo').val(dt.ForJNo);
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
            $('#chkDuplicate').prop('checked', dt.IsDuplicate > 0 ? true : false);
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
    function SetGridAdv() {
        var w = '';
        if (job.length > 0) {
            w = '&jobno=' + job;
        }
        $.get(path + 'adv/getadvancegrid?branchcode=' + $('#txtBranchCode').val() + w, function (r) {
            var h = r[0].Table;
            $('#tbHeader').DataTable({
                data: h,
                selected: true, //ให้สามารถเลือกแถวได้
                columns: [ //กำหนด property ของ header column
                    { data: "AdvNo", title: "Advance No" },
                    { data: "AdvDate", title: "Date" },
                    { data: "CustCode", title: "Customer" },
                    { data: "EmpCode", title: "Request By" },
                    { data: "JobNo", title: "Job Number" },
                    { data: "DocStatus", title: "Status" },
                    { data: "TotalAdvance", title: "Total" },
                    { data: "Doc50Tavi", title: "W/T No" },
                    { data: "PaymentNo", title: "A/P No" },
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
            case 'advance':
                SetGridAdv();
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
                SetGridSICode(path, '#tbServ', "", '#frmSearchSICode', ReadService);
                break;
            case 'job':
                SetGridJob(path, '#tbJob', '#frmSearchJob', GetParam(), ReadJob);
                break;
        }
    }
    function GetParam() {
        var strParam = '?';
        strParam += 'Branch=' + $('#txtBranchCode').val();
        strParam += '&JType=' + $('#cboJobType').val().substr(0, 2);
        strParam += '&SBy=' + $('#cboShipBy').val().substr(0, 2);
        strParam += '&CustCode=' + $('#txtCustCode').val();
        return strParam;
    }
    function ReadAdvBy(dt) {
        $('#txtAdvBy').val(dt.UserID);
        $('#txtAdvName').val(dt.TName);
        $('#txtAdvBy').focus();
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
    function SumTotal() {
        var cash = CDbl($('#txtAdvCash').val(),2);
        var chq = CDbl($('#txtAdvChq').val(),2);
        var chqcash = CDbl($('#txtAdvChqCash').val(),2);
        var cred = CDbl($('#txtAdvCred').val(),2);
        return CDbl(Number(cash) + Number(chq) + Number(chqcash) + Number(cred),2);
    }
    function GetTotal() {
        var total = SumTotal();
        return CDbl(CNum($('#txtTotalAmount').val()) - total,2);
    }
    function CalTotal() {
        var amt = CDbl($('#txtAMT').val(),2);
        var vat = CDbl($('#txtVAT').val(),2);
        var wht = CDbl($('#txtWHT').val(),2);
        var net = CDbl($('#txtNET').val(),2);
        var type = $('#txtVatType').val();
        if (type == '') type = '1';
        if (type == '2') {
            $('#txtAMT').val(CDbl(CNum(net) - CNum(vat) + CNum(wht), 2));
            $('#txtNET').val(CDbl(net, 2));
        }
        if (type == '1') {
            $('#txtNET').val(CDbl(CNum(amt) + CNum(vat) - CNum(wht), 2));
            $('#txtAMT').val(CDbl(amt, 2));
        }
    }
    function CalVATWHT() {
        var type = $('#txtVatType').val();
        if (type == '') type = '1';
        var amt = CDbl($('#txtAMT').val(),2);
        if (type == '2') {
            amt = CDbl($('#txtNET').val(),2);
        }
        var vatrate = CDbl($('#txtVATRate').val(),2);
        var whtrate = CDbl($('#txtWHTRate').val(),2);
        var vat = 0;
        var wht = 0;
        var net = 0;
        if (type == "2") {
            var base = amt * 100 / (100 + (vatrate - whtrate));
            vat = base * vatrate * 0.01;
            wht = base * whtrate * 0.01;
        }
        if (type == "1") {
            vat = amt * vatrate * 0.01;
            wht = amt * whtrate * 0.01;
            net = amt + vat - wht;
        }
        $('#txtVAT').val(CDbl(vat, 2));
        $('#txtWHT').val(CDbl(wht, 2));
        CalTotal();
    }
</script>