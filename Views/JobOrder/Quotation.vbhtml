@Code
    ViewBag.Title = "Quotation"
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
                <label style="display:block;width:20%">Customer:</label>
                <input type="text" class="form-control" id="txtCustCode" style="width:20%" disabled />
                <input type="text" class="form-control" id="txtCustBranch" style="width:10%" disabled />
                <input type="button" class="btn btn-default" value="..." onclick="SearchData('customer');" />
                <input type="text" class="form-control" id="txtCustName" style="width:60%" disabled />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-2">
                Date From:<br />
                <input type="date" class="form-control" id="txtDocDateF" />
            </div>
            <div class="col-sm-2">
                Date To:<br />
                <input type="date" class="form-control" id="txtDocDateT" />
            </div>
            <div class="col-sm-3">
                <br />
                <input type="button" class="btn btn-primary" value="Show" id="btnShow" />
                <button class="btn btn-success" data-toggle="modal" data-target="#frmHeader">New Quotation</button>
            </div>
        </div>
        <input type="checkbox" id="chkCancel" />Show Cancel Only
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
                            <th>QNo</th>
                            <th>DocDate</th>
                            <th>CustCode</th>
                            <th>BillToCustCode</th>
                            <th>TRemark</th>
                            <th>ContactName</th>
                            <th>ManagerCode</th>
                            <th>ApproveDate</th>
                        </tr>
                    </thead>
                </table>
            </div>
            <div class="tab-pane fade" id="tabDetail">
                Details of Quotation No:<input type="text" id="txtDocNo" style="width:10%" disabled />
                <button id="btnAddDetail" class="btn btn-default" data-toggle="modal" data-target="#frmDetail">Add Detail</button>
                <table id="tbDetail" class="table table-responsive">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>SeqNo</th>
                            <th>JobType</th>
                            <th>ShipBy</th>
                            <th>Description</th>
                        </tr>
                    </thead>
                </table>
                Lists of Expenses:<button id="btnAddItem" class="btn btn-default" data-toggle="modal" data-target="#frmItem">Add Expense</button> <br />
                <table id="tbItem" class="table table-responsive" style="width:100%">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>ItemNo</th>
                            <th>SICode</th>
                            <th>Description</th>
                            <th>QtyBegin-QtyEnd/Unit</th>
                            <th>Total</th>
                            <th>Disc</th>
                            <th>Net</th>
                            <th>Commission</th>
                            <th>Profit</th>
                        </tr>
                    </thead>
                </table>
            </div>
        </div>
        <div id="frmHeader" class="modal fade">
            <div class="modal-dialog-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <div class="row">
                            <div class="col-sm-3">
                                Quotation No:<br /> <input type="text" id="txtQNo" class="form-control" disabled />
                            </div>
                            <div class="col-sm-3">
                                Issue Date:<br /> <input type="date" id="txtDocDate" class="form-control" />
                            </div>
                            <div class="col-sm-3">
                                Status :<input type="text" id="txtDocStatus" class="form-control" disabled />
                            </div>
                            <div class="col-sm-3">
                                Refer Q.No : <input type="text" id="txtReferQNo" class="form-control" />
                            </div>
                        </div>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-sm-6">
                                Billing To:<br />
                                <div style="display:flex">
                                    <input type="text" id="txtBCustCode" style="width:150px" disabled />
                                    <input type="text" id="txtBCustBranch" style="width:100px" disabled />
                                    <input type="button" class="btn btn-default" value="..." />
                                    <input type="text" id="txtBCustName" style="width:100%" disabled />
                                </div>
                            </div>
                            <div class="col-sm-6">
                                Manager <br />
                                <div style="display:flex">
                                    <input type="text" id="txtManagerCode" style="width:150px" disabled />
                                    <input type="button" class="btn btn-default" value="..." />
                                    <input type="text" id="txtManagerName" style="width:100%" disabled />
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-4">
                                Contact Name <input type="text" id="txtContactName" class="form-control" />
                            </div>
                            <div class="col-sm-8">
                                Remark <textarea id="txtTRemark" class="form-control"></textarea>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-6">
                                Header:<textarea id="txtDescriptionH" class="form-control"></textarea>
                            </div>
                            <div class="col-sm-6">
                                Footer:<textarea id="txtDescriptionF" class="form-control"></textarea>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-6">
                                <div style="display:flex">
                                    <div style="flex:1">
                                        Approve By <input type="text" id="txtApproveBy" style="width:100%" disabled />
                                    </div>
                                    <div style="flex:1">
                                        Approve Date<br /><input type="date" id="txtApproveDate" disabled /> &nbsp;
                                    </div>
                                    <div style="flex:1">
                                        Approve Time<br /><input type="date" id="txtApproveTime" disabled /> &nbsp;
                                    </div>
                                </div>
                                <input type="button" id="btnApprove" class="btn btn-primary" onclick="ApproveData()" value="Approve" />
                            </div>
                            <div class="col-sm-3" style="display:flex">
                                <div style="flex:1">
                                    Cancel By<br />
                                    <input type="text" id="txtCancelBy" style="width:100%" disabled />
                                </div>
                                <div style="flex:1">
                                    Cancel Date<br />
                                    <input type="date" id="txtCancelDate" disabled /> &nbsp;
                                </div>
                            </div>
                            <div class="col-sm-3">
                                Reason<br />
                                <textarea id="txtCancelReason" style="width:100%"></textarea>
                                <input type="button" id="btnCancel" class="btn btn-danger" onclick="CancelData()" value="Cancel" />
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
        <div id="frmDetail" class="modal">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        Sequence No <input type="text" id="txtSeqNo" disabled />
                    </div>
                    <div class="modal-body">
                        <div style="display:flex">
                            <div style="flex:1">
                                Job Type :<br /><select id="txtJobType" class="form-control dropdown" value="0"></select>
                            </div>
                            <div style="flex:1">
                                Ship By :<br /><select id="txtShipBy" class="form-control dropdown" value="0"></select>
                            </div>
                        </div>
                        Description<br/>
                        <textarea id="txtDescription" style="width:100%"></textarea>
                    </div>
                    <div class="modal-footer">
                        <button id="btnHide" class="btn btn-danger" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>
        <div id="frmItem" class="modal">
            <div class="modal-dialog-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        Item No <input type="text" id="txtItemNo" disabled />
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-sm-12">
                                Code <input type="text" id="txtSICode" style="width:20%" disabled />
                                <input type="text" id="txtSDescription" style="width:60%" />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                Currency <input type="text" id="txtCurrencyCode" style="width:10%" disabled />
                                <input type="button" id="btnCurr" value="..." onclick="SearchData('dcurrency')" />
                                <input type="text" id="txtCurrencyName" style="width:40%" disabled />
                                Exc.Rate <input type="text" id="txtCurrencyRate" style="width:15%" onchange="CalForeignDetail()" />
                            </div>
                        </div>
                        <p>
                            <div class="row">
                                <div class="col-sm-6">
                                    Remark <textarea id="txtDescriptionThai" style="width:100%"></textarea>
                                </div>
                                <div class="col-sm-3" style="display:flex;flex-direction:row">
                                    <div style="flex-direction:column;flex:1">
                                        Qty Start <input type="text" id="txtQtyBegin" />
                                    </div>
                                    <div style="flex-direction:column;flex:1">
                                        Qty End <input type="text" id="txtQtyEnd" />
                                    </div>
                                </div>
                                <div class="col-sm-3" style="display:flex;flex-direction:row">
                                    <div style="flex-direction:column;flex:1">
                                        Unit <input type="text" id="txtUnitCheck" />
                                    </div>
                                    <div style="flex-direction:column;flex:1">
                                        Price <input type="text" id="txtChargeAmt" disabled />
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-6">
                                    <div style="display:flex">
                                        <div style="flex:1">
                                            Discount Type
                                            <select id="txtDiscountType" onchange="ShowDiscount()">
                                                <option value="0" selected>Percent</option>
                                                <option value="1">Cash</option>
                                            </select>
                                        </div>
                                        <div style="flex:1">
                                            Discount Rate
                                            <input type="text" id="txtUnitDiscntPerc" style="width:50%" onchange="CalDiscountDetail()" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-sm-6">
                                    <div style="display:flex">
                                        <div style="flex:1">
                                            Discount (B)<input type="text" id="txtUnitDiscntAmt" />
                                        </div>
                                        <div style="flex:1">
                                            Discount (F)<input type="text" id="txtFUnitDiscntAmt" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-6" style="display:flex;flex-direction:column">
                                    <div style="display:flex">
                                        <div style="flex:1">
                                            Vender <input type="text" id="txtVenderCode" style="width:150px" disabled />
                                            <input type="button" id="btnBrow" value="..." onclick="SearchData('vender')" />
                                            <input type="text" id="txtVenderName" style="width:100%" disabled />
                                            Cost Amount <input type="text" id="txtVenderCost" />
                                        </div>
                                    </div>
                                    <br/>
                                    <div style="display:flex">
                                        <div style="flex:1">
                                            Commission Type
                                            <select id="txtCommissionType">
                                                <option value="0" selected>Percent</option>
                                                <option value="1">Fixed</option>
                                            </select>
                                            <input type="text" id="txtCommissionPerc" style="width:20%" />
                                            Commission Amount <input type="text" id="txtCommissionAmt" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-sm-6" style="display:flex;flex-direction:column">
                                    <div style="display:flex">
                                        <div style="flex:1">
                                            VAT

                                            <select id="txtIsvat">
                                                <option value="0">NO</option>
                                                <option value="1">EX</option>
                                                <option value="2">IN</option>
                                            </select>

                                            Rate

                                            <input type="text" id="txtVatRate" />
                                            <br />
                                            VAT Amt
                                            <input type="text" id="txtVatAmt" />

                                        </div>
                                        <div style="flex:1">
                                            WHT
                                            <select id="txtIsTax">
                                                <option value="0">NO</option>
                                                <option value="1">YES</option>
                                            </select>
                                            Rate
                                            <input type="text" id="txtTaxRate" />
                                            <br />
                                            WHT Amt
                                            <input type="text" id="txtTaxAmt" />
                                        </div>
                                    </div>
                                    <div style="display:flex;flex-direction:row">
                                        <div style="flex:1">
                                            <b>Charge</b><br />
                                            <input type="text" id="txtTotalCharge" disabled style="font:bold" />
                                        </div>
                                        <div style="flex:1">
                                            <b>Total</b><br />
                                            <input type="text" id="txtTotalAmt" disabled style="font:bold" />
                                        </div>
                                    </div>
                                    <div style="display:flex;flex-direction:row">
                                        <div style="flex:1">
                                            Base Profit<br /><input type="text" id="txtBaseProfit" disabled />
                                        </div>
                                        <div style="flex:1">
                                            Net Profit<br /><input type="text" id="txtNetProfit" disabled />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </p>
                    </div>
                    <div class="modal-footer">
                        <button id="btnHide" class="btn btn-danger" data-dismiss="modal">Close</button>
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
        $.get(path + 'acc/getbillheader?branch=' + $('#txtBranchCode').val() + w, function (r) {
            if (r.billheader.data.length == 0) {
                $('#tbHeader').DataTable().clear().draw();
                if (isAlert==true) alert('data not found');
                return;
            }
            let h = r.billheader.data;
            row = {};
            row_d = {};
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
                    { data: "BillAcceptNo", title: "Bill No" },
                    {
                        data: "BillDate", title: "Doc date ",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "CustCode", title: "Customer" },
                    { data: "BillRemark", title: "Remark" },
                    {
                        data: "BillRecvDate", title: "Confirm date ",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    {
                        data: "DuePaymentDate", title: "Due date ",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "TotalAdvance", title: "Advance" },
                    { data: "TotalChargeVAT", title: "Charge" },
                    { data: "TotalVAT", title: "VAT" },
                    { data: "TotalWH", title: "WHT" },
                    { data: "TotalNet", title: "NET" }
                ],
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            });
            $('#tbHeader tbody').on('click', 'tr', function () {
                row = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                SetSelect('#tbHeader', this);
                row_d = {};
                ReadData();
                ShowDetail(row.BranchCode, row.BillAcceptNo);
            });
            $('#tbHeader tbody').on('dblclick', 'tr', function () {
                $('a[href="#tabDetail"]').click();
            });
            $('#tbHeader tbody').on('click', 'button', function () {
                if (userRights.indexOf('E') > 0) {
                    $('#frmHeader').modal('show');
                } else {
                    alert('you are not allow to edit billing document');
                }
            });
        });
    }
    function PrintData() {
        let code = row.BillAcceptNo;
        if (code !== '') {

            let branch = row.BranchCode;
            window.open(path + 'Acc/FormBill?Branch=' + branch + '&Code=' + code, '_blank');
        }
    }
    function ReadData() {
        $('#txtDocNo').val(row.BillAcceptNo);
        $('#txtBillAcceptNo').val(row.BillAcceptNo);
        $('#txtBillDate').val(CDateEN(row.BillDate));
        $('#txtBCustCode').val(row.CustCode);
        $('#txtBCustBranch').val(row.CustBranch);
        ShowCustomer(path, row.CustCode, row.CustBranch, '#txtBCustName');
        $('#txtBillRecvBy').val(row.BillRecvBy);
        $('#txtBillRecvDate').val(CDateEN(row.BillRecvDate));
        $('#txtDuePaymentDate').val(CDateEN(row.DuePaymentDate));
        $('#txtBillRemark').val(row.BillRemark);
        $('#txtCancelReson').val(row.CancelReson);
        $('#txtCancelProve').val(row.CancelProve);
        $('#txtCancelDate').val(CDateEN(row.CancelDate));
        $('#txtCancelTime').val(ShowTime(row.CancelTime));
        $('#lblEmpCode').text(row.EmpCode);
        $('#lblRecDateTime').text(ShowDate(row.RecDateTime));
        $('#txtTotalAdvance').val(CDbl(row.TotalAdvance, 2));
        $('#txtTotalCustAdv').val(CDbl(row.TotalCustAdv, 2));
        $('#txtTotalChargeVAT').val(CDbl(row.TotalChargeVAT, 2));
        $('#txtTotalChargeNonVAT').val(CDbl(row.TotalChargeNonVAT, 2));
        $('#txtTotalVAT').val(CDbl(row.TotalVAT, 2));
        $('#txtTotalWH').val(CDbl(row.TotalWH, 2));
        $('#txtTotalDiscount').val(CDbl(row.TotalDiscount, 2));
        $('#txtTotalNet').val(CDbl(row.TotalNet, 2));
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
            alert('you are not allow to cancel billing Document');
        }
    }
    function SaveData() {
        if (row !== null) {
            row.BillRemark = $('#txtBillRemark').val();
            row.BillRecvBy = $('#txtBillRecvBy').val();
            row.BillRecvDate = CDateTH($('#txtBillRecvDate').val());
            row.DuePaymentDate = CDateTH($('#txtDuePaymentDate').val());
            row.CancelDate = CDateTH($('#txtCancelDate').val());
            row.CancelTime = $('#txtCancelTime').val();
            row.CancelProve = $('#txtCancelProve').val();
            row.CancelReson = $('#txtCancelReson').val();
            row.EmpCode = user;
            row.RecDateTime = CDateTH(GetToday());

            let jsonString = JSON.stringify({ data: row });
            $.ajax({
                url: "@Url.Action("SetBillHeader", "Acc")",
                type: "POST",
                contentType: "application/json",
                data: jsonString,
                success: function (response) {
                    if (response.result.data !== null) {

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
    }
    function ShowDetail(branch, code) {
        $.get(path + 'Acc/GetBillDetail?Branch=' + branch + '&Code=' + code, function (r) {
            if (r.billdetail.data.length > 0) {
                let d = r.billdetail.data;
                $('#tbDetail').DataTable({
                    data: d,
                    selected: true,
                    columns: [
                        { data: "InvNo", title: "Inv.No" },
                        {
                            data: null, title: "Inv.Date",
                            render: function (data) {
                                return CDateTH(data.InvDate);
                            }
                        },
                        { data: "AmtCustAdvance", title: "Cust.Adv" },
                        { data: "AmtAdvance", title: "Advance" },
                        { data: "AmtChargeNonVAT", title: "Service" },
                        { data: "AmtChargeVAT", title: "Service (VAT)" },
                        { data: "AmtDiscount", title: "Discount" },
                        { data: "AmtWH", title: "WH-Tax" },
                        { data: "AmtVAT", title: "VAT" },
                        { data: "AmtTotal", title: "Total" }
                    ],
                    destroy:true
                });
                $('#tbDetail tbody').on('click', 'tr', function () {
                    SetSelect('#tbDetail', this);
                    row_d = $('#tbDetail').DataTable().row(this).data();
                });
            }
        });
    }
    function DeleteDetail() {
        if (row_d.ItemNo !== undefined) {
            if (confirm("Are you sure to delete inv " + row_d.InvNo + ' from ' + row_d.BillAcceptNo) == true) {
                $.get(path+ 'Acc/DelBillDetail?Branch=' + row.BranchCode + '&Code=' + row.BillAcceptNo + '&Item=' + row_d.ItemNo)
                    .done(function (r) {
                        if (r.billdetail.data !== null) {
                            ShowDetail(row.BranchCode, row.BillAcceptNo);
                        }
                        alert(r.billdetail.result);
                    });
            }
        } else {
            alert('no data to delete');
        }

    }
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
</script>

