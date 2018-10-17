
@Code
    ViewBag.Title = "Advance Information"
End Code
<div class="panel-body">
    <div id="dvHeader" class="container">
        <div class="row">
            <div class="col-sm-5">
                Branch :
                <input type="text" id="txtBranchCode" style="width:50px" tabindex="0"/>
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
                                    <input type="text" id="txtReqBy" style="width:100px" tabindex="3"/>
                                    <button id="btnBrowseEmp2" onclick="SearchData('reqby')">...</button>
                                    <input type="text" id="txtReqName" style="width:300px" disabled />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Advance For :
                                </td>
                                <td>
                                    <input type="text" id="txtCustCode" style="width:120px" tabindex="4"/>
                                    <input type="text" id="txtCustBranch" style="width:50px" tabindex="5"/>
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
                                    <input type="text" id="txtWHTaxSlipNo" style="width:200px" tabindex="6"/>
                                </td>
                                <td>
                                    Bill A/P:
                                </td>
                                <td>
                                    <input type="text" id="txtBillNumber" style="width:200px" tabindex="7"/>
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
                                    <select id="cboDocStatus" style="width:200px;height:40px;text-align:center;font-style:bold" disabled></select>
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
                        <textarea id="txtRemark" style="width:100%;height:80px" tabindex="11"></textarea>
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
                        <input type="text" id="txtSICode" style="width:80px" tabindex="12" />
                        <input type="button" id="btnBrowseS" value="..." onclick="SearchData('servicecode')" />
                        <input type="text" id="txtSDescription" style="width:280px" tabindex="13" />
                        <label for="txtForJNo">Job No :</label>
                        <input type="text" id="txtForJNo" style="width:120px" tabindex="14" />
                        <input type="button" id="btnBrowseJ" value="..." onclick="SearchData('job')" />
                        <br />
                        <label for="txtAmount">Amount :</label>
                        <input type="text" id="txtAMT" style="width:100px;text-align:right" tabindex="15" />
                        <label for="txtVATRate">VAT :</label>
                        <input type="text" id="txtVATRate" style="width:50px;text-align:right" tabindex="16" />
                        <input type="text" id="txtVAT" style="width:100px;text-align:right" tabindex="17" />
                        <label for="txtWHTRate">WHT :</label>
                        <input type="text" id="txtWHTRate" style="width:50px;text-align:right" tabindex="18" />
                        <input type="text" id="txtWHT" style="width:100px;text-align:right" tabindex="19" />
                        <label for="txtNETAmount">Net Amount :</label>
                        <input type="text" id="txtNET" style="width:100px;text-align:right" tabindex="20" />
                        <input type="hidden" id="txtVatType" /><br />
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
    <div id="dvLOVs"></div>
</div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    var serv = [];
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
        loadConfig('#cboAdvType', 'ADV_TYPE', path, '01');
        loadConfig('#cboAdvStatus', 'ADV_STATUS', path, '01');
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
                GetServiceCode(path, $('#txtSICode').val(), ReadService);
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
        serv = dt;
        $('#txtSICode').val(dt.SICode);
        $('#txtSDescription').val(dt.NameThai);
        $('#txtVatType').val(dt.IsTaxCharge);
        $('#txtVATRate').val(dt.IsTaxCharge == "0" ? "0" : "7");
        $('#txtWHTRate').val(dt.Is50Tavi=="0"? "0" : dt.Rate50Tavi);
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
        if (type == "1") {
            $('#txtNET').val(amt + vat - wht);
        }
    }
    function ReadJob(dt) {
        $('#txtForJNo').val(dt.JNo);
    }
    function CalTotal() {
        var amt = Number($('#txtAMT').val());
        var vat = Number($('#txtVAT').val());
        var wht = Number($('#txtWHT').val());
        var net = Number($('#txtNET').val());
        var type = $('#txtVatType').val();
        if (type == '') type = "1";
        if (type == "2") {
            $('#txtAMT').val(CDbl(net - vat + wht,2));
        }
        if (type == "1") {
            $('#txtNET').val(CDbl(amt + vat - wht,2));
        }
    }
    function CalVATWHT() {
        var type = $('#txtVatType').val();
        if (type == '') type = "1";
        var amt = Number($('#txtAMT').val());
        if (type == "2") {
            amt = Number($('#txtNET').val());
        }
        var vatrate = Number($('#txtVATRate').val());
        var whtrate = Number($('#txtWHTRate').val());
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