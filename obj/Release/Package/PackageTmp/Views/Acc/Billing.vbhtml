@Code
    ViewBag.Title = "Billing Acknowledgement"
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
        </div>
        <div class="row">
            <div class="col-sm-2">
                Bill Date From:<br />
                <input type="date" class="form-control" id="txtDocDateF" />
            </div>
            <div class="col-sm-2">
                Bill Date To:<br />
                <input type="date" class="form-control" id="txtDocDateT" />
            </div>
            <div class="col-sm-3">
                <br />
                <a href="#" class="btn btn-primary" id="btnShow">
                    <i class="fa fa-lg fa-filter"></i>&nbsp;<b>Search</b>
                </a>
                <a href="#" class="btn btn-default w3-purple" id="btnAdd" onclick="CreateBilling()">
                    <i class="fa fa-lg fa-file-o"></i>&nbsp;<b>New Billing</b>
                </a>
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
                            <th>BillNo</th>
                            <th class="desktop">BillDate</th>
                            <th class="desktop">CustCode</th>
                            <th class="desktop">BillRemark</th>
                            <th class="desktop">BillRecvDate</th>
                            <th>DuePayment</th>
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
                Details of Billing No:<input type="text" id="txtDocNo" style="width:10%" disabled />
                <table id="tbDetail" class="table table-responsive" style="width:100%">
                    <thead>
                        <tr>
                            <th>InvNo</th>
                            <th class="desktop">InvDate</th>
                            <th class="desktop">CustAdv</th>
                            <th class="desktop">Adv</th>
                            <th class="desktop">Charge</th>
                            <th class="desktop">ChargeVat</th>
                            <th class="desktop">Disc</th>
                            <th class="desktop">WH</th>
                            <th class="desktop">VAT</th>
                            <th class="all">Total</th>
                        </tr>
                    </thead>
                </table>
                <a href="#" class="btn btn-info" id="btnPrint" onclick="PrintData()">
                    <i class="fa fa-lg fa-print"></i>&nbsp;<b>Print</b>
                </a>
                <div style="float:right">
                    <a href="#" class="btn btn-danger" id="btnDel" onclick="DeleteDetail()">
                        <i class="fa fa-lg fa-trash"></i>&nbsp;<b>Delete</b>
                    </a>
                </div>
            </div>
        </div>
        <div id="frmHeader" class="modal fade">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <div style="display:flex">
                            Billing No: <input type="text" id="txtBillAcceptNo" style="width:150px" disabled /> &nbsp;
                            Issue Date: <input type="date" id="txtBillDate" style="width:150px" disabled />
                        </div>
                    </div>
                    <div class="modal-body">
                        <div style="display:flex">
                            Billing To: <input type="text" id="txtBCustCode" style="width:100px" disabled />
                            <input type="text" id="txtBCustBranch" style="width:50px" disabled />
                            <input type="text" id="txtBCustName" style="width:250px" disabled />
                        </div>
                        <div style="display:flex">
                            Received By : <input type="text" id="txtBillRecvBy" style="width:200px" /> &nbsp;
                            Confirm Date : <input type="date" id="txtBillRecvDate" style="width:150px" />
                        </div>
                        <div style="display:flex">
                            <div style="flex:2">
                                Remark:<textarea id="txtBillRemark" style="width:100%"></textarea>
                            </div>
                            <div style="flex:1">
                                Payment Due : <input type="date" id="txtDuePaymentDate" style="width:150px" />
                            </div>
                        </div>
                        <p>
                            <div style="display:flex">
                                <div style="flex:1">
                                    Cancel By <input type="text" id="txtCancelProve" disabled />
                                </div>
                                <div style="flex:3">
                                    Reason <textarea id="txtCancelReson" style="width:100%"></textarea>
                                </div>
                            </div>
                            <div style="flex-direction:row;">
                                Cancel Date <input type="date" id="txtCancelDate" disabled /> &nbsp;
                                Time <input type="text" id="txtCancelTime" disabled /> &nbsp;
                                <input type="button" id="btnCancel" class="btn btn-danger" onclick="CancelData()" value="Cancel" />
                            </div>
                        </p>
                        <p>
                            Total Billing :
                            <div style="display:flex">
                                <div style="flex:1">
                                    <table style="width:100%">
                                        <tr>
                                            <td>
                                                Advance
                                            </td>
                                            <td>
                                                <input type="number" id="txtTotalAdvance" style="width:100px" disabled />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Service
                                            </td>
                                            <td>
                                                <input type="number" id="txtTotalChargeNonVAT" style="width:100px" disabled />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Service VAT
                                            </td>
                                            <td>
                                                <input type="number" id="txtTotalChargeVAT" style="width:100px" disabled />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Cust.Adv
                                            </td>
                                            <td>
                                                <input type="number" id="txtTotalCustAdv" style="width:100px" disabled />
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                <div style="flex:1">
                                    <table style="width:100%">
                                        <tr>
                                            <td>VAT </td>
                                            <td>
                                                <input type="number" id="txtTotalVAT" style="width:100px" disabled />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                WH-Tax
                                            </td>
                                            <td>
                                                <input type="number" id="txtTotalWH" style="width:100px" disabled />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Discount
                                            </td>
                                            <td>
                                                <input type="number" id="txtTotalDiscount" style="width:100px" disabled />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                Total
                                            </td>
                                            <td>
                                                <input type="number" id="txtTotalNet" style="width:100px" disabled />
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                        </p>
                    </div>
                    <div class="modal-footer">
                        <div style="float:left">
                            <a href="#" class="btn btn-success" id="btnSave" onclick="SaveData()">
                                <i class="fa fa-lg fa-save"></i>&nbsp;<b>Update</b>
                            </a>
                            <a href="#" class="btn btn-info" id="btnPrint" onclick="PrintData()">
                                <i class="fa fa-lg fa-print"></i>&nbsp;<b>Print</b>
                            </a>
                            Last update <label id="lblEmpCode"></label> At <label id="lblRecDateTime"></label>
                        </div>
                        <button id="btnHide" class="btn btn-danger" data-dismiss="modal">X</button>
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
                if (isAlert==true) ShowMessage('data not found');
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
                responsive:true,
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
                    ShowMessage('you are not allow to edit billing document');
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
                ShowMessage('Please enter reason for cancel');
                $('#txtCancelReson').focus();
                return;
            }
            $('#txtCancelDate').val(GetToday());
            $('#txtCancelTime').val(ShowTime(GetTime()));
            $('#txtCancelProve').val(user);
        } else {
            ShowMessage('you are not allow to cancel billing Document');
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
                    responsive:true,
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
            ShowConfirm("Are you sure to delete inv " + row_d.InvNo + ' from ' + row_d.BillAcceptNo, function (result) {
                if (result == true) {
                    $.get(path + 'Acc/DelBillDetail?Branch=' + row.BranchCode + '&Code=' + row.BillAcceptNo + '&Item=' + row_d.ItemNo)
                    .done(function (r) {
                        if (r.billdetail.data !== null) {
                            ShowDetail(row.BranchCode, row.BillAcceptNo);
                        }
                        ShowMessage(r.billdetail.result);
                    });
                }                
            });
        } else {
            ShowMessage('no data to delete');
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
    function CreateBilling() {
        let w = '?branch=' + $('#txtBranchCode').val();
        if ($('#txtCustCode').val() !== '') {
            w += '&custcode=' + $('#txtCustCode').val() + '&custbranch=' + $('#txtCustBranch').val();
        }        
        window.open('/Acc/GenerateBilling' + w, '_blank');
    }
</script>

