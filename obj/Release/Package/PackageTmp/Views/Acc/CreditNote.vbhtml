@Code
    ViewBag.Title = "Credit/Debit Note"
End Code
    <div class="panel-body">
        <div class="row">
            <div class="col-sm-4">
                Branch
                <br/>
                <div style="display:flex;flex-direction:row">
                    <input type="text" class="form-control" id="txtBranchCode" style="width:15%" disabled />
                    <input type="button" class="btn btn-default" value="..." onclick="SearchData('branch');" />
                    <input type="text" class="form-control" id="txtBranchName" style="width:65%" disabled />
                </div>
            </div>
            <div class="col-sm-6">
                Customer:
                <br/>
                <div style="display:flex;flex-direction:row">
                    <input type="text" class="form-control" id="txtCustCode" style="width:20%" disabled />
                    <input type="text" class="form-control" id="txtCustBranch" style="width:10%" disabled />
                    <input type="button" class="btn btn-default" value="..." onclick="SearchData('customer');" />
                    <input type="text" class="form-control" id="txtCustName" style="width:60%" disabled />
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-2">
                Document Date From:<br />
                <input type="date" class="form-control" id="txtDocDateF" />
            </div>
            <div class="col-sm-2">
                Document Date To:<br />
                <input type="date" class="form-control" id="txtDocDateT" />
            </div>
            <div class="col-sm-3">
                <br />
                <a href="#" class="btn btn-primary" id="btnShow">
                    <i class="fa fa-lg fa-filter"></i>&nbsp;<b>Search</b>
                </a>
                <a href="#" class="btn btn-default w3-purple" id="btnNew">
                    <i class="fa fa-lg fa-file-o"></i>&nbsp;<b>Create New</b>
                </a>
            </div>
        </div>
        <ul class="nav nav-tabs">
            <li class="active">
                <a data-toggle="tab" href="#tabHeader">Headers</a>
            </li>
            <li>
                <a data-toggle="tab" href="#tabDetail">Details</a>
            </li>
        </ul>
        <div class="tab-content">
            <div class="tab-pane fade in active" id="tabHeader">
                <input type="checkbox" id="chkCancel" />Show Cancel Only
                <table id="tbHeader" class="table table-responsive">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>DocNo</th>
                            <th class="desktop">DocDate</th>
                            <th class="all">CustCode</th>
                            <th class="desktop">Reference</th>
                            <th class="desktop">Remark</th>
                            <th class="all">Total</th>
                        </tr>
                    </thead>
                </table>
            </div>
            <div class="tab-pane fade" id="tabDetail">
                <a href="#" class="btn btn-warning" id="btnAdd">
                    <i class="fa fa-lg fa-file-o"></i>&nbsp;<b>Add Invoice</b>
                </a>
                <table id="tbDetail" class="table table-responsive">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>InvNo</th>
                            <th class="desktop">SICode</th>
                            <th class="all">SDescription</th>
                            <th class="desktop">Original</th>
                            <th class="desktop">Correct</th>
                            <th class="desktop">Diff</th>
                            <th class="desktop">Vat</th>
                            <th class="all">Net</th>
                            <th class="desktop">Currency</th>
                            <th class="desktop">Rate</th>
                            <th class="desktop">Total</th>
                        </tr>
                    </thead>
                </table>
            </div>
        </div>
        <div id="frmHeader" class="modal fade">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <div style="display:flex;flex-direction:row">
                            Document No:<input type="text" id="txtDocNo" style="width:20%" disabled />
                            Doc.Date:<input type="date" id="txtDocDate" style="width:30%" />
                        </div>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-sm-12" style="display:flex;flex-direction:column">
                                <p style="flex-direction:row">
                                    Document Type:
                                    <select id="txtDocType">
                                        <option value="0">Credit Note</option>
                                        <option value="1">Debit Note</option>
                                    </select>
                                    Create By:<input type="text" id="txtEmpCode" style="width:30%" disabled />
                                </p>
                                <p style="flex-direction:row">
                                    Customer:<input type="text" id="txtHCustCode" style="width:20%" disabled />
                                    <input type="text" id="txtHCustBranch" style="width:10%" disabled />
                                    <input type="text" id="txtHCustName" style="width:50%" disabled />
                                </p>
                                <p>
                                    <textarea id="txtHCustAddr" style="width:100%;height:100%" disabled></textarea>
                                </p>
                                <p style="flex-direction:row">
                                    Document Note:
                                    <textarea id="txtRemark" style="width:100%;height:100%"></textarea>
                                </p>
                            </div>
                        </div>
                        <p>
                            <div class="row">
                                <div class="col-sm-4">
                                    <input type="checkbox" id="chkApprove" onclick="ApproveData()" />
                                    Approve Date:<br /> <input type="date" id="txtApproveDate" style="width:100%" disabled />
                                </div>
                                <div class="col-sm-3">
                                    Approve Time:<br /><input type="text" id="txtApproveTime" style="width:100%" disabled />
                                </div>
                                <div class="col-sm-5">
                                    Approve By:<br /> <input type="text" id="txtApproveBy" style="width:100%" disabled />
                                </div>
                            </div>
                        </p>
                        <div class="row">
                            <div class="col-sm-3">
                                <button id="btnCancel" class="btn btn-danger" onclick="CancelData()">Cancel</button>
                            </div>
                            <div class="col-sm-4">
                                Cancel date:<br /> <input type="date" id="txtCancelDate" style="width:100%" disabled />
                            </div>
                            <div class="col-sm-5">
                                Update By:<br /> <input type="text" id="txtUpdateBy" style="width:100%" disabled />
                            </div>
                        </div>
                        Cancel Reason:<br /> <textarea id="txtCancelReson" style="width:100%"></textarea>
                        <input type="hidden" id="txtDocStatus" />
                    </div>
                    <div class="modal-footer">
                        <div style="float:left">
                            <a href="#" class="btn btn-success" id="btnUpdate" onclick="SaveData()">
                                <i class="fa fa-lg fa-save"></i>&nbsp;<b>Save</b>
                            </a>
                            <a href="#" class="btn btn-info" id="btnPrint" onclick="PrintData()">
                                <i class="fa fa-lg fa-print"></i>&nbsp;<b>Print</b>
                            </a>
                        </div>
                        Last update:<input type="date" id="txtLastupDate" disabled />
                        <button id="btnHide" class="btn btn-danger" data-dismiss="modal">X</button>
                    </div>
                </div>
            </div>
        </div>
        <div id="frmDetail" class="modal fade">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <div class="row">
                            <div class="col-sm-12">
                                Doc.No <input type="text" id="txtDDocNo" style="width:20%" disabled />
                                Seq.<input type="text" id="txtItemNo" style="width:5%" disabled />
                                Inv.No <input type="text" id="txtBillingNo" style="width:20%" disabled />
                                #No <input type="text" id="txtBillItemNo" style="width:5%" disabled />
                                <input type="button" value="..." onclick="SearchData('invoice');" />
                            </div>
                        </div>
                    </div>
                    <div class="modal-body">
                        Code <input type="text" id="txtSICode" style="width:15%" disabled />
                        <input type="text" id="txtSDescription" style="width:75%" />
                        <p>
                            Currency <input type="text" id="txtDCurrencyCode" style="width:10%" disabled />
                            <input type="button" value="..." onclick="SearchData('currency');" />
                            <input type="text" id="txtCurrencyName" style="width:60%" disabled />
                        </p>
                        <p>
                            <div class="row">
                                <div class="col-sm-4" style="display:flex;">
                                    <table>
                                        <tr>
                                            <td>
                                                Exc.Rate
                                            </td>
                                            <td>
                                                <input type="number" id="txtExchangeRate" style="width:100%" onchange="CalForeign()" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Original
                                            </td>
                                            <td>
                                                <input type="number" id="txtOriginalAmt" style="width:100%" onchange="CalDiff()" disabled />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>Correct</td>
                                            <td>
                                                <input type="number" id="txtCorrectAmt" style="width:100%" onchange="CalDiff()" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>Diff</td>
                                            <td>
                                                <input type="number" id="txtDiffAmt" style="width:100%" onchange="CalVATWHT()" />
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                <div class="col-sm-8">
                                    <table>
                                        <tr>
                                            <td>
                                                VAT
                                                <select id="txtIsTaxCharge" style="width:100%" disabled>
                                                    <option value="0">NO</option>
                                                    <option value="1">EX</option>
                                                    <option value="2">IN</option>
                                                </select>
                                            </td>
                                            <td style="text-align:right">
                                                Rate
                                                <input type="number" id="txtVATRate" style="width:50%" onchange="CalVATWHT()" />
                                            </td>
                                            <td style="text-align:right">
                                                <input type="number" id="txtVATAmt" style="width:100%" onchange="CalNetAmount()" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                WHT
                                                <select id="txtIs50Tavi" style="width:100%" disabled>
                                                    <option value="0">NO</option>
                                                    <option value="1">YES</option>
                                                </select>
                                            </td>
                                            <td style="text-align:right">
                                                Rate
                                                <input type="number" id="txtWHTRate" style="width:50%" onchange="CalVATWHT(1)" />
                                            </td>
                                            <td style="text-align:right">
                                                <input type="number" id="txtWHTAmt" style="width:100%" onchange="CalNetAmount()" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" style="text-align:right">
                                                Net Change (B)
                                            </td>
                                            <td style="text-align:right">
                                                <input type="number" id="txtTotalNet" style="width:100%" disabled />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" style="text-align:right">
                                                Net Change (F)
                                            </td>
                                            <td style="text-align:right">
                                                <input type="number" id="txtForeignNet" style="width:100%" disabled />
                                            </td>
                                        </tr>

                                    </table>
                                </div>
                            </div>
                        </p>

                    </div>
                    <div class="modal-footer">
                        <div style="float:left">
                            <a href="#" class="btn btn-success" id="btnUpd" onclick="SaveDetail()">
                                <i class="fa fa-lg fa-save"></i>&nbsp;<b>Update</b>
                            </a>
                            <a href="#" class="btn btn-danger" id="btnDel" onclick="DeleteDetail()">
                                <i class="fa fa-lg fa-trash"></i>&nbsp;<b>Delete</b>
                            </a>
                        </div>
                        <button id="btnHid" class="btn btn-danger" data-dismiss="modal">X</button>
                    </div>
                </div>
            </div>
        </div>
        <div id="frmSearchBill" class="modal fade">
            <div class="modal-dialog-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        Select Invoice
                    </div>
                    <div class="modal-body">
                        <table id="tbInvoice" style="width:100%;">
                            <thead>
                                <tr>
                                    <th>InvNo</th>
                                    <th class="desktop">Item</th>
                                    <th class="all">Description</th>
                                    <th class="desktop">Service</th>
                                    <th class="desktop">Vat</th>
                                    <th class="desktop">Wh-Tax</th>
                                    <th class="all">Net</th>
                                </tr>
                            </thead>
                            <tbody></tbody>
                        </table>
                    </div>
                    <div class="modal-footer">
                        <button id="btnClose" class="btn btn-danger" data-dismiss="modal">X</button>
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
    let row = {};
    let row_d = {};
    SetLOVs();
    $('#btnShow').on('click', function () {
        ShowHeader();
    });
    $('#btnNew').on('click', function () {
        ClearHeader();
        $('#frmHeader').modal('show');
    });
    $('#btnAdd').on('click', function () {
        ClearDetail();
        $('#frmDetail').modal('show');
    });
    function ClearHeader() {
        $('#txtDocNo').val('');
        $('#txtDocType').val('0');
        $('#txtDocDate').val('');
        $('#txtHCustCode').val($('#txtCustCode').val());
        $('#txtHCustBranch').val($('#txtCustBranch').val());
        ShowCustomerAddress(path, $('#txtCustCode').val(), $('#txtCustBranch').val(), '#txtHCustName', '#txtHCustAddr');
        $('#txtEmpCode').val(user);
        $('#txtApproveBy').val('');
        $('#txtApproveDate').val('');
        $('#txtApproveTime').val('');
        $('#txtUpdateBy').val('');
        $('#chkApprove').prop('checked', false);
        $('#txtLastupDate').val(GetToday());
        $('#txtDocStatus').val('0');
        $('#txtCancelDate').val('');
        $('#txtCancelReson').val('');
        $('#txtRemark').val('');
        row = {			
            BranchCode:$('#txtBranchCode').val(),
            DocNo:$('#txtDocNo').val(),
            DocType:$('#txtDocType').val(),
            CustCode:$('#txtHCustCode').val(),
            CustBranch:$('#txtHCustBranch').val(),
            DocDate:CDateTH($('#txtDocDate').val()),
            EmpCode:$('#txtEmpCode').val(),
            ApproveBy:$('#txtApproveBy').val(),
            ApproveDate:CDateTH($('#txtApproveDate').val()),
            ApproveTime:CDateTH($('#txtApproveTime').val()),
            UpdateBy:user,
            LastupDate:CDateTH(GetToday()),
            DocStatus:$('#txtDocStatus').val(),
            CancelDate:CDateTH($('#txtCancelDate').val()),
            CancelReason:$('#txtCancelReson').val(),
            Remark:$('#txtRemark').val(),
        };
    }
    function ClearDetail() {
        $('#txtDDocNo').val($('#txtDocNo').val());
        $('#txtItemNo').val('0');
        $('#txtBillingNo').val('');
        $('#txtBillItemNo').val('');
        $('#txtSICode').val('');
        $('#txtSDescription').val('');
        $('#txtOriginalAmt').val('0.00');
        $('#txtCorrectAmt').val('0.00');
        $('#txtDiffAmt').val('0.00');
        $('#txtIsTaxCharge').val('0');
        $('#txtVATRate').val('0.00');
        $('#txtVATAmt').val('0.00');
        $('#txtIs50Tavi').val('0');
        $('#txtWHTRate').val('0.00');
        $('#txtWHTAmt').val('0.00');
        $('#txtTotalNet').val('0.00');
        $('#txtDCurrencyCode').val('THB');
        $('#txtCurrencyName').val('THAI BAHT');
        $('#txtExchangeRate').val('1');
        $('#txtForeignNet').val('0.00');
        row_d={			
            BranchCode:$('#txtBranchCode').val(),
            DocNo:$('#txtDDocNo').val(),
            ItemNo:$('#txtItemNo').val(),
            BillingNo: $('#txtBillingNo').val(),
            BillItemNo:CNum($('#txtBillItemNo').val()),
            SICode:$('#txtSICode').val(),
            SDescription:$('#txtSDescription').val(),
            OriginalAmt:CNum($('#txtOriginalAmt').val()),
            CorrectAmt:CNum($('#txtCorrectAmt').val()),
            DiffAmt:CNum($('#txtDiffAmt').val()),
            IsTaxCharge:$('#txtIsTaxCharge').val(),
            VATRate:CNum($('#txtVATRate').val()),
            VATAmt: CNum($('#txtVATAmt').val()),
            Is50Tavi:$('#txtIs50Tavi').val(),
            WHTRate:CNum($('#txtWHTRate').val()),
            WHTAmt:CNum($('#txtWHTAmt').val()),
            TotalNet:CNum($('#txtTotalNet').val()),
            CurrencyCode:$('#txtDCurrencyCode').val(),
            ExchangeRate:CNum($('#txtExchangeRate').val()),
            ForeignNet: CNum($('#txtForeignNet').val()),
            TaxInvNo: ''
        };
    }
    function SetLOVs() {
        $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
        $('#txtBranchName').val('@ViewBag.PROFILE_DEFAULT_BRANCH_NAME');
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv, '#frmSearchCust', '#tbCust', 'Customers', response, 3);
            //Currency
            CreateLOV(dv, '#frmSearchCurr', '#tbCurr', 'Currency', response, 2);
            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response,4);
        });
    }
    function SearchData(type) {
        switch (type) {
            case 'branch':
                SetGridBranch(path, '#tbBranch', '#frmSearchBranch', ReadBranch);
                break;
            case 'customer':
                SetGridCompany(path, '#tbCust', '#frmSearchCust', ReadCustomer);
                break;
            case 'currency':
                SetGridCurrency(path, '#tbCurr', '#frmSearchCurr', ReadCurrency);
                break;
            case 'invoice':
                ShowInvoice();
                break;
        }
    }
    function ApproveData() {
        $('#txtApproveBy').val($('#chkApprove').prop('checked') == true ? user : '');
        $('#txtApproveDate').val($('#chkApprove').prop('checked') == true ? GetToday() : '');
        $('#txtApproveTime').val($('#chkApprove').prop('checked') == true ? ShowTime(GetTime()) : '');
        $('#txtDocStatus').val($('#chkApprove').prop('checked') == true ? '1' : row.DocStatus);
    }
    function CancelData() {
        if (userRights.indexOf('D') > 0) {
            if ($('#txtCancelReson').val() == '') {
                ShowMessage('Please enter reason for cancel');
                $('#txtCancelReson').focus();
                return;
            }
            $('#txtCancelDate').val(GetToday());
            $('#txtCancelTime').val(ShowTime(GetTime()));            
            $('#txtUpdateBy').val(user);
            $('#txtDocStatus').val('99');
        } else {
            ShowMessage('you are not allow to cancel Document');
        }
    }
    function SaveData() {
        let dataDoc={			
            BranchCode:$('#txtBranchCode').val(),
            DocNo:$('#txtDocNo').val(),
            DocType:$('#txtDocType').val(),
            CustCode:$('#txtHCustCode').val(),
            CustBranch:$('#txtHCustBranch').val(),
            DocDate:CDateTH($('#txtDocDate').val()),
            EmpCode:$('#txtEmpCode').val(),
            ApproveBy:$('#txtApproveBy').val(),
            ApproveDate:CDateTH($('#txtApproveDate').val()),
            ApproveTime:$('#txtApproveTime').val(),
            UpdateBy:user,
            LastupDate:CDateTH(GetToday()),
            DocStatus:$('#txtDocStatus').val(),
            CancelDate:CDateTH($('#txtCancelDate').val()),
            CancelReason:$('#txtCancelReson').val(),
            Remark:$('#txtRemark').val(),
        };
        let jsonString = JSON.stringify({ data: dataDoc });
        $.ajax({
            url: "@Url.Action("SetCNDNHeader", "Acc")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                if (response.result.data !== null) {
                    ShowHeader();
                    ShowMessage(response.result.data);
                    $('#frmHeader').modal('hide');
                    return;
                }
                ShowMessage(response.result.msg);
            },
            error: function (e) {
                ShowMessage(e);
            }
        });
    }
    function PrintData() {
        let code = row.DocNo;
        if (code !== '') {
            let branch = row.BranchCode;
            window.open(path + 'Acc/FormCreditNote?Branch=' + branch + '&Code=' + code);
        }
    }
    function ShowHeader() {
        let w = '';
        if ($('#txtCustCode').val() !== '') {
            w += '&cust=' + $('#txtCustCode').val();
        }
        if ($('#txtDocDateF').val() !== "") {
            w += '&DateFrom=' + CDateEN($('#txtDocDateF').val());
        }
        if ($('#txtDocDateT').val() !== "") {
            w += '&DateTo=' + CDateEN($('#txtDocDateT').val());
        }
        if ($('#chkCancel').prop('checked') == true) {
            w += '&Status=99';
        } else {
            w += '&Status=0,1';
        }
        $.get(path + 'Acc/GetCNDNGrid?Branch=' + $('#txtBranchCode').val() + w, function (r) {
            if (r.creditnote.data.length == 0) {
                $('#tbHeader').DataTable().clear().draw();
                ShowMessage('data not found');
                return;
            }
            let h = r.creditnote.data;
            $('#tbHeader').DataTable({
                data: h,
                selected: true, //ให้สามารถเลือกแถวได้
                columns: [ //กำหนด property ของ header column
                    {
                        data: null, title: "#",
                        render: function (data, type, full, meta) {
                            let html = "<button class='btn btn-warning'>Edit</button>";
                            return html;
                        }
                    },
                    { data: "DocNo", title: "Document No" },
                    {
                        data: "DocDate", title: "Issue date ",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "CustCode", title: "Customer" },
                    { data: "InvoiceNo", title: "Invoice No" },
                    { data: "Remark", title: "Remark" },
                    { data: "TotalNet", title: "Total" }
                ],
                responsive:true,
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            });
            $('#tbHeader tbody').on('click', 'tr', function () {
                ClearHeader();
                SetSelect('#tbHeader', this);
                row = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                $('#txtDocNo').val(row.DocNo);
                row_d = {};
                ReadData();
                ShowDetail(row.BranchCode, row.DocNo);
            });
            $('#tbHeader tbody').on('dblclick', 'tr', function () {
                $('a[href="#tabDetail"]').click();
            });
            $('#tbHeader tbody').on('click', 'button', function () {
                if (userRights.indexOf('E') > 0) {
                    $('#frmHeader').modal('show');
                } else {
                    ShowMessage('you are not allow to edit this document');
                }
            });
        });
    }
    function ShowDetail(branch, code) {
        $('#tbDetail').DataTable().clear().draw();
        $.get(path + 'Acc/GetCNDNDetail?Branch=' + branch + '&Code=' + code, function (r) {
            if (r.creditnote.detail.length > 0) {
                let d = r.creditnote.detail;
                LoadDetail(d);
            }
        });
    }
    function LoadDetail(d) {
        $('#tbDetail').DataTable({
            data: d,
            selected: true,
            columns: [
                {
                    data: null, title: "#",
                    render: function (data, type, full, meta) {
                        let html = "<button class='btn btn-warning'>Edit</button>";
                        return html;
                    }
                },
                { data: "BillingNo", title: "Invoice" },
                { data: "SICode", title: "Cpde" },
                { data: "SDescription", title: "Expenses" },
                { data: "OriginalAmt", title: "Original" },
                { data: "CorrectAmt", title: "Correct.Amt" },
                { data: "DiffAmt", title: "Change" },
                { data: "VATAmt", title: "VAT" },
                { data: "TotalNet", title: "Net" },
                { data: "CurrencyCode", title: "Currency" },
                { data: "ExchangeRate", title: "Rate" },
                { data: "ForeignNet", title: "Total" }
            ],
            responsive:true,
            destroy:true
        });
        $('#tbDetail tbody').on('click', 'tr', function () {
            SetSelect('#tbDetail', this);
            ClearDetail();
            row_d = $('#tbDetail').DataTable().row(this).data();
            ReadDetail();
        });
        $('#tbDetail tbody').on('click', 'button', function () {
            if (userRights.indexOf('E') > 0) {
                $('#frmDetail').modal('show');
            } else {
                ShowMessage('you are not allow to edit this document');
            }
        });
    }
    function ReadData() {
        $('#txtDocType').val(row.DocType);
        $('#txtHCustCode').val(row.CustCode);
        $('#txtHCustBranch').val(row.CustBranch);
        ShowCustomerAddress(path, row.CustCode, row.CustBranch, '#txtHCustName','#txtHCustAddr');
        $('#txtDocDate').val(CDateEN(row.DocDate));
        $('#txtEmpCode').val(row.EmpCode);
        $('#txtApproveBy').val(row.ApproveBy);
        if ($('#txtApproveBy').val() !== '') {
            $('#chkApprove').prop('checked', true);
        }
        $('#txtApproveDate').val(CDateEN(row.ApproveDate));
        $('#txtApproveTime').val(ShowTime(row.ApproveTime));
        $('#txtUpdateBy').val(row.UpdateBy);
        $('#txtLastupDate').val(CDateEN(row.LastupDate));
        $('#txtDocStatus').val(row.DocStatus);
        $('#txtCancelDate').val(CDateEN(row.CancelDate));
        $('#txtCancelReson').val(row.CancelReason);
        $('#txtRemark').val(row.Remark);
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
    }
    function ReadCurrency(dt) {
        $('#txtDCurrencyCode').val(dt.Code);
        $('#txtCurrencyName').val(dt.TName);
        $('#txtExchangeRate').focus();
    }
    function ReadDetail() {
        $('#txtDDocNo').val(row_d.DocNo);
        $('#txtItemNo').val(row_d.ItemNo);        
        $('#txtBillingNo').val(row_d.BillingNo);
        $('#txtBillItemNo').val(row_d.BillItemNo);        
        $('#txtSICode').val(row_d.SICode);
        $('#txtSDescription').val(row_d.SDescription);
        $('#txtOriginalAmt').val(row_d.OriginalAmt);
        $('#txtCorrectAmt').val(row_d.CorrectAmt);
        $('#txtDiffAmt').val(row_d.DiffAmt);
        $('#txtIsTaxCharge').val(row_d.IsTaxCharge);
        $('#txtVATRate').val(row_d.VATRate);
        $('#txtVATAmt').val(row_d.VATAmt);
        $('#txtIs50Tavi').val(row_d.Is50Tavi);
        $('#txtWHTRate').val(row_d.WHTRate);
        $('#txtWHTAmt').val(row_d.WHTAmt);
        $('#txtTotalNet').val(row_d.TotalNet);
        $('#txtDCurrencyCode').val(row_d.CurrencyCode);
        ShowCurrency(path, row_d.CurrencyCode, '#txtCurrencyName');
        $('#txtExchangeRate').val(row_d.ExchangeRate);
        $('#txtForeignNet').val(row_d.ForeignNet);
    }
    function SaveDetail() {
        if (row_d !== null) {
            let obj={			
                BranchCode:$('#txtBranchCode').val(),
                DocNo:$('#txtDDocNo').val(),
                ItemNo:$('#txtItemNo').val(),
                BillingNo: $('#txtBillingNo').val(),
                BillItemNo:$('#txtBillItemNo').val(),
                SICode:$('#txtSICode').val(),
                SDescription:$('#txtSDescription').val(),
                OriginalAmt:CNum($('#txtOriginalAmt').val()),
                CorrectAmt:CNum($('#txtCorrectAmt').val()),
                DiffAmt:CNum($('#txtDiffAmt').val()),
                IsTaxCharge:$('#txtIsTaxCharge').val(),
                VATRate:CNum($('#txtVATRate').val()),
                VATAmt: CNum($('#txtVATAmt').val()),
                Is50Tavi:$('#txtIs50Tavi').val(),
                WHTRate:CNum($('#txtWHTRate').val()),
                WHTAmt:CNum($('#txtWHTAmt').val()),
                TotalNet:CNum($('#txtTotalNet').val()),
                CurrencyCode:$('#txtDCurrencyCode').val(),
                ExchangeRate:CNum($('#txtExchangeRate').val()),
                ForeignNet: CNum($('#txtForeignNet').val()),
                TaxInvNo: row_d.TaxInvNo
            };
            if ($('#txtDocType').val() == '0' && obj.TotalNet < 0) {
                ShowMessage('Credit Note value must be more than zero');
                return;
            }
            if ($('#txtDocType').val() == '1' && obj.TotalNet > 0) {
                ShowMessage('Debit Note value must be less than zero');
                return;
            }
            let jsonText = JSON.stringify({ data: obj });
            //ShowMessage(jsonText);
            $.ajax({
                url: "@Url.Action("SetCNDNDetail", "Acc")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.data !== null) {
                        ShowDetail(row.BranchCode, row.DocNo);
                        ShowMessage(response.result.msg + '\n=>' + response.result.data);
                        $('#frmDetail').modal('hide');
                        return;
                    }
                    ShowMessage(response.result.msg);
                },
                error: function (e) {
                    ShowMessage(e);
                }
            });
        } else {
            ShowMessage('no data to save');
        }
    }
    function DeleteDetail() {
        if (row_d !== null) {
            $.get(path+ 'Acc/DelCNDNDetail?Branch=' + row.BranchCode + '&Code=' + row.DocNo + '&Item=' + row_d.ItemNo)
                .done(function (r) {
                    if (r.creditnote.data !== null) {
                        ShowDetail(row.BranchCode, row.DocNo);
                    }
                    ShowMessage(r.creditnote.result);
                });
        } else {
            ShowMessage('no data to delete');
        }
    }
    function CalDiff() {
        let oldAmt = CNum($('#txtOriginalAmt').val());
        let newAmt = CNum($('#txtCorrectAmt').val());
        $('#txtDiffAmt').val(CDbl(oldAmt - newAmt,2));
        CalVATWHT();
    }
    function CalForeign() {
        let totalforeign = CDbl(CNum($('#txtTotalNet').val()) / CNum($('#txtExchangeRate').val()), 2);
        $('#txtForeignNet').val(CDbl(totalforeign,2));
    }
    function CalVATWHT(step = 0) {
        let amt = CNum($('#txtDiffAmt').val());
        if (step == 0) {
            let vat = amt * CNum($('#txtVATRate').val()) * 0.01;
            $('#txtVATAmt').val(CDbl(vat,2));
        }
        let wht = amt * CNum($('#txtWHTRate').val()) * 0.01;
        $('#txtWHTAmt').val(CDbl(wht, 2));
        CalNetAmount();
    }
    function CalNetAmount() {
        let amt = CNum($('#txtDiffAmt').val());
        let vat = CNum($('#txtVATAmt').val());
        let wht = CNum($('#txtWHTAmt').val());
        let net = amt + vat - wht;

        $('#txtTotalNet').val(CDbl(net, 2));
        CalForeign();
    }
    function ShowInvoice() {
        $.get(path + 'acc/getinvforreceive?show=ALL&billto=' + row.CustCode + '&branch=' + row.BranchCode, function (r) {
            if (r.invdetail.data.length == 0) {
                $('#tbInvoice').DataTable().clear().draw();
                $('#frmSearchBill').modal('show');
                return;
            }
            let d = r.invdetail.data;
            $('#tbInvoice').DataTable({
                data: d,
                selected: true, //ให้สามารถเลือกแถวได้
                columns: [ //กำหนด property ของ header column
                    { data: "InvoiceNo", title: "Doc No" },
                    { data: "InvoiceItemNo", title: "Item No" },
                    { data: "SDescription", title: "Description" },
                    { data: "InvAmt", title: "Charge" },
                    { data: "InvVat", title: "Vat" },
                    { data: "Inv50Tavi", title: "W-Tax" },
                    { data: "InvTotal", title: "NET" }
                ],
                responsive:true,
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            });
            $('#tbInvoice tbody').on('click', 'tr', function () {
                let data = $('#tbInvoice').DataTable().row(this).data(); //read current row selected
                ReadInvoice(data);
                $('#frmSearchBill').modal('hide');
            });
            $('#frmSearchBill').modal('show');
        });
    }
    function ReadInvoice(dt) {
        $('#txtBillingNo').val(dt.InvoiceNo);
        $('#txtBillItemNo').val(dt.InvoiceItemNo);
        $('#txtSICode').val(dt.SICode);
        $('#txtSDescription').val(dt.SDescription);
        $('#txtDCurrencyCode').val(dt.DCurrencyCode);
        ShowCurrency(path, dt.DCurrencyCode, '#txtCurrencyName');
        $('#txtExchangeRate').val(dt.DExchangeRate);
        $('#txtOriginalAmt').val(CDbl(dt.InvAmt, 2));
        $('#txtIs50Tavi').val(dt.Is50Tavi);
        $('#txtWHTRate').val(dt.Rate50Tavi);
        $('#txtIsTaxCharge').val(dt.IsTaxCharge);
        $('#txtVATRate').val(CDbl(dt.VATRate, 0));
        row_d.TaxInvNo = dt.LastReceiptNo;
    }


</script>
