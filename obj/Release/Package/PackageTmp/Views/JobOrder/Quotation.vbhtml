﻿@Code
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
                <input type="button" class="btn btn-primary" value="Show" onclick="ShowHeader()" id="btnShow" />
                <button class="btn btn-success" onclick="AddHeader()">New Quotation</button>
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
                <p>
                    Details of Quotation No:<input type="text" id="txtDocNo" style="width:10%" disabled />
                    <button id="btnAddDetail" class="btn btn-success" onclick="AddDetail()">Add Section</button>
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
                    <input type="button" id="btnDelDetail" class="btn btn-danger" onclick="DeleteDetail()" value="Delete Section" />
                </p>
                <p>
                    Lists of Item <input type="text" id="txtDocItemNo" style="width:10%" disabled /> Expenses:<button id="btnAddItem" class="btn btn-success" onclick="AddItem()">Add Expense</button> <br />
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
                    <input type="button" id="btnDelItem" class="btn btn-danger" onclick="DeleteItem()" value="Delete Expense" />
                </p>
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
                                Status :<br/>
                                        <select id="txtDocStatus" class="form-control dropdown" disabled>
                                            <option value="0">REQUEST</option>
                                            <option value="1">APPROVE</option>
                                            <option value="99">CANCEL</option>
                                        </select>
                            </div>
                            <div class="col-sm-3">
                                Refer Q.No : <br/>
                                <input type="text" id="txtReferQNo" class="form-control" />
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
                                    <input type="button" class="btn btn-default" value="..." onclick="SearchData('billing')" />
                                    <input type="text" id="txtBCustName" style="width:100%" disabled />
                                </div>
                            </div>
                            <div class="col-sm-6">
                                Manager <br />
                                <div style="display:flex">
                                    <input type="text" id="txtManagerCode" style="width:150px" disabled />
                                    <input type="button" class="btn btn-default" value="..." onclick="SearchData('sales')" />
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
                                        Approve Time<br /><input type="text" id="txtApproveTime" disabled /> &nbsp;
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
                        <div style="float:left">
                            <button id="btnUpdateD" class="btn btn-primary" onclick="SaveDetail()">Update</button>
                        </div>
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
                        Calculate Type
                        <select id="txtCalculateType">
                            <option value="0">Last Price</option>
                            <option value="1">Accumulate Price</option>
                        </select>
                        Required?
                        <select id="txtIsRequired">
                            <option value="0">No</option>
                            <option value="1">Yes</option>
                        </select>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-sm-12">
                                Service Code <input type="text" id="txtSICode" style="width:20%" disabled />
                                <input type="button" id="btnServ" value="..." onclick="SearchData('service')" />
                                <input type="text" id="txtSDescription" style="width:60%" disabled />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-12">
                                Currency <input type="text" id="txtCurrencyCode" style="width:10%" disabled />
                                <input type="button" id="btnCurr" value="..." onclick="SearchData('currency')" />
                                <input type="text" id="txtCurrencyName" style="width:40%" disabled />
                                Exc.Rate <input type="text" id="txtCurrencyRate" style="width:15%" onchange="CalAmount()" />
                            </div>
                        </div>
                        <p>
                            <div class="row">
                                <div class="col-sm-6">
                                    Service Description <textarea id="txtDescriptionThai" style="width:100%"></textarea>
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
                                        Price <input type="text" id="txtChargeAmt" onchange="CalAmount()" />
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
                                            <input type="text" id="txtUnitDiscntPerc" style="width:50%" onchange="CalDiscount()" />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-sm-6">
                                    <div style="display:flex">
                                        <div style="flex:1">
                                            Discount (B)<input type="text" id="txtUnitDiscntAmt" onchange="CalDiscount()" disabled />
                                        </div>
                                        <div style="flex:1">
                                            Discount (F)<input type="text" id="txtFUnitDiscntAmt" disabled />
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
                                            Cost Amount <input type="text" id="txtVenderCost" onchange="CalProfit()" />
                                        </div>
                                    </div>
                                    <br/>
                                    <div style="display:flex">
                                        <div style="flex:1">
                                            Commission Type
                                            <select id="txtCommissionType" onchange="ShowCommission()">
                                                <option value="0" selected>Percent</option>
                                                <option value="1">Fixed</option>
                                            </select>
                                            <input type="text" id="txtCommissionPerc" style="width:20%" onchange="CalCommission()" />
                                            Commission Amount <input type="text" id="txtCommissionAmt" onchange="CalProfit()" disabled />
                                        </div>
                                    </div>
                                </div>
                                <div class="col-sm-6" style="display:flex;flex-direction:column">
                                    <div style="display:flex">
                                        <div style="flex:1">
                                            VAT

                                            <select id="txtIsvat" onchange="CalVATWHT()">
                                                <option value="0">NO</option>
                                                <option value="1">EX</option>
                                                <option value="2">IN</option>
                                            </select>

                                            Rate

                                            <input type="text" id="txtVatRate" onchange="CalVATWHT()" />
                                            <br />
                                            VAT Amt
                                            <input type="text" id="txtVatAmt" onchange="CalCommission()" />

                                        </div>
                                        <div style="flex:1">
                                            WHT
                                            <select id="txtIsTax" onchange="CalVATWHT()">
                                                <option value="0">NO</option>
                                                <option value="1">YES</option>
                                            </select>
                                            Rate
                                            <input type="text" id="txtTaxRate" onchange="CalVATWHT()" />
                                            <br />
                                            WHT Amt
                                            <input type="text" id="txtTaxAmt" onchange="CalCommission()" />
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
                        <div style="float:left">
                            <button id="btnUpdateI" class="btn btn-primary" onclick="SaveItem()">Update</button>
                        </div>
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
    let row_i = {};
    let chkmode = '';

    SetLOVs();

    function ShowHeader() {
        let w = '&cust=' + $('#txtCustCode').val();
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
        $('#tbHeader').DataTable().clear().draw();
        $('#tbDetail').DataTable().clear().draw();
        $('#tbItem').DataTable().clear().draw();
        ClearHeader();
        ClearDetail();
        ClearItem();
        $.get(path + 'joborder/getquotation?branch=' + $('#txtBranchCode').val() + w, function (r) {
            if (r.quotation.header.length == 0) {                
                alert('data not found');
                return;
            }
            let h = r.quotation.header;
            row = {};
            row_d = {};
            row_i = {};
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
                    { data: "QNo", title: "Quotation No" },
                    {
                        data: "DocDate", title: "Doc date ",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "CustCode", title: "Customer" },
                    { data: "BillToCustCode", title: "Billing To" },
                    { data: "TRemark", title: "Remark" },
                    { data: "ContactName", title: "Contact Name" },
                    { data: "ManagerCode", title: "Manager Code" },
                    {
                        data: "ApproveDate", title: "Appv.date ",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    }                    
                ],
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            });
            $('#tbHeader tbody').on('click', 'tr', function () {
                SetSelect('#tbHeader', this);
                ClearHeader();
                row = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                ReadData();
                ShowDetail(row.BranchCode, row.QNo);
            });
            $('#tbHeader tbody').on('dblclick', 'tr', function () {
                $('a[href="#tabDetail"]').click();
            });
            $('#tbHeader tbody').on('click', 'button', function () {
                if (userRights.indexOf('E') > 0) {
                    $('#frmHeader').modal('show');
                } else {
                    alert('you are not allow to edit quotation');
                }
            });
        });
    }
    function ShowItem(branch, code, seq) {
        $('#tbItem').DataTable().clear().draw();
        row_i = {};
        $.get(path + 'JobOrder/GetQuoItem?Branch=' + branch + '&Code=' + code + '&Seq=' + seq, function (r) {
            if (r.quotation.items.length > 0) {
                let d = r.quotation.items;
                $('#tbItem').DataTable({
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
                        { data: "ItemNo", title: "Seq" },
                        { data: "SICode", title: "Code" },
                        { data: "DescriptionThai", title: "Description" },
                        {
                            data: null, title: "Qty",
                            render: function (data) {
                                return data.QtyBegin + '-' + data.QtyEnd + '/' + data.UnitCheck;
                            }
                        },
                        { data: "TotalAmt", title: "Total" },
                        { data: "UnitDiscntAmt", title: "Discount" },
                        { data: "TotalCharge", title: "Net" },
                        { data: "CommissionAmt", title: "Commission" },
                        { data: "NetProfit", title: "Profit" }
                    ],
                    destroy:true
                });
                $('#tbItem tbody').on('click', 'tr', function () {
                    SetSelect('#tbItem', this);
                    row_i = $('#tbItem').DataTable().row(this).data();
                    ReadItem();
                });
                $('#tbItem tbody').on('click', 'button', function () {
                    if (userRights.indexOf('E') > 0) {
                        $('#frmItem').modal('show');
                    } else {
                        alert('you are not allow to edit quotation');
                    }
                });
            }
        });
    }
    function ShowDetail(branch, code) {
        $('#tbDetail').DataTable().clear().draw();
        row_d = {};
        row_i = {};
        $.get(path + 'JobOrder/GetQuotation?Branch=' + branch + '&Code=' + code, function (r) {
            if (r.quotation.detail.length > 0) {
                let d = r.quotation.detail;
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
                        { data: "SeqNo", title: "Seq" },
                        { data: "JobTypeName", title: "Job Type" },
                        { data: "ShipByName", title: "Ship By" },
                        { data: "Description", title: "Description" }
                    ],
                    destroy:true
                });
                $('#tbDetail tbody').on('click', 'tr', function () {
                    SetSelect('#tbDetail', this);
                    row_d = $('#tbDetail').DataTable().row(this).data();
                    ShowItem(row_d.BranchCode, row_d.QNo, row_d.SeqNo);
                    ReadDetail();
                });
                $('#tbDetail tbody').on('click', 'button', function () {
                    if (userRights.indexOf('E') > 0) {
                        $('#frmDetail').modal('show');
                    } else {
                        alert('you are not allow to edit quotation');
                    }
                });
            }
        });
    }
    function PrintData() {
        let code = row.QNo;
        if (code !== '') {
            let branch = row.BranchCode;
            window.open(path + 'JobOrder/FormQuotation?Branch=' + branch + '&docno=' + code, '_blank');
        }
    }
    function CancelData() {
        if (userRights.indexOf('D') > 0) {
            if ($('#txtCancelReason').val() == '') {
                alert('Please enter reason for cancel');
                $('#txtCancelReason').focus();
                return;
            }
            $('#txtCancelDate').val(GetToday());
            $('#txtCancelBy').val(user);
            $('#txtDocStatus').val('99');
        } else {
            alert('you are not allow to cancel Quotation');
        }
    }
    function ApproveData() {
        chkmode = $('#txtApproveBy').val() == '' ? 'I' : 'D';
        CallBackAuthorize(path, 'MODULE_SALES', 'QuoApprove',chkmode, SetApprove);
    }
    function SetApprove(b) {
        if (b == true) {
            $('#txtApproveBy').val(chkmode == 'I' ? user : '');
            $('#txtApproveDate').val(chkmode == 'I' ? GetToday() : '');
            $('#txtApproveTime').val(chkmode == 'I' ? ShowTime(GetTime()) : '');
            if (row.DocStatus !== '99') $('#txtDocStatus').val(chkmode == 'I' ? '1' : '0');
        } else {
            alert('you are not allow to approve quotation');
        }
    }
    function SaveData() {
        if ($('#txtBCustCode').val() == '') {
            alert('please enter billing place');
            return;
        }
        if ($('#txtManagerCode').val() == '') {
            alert('please enter manager code');
            return;
        }
        row.BranchCode = $('#txtBranchCode').val();
        row.QNo = $('#txtQNo').val();
        row.ReferQNo = $('#txtReferQNo').val();
        row.CustCode = $('#txtCustCode').val();
        row.CustBranch = $('#txtCustBranch').val();
        row.BillToCustCode = $('#txtBCustCode').val();
        row.BillToCustBranch = $('#txtBCustBranch').val();
        row.ContactName = $('#txtContactName').val();
        row.DocDate = CDateTH($('#txtDocDate').val());
        row.ManagerCode = $('#txtManagerCode').val();
        row.DescriptionH = $('#txtDescriptionH').val();
        row.DescriptionF = $('#txtDescriptionF').val();
        row.TRemark = $('#txtTRemark').val();
        row.DocStatus = $('#txtDocStatus').val();
        row.ApproveBy = $('#txtApproveBy').val();
        row.ApproveDate = CDateTH($('#txtApproveDate').val());
        row.ApproveTime = $('#txtApproveTime').val();
        row.CancelBy = $('#txtCancelBy').val();
        row.CancelDate = CDateTH($('#txtCancelDate').val());
        row.CancelReason = $('#txtCancelReason').val();

        let jsonString = JSON.stringify({ data: row });
        $.ajax({
            url: "@Url.Action("SetQuoHeader", "JobOrder")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                if (response.result.data !== null) {
                    $('#txtDocNo').val(response.result.data);
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
    function SaveDetail() {
        row_d.BranchCode = $('#txtBranchCode').val();
        row_d.QNo = $('#txtDocNo').val();
        row_d.SeqNo = $('#txtSeqNo').val();
        row_d.JobType = $('#txtJobType').val();
        row_d.ShipBy = $('#txtShipBy').val();
        row_d.Description = $('#txtDescription').val();
        row_d.JobTypeName = null;
        row_d.ShipByName = null;

        let jsonString = JSON.stringify({ data: row_d });
        $.ajax({
            url: "@Url.Action("SetQuoDetail", "JobOrder")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                if (response.result.data !== null) {
                    ShowDetail(row.BranchCode, row.QNo);
                    alert(response.result.data);
                    $('#frmDetail').modal('hide');
                    return;
                }
                alert(response.result.msg);
            },
            error: function (e) {
                alert(e);
            }
        });
    }
    function SaveItem() {
        row_i.BranchCode = $('#txtBranchCode').val();
        row_i.QNo = $('#txtDocNo').val();
        row_i.SeqNo = $('#txtDocItemNo').val();
        row_i.ItemNo = $('#txtItemNo').val();
        row_i.SICode = $('#txtSICode').val();
        row_i.DescriptionThai = $('#txtDescriptionThai').val();
        row_i.CalculateType = $('#txtCalculateType').val();
        row_i.QtyBegin = $('#txtQtyBegin').val();
        row_i.QtyEnd = $('#txtQtyEnd').val();
        row_i.UnitCheck = $('#txtUnitCheck').val();
        row_i.CurrencyCode = $('#txtCurrencyCode').val();
        row_i.CurrencyRate = $('#txtCurrencyRate').val();
        row_i.ChargeAmt = $('#txtChargeAmt').val();
        row_i.Isvat = $('#txtIsvat').val();
        row_i.VatRate = $('#txtVatRate').val();
        row_i.VatAmt = $('#txtVatAmt').val();
        row_i.IsTax = $('#txtIsTax').val();
        row_i.TaxRate = $('#txtTaxRate').val();
        row_i.TaxAmt = $('#txtTaxAmt').val();
        row_i.TotalAmt = $('#txtTotalAmt').val();
        row_i.TotalCharge = $('#txtTotalCharge').val();
        row_i.UnitDiscntPerc = $('#txtUnitDiscntPerc').val();
        row_i.UnitDiscntAmt = $('#txtUnitDiscntAmt').val();
        row_i.VenderCode = $('#txtVenderCode').val();
        row_i.VenderCost = $('#txtVenderCost').val();
        row_i.BaseProfit = $('#txtBaseProfit').val();
        row_i.CommissionPerc = $('#txtCommissionPerc').val();
        row_i.CommissionAmt = $('#txtCommissionAmt').val();
        row_i.NetProfit = $('#txtNetProfit').val();
        row_i.IsRequired = $('#txtIsRequired').val();

        let jsonString = JSON.stringify({ data: row_i });
        $.ajax({
            url: "@Url.Action("SetQuoItem", "JobOrder")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                if (response.result.data !== null) {
                    ShowItem($('#txtBranchCode').val(), $('#txtDocNo').val(), $('#txtDocItemNo').val());
                    alert(response.result.data);
                    $('#frmItem').modal('hide');
                    return;
                }
                alert(response.result.msg);
            },
            error: function (e) {
                alert(e);
            }
        });
    }
    function DeleteDetail() {
        if (userRights.indexOf('D') < 0) {
            alert('you are not allow to delete section');
            return;
        }
        if (row_d.SeqNo !== undefined) {
            if (confirm("Are you sure to delete seq " + row_d.SeqNo + ' from ' + row_d.QNo) == true) {
                $.get(path+ 'JobOrder/DelQuoDetail?Branch=' + row_d.BranchCode + '&Code=' + row_d.QNo + '&Seq=' + row_d.SeqNo)
                    .done(function (r) {
                        if (r.quodetail.data !== null) {
                            ShowDetail(row.BranchCode, row.QNo);
                            row_d = {};
                            row_i = {};
                            $('#tbItem').DataTable().clear().draw();
                        }
                        alert(r.quodetail.result);
                    });
            }
        } else {
            alert('no selected section to delete');
        }
    }
    function DeleteItem() {
        if (userRights.indexOf('D') < 0) {
            alert('you are not allow to delete item');
            return;
        }
        if (row_i.ItemNo !== undefined) {
            if (confirm("Are you sure to delete item " + row_i.ItemNo + ' from section #' + row_i.SeqNo) == true) {
                $.get(path+ 'JobOrder/DelQuoItem?Branch=' + row_i.BranchCode + '&Code=' + row_i.QNo + '&Seq=' + row_i.SeqNo + '&Item=' + row_i.ItemNo)
                    .done(function (r) {
                        if (r.quoitem.data !== null) {
                            ShowItem(row_d.BranchCode, row_d.QNo, row_d.SeqNo);
                            row_i = {};
                        }
                        alert(r.quoitem.result);
                    });
            }
        } else {
            alert('no selected item to delete');
        }
    }
    function AddHeader() {
        if (userRights.indexOf('I') < 0) {
            alert('you are not allow to add quotation');
            return;
        }
        if ($('#txtBranchCode').val() == '') {
            alert('please enter branch');
            return;
        }
        if ($('#txtCustCode').val() == '') {
            alert('please enter customer');
            return;
        }
        ClearHeader();
        $('#frmHeader').modal('show');
    }
    function ClearHeader() {
        row_d = {};
        row_i = {};
        $('#txtQNo').val('');
        $('#txtDocNo').val('');
        $('#txtDocItemNo').val('');
        $('#txtReferQNo').val('');
        $('#txtDocDate').val(GetToday());
        $('#txtBCustCode').val('');
        $('#txtBCustBranch').val('');
        $('#txtBCustName').val('');
        $('#txtContactName').val('');
        $('#txtApproveDate').val('');
        $('#txtApproveTime').val('');
        $('#txtApproveBy').val('');
        $('#txtTRemark').val('');
        $('#txtDocStatus').val('0');
        $('#txtCancelReason').val('');
        $('#txtCancelBy').val('');
        $('#txtCancelDate').val('');        
        $('#txtManagerCode').val('');
        $('#txtManagerName').val('');
        $('#txtDescriptionH').val('');
        $('#txtDescriptionF').val('');
    }
    function ClearDetail() {
        $('#txtSeqNo').val('0');
        $('#txtJobType').val('');
        $('#txtShipBy').val('');
        $('#txtDescription').val('');
    }
    function ClearItem() {
        $('#txtItemNo').val('0');
        $('#txtSICode').val('');
        $('#txtSDescription').val('');
        $('#txtDescriptionThai').val('');
        $('#txtCalculateType').val('0');
        $('#txtQtyBegin').val(1);
        $('#txtQtyEnd').val(1);
        $('#txtUnitCheck').val('');
        $('#txtCurrencyCode').val('@ViewBag.PROFILE_CURRENCY');
        $('#txtCurrencyName').val('THAI BAHT');
        $('#txtCurrencyRate').val(1);
        $('#txtChargeAmt').val(0);
        $('#txtIsvat').val('0');
        $('#txtVatRate').val('0');
        $('#txtVatAmt').val('0');
        $('#txtIsTax').val('0');
        $('#txtTaxRate').val('0');
        $('#txtTaxAmt').val('0');
        $('#txtTotalAmt').val('0');
        $('#txtTotalCharge').val('0');
        $('#txtDiscountType').val('0');
        ShowDiscount();
        $('#txtUnitDiscntPerc').val('0');
        $('#txtUnitDiscntAmt').val('0');
        $('#txtFUnitDiscntAmt').val('0');
        $('#txtVenderCode').val('');
        $('#txtVenderName').val('');
        $('#txtVenderCost').val('0');
        $('#txtBaseProfit').val('0');
        $('#txtCommissionType').val('0');
        ShowCommission();
        $('#txtCommissionPerc').val('0');
        $('#txtCommissionAmt').val('0');
        $('#txtNetProfit').val('0');
        $('#txtIsRequired').val('1');
    }
    function AddDetail() {
        if (userRights.indexOf('I') < 0) {
            alert('you are not allow to add section');
            return;
        }
        if ($('#txtDocNo').val() == '') {
            alert('please select quotation first');
            return;
        }
        row_d = {};
        ClearDetail();
        $('#frmDetail').modal('show');
    }
    function AddItem() {
        if (userRights.indexOf('I') < 0) {
            alert('you are not allow to add item');
            return;
        }
        if ($('#txtDocItemNo').val() == '') {
            alert('please select some from section above first');
            return;
        }
        row_i = {};
        ClearItem();
        $('#frmItem').modal('show');
    }
    function SetLOVs() {
        $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
        $('#txtBranchName').val('@ViewBag.PROFILE_DEFAULT_BRANCH_NAME');

        let lists = 'JOB_TYPE=#txtJobType|,SHIP_BY=#txtShipBy|';
        loadCombos(path, lists);

        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv, '#frmSearchCust', '#tbCust', 'Customers', response, 3);
            CreateLOV(dv, '#frmSearchBill', '#tbBill', 'Billing Place', response, 3);
            //currency
            CreateLOV(dv, '#frmSearchCurr', '#tbCurr', 'Currency', response, 2);
            //Vender
            CreateLOV(dv, '#frmSearchVend', '#tbVend', 'Venders', response, 2);
            //users
            CreateLOV(dv, '#frmSearchUser', '#tbUser', 'Users', response, 2);
            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response, 2);
            //Service 
            CreateLOV(dv, '#frmSearchServ', '#tbServ', 'Service Code', response,2);
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
            case 'vender':
                SetGridVender(path, '#tbVend', '#frmSearchVend', ReadVender);
                break;
            case 'sales':
                SetGridUser(path, '#tbUser', '#frmSearchUser', ReadManager);
                break;
            case 'service':
                SetGridSICode(path, '#tbServ','', '#frmSearchServ', ReadService);
                break;
        }
    }
    function ReadData() {
        $('#txtQNo').val(row.QNo);
        $('#txtDocNo').val(row.QNo);
        $('#txtReferQNo').val(row.ReferQNo);
        $('#txtDocDate').val(CDateEN(row.DocDate));
        $('#txtBCustCode').val(row.BillToCustCode);
        $('#txtBCustBranch').val(row.BillToCustBranch);
        ShowCustomer(path, row.BillToCustCode, row.BillToCustBranch, '#txtBCustName');
        $('#txtContactName').val(row.ContactName);
        $('#txtApproveDate').val(CDateEN(row.ApproveDate));
        $('#txtApproveTime').val(ShowTime(row.ApproveTime));
        $('#txtApproveBy').val(row.ApproveBy);
        $('#txtTRemark').val(row.TRemark);
        $('#txtDocStatus').val(row.DocStatus);
        $('#txtCancelReason').val(row.CancelReason);
        $('#txtCancelBy').val(row.CancelBy);
        $('#txtCancelDate').val(CDateEN(row.CancelDate));        
        $('#txtManagerCode').val(row.ManagerCode);
        ShowUser(path, row.ManagerCode, '#txtManagerName');
        $('#txtDescriptionH').val(row.DescriptionH);
        $('#txtDescriptionF').val(row.DescriptionF);
    }
    function ReadDetail() {
        $('#txtDocItemNo').val(row_d.SeqNo);
        $('#txtSeqNo').val(row_d.SeqNo);
        $('#txtJobType').val(CCode(row_d.JobType));
        $('#txtShipBy').val(CCode(row_d.ShipBy));
        $('#txtDescription').val(row_d.Description);
    }
    function ReadItem() {
        $('#txtItemNo').val(row_i.ItemNo);
        $('#txtSICode').val(row_i.SICode);
        ShowServiceCode(path, row_i.SICode, '#txtSDescription');
        $('#txtDescriptionThai').val(row_i.DescriptionThai);
        $('#txtCalculateType').val(row_i.CalculateType);
        $('#txtQtyBegin').val(row_i.QtyBegin);
        $('#txtQtyEnd').val(row_i.QtyEnd);
        $('#txtUnitCheck').val(row_i.UnitCheck);
        $('#txtCurrencyCode').val(row_i.CurrencyCode);
        ShowCurrency(path, row_i.CurrencyCode, '#txtCurrencyName');
        $('#txtCurrencyRate').val(row_i.CurrencyRate);
        $('#txtChargeAmt').val(row_i.ChargeAmt);
        $('#txtIsvat').val(row_i.Isvat);
        $('#txtVatRate').val(row_i.VatRate);
        $('#txtVatAmt').val(row_i.VatAmt);
        $('#txtIsTax').val(row_i.IsTax);
        $('#txtTaxRate').val(row_i.TaxRate);
        $('#txtTaxAmt').val(row_i.TaxAmt);
        $('#txtTotalAmt').val(row_i.TotalAmt);
        $('#txtTotalCharge').val(row_i.TotalCharge);
        $('#txtDiscountType').val((row_i.UnitDiscntPerc > 0 ? '0' : '1'));
        ShowDiscount();
        $('#txtUnitDiscntPerc').val(row_i.UnitDiscntPerc);
        $('#txtUnitDiscntAmt').val(row_i.UnitDiscntAmt);
        $('#txtVenderCode').val(row_i.VenderCode);
        ShowVender(path, row_i.VenderCode, '#txtVenderName');
        $('#txtVenderCost').val(row_i.VenderCost);
        $('#txtBaseProfit').val(row_i.BaseProfit);
        $('#txtCommissionType').val((row_i.CommissionPerc > 0 ? '0' : '1'));
        ShowCommission();
        $('#txtCommissionPerc').val(row_i.CommissionPerc);
        $('#txtCommissionAmt').val(row_i.CommissionAmt);
        $('#txtNetProfit').val(row_i.BaseProfit);
        $('#txtIsRequired').val(row_i.IsRequired);
        CalAmount();
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
    function ReadBilling(dt) {
        $('#txtBCustCode').val(dt.CustCode);
        $('#txtBCustBranch').val(dt.Branch);
        ShowCustomer(path, dt.CustCode, dt.Branch, '#txtBCustName');
    }
    function ReadCurrency(dt) {
        $('#txtCurrencyCode').val(dt.Code);
        $('#txtCurrencyName').val(dt.TName);
        $('#txtCurrencyRate').focus();
    }
    function ReadVender(dt) {
        $('#txtVenderCode').val(dt.VenCode);
        $('#txtVenderName').val(dt.TName);
        $('#txtVenderCost').focus();
    }
    function ReadManager(dt) {
        $('#txtManagerCode').val(dt.UserID);
        $('#txtManagerName').val(dt.TName);
    }
    function ReadService(dt) {
        $('#txtSICode').val(dt.SICode);
        $('#txtSDescription').val(dt.NameThai);
        $('#txtDescriptionThai').val(dt.NameThai);

    }
    function ShowDiscount() {
        if ($('#txtDiscountType').val() == '1') {
            $('#txtUnitDiscntPerc').val('0');
            $('#txtUnitDiscntAmt').removeAttr('disabled');
            $('#txtUnitDiscntPerc').attr('disabled','disabled');
        } else {
            $('#txtUnitDiscntAmt').attr('disabled', 'disabled');
            $('#txtUnitDiscntPerc').removeAttr('disabled');
        }
    }
    function ShowCommission() {
        if ($('#txtCommissionType').val() == '1') {
            $('#txtCommissionPerc').val('0');
            $('#txtCommissionAmt').removeAttr('disabled');
            $('#txtCommissionPerc').attr('disabled', 'disabled');
        } else {
            $('#txtCommissionAmt').attr('disabled', 'disabled');
            $('#txtCommissionPerc').removeAttr('disabled');
        }
    }
    function CalAmount() {
        let rate = CNum($('#txtCurrencyRate').val());
        let charge = CDbl(($('#txtChargeAmt').val() * rate), 2);
        $('#txtTotalAmt').val(charge);
        CalDiscount();
    }
    function CalDiscount() {
        let type = $('#txtDiscountType').val();
        let rate = CNum($('#txtUnitDiscntPerc').val());
        let disc = 0;
        if (type == 1) {
            disc = CNum($('#txtUnitDiscntAmt').val());
        } else {
            disc = CDbl((CNum($('#txtChargeAmt').val()) * CNum($('#txtCurrencyRate').val())) * (rate * 0.01), 2);
            $('#txtUnitDiscntAmt').val(disc);
        }
        $('#txtFUnitDiscntAmt').val(CDbl(disc / CNum($('#txtCurrencyRate').val()),2));
        $('#txtTotalCharge').val(CNum($('#txtTotalAmt').val()) - disc);
        CalVATWHT();
    }
    function GetBasePrice() {
        let type = $('#txtIsvat').val();
        let amt=CNum($('#txtTotalCharge').val());
        switch (type) {
            case '2': //inc vat
                amt = amt * (100 / (100 + (CNum($('#txtVatRate').val()) - CNum($('#txtTaxRate').val()))));
                break;
        }
        return amt;
    }
    function GetNetPrice() {
        let type = $('#txtIsvat').val();
        let amt = 0;
        if (type == '2') {
            amt = CNum($('#txtTotalCharge').val()) + CNum($('#txtTaxAmt').val()) - CNum($('#txtVatAmt').val());
        } else {
            amt = CNum($('#txtTotalCharge').val()) + CNum($('#txtVatAmt').val()) - CNum($('#txtTaxAmt').val());
        }
        return amt;
    }
    function CalVATWHT() {
        let amt = GetBasePrice();
        let type = $('#txtIsvat').val();
        let vat = 0;
        switch (type) {
            case '0': //novat
                vat = 0;
                break;
            default:
                vat = amt * (CNum($('#txtVatRate').val()) * 0.01);
                break;
        }
        $('#txtVatAmt').val(CDbl(vat,2));
        let wht = 0;
        type = $('#txtIsTax').val();
        switch (type) {
            case '0': //novat
                break;
            default:
                wht = amt * (CNum($('#txtTaxRate').val()) * 0.01);
                break;
        }
        $('#txtTaxAmt').val(CDbl(wht, 2));
        CalCommission();
    }
    function CalCommission() {
        let type = $('#txtCommissionType').val();
        let rate = CNum($('#txtCommissionPerc').val());
        let comm = CDbl(GetNetPrice() * (rate * 0.01), 2);
        if (type == 1) {
            comm = CNum($('#txtCommissionAmt').val());
        }
        $('#txtCommissionAmt').val(CDbl(comm, 2));
        CalProfit();
    }
    function CalProfit() {
        let comm = CNum($('#txtCommissionAmt').val());
        let cost = CNum($('#txtVenderCost').val());
        let amt = GetNetPrice();
        $('#txtBaseProfit').val(CDbl(amt - cost, 2));
        $('#txtNetProfit').val(CDbl(amt - comm - cost, 2));
    }
</script>

