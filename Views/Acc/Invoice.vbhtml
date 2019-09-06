
@Code
    ViewBag.Title = "invoice"
End Code
    <div class="panel-body">
        <div class="row">
            <div class="col-sm-4">
                Branch
                <br />
                <div style="display:flex;flex-direction:row">
                    <input type="text" class="form-control" id="txtBranchCode" style="width:15%" disabled />
                    <input type="button" class="btn btn-default" value="..." onclick="SearchData('branch');" />
                    <input type="text" class="form-control" id="txtBranchName" style="width:65%" disabled />
                </div>
            </div>
            <div class="col-sm-6">
                Customer:
                <br />
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
                Invoice Date From:<br />
                <input type="date" class="form-control" id="txtDocDateF" />
            </div>
            <div class="col-sm-2">
                Invoice Date To:<br />
                <input type="date" class="form-control" id="txtDocDateT" />
            </div>
            <div class="col-sm-3">
                <br />
                <a href="#" class="btn btn-primary" id="btnShow">
                    <i class="fa fa-lg fa-filter"></i>&nbsp;<b>Search</b>
                </a>
                <a href="#" class="btn btn-default w3-purple" id="btnGen" onclick="CreateInvoice()">
                    <i class="fa fa-lg fa-file-o"></i>&nbsp;<b>Create Invoice</b>
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
            <input type="checkbox" id="chkCancel" />Show Cancel Only
            <div class="tab-pane fade in active" id="tabHeader">
                <table id="tbHeader" class="table table-responsive">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th class="all">DocNo</th>
                            <th class="desktop">DocDate</th>
                            <th class="desktop">CustCode</th>
                            <th>Remark</th>
                            <th class="desktop">Discount</th>
                            <th class="desktop">Cust.Adv</th>
                            <th class="desktop">Advance</th>
                            <th class="desktop">Charge</th>
                            <th class="desktop">VAT</th>
                            <th class="desktop">WHT</th>
                            <th class="all">Net</th>
                        </tr>
                    </thead>
                </table>
            </div>
            <div class="tab-pane fade" id="tabDetail">
                Details Of Invoice No:<input type="text" id="txtInvNo" style="width:10%" disabled />
                <table id="tbDetail" class="table table-responsive" style="width:100%">
                    <thead>
                        <tr>
                            <th>ItemNo</th>
                            <th class="desktop">SICode</th>
                            <th class="all">SDescription</th>
                            <th class="desktop">ExpSlipNo</th>
                            <th class="desktop">AmtAdvance</th>
                            <th class="desktop">AmtCharge</th>
                            <th class="desktop">Currency</th>
                            <th class="desktop">Amt</th>
                            <th class="desktop">AmtDiscount</th>
                            <th class="desktop">AmtVAT</th>
                            <th class="desktop">Amt50Tavi</th>
                            <th class="all">TotalAmt</th>
                        </tr>
                    </thead>
                </table>
                <a href="#" class="btn btn-info" id="btnPrint" onclick="PrintData()">
                    <i class="fa fa-lg fa-print"></i>&nbsp;<b>Print</b>
                </a>
            </div>
        </div>
        <div id="frmHeader" class="modal modal-lg fade">
            <div class="modal-dialog-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <div style="display:flex;flex-direction:row">
                            Invoice No:<input type="text" id="txtDocNo" style="width:10%" disabled />
                            Doc.Date:<input type="date" id="txtDocDate" style="width:10%" disabled />
                            Customer:<input type="text" id="txtDCustCode" style="width:10%" disabled />
                            <input type="text" id="txtDCustBranch" style="width:5%" disabled />
                            <input type="text" id="txtDCustName" style="width:30%" disabled />
                        </div>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-sm-2" style="display:flex;flex-direction:column">
                                Advance :<input type="text" id="txtTotalAdvance" style="width:100%" disabled />

                                Charge :<input type="text" id="txtTotalCharge" style="width:100%" disabled />
                                <div style="flex-direction:row">
                                    Disc.Line :<input type="text" id="txtSumDiscount" style="width:50%" disabled />
                                    <br />
                                    Disc.Total :<input type="text" id="txtDiscountCal" style="width:50%" disabled />
                                    <input type="hidden" id="txtTotalDiscount" />
                                </div>

                                Vatable :<input type="text" id="txtTotalIsTaxCharge" style="width:100%" disabled />
                                <div style="flex-direction:row">
                                    VAT Rate:<input type="text" id="txtVATRate" style="width:15%" />
                                    VAT:<input type="text" id="txtTotalVAT" style="width:40%" />
                                </div>
                                <div style="flex-direction:row">
                                    Taxable :<input type="text" id="txtTotalIs50Tavi" style="width:100%" disabled />
                                    WH-Tax:<input type="text" id="txtTotal50Tavi" style="width:50%" />
                                </div>
                                Cust.Adv :<input type="text" id="txtTotalCustAdv" style="width:100%" disabled />
                                Total Inv:<input type="text" id="txtTotalNet" style="width:100%" />
                            </div>
                            <div class="col-sm-5" style="display:flex;flex-direction:column">
                                <p style="flex-direction:row">
                                    Cust contact:<input type="text" id="txtContactName" style="width:30%" />
                                </p>
                                <p style="flex-direction:row">
                                    Shipping Note:
                                    <textarea id="txtShippingRemark" style="width:100%"></textarea>
                                </p>
                                <p style="flex-direction:row">
                                    Bill To:<input type="text" id="txtBillToCustCode" style="width:20%" disabled />
                                    <input type="text" id="txtBillToCustBranch" style="width:10%" disabled />
                                    <button onclick="SearchData('billing')">...</button>
                                    <input type="text" id="txtBillToCustName" style="width:40%" disabled />
                                    <textarea id="txtBillAddress" style="width:100%" disabled></textarea>
                                </p>
                                <p style="flex-direction:row">
                                    Bill.No:<input type="text" id="txtBillAcceptNo" style="width:15%" disabled />
                                    Issue Date:<input type="date" id="txtBillIssueDate" style="width:25%" disabled />
                                    Accept Date:<input type="date" id="txtBillAcceptDate" style="width:25%" />
                                </p>
                                <p style="flex-direction:row">
                                    Discount Rate(%) :<input type="text" id="txtDiscountRate" style="width:15%" onchange="SetDiscount()" />
                                    Discount:<input type="text" id="txtCalDiscount" style="width:15%" />
                                </p>
                                <p style="flex-direction:row">
                                    Currency:<input type="text" id="txtCurrencyCode" style="width:10%" disabled />
                                    <button onclick="SearchData('currency')">...</button>
                                    <input type="text" id="txtCurrencyName" style="width:40%" disabled />
                                </p>
                                <p style="flex-direction:row">
                                    Exchange Rate:<input type="text" id="txtExchangeRate" style="width:15%" onchange="CalForeign()" />
                                    Total Foreign:<input type="text" id="txtForeignNet" style="width:20%" disabled />
                                </p>
                            </div>
                            <div class="col-sm-4">
                                Remark:
                                <input type="text" id="txtRemark1" class="form-control" />
                                <input type="text" id="txtRemark2" class="form-control" />
                                <input type="text" id="txtRemark3" class="form-control" />
                                <input type="text" id="txtRemark4" class="form-control" />
                                <input type="text" id="txtRemark5" class="form-control" />
                                <input type="text" id="txtRemark6" class="form-control" />
                                <input type="text" id="txtRemark7" class="form-control" />
                                <input type="text" id="txtRemark8" class="form-control" />
                                <input type="text" id="txtRemark9" class="form-control" />
                                <input type="text" id="txtRemark10" class="form-control" />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-4">
                                Cancel Reason:<br /> <textarea id="txtCancelReson" style="width:80%"></textarea>
                                <button id="btnCancel" class="btn btn-danger" onclick="CancelData()">Cancel</button>
                            </div>
                            <div class="col-sm-3">
                                Cancel date:<br /> <input type="date" id="txtCancelDate" style="width:100%" disabled />
                            </div>
                            <div class="col-sm-2">
                                Cancel Time:<br /><input type="text" id="txtCancelTime" style="width:100%" disabled />
                            </div>
                            <div class="col-sm-3">
                                Cancel By:<br /> <input type="text" id="txtCancelProve" style="width:100%" disabled />
                            </div>
                        </div>
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
                        <button id="btnHide" class="btn btn-danger" data-dismiss="modal">X</button>
                    </div>
                </div>
            </div>
        </div>
        <div id="frmDetail" class="modal modal-lg fade">
            <div class="modal-dialog-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <h4>Edit Detail</h4>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-sm-12">
                                Invoice No <input type="text" id="txtDDocNo" style="width:10%" disabled />
                                Item No. <input type="text" id="txtItemNo" style="width:5%" disabled />
                                Code <input type="text" id="txtSICode" style="width:10%" disabled />
                                <input type="text" id="txtSDescription" style="width:30%" />
                                Slip No <input type="text" id="txtExpSlipNO" style="width:20%" />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                Currency <input type="text" id="txtDCurrencyCode" style="width:10%" disabled />
                                <input type="button" id="btnCurr" value="..." onclick="SearchData('dcurrency')" />
                                <input type="text" id="txtDCurrencyName" style="width:40%" disabled />
                                Exc.Rate <input type="text" id="txtDExchangeRate" style="width:15%" onchange="CalForeignDetail()" />
                                Discount
                                <select id="txtDiscountType" onchange="ShowDiscount()">
                                    <option value="0" selected>Percent</option>
                                    <option value="1">Cash</option>
                                </select>
                                <input type="text" id="txtDiscountPerc" style="width:10%" onchange="CalDiscountDetail()" />
                            </div>
                        </div>
                        <p>
                            <div class="row">
                                <div class="col-sm-6">
                                    Remark <textarea id="txtSRemark" style="width:100%"></textarea>
                                    <input type="hidden" id="txtCurrencyCodeCredit" />
                                    <input type="hidden" id="txtExchangeRateCredit" />
                                </div>
                                <div class="col-sm-6" style="display:flex;flex-direction:row">
                                    <div style="flex-direction:column;flex:1">
                                        Qty <input type="text" id="txtQty" disabled />
                                    </div>
                                    <div style="flex-direction:column;flex:1">
                                        Unit <input type="text" id="txtQtyUnit" disabled />
                                    </div>
                                    <div style="flex-direction:column;flex:1">
                                        Price(B) <input type="text" id="txtUnitPrice" disabled />
                                    </div>
                                    <div style="flex-direction:column;flex:1">
                                        Amount(B) <input type="text" id="txtAmt" disabled />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-6" style="display:flex;">
                                    <div style="flex-direction:row;flex:1">
                                        <table>
                                            <tr>
                                                <td>VAT</td>
                                                <td>
                                                    <select id="txtIsTaxCharge" disabled>
                                                        <option value="0">NO</option>
                                                        <option value="1">EX</option>
                                                        <option value="2">IN</option>
                                                    </select>
                                                </td>
                                                <td>Rate</td>
                                                <td>
                                                    <input type="text" id="txtDVATRate" disabled />
                                                </td>
                                                <td>
                                                    <input type="text" id="txtAmtVat" disabled />
                                                </td>
                                                <td>
                                                    Discount (B)
                                                </td>
                                                <td>
                                                    <input type="text" id="txtAmtDiscount" onchange="CalVATWHT(0)" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>WHT</td>
                                                <td>
                                                    <select id="txtIs50Tavi" disabled>
                                                        <option value="0">NO</option>
                                                        <option value="1">YES</option>
                                                    </select>
                                                </td>
                                                <td>
                                                    Rate
                                                </td>
                                                <td>
                                                    <input type="text" id="txtRate50Tavi" disabled />
                                                </td>
                                                <td>
                                                    <input type="text" id="txtAmt50Tavi" disabled />
                                                </td>
                                                <td>
                                                    Discount (F)
                                                </td>
                                                <td>
                                                    <input type="text" id="txtFAmtDiscount" disabled />
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>
                                <div class="col-sm-6">
                                    <table>
                                        <tr>
                                            <td>
                                                Credit (F)<br />
                                                <input type="text" id="txtFAmtCredit" disabled />
                                            </td>
                                            <td>
                                                Credit (B)<br />
                                                <input type="text" id="txtAmtCredit" disabled />
                                            </td>
                                            <td>
                                                Price(F)<br />
                                                <input type="text" id="txtFUnitPrice" disabled />
                                            </td>
                                            <td>
                                                Amount(F)<br />
                                                <input type="text" id="txtFAmt" disabled />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <b>Advance</b><br />
                                                <input type="text" id="txtAmtAdvance" disabled style="font:bold" />
                                            </td>
                                            <td>
                                                <b>Charge</b><br />
                                                <input type="text" id="txtAmtCharge" disabled style="font:bold" />
                                            </td>
                                            <td>
                                                Total(F)<br /><input type="text" id="txtFTotalAmt" disabled />
                                            </td>
                                            <td>
                                                Total(B)<br /><input type="text" id="txtTotalAmt" disabled />
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
                                <i class="fa fa-lg fa-save"></i>&nbsp;<b>Save</b>
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
            w += '&show=CANCEL';
        } else {
            w += '&show=ACTIVE';
        }
        $.get(path + 'acc/getinvforbill?branch=' + $('#txtBranchCode').val()+ w, function (r)
        {
            if (r.invdetail.data.length == 0) {
                $('#tbHeader').DataTable().clear().draw();
                ShowMessage('data not found');
                return;
            }
            let h = r.invdetail.data;
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
                    { data: "DocNo", title: "Inv No" },
                    {
                        data: "DocDate", title: "Inv date ",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "CustCode", title: "Customer" },
                    { data: "RefNo", title: "Reference Number" },
                    { data: "TotalDiscount", title: "Discount" },
                    { data: "TotalCustAdv", title: "Cust.Adv" },
                    { data: "TotalAdvance", title: "Advance" },
                    { data: "TotalCharge", title: "Charge" },
                    { data: "TotalVAT", title: "VAT" },
                    { data: "Total50Tavi", title: "WHT" },
                    { data: "TotalNet", title: "NET" }
                ],
                responsive:true,
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page,
            });
            $('#tbHeader tbody').on('click', 'tr', function () {
                SetSelect('#tbHeader', this);
                row = $('#tbHeader').DataTable().row(this).data(); //read current row selected
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
                    ShowMessage('you are not allow to edit invoice document');
                }
            });
        });
    }
    function PrintData() {
        let code = row.DocNo;
        if (code !== '') {
            let branch = row.BranchCode;
            window.open(path + 'Acc/FormInv?Branch=' + branch + '&Code=' + code,'_blank');
        }
    }
    function ShowDetail(branch,code) {
        $.get(path + 'Acc/GetInvDetail?branch=' + branch + '&code=' + code, function (r) {
            if (r.invdetail.data.length > 0) {
                let d = r.invdetail.data;
                $('#tbDetail').DataTable({
                    data: d,
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: "ItemNo", title: "No" },
                        { data: "SICode", title: "Code" },
                        { data: "SDescription", title: "Desc" },
                        { data: "ExpSlipNO", title: "Slip" },
                        { data: "AmtAdvance", title: "Advance" },
                        { data: "AmtCharge", title: "Charge" },
                        {
                            data: null, title: "Currency", render:function(data) {
                                return data.CurrencyCode + '=' + data.ExchangeRate;
                            }
                        },
                        { data: "Amt", title: "Amount" },
                        { data: "AmtDiscount", title: "Discount" },
                        { data: "AmtVat", title: "VAT" },
                        { data: "Amt50Tavi", title: "WHT" },
                        { data: "TotalAmt", title: "NET" }
                    ],
                    responsive:true,
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                $('#tbDetail tbody').on('click', 'tr', function () {
                    SetSelect('#tbDetail', this);
                    if (userRights.indexOf('E') > 0) {
                        let data = $('#tbDetail').DataTable().row(this).data();
                        LoadDetail(data);
                    } else {
                        ShowMessage('you are not allow to edit invoice');
                    }
                });
            }
        });
    }
    function SetLOVs() {
        $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
        $('#txtBranchName').val('@ViewBag.PROFILE_DEFAULT_BRANCH_NAME');
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv, '#frmSearchCust', '#tbCust', 'Customers', response, 3);
            //Customers
            CreateLOV(dv, '#frmSearchBill', '#tbBill', 'Billing Place', response, 3);

            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response,4);
            //Currency
            CreateLOV(dv, '#frmSearchCurr', '#tbCurr', 'Currency Code', response, 4);
        });
    }
    function LoadDetail(dt) {
        row_d = dt;
        $('#txtDDocNo').val(dt.DocNo);
        $('#txtItemNo').val(dt.ItemNo);
        $('#txtSICode').val(dt.SICode);
        $('#txtSDescription').val(dt.SDescription);
        $('#txtExpSlipNO').val(dt.ExpSlipNO);
        $('#txtSRemark').val(dt.SRemark);
        $('#txtDCurrencyCode').val(dt.CurrencyCode);
        ShowCurrency(path, dt.CurrencyCode, '#txtDCurrencyName');
        $('#txtDExchangeRate').val(dt.ExchangeRate);
        $('#txtQty').val(dt.Qty);
        $('#txtQtyUnit').val(dt.QtyUnit);
        $('#txtUnitPrice').val(ShowNumber(dt.UnitPrice,2));
        $('#txtFUnitPrice').val(ShowNumber(dt.FUnitPrice, 2));
        $('#txtAmt').val(ShowNumber(dt.Amt, 2));
        $('#txtFAmt').val(ShowNumber(dt.FAmt, 2));
        $('#txtDiscountType').val(dt.DiscountType);
        $('#txtDiscountPerc').val(dt.DiscountPerc);
        $('#txtAmtDiscount').val(ShowNumber(dt.AmtDiscount, 2));
        $('#txtFAmtDiscount').val(ShowNumber(dt.FAmtDiscount, 2));
        $('#txtIs50Tavi').val(dt.Is50Tavi);
        $('#txtRate50Tavi').val(dt.Rate50Tavi);
        $('#txtAmt50Tavi').val(ShowNumber(dt.Amt50Tavi,2));
        $('#txtIsTaxCharge').val(dt.IsTaxCharge);
        $('#txtAmtVat').val(ShowNumber(dt.AmtVat,2));
        $('#txtTotalAmt').val(ShowNumber(dt.TotalAmt,2));
        $('#txtFTotalAmt').val(ShowNumber(dt.FTotalAmt,2));
        $('#txtAmtAdvance').val(ShowNumber(dt.AmtAdvance,2));
        $('#txtAmtCharge').val(ShowNumber(dt.AmtCharge, 2));
        $('#txtDVATRate').val(ShowNumber(dt.VATRate,0));
        $('#txtCurrencyCodeCredit').val(dt.CurrencyCodeCredit);
        $('#txtExchangeRateCredit').val(dt.ExchangeRateCredit);
        $('#txtAmtCredit').val(ShowNumber(dt.AmtCredit,2));
        $('#txtFAmtCredit').val(ShowNumber(dt.FAmtCredit, 2));

        $('#frmDetail').modal('show');
    }
    function SaveDetail() {
        if (row_d !== null) {
            row_d.SDescription = $('#txtSDescription').val();
            row_d.ExpSlipNO = $('#txtExpSlipNO').val();
            row_d.SRemark = $('#txtSRemark').val();
            row_d.CurrencyCode = $('#txtDCurrencyCode').val();
            row_d.ExchangeRate = $('#txtDExchangeRate').val();
            row_d.FUnitPrice = CNum($('#txtFUnitPrice').val());
            row_d.FAmt = CNum($('#txtFAmt').val());
            row_d.DiscountType = $('#txtDiscountType').val();
            row_d.DiscountPerc = CNum($('#txtDiscountPerc').val());
            row_d.AmtDiscount = CNum($('#txtAmtDiscount').val());
            row_d.FAmtDiscount = CNum($('#txtFAmtDiscount').val());
            row_d.Amt50Tavi = CNum($('#txtAmt50Tavi').val());
            row_d.AmtVat = CNum($('#txtAmtVat').val());
            row_d.TotalAmt = CNum($('#txtTotalAmt').val());
            row_d.FTotalAmt = CNum($('#txtFTotalAmt').val());
            row_d.AmtAdvance = CNum($('#txtAmtAdvance').val());
            row_d.AmtCharge = CNum($('#txtAmtCharge').val());

            let jsonText = JSON.stringify({ data: row_d });
            //ShowMessage(jsonText);
            $.ajax({
                url: "@Url.Action("SetInvDetail", "Acc")",
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
            $.get(path+ 'Acc/DelInvDetail?Branch=' + row.BranchCode + '&Code=' + row.DocNo + '&Item=' + row_d.ItemNo)
                .done(function (r) {
                    if (r.invdetail.data !== null) {
                        ShowDetail(row.BranchCode, row.DocNo);
                    }
                    ShowMessage(r.invdetail.result);
                });
        } else {
            ShowMessage('no data to delete');
        }

    }
    function SearchData(type) {
        switch (type) {
            case 'branch':
                SetGridBranch(path, '#tbBranch', '#frmSearchBranch', ReadBranch);
                break;
            case 'customer':
                SetGridCompany(path, '#tbCust', '#frmSearchCust', ReadCustomer);
                break;
            case 'billing':
                SetGridCompany(path, '#tbBill', '#frmSearchBill', ReadBilling);
                break;
            case 'currency':
                SetGridCurrency(path, '#tbCurr', '#frmSearchCurr', ReadCurrency);
                break;
            case 'dcurrency':
                SetGridCurrency(path, '#tbCurr', '#frmSearchCurr', ReadDCurrency);
                break;
        }
    }
    function SaveData() {
         let dataInv = {
            BranchCode:$('#txtBranchCode').val(),
            DocNo: $('#txtDocNo').val(),
            DocType:row.DocType,
            DocDate: CDateTH($('#txtDocDate').val()),
            CustCode:$('#txtDCustCode').val(),
            CustBranch:$('#txtDCustBranch').val(),
            BillToCustCode:$('#txtBillToCustCode').val(),
            BillToCustBranch:$('#txtBillToCustBranch').val(),
            ContactName:$('#txtContactName').val(),
            EmpCode:user,
            PrintedBy:row.PrintedBy,
            PrintedDate:CDateTH(row.PrintedDate),
            PrintedTime:row.PrintedTime,
            RefNo: row.RefNo,
            VATRate:CDbl($('#txtVATRate').val(),0),
            TotalAdvance:CNum($('#txtTotalAdvance').val()),
            TotalCharge:CNum($('#txtTotalCharge').val()),
            TotalIsTaxCharge:CNum($('#txtTotalIsTaxCharge').val()),
            TotalIs50Tavi:CNum($('#txtTotalIs50Tavi').val()),
            TotalVAT:CNum($('#txtTotalVAT').val()),
            Total50Tavi:CNum($('#txtTotal50Tavi').val()),
            TotalCustAdv:CNum($('#txtTotalCustAdv').val()),
            TotalNet:CNum($('#txtTotalNet').val()),
            CurrencyCode:$('#txtCurrencyCode').val(),
            ExchangeRate:CNum($('#txtExchangeRate').val()),
            ForeignNet: CNum($('#txtForeignNet').val()),
            TotalDiscount: CNum($('#txtTotalDiscount').val()),
            SumDiscount: CNum($('#txtSumDiscount').val()),
            DiscountRate: CNum($('#txtDiscountRate').val()),
            DiscountCal:CNum($('#txtDiscountCal').val()),
            BillAcceptDate:CDateTH($('#txtBillAcceptDate').val()),
            BillIssueDate:CDateTH($('#txtBillIssueDate').val()),
            BillAcceptNo:$('#txtBillAcceptNo').val(),
            Remark1:$('#txtRemark1').val(),
            Remark2:$('#txtRemark2').val(),
            Remark3:$('#txtRemark3').val(),
            Remark4:$('#txtRemark4').val(),
            Remark5:$('#txtRemark5').val(),
            Remark6:$('#txtRemark6').val(),
            Remark7:$('#txtRemark7').val(),
            Remark8:$('#txtRemark8').val(),
            Remark9:$('#txtRemark9').val(),
            Remark10:$('#txtRemark10').val(),
            CancelReson:$('#txtCancelReson').val(),
            CancelProve:$('#txtCancelProve').val(),
            CancelDate:CDateTH($('#txtCancelDate').val()),
            CancelTime:$('#txtCancelTime').val(),
            ShippingRemark:$('#txtShippingRemark').val()
        };
        let jsonString = JSON.stringify({ data: dataInv });
        $.ajax({
            url: "@Url.Action("SetInvHeader", "Acc")",
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
    function CancelData() {
        if (userRights.indexOf('D') > 0) {
            if ($('#txtCancelReson').val() == '') {
                ShowMessage('Please enter reason for cancel');
                $('#txtCancelReson').focus();
                return;
            }
            $('#txtCancelDate').val(GetToday());
            $('#txtCancelTime').val(ShowTime(GetTime()));
            $('#txtCancelProve').val(user);
        } else {
            ShowMessage('you are not allow to cancel invoice');
        }
    }
    function ReadData() {
        $('#txtInvNo').val(row.DocNo);
        $('#txtDocNo').val(row.DocNo);
        $('#txtDocDate').val(CDateEN(row.DocDate));
        $('#txtDCustCode').val(row.CustCode);
        $('#txtDCustBranch').val(row.CustBranch);
        ShowCustomer(path, row.CustCode, row.CustBranch, '#txtDCustName');
        $('#txtContactName').val(row.ContactName);
        $('#txtShippingRemark').val(row.ShippingRemark);
        $('#txtBillToCustCode').val(row.BillToCustCode);
        $('#txtBillToCustBranch').val(row.BillToCustBranch);
        ShowCustomerAddress(path, row.BillToCustCode, row.BillToCustBranch, '#txtBillToCustName', '#txtBillAddress');
        $('#txtBillAcceptNo').val(row.BillAcceptNo);
        $('#txtBillIssueDate').val(CDateEN(row.BillIssueDate));
        $('#txtBillAcceptDate').val(CDateEN(row.BillAcceptDate));
        $('#txtDiscountRate').val(row.DiscountRate);
        $('#txtDiscountCal').val(ShowNumber(row.DiscountCal,2));
        $('#txtCurrencyCode').val(row.CurrencyCode);
        $('#txtExchangeRate').val(row.ExchangeRate);
        $('#txtVATRate').val(row.VATRate);
        ShowCurrency(path, row.CurrencyCode, '#txtCurrencyName');
        $('#txtForeignNet').val(ShowNumber(row.ForeignNet,2));
        $('#txtRemark1').val(row.Remark1);
        $('#txtRemark2').val(row.Remark2);
        $('#txtRemark3').val(row.Remark3);
        $('#txtRemark4').val(row.Remark4);
        $('#txtRemark5').val(row.Remark5);
        $('#txtRemark6').val(row.Remark6);
        $('#txtRemark7').val(row.Remark7);
        $('#txtRemark8').val(row.Remark8);
        $('#txtRemark9').val(row.Remark9);
        $('#txtRemark10').val(row.Remark10);
        $('#txtTotalAdvance').val(ShowNumber(row.TotalAdvance,2));
        $('#txtTotalCharge').val(ShowNumber(row.TotalCharge,2));
        $('#txtSumDiscount').val(ShowNumber(row.SumDiscount,2));
        $('#txtCalDiscount').val(ShowNumber(row.DiscountCal,2));
        $('#txtTotalDiscount').val(ShowNumber(row.TotalDiscount,2));
        $('#txtTotalCustAdv').val(ShowNumber(row.TotalCustAdv,2));
        $('#txtTotalIsTaxCharge').val(ShowNumber(row.TotalIsTaxCharge,2));
        $('#txtTotalIs50Tavi').val(ShowNumber(row.TotalIs50Tavi,2));
        $('#txtTotalVAT').val(ShowNumber(row.TotalVAT,2));
        $('#txtTotal50Tavi').val(ShowNumber(row.Total50Tavi,2));
        $('#txtTotalNet').val(ShowNumber(row.TotalNet,2));
        $('#txtCancelReson').val(row.CancelReson);
        $('#txtCancelDate').val(CDateEN(row.CancelDate));
        $('#txtCancelTime').val(ShowTime(row.CancelTime));
        $('#txtCancelProve').val(row.CancelProve);
    }
    function ReadCustomer(dt) {
        $('#txtCustCode').val(dt.CustCode);
        $('#txtCustBranch').val(dt.Branch);
        ShowCustomer(path, dt.CustCode, dt.Branch, '#txtCustName');
    }
    function ReadBilling(dt) {
        $('#txtBillToCustCode').val(dt.CustCode);
        $('#txtBillToCustBranch').val(dt.Branch);
        ShowCustomer(path, dt.CustCode, dt.Branch, '#txtBillToCustName');
        $('#txtBillAddress').val(dt.TAddress1 + '' + dt.TAddress2);
    }
    function ReadCurrency(dt) {
        $('#txtCurrencyCode').val(dt.Code);
        $('#txtCurrencyName').val(dt.TName);
        $('#txtExchangeRate').focus();
    }
    function ReadDCurrency(dt) {
        $('#txtDCurrencyCode').val(dt.Code);
        $('#txtDCurrencyName').val(dt.TName);
        $('#txtDExchangeRate').focus();
    }
    function ReadBranch(dt) {
        $('#txtBranchCode').val(dt.Code);
        $('#txtBranchName').val(dt.BrName);
        $('#txtBranchCode').focus();
    }
    function ShowDiscount() {
        let chk = $('#txtDiscountType').val();
        if (chk === "1") {
            $('#txtDiscountPerc').val(0);
            $('#txtDiscountPerc').attr('disabled', 'disabled');
        } else {
            $('#txtDiscountPerc').removeAttr('disabled');
        }
    }
    function SetDiscount() {
        let amt = CNum($('#txtTotalAdvance').val()) + CNum($('#txtTotalCharge').val()) - CNum($('#txtSumDiscount').val()) + CNum($('#txtTotalVAT').val()) - CNum($('#txtTotal50Tavi').val()) - CNum($('#txtTotalCustAdv').val());
        let disc = amt * Number($('#txtDiscountRate').val()) * 0.01;
        $('#txtCalDiscount').val(ShowNumber(disc, 2));
        $('#txtDiscountCal').val(ShowNumber(disc,2));
        SumDiscount();
    }
    function SumDiscount() {
        let totaldisc = CNum($('#txtSumDiscount').val()) + CNum($('#txtCalDiscount').val());
        $('#txtTotalDiscount').val(ShowNumber(totaldisc,2));
        CalTotal();
    }
    function CalTotal() {
        let totaldisc = CNum($('#txtSumDiscount').val()) + CNum($('#txtCalDiscount').val());
        let totalnet = CNum($('#txtTotalAdvance').val()) + CNum($('#txtTotalCharge').val())- totaldisc + CNum($('#txtTotalVAT').val()) - CNum($('#txtTotal50Tavi').val()) - CNum($('#txtTotalCustAdv').val());
        $('#txtTotalNet').val(ShowNumber(totalnet,2));
        CalForeign();
    }
    function CalForeign() {
        let totalforeign = CDbl(CNum($('#txtTotalNet').val()) / CNum($('#txtExchangeRate').val()), 2);
        $('#txtForeignNet').val(ShowNumber(totalforeign,2));
    }
    function CalForeignDetail() {
        let rate = CNum($('#txtDExchangeRate').val());
        $('#txtFUnitPrice').val(CDbl(CNum($('#txtUnitPrice').val()) / rate, 2));
        $('#txtFAmt').val(CDbl(CNum($('#txtAmt').val()) / rate, 2));
        $('#txtFTotalAmt').val(CDbl(CNum($('#txtTotalAmt').val()) / rate, 2));
        //$('#txtFAmtCredit').val(CDbl(CNum($('#txtAmtCredit').val()) / rate, 2));
        $('#txtFAmtDiscount').val(CDbl(CNum($('#txtAmtDiscount').val()) / rate, 2));
        if (CNum($('#txtAmtAdvance').val()) > 0) {
            $('#txtAmtAdvance').val(ShowNumber($('#txtFTotalAmt').val(), 2));
        }
        if (CNum($('#txtAmtCharge').val()) > 0) {
            $('#txtAmtCharge').val(ShowNumber(CNum($('#txtFAmt').val()) - CNum($('#txtFAmtDiscount').val()), 2));
        }
    }
    function CalDiscountDetail() {
        let amt = CNum($('#txtAmt').val());
        let disc = amt * CNum($('#txtDiscountPerc').val()) * 0.01;
        $('#txtAmtDiscount').val(ShowNumber(disc,2));
        CalVATWHT(0);
    }
    function CalVATWHT(step = 0) {
        let amt = CNum($('#txtAmt').val())-CNum($('#txtAmtDiscount').val());
        if (step == 0) {
            let vat = amt * CNum($('#txtDVATRate').val()) * 0.01;
            $('#txtAmtVat').val(ShowNumber(vat,2));
        }
        let wht = amt * CNum($('#txtRate50Tavi').val()) * 0.01;
        $('#txtAmt50Tavi').val(ShowNumber(wht, 2));
        CalNetAmount();
    }
    function CalNetAmount() {
        let amt = CNum($('#txtAmt').val()) - CNum($('#txtAmtDiscount').val());
        let vat = CNum($('#txtAmtVat').val());
        let wht = CNum($('#txtAmt50Tavi').val());
        let net = amt + vat - wht;

        $('#txtTotalAmt').val(ShowNumber(net, 2));
        CalForeignDetail();
    }
    function CreateInvoice() {
        let w = '';
        if ($('#txtCustCode').val() !== '') {
            w += '&custcode=' + $('#txtCustCode').val() + '&custbranch=' + $('#txtCustBranch').val();
        }
        window.open('/clr/generateinv?branch=' + $('#txtBranchCode').val() + w, '_blank');
    }
</script>


