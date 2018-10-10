
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
                <input type="date" id="txtAdvDate" />
            </div>
            <div class="col-sm-4" style="text-align:left">
                <table border="1">
                    <tr>
                        <td>
                            <b>Advance No</b>
                            <br />
                            <input type="text" id="txtAdvNo" style="font-style:bold;font-size:20px;text-align:center" />
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
                                    <input type="text" id="txtAdvBy" style="width:100px" />
                                    <button id="btnBrowseEmp1" onclick="SearchData('advby')">...</button>
                                    <input type="text" id="txtAdvName" style="width:300px" disabled />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Request By :
                                </td>
                                <td>
                                    <input type="text" id="txtReqBy" style="width:100px" />
                                    <button id="btnBrowseEmp2" onclick="SearchData('reqby')">...</button>
                                    <input type="text" id="txtReqName" style="width:300px" disabled />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Advance For :
                                </td>
                                <td>
                                    <input type="text" id="txtCustCode" style="width:100px" />
                                    <input type="text" id="txtCustBranch" style="width:30px" />
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
                                    <input type="text" id="txtWHTaxSlipNo" style="width:200px" />
                                </td>
                                <td>
                                    Bill A/P:
                                </td>
                                <td>
                                    <input type="text" id="txtBillNumber" style="width:200px" />
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
                                    <select id="cboJobType" style="width:200px" class="form-control dropdown"></select>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Ship By :
                                </td>
                                <td>
                                    <select id="cboShipBy" style="width:200px" class="form-control dropdown"></select>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Status :
                                </td>
                                <td>
                                    <input type="text" id="txtDocStatus" style="width:200px;height:40px;text-align:center;font-style:bold" disabled />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-7">
                        Advance Type:
                        <select id="cboAdvType" class="form-control dropdown" style="width:100%"></select>
                        <br />
                        Remark:
                        <textarea id="txtRemark" style="width:100%;height:80px"></textarea>
                    </div>
                    <div class="col-sm-5">
                        <br />
                        Payment Method:
                        <table>
                            <tr>
                                <td>
                                    <input type="checkbox" id="chkCash" checked />
                                    <label for="chkCash">Cash</label>
                                </td>
                                <td>
                                    <input type="text" id="txtCashAmount" style="width:100px;text-align:right" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <input type="checkbox" id="chkComChq" />
                                    <label for="chkComChq">Cashier Chq</label>
                                </td>
                                <td>
                                    <input type="text" id="txtChqAmount" style="width:100px;text-align:right" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <input type="checkbox" id="chkCustChq" />
                                    <label for="chkCustChq">Customer Chq</label>
                                </td>
                                <td>
                                    <input type="text" id="txtCustChqAmount" style="width:100px;text-align:right" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <input type="checkbox" id="chkCredit" />
                                    <label for="chkCredit">Credit</label>
                                </td>
                                <td>
                                    <input type="text" id="txtCreditAmount" style="width:100px;text-align:right" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4" style="border-style:solid;border-width:1px">
                        <input type="checkbox" id="chkApprove" checked />
                        <label for="chkApprove">Approve By</label>
                        <br />
                        <input type="text" id="txtApproveBy" style="width:250px" disabled />
                        <br />
                        Date:
                        <input type="text" id="txtApproveDate" style="width:120px" disabled />
                        Time:
                        <input type="text" id="txtApproveTime" style="width:80px" disabled />
                    </div>
                    <div class="col-sm-4" style="border-style:solid;border-width:1px">
                        <input type="checkbox" id="chkPayment" />
                        <label for="chkPayment">Payment By</label>
                        <input type="text" id="txtPaymentBy" style="width:250px" disabled />
                        <br />
                        Date:
                        <input type="text" id="txtPaymentDate" style="width:120px" disabled />
                        Time:
                        <input type="text" id="txtPaymentTime" style="width:80px" disabled />
                        <br />
                        Payment Ref:<input type="text" id="txtPaymentRef" style="width:200px" />
                    </div>
                    <div class="col-sm-4" style="border-style:solid;border-width:1px;color:red">
                        <input type="checkbox" id="chkCancel" />
                        <label for="chkCancel">Cancel By</label>
                        <input type="text" id="txtCancelBy" style="width:250px" disabled />
                        <br />
                        Date:
                        <input type="text" id="txtCancelDate" style="width:120px" disabled />
                        Time:
                        <input type="text" id="txtCancelTime" style="width:80px" disabled />
                        <br />
                        Cancel Reason :<input type="text" id="txtCancelReson" style="width:250px" />
                    </div>
                </div>
                <button id="btnSave" class="btn btn-success">Save Header</button>
                <button id="btnPrint" class="btn btn-info" onclick="PrintData()">Print Data</button>
            </div>
            <div id="tabDetail" class="tab-pane fade">
                <div class="row">
                    <div class="col-sm-12">
                        <table id="tbDetail" class="table table-responsive">
                            <thead>
                                <tr>
                                    <th>SICode</th>
                                    <th>Description</th>
                                    <th>Job No</th>
                                    <th>Amount</th>
                                    <th>Vat</th>
                                    <th>WH-Tax</th>
                                    <th>Remark</th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-9">
                        <label for="txtItemNo">Item No :</label>
                        <input type="text" id="txtItemNo" style="width:40px" disabled />
                        <label for="txtSICode">Code :</label>
                        <input type="text" id="txtSICode" style="width:80px" />
                        <input type="button" id="btnBrowseS" value="..." onclick="SearchData('servicecode')" />
                        <input type="text" id="txtSDescription" style="width:280px" />
                        <label for="txtForJNo">Job No :</label>
                        <input type="text" id="txtForJNo" style="width:120px" />
                        <input type="button" id="btnBrowseJ" value="..." onclick="SearchData('job')" />
                        <br />
                        <label for="txtAmount">Amount :</label>
                        <input type="text" id="txtAmount" style="width:100px;text-align:right" />
                        <label for="txtVATRate">VAT :</label>
                        <input type="text" id="txtVATRate" style="width:50px;text-align:right" />
                        <input type="text" id="txtVATAmount" style="width:100px;text-align:right" />
                        <label for="txtWHTRate">WHT :</label>
                        <input type="text" id="txtWHTRate" style="width:50px;text-align:right" />
                        <input type="text" id="txtWHTAmount" style="width:100px;text-align:right" />
                        <label for="txtNETAmount">Net Amount :</label>
                        <input type="text" id="txtNETAmount" style="width:100px;text-align:right" />
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
                <button id="btnAdd" class="btn btn-default">New</button>
                <button id="btnUpdate" class="btn btn-primary">Save</button>
                <button id="btnDelete" class="btn btn-danger">Delete</button>
            </div>
        </div>
    </div>
    <div id="frmSearchBranch" class="modal fade" role="dialog"></div>
    <div id="frmSearchAdv" class="modal fade" role="dialog"></div>
    <div id="frmSearchReq" class="modal fade" role="dialog"></div>
    <div id="frmSearchCust" class="modal fade" role="dialog"></div>
    <div id="frmSearchSICode" class="modal fade" role="dialog"></div>
    <div id="frmSearchJob" class="modal fade" role="dialog"></div>
</div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    $(document).ready(function () {       
        CheckParam();
        SetLOVs();
        SetEvents();
        SetEnterToTab();
    });
    function CheckParam() {
        //read query string parameters
        var br = getQueryString('BranchCode');
        var jt = getQueryString('JType');
        var sb = getQueryString('SBy');
        var ano = getQueryString('AdvNo');

        if (br != null) {
            $('#txtBranchCode').val(br);
            ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
        }
        if (jt == null) jt = "01";
        if (sb == null) sb = "01";
        //Combos
        loadConfig('#cboJobType', 'JOB_TYPE', path, jt);
        loadConfig('#cboShipBy', 'SHIP_BY', path, sb);
        loadConfig('#cboAdvType', 'ADV_TYPE', path, '');
    }
    function SetEnterToTab() {
        //Set enter to tab
        $("input[tabindex], select[tabindex], textarea[tabindex]").each(function () {
            $(this).on("keypress", function (e) {
                if (e.keyCode === 13) {
                    var nextElement = $('[tabindex="' + (this.tabIndex + 1) + '"]');
                    if (nextElement.length) {
                        $('[tabindex="' + (this.tabIndex + 1) + '"]').focus();
                        e.preventDefault();
                    } else
                        $('[tabindex="1"]').focus();
                }
            });
        });
        $('#txtBranchCode').focus();
    }
    function PrintData() {
        window.open(path + 'Adv/FormAdv');
    }
    function SetEvents() {
        $('#txtBranchCode').keydown(function (event) {
            if (event.which == 13) {
                ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
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
                ShowServiceCode(path, $('#txtSICode').val(), '#txtSDescription');
            }
        });
    }
    function SetLOVs() {
        //3 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            //Customers
            var ListCust = response.replace('tbX', 'tbCust').replace('cpX', 'Customers');
            BindList('#frmSearchCust', '#tbCust', ListCust);
            //Job
            var ListJob = response.replace('tbX', 'tbJob').replace('cpX', 'Job List');
            BindList('#frmSearchJob', '#tbJob', ListJob);

            //2 Fields
            response = response.replace('<th>key</th>', '');
            //Users
            var ListUser = response.replace('tbX', 'tbAdv').replace('cpX', 'Advance By');
            BindList('#frmSearchAdv', '#tbAdv', ListUser);
            var ListUser2 = response.replace('tbX', 'tbReq').replace('cpX', 'Request By');
            BindList('#frmSearchReq', '#tbReq', ListUser2);
            //Branch
            var ListBranch = response.replace('tbX', 'tbBranch').replace('cpX', 'Branch');
            BindList('#frmSearchBranch', '#tbBranch', ListBranch);
            //SICode
            var ListServ = response.replace('tbX', 'tbServ').replace('cpX', 'Service Code');
            BindList('#frmSearchSICode', '#tbServ', ListServ);

        });
    }
    function SearchData(type) {
        switch (type) {
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
        $('#txtSICode').val(dt.SICode);
        $('#txtSDescription').val(dt.NameThai);
        $('#txtSICode').focus();
    }
    function ReadJob(dt) {
        $('#txtForJNo').val(dt.JNo);
    }
</script>