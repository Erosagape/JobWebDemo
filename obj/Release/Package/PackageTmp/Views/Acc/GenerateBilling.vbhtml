@Code
    ViewBag.Title = "สร้างใบวางบิล"
End Code
<div class="panel-body">
    <div class="container">
        <div class="row">
            <div class="col-sm-4">
                Branch:
                <br />
                <div style="display:flex;flex-direction:row">
                    <input type="text" class="form-control" id="txtBranchCode" style="width:15%" disabled />
                    <input type="button" class="btn btn-default" value="..." onclick="SearchData('branch');" />
                    <input type="text" class="form-control" id="txtBranchName" style="width:65%" disabled />
                </div>
            </div>
            <div class="col-sm-2">
                Invoice Date From:<br />
                <input type="date" class="form-control" id="txtDocDateF" />
            </div>
            <div class="col-sm-2">
                Invoice Date To:<br />
                <input type="date" class="form-control" id="txtDocDateT" />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                Customer:
                <br />
                <div style="display:flex;flex-direction:row">
                    <input type="text" id="txtCustCode" style="width:120px" />
                    <input type="text" id="txtCustBranch" style="width:50px" />
                    <button id="btnBrowseCust" class="btn btn-default" onclick="SearchData('customer')">...</button>
                    <input type="text" id="txtCustName" style="width:100%" disabled />
                </div>
            </div>
            <div class="col-sm-3">
                <br />
                <a href="#" class="btn btn-primary" id="btnSearch" onclick="SetGridAdv(true)">
                    <i class="fa fa-lg fa-filter"></i>&nbsp;<b>Search</b>
                </a>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <table id="tbHeader" class="table table-responsive">
                    <thead>
                        <tr>
                            <th>DocNo</th>
                            <th class="desktop">DocDate</th>
                            <th class="desktop">CustCode</th>
                            <th class="desktop">Remark</th>
                            <th class="desktop">Cust.Adv</th>
                            <th class="all">Advance</th>
                            <th class="all">Charge</th>
                            <th class="desktop">VAT</th>
                            <th class="desktop">WHT</th>
                            <th class="all">Net</th>
                        </tr>
                    </thead>
                </table>
                <br />
                <a href="#" class="btn btn-success" id="btnGen" onclick="ShowSummary()">
                    <i class="fa fa-lg fa-save"></i>&nbsp;<b>Create Billing</b>
                </a>
            </div>
        </div>
    </div>
    <div id="dvCreate" class="modal modal-lg fade" role="dialog">
        <div class="modal-dialog-lg">
            <div class="modal-content">
                <div class="modal-header">
                    <table>
                        <tr>
                            <td style="width:20%">
                                Billing Date :<br />
                                <input type="date" id="txtDocDate" value="@DateTime.Today.ToString("yyyy-MM-dd")" />
                            </td>
                            <td style="width:20%">
                                <a href="#" onclick="SearchData('billing')">Billing Place :</a><br />
                                <input type="text" id="txtBillToCustCode" style="width:100%" disabled />
                            </td>
                            <td style="width:10%">
                                <br />
                                <input type="text" id="txtBillToCustBranch" style="width:100%" disabled />
                            </td>
                            <td style="width:50%">
                                <br />
                                <input type="text" id="txtBillToCustName" style="width:100%" disabled />
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="modal-body">
                    <b>Billing Summary:</b><br />
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
                                <tr><td>Cust.Advance</td><td><input type="text" id="txtTotalCustAdv" disabled /></td></tr>
                                <tr><td>NET</td><td><input type="text" id="txtTotalNet" disabled /></td></tr>
                            </table>
                            <a href="#" class="btn btn-success" id="btnGen" onclick="ApproveData()">
                                <i class="fa fa-lg fa-save"></i>&nbsp;<b>Save Billing</b>
                            </a>
                        </div>
                        <div class="col-sm-6">
                            <b>Billing Detail:</b><br />
                            <table id="tbDetail" style="width:100%;">
                                <thead>
                                    <tr>
                                        <th>InvNo</th>
                                        <th class="desktop">InvDate</th>
                                        <th class="all">Advance</th>
                                        <th class="all">Charge</th>
                                        <th class="desktop">VAT</th>
                                        <th class="desktop">WH-Tax</th>
                                        <th class="all">Net</th>
                                    </tr>
                                </thead>
                                <tbody></tbody>
                            </table>
                        </div>
                    </div>
                    Billing No : <input type="text" id="txtDocNo" disabled />
                    <a href="#" class="btn btn-info" id="btnPrint" onclick="PrintBilling()">
                        <i class="fa fa-lg fa-print"></i>&nbsp;<b>Print Billing</b>
                    </a>
                </div>
                <div class="modal-footer">
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
    let  arr = [];
    //$(document).ready(function () {
    //});
    let branch = getQueryString("branch");
    let custcode = getQueryString("custcode");
    let custbranch = getQueryString("custbranch");
    if (custcode !== '') {
        $('#txtBranchCode').val(branch);
        ShowBranch(path, branch, '#txtBranchName');

        $('#txtCustCode').val(custcode);
        $('#txtCustBranch').val(custbranch);
        ShowCustomer(path, custcode, custbranch, '#txtCustName');
    } else {
        $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
        $('#txtBranchName').val('@ViewBag.PROFILE_DEFAULT_BRANCH_NAME'); 
    }
    SetEvents();
    function SetEvents() {
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
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Customers
            CreateLOV(dv, '#frmSearchCust', '#tbCust', 'Customers', response, 3);
            CreateLOV(dv, '#frmSearchBill', '#tbBill', 'Billing Place', response, 3);
            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response, 2);
        });
    }
    function SetGridAdv(isAlert) {
        arr = [];

        let w = '';
        if ($('#txtCustCode').val() !== "") {
            w = w + '&Cust=' + $('#txtCustCode').val();
        }
        if ($('#txtDocDateF').val() !== "") {
            w = w + '&DateFrom=' + CDateEN($('#txtDocDateF').val());
        }
        if ($('#txtDocDateT').val() !== "") {
            w = w + '&DateTo=' + CDateEN($('#txtDocDateT').val());
        }
        $.get(path + 'acc/getinvforbill?branch=' + $('#txtBranchCode').val() + w, function (r) {
            if (r.invdetail.data.length == 0) {
                $('#tbHeader').DataTable().clear().draw();
                if (isAlert==true) ShowMessage('data not found');
                return;
            }
            let h = r.invdetail.data;
            $('#tbHeader').DataTable({
                data: h,
                selected: true, //ให้สามารถเลือกแถวได้
                columns: [ //กำหนด property ของ header column
                    { data: "DocNo", title: "Inv No" },
                    {
                        data: "DocDate", title: "Inv date ",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "CustCode", title: "Customer" },
                    { data: "RefNo", title: "Reference Number" },
                    { data: "TotalCustAdv", title: "Cust.Adv" },
                    { data: "TotalAdvance", title: "Advance" },
                    { data: "TotalCharge", title: "Charge" },
                    { data: "TotalVAT", title: "VAT" },
                    { data: "Total50Tavi", title: "WHT" },
                    { data: "TotalNet", title: "NET" }
                ],
                responsive:true,
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
        });
    }
    function ShowSummary() {
        if ($('#txtCustCode').val() == '') {
            ShowMessage('Please select Customer first');
            return;
        }
        if (arr.length == 0) {
            ShowMessage('no data to approve');
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

        for (let obj of arr) {
            totaladv += obj.TotalAdvance;
            totalcharge += obj.TotalCharge;
            totalistaxcharge += obj.TotalIsTaxCharge;
            totalis50tavi += obj.TotalIsTaxCharge;
            totalvat += obj.TotalVAT;
            total50tavi += obj.Total50Tavi;
            totalcustadv += obj.TotalCustAdv;
            totalnet += obj.TotalNet;
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

        ShowDetail();
        $('#txtDocNo').val('');
        $('#btnGen').show();
        $('#dvCreate').modal('show');
    }
    function ShowDetail() {
        $('#tbDetail').DataTable({
            data: arr,
            selected: true, //ให้สามารถเลือกแถวได้
            columns: [ //กำหนด property ของ header column
                { data: "DocNo", title: "Doc No" },
                {
                    data: "DocDate", title: "Inv date ",
                    render: function (data) {
                        return CDateEN(data);
                    }
                },
                { data: "TotalAdvance", title: "Advance" },
                { data: "TotalCharge", title: "Charge" },
                { data: "TotalVAT", title: "VAT" },
                { data: "Total50Tavi", title: "WHT" },
                { data: "TotalNet", title: "NET" }
            ],
            responsive:true,
            destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
        });
    }
    function CalTotal() {
        let totalnet = CNum($('#txtTotalAdvance').val()) + CNum($('#txtTotalCharge').val()) + CNum($('#txtTotalVat').val()) - CNum($('#txtTotal50Tavi').val()) - CNum($('#txtTotalCustAdv').val());
        $('#txtTotalNet').val(totalnet);

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
        if ($('#txtBillToCustCode').val() == '') {
            ShowMessage('Please select billing Place');
            return;
        }
        let dataInv = {
            BranchCode:$('#txtBranchCode').val(),
            BillAcceptNo: $('#txtDocNo').val(),
            BillDate: CDateTH($('#txtDocDate').val()),
            CustCode:$('#txtBillToCustCode').val(),
            CustBranch:$('#txtBillToCustBranch').val(),
            BillRecvBy: '',
            BillRecvDate: null,
            DuePaymentDate:null,
            BillRemark:'',
            CancelReson:'',
            CancelProve:'',
            CancelDate:null,
            CancelTime: null,
            EmpCode: user,
            RecDateTime:CDateTH(GetToday())
        };
        let jsonString = JSON.stringify({ data: dataInv });
        $.ajax({
            url: "@Url.Action("SetBillHeader", "Acc")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                if (response.result.data !== null) {
                    SaveDetail(response.result.data);
                    return;
                }
                ShowMessage(response.result.msg);
            },
            error: function (e) {
                ShowMessage(e);
            }
        });
        return;
    }
    function SaveDetail(docno) {
        $('#txtDocNo').val(docno);
        let list = GetDataDetail(arr,docno);
        let jsonText = JSON.stringify({ data: list });
            //ShowMessage(jsonText);
            $.ajax({
                url: "@Url.Action("SetBillDetail", "Acc")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.data !== null) {
                        ShowMessage(response.result.msg+'\n->'+response.result.data);
                        SetGridAdv(false);
                        $('#btnGen').hide();
                        return;
                    }
                    ShowMessage(response.result.msg);
                },
                error: function (e) {
                    ShowMessage(e);
                }
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
        //ShowCustomer(path, dt.CustCode, dt.Branch, '#txtCustName');
        $('#txtBillToCustName').val(dt.NameThai);
        $('#txtCustName').val(dt.NameThai);
        $('#txtBillToCustCode').val(dt.CustCode);
        $('#txtBillToCustBranch').val(dt.Branch);

        $('#txtCustCode').focus();
    }
    function ReadBilling(dt) {
        $('#txtBillToCustCode').val(dt.CustCode);
        $('#txtBillToCustBranch').val(dt.Branch);
        ShowCustomer(path, dt.CustCode, dt.Branch, '#txtBillToCustName');
    }

    function GetDataDetail(o, no) {
        let data = [];
        let i = 0;
        for (let obj of o) {
            //if (obj.TotalNet !== 0) {
                i = i + 1;
                data.push({
                    BranchCode: obj.BranchCode,
                    BillAcceptNo: no,
                    ItemNo: i,
                    InvNo: obj.DocNo,
                    InvDate: obj.DocDate,
                    RefNo:obj.RefNo,
                    CurrencyCode: obj.CurrencyCode,
                    ExchangeRate: obj.ExchangeRate,
                    AmtAdvance: obj.TotalAdvance,
                    AmtChargeNonVAT: CNum(obj.TotalCharge)-CNum(obj.TotalIsTaxChange),
                    AmtChargeVAT: obj.TotalIsTaxCharge,
                    AmtVAT: obj.TotalVAT,
                    AmtVATRate:obj.VATRate,
                    AmtWH: obj.Total50Tavi,
                    AmtWHRate: Number(obj.Total50Tavi) > 0 ? Number(obj.TotalCharge) / Number(obj.Total50Tavi) : 0,
                    AmtTotal: obj.TotalNet,
                    AmtCustAdvance: obj.TotalCustAdv,
                    AmtDiscount: obj.TotalDiscount,
                    AmtDiscRate: obj.DiscountRate,
                    AmtForeign: obj.ForeignNet
                });
            //}
        }
        return data;
    }

    function PrintBilling() {
        let code = $('#txtDocNo').val();
        if (code !== '') {
            let branch = $('#txtBranchCode').val();
            window.open(path + 'Acc/FormBill?Branch=' + branch + '&Code=' + code);
        }
    }

</script>