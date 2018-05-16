
@Code
    ViewBag.Title = "Job Information"
End Code
<head>
    <title>Bootstrap Example</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<div Class="panel-group">
    <div Class="panel-primary">
        <div Class="panel-heading">
            <h4 Class="panel-title">
                @ViewBag.Title
            </h4>
        </div>
        <div Class="panel-body">
            <div class="container">
                <label for="txtBranchCode">Branch :</label><input type="text" style="width:30px" id="txtBranchCode" disabled />
                <input type="text" style="width:120px" id="txtBranchName" disabled />
                <label for="txtJNo">Job No :</label><input type="text" style="width:120px" id="txtJNo" disabled />
                <label for="txtRevised">Revised :</label><input type="text" style="width:30px" id="txtRevised" disabled />
                <label for="txtDocDate">Open Date :</label><input type="text" style="width:80px" id="txtDocDate" disabled />
                <label for="txtDocDate">Job Status :</label><input type="text" style="width:150px" id="txtJobStatus" disabled />

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
                                <input type="text" id="txtContactName" style="width:200px" />
                                <label for="txtCSName">Support By :</label>
                                <input type="text" id="txtCSName" style="width:200px" disabled />
                            </div>
                            <div class="col-md-4">
                                <label for="txtConfirmDate">Confirm Date :</label>
                                <input type="text" id="txtConfirmDate" style="width:80px" />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-8">
                                <label for="txtJobType">Job Type : </label>
                                <input type="text" id="txtJobType" style="width:230px" disabled />
                                <label for="txtShipBy">Ship By : </label>
                                <input type="text" id="txtShipBy" style="width:230px" disabled />
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
                                <textarea id="txtDescription" style="width:200px"></textarea>
                                <label for="txtCancelReason">Cancel Note : </label>
                                <textarea id="txtCancelReason" style="width:200px"></textarea>
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
                                <textarea id="txtBillTAddress" style="width:250px" disabled></textarea>
                                <textarea id="txtBillEAddress" style="width:250px" disabled></textarea>
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
                                <input type="text" id="txtCustInvNo" style="width:250px" />
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
                                <input type="text" id="txtInvProduct" style="width:250px" />
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
                                <input type="text" id="txtMeasurement" style="width:60px" />
                            </div>
                            <div class="col-md-7">
                                <label for="txtNetWeight">Net Weight :</label>
                                <input type="text" id="txtNetWeight" style="width:80px" />
                                <label for="txtGrossWeight">Gross Weight :</label>
                                <input type="text" id="txtGrossWeight" style="width:80px" />
                                <input type="text" id="txtWeightUnit" style="width:40px" />
                                <input type="button" id="btnBrowseMeas" value="..." />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-5">
                                <label for="txtInvCurrency">Currency :</label>
                                <input type="text" id="txtInvCurrency" style="width:60px" />
                                <input type="button" id="btnBrowseRate" value="..." />
                                <label for="txtInvCurRate">Exchange Rate :</label>
                                <input type="text" id="txtInvCurRate" style="width:80px" />
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
                                <input type="text" id="txtBLNo" style="width:250px" />
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
                                <input type="text" id="txtVesselName" style="width:230px" />
                                <input type="button" id="btnBrowseVsl1" value="..." />
                            </div>
                            <div class="col-md-7">
                                <label for="txtMVesselName">Master Vessel Name :</label>
                                <input type="text" id="txtMVesselName" style="width:230px" />
                                <input type="button" id="btnBrowseVsl2" value="..." />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-5">
                                <label for="txtInterPort">Inter Port:</label>
                                <input type="text" id="txtInterPort" style="width:80px" />
                                <input type="button" id="btnBrowseIPort" value="..." />
                                <input type="text" id="txtInterPortName" style="width:180px" disabled />
                            </div>
                            <div class="col-md-7">
                                <label for="txtTransporter">Transporter :</label>
                                <input type="text" id="txtTransporter" style="width:80px" />
                                <input type="button" id="btnBrowseTrans" value="..." />
                                <input type="text" id="txtTransporterName" style="width:200px" disabled />
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
                                <input type="text" id="txtDeliverTo" style="width:150px" />
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
                            <div class="col-md-6">
                                <label for="txtShipping">Shipping :</label>
                                <input type="text" id="txtShipping" style="width:80px" />
                                <input type="button" id="btnBrowseShipping" value="..." />
                                <input type="text" id="txtShippingName" style="width:200px" disabled />
                            </div>
                            <div class="col-md-6">
                                <label for="txtShippingCmd">Shipping Note :</label>
                                <input type="text" id="txtShippingCmd" style="width:400px" />
                            </div>
                        </div>
                    </div>
                    <div id="menu3" class="tab-pane fade">
                        <h3>Menu 3</h3>
                        <p>Some content in menu 3.</p>
                    </div>
                    <div id="menu4" class="tab-pane fade">
                        <h3>Menu 4</h3>
                        <p>Some content in menu 4.</p>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>

