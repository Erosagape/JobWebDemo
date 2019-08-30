
@Code
    ViewBag.Title = "บันทึกบิลค่าใช้จ่าย"
End Code
<div class="panel-body">
    <div id="dvHeader" class="container">
        <div class="row">
            <div class="col-sm-5">
                Branch:
                <br />
                <div style="display:flex;flex-direction:row">
                    <input type="text" class="form-control" id="txtBranchCode" style="width:15%" disabled />
                    <input type="button" class="btn btn-default" value="..." onclick="SearchData('branch');" />
                    <input type="text" class="form-control" id="txtBranchName" style="width:65%" disabled />
                </div>
            </div>
            <div class="col-sm-4" style="text-align:left">
                <b>Payment No:</b>
                <br />
                <div style="display:flex;flex-direction:row">
                    <input type="text" class="form-control" id="txtDocNo" style="font-weight:bold;font-size:20px;text-align:center;background-color:navajowhite;color:brown" tabindex="1" />
                    <input type="button" class="btn btn-default" value="..." onclick="SearchData('payment')" />
                </div>
            </div>
            <div class="col-sm-3">
                Due Date :<br />
                <input type="date" class="form-control" id="txtDocDate" tabindex="1" />
            </div>
        </div>
        <ul class="nav nav-tabs">
            <li class="active"><a data-toggle="tab" href="#tabHeader">Header</a></li>
            <li><a data-toggle="tab" href="#tabDetail">Detail</a></li>
        </ul>
        <div class="tab-content">
            <div id="tabHeader" class="tab-pane fade in active">
                <div class="row">
                    <div class="col-sm-7">
                        <table>
                            <tr>
                                <td>
                                    Entry By :
                                </td>
                                <td>
                                    <input type="text" id="txtEmpCode" style="width:100px" tabindex="2" />
                                    <button id="btnBrowseEmp1" onclick="SearchData('user')">...</button>
                                    <input type="text" id="txtEmpName" style="width:300px" disabled />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Vender :
                                </td>
                                <td>
                                    <input type="text" id="txtVenCode" style="width:170px" tabindex="4" />
                                    <button id="btnBrowseCust" onclick="SearchData('vender')">...</button>
                                    <input type="text" id="txtVenName" style="width:300px" tabindex="5" disabled />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Contact  :
                                </td>
                                <td>
                                    <input type="text" id="txtContactName" style="width:400px" />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div class="col-sm-5">
                        <table>
                            <tr>
                                <td>
                                    Ref No.1:
                                </td>
                                <td>
                                    <input type="text" id="txtRefNo" style="width:200px" tabindex="6" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Ref No.2:
                                </td>
                                <td>
                                    <input type="text" id="txtPoNo" style="width:200px" tabindex="7" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Total Document:
                                </td>
                                <td>
                                    <input type="text" id="txtForeignAmt" style="width:100px;text-align:right" />
                                </td>
                            </tr>
                        </table>
                    </div>                    
                </div>
                <div class="row">
                    <div class="col-sm-7">
                        Remark:
                        <textarea id="txtRemark" style="width:100%;height:80px" tabindex="8"></textarea>
                    </div>
                    <div class="col-sm-5">
                        <a onclick="SearchData('currency')">Currency:</a>
                        <input type="text" id="txtCurrencyCode" style="width:100px" value="@ViewBag.PROFILE_CURRENCY" disabled />
                        <br />
                        Exchange Rate:
                        <input type="text" id="txtExchangeRate" style="width:50px" value="1" />
                        <br />
                        <buttom id="btnGetExcRate" class="btn btn-warning" onclick="GetExchangeRate()">Get Rate</buttom>                                                
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-7" style="border-style:solid;border-width:1px;color:red">
                        <input type="checkbox" id="chkCancel" />
                        <label for="chkCancel">Cancel By</label>
                        <input type="text" id="txtCancelProve" style="width:250px" disabled />
                        <br />
                        Date:
                        <input type="date" id="txtCancelDate" disabled />
                        Time:
                        <input type="text" id="txtCancelTime" style="width:80px" disabled />
                        <br />
                        Cancel Reason :<input type="text" id="txtCancelReson" style="width:250px" />
                    </div>
                    <div class="col-sm-5">
                        VAT Rate :<input type="text" id="txtVATRate" style="width:50px" /><br />
                        TAX Rate :<input type="text" id="txtTaxRate" style="width:50px" /><br />
                        Pay Type :<select id="txtPayType"></select>
                    </div>
                </div>
                <div id="dvCommand">
                    <a href="#" class="btn btn-default w3-purple" id="btnAdd" onclick="AddHeader()">
                        <i class="fa fa-lg fa-file-o"></i>&nbsp;<b>Clear Data</b>
                    </a>
                    <a href="#" class="btn btn-success" id="btnSave" onclick="SaveHeader()">
                        <i class="fa fa-lg fa-save"></i>&nbsp;<b>Save Data</b>
                    </a>
                </div>
            </div>
            <div id="tabDetail" class="tab-pane fade">
                <div class="row">
                    <div class="col-sm-12">
                        <table id="tbDetail" class="table table-responsive">
                            <thead>
                                <tr>
                                    <th>
                                    <th>SICode</th>
                                    <th class="all">Description</th>
                                    <th class="desktop">Qty</th>
                                    <th class="desktop">Price</th>
                                    <th class="desktop">Amount</th>
                                    <th class="desktop">Vat</th>
                                    <th class="desktop">WH-Tax</th>
                                    <th class="all">Net</th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-9">
                        <a href="#" class="btn btn-default w3-purple" id="btnAdd" onclick="AddDetail()">
                            <i class="fa fa-lg fa-file-o"></i>&nbsp;<b>Add Detail</b>
                        </a>
                        <a href="#" class="btn btn-danger" id="btnDel" onclick="DeleteDetail()">
                            <i class="fa fa-lg fa-trash"></i>&nbsp;<b>Delete Detail</b>
                        </a>
                    </div>
                    <div class="col-sm-3" style="text-align:right">
                        Amount :
                        <input type="text" id="txtTotalExpense" style="width:100px;text-align:right" /><br />
                        VAT :
                        <input type="text" id="txtTotalVAT" style="width:100px;text-align:right" /><br />
                        WHT :
                        <input type="text" id="txtTotalTax" style="width:100px;text-align:right" /><br />
                        Discount :
                        <input type="text" id="txtTotalDiscount" style="width:100px;text-align:right" /><br />
                        Total :
                        <input type="text" id="txtTotalNet" style="width:100px;text-align:right" />
                    </div>
                </div>

            </div>
            <div id="frmDetail" class="modal fade" role="dialog">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal"></button>
                            <h4 class="modal-title"><label id="lblHeader">Detail</label></h4>
                        </div>
                        <div class="modal-body">
                            <label for="txtItemNo">No :</label>
                            <input type="text" id="txtItemNo" style="width:40px" disabled />
                            <br />
                            <label for="txtSICode">Code :</label>
                            <input type="text" id="txtSICode" style="width:80px" tabindex="12" />
                            <input type="button" id="btnBrowseS" value="..." onclick="SearchData('service')" />
                            Description : <input type="text" id="txtSDescription" style="width:230px" tabindex="13" />
                            <br />
                            <label for="txtQty">Qty:</label>
                            <input type="text" id="txtQty" style="width:100px;text-align:right" tabindex="14" />
                            Unit :
                            <input type="text" id="txtQtyUnit" style="width:100px;text-align:right" tabindex="15" />
                            <label id="lblUnitPrice" for="txtUnitPrice">Price :</label>
                            <input type="text" id="txtUnitPrice" style="width:100px;text-align:right" tabindex="16" />
                            <br />
                            <label id="lblAmount" for="txtAmt">Amount :</label>
                            <input type="text" id="txtAmt" style="width:100px;text-align:right" tabindex="17" />
                            Discount <input type="text" id="txtDiscountPerc" style="width:50px" onchange="CalDiscount()" tabindex="18" />
                            <input type="text" id="txtAmtDisc" tabindex="19" onchange="CalTotal()" />
                            <br />
                            <input type="checkbox" id="txtIsTaxCharge" onclick="CalVATWHT()"> VAT :
                            <input type="text" id="txtAmtVAT" style="width:100px;text-align:right" tabindex="20" />
                            <input type="checkbox" id="txtIs50Tavi" onclick="CalVATWHT()">WH-Tax :
                            <input type="text" id="txtAmtWHT" style="width:100px;text-align:right" tabindex="21" />
                            <br />
                            <label id="lblNETAmount" for="txtTotal">Total :</label>
                            <input type="text" id="txtTotal" style="width:100px;text-align:right" tabindex="22" />
                            Total(F) :
                            <input type="text" id="txtFTotal" style="width:100px;text-align:right" disabled />
                            <br />
                            Remark : <input type="text" id="txtSRemark" style="width:230px" tabindex="23" />
                            <br />
                            Job No : <input type="text" id="txtForJNo" style="width:230px" tabindex="24" />
                        </div>
                        <div class="modal-footer">
                            <div style="float:left">
                                <a href="#" class="btn btn-default w3-purple" id="btnAddDet" onclick="AddDetail()">
                                    <i class="fa fa-lg fa-file-o"></i>&nbsp;<b>New</b>
                                </a>
                                <a href="#" class="btn btn-success" id="btnSaveDet" onclick="SaveDetail()">
                                    <i class="fa fa-lg fa-save"></i>&nbsp;<b>Save</b>
                                </a>
                            </div>
                            <button id="btnHide" class="btn btn-danger" data-dismiss="modal">X</button>
                        </div>
                    </div>
                </div>
            </div>
            <div id="frmHeader" class="modal modal-lg fade">
                <div class="modal-dialog-lg">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal"></button>
                            <h4 class="modal-title"><label id="lblHeader">Billing Payment</label></h4>
                        </div>
                        <div class="modal-body">
                            <table id="tbHeader" class="table table-responsive">
                                <thead>
                                    <tr>
                                        <th>DocNo</th>
                                        <th class="desktop">DocDate</th>
                                        <th class="desktop">VenCode</th>
                                        <th class="desktop">EmpCode</th>
                                        <th class="all">Ref</th>
                                        <th class="desktop">PoNo</th>
                                        <th class="desktop">Amount</th>
                                        <th class="desktop">WT</th>
                                        <th class="desktop">VAT</th>
                                        <th class="all">NET</th>
                                    </tr>
                                </thead>
                            </table>
                        </div>
                        <div class="modal-footer">
                            <button id="btnHide" class="btn btn-danger" data-dismiss="modal">X</button>
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
    const path = '@Url.Content("~")';
    const user = '@ViewBag.User';
    const userRights = '@ViewBag.UserRights';
    let serv = []; //must be array of object
    let hdr = {}; //simple object
    let dtl = {}; //simple object
    let job = '';
    let isjobmode = false;
    let chkmode = false;
    //$(document).ready(function () {
    SetLOVs();
    SetEvents();
    SetEnterToTab();
    CheckParam();
    //});
    function CheckParam() {
        ClearHeader();
        //read query string parameters
        let br = getQueryString('BranchCode');
        if (br.length>0) {
            $('#txtBranchCode').val(br);
            ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            let ano = getQueryString('DocNo');
            if (ano.length > 0) {
                $('#txtDocNo').val(ano);
                ShowData(br, $('#txtDocNo').val());
            } 
        } else {
            $('#txtBranchCode').val('@ViewBag.PROFILE_DEFAULT_BRANCH');
            $('#txtBranchName').val('@ViewBag.PROFILE_DEFAULT_BRANCH_NAME');
        }
    }
    function SetEnterToTab() {
        //Set enter to tab
        $("input[tabindex], select[tabindex], textarea[tabindex]").each(function () {
            $(this).on("keypress", function (e) {
                if (e.keyCode === 13) {
                    let idx = (this.tabIndex + 1);
                    let nextElement = $('[tabindex="' + idx + '"]');
                    while (nextElement.length) {
                        if (nextElement.prop('disabled') == false) {
                            $('[tabindex="' + idx + '"]').focus();
                            e.preventDefault();
                            return;
                        } else {
                            idx = idx + 1;
                            nextElement = $('[tabindex="' + idx + '"]');
                        }
                    }
                    $('[tabindex="0"]').focus();
                }
            });
        });
    }
    function SetEvents() {
        if (userRights.indexOf('I') < 0) $('#btnNew').attr('disabled', 'disabled');
        if (userRights.indexOf('I') < 0) $('#btnAdd').attr('disabled', 'disabled');
        if (userRights.indexOf('E') < 0) $('#btnSave').attr('disabled', 'disabled');
        if (userRights.indexOf('E') < 0) $('#btnUpdate').attr('disabled', 'disabled');
        if (userRights.indexOf('D') < 0) $('#btnDel').attr('disabled', 'disabled');
        if (userRights.indexOf('P') < 0) $('#btnPrint').attr('disabled', 'disabled');

        $('#frmDetail').on('shown.bs.modal', function () {
            $('#txtSICode').focus();
        });
        $('#chkCancel').on('click', function () {
            chkmode = this.checked;
            CallBackAuthorize(path, 'MODULE_ACC', 'Expense', 'D', SetCancel);
        });
        $('#txtBranchCode').focusout(function (event) {
            if (true) {
                ShowBranch(path, $('#txtBranchCode').val(), '#txtBranchName');
            }
        });
        $('#txtDocNo').focusout(function (event) {
            if (true) {
                ShowData($('#txtBranchCode').val(),$('#txtDocNo').val());
            }
        });
        $('#txtEmpCode').change(function (event) {
            if (true) {
                ShowUser(path, $('#txtEmpCode').val(), '#txtEmpName');
            }
        });
        $('#txtVenCode').change(function (event) {
            if (true) {
                ShowVender(path, $('#txtVenCode').val(), '#txtVenName');
            }
        });
        $('#txtSICode').change(function (event) {
            if (true) {
                let dt = FindService($('#txtSICode').val())
                ReadService(dt);
            }
        });
        $('#txtQty').change(function (event) {
            if (true) {
                CalAmount();
            }
        });
        $('#txtUnitPrice').change(function (event) {
            if (true) {
                CalAmount();
            }
        });
        $('#txtAmt').change(function (event) {
            if (true) {
                CalVATWHT();
            }
        });
        $('#txtAmtVAT').change(function (event) {
            if (true) {
                CalTotal();
            }
        });
        $('#txtAmtWHT').change(function (event) {
            if (true) {
                CalTotal();
            }
        });
        $('#txtTotal').change(function (event) {
            if (true) {
                let type = $('#txtIsTaxCharge').val();
                if (type == '0'||type=='') type = "1";
                if (type == "2") {
                    CalVATWHT();
                } else {
                    CalTotal();
                }
            }
        });
    }
    function SetCancel(b) {
        if (b == true) {
            ShowConfirm("Do you want to " + (chkmode ? 'cancel' : 're-open') + "?", function (result) {
                if (result == true) {
                    $('#txtCancelProve').val(chkmode ? user : '');
                    $('#txtCancelDate').val(chkmode ? CDateEN(GetToday()) : '');
                    $('#txtCancelTime').val(chkmode ? ShowTime(GetTime()) : '');
                    return;
                }
                $('#chkCancel').prop('checked', !chkmode);
            });
            return;
        }
        ShowMessage('You are not allow to ' + (b ? 'cancel payment!' : 'do this!'));
        $('#chkCancel').prop('checked', !chkmode);
    }
    function SetLOVs() {
        //Combos
        let lists = 'PAYMENT_TYPE=#txtPayType';
        loadCombos(path, lists);

        LoadService();

        //3 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("dvLOVs");
            //Venders
            CreateLOV(dv, '#frmSearchVend', '#tbVend', 'Venders', response,4);
            //Users
            CreateLOV(dv, '#frmSearchEmp', '#tbEmp', 'Entry By', response,4);
            //Branch
            CreateLOV(dv, '#frmSearchBranch', '#tbBranch', 'Branch', response,4);
            //SICode
            CreateLOV(dv, '#frmSearchSICode', '#tbServ', 'Service Code', response,4);
            //Currency
            CreateLOV(dv, '#frmSearchCurr', '#tbCurr', 'Currency Code', response,4);
        });
    }
    function ShowData(branchcode, docno) {
        if (userRights.indexOf('R') < 0) {
            ShowMessage('you are not authorize to view data');
            return;
        }
        $.get(path + 'acc/getpayment?branch'+branchcode+'&code='+ docno, function (r) {
            let h = r.payment.header[0];
            ReadPaymentHeader(h);
            let d = r.payment.detail;
            ReadPaymentDetail(d);
        });
    }
    function SaveHeader() {
        let obj = GetDataHeader();
        if (obj.DocNo == '') {
            if (userRights.indexOf('I') < 0) {
                ShowMessage('you are not authorize to add');
                return;
            }
        }
        if (userRights.indexOf('E') < 0) {
            ShowMessage('you are not authorize to save');
            return;
        }
        let jsonString = JSON.stringify({ data: obj });
        $.ajax({
            url: "@Url.Action("SetPayHeader", "Acc")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                ShowMessage(response.result.msg);
                if (response.result.data !== null) {
                    $('#txtDocNo').val(response.result.data);
                    ShowData($('#txtBranchCode').val(), $('#txtDocNo').val());
                }
            },
            error: function (e) {
                ShowMessage(e);
            }
        });
    }
    function GetDataHeader() {
        let dt = {
            BranchCode:$('#txtBranchCode').val(),
            DocNo:$('#txtDocNo').val(),
            DocDate:CDateTH($('#txtDocDate').val()),
            VenCode:$('#txtVenCode').val(),
            ContactName:$('#txtContactName').val(),
            EmpCode:$('#txtEmpCode').val(),
            PoNo:$('#txtPoNo').val(),
            VATRate:CNum($('#txtVATRate').val()),
            TaxRate:CNum($('#txtTaxRate').val()),
            TotalExpense:CNum($('#txtTotalExpense').val()),
            TotalTax:CNum($('#txtTotalTax').val()),
            TotalVAT:CNum($('#txtTotalVAT').val()),
            TotalDiscount:CNum($('#txtTotalDiscount').val()),
            TotalNet:CNum($('#txtTotalNet').val()),
            Remark:$('#txtRemark').val(),
            CancelReson:$('#txtCancelReson').val(),
            CancelProve:$('#txtCancelProve').val(),
            CancelDate:CDateTH($('#txtCancelDate').val()),
            CancelTime:CDateTH($('#txtCancelTime').val()),
            CurrencyCode:$('#txtCurrencyCode').val(),
            ExchangeRate:CNum($('#txtExchangeRate').val()),
            ForeignAmt:CNum($('#txtForeignAmt').val()),
            RefNo: $('#txtRefNo').val(),
            PayType:$('#txtPayType').val()
        };
        return dt;
    }
    function ReadPaymentHeader(dt) {
        if (dt != undefined) {
            hdr = dt;
            $('#txtDocNo').val(dt.DocNo);
            $('#txtDocDate').val(CDateEN(dt.DocDate));
            $('#txtVenCode').val(dt.VenCode);
            ShowVender(path, dt.VenCode, '#txtVenName');
            $('#txtContactName').val(dt.ContactName);
            $('#txtEmpCode').val(dt.EmpCode);
            ShowUser(path, dt.EmpCode, '#txtEmpName');
            $('#txtPoNo').val(dt.PoNo);
            $('#txtCurrencyCode').val(dt.CurrencyCode);
            $('#txtExchangeRate').val(dt.ExchangeRate);
            $('#txtVATRate').val(dt.VATRate);
            $('#txtTaxRate').val(dt.TaxRate);
            $('#txtTotalExpense').val(dt.TotalExpense);
            $('#txtTotalVAT').val(dt.TotalVAT);
            $('#txtTotalTax').val(dt.TotalTax);
            $('#txtTotalDiscount').val(dt.TotalDiscount);
            $('#txtTotalNet').val(dt.TotalNet);
            $('#txtForeignAmt').val(dt.ForeignAmt);
            $('#txtRemark').val(dt.Remark);
            $('#txtCancelReson').val(dt.CancelReson);
            $('#txtCancelProve').val(dt.CancelProve);
            $('#txtCancelDate').val(CDateEN(dt.CancelDate));
            $('#txtCancelTime').val(ShowTime(dt.CancelTime));
            $('#txtRefNo').val(dt.RefNo);
            $('#txtPayType').val(dt.PayType);
            return;
        }
        ClearHeader();
    }
    function AddHeader() {
        if (userRights.indexOf('I') < 0) {
            ShowMessage('you are not authorize to add');
            return;
        }
        $('#txtDocNo').val('');
        ClearHeader();
    }
    function AddDetail() {
        if ($('#txtDocNo').val() == '') {
            ShowMessage('Please save document before add detail');
            return;
        }
        ClearDetail();
        $('#frmDetail').modal('show');
    }
    function DeleteDetail() {
        if (dtl != undefined) {
            if (userRights.indexOf('D') < 0) {
                ShowMessage('you are not authorize to delete');
                return;
            }
            ShowConfirm('are you sure to delete this data?', function (result) {
                if (result == true) {
                    $.get(path + 'acc/delpaydetail?branch=' + $('#txtBranchCode').val() + '&code=' + $('#txtDocNo').val() + '&item=' + dtl.ItemNo, function (r) {
                        ShowMessage(r.payment.result);
                        ShowData($('#txtBranchCode').val(), $('#txtDocNo').val());
                    });
                }
            });
        } else {
            ShowMessage('No data to delete');
        }
    }
    function ClearHeader() {
        hdr = {};
        //$('#txtDocNo').val('');
        $('#txtDocDate').val(GetToday());
        $('#txtVenCode').val('');
        $('#txtVenName').val('');
        $('#txtContactName').val('');
        $('#txtEmpCode').val(user);
        ShowUser(path, user, '#txtEmpName');
        $('#txtPoNo').val('');
        $('#txtCurrencyCode').val('@ViewBag.PROFILE_CURRENCY');
        $('#txtExchangeRate').val('1');
        $('#txtVATRate').val(CDbl(CNum('@ViewBag.PROFILE_VATRATE')*100,0));
        $('#txtTaxRate').val('0');
        $('#txtTotalExpense').val('0');
        $('#txtTotalVAT').val('0');
        $('#txtTotalTax').val('0');
        $('#txtTotalDiscount').val('0');
        $('#txtTotalNet').val('0');
        $('#txtForeignAmt').val('0');
        $('#txtRemark').val('');
        $('#txtCancelReson').val('');
        $('#txtCancelProve').val('');
        $('#txtCancelDate').val('');
        $('#txtCancelTime').val('');
        $('#txtRefNo').val('');
        $('#txtPayType').val('CA');
    }
    function SaveDetail() {

        if (hdr == undefined) {
            ShowMessage('Please add header before');
            return;
        }
        if (hdr.DocNo == '') {
            ShowMessage('Please save header first');
            return;
        }
        let obj = GetDataDetail();
        if (obj.ItemNo == 0) {
            if (userRights.indexOf('I') < 0) {
                ShowMessage('you are not authorize to add');
                return;
            }
        }
        if (userRights.indexOf('E') < 0) {
            ShowMessage('you are not authorize to edit');
            return;
        }
        let jsonString = JSON.stringify({ data: obj });
        //ShowMessage(jsonString);
        $.ajax({
            url: "@Url.Action("SetPayDetail", "Acc")",
            type: "POST",
            contentType: "application/json",
            data: jsonString,
            success: function (response) {
                ShowMessage(response.result.msg);
                ShowData($('#txtBranchCode').val(), $('#txtDocNo').val());
            }
        });
    }
    function ReadPaymentDetail(dt) {
        $('#tbDetail').DataTable({
            data:dt,
            selected: true, //ให้สามารถเลือกแถวได้
            columns: [ //กำหนด property ของ header column
                { data: null, title: "Edit" },
                { data: "SICode", title: "Exp" },
                { data: "SDescription", title: "Description" },
                { data: "Qty", title: "Qty" },
                { data: "UnitPrice", title: "Price" },
                { data: "Amt", title: "Amount" },
                { data: "AmtVAT", title: "Vat" },
                { data: "AmtWHT", title: "WH-Tax" },
                { data: "Total", title: "Net" }
            ],
            "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                {
                    "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                    "data": null,
                    "render": function (data, type, full, meta) {
                        let html = "<button class='btn btn-warning'>Edit</button>";
                        return html;
                    }
                }
            ],
            responsive:true,
            destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
        });
        $('#tbDetail tbody').on('click', 'tr', function () {
            $('#tbDetail tbody > tr').removeClass('selected');
            $(this).addClass('selected');
            let data = $('#tbDetail').DataTable().row(this).data(); //read current row selected
            LoadDetail(data); //callback function from caller
        });
        $('#tbDetail tbody').on('click', 'button', function () {
            $('#frmDetail').modal('show');
            $('#txtSICode').focus();
        });
    }
    function GetDataDetail() {
        let dt = {
            BranchCode: $('#txtBranchCode').val(),
            DocNo: $('#txtDocNo').val(),
            ItemNo: $('#txtItemNo').val(),
            SICode: $('#txtSICode').val(),
            SDescription: $('#txtSDescription').val(),
            SRemark: $('#txtSRemark').val(),
            Qty: $('#txtQty').val(),
            QtyUnit: $('#txtQtyUnit').val(),
            UnitPrice: $('#txtUnitPrice').val(),
            IsTaxCharge: ($('#txtIsTaxCharge').prop('checked') == true ? '1' : '0'),
            Is50Tavi: ($('#txtIs50Tavi').prop('checked') == true ? '1' : '0'),
            DiscountPerc: $('#txtDiscountPerc').val(),
            Amt: $('#txtAmt').val(),
            AmtDisc: $('#txtAmtDisc').val(),
            AmtVAT: $('#txtAmtVAT').val(),
            AmtWHT: $('#txtAmtWHT').val(),
            Total: $('#txtTotal').val(),
            FTotal: $('#txtFTotal').val(),
            ForJNo: $('#txtForJNo').val()
        };
        return dt;
    }
    function LoadDetail(dt) {
        if (dt != undefined) {
            ClearDetail();
            dtl = dt;
            $('#txtItemNo').val(dt.ItemNo);
            $('#txtSICode').val(dt.SICode);
            $('#txtSDescription').val(dt.SDescription);
            $('#txtSRemark').val(dt.SRemark);
            $('#txtQty').val(dt.Qty);
            $('#txtQtyUnit').val(dt.QtyUnit);
            $('#txtUnitPrice').val(dt.UnitPrice);
            $('#txtIsTaxCharge').prop('checked', (dt.IsTaxCharge == 1 ? true : false));
            $('#txtIs50Tavi').prop('checked', (dt.Is50Tavi == 1 ? true : false));
            $('#txtDiscountPerc').val(dt.DiscountPerc);
            $('#txtAmt').val(dt.Amt);
            $('#txtAmtDisc').val(dt.AmtDisc);
            $('#txtAmtVAT').val(dt.AmtVAT);
            $('#txtAmtWHT').val(dt.AmtWHT);
            $('#txtTotal').val(dt.Total);
            $('#txtFTotal').val(dt.FTotal);
            $('#txtForJNo').val(dt.ForJNo);
            return;
        }
        ClearDetail();
    }
    function ClearDetail() {
        dtl = {};
        $('#txtItemNo').val(0);
        $('#txtSICode').val('');
        $('#txtSDescription').val('');
        $('#txtSRemark').val('');
        $('#txtQty').val('1');
        $('#txtQtyUnit').val('');
        $('#txtUnitPrice').val('');
        $('#txtIsTaxCharge').prop('checked', false);
        $('#txtIs50Tavi').prop('checked', false);
        $('#txtDiscountPerc').val('0');
        $('#txtAmt').val('0');
        $('#txtAmtDisc').val('0');
        $('#txtAmtVAT').val('0');
        $('#txtAmtWHT').val('0');
        $('#txtTotal').val('0');
        $('#txtFTotal').val('0');
        $('#txtForJNo').val('');
    }
    function LoadService() {
        if (serv.length==0) {
            $.get(path + 'master/getservicecode')
                .done(function (r) {
                    if (r.servicecode.data.length > 0) {
                        serv = r.servicecode.data;
                    }
                });
        }
    }
    function FindService(Code) {
        let c = $.grep(serv, function (data) {
            return data.SICode === Code;
        });
        return c[0];
    }
    function SetGridAdv() {
        let w = $('#txtBranchCode').val();
        if ($('#txtVenCode').val()!=='') {
            w += '&vencode=' + $('#txtVenCode').val();
        }
        if ($('#txtEmpCode').val() !== '') {
            w += '&empcode=' + $('#txtEmpCode').val();
        }
        $.get(path + 'acc/getpayment?branch=' +  w, function (r) {
            if (r.payment.header.length == 0) {
                ShowMessage('data not found on this branch');
                return;
            }
            let h = r.payment.header;
            $('#tbHeader').DataTable({
                data: h,
                selected: true, //ให้สามารถเลือกแถวได้
                columns: [ //กำหนด property ของ header column
                    { data: "DocNo", title: "Pay.No" },
                    {
                        data: "DocDate", title: "Due Date",
                        render: function (data) {
                            return CDateEN(data);
                        }
                    },
                    { data: "VenCode", title: "Vender" },
                    { data: "ContactName", title: "Contact" },
                    { data: "RefNo", title: "Ref.No" },
                    { data: "PoNo", title: "PO.No" },
                    { data: "TotalExpense", title: "Amount" },
                    { data: "TotalVAT", title: "VAT" },
                    { data: "TotalTax", title: "Tax" },
                    { data: "TotalNet", title: "Net" }
                ],
                responsive:true,
                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
            });
            $('#tbHeader tbody').on('click', 'tr', function () {
                $('#tbHeader tbody > tr').removeClass('selected');
                $(this).addClass('selected');
                let data = $('#tbHeader').DataTable().row(this).data(); //read current row selected
                ShowData(data.BranchCode, data.DocNo); //callback function from caller
                $('#frmHeader').modal('hide');
            });
            $('#frmHeader').on('shown.bs.modal', function () {
                $('#tbHeader_filter input').focus();
            });
            $('#frmHeader').modal('show');
        });
    }
    function SearchData(type) {
        switch (type) {
            case 'payment':
                SetGridAdv();
                break;
            case 'branch':
                SetGridBranch(path, '#tbBranch', '#frmSearchBranch', ReadBranch);
                break;
            case 'user':
                SetGridUser(path, '#tbEmp', '#frmSearchEmp', ReadUser);
                break;
            case 'service':
                SetGridSICodeFilter(path, '#tbServ', '', '#frmSearchSICode', ReadService);
                break;
            case 'currency':
                SetGridCurrency(path, '#tbCurr', '#frmSearchCurr', ReadCurrency);
                break;
            case 'vender':
                SetGridVender(path, '#tbVend', '#frmSearchVend', ReadVender);
                break;
        }
    }
    function GetParam() {
        let strParam = '?';
        strParam += 'Branch=' + $('#txtBranchCode').val();
        strParam += '&VenCode=' + $('#txtVenCode').val();
        return strParam;
    }
    function ReadVender(dt) {
        $('#txtVenCode').val(dt.VenCode);
        $('#txtVenName').val(dt.TName);
    }
    function ReadCurrency(dt) {
        $('#txtCurrencyCode').val(dt.Code);
        $('#txtExchangeRate').focus();
    }
    function ReadUser(dt) {
        $('#txtEmpCode').val(dt.UserID);
        $('#txtEmpName').val(dt.TName);
    }
    function ReadBranch(dt) {
        $('#txtBranchCode').val(dt.Code);
        $('#txtBranchName').val(dt.BrName);
    }
    function ReadService(dt) {
        if (dt != undefined) {
            $('#txtSICode').val(dt.SICode);
            $('#txtSDescription').val(dt.NameThai);
            return;
        }
        CalVATWHT();
    }
    function CalDiscount() {
        let rate = CNum($('#txtDiscountPerc').val());
        let disc = 0;
        if (rate == 0) {
            disc = CNum($('#txtAmtDisc').val());
        } else {
            disc = CDbl(CNum($('#txtTotal').val()) * (rate * 0.01), 2);
            $('#txtAmtDisc').val(disc);
        }
        CalTotal();
    }
    function CalAmount() {
        let price = CDbl($('#txtUnitPrice').val(), 4);
        let qty = CDbl($('#txtQty').val(),4);
        let rate = CDbl($('#txtExchangeRate').val(),4); //rate ของ detail
        if (qty > 0) {
            let amt = CNum(qty) * CNum(price);
            $('#txtAmt').val(CDbl(CNum(amt) * CNum(rate), 4));
            CalVATWHT();
        } else {
            $('#txtUnitPrice').val(0);
            $('#txtAmt').val(0);
            $('#txtAmtDisc').val(0);
            $('#txtTotal').val(0);
            $('#txtFTotal').val(0);
            $('#txtAmtVAT').val(0);
            $('#txtAmtWHT').val(0);
        }
    }
    function CalTotal() {
        let amt = CDbl($('#txtAmt').val(), 4);
        let disc = CDbl($('#txtAmtDisc').val(), 4);
        let vat = CDbl($('#txtAmtVAT').val(),4);
        let wht = CDbl($('#txtAmtWHT').val(),4);
        $('#txtTotal').val(CDbl(CNum(amt) + CNum(vat) - CNum(wht) - CNum(disc), 4));
        let rate = CDbl($('#txtExchangeRate').val(), 4);
        let net = CDbl($('#txtTotal').val(), 4);
        $('#txtFTotal').val(CDbl((net / rate), 4));
    }
    function CalVATWHT() {
        let vattype = $('#txtIsTaxCharge').prop('checked') == true ? '1' : '0';
        let whttype = $('#txtIs50Tavi').prop('checked') == true ? '1' : '0';
        let amt = CDbl($('#txtAmt').val(),4);
        let vatrate = CDbl($('#txtVATRate').val(),4);
        let whtrate = CDbl($('#txtTaxRate').val(), 4);
        let vat = 0;
        let wht = 0;
        if (vattype == '1') {
            vat = amt * vatrate * 0.01;
        }
        if (whttype == '1') {
            wht = amt * whtrate * 0.01;
        }
        $('#txtAmtVAT').val(CDbl(vat,4));
        $('#txtAmtWHT').val(CDbl(wht,4));
        CalTotal();
    }
    function GetExchangeRate() {
        $.get('https://free.currencyconverterapi.com/api/v6/convert?q=' + $('#txtCurrencyCode').val() + '_THB&compact=ultra&apiKey=6210d55b79170a4a7da2', function (r) {
            let rate = CDbl(r[$('#txtCurrencyCode').val() + '_THB'], 4);
            $('#txtExchangeRate').val(rate);
        });
    }
</script>