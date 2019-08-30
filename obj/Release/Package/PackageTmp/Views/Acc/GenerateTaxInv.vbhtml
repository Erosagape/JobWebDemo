@Code
    ViewBag.Title = "สร้างใบกำกับภาษี/ใบเสร็จรับเงิน"
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
            <div class="col-sm-4">
                Type :<br />
                <select id="cboType" class="form-control dropdown">
                    <option value="TAX" selected>Tax-Invoice (Vatable+Advance)</option>
                    <option value="SRV" selected>Tax-Invoice (Vatable only)</option>
                    <option value="REC">Receipt (Non-Vat only)</option>
                    <option value="RCV">Receipt (Non-Vat+Advance)</option>
                </select>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                Customer:<input type="checkbox" id="chkBilling">Search For Billing Place
                <br />
                <div style="display:flex;flex-direction:row">
                    <input type="text" id="txtCustCode" style="width:120px" />
                    <input type="text" id="txtCustBranch" style="width:50px" />
                    <button id="btnBrowseCust" class="btn btn-default" onclick="SearchData('customer')">...</button>
                    <input type="text" id="txtCustName" style="width:100%" disabled />
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
        <a href="#" class="btn btn-primary" id="btnSearch" onclick="SetGridAdv(true)">
            <i class="fa fa-lg fa-filter"></i>&nbsp;<b>Search</b>
        </a>
        <div class="row">
            <div class="col-sm-12">
                <table id="tbHeader" class="table table-responsive">
                    <thead>
                        <tr>
                            <th>DocNo</th>
                            <th class="desktop">DocDate</th>
                            <th class="desktop">CustCode</th>
                            <th class="desktop">Remark</th>
                            <th class="all">Desc</th>
                            <th class="desktop">Service</th>
                            <th class="desktop">Vat</th>
                            <th class="desktop">Wh-tax</th>
                            <th class="all">Net</th>
                        </tr>
                    </thead>
                </table>
                <br />
                <a href="#" class="btn btn-success" id="btnGen" onclick="ShowSummary()">
                    <i class="fa fa-lg fa-save"></i>&nbsp;<b>Create Tax-Invoice</b>
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
                </div>
                <div class="modal-body">
                    <b>Receipt Summary:</b><br />
                    Total Advance:<input type="text" id="txtTotalAdvance" disabled />
                    Total Service:<input type="text" id="txtTotalCharge" disabled />
                    Total VAT:<input type="text" id="txtTotalVAT" disabled />
                    Total WH-Tax:<input type="text" id="txtTotal50Tavi" disabled />
                    Receive Total:<input type="text" id="txtTotalNet" disabled />
                    <div class="row">
                        <div class="col-sm-3">
                            <input type="checkbox" id="chkMerge" checked /> Generate One Tax-Invoice<br />
                            <div id="dvMsg"></div>
                            <a href="#" class="btn btn-default w3-purple" id="btnGen" onclick="ApproveData()">
                                <i class="fa fa-lg fa-save"></i>&nbsp;<b>Save Tax-Invoice</b>
                            </a>
                        </div>
                        <div class="col-sm-9">
                            <b>Invoice Detail:</b><br />
                            <table id="tbDetail" style="width:100%;">
                                <thead>
                                    <tr>
                                        <th>InvNo</th>
                                        <th class="desktop">InvDate</th>
                                        <th class="desktop">Item</th>
                                        <th class="desktop">Code</th>
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
                    </div>
                    Tax-Invoice No : <input type="text" id="txtDocNo" disabled /><br />
                    <a href="#" class="btn btn-info" id="btnPrint" onclick="PrintReceipt()">
                        <i class="fa fa-lg fa-print"></i>&nbsp;<b>Print Tax-Invoice</b>
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
    function ShowMessage(str) {
        $('#dvMsg').append('<br/>' + str);
    }
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
        let type = $('#cboType').val();
        $.get(path + 'acc/getinvforreceive?show=WAIT&type='+type+'&branch=' + $('#txtBranchCode').val() + w, function (r) {
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
                    { data: "Amt", title: "Charges" },
                    { data: "AmtVAT", title: "Vat" },
                    { data: "Amt50Tavi", title: "W-Tax" },
                    { data: "Net", title: "Net" }
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
        let totalvat = 0;
        let totaltax = 0;
        let totalnet = 0;

        for (let obj of arr) {
            totaladv += (obj.AmtAdvance > 0 ? Number(obj.Amt) : 0);
            totalcharge += (obj.AmtCharge > 0 ? Number(obj.Amt) : 0);
            totalvat += Number(obj.AmtVAT);
            totaltax += Number(obj.Amt50Tavi);
            totalnet += Number(obj.Net);
        }
        $('#txtTotalAdvance').val(CDbl(totaladv, 2));;
        $('#txtTotalCharge').val(CDbl(totalcharge, 2));;
        $('#txtTotalVAT').val(CDbl(totalvat, 2));;
        $('#txtTotal50Tavi').val(CDbl(totaltax, 2));;
        $('#txtTotalNet').val(CDbl(totalnet, 2));;

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
                { data: "Amt", title: "Charge" },
                { data: "AmtVAT", title: "Vat" },
                { data: "Amt50Tavi", title: "W-Tax" },
                { data: "Net", title: "NET" }
            ],
            responsive:true,
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
    function ApproveData() {
        if ($('#txtCustCode').val() == '') {
            ShowMessage('Please select Customer');
            return;
        }
        if ($('#txtBillToCustCode').val() == '') {
            ShowMessage('Please select Billing Place first');
            return;
        }
        if ($('#chkMerge').prop('checked') == true) {
            let dataInv = {
                BranchCode: $('#txtBranchCode').val(),
                ReceiptNo: $('#txtDocNo').val(),
                ReceiptDate: CDateEN($('#txtDocDate').val()),
                ReceiptType: $('#cboType').val(),
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
                TotalVAT: $('#txtTotalVAT').val(),
                Total50Tavi: $('#txtTotal50Tavi').val(),
                TotalNet: $('#txtTotalNet').val(),
                FTotalNet: $('#txtTotalNet').val()
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
                    ShowMessage(response.result.msg);
                },
                error: function (e) {
                    ShowMessage(e);
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
            ReceiptType: $('#cboType').val(),
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
            TotalVAT: $('#txtTotalVAT').val(),
            Total50Tavi: $('#txtTotal50Tavi').val(),
            TotalNet: $('#txtTotalNet').val(),
            FTotalNet: $('#txtTotalNet').val()
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
            //ShowMessage(jsonText);
            $.ajax({
                url: "@Url.Action("SaveRcpDetail", "Acc")",
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
            window.open(path + 'Acc/FormTaxInv?Branch=' + branch + '&Code=' + code,'_blank');
        }
    }

</script>