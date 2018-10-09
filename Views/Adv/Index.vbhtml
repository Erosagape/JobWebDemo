
@Code
    ViewBag.Title = "Advance Information"
End Code
<div class="panel-body">
    <div id="dvHeader" class="container">
        <div class="row">
            <div class="col-sm-5">
                Branch :
                <input type="text" id="txtBranchCode" style="width:50px" />
                <button id="btnBrowseBranch">...</button>
                <input type="text" id="txtBranchName" style="width:200px" disabled />
            </div>
            <div class="col-sm-3">
                Request Date :
                <input type="date" id="txtAdvDate" />
            </div>
            <div class="col-sm-4" style="text-align:left">
                <table border="1">
                    <tr>
                        <td>
                            <b>Advance No</b>
                            <br />
                            <input type="text" id="txtAdvNo" style="font-style:bold;font-size:20px;text-align:center" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <ul class="nav nav-tabs">
            <li class="active"><a data-toggle="tab" href="#tabHeader">Advance Header</a></li>
            <li><a data-toggle="tab" href="#tabDetail">Advance Detail</a></li>
        </ul>
        <div class="tab-content">
            <div id="tabHeader" class="tab-pane fade in active">
                <div class="row">
                    <div class="col-sm-7">
                        <table>
                            <tr>
                                <td>
                                    Advance By :
                                </td>
                                <td>
                                    <input type="text" id="txtAdvBy" style="width:100px" />
                                    <button id="btnBrowseEmp1">...</button>
                                    <input type="text" id="txtAdvName" style="width:300px" disabled />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Request By :
                                </td>
                                <td>
                                    <input type="text" id="txtReqBy" style="width:100px" />
                                    <button id="btnBrowseEmp2">...</button>
                                    <input type="text" id="txtReqName" style="width:300px" disabled />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Advance For :
                                </td>
                                <td>
                                    <input type="text" id="txtCustCode" style="width:100px" />
                                    <button id="btnBrowseCust">...</button>
                                    <input type="text" id="txtCustName" style="width:300px" disabled />
                                </td>
                            </tr>
                        </table>
                        <table>
                            <tr>
                                <td>
                                    WH-Tax No:
                                </td>
                                <td>
                                    <input type="text" id="txtWHTaxSlipNo" style="width:200px" />
                                </td>
                                <td>
                                    Bill A/P:
                                </td>
                                <td>
                                    <input type="text" id="txtBillNumber" style="width:200px" />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div class="col-sm-5">
                        <table>
                            <tr>
                                <td>
                                    Job Type :
                                </td>
                                <td>
                                    <select id="cboJobType" style="width:200px" class="form-control dropdown">
                                        <option id="1">01 / IMPORT</option>
                                        <option id="2">02 / EXPORT</option>
                                    </select>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Ship By :
                                </td>
                                <td>
                                    <select id="cboShipBy" style="width:200px" class="form-control dropdown">
                                        <option id="1">01 / AIR</option>
                                        <option id="2">02 / SEA</option>
                                    </select>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Status :
                                </td>
                                <td>
                                    <input type="text" id="txtDocStatus" style="width:200px;height:40px;text-align:center;font-style:bold" disabled />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-7">
                        Advance Type:
                        <select id="cboAdvType" class="form-control dropdown" style="width:100%">
                            <option value="1">01 / Customs Service / General (C/S)</option>
                            <option value="2">02 / Duty Fee (C/S)</option>
                            <option value="3">03 / Shipping Performance (S/P)</option>
                            <option value="4">04 / Other</option>
                        </select>
                        <br />
                        Remark:
                        <textarea id="txtRemark" style="width:100%;height:80px"></textarea>
                    </div>
                    <div class="col-sm-5">
                        <br />
                        Payment Method:
                        <table>
                            <tr>
                                <td>
                                    <input type="checkbox" id="chkCash" checked />
                                    <label for="chkCash">Cash</label>
                                </td>
                                <td>
                                    <input type="text" id="txtCashAmount" style="width:100px;text-align:right" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <input type="checkbox" id="chkComChq" />
                                    <label for="chkComChq">Cashier Chq</label>
                                </td>
                                <td>
                                    <input type="text" id="txtChqAmount" style="width:100px;text-align:right" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <input type="checkbox" id="chkCustChq" />
                                    <label for="chkCustChq">Customer Chq</label>
                                </td>
                                <td>
                                    <input type="text" id="txtCustChqAmount" style="width:100px;text-align:right" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <input type="checkbox" id="chkCredit" />
                                    <label for="chkCredit">Credit</label>
                                </td>
                                <td>
                                    <input type="text" id="txtCreditAmount" style="width:100px;text-align:right" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-4" style="border-style:solid;border-width:1px">
                        <input type="checkbox" id="chkApprove" checked />
                        <label for="chkApprove">Approve By</label>
                        <br />
                        <input type="text" id="txtApproveBy" style="width:250px" disabled />
                        <br />
                        Date:
                        <input type="text" id="txtApproveDate" style="width:120px" disabled />
                        Time:
                        <input type="text" id="txtApproveTime" style="width:80px" disabled />
                    </div>
                    <div class="col-sm-4" style="border-style:solid;border-width:1px">
                        <input type="checkbox" id="chkPayment" />
                        <label for="chkPayment">Payment By</label>
                        <input type="text" id="txtPaymentBy" style="width:250px" disabled />
                        <br />
                        Date:
                        <input type="text" id="txtPaymentDate" style="width:120px" disabled />
                        Time:
                        <input type="text" id="txtPaymentTime" style="width:80px" disabled />
                        <br />
                        Payment Ref:<input type="text" id="txtPaymentRef" style="width:200px" />
                    </div>
                    <div class="col-sm-4" style="border-style:solid;border-width:1px;color:red">
                        <input type="checkbox" id="chkCancel" />
                        <label for="chkCancel">Cancel By</label>
                        <input type="text" id="txtCancelBy" style="width:250px" disabled />
                        <br />
                        Date:
                        <input type="text" id="txtCancelDate" style="width:120px" disabled />
                        Time:
                        <input type="text" id="txtCancelTime" style="width:80px" disabled />
                        <br />
                        Cancel Reason :<input type="text" id="txtCancelReson" style="width:250px" />
                    </div>
                </div>
                <button id="btnSave" class="btn btn-success">Save Header</button>
                <button id="btnPrint" class="btn btn-info" onclick="PrintData()">Print Data</button>
            </div>
            <div id="tabDetail" class="tab-pane fade">
                <div class="row">
                    <div class="col-sm-12">
                        <table id="tbDetail" class="table table-responsive">
                            <thead>
                                <tr>
                                    <th>SICode</th>
                                    <th>Description</th>
                                    <th>Job No</th>
                                    <th>Amount</th>
                                    <th>Vat</th>
                                    <th>WH-Tax</th>
                                    <th>Remark</th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-9">
                        <label for="txtItemNo">Item No :</label>
                        <input type="text" id="txtItemNo" style="width:40px" disabled />
                        <label for="txtSICode">Code :</label>
                        <input type="text" id="txtSICode" style="width:80px" />
                        <input type="button" id="btnBrowseS" value="..." />
                        <input type="text" id="txtSDescription" style="width:280px" />
                        <label for="txtForJNo">Job No :</label>
                        <input type="text" id="txtForJNo" style="width:120px" />
                        <input type="button" id="btnBrowseJ" value="..." />
                        <br />
                        <label for="txtAmount">Amount :</label>
                        <input type="text" id="txtAmount" style="width:100px;text-align:right" />
                        <label for="txtVATRate">VAT :</label>
                        <input type="text" id="txtVATRate" style="width:50px;text-align:right" />
                        <input type="text" id="txtVATAmount" style="width:100px;text-align:right" />
                        <label for="txtWHTRate">WHT :</label>
                        <input type="text" id="txtWHTRate" style="width:50px;text-align:right" />
                        <input type="text" id="txtWHTAmount" style="width:100px;text-align:right" />
                        <label for="txtNETAmount">Net Amount :</label>
                        <input type="text" id="txtNETAmount" style="width:100px;text-align:right" />
                    </div>
                    <div class="col-sm-3" style="text-align:right">
                        Amount :
                        <input type="text" id="txtAdvAmount" style="width:100px;text-align:right" /><br />
                        VAT :
                        <input type="text" id="txtVatAmount" style="width:100px;text-align:right" /><br />
                        WHT :
                        <input type="text" id="txtWhtAmount" style="width:100px;text-align:right" /><br />
                        Total :
                        <input type="text" id="txtTotalAmount" style="width:100px;text-align:right" />
                    </div>
                </div>
                <button id="btnAdd" class="btn btn-default">New</button>
                <button id="btnUpdate" class="btn btn-primary">Save</button>
                <button id="btnDelete" class="btn btn-danger">Delete</button>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    $(document).ready(function () {
        var br = getQueryString('BranchCode');
        var ano = getQueryString('AdvNo');
    });
    function PrintData() {
        window.open(path + 'Adv/FormAdv');
    }
</script>