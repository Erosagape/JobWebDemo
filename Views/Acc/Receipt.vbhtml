@Code
    ViewBag.Title = "Receipt"
End Code
    <div class="panel-body">
        <div class="row">
            <div class="col-sm-4" style="display:flex;flex-direction:row">
                <label style="display:block;width:20%">Branch:</label>
                <input type="text" class="form-control" id="txtBranchCode" style="width:15%" disabled />
                <input type="button" class="btn btn-default" value="..." onclick="SearchData('branch');" />
                <input type="text" class="form-control" id="txtBranchName" style="width:65%" disabled />
            </div>
            <div class="col-sm-6" style="display:flex;flex-direction:row">
                <label style="display:block;width:20%">Billing Place:</label>
                <input type="text" class="form-control" id="txtCustCode" style="width:20%" disabled />
                <input type="text" class="form-control" id="txtCustBranch" style="width:10%" disabled />
                <input type="button" class="btn btn-default" value="..." onclick="SearchData('customer');" />
                <input type="text" class="form-control" id="txtCustName" style="width:60%" disabled />
            </div>
            <div class="col-sm-2" style="display:flex;flex-direction:row">
                <input type="button" class="btn btn-primary" value="Show" id="btnShow" />
                <button class="btn btn-success" onclick="window.open('/Acc/GenerateReceipt', '_blank');">Generate Receipts</button>
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
                <table id="tbHeader" class="table table-responsive">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>DocNo</th>
                            <th>DocDate</th>
                            <th>CustCode</th>
                            <th>Reference</th>
                            <th>Remark</th>
                            <th>Advance</th>
                        </tr>
                    </thead>
                </table>
            </div>
            <div class="tab-pane fade" id="tabDetail">
                Details of Receipt No:<input type="text" id="txtDocNo" style="width:10%" disabled />
                <table id="tbDetail" class="table table-responsive">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>InvNo</th>
                            <th>SICode</th>
                            <th>SDescription</th>
                            <th>Cash</th>
                            <th>Transfer</th>
                            <th>Cheque</th>
                            <th>Credit</th>
                            <th>Amt</th>
                            <th>VAT</th>
                            <th>W-Tax</th>
                            <th>Net</th>
                        </tr>
                    </thead>
                </table>
            </div>
        </div>
        <div id="frmHeader" class="modal fade">
            <div class="modal-dialog-lg">
                <div class="modal-content">
                    <div class="modal-header">

                    </div>
                    <div class="modal-body">

                    </div>
                    <div class="modal-footer">

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
                                Receipt No <input type="text" id="txtDDocNo" style="width:20%" disabled />
                                Item No. <input type="text" id="txtItemNo" style="width:5%" disabled />
                                Invoice No <input type="text" id="txtInvoiceNo" style="width:20%" disabled />
                                No#<input type="text" id="txtInvoiceItemNo" style="width:5%" disabled />
                            </div>
                        </div>
                    </div>
                    <div class="modal-body">

                        Code <input type="text" id="txtSICode" style="width:15%" disabled />
                        <input type="text" id="txtSDescription" style="width:75%" />
                        <p>
                            <div class="row">
                                <div class="col-sm-12">
                                    Payment Type
                                    <select id="cboacType" onchange="ChangeAmount()">
                                        <option value="CA">Cash</option>
                                        <option value="TR">Transfer</option>
                                        <option value="CH">Cheque</option>
                                        <option value="CR">Credit</option>
                                    </select>
                                    Currency <input type="text" id="txtDCurrencyCode" style="width:10%" disabled />
                                    Exc.Rate <input type="text" id="txtDExchangeRate" style="width:15%" onchange="CalForeignDetail()" />
                                </div>
                            </div>
                        </p>
                        <p>
                            <div class="row">
                                <div class="col-sm-6" style="display:flex;">
                                    <table>
                                        <tr>
                                            <td colspan="2">
                                                Amount
                                            </td>
                                            <td>
                                                <input type="text" id="txtAmt" style="width:100%" onchange="CalVATWHT(0)" disabled/>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                VAT
                                                <select id="txtIsTaxCharge" disabled>
                                                    <option value="0">NO</option>
                                                    <option value="1">EX</option>
                                                    <option value="2">IN</option>
                                                </select>
                                            </td>
                                            <td>
                                                Rate
                                                <input type="text" id="txtVATRate" style="width:30%" onchange="CalVATWHT(0)" />
                                            </td>
                                            <td>
                                                <input type="text" id="txtAmtVAT" style="width:100%" onchange="CalNetAmount()" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                WHT
                                                <select id="txtIs50Tavi" disabled>
                                                    <option value="0">NO</option>
                                                    <option value="1">YES</option>
                                                </select>
                                            </td>
                                            <td>
                                                Rate
                                                <input type="text" id="txtRate50Tavi" style="width:30%" onchange="CalVATWHT(1)" />
                                            </td>
                                            <td>
                                                <input type="text" id="txtAmt50Tavi" style="width:100%" onchange="CalNetAmount()" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">Net</td>
                                            <td>
                                                <input type="text" id="txtNet" style="width:100%" onchange="ChangeAmount()" disabled />
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                <div class="col-sm-6">
                                    <table>
                                        <tr>
                                            <td>
                                                Amount (F)
                                            </td>
                                            <td>
                                                <input type="text" id="txtFAmt" onchange="CalForeignDetail()" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                VAT (F)
                                            </td>
                                            <td>
                                                <input type="text" id="txtFAmtVAT" disabled />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                WH-Tax (F)
                                            </td>
                                            <td>
                                                <input type="text" id="txtFAmt50Tavi" disabled />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Net (F)
                                            </td>
                                            <td>
                                                <input type="text" id="txtFNet" disabled />
                                            </td>
                                        </tr>

                                    </table>
                                </div>
                            </div>
                        </p>
                        Voucher No: <input type="text" id="txtVoucherNo" style="width:20%" disabled />
                        Control No: <input type="text" id="txtControlNo" style="width:20%" disabled />
                        #No: <input type="text" id="txtControlItemNo" style="width:5%" disabled />
                             <div class="row">
                                     <div class="col-sm-3">
                                         Cash<br /><input type="text" id="txtCashAmount" class="form-control" disabled />
                                     </div>
                                     <div class="col-sm-3">
                                         Transfer<br /><input type="text" id="txtTransferAmount" class="form-control" disabled />
                                     </div>
                                     <div class="col-sm-3">
                                         Cheque<br /><input type="text" id="txtChequeAmount" class="form-control" disabled />
                                     </div>
                                     <div class="col-sm-3">
                                         Credit<br/><input type="text" id="txtCreditAmount" class="form-control" disabled />
                                     </div>
                             </div>
                             
                    </div>
                    <div class="modal-footer">
                        <div style="float:left">
                            <button id="btnUpd" class="btn btn-primary" onclick="SaveDetail()">Update</button>
                            <button id="btnDel" class="btn btn-danger" onclick="DeleteDetail()">Delete</button>
                        </div>
                        <button id="btnHid" class="btn btn-danger" data-dismiss="modal">Close</button>
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
    function SetLOVs() {
        $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
        $('#txtBranchName').val('@ViewBag.PROFILE_DEFAULT_BRANCH_NAME');
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv, '#frmSearchCust', '#tbCust', 'Customers', response, 3);
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
        }
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
    function ShowHeader() {
        $.get(path + 'acc/getReceipt?type=ADV&branch=' + $('#txtBranchCode').val(), function (r) {
            if (r.receipt.header.length == 0) {
                $('#tbHeader').DataTable().clear().draw();
                if (isAlert==true) alert('data not found');
                return;
            }
            let h = r.receipt.header[0];
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
                    { data: "ReceiptNo", title: "Receive No" },
                    {
                        data: "ReceiptDate", title: "Issue date ",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "CustCode", title: "Customer" },
                    { data: "ReceiveRef", title: "Reference Number" },
                    { data: "TRemark", title: "Remark" },
                    { data: "TotalNet", title: "Total" }
                ],
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            });
            $('#tbHeader tbody').on('click', 'tr', function () {
                row = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                SetSelect('#tbHeader', this);
                row_d = {};
                ReadData();
                ShowDetail(row.BranchCode, row.ReceiptNo);
            });
            $('#tbHeader tbody').on('dblclick', 'tr', function () {
                $('a[href="#tabDetail"]').click();
            });
            $('#tbHeader tbody').on('click', 'button', function () {
                if (userRights.indexOf('E') > 0) {
                    $('#frmHeader').modal('show');
                } else {
                    alert('you are not allow to edit receipt document');
                }
            });
        });
    }
    function ShowDetail(branch, code) {
        $.get(path + 'Acc/GetRcpDetail?Branch=' + branch + '&Code=' + code, function (r) {
            if (r.rcpdetail.data.length > 0) {
                let d = r.rcpdetail.data;
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
                        {
                            data: null, title: "Inv.No",
                            render: function (data) {
                                return data.InvoiceNo + '#' + data.InvoiceItemNo;
                            }
                        },
                        { data: "SICode", title: "Cpde" },
                        { data: "SDescription", title: "Expenses" },
                        { data: "CashAmount", title: "Cash" },
                        { data: "TransferAmount", title: "Transfer" },
                        { data: "ChequeAmount", title: "Cheque" },
                        { data: "CreditAmount", title: "Credit" },
                        { data: "Amt", title: "Amount" },
                        { data: "AmtVAT", title: "VAT" },
                        { data: "Amt50Tavi", title: "WH-Tax" },
                        { data: "Net", title: "Total" }
                    ],
                    destroy:true
                });
                $('#tbDetail tbody').on('click', 'tr', function () {
                    SetSelect('#tbDetail', this);
                    row_d = $('#tbDetail').DataTable().row(this).data();
                    $('#txtDocNo').val(row_d.ReceiptNo);
                    LoadDetail();
                });
                $('#tbDetail tbody').on('click', 'button', function () {
                    if (userRights.indexOf('E') > 0) {
                        $('#frmDetail').modal('show');
                    } else {
                        alert('you are not allow to edit receipt document');
                    }
                });
            }
        });

    }
    function ReadData() {

    }
    function LoadDetail() {
        $('#txtDDocNo').val(row_d.ReceiptNo);
        $('#txtItemNo').val(row_d.ItemNo);

        $('#txtCashAmount').val(0);
        $('#txtTransferAmount').val(0);
        $('#txtChequeAmount').val(0);
        $('#txtCreditAmount').val(0);

        if (row_d.CashAmount > 0) {
            $('#cboacType').val('CA');
            $('#txtCashAmount').val(row_d.CashAmount);
        } else if (row_d.TransferAmount > 0) {
            $('#cboacType').val('TR');
            $('#txtTransferAmount').val(row_d.TransferAmount);
        } else if (row_d.ChequeAmount > 0) {
            $('#cboacType').val('CH');
            $('#txtChequeAmount').val(row_d.ChequeAmount);
        } else if (row_d.CreditAmount > 0) {
            $('#cboacType').val('CR');
            $('#txtCreditAmount').val(row_d.CreditAmount);
        }
        
        $('#txtControlNo').val(row_d.ControlNo);
        $('#txtVoucherNo').val(row_d.VoucherNo);
        $('#txtControlItemNo').val(row_d.ControlItemNo);
        $('#txtInvoiceNo').val(row_d.InvoiceNo);
        $('#txtInvoiceItemNo').val(row_d.InvoiceItemNo);
        $('#txtSICode').val(row_d.SICode);
        $('#txtSDescription').val(row_d.SDescription);
        $('#txtVATRate').val(row_d.VATRate);
        $('#txtRate50Tavi').val(row_d.Rate50Tavi);
        $('#txtAmt').val(row_d.Amt);
        $('#txtAmtVAT').val(row_d.AmtVAT);
        $('#txtAmt50Tavi').val(row_d.Amt50Tavi);
        $('#txtNet').val(row_d.Net);
        $('#txtDCurrencyCode').val(row_d.DCurrencyCode);
        $('#txtDExchangeRate').val(row_d.DExchangeRate);
        $('#txtFAmt').val(row_d.FAmt);
        $('#txtFAmtVAT').val(row_d.FAmtVAT);
        $('#txtFAmt50Tavi').val(row_d.FAmt50Tavi);
        $('#txtFNet').val(row_d.FNet);
        if ($('#txtControlNo').val() !== '') {
            $('#btnUpd').attr('disabled', 'disabled');
            $('#btnDel').attr('disabled', 'disabled');
        } else {
            $('#btnUpd').removeAttr('disabled');
            $('#btnDel').removeAttr('disabled');
        }
    }
    function SaveDetail() {
        if (row_d !== null) {
            row_d.SDescription = $('#txtSDescription').val();
            row_d.DCurrencyCode = $('#txtDCurrencyCode').val();
            row_d.DExchangeRate = $('#txtDExchangeRate').val();
            row_d.FAmt = CNum($('#txtFAmt').val());
            row_d.FAmt50Tavi = CNum($('#txtFAmt50Tavi').val());
            row_d.FAmtVAT = CNum($('#txtFAmtVAT').val());
            row_d.FNet = CNum($('#txtFNet').val());
            row_d.Amt = CNum($('#txtAmt').val());
            row_d.Amt50Tavi = CNum($('#txtAmt50Tavi').val());
            row_d.AmtVAT = CNum($('#txtAmtVAT').val());
            row_d.Net = CNum($('#txtNet').val());
            row_d.CashAmount = CNum($('#txtCashAmount').val());
            row_d.TransferAmount = CNum($('#txtTransferAmount').val());
            row_d.ChequeAmount = CNum($('#txtChequeAmount').val());
            row_d.CreditAmount = CNum($('#txtCreditAmount').val());
            row_d.VATRate = CNum($('#txtVATRate').val());
            row_d.Rate50Tavi = CNum($('#txtRate50Tavi').val());

            let jsonText = JSON.stringify({ data: row_d });
            //alert(jsonText);
            $.ajax({
                url: "@Url.Action("SetRcpDetail", "Acc")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.data !== null) {
                        ShowDetail(row.BranchCode, row.ReceiptNo);
                        alert(response.result.msg + '\n=>' + response.result.data);
                        $('#frmDetail').modal('hide');
                        return;
                    }
                    alert(response.result.msg);
                },
                error: function (e) {
                    alert(e);
                }
            });
        } else {
            alert('no data to save');
        }
    }
    function DeleteData() {
        if (row_d !== null) {
            $.get(path, 'Acc/DelRcpDetail?Branch=' + row.BranchCode + '&Code=' + row.ReceiptNo + '&Item=' + row_d.ItemNo)
                .done(function (r) {
                    if (r.rcpdetail.data !== null) {
                        ShowDetail(row.BranchCode, row.ReceiptNo);
                    }
                    alert(r.rcpdetail.result);
                });
        } else {
            alert('no data to delete');
        }
    }
    function ChangeAmount() {
        $('#txtCashAmount').val(0);
        $('#txtTransferAmount').val(0);
        $('#txtChequeAmount').val(0);
        $('#txtCreditAmount').val(0);
        let amt = $('#txtNet').val();
        switch ($('#cboacType').val()) {
            case 'CA':
                $('#txtCashAmount').val(amt);
                break;
            case 'TR':
                $('#txtTransferAmount').val(amt);
                break;
            case 'CH':
                $('#txtChequeAmount').val(amt);
                break;
            case 'CR':
                $('#txtCreditAmount').val(amt);
                break;
        }
    }

    function PrintData() {
        let code = row.ReceiptNo;
        if (code !== '') {
            let branch = $('#txtBranchCode').val();
            window.open(path + 'Acc/FormRcp?Branch=' + branch + '&Code=' + code);
        }
    }

    function CalForeignDetail() {
        let rate = CNum($('#txtDExchangeRate').val());
        $('#txtAmt').val(CDbl(CNum($('#txtFAmt').val()) * rate, 2));
        CalVATWHT(0);
    }
    function CalVATWHT(step = 0) {

        let amt = CNum($('#txtAmt').val());
        if (step == 0) {
            let vat = amt * CNum($('#txtVATRate').val()) * 0.01;
            $('#txtAmtVAT').val(ShowNumber(vat,2));
        }
        let wht = amt * CNum($('#txtRate50Tavi').val()) * 0.01;
        $('#txtAmt50Tavi').val(ShowNumber(wht, 2));
        CalNetAmount();
    }

    function CalNetAmount() {
        let amt = CNum($('#txtAmt').val());
        let vat = CNum($('#txtAmtVAT').val());
        let wht = CNum($('#txtAmt50Tavi').val());
        let net = amt + vat - wht;

        $('#txtNet').val(ShowNumber(net, 2));

        let rate = CNum($('#txtDExchangeRate').val());
        $('#txtFAmtVAT').val(CDbl(CNum($('#txtAmtVAT').val()) / rate, 2));
        $('#txtFAmt50Tavi').val(CDbl(CNum($('#txtAmt50Tavi').val()) / rate, 2));
        $('#txtFNet').val(CDbl(CNum($('#txtNet').val()) / rate, 2));
        ChangeAmount();
    }
</script>
