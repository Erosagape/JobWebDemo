@Code
    ViewBag.Title = "สร้างใบแจ้งหนี้"
End Code
<div class="panel-body">
    <div class="container">
        <div class="row">
            <div class="col-sm-4">
                <a href="#" onclick="SearchData('branch')"> Branch :</a><br />
                <input type="text" id="txtBranchCode" style="width:50px" />
                <input type="text" id="txtBranchName" style="width:200px" disabled />
            </div>
            <div class="col-sm-3">
                Job Type: <br />
                <select id="cboJobType" class="form-control dropdown"></select>
            </div>
            <div class="col-sm-3">
                Ship By:<br />
                <select id="cboShipBy" class="form-control dropdown"></select>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                <a href="#" onclick="SearchData('customer')"> Customer :</a><br />
                <input type="text" id="txtCustCode" style="width:120px" />
                <input type="text" id="txtCustBranch" style="width:50px" />
                <input type="text" id="txtCustName" style="width:300px" disabled />
            </div>
            <div class="col-sm-3">
                <a href="#" onclick="SearchData('job')">Job No :</a><br />
                <input type="text" id="txtJobNo" class="form-control" />
            </div>
            <div class="col-sm-3">
                <br />
                <button class="btn btn-warning" id="btnRefresh" onclick="SetGridAdv(true)">Show</button>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <table id="tbHeader" class="table table-responsive">
                    <thead>
                        <tr>
                            <th>JobNo</th>
                            <th>ClrNo</th>
                            <th>CustCode</th>
                            <th>Description</th>
                            <th>Cost</th>
                            <th>Advance</th>
                            <th>Charge</th>
                            <th>VAT</th>
                            <th>WHT</th>
                            <th>Net</th>
                        </tr>
                    </thead>
                </table>
                <br />
                <input type="button" class="btn btn-success" value="Create Invoice" onclick="ShowSummary()" />
                <input type="button" class="btn btn-default" value="Reset Data" onclick="ResetData()" />
            </div>
        </div>
    </div>
    <div id="dvCreate" class="modal modal-lg fade" role="dialog">
        <div class="modal-dialog-lg">
            <div class="modal-content">
                <div class="modal-header">
                    <table>
                        <tr>
                            <td>
                                Invoice Date :<br />
                                <input type="date" id="txtDocDate" value="@DateTime.Today.ToString("yyyy-MM-dd")" />

                            </td>
                            <td>
                                Invoice Type :<br />
                                <select id="cboDocType">
                                    <option value="IVS-">Service</option>
                                    <option value="IVT-">Transport</option>
                                    <option value="IVF-">Freight</option>
                                </select>

                            </td>
                            <td>
                                <a href="#" onclick="SearchData('invoice')"> Replace Invoice No :</a><br />
                                <input type="text" id="txtDocNo" ondblclick="PrintInvoice()" disabled/>
                            </td>
                            <td>
                                <br />
                                <input type="button" onclick="PrintInvoice()" class="btn btn-success" value="Print Invoice" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <a href="#" onclick="SearchData('chequecust')">Customer Cheque Used</a> <br/>
                                <input type="text" id="txtChqNo" class="form-control" disabled />
                            </td>
                            <td>
                                Cheque Amount<br/>
                                <input type="text" id="txtChqAmount" class="form-control" disabled />
                                <input type="button" id="btnAddCheque" value="Add" class="btn" onclick="AddCheque()" />
                            </td>
                        </tr>
                    </table>
                    <button id="btnHide" class="btn btn-danger" data-dismiss="modal">Close</button>
                </div>
                <div class="modal-body">                    
                    <b>Invoice Summary:</b><br />
                    <div class="row">
                        <div class="col-sm-4">
                            <table style="width:100%">
                                <tr><td>Advance </td><td><input type="text" id="txtTotalAdvance" disabled /></td></tr>
                                <tr><td>Charge</td><td><input type="text" id="txtTotalCharge" disabled /></td></tr>
                                <tr><td>Vatable</td><td><input type="text" id="txtTotalIsTaxCharge" disabled /></td></tr>
                                <tr><td>Taxable</td><td><input type="text" id="txtTotalIs50Tavi" disabled /></td></tr>
                                <tr><td>VAT</td><td><input type="text" id="txtTotalVat" disabled /></td></tr>
                                <tr><td>After VAT</td><td><input type="text" id="txtTotalAfter" disabled /></td></tr>
                                <tr><td>WHT</td><td><input type="text" id="txtTotal50Tavi" disabled /></td></tr>
                                <tr><td>After WHT</td><td><input type="text" id="txtTotalService" disabled /></td></tr>
                                <tr><td>Cust.Advance</td><td><input type="text" id="txtTotalCustAdv" onchange="CalTotal()" /></td></tr>
                                <tr><td>NET</td><td><input type="text" id="txtTotalNet" disabled /></td></tr>
                                <tr><td>Currency</td><td><input type="text" id="txtCurrencyCode" disabled /></td></tr>
                                <tr><td>Exc.Rate</td><td><input type="text" id="txtExchangeRate" onchange="CalForeign()" /></td></tr>
                                <tr><td>Invoiced</td><td><input type="text" id="txtForeignNet" disabled /></td></tr>
                                <tr><td>Cost</td><td><input type="text" id="txtTotalCost" disabled /></td></tr>
                                <tr><td>Profit</td><td><input type="text" id="txtTotalProfit" disabled /></td></tr>
                            </table>
                            <button id="btnGen" class="btn btn-success" onclick="ApproveData()">Save Invoice</button>
                        </div>
                        <div class="col-sm-6">
                            <b>Invoice Detail:</b><br />
                            <table id="tbDetail" style="width:100%;">
                                <thead>
                                    <tr>
                                        <th>JobNo</th>
                                        <th>Description</th>
                                        <th>SlipNo</th>
                                        <th>Advance</th>
                                        <th>Charge</th>
                                        <th>VAT</th>
                                        <th>WH-Tax</th>
                                    </tr>
                                </thead>
                                <tbody></tbody>
                            </table>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm-4">
                            <b>Cheque Used</b><br/>
                            <table id="tbCheque">
                                <thead>
                                    <tr>
                                        <th>Cheque No</th>
                                        <th>Amount</th>
                                    </tr>
                                </thead>
                                <tbody></tbody>
                            </table>
                        </div>
                        <div class="col-sm-6">
                            <b>Costing of Invoice:</b><br />
                            <table id="tbCost" style="width:100%;">
                                <thead>
                                    <tr>
                                        <th>Job No</th>
                                        <th>Description</th>
                                        <th>SlipNo</th>
                                        <th>Expense</th>
                                        <th>VAT</th>
                                        <th>WH-Tax</th>
                                        <th>Net</th>
                                    </tr>
                                </thead>
                                <tbody></tbody>
                            </table>
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
    var arr = [];
    var chq = [];
    $(document).ready(function () {
        SetEvents();
        //Load params
        let branch = getQueryString("branch");
        let code = getQueryString("code");
        if (branch !== null && code !== null) {
            $('#txtBranchCode').val(branch);
            ShowBranch(path, branch, '#txtBranchName');
            $('#txtJobNo').val(code.toUpperCase());            
        }
    });
    function SetEvents() {
        //Combos
        let lists = 'JOB_TYPE=#cboJobType';
        lists += ',SHIP_BY=#cboShipBy';
        loadCombos(path, lists);
        //Events
        $('#txtBranchCode').keydown(function (event) {
            if (event.which == 13) {
                $('#txtBranchName').val('');
                ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            }
        });
        $('#txtCustBranch').keydown(function (event) {
            if (event.which == 13) {
                $('#txtCustName').val('');
                ShowCustomer(path, $('#txtCustCode').val(), $('#txtCustBranch').val(), '#txtCustName');
            }
        });

        //3 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name,desc1,desc2', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv, '#frmSearchCust', '#tbCust', 'Customers', response, 3);
            CreateLOV(dv, '#frmSearchJob', '#tbJob', 'Job', response, 3);
            CreateLOV(dv, '#frmSearchInv', '#tbInv', 'Cancelled Invoice', response, 3);
            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response, 2);
            //Cheque
            CreateLOV(dv, '#frmSearchChq', '#tbChq', 'Customer Cheque', response, 5);
        });

    }
    function SetGridAdv(isAlert) {
        let w = '';
        if ($('#txtJobNo').val() !== "") {
            w = w + '&job=' + $('#txtJobNo').val();
        }
        if ($('#txtCustCode').val() !== "") {
            w = w + '&cust=' + $('#txtCustCode').val();
        }
        if ($('#cboJobType').val() !== "") {
            w = w + '&jtype=' + $('#cboJobType').val();
        }
        if ($('#cboShipBy').val() !== "") {
            w = w + '&sby=' + $('#cboShipBy').val();
        }
        $.get(path + 'acc/getclearforinv?branch=' + $('#txtBranchCode').val() + w, function (r) {
            if (r.invdetail.data.length == 0) {
                $('#tbHeader').DataTable().clear().draw();
                if (isAlert==true) alert('data not found');
                return;
            }
            let h = r.invdetail.data;
            $('#tbHeader').DataTable({
                data: h,
                selected: true, //ให้สามารถเลือกแถวได้
                columns: [ //กำหนด property ของ header column
                    { data: "JobNo", title: "Job No" },
                    { data: "ClrNo", title: "Clr No" },
                    { data: "CustCode", title: "Customer" },
                    {
                        data: null, title: "Description",
                        render: function (data) {
                            return data.SICode + '-' + data.SDescription + (data.ExpSlipNO == null ? '' : ' #' + data.ExpSlipNO);
                        }
                    },
                    { data: "AmtCost", title: "Cost" },
                    { data: "AmtAdvance", title: "Advance" },
                    { data: "AmtCharge", title: "Charge" },
                    { data: "AmtVat", title: "VAT" },
                    { data: "Amt50Tavi", title: "WHT" },
                    { data: "AmtNet", title: "NET" }
                ],
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            });
            $('#tbHeader tbody').on('click', 'tr', function () {
                if ($(this).hasClass('selected') == true) {
                    $(this).removeClass('selected');
                    let data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                    RemoveData(data); //callback function from caller
                    return;
                }
                $(this).addClass('selected');
                let data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                AddData(data); //callback function from caller
            });
            $('#tbHeader tbody').on('dblclick', 'tr', function () {            
                let clearno = $(this).find('td:eq(1)').text();
                //alert('you click ' + clearno);
                window.open(path + 'Clr/Index?BranchCode=' + $('#txtBranchCode').val() + '&ClrNo=' + clearno);
            });
        });
    }
    function ShowSummary() {
        if ($('#txtCustCode').val() == '') {
            alert('Please Select Customer Before');
            return;
        }
        if (arr.length == 0) {
            alert('No data selected');
            return;
        }
        let totaladv = 0;
        let totalcharge = 0;
        let totalistaxcharge = 0;
        let totalis50tavi = 0;
        let totalvat = 0;
        let total50tavi = 0;
        let totalcustadv = 0;
        let totalnet = 0;
        let totalcost = 0;

        for (let obj of arr) {
            totaladv += obj.AmtAdvance;
            totalcharge += obj.AmtCharge;
            totalcost += obj.AmtCost;
            if (obj.AmtCharge > 0) {
                totalistaxcharge += (obj.AmtVat > 0 ? obj.AmtCharge : 0);
                totalis50tavi += (obj.Amt50Tavi > 0 ? obj.AmtCharge : 0);
                totalvat += obj.AmtVat;
                total50tavi += obj.Amt50Tavi;
            }
            totalnet += obj.AmtNet;
        }
        for (let c of chq) {
            totalcustadv += c.ChqAmount;
        }
        $('#txtTotalAdvance').val(CDbl(totaladv, 2));
        $('#txtTotalCharge').val(CDbl(totalcharge, 2));
        $('#txtTotalIsTaxCharge').val(CDbl(totalistaxcharge, 2));
        $('#txtTotalIs50Tavi').val(CDbl(totalis50tavi, 2));
        $('#txtTotalVat').val(CDbl(totalvat, 2));
        $('#txtTotalAfter').val(CDbl(totalcharge+totalvat, 2));
        $('#txtTotal50Tavi').val(CDbl(total50tavi, 2));
        $('#txtTotalService').val(CDbl(totalcharge+totalvat-total50tavi, 2));
        $('#txtTotalNet').val(CDbl(totalnet, 2));
        $('#txtTotalCustAdv').val(CDbl(totalcustadv, 2));

        $('#txtCurrencyCode').val('@ViewBag.PROFILE_CURRENCY');
        $('#txtExchangeRate').val(1);
        $('#txtTotalCost').val(CDbl(totalcost, 2));
        $('#txtTotalProfit').val(CDbl(totalcharge+totalvat-total50tavi - totalcost, 2));

        CalForeign();

        ShowDetail();
        $('#txtDocNo').val('');
        $('#btnGen').show();
        $('#dvCreate').modal('show');
    }
    function ShowDetail() {
        let arr_sel = arr.filter(function (d) {
            return d.AmtCharge > 0 || d.AmtAdvance > 0;
        });
        $('#tbDetail').DataTable({
            data: arr_sel,
            selected: true, //ให้สามารถเลือกแถวได้
            columns: [ //กำหนด property ของ header column
                    { data: "JobNo", title: "Job No" },
                    {
                        data: null, title: "Description",
                        render: function (data) {
                            return data.SICode + '-' + data.SDescription + (data.ExpSlipNO == null ? '' : ' #' + data.ExpSlipNO);
                        }
                    },
                    { data: "ExpSlipNO", title: "Slip No" },
                    { data: "AmtAdvance", title: "Advance" },
                    { data: "AmtCharge", title: "Charge" },
                    { data: "AmtVat", title: "VAT" },
                    { data: "Amt50Tavi", title: "WHT" }
                ],
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
        });
        let arr_cost = arr.filter(function (d) {
            return d.AmtCost > 0;
        });
        $('#tbCost').DataTable({
            data: arr_cost,
            selected: true, //ให้สามารถเลือกแถวได้
            columns: [ //กำหนด property ของ header column
                { data: "JobNo", title: "Job No" },
                {
                    data: null, title: "Description",
                    render: function (data) {
                        return data.SICode + '-' + data.SDescription + (data.ExpSlipNO == null ? '' : ' #' + data.ExpSlipNO);
                    }
                },
                { data: "ExpSlipNO", title: "Slip No" },
                { data: "AmtCost", title: "Advance" },
                { data: "AmtVat", title: "VAT" },
                { data: "Amt50Tavi", title: "WHT" },
                { data: "AmtNet", title: "NET" }
            ],
            destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
        });
    }
    function CalTotal() {
        let totalnet = CNum($('#txtTotalAdvance').val()) + CNum($('#txtTotalCharge').val()) + CNum($('#txtTotalVat').val()) - CNum($('#txtTotal50Tavi').val()) - CNum($('#txtTotalCustAdv').val());
        $('#txtTotalNet').val(totalnet);
        $('#txtTotalProfit').val(CDbl(totalnet - CNum($('#txtTotalCost').val()), 2));

        CalForeign();
    }
    function CalForeign() {
        let totalforeign = CDbl(CNum($('#txtTotalNet').val()) / CNum($('#txtExchangeRate').val()), 2);
        $('#txtForeignNet').val(totalforeign);
    }
    function AddData(o) {
        arr.push(o);
    }
    function RemoveData(o) {
        let idx = arr.indexOf(o);
        if (idx < 0) {
            return;
        }
        arr.splice(idx, 1);
    }
    function ApproveData() {
        if (Number($('#txtTotalNet').val()) == 0) {
            alert('no data to approve');
            return;
        }
        if ($('#txtCustCode').val() == '') {
            alert('Please select Customer first!');
            return;
        }
        let dataInv = {
            BranchCode:$('#txtBranchCode').val(),
            DocNo: $('#txtDocNo').val(),
            DocType:$('#cboDocType').val(),
            DocDate: CDateTH($('#txtDocDate').val()),
            CustCode:$('#txtCustCode').val(),
            CustBranch:$('#txtCustBranch').val(),
            BillToCustCode:null,
            BillToCustBranch: null,
            ContactName:'',
            EmpCode:user,
            PrintedBy:'',
            PrintedDate:null,
            PrintedTime:null,
            RefNo: GetRefNo(),
            VATRate:CNum(Number(@ViewBag.PROFILE_VATRATE)*100),
            TotalAdvance:CNum($('#txtTotalAdvance').val()),
            TotalCharge:CNum($('#txtTotalCharge').val()),
            TotalIsTaxCharge:CNum($('#txtTotalIsTaxCharge').val()),
            TotalIs50Tavi:CNum($('#txtTotalIs50Tavi').val()),
            TotalVAT:CNum($('#txtTotalVat').val()),
            Total50Tavi:CNum($('#txtTotal50Tavi').val()),
            TotalCustAdv:CNum($('#txtTotalCustAdv').val()),
            TotalNet:CNum($('#txtTotalNet').val()),
            CurrencyCode:$('#txtCurrencyCode').val(),
            ExchangeRate:CNum($('#txtExchangeRate').val()),
            ForeignNet: CNum($('#txtForeignNet').val()),
            TotalDiscount: 0,
            SumDiscount: 0,
            DiscountRate: 0,
            CalDiscount:0,
            BillAcceptDate:null,
            BillIssueDate:null,
            BillAcceptNo:'',
            Remark1:'',
            Remark2:'',
            Remark3:'',
            Remark4:'',
            Remark5:'',
            Remark6:'',
            Remark7:'',
            Remark8:'',
            Remark9:'',
            Remark10:'',
            CancelReson:'',
            CancelProve:'',
            CancelDate:null,
            CancelTime:null,
            ShippingRemark:''
        };
        let jsonString = JSON.stringify({ data: dataInv });
        $.ajax({
            url: "@Url.Action("SetInvHeader", "Acc")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                if (response.result.data !== null) {
                    SaveDetail(response.result.data);
                    alert(response.result.data);
                    return;
                }
                alert(response.result.msg);
            },
            error: function (e) {
                alert(e);
            }
        });
        return;
    }
    function GetRefNo() {
        let joblist = [];
        let retstr = '';
        for (let obj of arr) {
            if (joblist.indexOf(obj.JobNo) < 0) {
                joblist.push(obj.JobNo);
                if (retstr !== '') retstr += ',';
                retstr += obj.JobNo;
            }
        }
        return retstr;
    }
    function SaveDetail(docno) {
        $('#txtDocNo').val(docno);
        let list = GetDataDetail(arr,docno);
        let jsonText = JSON.stringify({ data: list });
            //alert(jsonText);
            $.ajax({
                url: "@Url.Action("SaveInvDetail", "Acc")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.data !== null) {
                        alert(response.result.msg + '\n=>' + response.result.data);
                        SetGridAdv(false);
                        $('#btnGen').hide();
                        arr = [];
                        return;
                    }
                    alert(response.result.msg);
                },
                error: function (e) {
                    alert(e);
                }
            });
    }
    function SearchData(type) {
        switch (type) {
            case 'branch':
                SetGridBranch(path, '#tbBranch', '#frmSearchBranch', ReadBranch);
                break;
            case 'job':
                SetGridJob(path, '#tbJob', '#frmSearchJob', '?branch=' + $('#txtBranchCode').val() + '&custcode=' + $('#txtCustCode').val(), ReadJob);
                break;
            case 'invoice':
                SetGridInv(path, '#tbInv', '#frmSearchInv', '?cancel=Y' ,ReadInv);
                break;
            case 'customer':
                SetGridCompany(path, '#tbCust', '#frmSearchCust', ReadCustomer);
                break;
            case 'chequecust':
                SetGridCheque(path, '#tbChq', '#frmSearchChq', '?type=CU&Cancel=N&Branch=' + $('#txtBranchCode').val(), ReadCheque);
                break;
        }
    }
    function ReadInv(dt) {
        $('#txtDocNo').val(dt.DocNo);
    }
    function ReadJob(dt) {
        $('#txtJobNo').val(dt.JNo);
    }
    function ReadCheque(dt) {
        $('#txtChqNo').val(dt.ChqNo);
        $('#txtChqAmount').val(dt.AmountRemain);
    }
    function ReadBranch(dt) {
        $('#txtBranchCode').val(dt.Code);
        $('#txtBranchName').val(dt.BrName);
        $('#txtBranchCode').focus();
    }
    function ReadCustomer(dt) {
        $('#txtCustCode').val(dt.CustCode);
        $('#txtCustBranch').val(dt.Branch);
        //ShowCustomer(path, dt.CustCode, dt.Branch, '#txtCustName');
        $('#txtCustName').val(dt.NameThai);
        $('#txtCustCode').focus();
    }
    function GetDataDetail(o, no) {
        let data = [];
        let i = 0;
        for (let obj of o) {
            if (obj.AmtCharge > 0 || obj.AmtAdvance > 0) {

                i = i + 1;
                data.push({
                    BranchCode: obj.BranchCode,
                    ClrNo: obj.ClrNo,
                    ClrItemNo: obj.ClrItemNo,
                    DocNo: no,
                    ItemNo: i,
                    SICode: obj.SICode,
                    SDescription: obj.SDescription,
                    ExpSlipNO: obj.ExpSlipNO,
                    SRemark: obj.SRemark,
                    CurrencyCode: $('#txtCurrencyCode').val(),
                    ExchangeRate: $('#txtExchangeRate').val(),
                    Qty: CNum(obj.Qty),
                    QtyUnit: obj.QtyUnit,
                    UnitPrice: obj.UnitPrice,
                    FUnitPrice: CDbl(obj.UnitPrice / CNum($('#txtExchangeRate').val()), 2),
                    Amt: obj.Amt,
                    FAmt: CDbl(obj.Amt / CNum($('#txtExchangeRate').val()), 2),
                    DiscountType: obj.DiscountType,
                    DiscountPerc: obj.DiscountPerc,
                    AmtDiscount: obj.AmtDiscount,
                    FAmtDiscount: CDbl(obj.AmtDiscount / CNum($('#txtExchangeRate').val()), 2),
                    Is50Tavi: obj.Is50Tavi,
                    Rate50Tavi: obj.Rate50Tavi,
                    Amt50Tavi: obj.Amt50Tavi,
                    IsTaxCharge: obj.IsTaxCharge,
                    AmtVat: obj.AmtVat,
                    TotalAmt: obj.TotalAmt,
                    FTotalAmt: CDbl(obj.TotalAmt / CNum($('#txtExchangeRate').val()), 2),
                    AmtAdvance: obj.AmtAdvance,
                    AmtCharge: obj.AmtCharge,
                    CurrencyCodeCredit: obj.CurrencyCodeCredit,
                    ExchangeRateCredit: obj.ExchangeRateCredit,
                    AmtCredit: obj.AmtCredit,
                    FAmtCredit: CDbl(obj.FAmtCredit / CNum($('#txtExchangeRate').val()), 2),
                    VATRate: obj.VATRate
                });
            } else {
                data.push({
                    BranchCode: obj.BranchCode,
                    ClrNo: obj.ClrNo,
                    ClrItemNo: obj.ClrItemNo,
                    DocNo: no,
                    ItemNo: 0,
                    SICode: obj.SICode,
                    SDescription: obj.SDescription,
                    ExpSlipNO: obj.ExpSlipNO,
                    SRemark: obj.SRemark,
                    CurrencyCode: $('#txtCurrencyCode').val(),
                    ExchangeRate: $('#txtExchangeRate').val(),
                    Qty: obj.Qty,
                    QtyUnit: obj.QtyUnit,
                    UnitPrice: obj.UnitPrice,
                    FUnitPrice: CDbl(obj.UnitPrice / CNum($('#txtExchangeRate').val()), 2),
                    Amt: obj.Amt,
                    FAmt: CDbl(obj.Amt / CNum($('#txtExchangeRate').val()), 2),
                    DiscountType: obj.DiscountType,
                    DiscountPerc: obj.DiscountPerc,
                    AmtDiscount: obj.AmtDiscount,
                    FAmtDiscount: CDbl(obj.AmtDiscount / CNum($('#txtExchangeRate').val()), 2),
                    Is50Tavi: obj.Is50Tavi,
                    Rate50Tavi: obj.Rate50Tavi,
                    Amt50Tavi: obj.Amt50Tavi,
                    IsTaxCharge: obj.IsTaxCharge,
                    AmtVat: obj.AmtVat,
                    TotalAmt: obj.TotalAmt,
                    FTotalAmt: CDbl(obj.TotalAmt / CNum($('#txtExchangeRate').val()), 2),
                    AmtAdvance: obj.AmtAdvance,
                    AmtCharge: obj.AmtCharge,
                    CurrencyCodeCredit: obj.CurrencyCodeCredit,
                    ExchangeRateCredit: obj.ExchangeRateCredit,
                    AmtCredit: obj.AmtCredit,
                    FAmtCredit: CDbl(obj.FAmtCredit / CNum($('#txtExchangeRate').val()), 2),
                    VATRate: obj.VATRate
                });
            }
        }
        return data;
    }
    function PrintInvoice() {
        let code = $('#txtDocNo').val();
        if (code !== '') {
            let branch = $('#txtBranchCode').val();
            window.open(path + 'Acc/FormInv?Branch=' + branch + '&Code=' + code);
        }
    }
    function ResetData() {
        arr = [];
        SetGridAdv(true);
    }
    function AddCheque() {
        let c = {
            ChqNo: $('#txtChqNo').val(),
            ChqAmount: $('#txtChqAmount').val()
        };
        if (chq.indexOf(c) < 0) {
            chq.push(c);
        }
        ShowCheque();
        ShowSummary();
    }
    function ShowCheque() {
        $('#tbCheque').DataTable({
            data: chq,
            selected: true, //ให้สามารถเลือกแถวได้
            columns: [ //กำหนด property ของ header column
                { data: "ChqNo", title: "Cheque No" },
                { data: "ChqAmount", title: "Amount" }
            ],
            destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
        });
    }
</script>