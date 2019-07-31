@Code
    ViewBag.Title = "สร้างใบเสร็จรับเงิน"
End Code
<div class="panel-body">
    <div class="container">
        <div class="row">
            <div class="col-sm-4">
                <a href="#" onclick="SearchData('branch')"> Branch :</a><br />
                <input type="text" id="txtBranchCode" style="width:50px" />
                <input type="text" id="txtBranchName" style="width:200px" disabled />
            </div>
            <div class="col-sm-2">
                Invoice Date From:<br />
                <input type="date" id="txtDocDateF" />
            </div>
            <div class="col-sm-2">
                Invoice Date To:<br />
                <input type="date" id="txtDocDateT" />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                <a href="#" onclick="SearchData('customer')"> Customer :</a><br />
                <input type="text" id="txtCustCode" style="width:120px" />
                <input type="text" id="txtCustBranch" style="width:50px" />
                <input type="text" id="txtCustName" style="width:300px" disabled />
            </div>
            <div class="col-sm-4">
                <input type="checkbox" id="chkBilling" class="checkbox">Use Billing Place<br />
            </div>
        </div>
        <button class="btn btn-warning" id="btnRefresh" onclick="SetGridAdv(true)">Show</button>
        <div class="row">
            <div class="col-sm-12">
                <table id="tbHeader" class="table table-responsive">
                    <thead>
                        <tr>
                            <th>DocNo</th>
                            <th>DocDate</th>
                            <th>CustCode</th>
                            <th>Remark</th>
                            <th>Desc</th>
                            <th>Advance</th>
                        </tr>
                    </thead>
                </table>
                <br />
                <input type="button" class="btn btn-success" value="Create Receipt" onclick="ShowSummary()" />
            </div>
        </div>
    </div>
    <div id="dvCreate" class="modal modal-lg fade" role="dialog">
        <div class="modal-dialog-lg">
            <div class="modal-content">
                <div class="modal-header">
                    <table>
                        <tr>
                            <td style="width:10%">
                                Receipt Date :<br />
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
                    <button id="btnHide" class="btn btn-danger" data-dismiss="modal">Close</button>
                </div>
                <div class="modal-body">
                    <b>Receipt Summary:</b><br />
                    Total Advance:<input type="text" id="txtTotalAdvance" disabled />
                    <div class="row">
                        <div class="col-sm-3">
                            <input type="checkbox" id="chkMerge" checked /> Generate One Receipt<br />
                            <button id="btnGen" class="btn btn-success" onclick="ApproveData()">Save Receipt</button><br />
                            <div id="dvMsg"></div>
                        </div>
                        <div class="col-sm-9">
                            <b>Invoice Detail:</b><br />
                            <table id="tbDetail" style="width:100%;">
                                <thead>
                                    <tr>
                                        <th>InvNo</th>
                                        <th>InvDate</th>
                                        <th>Item</th>
                                        <th>Code</th>
                                        <th>Description</th>
                                        <th>Advance</th>
                                    </tr>
                                </thead>
                                <tbody></tbody>
                            </table>
                        </div>
                    </div>
                    Receipt No : <input type="text" id="txtDocNo" ondblclick="PrintReceipt()" disabled /><br />
                    <input type="button" onclick="PrintReceipt()" class="btn btn-default" value="Print Billing" />
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
    let arr = [];
    let dtl_list = [];
    let resp_count = 0;
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
    //$(document).ready(function () {
        SetEvents();
    //});
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
        if ($('#chkBilling').prop('checked') == true) {
            if ($('#txtCustCode').val() !== "") {
                w = w + '&billto=' + $('#txtCustCode').val();
            }
            if ($('#txtDocDateF').val() !== "") {
                w = w + '&BillDateFrom=' + CDateEN($('#txtDocDateF').val());
            }
            if ($('#txtDocDateT').val() !== "") {
                w = w + '&BillDateTo=' + CDateEN($('#txtDocDateT').val());
            }
        } else {
            if ($('#txtCustCode').val() !== "") {
                w = w + '&cust=' + $('#txtCustCode').val();
            }
            if ($('#txtDocDateF').val() !== "") {
                w = w + '&DateFrom=' + CDateEN($('#txtDocDateF').val());
            }
            if ($('#txtDocDateT').val() !== "") {
                w = w + '&DateTo=' + CDateEN($('#txtDocDateT').val());
            }
        }

        $.get(path + 'acc/getinvforreceive?show=WAIT&type=ADV&branch=' + $('#txtBranchCode').val() + w, function (r) {
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
                    { data: "InvoiceNo", title: "Inv No" },
                    {
                        data: "InvoiceDate", title: "Inv date ",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "BillToCustCode", title: "Billing To" },
                    { data: "RefNo", title: "Reference Number" },
                    { data: "SDescription", title: "Expenses" },
                    { data: "Amt", title: "Advance" }
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
        });
    }
    function ShowSummary() {
        if ($('#txtCustCode').val() == '') {
            alert('Please select Customer first');
            return;
        }

        if (arr.length == 0) {
            alert('no data to approve');
            return;
        }
        let totaladv = 0;


        for (let obj of arr) {
            totaladv += obj.Amt;
        }
        $('#txtTotalAdvance').val(CDbl(totaladv, 2));;

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
                { data: "InvoiceNo", title: "Doc No" },
                {
                    data: "InvoiceDate", title: "Inv date ",
                    render: function (data) {
                        return CDateEN(data);
                    }
                },
                { data: "ItemNo", title: "Item No" },
                { data: "SICode", title: "Code" },
                { data: "SDescription", title: "Description" },
                { data: "Amt", title: "Advance" }
            ],
            destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
        });
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
    function ShowMessage(str) {
        $('#dvMsg').append('<br/>' + str);
    }
    function ApproveData() {
        if ($('#txtCustCode').val() == '') {
            alert('Please select Customer');
            return;
        }
        if ($('#txtBillToCustCode').val() == '') {
            alert('Please select Billing Place first');
            return;
        }
        if ($('#chkMerge').prop('checked') == true) {
            let dataInv = {
                BranchCode: $('#txtBranchCode').val(),
                ReceiptNo: $('#txtDocNo').val(),
                ReceiptDate: CDateEN($('#txtDocDate').val()),
                ReceiptType: 'ADV',
                CustCode: $('#txtCustCode').val(),
                CustBranch: $('#txtCustBranch').val(),
                BillToCustCode: $('#txtBillToCustCode').val(),
                BillToCustBranch: $('#txtBillToCustBranch').val(),
                TRemark: '',
                EmpCode: user,
                PrintedBy: '',
                PrintedDate: null,
                PrintedTime: null,
                ReceiveBy: '',
                ReceiveDate: null,
                ReceiveRef: '',
                CancelReson: '',
                CancelProve: '',
                CancelDate: null,
                CancelTime: null,
                CurrencyCode: '@ViewBag.PROFILE_CURRENCY',
                ExchangeRate: 1,
                TotalCharge: $('#txtTotalAdvance').val(),
                TotalVAT: 0,
                Total50Tavi: 0,
                TotalNet: $('#txtTotalAdvance').val(),
                FTotalNet: $('#txtTotalAdvance').val()
            };
            let jsonString = JSON.stringify({ data: dataInv });
            $.ajax({
                url: "@Url.Action("SetRcpHeader", "Acc")",
                type: "POST",
                contentType: "application/json",
                data: jsonString,
                success: function (response) {
                    if (response.result.data !== null) {
                        SaveDetail(response.result.data);
                        return;
                    }
                    alert(response.result.msg);
                },
                error: function (e) {
                    alert(e);
                }
            });
        } else {
            sortData(arr, 'InvoiceNo', 'asc');
            let rowProcess = 0;
            let currInv = '';
            let dtl = [];
            dtl_list = [];
            resp_count = 0;
            $('#dvMsg').html('');
            for (let obj of arr) {
                rowProcess += 1;
                if (currInv !== obj.InvoiceNo) {
                    if (dtl.length > 0) {
                        let data = JSON.parse(JSON.stringify(dtl));
                        SaveHeaderByInv(data,currInv);
                    }
                    currInv = obj.InvoiceNo;
                    dtl = [];
                }
                dtl.push(obj);
                if (rowProcess == arr.length) {
                    let data = JSON.parse(JSON.stringify(dtl));
                    SaveHeaderByInv(data,currInv);
                }
            }
        }
        return;
    }
    function SaveHeaderByInv(dt,inv) {
        dtl_list.push({
            docno:inv,
            data: dt
        });
        let dataInv = {
            BranchCode: $('#txtBranchCode').val(),
            ReceiptNo: $('#txtDocNo').val(),
            ReceiptDate: CDateEN($('#txtDocDate').val()),
            ReceiptType: 'ADV',
            CustCode: $('#txtCustCode').val(),
            CustBranch: $('#txtCustBranch').val(),
            BillToCustCode: $('#txtBillToCustCode').val(),
            BillToCustBranch: $('#txtBillToCustBranch').val(),
            TRemark: '',
            EmpCode: user,
            PrintedBy: '',
            PrintedDate: null,
            PrintedTime: null,
            ReceiveBy: '',
            ReceiveDate: null,
            ReceiveRef: '',
            CancelReson: '',
            CancelProve: '',
            CancelDate: null,
            CancelTime: null,
            CurrencyCode: '@ViewBag.PROFILE_CURRENCY',
            ExchangeRate: 1,
            TotalCharge: $('#txtTotalAdvance').val(),
            TotalVAT: 0,
            Total50Tavi: 0,
            TotalNet: $('#txtTotalAdvance').val(),
            FTotalNet: $('#txtTotalAdvance').val()
        };
        let jsonString = JSON.stringify({ data: dataInv });
        $.ajax({
            url: "@Url.Action("SetRcpHeader", "Acc")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                if (response.result.data !== null) {
                    SaveDetailFromArray(response.result.data, resp_count);
                    resp_count +=1;
                    return;
                }
                ShowMessage(response.result.msg);
            },
            error: function (e) {
                ShowMessage(e);
            }
        });
    }
    function SaveDetail(docno) {
        $('#txtDocNo').val(docno);
        let list = GetDataDetail(arr,docno);
        let jsonText = JSON.stringify({ data: list });
            //alert(jsonText);
        $.ajax({
            url: "@Url.Action("SaveRcpDetail", "Acc")",
            type: "POST",
            contentType: "application/json",
            data: jsonText,
            success: function (response) {
                if (response.result.data !== null) {
                    alert(response.result.msg+'\n->'+response.result.data);
                    SetGridAdv(false);
                    $('#btnGen').hide();
                    return;
                }
                alert(response.result.msg);
            },
            error: function (e) {
                alert(e);
            }
        });
    }
    function SaveDetailFromArray(docno) {
        let list = GetDataDetail(dtl_list[resp_count].data,docno);
        let jsonText = JSON.stringify({ data: list });
        $.ajax({
            url: "@Url.Action("SaveRcpDetail", "Acc")",
            type: "POST",
            contentType: "application/json",
            data: jsonText,
            success: function (response) {
                if (response.result.data !== null) {
                    ShowMessage(response.result.msg + '=>' + response.result.data);
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
        $('#txtCustName').val(dt.NameThai);


        $('#txtCustCode').focus();
    }
    function ReadBilling(dt) {
        $('#txtBillToCustCode').val(dt.CustCode);
        $('#txtBillToCustBranch').val(dt.Branch);
        $('#txtBillToCustName').val(dt.NameThai);
    }

    function GetDataDetail(o, no) {
        let data = [];
        let i = 0;
        for (let obj of o) {
            if (obj.TotalNet !== 0) {
                i = i + 1;
                data.push({
                    BranchCode: obj.BranchCode,
                    ReceiptNo: no,
                    ItemNo: i,
                    CreditAmount: obj.CreditAmount,
                    CashAmount: obj.CashAmount,
                    TransferAmount: obj.TransferAmount,
                    ChequeAmount: obj.ChequeAmount,
                    ControlNo: obj.ControlNo,
                    VoucherNo: obj.VoucherNo,
                    ControlItemNo:obj.ControlItemNo,
                    InvoiceNo: obj.InvoiceNo,
                    InvoiceItemNo: obj.InvoiceItemNo,
                    SICode: obj.SICode,
                    SDescription: obj.SDescription,
                    VATRate: obj.VATRate,
                    Rate50Tavi: obj.Rate50Tavi,
                    Amt: obj.Amt,
                    AmtVAT: obj.AmtVAT,
                    Amt50Tavi: obj.Amt50Tavi,
                    Net: obj.Net,
                    DCurrencyCode: obj.DCurrencyCode,
                    DExchangeRate: obj.DExchangeRate,
                    FAmt: obj.FAmt,
                    FAmtVAT: obj.FAmtVAT,
                    FAmt50Tavi: obj.FAmt50Tavi,
                    FNet:obj.FNet
                });
            }
        }
        return data;
    }

    function PrintReceipt() {
        let code = $('#txtDocNo').val();
        if (code !== '') {
            let branch = $('#txtBranchCode').val();
            window.open(path + 'Acc/FormRcp?Branch=' + branch + '&Code=' + code,'_blank');
        }
    }

</script>