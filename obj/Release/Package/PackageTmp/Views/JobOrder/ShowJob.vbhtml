
@Code
    ViewBag.Title = "Job Information"
End Code
<div Class="panel-body">
    <div class="container">
        <label for="txtBranchCode">Branch :</label><input type="text" style="width:30px" id="txtBranchCode" disabled />
        <input type="text" style="width:120px" id="txtBranchName" disabled />
        <label for="txtJNo">Job No :</label><input type="text" style="width:120px" id="txtJNo" disabled />
        <label for="txtRevised">Revised :</label><input type="text" style="width:30px" id="txtRevised" disabled />
        <label for="txtDocDate">Open Date :</label><input type="text" style="width:80px" id="txtDocDate" disabled />
        <label for="txtJobStatus">Job Status :</label><input type="text" style="width:130px" id="txtJobStatus" disabled />

        <ul class="nav nav-tabs">
            <li class="active"><a data-toggle="tab" href="#tabinfo">Job Descriptions</a></li>
            <li><a data-toggle="tab" href="#tabinv">Invoice Description</a></li>
            <li><a data-toggle="tab" href="#tabdeclare">Customs Description</a></li>
            <li><a data-toggle="tab" href="#tabtracking">Job Document Tracking</a></li>
            <li><a data-toggle="tab" href="#tabremark">Other Controls</a></li>
        </ul>
        <div id="frmSearchSUnt" class="modal fade" role="dialog">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal"></button>
                        <h4 class="modal-title"><label id="lblHeader">Search Service Type</label></h4>
                    </div>
                    <div class="modal-body">
                        <table id="tbSUnt" class="table table-responsive">
                            <thead>
                                <tr>
                                    <th>
                                    <th>code</th>
                                    <th>name</th>
                                </tr>
                            </thead>
                        </table>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-success" id="btnApplyCons">Apply</button>
                        <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>
        <div id="frmLOVs"></div>
        <div class="tab-content">
            <div id="tabinfo" class="tab-pane fade in active">
                <div class="row">
                    <div class="col-md-8">
                        <label for="txtCustCode">Customer :</label>
                        <input type="text" id="txtCustCode" style="width:100px" />
                        <input type="text" id="txtCustBranch" style="width:40px" />
                        <input type="button" id="btnBrowseCust" value="..." onclick="SearchData('CUSTOMER')" />
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
                        <input type="text" id="txtJobCondition" style="width:600px" />
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
                        <label for="txtCancelBy">Cancel By :</label>
                        <input type="text" id="txtCancelBy" style="width:100px" disabled />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-8">
                        <label for="txtConsignee">Billing Place :</label>
                        <input type="text" id="txtConsignee" style="width:100px" />
                        <input type="text" id="txtConsBranch" style="width:40px" />
                        <input type="button" id="btnBrowseCons" value="..." onclick="SearchData('CONSIGNEE')" />
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
            <div id="tabinv" class="tab-pane fade">
                <div class="row">
                    <div class="col-md-5">
                        <label for="txtCustInvNo">Cust.Invoice No :</label>
                        <input type="text" id="txtCustInvNo" style="width:200px" />
                    </div>
                    <div class="col-md-7">
                        <label for="txtProjectName">Project Name :</label>
                        <input type="text" id="txtProjectName" style="width:400px" />
                        <input type="button" id="btnBrowseProj" value="..." onclick="SearchData('ProjectName')" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-5">
                        <label for="txtInvProduct">Products :</label>
                        <input type="text" id="txtInvProduct" style="width:200px" />
                        <input type="button" id="btnBrowseProd" value="..." onclick="SearchData('InvProduct')" />
                    </div>
                    <div class="col-md-7">
                        <label for="txtInvQty">Qty :</label>
                        <input type="text" id="txtInvQty" style="width:80px" />
                        <input type="text" id="txtInvUnit" style="width:40px" />
                        <input type="button" id="btnBrowseUnit" value="..." onclick="SearchData('invproductunit')" />
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
                        <input type="button" id="btnBrowseMeas" value="..." onclick="SearchData('GWUnit')" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-5">
                        <label for="txtInvCurrency">Currency :</label>
                        <input type="text" id="txtInvCurrency" style="width:40px" />
                        <input type="button" id="btnBrowseRate" value="..." onclick="SearchData('CURRENCY')" />
                        <label for="txtInvCurRate">Exchange Rate :</label>
                        <input type="text" id="txtInvCurRate" style="width:60px" />
                    </div>
                    <div class="col-md-7">
                        <label for="txtInvFCountry">From Country :</label>
                        <input type="hidden" id="txtInvFCountryCode" />
                        <input type="text" id="txtInvFCountry" style="width:130px" disabled />
                        <input type="button" id="btnBrowseFCountry" value="..." onclick="SearchData('fcountry')" />
                        <label for="txtInvCountry">To :</label>
                        <input type="hidden" id="txtInvCountryCode" />
                        <input type="text" id="txtInvCountry" style="width:130px" disabled />
                        <input type="button" id="btnBrowseCountry" value="..." onclick="SearchData('country')" />
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
                        <input type="button" id="btnBrowseFwdr" value="..." onclick="SearchData('forwarder')" />
                        <input type="text" id="txtForwarderName" style="width:300px" disabled />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-5">
                        <label for="txtVesselName">Vessel Name :</label>
                        <input type="text" id="txtVesselName" style="width:200px" />
                        <input type="button" id="btnBrowseVsl1" value="..." onclick="SearchData('vessel')" />
                    </div>
                    <div class="col-md-7">
                        <label for="txtMVesselName">Master Vessel Name :</label>
                        <input type="text" id="txtMVesselName" style="width:200px" />
                        <input type="button" id="btnBrowseVsl2" value="..." onclick="SearchData('mvessel')" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-5">
                        <label for="txtInterPort">Inter Port:</label>
                        <input type="text" id="txtInterPort" style="width:80px" />
                        <input type="button" id="btnBrowseIPort" value="..." onclick="SearchData('interport')" />
                        <input type="text" id="txtInterPortName" style="width:160px" disabled />
                    </div>
                    <div class="col-md-7">
                        <label for="txtTransporter">Transporter :</label>
                        <input type="text" id="txtTransporter" style="width:80px" />
                        <input type="button" id="btnBrowseTrans" value="..." onclick="SearchData('agent')" />
                        <input type="text" id="txtTransporterName" style="width:250px" disabled />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-5">
                        <label for="txtTotalCTN">Total Containers :</label>
                        <input type="text" id="txtTotalCTN" style="width:80px" />
                        <input type="button" id="btnGetCTN" value="..." onclick="SearchData('SERVUNIT')" />
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
                        <input type="text" id="txtDeliverAddr" style="width:400px" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <label for="txtDeliveryDate">Delivery Date :</label><input type="text" style="width:80px" id="txtDeliveryDate" />
                        <input type="button" class="btn btn-success" value="Print Delivery Slip" />
                    </div>
                </div>
            </div>
            <div id="tabdeclare" class="tab-pane fade">
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
                        <input type="button" id="btnBrowseDCType" value="..." onclick="SearchData('RFDCT')" />
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
                        <input type="button" id="btnBrowseLCPort" value="..." onclick="SearchData('RFARS')" />
                        <input type="text" id="txtReleasePortName" style="width:200px" disabled />
                        <label for="txtPortNo">PORT#</label>
                        <input type="text" id="txtPortNo" style="width:30px" />
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <label for="txtShipping">Shipping Staff :</label>
                        <input type="text" id="txtShipping" style="width:80px" />
                        <input type="button" id="btnBrowseShipping" value="..." onclick="SearchData('user')" />
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
                                    Cash:
                                </td>
                                <td>
                                    <input type="text" id="txtCustPaidCash" style="width:80px" /><br />
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
                                    <input type="text" id="txtCustPaidBank" style="width:80px" /><br />
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
            <div id="tabtracking" class="tab-pane fade">
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
            <div id="tabremark" class="tab-pane fade">
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
<script type="text/javascript">
    //define variables
    var path = '@Url.Content("~")';
    $(document).ready(function () {
        //load list of values
        $.get(path + 'JobOrder/GetFormJobLOV', function (response) {
            $('#frmLOVs').html(response);
            SetLOVs();
        });
        SetEvents();
        //check parameters
        var br = getQueryString('BranchCode');
        var jno = getQueryString('JNo');
        if (br != "" && jno != "") {
            $('#txtBranchCode').val(br);
            ShowBranch(br);
            $('#txtJNo').val(jno);
            ShowJob(br, jno);
        }
    });
    function SetEvents() {
        $('#txtTransporter').keydown(function (event) {
            if (event.which == 13) {
                ShowVender($('#txtTransporter').val(), '#txtTransporterName');
            }
        });
        $('#txtForwarder').keydown(function (event) {
            if (event.which == 13) {
                ShowVender($('#txtForwarder').val(), '#txtForwarderName');
            }
        });
        $('#txtShipping').keydown(function (event) {
            if (event.which == 13) {
                ShowUser($('#txtShipping').val(), '#txtShippingName');
            }
        });
        $('#txtCustBranch').keydown(function (event) {
            if (event.which == 13) {
                ShowCustomer($('#txtCustCode').val(), $('#txtCustBranch').val(), false);
            }
        });
        $('#txtConsBranch').keydown(function (event) {
            if (event.which == 13) {
                ShowCustomer($('#txtConsignee').val(), $('#txtConsBranch').val(), true);
            }
        });
        $('#txtReleasePort').keydown(function (event) {
            if (event.which == 13) {
                ShowReleasePort($('#txtReleasePort').val());
            }
        });
        $('#txtInterPort').keydown(function (event) {
            if (event.which == 13) {
                if ($('#txtJobType').val() == 'IMPORT') {
                    ShowInterPort($('#txtInvCountryCode').val(), $('#txtInterPort').val());
                } else {
                    ShowInterPort($('#txtInvFCountryCode').val(), $('#txtInterPort').val());
                }
            }
        });
        $('#txtDeclareType').keydown(function (event) {
            if (event.which == 13) {
                ShowDeclareType($('#txtDeclareType').val());
            }
        });
    }
    function SetLOVs() {
        //3 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            //Customers
            var ListCust = response.replace('tbX', 'tbCust').replace('cpX', 'Customers');
            $('#frmSearchCust').html(ListCust);
            $('#frmSearchCust').on('shown.bs.modal', function () {
                $('#tbCust_filter input').focus();
            });
            //Consignee
            var ListCons = response.replace('tbX', 'tbCons').replace('cpX', 'Consignees');
            $('#frmSearchCons').html(ListCons);
            $('#frmSearchCons').on('shown.bs.modal', function () {
                $('#tbCons_filter input').focus();
            });
            //Inter Port
            var ListIPort = response.replace('tbX', 'tbIPort').replace('cpX', 'Inter Port');
            $('#frmSearchIPort').html(ListIPort);
            $('#frmSearchIPort').on('shown.bs.modal', function () {
                $('#tbIPort_filter input').focus();
            });
        });
        //2 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,name', function (response) {
            //Users
            var ListUser = response.replace('tbX', 'tbUser').replace('cpX', 'Users');
            $('#frmSearchUser').html(ListUser);
            $('#frmSearchUser').on('shown.bs.modal', function () {
                $('#tbUser_filter input').focus();
            });
            //Declare Type
            var ListDType = response.replace('tbX', 'tbDType').replace('cpX', 'Declaration Type');
            $('#frmSearchDType').html(ListDType);
            $('#frmSearchDType').on('shown.bs.modal', function () {
                $('#tbDType_filter input').focus();
            });
            //Customs Port
            var ListCPort = response.replace('tbX', 'tbCPort').replace('cpX', 'Customs Inspection At');
            $('#frmSearchCPort').html(ListCPort);
            $('#frmSearchCPort').on('shown.bs.modal', function () {
                $('#tbCPort_filter input').focus();
            });
            //Currency
            var ListCurr = response.replace('tbX', 'tbCurr').replace('cpX', 'Currencys');
            $('#frmSearchCurr').html(ListCurr);
            $('#frmSearchCurr').on('shown.bs.modal', function () {
                $('#tbCurr_filter input').focus();
            });
            //Country
            var ListCountry = response.replace('tbX', 'tbCountry').replace('cpX', 'Country');
            $('#frmSearchCountry').html(ListCountry);
            $('#frmSearchCountry').on('shown.bs.modal', function () {
                $('#tbCountry_filter input').focus();
            });
            //FCountry
            var ListFCountry = response.replace('tbX', 'tbFCountry').replace('cpX', 'Country');
            $('#frmSearchFCountry').html(ListFCountry);
            $('#frmSearchFCountry').on('shown.bs.modal', function () {
                $('#tbFCountry_filter input').focus();
            });
            //Agent
            var ListAgent = response.replace('tbX', 'tbVend').replace('cpX', 'Agent');
            $('#frmSearchVend').html(ListAgent);
            $('#frmSearchVend').on('shown.bs.modal', function () {
                $('#tbVend_filter input').focus();
            });
            //Forwarder/Transporter
            var ListForwarder = response.replace('tbX', 'tbForw').replace('cpX', 'Transporter');
            $('#frmSearchForw').html(ListForwarder);
            $('#frmSearchForw').on('shown.bs.modal', function () {
                $('#tbForw_filter input').focus();
            });
        });
        //1 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=name', function (response) {
            //Projects Name
            var ListProj = response.replace('tbX', 'tbProj').replace('cpX', 'Project Name');
            $('#frmSearchProj').html(ListProj);
            $('#frmSearchProj').on('shown.bs.modal', function () {
                $('#tbProj_filter input').focus();
            });
            //Products
            var ListProd = response.replace('tbX', 'tbProd').replace('cpX', 'Products');
            $('#frmSearchProd').html(ListProd);
            $('#frmSearchProd').on('shown.bs.modal', function () {
                $('#tbProd_filter input').focus();
            });
            //Vessel
            var ListVessel = response.replace('tbX', 'tbVessel').replace('cpX', 'Vessels');
            $('#frmSearchVessel').html(ListVessel);
            $('#frmSearchVessel').on('shown.bs.modal', function () {
                $('#tbVessel_filter input').focus();
            });
            //Mother Vessel
            var ListMVessel = response.replace('tbX', 'tbMVessel').replace('cpX', 'Vessels');
            $('#frmSearchMVessel').html(ListMVessel);
            $('#frmSearchMVessel').on('shown.bs.modal', function () {
                $('#tbMVessel_filter input').focus();
            });
            //Inv Units
            var ListInvUnit = response.replace('tbX', 'tbIUnt').replace('cpX', 'Invoice Units');
            $('#frmSearchIUnt').html(ListInvUnit);
            $('#frmSearchIUnt').on('shown.bs.modal', function () {
                $('#tbIUnt_filter input').focus();
            });
            //Weights Unit
            var ListWeightUnit = response.replace('tbX', 'tbWUnt').replace('cpX', 'Weight Units');
            $('#frmSearchWUnt').html(ListWeightUnit);
            $('#frmSearchWUnt').on('shown.bs.modal', function () {
                $('#tbWUnt_filter input').focus();
            });
        });
    }
    function SearchData(type) {
        switch (type) {
            case 'interport':
                var CountryID = $('#txtInvFCountryCode').val();
                if ($('#txtJobType').val() == "IMPORT") {
                    CountryID = $('#txtInvCountryCode').val();
                }
                $('#tbIPort').DataTable({
                    ajax: {
                        url: path + 'Master/GetInterPort?Key=' + CountryID, //web service ที่จะ call ไปดึงข้อมูลมา
                        dataSrc: 'interport.data'
                    },
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "PortCode", title: "รหัส" },
                        { data: "CountryCode", title: "ประเทศ" },
                        { data: "PortName", title: "ชื่อ" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                var html = "<button class='btn btn-warning'>Select</button>";
                                return html;
                            }
                        }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                $('#tbIPort tbody').on('click', 'button', function () {
                    var dt = GetSelect('#tbIPort', this);
                    $('#txtInterPort').val(dt.PortCode);
                    $('#txtInterPortName').val(dt.PortName);
                    $('#frmSearchIPort').modal('hide');
                });
                $('#tbIPort tbody').on('click', 'tr', function () {
                    $('#tbIPort tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                    $(this).addClass('selected'); //select row ใหม่
                });
                $('#frmSearchIPort').modal('show');
                break;
            case 'agent':
                $('#tbVend').DataTable({
                    ajax: {
                        url: path + 'Master/GetVender', //web service ที่จะ call ไปดึงข้อมูลมา
                        dataSrc: 'vender.data'
                    },
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "VenCode", title: "รหัส" },
                        { data: "TName", title: "ชื่อ" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                var html = "<button class='btn btn-warning'>Select</button>";
                                return html;
                            }
                        }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                $('#tbVend tbody').on('click', 'button', function () {
                    var dt = GetSelect('#tbVend', this);
                    $('#txtTransporter').val(dt.VenCode);
                    $('#txtTransporterName').val(dt.TName);
                    $('#frmSearchVend').modal('hide');
                });
                $('#tbVend tbody').on('click', 'tr', function () {
                    $('#tbVend tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                    $(this).addClass('selected'); //select row ใหม่
                });
                $('#frmSearchVend').modal('show');
                break;
            case 'forwarder':
                $('#tbForw').DataTable({
                    ajax: {
                        url: path + 'Master/GetVender', //web service ที่จะ call ไปดึงข้อมูลมา
                        dataSrc: 'vender.data'
                    },
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "VenCode", title: "รหัส" },
                        { data: "TName", title: "ชื่อ" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                var html = "<button class='btn btn-warning'>Select</button>";
                                return html;
                            }
                        }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                $('#tbForw tbody').on('click', 'button', function () {
                    var dt = GetSelect('#tbForw', this);
                    $('#txtForwarder').val(dt.VenCode);
                    $('#txtForwarderName').val(dt.TName);
                    $('#frmSearchForw').modal('hide');
                });
                $('#tbForw tbody').on('click', 'tr', function () {
                    $('#tbForw tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                    $(this).addClass('selected'); //select row ใหม่
                });
                $('#frmSearchForw').modal('show');
                break;
            case 'country':
                $('#tbCountry').DataTable({
                    ajax: {
                        url: path + 'Master/GetCountry', //web service ที่จะ call ไปดึงข้อมูลมา
                        dataSrc: 'country.data'
                    },
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "CTYCODE", title: "รหัส" },
                        { data: "CTYName", title: "ชื่อประเทศ" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                var html = "<button class='btn btn-warning'>Select</button>";
                                return html;
                            }
                        }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                $('#tbCountry tbody').on('click', 'button', function () {
                    var dt = GetSelect('#tbCountry', this);
                    $('#txtInvCountry').val(dt.CTYName);
                    $('#txtInvCountryCode').val(dt.CTYCODE);
                    $('#frmSearchCountry').modal('hide');
                });
                $('#tbCountry tbody').on('click', 'tr', function () {
                    $('#tbCountry tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                    $(this).addClass('selected'); //select row ใหม่
                });
                $('#frmSearchCountry').modal('show');
                break;
            case 'fcountry':
                $('#tbFCountry').DataTable({
                    ajax: {
                        url: path + 'Master/GetCountry', //web service ที่จะ call ไปดึงข้อมูลมา
                        dataSrc: 'country.data'
                    },
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "CTYCODE", title: "รหัส" },
                        { data: "CTYName", title: "ชื่อประเทศ" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                var html = "<button class='btn btn-warning'>Select</button>";
                                return html;
                            }
                        }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                $('#tbFCountry tbody').on('click', 'button', function () {
                    var dt = GetSelect('#tbFCountry', this);
                    $('#txtInvFCountry').val(dt.CTYName);
                    $('#txtInvFCountryCode').val(dt.CTYCODE);
                    $('#frmSearchFCountry').modal('hide');
                });
                $('#tbFCountry tbody').on('click', 'tr', function () {
                    $('#tbFCountry tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                    $(this).addClass('selected'); //select row ใหม่
                });
                $('#frmSearchFCountry').modal('show');
                break;
            case 'GWUnit':
                //popup for search data
                $.get(path + 'joborder/getjobdatadistinct?field=' + type)
                    .done(function (r) {
                        var dr = r[0].Table;
                        if (dr.length > 0) {
                            $('#tbWUnt').DataTable({
                                data: dr, //web service ที่จะ call ไปดึงข้อมูลมา
                                selected: true, //ให้สามารถเลือกแถวได้
                                columns: [ //กำหนด property ของ header column
                                    { data: null, title: "#" },
                                    { data: "val", title: "ชื่อหน่วย" }
                                ],
                                "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                                    {
                                        "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                                        "data": null,
                                        "render": function (data, type, full, meta) {
                                            var html = "<button class='btn btn-warning'>Select</button>";
                                            return html;
                                        }
                                    }
                                ],
                                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                            });
                            $('#tbWUnt tbody').on('click', 'button', function () {
                                var dt = GetSelect('#tbWUnt', this);
                                $('#txtWeightUnit').val(dt.val);
                                $('#frmSearchWUnt').modal('hide');
                            });
                            $('#tbWUnt tbody').on('click', 'tr', function () {
                                $('#tbWUnt tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                                $(this).addClass('selected'); //select row ใหม่
                            });
                            $('#frmSearchWUnt').modal('show');
                        }
                    });
                break;
            case 'invproductunit':
                //popup for search data
                $.get(path + 'joborder/getjobdatadistinct?field='+type)
                    .done(function (r) {
                        var dr = r[0].Table;
                        if (dr.length > 0) {
                            $('#tbIUnt').DataTable({
                                data: dr, //web service ที่จะ call ไปดึงข้อมูลมา
                                selected: true, //ให้สามารถเลือกแถวได้
                                columns: [ //กำหนด property ของ header column
                                    { data: null, title: "#" },
                                    { data: "val", title: "ชื่อหน่วย" }
                                ],
                                "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                                    {
                                        "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                                        "data": null,
                                        "render": function (data, type, full, meta) {
                                            var html = "<button class='btn btn-warning'>Select</button>";
                                            return html;
                                        }
                                    }
                                ],
                                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                            });
                            $('#tbIUnt tbody').on('click', 'button', function () {
                                var dt = GetSelect('#tbIUnt', this);
                                $('#txtInvUnit').val(dt.val);
                                $('#frmSearchIUnt').modal('hide');
                            });
                            $('#tbIUnt tbody').on('click', 'tr', function () {
                                $('#tbIUnt tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                                $(this).addClass('selected'); //select row ใหม่
                            });
                            $('#frmSearchIUnt').modal('show');
                        }
                    });
                break;
            case 'mvessel':
                //popup for search data
                $.get(path + 'joborder/getjobdatadistinct?field=MVesselName')
                    .done(function (r) {
                        var dr = r[0].Table;
                        if (dr.length > 0) {
                            $('#tbMVessel').DataTable({
                                data: dr, //web service ที่จะ call ไปดึงข้อมูลมา
                                selected: true, //ให้สามารถเลือกแถวได้
                                columns: [ //กำหนด property ของ header column
                                    { data: null, title: "#" },
                                    { data: "val", title: "ชื่อยานพาหนะ" }
                                ],
                                "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                                    {
                                        "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                                        "data": null,
                                        "render": function (data, type, full, meta) {
                                            var html = "<button class='btn btn-warning'>Select</button>";
                                            return html;
                                        }
                                    }
                                ],
                                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                            });
                            $('#tbMVessel tbody').on('click', 'button', function () {
                                var dt = GetSelect('#tbMVessel', this);
                                $('#txtMVesselName').val(dt.val);
                                $('#frmSearchMVessel').modal('hide');
                            });
                            $('#tbMVessel tbody').on('click', 'tr', function () {
                                $('#tbMVessel tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                                $(this).addClass('selected'); //select row ใหม่
                            });
                            $('#frmSearchMVessel').modal('show');
                        }
                    });
                break;
            case 'vessel':
                //popup for search data
                $.get(path + 'joborder/getjobdatadistinct?field=VesselName')
                    .done(function (r) {
                        var dr = r[0].Table;
                        if (dr.length > 0) {
                            $('#tbVessel').DataTable({
                                data: dr, //web service ที่จะ call ไปดึงข้อมูลมา
                                selected: true, //ให้สามารถเลือกแถวได้
                                columns: [ //กำหนด property ของ header column
                                    { data: null, title: "#" },
                                    { data: "val", title: "ชื่อยานพาหนะ" }
                                ],
                                "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                                    {
                                        "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                                        "data": null,
                                        "render": function (data, type, full, meta) {
                                            var html = "<button class='btn btn-warning'>Select</button>";
                                            return html;
                                        }
                                    }
                                ],
                                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                            });
                            $('#tbVessel tbody').on('click', 'button', function () {
                                var dt = GetSelect('#tbVessel', this);
                                $('#txtVesselName').val(dt.val);
                                $('#frmSearchVessel').modal('hide');
                            });
                            $('#tbVessel tbody').on('click', 'tr', function () {
                                $('#tbVessel tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                                $(this).addClass('selected'); //select row ใหม่
                            });
                            $('#frmSearchVessel').modal('show');
                        }
                    });
                break;
            case 'user':
                $('#tbUser').DataTable({
                    ajax: {
                        url: path + 'Master/GetUser', //web service ที่จะ call ไปดึงข้อมูลมา
                        dataSrc: 'user.data'
                    },
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "UserID", title: "รหัส" },
                        { data: "TName", title: "ชื่อ" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                var html = "<button class='btn btn-warning'>Select</button>";
                                return html;
                            }
                        }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                $('#tbUser tbody').on('click', 'button', function () {
                    var dt = GetSelect('#tbUser', this);
                    $('#txtShipping').val(dt.UserID);
                    $('#txtShippingName').val(dt.TName);
                    $('#frmSearchUser').modal('hide');
                });
                $('#tbUser tbody').on('click', 'tr', function () {
                    $('#tbUser tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                    $(this).addClass('selected'); //select row ใหม่
                });
                $('#frmSearchUser').modal('show');
                break;
            case 'RFDCT':
                $('#tbDType').DataTable({
                    ajax: {
                        url: path + 'Master/GetDeclareType', //web service ที่จะ call ไปดึงข้อมูลมา
                        dataSrc: 'RFDCT.data'
                    },
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "Type", title: "รหัส" },
                        { data: "Description", title: "คำอธิบาย" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                var html = "<button class='btn btn-warning'>Select</button>";
                                return html;
                            }
                        }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                $('#tbDType tbody').on('click', 'button', function () {
                    var dt = GetSelect('#tbDType', this);
                    $('#txtDeclareType').val(dt.Type);
                    $('#txtDeclareTypeName').val(dt.Description);
                    $('#frmSearchDType').modal('hide');
                });
                $('#tbDType tbody').on('click', 'tr', function () {
                    $('#tbDtype tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                    $(this).addClass('selected'); //select row ใหม่
                });
                $('#frmSearchDType').modal('show');
                break;
            case 'RFARS':
                //popup for search data
                $('#tbCPort').DataTable({
                    ajax: {
                        url: path + 'Master/GetCustomsPort', //web service ที่จะ call ไปดึงข้อมูลมา
                        dataSrc: 'RFARS.data'
                    },
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "AreaCode", title: "รหัส" },
                        { data: "AreaName", title: "คำอธิบาย" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                var html = "<button class='btn btn-warning'>Select</button>";
                                return html;
                            }
                        }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                $('#tbCPort tbody').on('click', 'button', function () {
                    var dt = GetSelect('#tbCPort', this);
                    $('#txtReleasePort').val(dt.AreaCode);
                    $('#txtReleasePortName').val(dt.AreaName);
                    $('#frmSearchCPort').modal('hide');
                });
                $('#tbCPort tbody').on('click', 'tr', function () {
                    $('#tbCPort tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                    $(this).addClass('selected'); //select row ใหม่
                });
                $('#frmSearchCPort').modal('show');
                break;

            case 'SERVUNIT':
                //popup for search data
                $('#tbSUnt').DataTable({
                    ajax: {
                        url: path + 'Master/GetServUnit', //web service ที่จะ call ไปดึงข้อมูลมา
                        dataSrc: 'servunit.data'
                    },
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "UnitType", title: "รหัส" },
                        { data: "UName", title: "คำอธิบาย" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                var html = "<input type='text' class='QtyCons' id='txtServices'/>";
                                return html;
                            }
                        }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });

                $('#btnApplyCons').on('click', function () {
                    $('#frmSearchSUnt').modal('hide');
                });
                $('#frmSearchSUnt').modal('show');
                break;
            case 'CURRENCY':
                //popup for search data
                $('#tbCurr').DataTable({
                    ajax: {
                        url: path + 'Master/GetCurrency', //web service ที่จะ call ไปดึงข้อมูลมา
                        dataSrc: 'currency.data'
                    },
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "Code", title: "รหัส" },
                        { data: "TName", title: "คำอธิบาย" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                var html = "<button class='btn btn-warning'>Select</button>";
                                return html;
                            }
                        }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                $('#tbCurr tbody').on('click', 'button', function () {
                    var dt = GetSelect('#tbCurr', this);
                    $('#txtInvCurrency').val(dt.Code);
                    $('#frmSearchCurr').modal('hide');
                });
                $('#tbCurr tbody').on('click', 'tr', function () {
                    $('#tbCurr tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                    $(this).addClass('selected'); //select row ใหม่
                });
                $('#frmSearchCurr').modal('show');
                break;
            case 'CUSTOMER':
                //popup for search data
                $('#tbCust').DataTable({
                    ajax: {
                        url: path + 'Master/GetCompany', //web service ที่จะ call ไปดึงข้อมูลมา
                        dataSrc: 'company.data'
                    },
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "CustCode", title: "รหัส" },
                        { data: "Branch", title: "สาขา" },
                        { data: "NameThai", title: "คำอธิบาย" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                var html = "<button class='btn btn-warning'>Select</button>";
                                return html;
                            }
                        }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                $('#tbCust tbody').on('click', 'button', function () {
                    var dt = GetSelect('#tbCust', this);
                    $('#txtCustCode').val(dt.CustCode);
                    $('#txtCustBranch').val(dt.Branch);
                    ShowCustomer(dt.CustCode, dt.Branch, false);
                    $('#frmSearchCust').modal('hide');
                });
                $('#tbCust tbody').on('click', 'tr', function () {
                    $('#tbCust tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                    $(this).addClass('selected'); //select row ใหม่
                });
                $('#frmSearchCust').modal('show');
                break;
            case 'CONSIGNEE':
                //popup for search data
                $('#tbCons').DataTable({
                    ajax: {
                        url: path + 'Master/GetCompany', //web service ที่จะ call ไปดึงข้อมูลมา
                        dataSrc: 'company.data'
                    },
                    selected: true, //ให้สามารถเลือกแถวได้
                    columns: [ //กำหนด property ของ header column
                        { data: null, title: "#" },
                        { data: "CustCode", title: "รหัส" },
                        { data: "Branch", title: "สาขา" },
                        { data: "NameThai", title: "คำอธิบาย" }
                    ],
                    "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                        {
                            "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                            "data": null,
                            "render": function (data, type, full, meta) {
                                var html = "<button class='btn btn-warning'>Select</button>";
                                return html;
                            }
                        }
                    ],
                    destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                });
                $('#tbCons tbody').on('click', 'button', function () {
                    var dt = GetSelect('#tbCons', this);
                    $('#txtConsignee').val(dt.CustCode);
                    $('#txtConsBranch').val(dt.Branch);
                    ShowCustomer(dt.CustCode, dt.Branch, true);
                    $('#frmSearchCons').modal('hide');
                });
                $('#tbCons tbody').on('click', 'tr', function () {
                    $('#tbCons tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                    $(this).addClass('selected'); //select row ใหม่
                });
                $('#frmSearchCons').modal('show');
                break;
            case 'ProjectName':
                //popup for search data
                $.get(path + 'joborder/getjobdatadistinct?field=' + type)
                    .done(function (r) {
                        var dr = r[0].Table;
                        if (dr.length > 0) {
                            $('#tbProj').DataTable({
                                data: dr, //web service ที่จะ call ไปดึงข้อมูลมา
                                selected: true, //ให้สามารถเลือกแถวได้
                                columns: [ //กำหนด property ของ header column
                                    { data: null, title: "#" },
                                    { data: "val", title: "ชื่อโครงการ" }
                                ],
                                "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                                    {
                                        "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                                        "data": null,
                                        "render": function (data, type, full, meta) {
                                            var html = "<button class='btn btn-warning'>Select</button>";
                                            return html;
                                        }
                                    }
                                ],
                                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                            });
                            $('#tbProj tbody').on('click', 'button', function () {
                                var dt = GetSelect('#tbProj', this);
                                $('#txtProjectName').val(dt.val);
                                $('#frmSearchProj').modal('hide');
                            });
                            $('#tbProj tbody').on('click', 'tr', function () {
                                $('#tbProj tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                                $(this).addClass('selected'); //select row ใหม่
                            });
                            $('#frmSearchProj').modal('show');
                        }
                    });
                break;
            case 'InvProduct':
                //popup for search data
                $.get(path + 'joborder/getjobdatadistinct?field=' + type)
                    .done(function (r) {
                        var dr = r[0].Table;
                        if (dr.length > 0) {
                            $('#tbProd').DataTable({
                                data: dr, //web service ที่จะ call ไปดึงข้อมูลมา
                                selected: true, //ให้สามารถเลือกแถวได้
                                columns: [ //กำหนด property ของ header column
                                    { data: null, title: "#" },
                                    { data: "val", title: "ชื่อสินค้า" }
                                ],
                                "columnDefs": [ //กำหนด control เพิ่มเติมในแต่ละแถว
                                    {
                                        "targets": 0, //column ที่ 0 เป็นหมายเลขแถว
                                        "data": null,
                                        "render": function (data, type, full, meta) {
                                            var html = "<button class='btn btn-warning'>Select</button>";
                                            return html;
                                        }
                                    }
                                ],
                                destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                            });
                            $('#tbProd tbody').on('click', 'button', function () {
                                var dt = GetSelect('#tbProd', this);
                                $('#txtInvProduct').val(dt.val);
                                $('#frmSearchProd').modal('hide');
                            });
                            $('#tbProd tbody').on('click', 'tr', function () {
                                $('#tbProd tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
                                $(this).addClass('selected'); //select row ใหม่
                            });
                            $('#frmSearchProd').modal('show');
                        }
                    });
                break;

        }
    }
    function ShowInterPort(CountryID, PortCode) {
        $('#txtInterPortName').val('');
        $.get(path + 'Master/GetInterPort?Code=' + PortCode + '&Key=' + CountryID)
            .done(function (r) {
                if (r.interport.data.length > 0) {
                    var b = r.interport.data[0];
                    $('#txtInterPortName').val(b.PortName);
                }
            });
    }
    function ShowVender(VenderID, ControlID) {
        $(ControlID).val('');
        if (VenderID != "") {
            $.get(path + 'Master/GetVender?Code=' + VenderID)
                .done(function (r) {
                    if (r.vender.data.length > 0) {
                        var b = r.vender.data[0];
                        $(ControlID).val(b.TName);
                    }
                });
        }
    }
    function ShowCountry(CountryID,ControlID) {
        $(ControlID).val('');
        if (CountryID != "") {
            $.get(path + 'Master/GetCountry?Code=' + CountryID)
                .done(function (r) {
                    if (r.country.data.length > 0) {
                        var b = r.country.data[0];
                        $(ControlID).val(b.CTYName);
                    }
                });
        }
    }
    function ShowUser(UserID, ControlID) {
        $(ControlID).val('');
        if (UserID != "") {
            $.get(path + 'Master/GetUser?Code=' + UserID)
                .done(function (r) {
                    if (r.user.data.length > 0) {
                        var b = r.user.data[0];
                        $(ControlID).val(b.TName);
                    }
                });
        }
    }
    function ShowBranch(Branch) {
        $('#txtBranchName').val('');
        $.get(path + 'Config/GetBranch?Code=' + Branch)
            .done(function (r) {
                if (r.branch.data.length > 0) {
                    var b = r.branch.data[0];
                    $('#txtBranchName').val(b.BrName);
                }
            });
    }
    function ShowDeclareType(Code) {
        $('#txtDeclareTypeName').val('');
        $.get(path + 'Master/GetDeclareType?Code=' + Code)
            .done(function (r) {
                if (r.RFDCT.data.length > 0) {
                    var b = r.RFDCT.data[0];
                    $('#txtDeclareTypeName').val(b.Description);
                }
            });
    }
    function ShowReleasePort(Code) {
        $('#txtReleasePortName').val('');
        $.get(path + 'Master/GetCustomsPort?Code=' + Code)
            .done(function (r) {
                if (r.RFARS.data.length > 0) {
                    var b = r.RFARS.data[0];
                    $('#txtReleasePortName').val(b.AreaName);
                }
            });
    }
    function ShowJobTypeShipBy(jt, sb, js) {
        $('#txtJobType').val('');
        $('#txtShipBy').val('');
        $('#txtJobStatus').val('');
        if (jt < 10) jt = '0' + jt;
        if (sb < 10) sb = '0' + sb;
        if (js < 10) js = '0' + js;
        $.get(path + 'Config/GetConfig?Code=JOB_TYPE&Key=' + jt)
            .done(function (r) {
                var b = r.config.data;
                if (b.length > 0) {
                    $('#txtJobType').val(b[0].ConfigValue);
                }
            });
        $.get(path + 'Config/GetConfig?Code=SHIP_BY&Key=' + sb)
            .done(function (r) {
                var b = r.config.data;
                if (b.length > 0) {
                    $('#txtShipBy').val(b[0].ConfigValue);
                }
            });
        $.get(path + 'Config/GetConfig?Code=JOB_STATUS&Key=' + js)
            .done(function (r) {
                var b = r.config.data;
                if (b.length > 0) {
                    $('#txtJobStatus').val(b[0].ConfigValue);
                }
            });
    }
    function ShowCustomer(Code, Branch, isCons) {
        if ((Code + Branch).length > 0) {
            if (isCons == true) {
                $('#txtConsignName').val('');
                $('#txtBillEAddress').val('');
                $('#txtBillTAddress').val('');
            }
            if (isCons == false) {
                $('#txtCustName').val('');
                $('#txtEAddress').val('');
                $('#txtTAddress').val('');
                $('#txtPhoneFax').val('');
            }
            $.get(path + 'Master/GetCompany?Code=' + Code + '&Branch=' + Branch)
                .done(function (r) {
                    if (r.company.data.length > 0) {
                        var c = r.company.data[0];
                        if (isCons == true) {
                            $('#txtConsignName').val(c.NameThai);
                            $('#txtBillEAddress').val((c.EAddress1 + ' ' + c.EAddress2).trim());
                            $('#txtBillTAddress').val((c.TAddress1 + ' ' + c.TAddress2).trim());
                        }
                        if (isCons == false) {
                            $('#txtCustName').val(c.NameThai);
                            $('#txtEAddress').val((c.EAddress1 + ' ' + c.EAddress2).trim());
                            $('#txtTAddress').val((c.TAddress1 + ' ' + c.TAddress2).trim());
                            $('#txtPhoneFax').val(c.Phone);
                        }
                    }
                });
        }
    }
    function ShowJob(Branch, Job) {
        $.get(path + 'joborder/getjobsql?branchcode=' + Branch + '&jno=' + Job)
            .done(function (r) {
                if (r.job.data.length > 0) {
                    var dr = r.job.data[0];
                    $('#txtCustCode').val(dr.CustCode);
                    $('#txtCustBranch').val(dr.CustBranch);
                    ShowCustomer(dr.CustCode, dr.CustBranch, false);
                    ShowJobTypeShipBy(dr.JobType, dr.ShipBy, dr.JobStatus)
                    $('#txtRevised').val(dr.JRevised);
                    $('#txtDocDate').val(CDate(dr.DocDate));
                    $('#txtQNo').val(dr.QNo);
                    $('#txtQRevise').val(dr.Revised);
                    $('#txtCustInvNo').val(dr.InvNo);
                    $('#txtDeclareNo').val(dr.DeclareNumber);
                    ShowUser(dr.ManagerCode, '#txtManagerCode');
                    $('#txtCommission').val(dr.Commission);
                    $('#txtContactName').val(dr.CustContactName);
                    ShowUser(dr.CSCode, '#txtCSName');
                    $('#txtConfirmDate').val(CDate(dr.ConfirmDate));
                    ShowUser(dr.CloseJobBy, '#txtCloseBy');
                    $('#txtJobCondition').val(dr.TRemark);
                    $('#txtCloseDate').val(CDate(dr.CloseJobDate));
                    $('#txtCustPoNo').val(dr.CustRefNO);
                    $('#txtDescription').val(dr.Description);
                    $('#txtCancelReason').val(dr.CancelReson);
                    ShowUser(dr.CancelProve, '#txtCancelBy');
                    $('#txtConsignee').val(dr.consigneecode);
                    $('#txtConsBranch').val(dr.CustBranch);
                    ShowCustomer(dr.consigneecode, dr.CustBranch,true);
                    $('#txtCancelDate').val(CDate(dr.CancelDate));
                    $('#txtProjectName').val(dr.ProjectName);
                    $('#txtInvProduct').val(dr.InvProduct);
                    $('#txtInvQty').val(dr.InvProductQty);
                    $('#txtInvUnit').val(dr.InvProductUnit);
                    $('#txtInvPackQty').val(dr.TotalQty);
                    $('#txtInvTotal').val(dr.InvTotal);
                    $('#txtMeasurement').val(dr.Measurement);
                    $('#txtNetWeight').val(dr.TotalNW);
                    $('#txtGrossWeight').val(dr.TotalGW);
                    $('#txtWeightUnit').val(dr.GWUnit);
                    $('#txtInvCurrency').val(dr.InvCurUnit);
                    $('#txtInvCurRate').val(dr.InvCurRate);
                    $('#txtInvCountryCode').val(dr.InvCountry);
                    $('#txtInvFCountryCode').val(dr.InvFCountry);
                    ShowCountry(dr.InvCountry, '#txtInvCountry');
                    ShowCountry(dr.InvFCountry, '#txtInvFCountry');
                    $('#txtBookingNo').val(dr.BookingNo);
                    $('#txtBLNo').val(dr.BLNo);
                    $('#txtHAWB').val(dr.HAWB);
                    $('#txtMAWB').val(dr.MAWB);
                    $('#txtForwarder').val(dr.ForwarderCode);
                    ShowVender(dr.ForwarderCode, '#txtForwarderName');
                    $('#txtVesselName').val(dr.VesselName);
                    $('#txtMVesselName').val(dr.MVesselName);
                    $('#txtInterPort').val(dr.InvInterPort);
                    if (dr.JobType==1) {
                        ShowInterPort(dr.InvCountry, dr.InvInterPort);
                    } else {
                        ShowInterPort(dr.InvFCountry, dr.InvInterPort);
                    }
                    $('#txtTransporter').val(dr.AgentCode);
                    ShowVender(dr.AgentCode, '#txtTransporterName');
                    $('#txtTotalCTN').val(dr.TotalContainer);
                    $('#txtETDDate').val(CDate(dr.ETDDate));
                    $('#txtETADate').val(CDate(dr.ETADate));
                    $('#txtLoadDate').val(CDate(dr.LoadDate));
                    $('#txtDeliveryDate').val(CDate(dr.EstDeliverDate));
                    $('#txtEDIDate').val(CDate(dr.ImExDate));
                    $('#txtReadyClearDate').val(CDate(dr.ReadyToClearDate));
                    $('#txtDutyDate').val(CDate(dr.DutyDate));
                    $('#txtClearDate').val(CDate(dr.ClearDate));
                    $('#txtDeclareType').val(dr.DeclareType);
                    ShowDeclareType(dr.DeclareType);
                    $('#txtReleasePort').val(dr.ClearPort);
                    ShowReleasePort(dr.ClearPort);
                    $('#txtDutyAmt').val(dr.DutyAmount);
                    $('#txtShipping').val(dr.ShippingEmp);
                    ShowUser(dr.ShippingEmp, '#txtShippingName');
                    $('#txtShippingCmd').val(dr.ShippingCmd);

                    $('#txtComPaidChq').val(dr.DutyLtdPayChqAmt);
                    $('#txtComPaidCash').val(dr.DutyLtdPayCashAmt);
                    $('#txtComPaidEPay').val(dr.DutyLtdPayEPAYAmt);
                    $('#txtComPaidOthers').val(dr.DutyLtdPayOtherAmt);
                    $('#txtComOthersPayBy').val(dr.DutyLtdPayOther);
                    $('#txtComPaidTotal').val(dr.DutyLtdPayChqAmt + dr.DutyLtdPayCashAmt + dr.DutyLtdPayEPAYAmt + dr.DutyLtdPayOtherAmt);
                    $('#txtCustPaidChq').val(dr.DutyCustPayChqAmt);
                    $('#txtCustPaidCash').val(dr.DutyCustPayCashAmt);
                    $('#txtCustPaidCard').val(dr.DutyCustPayCardAmt);
                    $('#txtCustPaidBank').val(dr.DutyCustPayBankAmt);
                    $('#txtCustPaidEPay').val(dr.DutyCustPayEPAYAmt);
                    $('#txtCustPaidOthers').val(dr.DutyCustPayOtherAmt);
                    $('#txtCustOthersPayBy').val(dr.DutyCustPayOther);
                    $('#txtCustPaidTotal').val(dr.DutyCustPayChqAmt + dr.DutyCustPayCashAmt + dr.DutyCustPayEPAYAmt + dr.DutyCustPayOtherAmt+ dr.DutyCustPayCardAmt+dr.DutyCustPayBankAmt);
                }
            });
    }
</script>
