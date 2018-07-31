
@Code
    ViewBag.Title = "Job Information"
End Code
<head>
    <title>Show Job</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="~/Content/bootstrap.min.css">
    <script src="~/Scripts/jquery-3.2.1.min.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>
</head>
<div Class="panel-body">
    <div class="container">
        <label for="txtBranchCode">Branch :</label><input type="text" style="width:30px" id="txtBranchCode" disabled />
        <input type="text" style="width:120px" id="txtBranchName" disabled />
        <label for="txtJNo">Job No :</label><input type="text" style="width:120px" id="txtJNo" disabled />
        <label for="txtRevised">Revised :</label><input type="text" style="width:30px" id="txtRevised" disabled />
        <label for="txtDocDate">Open Date :</label><input type="text" style="width:80px" id="txtDocDate" disabled />
        <label for="txtDocDate">Job Status :</label><input type="text" style="width:130px" id="txtJobStatus" disabled />

        <ul class="nav nav-tabs">
            <li class="active"><a data-toggle="tab" href="#home">Job Descriptions</a></li>
            <li><a data-toggle="tab" href="#menu1">Invoice Description</a></li>
            <li><a data-toggle="tab" href="#menu2">Customs Description</a></li>
            <li><a data-toggle="tab" href="#menu3">Job Document Tracking</a></li>
            <li><a data-toggle="tab" href="#menu4">Other Controls</a></li>
        </ul>

        <div class="tab-content">
            <div id="home" class="tab-pane fade in active">
                <div class="row">
                    <div class="col-md-8">
                        <label for="txtCustCode">Customer :</label>
                        <input type="text" id="txtCustCode" style="width:100px" />
                        <input type="text" id="txtCustBranch" style="width:40px" />
                        <input type="button" id="btnBrowseCust" value="..." />
                        <input type="text" id="txtCustName" style="width:450px" disabled />
                    </div>
                    <div class="col-md-4">
                        <label for="txtQNo">Quotation : </label>
                        <input type="text" id="txtQNo" style="width:120px" />
                        <input type="text" id="txtQRevise" style="width:40px" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-8">
                        <label for="txtTAddress">Address   :</label>
                        <textarea id="txtTAddress" style="width:250px" disabled></textarea>
                        <textarea id="txtEAddress" style="width:250px" disabled></textarea>
                    </div>
                    <div class="col-md-4">
                        <label for="txtManagerCode">Sales By :</label>
                        <input type="text" id="txtManagerCode" style="width:100px" disabled />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-8">
                        <label for="txtPhoneFax">Contact Info :</label>
                        <input type="text" id="txtPhoneFax" style="width:550px" />
                        <input type="checkbox" id="chkIsLocalTransport" />
                        <label for="chkIsLocalTransport">Use Local Transport</label>
                    </div>
                    <div class="col-md-4">
                        <label for="txtCommission">Commission :</label>
                        <input type="text" id="txtCommission" style="width:100px" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-8">
                        <label for="txtContactName">Contact Person :</label>
                        <input type="text" id="txtContactName" style="width:150px" />
                        <label for="txtCSName">Support By :</label>
                        <input type="text" id="txtCSName" style="width:150px" disabled />
                    </div>
                    <div class="col-md-4">
                        <label for="txtConfirmDate">Confirm Date :</label>
                        <input type="text" id="txtConfirmDate" style="width:80px" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-8">
                        <label for="txtJobType">Job Type : </label>
                        <input type="text" id="txtJobType" style="width:150px" disabled />
                        <label for="txtShipBy">Ship By : </label>
                        <input type="text" id="txtShipBy" style="width:150px" disabled />
                    </div>
                    <div class="col-md-4">
                        <label for="txtCloseBy">Close By :</label>
                        <input type="text" id="txtCloseBy" style="width:100px" disabled />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-8">
                        <label for="txtJobCondition">Work Condition :</label>
                        <input type="text" id="txtJobCondition" style="width:500px" />
                    </div>
                    <div class="col-md-4">
                        <label for="txtCloseDate">Close Date : </label>
                        <input type="text" id="txtCloseDate" style="width:80px" disabled />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-8">
                        <label for="txtCustPoNo">Customer PO :</label>
                        <input type="text" id="txtCustPoNo" style="width:300px" />
                    </div>
                    <div class="col-md-4">
                        <input type="button" id="btnCloseJob" class="btn btn-warning" value="Close/Reopen" style="width:100px" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-8">
                        <label for="txtDescription">Descriptions : </label>
                        <textarea id="txtDescription" style="width:180px"></textarea>
                        <label for="txtCancelReason">Cancel Note : </label>
                        <textarea id="txtCancelReason" style="width:180px"></textarea>
                    </div>
                    <div class="col-md-4">
                        <label for="txtCancelDate">Cancel By :</label>
                        <input type="text" id="txtCancelBy" style="width:100px" disabled />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-8">
                        <label for="txtConsignee">Billing Place :</label>
                        <input type="text" id="txtConsignee" style="width:100px" />
                        <input type="text" id="txtConsBranch" style="width:40px" />
                        <input type="button" id="btnBrowseCons" value="..." />
                        <input type="text" id="txtConsignName" style="width:450px" disabled />
                    </div>
                    <div class="col-md-4">
                        <label for="txtCancelDate">Cancel Date :</label>
                        <input type="text" id="txtCancelDate" style="width:80px" disabled />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-8">
                        <label for="txtBillTAddress">Address   :</label>
                        <textarea id="txtBillTAddress" style="width:200px" disabled></textarea>
                        <textarea id="txtBillEAddress" style="width:200px" disabled></textarea>
                    </div>
                    <div class="col-md-4">
                        <input type="button" id="btnCancelJob" class="btn btn-danger" value="Cancel Job" style="width:100px" />
                    </div>
                </div>
            </div>
            <div id="menu1" class="tab-pane fade">
                <div class="row">
                    <div class="col-md-5">
                        <label for="txtCustInvNo">Cust.Invoice No :</label>
                        <input type="text" id="txtCustInvNo" style="width:200px" />
                    </div>
                    <div class="col-md-7">
                        <label for="txtProjectName">Project Name :</label>
                        <input type="text" id="txtProjectName" style="width:800px" />
                        <input type="button" id="btnBrowseProj" value="..." />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-5">
                        <label for="txtInvProduct">Products :</label>
                        <input type="text" id="txtInvProduct" style="width:200px" />
                        <input type="button" id="btnBrowseProd" value="..." />
                    </div>
                    <div class="col-md-7">
                        <label for="txtInvQty">Qty :</label>
                        <input type="text" id="txtInvQty" style="width:80px" />
                        <input type="text" id="txtInvUnit" style="width:40px" />
                        <input type="button" id="btnBrowseUnit" value="..." />
                        <label for="txtInvPackQty">Package.Total :</label>
                        <input type="text" id="txtInvPackQty" style="width:80px" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-5">
                        <label for="txtInvTotal">Inv.Total :</label>
                        <input type="text" id="txtInvTotal" style="width:100px" />
                        <label for="txtMeasurement">Measurement(M3) :</label>
                        <input type="text" id="txtMeasurement" style="width:40px" />
                    </div>
                    <div class="col-md-7">
                        <label for="txtNetWeight">Net Weight :</label>
                        <input type="text" id="txtNetWeight" style="width:60px" />
                        <label for="txtGrossWeight">Gross Weight :</label>
                        <input type="text" id="txtGrossWeight" style="width:60px" />
                        <input type="text" id="txtWeightUnit" style="width:40px" />
                        <input type="button" id="btnBrowseMeas" value="..." />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-5">
                        <label for="txtInvCurrency">Currency :</label>
                        <input type="text" id="txtInvCurrency" style="width:40px" />
                        <input type="button" id="btnBrowseRate" value="..." />
                        <label for="txtInvCurRate">Exchange Rate :</label>
                        <input type="text" id="txtInvCurRate" style="width:60px" />
                    </div>
                    <div class="col-md-7">
                        <label for="txtInvFCountry">From Country :</label>
                        <input type="text" id="txtInvFCountry" style="width:130px" disabled />
                        <input type="button" id="btnBrowseFCountry" value="..." />
                        <label for="txtInvCountry">To :</label>
                        <input type="text" id="txtInvCountry" style="width:130px" disabled />
                        <input type="button" id="btnBrowseCountry" value="..." />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-5">
                        <label for="txtBookingNo">Booking No :</label>
                        <input type="text" id="txtBookingNo" style="width:250px" />
                    </div>
                    <div class="col-md-7">
                        <label for="txtHAWB">House BL/AWB :</label>
                        <input type="text" id="txtHAWB" style="width:100px" />
                        <label for="txtMAWB">Master BL/AWB :</label>
                        <input type="text" id="txtMAWB" style="width:100px" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-5">
                        <label for="txtBLNo">BL/AWB Status :</label>
                        <input type="text" id="txtBLNo" style="width:200px" />
                    </div>
                    <div class="col-md-7">
                        <label for="txtForwarder">Agent:</label>
                        <input type="text" id="txtForwarder" style="width:100px" />
                        <input type="button" id="btnBrowseFwdr" value="..." />
                        <input type="text" id="txtForwarderName" style="width:300px" disabled />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-5">
                        <label for="txtVesselName">Vessel Name :</label>
                        <input type="text" id="txtVesselName" style="width:200px" />
                        <input type="button" id="btnBrowseVsl1" value="..." />
                    </div>
                    <div class="col-md-7">
                        <label for="txtMVesselName">Master Vessel Name :</label>
                        <input type="text" id="txtMVesselName" style="width:200px" />
                        <input type="button" id="btnBrowseVsl2" value="..." />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-5">
                        <label for="txtInterPort">Inter Port:</label>
                        <input type="text" id="txtInterPort" style="width:80px" />
                        <input type="button" id="btnBrowseIPort" value="..." />
                        <input type="text" id="txtInterPortName" style="width:160px" disabled />
                    </div>
                    <div class="col-md-7">
                        <label for="txtTransporter">Transporter :</label>
                        <input type="text" id="txtTransporter" style="width:80px" />
                        <input type="button" id="btnBrowseTrans" value="..." />
                        <input type="text" id="txtTransporterName" style="width:250px" disabled />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-5">
                        <label for="txtTotalCTN">Total Containers :</label>
                        <input type="text" id="txtTotalCTN" style="width:80px" />
                        <input type="button" id="btnGetCTN" value="..." />
                        <label for="cboSelCtnType">Term : </label>
                        <select id="cboSelCtnType" class="dropdown">
                            <option value="LCL" selected>LCL</option>
                            <option value="CY">CY</option>
                            <option value="CFS">CY</option>
                        </select>
                    </div>
                    <div class="col-md-7">
                        <label for="txtETDDate">ETD Date:</label><input type="text" style="width:80px" id="txtETDDate" />
                        <label for="txtETADate">ETA Date:</label><input type="text" style="width:80px" id="txtETADate" />
                        <label for="txtLoadDate">Load Date:</label><input type="text" style="width:80px" id="txtLoadDate" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-5">
                        <label for="txtDeliverNo">Delivery No :</label>
                        <input type="text" id="txtDeliverNo" style="width:30px" />
                        <label for="txtDeliverTo">Delivery To :</label>
                        <input type="text" id="txtDeliverTo" style="width:130px" />
                    </div>
                    <div class="col-md-7">
                        <label for="txtDeliverAddr">Delivery Address :</label>
                        <input type="text" id="txtDeliverAddr" style="width:600px" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <label for="txtDeliveryDate">Delivery Date :</label><input type="text" style="width:80px" id="txtDeliveryDate" />
                        <input type="button" class="btn btn-success" value="Print Delivery Slip"/>
                    </div>
                </div>
            </div>
            <div id="menu2" class="tab-pane fade">
                <div class="row">
                    <div class="col-md-3">
                        <label for="txtEDIDate">EDI Date :</label>
                        <input type="text" id="txtEDIDate" style="width:80px" />
                    </div>
                    <div class="col-md-3">
                        <label for="txtReadyClearDate">Ready Clear :</label>
                        <input type="text" id="txtReadyClearDate" style="width:80px" />
                    </div>
                    <div class="col-md-3">
                        <label for="txtDutyDate">Duty Date :</label>
                        <input type="text" id="txtDutyDate" style="width:80px" />
                    </div>
                    <div class="col-md-3">
                        <label for="txtClearDate">Clear Date :</label>
                        <input type="text" id="txtClearDate" style="width:80px" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <label for="txtDeclareType">Declare Type :</label>
                        <input type="text" id="txtDeclareType" style="width:80px" />
                        <input type="button" id="btnBrowseDCType" value="..." />
                        <input type="text" id="txtDeclareTypeName" style="width:200px" disabled />
                    </div>
                    <div class="col-md-3">
                        <label for="txtDeclareNo">Declare No :</label>
                        <input type="text" id="txtDeclareNo" style="width:100px" />
                    </div>
                    <div class="col-md-3">
                        <label for="txtDutyAmt">Duty Amt :</label>
                        <input type="text" id="txtDutyAmt" style="width:100px" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4">
                        <input type="checkbox" id="chkIsPrivilege" />
                        <label for="chkIsPrivilege">Special Privilege</label>
                        <select id="cboPrivilege" class="dropdown">
                            <option value="">No Privilege</option>
                            <option value="GC">Gold Card</option>
                            <option value="CB">Customs Broker</option>
                        </select>
                    </div>
                    <div class="col-md-4">
                        <input type="checkbox" id="chkIs19BIS" />
                        <label for="chkIs19BIS">19 BIS Rule</label>
                        <select id="cbo19BIS" class="dropdown">
                            <option value="">No Rule</option>
                            <option value="CA">Cash</option>
                            <option value="BG">Bank Guarantee</option>
                            <option value="DD">Draft Deposit</option>
                        </select>
                    </div>
                    <div class="col-md-4">
                        <input type="checkbox" id="chkDutyRule" />
                        <label for="chkDutyRule">Duty Rule</label>
                        <select id="cboDutyRule" class="dropdown">
                            <option value="NX">Non-Tax</option>
                            <option value="TX">Tax Paid</option>
                            <option value="EX">Tax Excepts</option>
                        </select>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-5">
                        <label for="optDeclareStatus">Declaration Status :</label>
                        <label class="radio-inline"><input type="radio" name="optDeclareStatus"><label style="color:green;font:bold">Green</label></label>
                        <label class="radio-inline"><input type="radio" name="optDeclareStatus"><label style="color:red;font:bold">Red</label></label>
                        <label class="radio-inline"><input type="radio" name="optDeclareStatus"><label style="color:blue;font:bold">Manual</label></label>
                    </div>
                    <div class="col-md-7">
                        <label for="txtReleasePort">Release Port :</label>
                        <input type="text" id="txtReleasePort" style="width:50px" />
                        <input type="button" id="btnBrowseLCPort" value="..." />
                        <input type="text" id="txtReleasePortName" style="width:200px" disabled />
                        <label for="txtPortNo">PORT#</label>
                        <input type="text" id="txtPortNo" style="width:30px" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <label for="txtShipping">Shipping Staff :</label>
                        <input type="text" id="txtShipping" style="width:80px" />
                        <input type="button" id="btnBrowseShipping" value="..." />
                        <input type="text" id="txtShippingName" style="width:200px" disabled />
                    </div>
                    <div class="col-md-6">
                        <label for="txtShippingCmd">Shipping Note :</label>
                        <input type="text" id="txtShippingCmd" style="width:400px" />
                    </div>
                </div>
                <br />
                <label>Advances Expenses Information :</label>
                    <div class="row">
                        <div class="col-md-6">
                            <table>
                                <tr>
                                    <td>
                                        <label style="font:bold">Company Paid By : </label>
                                    </td>
                                    <td>
                                        Cheque:
                                    </td>
                                    <td>
                                        <input type="text" id="txtComPaidChq" style="width:80px" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        Cash:
                                    </td>
                                    <td>
                                        <input type="text" id="txtComPaidCash" style="width:80px" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        E-Payment:
                                    </td>
                                    <td>
                                        <input type="text" id="txtComPaidEPay" style="width:80px" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        Others:<input type="text" id="txtComOthersPayBy" style="width:100px" />
                                    </td>
                                    <td>
                                        <input type="text" id="txtComPaidOthers" style="width:80px" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        Total Paid:
                                    </td>
                                    <td>
                                        <input type="text" id="txtComPaidTotal" style="width:100px" />
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <div class="col-md-6">
                            <table>
                                <tr>
                                    <td>
                                        <label style="font:bold">Customer Paid By : </label>
                                    </td>
                                    <td>
                                        Cheque:
                                    </td>
                                    <td>
                                        <input type="text" id="txtCustPaidChq" style="width:80px" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        Tax-Card:
                                    </td>
                                    <td>
                                        <input type="text" id="txtCustPaidCard" style="width:80px" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        E-Payment:
                                    </td>
                                    <td>
                                        <input type="text" id="txtCustPaidEPay" style="width:80px" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        Bank Guarantee:
                                    </td>
                                    <td>
                                        <input type="text" id="txtCustBankGuarantee" style="width:80px" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        Others:<input type="text" id="txtCustOthersPayBy" style="width:100px" />
                                    </td>
                                    <td>
                                        <input type="text" id="txtCustPaidOthers" style="width:80px" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        Total Paid:
                                    </td>
                                    <td>
                                        <input type="text" id="txtCustPaidTotal" style="width:100px" />
                                    </td>
                                </tr>
                            </table>
                        </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <input type="button" id="btnViewTAdv" class="btn btn-default" value="Credit Advances" />
                    </div>
                    <div class="col-md-6">
                        <input type="button" id="btnViewChq" class="btn btn-default" value="Customer Cheques" />
                    </div>
                </div>
            </div>
            <div id="menu3" class="tab-pane fade">
                <table class="table table-responsive">
                    <thead>
                        <tr>
                            <th>
                                Date
                            </th>
                            <th>
                                Type
                            </th>
                            <th>
                                Document No
                            </th>
                            <th>
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                                2018-01-01
                            </td>
                            <td>
                                ADV
                            </td>
                            <td>
                                ADV-1801-0001
                            </td>
                            <td>
                                <button class="btn btn-success">View</button>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                2018-05-01
                            </td>
                            <td>
                                CLR
                            </td>
                            <td>
                                CLR-1805-0001
                            </td>
                            <td>
                                <button class="btn btn-success">View</button>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <div id="menu4" class="tab-pane fade">
                <div class="row">
                    <div class="col-md-12">
                        <table class="table table-responsive">
                            <thead>
                                <tr>
                                    <th>
                                        Date
                                    </th>
                                    <th>
                                        Action
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>
                                        2018-01-01
                                    </td>
                                    <td>
                                        Create Job
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        2018-05-01
                                    </td>
                                    <td>
                                        Close Job
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <input type="button" class="btn btn-primary" id="btnLinkDoc" value="Document Files" />
                        <input type="button" class="btn btn-primary" id="btnLinkLoad" value="Transport Info" />
                        <input type="button" class="btn btn-primary" id="btnLinkOption" value="Addition Info" />
                        <input type="button" class="btn btn-primary" id="btnLinkExp" value="Minimum Expense" />
                        <input type="button" class="btn btn-primary" id="btnLinkTAdv" value="Credit Advance" />
                        <input type="button" class="btn btn-primary" id="btnLinkAdv" value="Advance Request" />
                        <input type="button" class="btn btn-primary" id="btnLinkClr" value="Advance Clearing" />
                        <input type="button" class="btn btn-primary" id="btnLinkCost" value="Cost & Profit" />
                    </div>
                </div>
            </div>
        </div>

    </div>
</div>

