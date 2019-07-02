
@Code
    ViewBag.Title = "invoice"
End Code
<div class="panel-body">
    <div class="row">
        <div class="col-sm-4" style="display:flex;flex-direction:row">
            <label style="display:block;width:20%">Branch:</label>
            <input type="text" class="form-control" id="txtBranchCode" style="width:15%" />
            <input type="button" class="btn btn-default" value="..." onclick="SearchData('branch');" />
            <input type="text" class="form-control" id="txtBranchName" style="width:65%" disabled />
        </div>
        <div class="col-sm-6" style="display:flex;flex-direction:row">
            <label style="display:block;width:20%">Customer:</label>
            <input type="text" class="form-control" id="txtCustCode" style="width:20%" />
            <input type="button" class="btn btn-default" value="..." onclick="SearchData('customer');" />
            <input type="text" class="form-control" id="txtCustName" style="width:60%" disabled />
        </div>
        <div class="col-sm-2" style="display:flex;flex-direction:row">
            <input type="button" class="btn btn-block" value="Show" id="btnShow" />
        </div>
    </div>
    <button class="btn btn-success" onclick="window.open('/clr/generateinv', '_blank');">Generate Invoice</button>
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
                        <th>Remark</th>
                        <th>Discount</th>
                        <th>Cust.Adv</th>
                        <th>Advance</th>
                        <th>Charge</th>
                        <th>VAT</th>
                        <th>WHT</th>
                        <th>Net</th>
                    </tr>
                </thead>
            </table>
        </div>
        <div class="tab-pane fade" id="tabDetail">
            Details Of Invoice No:<input type="text" id="txtInvNo" style="width:10%" disabled />
            <table id="tbDetail" class="table table-responsive">
                <thead>
                    <tr>
                        <th>ItemNo</th>
                        <th>SICode</th>
                        <th>SDescription</th>
                        <th>ExpSlipNo</th>
                        <th>AmtAdvance</th>
                        <th>AmtCharge</th>
                        <th>AmtVAT</th>
                        <th>Amt50Tavi</th>
                        <th>TotalAmt</th>
                        <th>AmtCredit</th>
                    </tr>
                </thead>
            </table>
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
                        <button id="btnUpdate" class="btn btn-primary" onclick="SaveData()">Update</button>
                        <button onclick="PrintData()" class="btn btn-default">Print</button>
                    </div>
                    <button id="btnHide" class="btn btn-danger" data-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>
    <div id="frmDetail" class="modal modal-lg fade">
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
    <div id="dvLOVs"></div>
</div>    
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    const path = '@Url.Content("~")';
    const user = '@ViewBag.User';
    const userRights = '@ViewBag.UserRights';
    let row = {};
    SetLOVs();
    $('#btnShow').on('click', function () {
        ShowHeader();
    });
    function ShowHeader() {
        $.get(path + 'acc/getinvforbill?show=ALL&cust=' + $('#txtCustCode').val() + '&branch=' + $('#txtBranchCode').val(), function (r)
        {
            if (r.invdetail.data.length == 0) {
                $('#tbHeader').DataTable().clear().draw();
                alert('data not found');
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
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page,
            });
            $('#tbHeader tbody').on('click', 'tr', function () {
                SetSelect('#tbHeader', this);
                row = $('#tbHeader').DataTable().row(this).data(); //read current row selected
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
                    alert('you are not allow to edit invoice');
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
                        { data: "AmtVat", title: "VAT" },
                        { data: "Amt50Tavi", title: "WHT" },
                        { data: "TotalAmt", title: "NET" }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
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
                    alert(response.result.data);
                    $('#frmHeader').modal('hide');
                    return;
                }
                alert(response.result.msg);
            },
            error: function (e) {
                alert(e);
            }
        });
    }
    function CancelData() {
        if (userRights.indexOf('D') > 0) {
            if ($('#txtCancelReson').val() == '') {
                alert('Please enter reason for cancel');
                $('#txtCancelReson').focus();
                return;
            }
            $('#txtCancelDate').val(GetToday());
            $('#txtCancelTime').val(ShowTime(GetTime()));
            $('#txtCancelProve').val(user);
        } else {
            alert('you are not allow to cancel invoice');
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
    function ReadBranch(dt) {
        $('#txtBranchCode').val(dt.Code);
        $('#txtBranchName').val(dt.BrName);
        $('#txtBranchCode').focus();
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
</script>


