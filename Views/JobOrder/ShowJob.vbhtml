@Code
    ViewBag.Title = "Job Information"
End Code
<div Class="panel-body">
    <div class="container">
        <div class="row">
            <div class="col-sm-3">                               
                <div style="display:flex;flex-direction:row">
                    <label id="lblBranchCode">Branch Code:</label>
                    <input type="text" class="form-control" style="width:50px" id="txtBranchCode" disabled />
                    <input type="text" class="form-control" style="width:100%" id="txtBranchName" disabled />
                </div>
            </div>
            <div class="col-sm-3">
                <div style="display:flex;flex-direction:row">
                    <label id="lblJNo">Job Number:</label>
                    <input type="text" class="form-control" style="width:100%;background-color:yellow;color:red;font-weight:bold" id="txtJNo" disabled />
                    <input type="text" class="form-control" style="width:50px" id="txtRevised" disabled />
                </div>
            </div>
            <div class="col-sm-3">
                <div style="display:flex;flex-direction:row">
                    <label id="lblDocDate">Open Date:</label>
                    <input type="date" class="form-control" id="txtDocDate" disabled />
                </div>
            </div>
            <div class="col-sm-3">
                <div style="display:flex;flex-direction:row">
                    <label id="lblJobStatus">Job Status:</label>
                    <input type="text" class="form-control" style="width:100%;background-color:aquamarine;font-weight:bold" id="txtJobStatus" disabled />
                </div>
            </div>
        </div>               
        <p>
            <ul class="nav nav-tabs">
                <li class="active"><a data-toggle="tab" href="#tabinfo">Job Descriptions</a></li>
                <li><a data-toggle="tab" href="#tabinv">Invoice Description</a></li>
                <li><a data-toggle="tab" href="#tabdeclare">Customs Description</a></li>
                <li><a data-toggle="tab" href="#tabtracking">Job Document Tracking</a></li>
                <li><a data-toggle="tab" href="#tabremark">Other Controls</a></li>
            </ul>
            <div class="tab-content">
                <div id="tabinfo" class="tab-pane fade in active">
                    <div class="row">
                        <div class="col-md-8">
                            <label for="txtCustCode" onclick="window.open('/Master/Customers');">Customer :</label>
                            <input type="text" id="txtCustCode" style="width:130px" tabindex="0" />
                            <input type="text" id="txtCustBranch" style="width:40px" tabindex="1" />
                            <input type="button" id="btnBrowseCust" value="..." onclick="SearchData('CUSTOMER')" />
                            <input type="text" id="txtCustName" style="width:450px" disabled />
                            <br />
                            <label for="txtTAddress">Address   :</label>
                            <textarea id="txtTAddress" style="width:250px" disabled></textarea>
                            <textarea id="txtEAddress" style="width:250px" disabled></textarea>
                            <br />
                            <label for="txtPhoneFax">Contact Info :</label>
                            <input type="text" id="txtPhoneFax" style="width:550px" tabindex="2" />
                            <br />
                            <label for="txtConsignee">Billing Place :</label>
                            <input type="text" id="txtConsignee" style="width:130px" tabindex="7" />
                            <input type="text" id="txtConsBranch" style="width:40px" tabindex="8" />
                            <input type="button" id="btnBrowseCons" value="..." onclick="SearchData('CONSIGNEE')" />
                            <input type="text" id="txtConsignName" style="width:450px" disabled />
                            <br />
                            <label for="txtBillTAddress">Address   :</label>
                            <textarea id="txtBillTAddress" style="width:200px" disabled></textarea>
                            <textarea id="txtBillEAddress" style="width:200px" disabled></textarea>
                            <br />
                            <input type="checkbox" id="chkTSRequest" />
                            <label for="chkTSRequest">Use Local Transport</label>
                            <br />
                            <label for="txtContactName">Contact Person :</label>
                            <input type="text" id="txtContactName" style="width:150px" tabindex="3" />
                            <label for="txtCSName">Support By :</label>
                            <input type="text" id="txtCSName" style="width:150px" disabled />
                            <br />
                            <label for="txtJobType">Job Type : </label>
                            <input type="text" id="txtJobType" style="width:150px" disabled />
                            <label for="txtShipBy">Ship By : </label>
                            <input type="text" id="txtShipBy" style="width:150px" disabled />
                            <br />
                            <label for="txtJobCondition">Work Condition :</label>
                            <input type="text" id="txtJobCondition" style="width:600px" tabindex="4" />
                            <br />
                            <label for="txtCustPoNo">Customer PO :</label>
                            <input type="text" id="txtCustPoNo" style="width:300px" tabindex="5" />
                            <br />
                            <label for="txtDescription">Descriptions : </label>
                            <textarea id="txtDescription" style="width:180px" tabindex="6"></textarea>

                        </div>
                        <div class="col-md-4">
                            <label for="txtQNo">Quotation : </label>
                            <input type="text" id="txtQNo" style="width:130px" tabindex="9" />
                            <input type="text" id="txtQRevise" style="width:40px" tabindex="10" />
                            <br />
                            <label for="txtManagerCode">Sales By :</label>
                            <input type="text" id="txtManagerCode" style="width:130px" disabled />
                            <br />
                            <label for="txtCommission">Commission :</label>
                            <input type="text" id="txtCommission" style="width:130px" tabindex="11" />
                            <br />
                            <label for="txtConfirmDate">Confirm Date :</label>
                            <input type="date" id="txtConfirmDate" style="width:130px" tabindex="12" />
                            <br />
                            <label for="txtCloseBy">Close By :</label>
                            <input type="text" id="txtCloseBy" style="width:130px" disabled />
                            <br />
                            <label for="txtCloseDate">Close Date : </label>
                            <input type="date" id="txtCloseDate" style="width:130px" disabled />
                            <br />
                            <input type="button" id="btnCloseJob" class="btn btn-warning" value="Close Job" onclick="CloseJob()" style="width:130px" />
                            <br />
                            <label for="txtCancelBy">Cancel By :</label>
                            <input type="text" id="txtCancelBy" style="width:130px" disabled />
                            <br />
                            <label for="txtCancelDate">Cancel Date :</label>
                            <input type="date" id="txtCancelDate" style="width:130px" disabled />
                            <br />
                            <label for="txtCancelReason">Cancel Note : </label>
                            <textarea id="txtCancelReason" style="width:180px"></textarea>
                            <br />
                            <input type="button" id="btnCancelJob" class="btn btn-danger" value="Cancel Job" onclick="CancelJob()" style="width:130px" />
                        </div>
                    </div>
                </div>
                <div id="tabinv" class="tab-pane fade">
                    <div class="row">
                        <div class="col-md-5">
                            <label for="txtCustInvNo">Cust.Invoice No :</label>
                            <input type="text" id="txtCustInvNo" style="width:200px" tabindex="13" disabled />
                            <br />
                            <label for="txtInvProduct">Products :</label>
                            <input type="text" id="txtInvProduct" style="width:200px" tabindex="14" />
                            <input type="button" id="btnBrowseProd" value="..." onclick="SearchData('InvProduct')" />
                            <br />
                            <label for="txtInvTotal">Inv.Total :</label>
                            <input type="text" id="txtInvTotal" style="width:130px" tabindex="15" />
                            <br />
                            <label for="txtInvCurrency" onclick="window.open('/Master/Currency');">Currency :</label>
                            <input type="text" id="txtInvCurrency" style="width:40px" tabindex="17" />
                            <input type="button" id="btnBrowseRate" value="..." onclick="SearchData('CURRENCY')" />
                            <label for="txtInvCurRate">Exchange Rate :</label>
                            <input type="text" id="txtInvCurRate" style="width:60px" tabindex="18" />
                            <br />
                            <label for="txtBookingNo">Booking No :</label>
                            <input type="text" id="txtBookingNo" style="width:250px" tabindex="19" />
                            <br />
                            <label for="txtBLNo">BL/AWB Status :</label>
                            <input type="text" id="txtBLNo" style="width:200px" tabindex="20" />
                            <br />
                            <label for="txtVesselName">Vessel Name :</label>
                            <input type="text" id="txtVesselName" style="width:200px" tabindex="21" />
                            <input type="button" id="btnBrowseVsl1" value="..." onclick="SearchData('vessel')" />
                            <br />
                            <label for="txtInterPort" onclick="window.open('/Master/InterPort');">Inter Port:</label>
                            <input type="text" id="txtInterPort" style="width:130px" tabindex="22" />
                            <input type="button" id="btnBrowseIPort" value="..." onclick="SearchData('interport')" />
                            <input type="text" id="txtInterPortName" style="width:160px" disabled />
                            <br />
                            <label for="txtTotalCTN">Total Containers :</label>
                            <input type="text" id="txtTotalCTN" style="width:130px" tabindex="23" />
                            <input type="button" id="btnGetCTN" value="..." onclick="SplitData()" />
                            <br />
                            <label for="txtMeasurement">Measurement(M3) :</label>
                            <input type="text" id="txtMeasurement" style="width:80px" tabindex="16" />
                            <br />
                            <label for="txtDeliverNo">Delivery No :</label>
                            <input type="text" id="txtDeliverNo" style="width:130px" tabindex="41" />
                            <label for="txtDeliveryDate">Delivery Date :</label><input type="date" style="width:130px" id="txtDeliveryDate" tabindex="42" />
                        </div>
                        <div class="col-md-7">
                            <label for="txtProjectName">Project Name :</label>
                            <input type="text" id="txtProjectName" style="width:400px" tabindex="24" />
                            <input type="button" id="btnBrowseProj" value="..." onclick="SearchData('ProjectName')" />
                            <br />
                            <label for="txtInvQty">Qty :</label>
                            <input type="text" id="txtInvQty" style="width:130px" tabindex="25" />
                            <input type="text" id="txtInvUnit" style="width:40px" tabindex="26" />
                            <input type="button" id="btnBrowseUnit" value="..." onclick="SearchData('invproductunit')" />
                            <label for="txtInvPackQty">Package.Total :</label>
                            <input type="text" id="txtInvPackQty" style="width:130px" tabindex="27" />
                            <br />
                            <label for="txtNetWeight">Net Weight :</label>
                            <input type="text" id="txtNetWeight" style="width:80px" tabindex="28" />
                            <label for="txtGrossWeight">Gross Weight :</label>
                            <input type="text" id="txtGrossWeight" style="width:80px" tabindex="29" />
                            <input type="text" id="txtWeightUnit" style="width:60px" tabindex="30" />
                            <input type="button" id="btnBrowseMeas" value="..." onclick="SearchData('GWUnit')" />
                            <br />
                            <label for="txtInvFCountry">From Country :</label>
                            <input type="hidden" id="txtInvFCountryCode" />
                            <input type="text" id="txtInvFCountry" style="width:130px" disabled />
                            <input type="button" id="btnBrowseFCountry" value="..." onclick="SearchData('fcountry')" tabindex="31" />
                            <label for="txtInvCountry">To :</label>
                            <input type="hidden" id="txtInvCountryCode" />
                            <input type="text" id="txtInvCountry" style="width:130px" disabled />
                            <input type="button" id="btnBrowseCountry" value="..." onclick="SearchData('country')" tabindex="32" />
                            <br />
                            <label for="txtHAWB">House BL/AWB :</label>
                            <input type="text" id="txtHAWB" style="width:130px" tabindex="33" />
                            <label for="txtMAWB">Master BL/AWB :</label>
                            <input type="text" id="txtMAWB" style="width:130px" tabindex="34" />
                            <br />
                            <label for="txtForwarder" onclick="window.open('/Master/Venders');">Agent:</label>
                            <input type="text" id="txtForwarder" style="width:130px" tabindex="35" />
                            <input type="button" id="btnBrowseFwdr" value="..." onclick="SearchData('forwarder')" />
                            <input type="text" id="txtForwarderName" style="width:300px" disabled />
                            <br />
                            <label for="txtMVesselName">Master Vessel Name :</label>
                            <input type="text" id="txtMVesselName" style="width:200px" tabindex="36" />
                            <input type="button" id="btnBrowseVsl2" value="..." onclick="SearchData('mvessel')" />
                            <br />
                            <label for="txtTransporter">Transporter :</label>
                            <input type="text" id="txtTransporter" style="width:130px" tabindex="37" />
                            <input type="button" id="btnBrowseTrans" value="..." onclick="SearchData('agent')" />
                            <input type="text" id="txtTransporterName" style="width:250px" disabled />
                            <br />
                            <label for="txtETDDate">ETD Date:</label><input type="date" style="width:130px" id="txtETDDate" tabindex="38" />
                            <label for="txtETADate">ETA Date:</label><input type="date" style="width:130px" id="txtETADate" tabindex="39" />
                            <label for="txtLoadDate">Load Date:</label><input type="date" style="width:130px" id="txtLoadDate" tabindex="40" />
                            <br />
                            <label for="txtDeliverTo">Delivery To :</label>
                            <input type="text" id="txtDeliverTo" style="width:300px" tabindex="43" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <label for="txtDeliverAddr">Delivery Address :</label>
                            <input type="text" id="txtDeliverAddr" style="width:400px" tabindex="44" />
                            <input type="button" class="btn btn-info" value="Print Delivery Slip" onclick="PrintDelivery()" />
                        </div>
                    </div>
                </div>
                <div id="tabdeclare" class="tab-pane fade">
                    <div class="row">
                        <div class="col-md-3">
                            <label for="txtEDIDate">EDI Date :</label>
                            <input type="date" id="txtEDIDate" style="width:130px" tabindex="43" />
                        </div>
                        <div class="col-md-3">
                            <label for="txtReadyClearDate">Ready Clear :</label>
                            <input type="date" id="txtReadyClearDate" style="width:130px" tabindex="44" />
                        </div>
                        <div class="col-md-3">
                            <label for="txtDutyDate">Duty Date :</label>
                            <input type="date" id="txtDutyDate" style="width:130px" tabindex="45" />
                        </div>
                        <div class="col-md-3">
                            <label for="txtClearDate">Clear Date :</label>
                            <input type="date" id="txtClearDate" style="width:130px" tabindex="46" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <label for="txtDeclareType" onclick="window.open('/Master/DeclareType');">Declare Type :</label>
                            <input type="text" id="txtDeclareType" style="width:130px" tabindex="47" />
                            <input type="button" id="btnBrowseDCType" value="..." onclick="SearchData('RFDCT')" />
                            <input type="text" id="txtDeclareTypeName" style="width:200px" disabled />
                        </div>
                        <div class="col-md-3">
                            <label for="txtDeclareNo">Declare No :</label>
                            <input type="text" id="txtDeclareNo" style="width:130px" tabindex="48" />
                        </div>
                        <div class="col-md-3">
                            <label for="txtDutyAmt">Duty Amt :</label>
                            <input type="text" id="txtDutyAmt" style="width:130px" tabindex="49" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-4">
                            <input type="checkbox" id="chkTyAuthorSp" />
                            <label for="chkTyAuthorSp">Special Privilege</label>
                            <select id="cboTyAuthorSp" class="dropdown"></select>
                        </div>
                        <div class="col-md-4">
                            <input type="checkbox" id="chkTy19BIS" />
                            <label for="chkTy19BIS">19 BIS Rule</label>
                            <select id="cboTy19BIS" class="dropdown"></select>
                        </div>
                        <div class="col-md-4">
                            <input type="checkbox" id="chkTyClearTax" />
                            <label for="chkTyClearTax">Duty Rule</label>
                            <select id="cboTyClearTax" class="dropdown"></select>
                            <input type="text" id="txtClearTaxReson" tabindex="50" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5">
                            <label for="optDeclareStatus">Declaration Status :</label>
                            <label class="radio-inline"><input type="radio" name="optDeclareStatus" value="G"><label style="color:green;font:bold">Green</label></label>
                            <label class="radio-inline"><input type="radio" name="optDeclareStatus" value="R"><label style="color:red;font:bold">Red</label></label>
                            <label class="radio-inline"><input type="radio" name="optDeclareStatus" value="M"><label style="color:blue;font:bold">Manual</label></label>
                        </div>
                        <div class="col-md-7">
                            <label for="txtReleasePort" onclick="window.open('/Master/CustomsPort');">Release Port :</label>
                            <input type="text" id="txtReleasePort" style="width:50px" tabindex="51" />
                            <input type="button" id="btnBrowseLCPort" value="..." onclick="SearchData('RFARS')" />
                            <input type="text" id="txtReleasePortName" style="width:200px" disabled />
                            <label for="txtPortNo">PORT#</label>
                            <input type="text" id="txtPortNo" style="width:30px" tabindex="52" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <label for="txtShipping">Shipping Staff :</label>
                            <input type="text" id="txtShipping" style="width:130px" tabindex="53" />
                            <input type="button" id="btnBrowseShipping" value="..." onclick="SearchData('user')" />
                            <input type="text" id="txtShippingName" style="width:200px" disabled />
                        </div>
                        <div class="col-md-6">
                            <label for="txtShippingCmd">Shipping Note :</label>
                            <input type="text" id="txtShippingCmd" style="width:400px" tabindex="54" />
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
                                        <input type="text" id="txtComPaidChq" style="width:130px" onchange="CalTotalLtd();" tabindex="55" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        Cash:
                                    </td>
                                    <td>
                                        <input type="text" id="txtComPaidCash" style="width:130px" onchange="CalTotalLtd();" tabindex="56" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        E-Payment:
                                    </td>
                                    <td>
                                        <input type="text" id="txtComPaidEPay" style="width:130px" onchange="CalTotalLtd();" tabindex="57" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        Others:<input type="text" id="txtComOthersPayBy" style="width:130px" tabindex="58" />
                                    </td>
                                    <td>
                                        <input type="text" id="txtComPaidOthers" style="width:130px" onchange="CalTotalLtd();" tabindex="59" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        Total Paid:
                                    </td>
                                    <td>
                                        <input type="text" id="txtComPaidTotal" style="width:130px" disabled />
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
                                        <input type="text" id="txtCustPaidChq" style="width:130px" onchange="CalTotalCust();" tabindex="60" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        Cash:
                                    </td>
                                    <td>
                                        <input type="text" id="txtCustPaidCash" style="width:130px" onchange="CalTotalCust();" tabindex="61" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        Tax-Card:
                                    </td>
                                    <td>
                                        <input type="text" id="txtCustPaidCard" style="width:130px" onchange="CalTotalCust();" tabindex="62" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        E-Payment:
                                    </td>
                                    <td>
                                        <input type="text" id="txtCustPaidEPay" style="width:130px" onchange="CalTotalCust();" tabindex="63" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        Bank Guarantee:
                                    </td>
                                    <td>
                                        <input type="text" id="txtCustPaidBank" style="width:130px" onchange="CalTotalCust();" tabindex="64" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        Others:<input type="text" id="txtCustOthersPayBy" style="width:130px" tabindex="65" />
                                    </td>
                                    <td>
                                        <input type="text" id="txtCustPaidOthers" style="width:130px" onchange="CalTotalCust();" tabindex="66" /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>
                                        Total Paid:
                                    </td>
                                    <td>
                                        <input type="text" id="txtCustPaidTotal" style="width:130px" disabled />
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <input type="button" id="btnViewTAdv" class="btn btn-default" value="Credit Advances" onclick="OpenCreditAdv()" />
                        </div>
                        <div class="col-md-6">
                            <input type="button" id="btnViewChq" class="btn btn-default" value="Customer Cheques" onclick="OpenCheque()" />
                        </div>
                    </div>
                </div>
                <div id="tabtracking" class="tab-pane fade">
                    <table id="tbTracking" class="table table-responsive">
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
                                    Expenses
                                </th>
                                <th>
                                    Amount
                                </th>
                                <th>
                                    Status
                                </th>
                            </tr>
                        </thead>
                        <tbody></tbody>
                    </table>
                </div>
                <div id="tabremark" class="tab-pane fade">
                    <div class="row">
                        <div class="col-md-12">
                            <table id="tbLog" class="table table-responsive">
                                <thead>
                                    <tr>
                                        <th>
                                            Date
                                        </th>
                                        <th>
                                            Action
                                        </th>
                                        <th>
                                            User
                                        </th>
                                    </tr>
                                </thead>
                                <tbody></tbody>
                            </table>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <input type="button" class="btn btn-default" id="btnLinkDoc" value="Document Files" onclick="OpenDocument()" />
                            <input type="button" class="btn btn-default" id="btnLinkLoad" value="Transport Info" onclick="OpenTransport()" />
                            <input type="button" class="btn btn-default" id="btnLinkExp" value="Estimate Expenses" onclick="OpenExpense()" />
                            <input type="button" class="btn btn-default" id="btnLinkTAdv" value="Credit Advance" onclick="OpenCreditAdv()" />
                            <input type="button" class="btn btn-warning" id="btnLinkAdv" value="Advance Request" onclick="OpenAdvance()" />
                            <input type="button" class="btn btn-success" id="btnLinkClr" value="Advance Clearing" onclick="OpenClearing()" />
                            <input type="button" class="btn btn-danger" id="btnLinkCost" value="Cost & Profit" onclick="OpenCosting()" />
                        </div>
                    </div>
                </div>
            </div>
            <a href="#" class="btn btn-success" id="btnSave" onclick="SaveData()">
                <i class="fa fa-lg fa-save"></i>&nbsp;<b>Save</b>
            </a>
            <a href="#" class="btn btn-info" id="btnPrint" onclick="PrintData()">
                <i class="fa fa-lg fa-print"></i>&nbsp;<b>Print</b>
            </a>
        </p>
        <div id="frmContainerEdit" class="modal fade" role="dialog">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal"></button>
                        <h4 class="modal-title"><label id="lblHeader">Services Summary</label></h4>
                    </div>
                    <div class="modal-body">
                        Qty : <input type="text" id="txtQtyAdd" />
                        Unit : <input type="text" id="txtUnitAdd" disabled />
                        <input type="button" id="btnBrowseSUnt" value="..." onclick="SearchData('SERVUNIT')" />
                        <button type="button" class="btn btn-success" id="btnAddCons" onclick="AddService()">Add Service</button>
                        <div id="frmSearchSUnt">
                            <table id="tbSUnt" class="table table-responsive">
                                <thead>
                                    <tr>
                                        <th>
                                        <th>Code</th>
                                        <th>Name</th>
                                    </tr>
                                </thead>
                            </table>
                        </div>
                        <div id="dvSplit"></div>
                    </div>
                    <div class="modal-footer">
                        Total Container : <input type="text" id="txtTotalCon" disabled />
                        <button type="button" class="btn btn-primary" id="btnSaveCons" onclick="ApplyService()">Update Value</button>
                        <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>
        <div id="frmLOVs"></div>
    </div>
</div>
<script type="text/javascript">
    //define letiables
    const path = '@Url.Content("~")';
    const user = '@ViewBag.User';
    const userRights = '@ViewBag.UserRights';
    let rec = {};
    //main function
    //$(document).ready(function () {
    SetLOVs();
    SetEvents();
    //check parameters
    let br = getQueryString('BranchCode');
    let jno = getQueryString('JNo');
    if (br != "" && jno != "") {
        $('#txtBranchCode').val(br);
        ShowBranch(path, br, '#txtBranchName');
        ShowJob(br, jno);
    }
    SetEnterToTab();
    if (userRights.indexOf('E') < 0) $('#btnSave').attr('disabled', 'disabled');
    if (userRights.indexOf('P') < 0) $('#btnPrint').attr('disabled', 'disabled');
    //});
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
                    $('[tabindex="1"]').focus();
                }
            });
        });
        $('#txtCustCode').focus();
    }
    function SetEvents() {
        $('#txtTransporter').keydown(function (event) {
            if (event.which == 13) {
                ShowVender(path, $('#txtTransporter').val(), '#txtTransporterName');
            }
        });
        $('#txtForwarder').keydown(function (event) {
            if (event.which == 13) {
                ShowVender(path, $('#txtForwarder').val(), '#txtForwarderName');
            }
        });
        $('#txtShipping').keydown(function (event) {
            if (event.which == 13) {
                ShowUser(path, $('#txtShipping').val(), '#txtShippingName');
            }
        });
        $('#txtCustBranch').keydown(function (event) {
            if (event.which == 13) {
                ShowCustomerFull(path, $('#txtCustCode').val(), $('#txtCustBranch').val(), '#txtCustName', '#txtTAddress', '#txtEAddress', '#txtPhoneFax');
            }
        });
        $('#txtConsBranch').keydown(function (event) {
            if (event.which == 13) {
                ShowCustomerFull(path, $('#txtConsignee').val(), $('#txtConsBranch').val(), '#txtConsignName', '#txtBillTAddress', '#txtBillEAddress', '');
            }
        });
        $('#txtReleasePort').keydown(function (event) {
            if (event.which == 13) {
                ShowReleasePort(path, $('#txtReleasePort').val(), '#txtReleasePortName');
            }
        });
        $('#txtInterPort').keydown(function (event) {
            if (event.which == 13) {
                ShowInterPort(path, $('#txtJobType').val() == 'IMPORT' ? $('#txtInvFCountryCode').val() : $('#txtInvCountryCode').val(), $('#txtInterPort').val(), '#txtInterPortName');
            }
        });
        $('#txtDeclareType').keydown(function (event) {
            if (event.which == 13) {
                ShowDeclareType(path,$('#txtDeclareType').val(), '#txtDeclareTypeName');
            }
        });
        $('#frmContainerEdit').on('shown.bs.modal', function () {
            $('#txtQtyAdd').focus();
        });
    }
    function SetLOVs() {
        //3 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            let dv = document.getElementById("frmLOVs");
            //Customers
            CreateLOV(dv,'#frmSearchCust', '#tbCust','Customers',response,3);
            //Consignee
            CreateLOV(dv,'#frmSearchCons', '#tbCons','Consignees',response,3);
            //Inter Port
            CreateLOV(dv,'#frmSearchIPort', '#tbIPort','International Port',response,3);

            //2 Fields
            //Users
            CreateLOV(dv,'#frmSearchUser', '#tbUser','Users',response,2);
            //Declare Type
            CreateLOV(dv,'#frmSearchDType', '#tbDType','Declare Type',response,2);
            //Customs Port
            CreateLOV(dv,'#frmSearchCPort', '#tbCPort','Customs Port',response,2);
            //Currency
            CreateLOV(dv,'#frmSearchCurr', '#tbCurr','Currency',response,2);
            //Country
            CreateLOV(dv,'#frmSearchCountry', '#tbCountry', 'Country', response,2);
            //FCountry
            CreateLOV(dv,'#frmSearchFCountry', '#tbFCountry','Country',response,2);
            //Agent
            CreateLOV(dv,'#frmSearchVend', '#tbVend','Venders', response,2);
            //Forwarder/Transporter
            CreateLOV(dv,'#frmSearchForw', '#tbForw','Venders',response,2);

            //1 Fields
            //Projects Name
            CreateLOV(dv,'#frmSearchProj', '#tbProj', 'Project Name',response,1);
            //Products
            CreateLOV(dv,'#frmSearchProd', '#tbProd', 'Products',response,1);
            //Vessel
            CreateLOV(dv,'#frmSearchVessel', '#tbVessel', 'Vessels',response,1);
            //Mother Vessel
            CreateLOV(dv,'#frmSearchMVessel', '#tbMVessel','Mother Vessels',response,1);
            //Inv Units
            CreateLOV(dv,'#frmSearchIUnt', '#tbIUnt','Invoice Units',response,2);
            //Weights Unit
            CreateLOV(dv,'#frmSearchWUnt', '#tbWUnt', 'Weight Unit',response,2);
        });
        //load list of values
        let lists = 'CUSTOMS_PRIVILEGE=#cboTyAuthorSp';
        lists += ',CUSTOMS_19BIS=#cboTy19BIS';
        lists += ',CUSTOMS_EXPENSES=#cboTyClearTax';
        loadCombos(path, lists);
    }
    //This section is for popup searching function
    function ReadInterPort(dt) {
        $('#txtInterPort').val(dt.PortCode);
        $('#txtInterPortName').val(dt.PortName);
        $('#txtInterPort').focus();
    }
    function ReadTransporter(dt) {
        $('#txtTransporter').val(dt.VenCode);
        $('#txtTransporterName').val(dt.TName);
        $('#txtTransporter').focus();
    }
    function ReadForwarder(dt) {
        $('#txtForwarder').val(dt.VenCode);
        $('#txtForwarderName').val(dt.TName);
        $('#txtForwarder').focus();
    }
    function ReadCountry(dt) {
        $('#txtInvCountry').val(dt.CTYName);
        $('#txtInvCountryCode').val(dt.CTYCODE);
    }
    function ReadFCountry(dt) {
        $('#txtInvFCountry').val(dt.CTYName);
        $('#txtInvFCountryCode').val(dt.CTYCODE);
    }
    function ReadGWUnit(dt) {
        $('#txtWeightUnit').val(dt.Code);
        $('#txtWeightUnit').focus();
    }
    function ReadInvUnit(dt) {
        $('#txtInvUnit').val(dt.Code);
        $('#txtInvUnit').focus();
    }
    function ReadVessel(dt) {
        $('#txtVesselName').val(dt.TName);
        $('#txtVesselName').focus();
    }
    function ReadMVessel(dt) {
        $('#txtMVesselName').val(dt.TName);
        $('#txtMVesselName').focus();
    }
    function ReadShipping(dt) {
        $('#txtShipping').val(dt.UserID);
        $('#txtShippingName').val(dt.TName);
        $('#txtShipping').focus();
    }
    function ReadDeclareType(dt) {
        $('#txtDeclareType').val(dt.Type);
        $('#txtDeclareTypeName').val(dt.Description);
        $('#txtDeclareType').focus();
    }
    function ReadCustomsPort(dt) {
        $('#txtReleasePort').val(dt.AreaCode);
        $('#txtReleasePortName').val(dt.AreaName);
        $('#txtReleasePort').focus();
    }
    function ReadCurrency(dt) {
        $('#txtInvCurrency').val(dt.Code);
        $('#txtInvCurrency').focus();
    }
    function ReadCustomer(dt) {
        $('#txtCustCode').val(dt.CustCode);
        $('#txtCustBranch').val(dt.Branch);
        ShowCustomerFull(path, dt.CustCode, dt.Branch, '#txtCustName', '#txtTAddress', '#txtEAddress', '#txtPhoneFax');
        $('#txtCustCode').focus();
    }
    function ReadConsignee(dt) {
        $('#txtConsignee').val(dt.CustCode);
        $('#txtConsBranch').val(dt.Branch);
        ShowCustomerFull(path, dt.CustCode, dt.Branch, '#txtConsignName', '#txtBillTAddress', '#txtBillEAddress', '');
        $('#txtConsignee').focus();
    }
    function ReadInvProduct(dt) {
        $('#txtInvProduct').val(dt.val);
        $('#txtInvProduct').focus();
    }
    function ReadProjectName(dt) {
        $('#txtProjectName').val(dt.val);
        $('#txtProjectName').focus();
    }
    function SearchData(type) {
        switch (type) {
            case 'interport':
                let CountryID = $('#txtJobType').val() == "IMPORT" ? $('#txtInvFCountryCode').val() : $('#txtInvCountryCode').val();
                SetGridInterPort(path, '#tbIPort', '#frmSearchIPort', CountryID, ReadInterPort);
                break;
            case 'agent':
                SetGridVender(path, '#tbVend', '#frmSearchVend', ReadTransporter);
                break;
            case 'forwarder':
                SetGridVender(path, '#tbForw', '#frmSearchForw', ReadForwarder);
                break;
            case 'country':
                SetGridCountry(path, '#tbCountry', '#frmSearchCountry', ReadCountry);
                break;
            case 'fcountry':
                SetGridCountry(path, '#tbFCountry', '#frmSearchFCountry', ReadFCountry);
                break;
            case 'GWUnit':
                SetGridUnit(path, '#tbWUnt', '#frmSearchWUnt', ReadGWUnit);
                break;
            case 'invproductunit':
                SetGridUnit(path, '#tbIUnt', '#frmSearchIUnt', ReadInvUnit);
                break;
            case 'mvessel':
                SetGridVessel(path, '#tbMVessel', '#frmSearchMVessel', 'M', ReadMVessel);
                break;
            case 'vessel':
                SetGridVessel(path, '#tbVessel', '#frmSearchVessel', '', ReadVessel);
                break;
            case 'user':
                SetGridUser(path, '#tbUser', '#frmSearchUser', ReadShipping);
                break;
            case 'RFDCT':
                SetGridDeclareType(path, '#tbDType', '#frmSearchDType', ReadDeclareType);
                break;
            case 'RFARS':
                SetGridCustomsPort(path, '#tbCPort', '#frmSearchCPort', ReadCustomsPort);
                break;
            case 'CURRENCY':
                SetGridCurrency(path, '#tbCurr', '#frmSearchCurr', ReadCurrency);
                break;
            case 'CUSTOMER':
                SetGridCompanyByGroup(path, '#tbCust', 'CUSTOMERS', '#frmSearchCust', ReadCustomer);
                break;
            case 'CONSIGNEE':
                SetGridCompanyByGroup(path, '#tbCons','CONSIGNEE', '#frmSearchCons', ReadConsignee);
                break;
            case 'ProjectName':
                SetGridProjectName(path, '#tbProj', '#frmSearchProj', ReadProjectName);
                break;
            case 'InvProduct':
                SetGridInvProduct(path, '#tbProd', '#frmSearchProd', ReadInvProduct);
                break;
            case 'SERVUNIT':
                SetContainerEdit();
                break;
        }
    }
    //This section for calculate amount of duty payment
    function CalTotalLtd() {
        let ltd1 = Number($('#txtComPaidChq').val());
        let ltd2 = Number($('#txtComPaidCash').val());
        let ltd3 = Number($('#txtComPaidEPay').val());
        let ltd4 = Number($('#txtComPaidOthers').val());

        $('#txtComPaidTotal').val(ltd1 + ltd2 + ltd3 + ltd4);
    }
    function CalTotalCust() {
        let cust1 = Number($('#txtCustPaidChq').val());
        let cust2 = Number($('#txtCustPaidCash').val());
        let cust3 = Number($('#txtCustPaidCard').val());
        let cust4 = Number($('#txtCustPaidBank').val());
        let cust5 = Number($('#txtCustPaidEPay').val());
        let cust6 = Number($('#txtCustPaidOthers').val());

        $('#txtCustPaidTotal').val(cust1 + cust2 + cust3 + cust4 + cust5 + cust6);
    }
    //This section for Load Data And Print data
    function ShowJob(Branch, Job) {
        $.get(path + 'joborder/getjobsql?branch=' + Branch + '&jno=' + Job)
            .done(function (r) {
                if (r.job.data.length > 0) {
                    let dr = r.job.data[0];
                    rec = dr;
                    $('#txtJNo').val(dr.JNo);
                    $('#txtCustCode').val(dr.CustCode);
                    $('#txtCustBranch').val(dr.CustBranch);
                    ShowCustomerFull(path,dr.CustCode, dr.CustBranch, '#txtCustName', '#txtTAddress', '#txtEAddress', '#txtPhoneFax');
                    ShowJobTypeShipBy(path,dr.JobType, dr.ShipBy, dr.JobStatus, '#txtJobType', '#txtShipBy', '#txtJobStatus');
                    $('#txtRevised').val(dr.JRevise);
                    $('#txtDocDate').val(CDateEN(dr.DocDate));
                    $('#txtQNo').val(dr.QNo);
                    $('#txtQRevise').val(dr.Revise);
                    $('#txtCustInvNo').val(dr.InvNo);
                    $('#txtDeclareNo').val(dr.DeclareNumber);
                    ShowUser(path,dr.ManagerCode, '#txtManagerCode');
                    $('#txtCommission').val(dr.Commission);
                    $('#txtContactName').val(dr.CustContactName);
                    ShowUser(path,dr.CSCode, '#txtCSName');
                    $('#txtConfirmDate').val(CDateEN(dr.ConfirmDate));
                    ShowUser(path,dr.CloseJobBy, '#txtCloseBy');
                    $('#txtJobCondition').val(dr.TRemark);
                    $('#txtCloseDate').val(CDateEN(dr.CloseJobDate));
                    $('#txtCustPoNo').val(dr.CustRefNO);
                    $('#txtDescription').val(dr.Description);
                    $('#txtCancelReason').val(dr.CancelReson);
                    ShowUser(path,dr.CancelProve, '#txtCancelBy');
                    $('#txtConsignee').val(dr.consigneecode);
                    $('#txtConsBranch').val(dr.CustBranch);
                    ShowCustomerFull(path,dr.consigneecode, dr.CustBranch, '#txtConsignName', '#txtBillTAddress', '#txtBillEAddress', '');

                    $('#txtCancelDate').val(CDateEN(dr.CancelDate));
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

                    $('#cboTyAuthorSp').val(dr.TyAuthorSp);
                    $('#cboTy19BIS').val(dr.Ty19BIS);
                    $('#cboTyClearTax').val(dr.TyClearTax);
                    $('#txtClearTaxReson').val(dr.TyClearTaxReson);

                    $('#chkTSRequest').prop('checked', dr.TSRequest === 1 ? true : false);
                    $('#chkTyAuthorSp').prop('checked', $('#cboTyAuthorSp').val()==='' ? false : true);
                    $('#chkTy19BIS').prop('checked', $('#cboTy19BIS').val() === '' ? false : true);
                    $('#chkTyClearTax').prop('checked', $('#cboTyClearTax').val() === '' ? false : true);

                    $('input:radio[name=optDeclareStatus]:checked').prop('checked', false);
                    $('input:radio[name=optDeclareStatus][value="' + dr.DeclareStatus + '"]').prop('checked', true);

                    $('#txtInvCurrency').val(dr.InvCurUnit);
                    $('#txtInvCurRate').val(dr.InvCurRate);
                    $('#txtInvCountryCode').val(dr.InvCountry);
                    $('#txtInvFCountryCode').val(dr.InvFCountry);
                    ShowCountry(path,dr.InvCountry, '#txtInvCountry');
                    ShowCountry(path,dr.InvFCountry, '#txtInvFCountry');
                    $('#txtBookingNo').val(dr.BookingNo);
                    $('#txtBLNo').val(dr.BLNo);
                    $('#txtHAWB').val(dr.HAWB);
                    $('#txtMAWB').val(dr.MAWB);
                    $('#txtForwarder').val(dr.ForwarderCode);
                    ShowVender(path,dr.ForwarderCode, '#txtForwarderName');
                    $('#txtVesselName').val(dr.VesselName);
                    $('#txtMVesselName').val(dr.MVesselName);
                    $('#txtInterPort').val(dr.InvInterPort);
                    ShowInterPort(path, dr.JobType == 1 ? dr.InvFCountry : dr.InvCountry, dr.InvInterPort, '#txtInterPortName');
                    $('#txtTransporter').val(dr.AgentCode);
                    ShowVender(path,dr.AgentCode, '#txtTransporterName');
                    $('#txtTotalCTN').val(dr.TotalContainer);
                    $('#txtETDDate').val(CDateEN(dr.ETDDate));
                    $('#txtETADate').val(CDateEN(dr.ETADate));
                    $('#txtLoadDate').val(CDateEN(dr.LoadDate));
                    $('#txtDeliveryDate').val(CDateEN(dr.EstDeliverDate));
                    $('#txtEDIDate').val(CDateEN(dr.ImExDate));
                    $('#txtReadyClearDate').val(CDateEN(dr.ReadyToClearDate));
                    $('#txtDutyDate').val(CDateEN(dr.DutyDate));
                    $('#txtClearDate').val(CDateEN(dr.ClearDate));
                    $('#txtDeclareType').val(dr.DeclareType);
                    ShowDeclareType(path,dr.DeclareType, '#txtDeclareTypeName');
                    $('#txtReleasePort').val(dr.ClearPort);
                    $('#txtPortNo').val(dr.ClearPortNo);
                    ShowReleasePort(path,dr.ClearPort, '#txtReleasePortName');
                    $('#txtDutyAmt').val(dr.DutyAmount);
                    $('#txtShipping').val(dr.ShippingEmp);
                    ShowUser(path,dr.ShippingEmp, '#txtShippingName');
                    $('#txtShippingCmd').val(dr.ShippingCmd);

                    $('#txtComPaidChq').val(dr.DutyLtdPayChqAmt);
                    $('#txtComPaidCash').val(dr.DutyLtdPayCashAmt);
                    $('#txtComPaidEPay').val(dr.DutyLtdPayEPAYAmt);
                    $('#txtComPaidOthers').val(dr.DutyLtdPayOtherAmt);
                    $('#txtComOthersPayBy').val(dr.DutyLtdPayOther);

                    $('#txtCustPaidChq').val(dr.DutyCustPayChqAmt);
                    $('#txtCustPaidCash').val(dr.DutyCustPayCashAmt);
                    $('#txtCustPaidCard').val(dr.DutyCustPayCardAmt);
                    $('#txtCustPaidBank').val(dr.DutyCustPayBankAmt);
                    $('#txtCustPaidEPay').val(dr.DutyCustPayEPAYAmt);
                    $('#txtCustPaidOthers').val(dr.DutyCustPayOtherAmt);
                    $('#txtCustOthersPayBy').val(dr.DutyCustPayOther);

                    CalTotalLtd();
                    CalTotalCust();

                    $('#txtDeliverNo').val(dr.DeliveryNo);
                    $('#txtDeliverTo').val(dr.DeliveryTo);
                    $('#txtDeliverAddr').val(dr.DeliveryAddr);

                    if (dr.JobStatus >= 7) {
                        $('#btnSave').attr('disabled', 'disabled');
                    }
                }
            });

        $.get(path + 'joborder/getjobdocument?branch=' + Branch + '&job=' + Job)
            .done(function (r) {
                if (r.job.data.length > 0) {
                    let d = r.job.data;
                    $('#tbTracking').DataTable({
                        data: d,
                        selected: true, //ให้สามารถเลือกแถวได้
                        columns: [ //กำหนด property ของ header column
                            {
                                data: "DocDate", title: "Doc Date",
                                render: function (data) {
                                    return CDateEN(data);
                                }
                            },
                            { data: "DocType", title: "Type" },
                            { data: "DocNo", title: "Doc No" },
                            { data: "Expense", title: "Description" },
                            { data: "Amount", title: "Amount" },
                            { data: "DocStatus", title: "Status" }
                        ],
                        destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
                    });
                }
            });
    }
    function PrintData() {
        window.open(path + 'JobOrder/FormJob?BranchCode=' + $('#txtBranchCode').val() + '&JNo=' + $('#txtJNo').val(), '', '');
    }
    function PrintDelivery() {
        window.open(path + 'JobOrder/FormDelivery?Branch=' + $('#txtBranchCode').val() + '&Doc=' + $('#txtDeliverNo').val(), '', '');
    }
    function OpenAdvance() {
        window.open(path + 'Adv/Index?BranchCode=' + $('#txtBranchCode').val() + '&JNo=' + $('#txtJNo').val(), '', '');
    }
    function OpenCreditAdv() {
        window.open(path + 'Adv/CreditAdv?BranchCode=' + $('#txtBranchCode').val() + '&JNo=' + $('#txtJNo').val(), '', '');
    }

    function OpenClearing() {
        window.open(path + 'Clr/Index?BranchCode=' + $('#txtBranchCode').val() + '&JNo=' + $('#txtJNo').val(), '', '');
    }
    function OpenTransport() {
        window.open(path + 'JobOrder/Transport?BranchCode=' + $('#txtBranchCode').val() + '&JNo=' + $('#txtJNo').val(), '', '');
    }
    function OpenDocument() {
        window.open(path + 'Tracking/Document?BranchCode=' + $('#txtBranchCode').val() + '&JNo=' + $('#txtJNo').val(), '', '');
    }
    function OpenExpense() {
        window.open(path + 'Adv/EstimateCost?BranchCode=' + $('#txtBranchCode').val() + '&JNo=' + $('#txtJNo').val(), '', '');
    }
    function OpenCosting() {
        window.open(path + 'Clr/Costing?BranchCode=' + $('#txtBranchCode').val() + '&JNo=' + $('#txtJNo').val(), '', '');
    }
    function OpenCheque() {
        window.open(path + 'Acc/Cheque?BranchCode=' + $('#txtBranchCode').val() + '&JNo=' + $('#txtJNo').val(), '', '');
    }

    function GetDataSave(dr) {
        dr.CustCode = $('#txtCustCode').val();
        dr.CustBranch = $('#txtCustBranch').val();
        dr.JRevise = Number($('#txtRevised').val()) + 1;
        dr.DocDate= CDateTH($('#txtDocDate').val());
        dr.QNo=$('#txtQNo').val();
        dr.Revise=$('#txtQRevise').val();
        dr.InvNo=$('#txtCustInvNo').val();
        dr.DeclareNumber=$('#txtDeclareNo').val();
        dr.Commission=$('#txtCommission').val();
        dr.CustContactName=$('#txtContactName').val();
        dr.ConfirmDate=CDateTH($('#txtConfirmDate').val());

        dr.TRemark = $('#txtJobCondition').val();

        dr.CloseJobDate = CDateTH($('#txtCloseDate').val());

        dr.CustRefNO=$('#txtCustPoNo').val();
        dr.Description = $('#txtDescription').val();

        dr.CancelDate = CDateTH($('#txtCancelDate').val());
        dr.CancelReson=$('#txtCancelReason').val();

        dr.Consigneecode=$('#txtConsignee').val();

        dr.ProjectName=$('#txtProjectName').val();
        dr.InvProduct=$('#txtInvProduct').val();
        dr.InvProductQty = CNum($('#txtInvQty').val());
        dr.InvProductUnit=$('#txtInvUnit').val();
        dr.TotalQty = CNum($('#txtInvPackQty').val());
        dr.InvTotal = CNum($('#txtInvTotal').val());
        dr.Measurement=$('#txtMeasurement').val();
        dr.TotalNW = CNum($('#txtNetWeight').val());
        dr.TotalGW = CNum($('#txtGrossWeight').val());
        dr.GWUnit=$('#txtWeightUnit').val();
        dr.InvCurUnit=$('#txtInvCurrency').val();
        dr.InvCurRate = CNum($('#txtInvCurRate').val());
        dr.InvCountry=$('#txtInvCountryCode').val();
        dr.InvFCountry = $('#txtInvFCountryCode').val();

        dr.BookingNo=$('#txtBookingNo').val();
        dr.BLNo=$('#txtBLNo').val();
        dr.HAWB=$('#txtHAWB').val();
        dr.MAWB=$('#txtMAWB').val();
        dr.ForwarderCode=$('#txtForwarder').val();

        dr.VesselName=$('#txtVesselName').val();
        dr.MVesselName=$('#txtMVesselName').val();
        dr.InvInterPort=$('#txtInterPort').val();
        dr.AgentCode=$('#txtTransporter').val();

        dr.TotalContainer = $('#txtTotalCTN').val();

        dr.ETDDate = CDateTH($('#txtETDDate').val());
        dr.ETADate = CDateTH($('#txtETADate').val());
        dr.LoadDate = CDateTH($('#txtLoadDate').val());
        dr.EstDeliverDate = CDateTH($('#txtDeliveryDate').val());
        dr.ImExDate = CDateTH($('#txtEDIDate').val());
        dr.ReadyToClearDate = CDateTH($('#txtReadyClearDate').val());
        dr.DutyDate = CDateTH($('#txtDutyDate').val());

        dr.ClearDate = CDateTH($('#txtClearDate').val());
        dr.ClearPort = $('#txtReleasePort').val();
        dr.ClearPortNo = $('#txtPortNo').val();

        dr.ShippingEmp=$('#txtShipping').val();
        dr.ShippingCmd=$('#txtShippingCmd').val();

        dr.DutyAmount = CNum($('#txtDutyAmt').val());
        dr.DutyLtdPayChqAmt = CNum($('#txtComPaidChq').val());
        dr.DutyLtdPayCashAmt = CNum($('#txtComPaidCash').val());
        dr.DutyLtdPayEPAYAmt = CNum($('#txtComPaidEPay').val());
        dr.DutyLtdPayOtherAmt = CNum($('#txtComPaidOthers').val());
        dr.DutyLtdPayOther = CNum($('#txtComOthersPayBy').val());

        dr.DutyCustPayChqAmt = CNum($('#txtCustPaidChq').val());
        dr.DutyCustPayCashAmt = CNum($('#txtCustPaidCash').val());
        dr.DutyCustPayCardAmt = CNum($('#txtCustPaidCard').val());
        dr.DutyCustPayBankAmt = CNum($('#txtCustPaidBank').val());
        dr.DutyCustPayEPAYAmt = CNum($('#txtCustPaidEPay').val());
        dr.DutyCustPayOtherAmt = CNum($('#txtCustPaidOthers').val());
        dr.DutyCustPayOther = CNum($('#txtCustOthersPayBy').val());

        dr.TSRequest = $('#chkTSRequest').prop('checked');
        dr.DeclareType = $('#txtDeclareType').val();
        dr.DeclareStatus = $('input:radio[name=optDeclareStatus]:checked').val() == undefined ? '' : $('input:radio[name=optDeclareStatus]:checked').val();
        dr.TyAuthorSp = $('#cboTyAuthorSp').val();
        dr.Ty19BIS=$('#cboTy19BIS').val();
        dr.TyClearTax= $('#cboTyClearTax').val();
        dr.TyClearTaxReson = $('#txtClearTaxReson').val();

        dr.DeliveryNo = $('#txtDeliverNo').val();
        dr.DeliveryTo = $('#txtDeliverTo').val();
        dr.DeliveryAddr = $('#txtDeliverAddr').val();

        return dr;
    }
    //This section is For Save Data function
    function CancelJob() {
        if (rec.JobStatus !== 99) {
            if ($('#txtCancelReason').val() !== '') {
                rec.JobStatus = 99;
                rec.CancelProve = user;
                rec.CancelTime = GetTime();
                ShowUser(path, rec.CancelProve, '#txtCancelBy');

                $('#txtCancelDate').val(CDateEN(GetToday()));
                ShowJobTypeShipBy(path, rec.JobType, rec.ShipBy, rec.JobStatus, '#txtJobType', '#txtShipBy', '#txtJobStatus');
                SaveData();
                return;
            } else {
                ShowMessage('Please enter reason of canceling');
                return;
            }
        } else {
            if (user == rec.CancelProve) {
                rec.JobStatus = 0;
                rec.CancelProve = null;
                rec.CancelTime = null;
                rec.CancelDate = null;
                rec.CancelReson = null;
                $('#txtCancelBy').val('');
                $('#txtCancelDate').val('');
                $('#txtCancelReason').val('');
                SaveData();
                $.get(path + 'joborder/updatejobstatus?branch=' + rec.BranchCode + '&JNo=' + rec.JNo, function (r) {
                    ShowJob(rec.BranchCode, rec.JNo);
                    return;
                });
                return;
            }
        }
        ShowMessage('This job already cancelled');
    }
    function CloseJob() {
        if ($('#txtCloseBy').val() == '') {
            if ($('#txtDutyDate').val()=='') {
                ShowMessage('Please Entry Duty Date before close job');
                $('#txtDutyDate').focus();
                return;
            }
            if ($('#txtConfirmDate').val()=='') {
                ShowMessage('Please Entry Confirm Date before close job');
                $('#txtConfirmDate').focus();
                return;
            }
            if (rec.JobStatus < 3) {
                rec.JobStatus = 3;
            }
            rec.CloseJobBy = user;
            rec.CloseJobTime = GetTime();
            ShowUser(path, rec.CloseJobBy, '#txtCloseBy');
            $('#txtCloseDate').val(CDateEN(GetToday()));
            ShowJobTypeShipBy(path, rec.JobType, rec.ShipBy, rec.JobStatus, '#txtJobType', '#txtShipBy', '#txtJobStatus');
            SaveData();
            return;
        } else {
            if (user == rec.CloseJobBy) {
                if (rec.JobStatus == 3) {
                    rec.JobStatus = 0;
                    rec.CloseJobBy = null;
                    rec.CloseJobTime = null;
                    rec.CloseJobDate = null;
                    $('#txtCloseBy').val('');
                    $('#txtCloseDate').val('');
                    SaveData();
                    $.get(path + 'joborder/updatejobstatus?branch=' + rec.BranchCode + '&JNo=' + rec.JNo, function (r) {
                        ShowJob(rec.BranchCode, rec.JNo);
                        return;
                    });
                    return;
                }
            }
        }
        ShowMessage('job is already closed');
    }
    function SaveData() {
        if (rec.JNo != undefined) {
            let obj = GetDataSave(rec);

            let jsonText = JSON.stringify({ data: obj });
            //ShowMessage(jsonText);
            $.ajax({
                url: "@Url.Action("SetJobData", "JobOrder")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (r) {
                    ShowMessage(r.msg);
                },
                error: function (e) {
                    ShowMessage(e);
                }
            });
        } else {
            ShowMessage('No data to save');
        }
    }
    //This section is for Total Container Editing
    function SetContainerEdit() {
        $('#tbSUnt').DataTable({
            ajax: {
                url: path + 'Master/GetServUnit?Type=1', //web service ที่จะ call ไปดึงข้อมูลมา
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
                        let html = "<button class='btn btn-warning'>Select</button>";
                        return html;
                    }
                }
            ],
            destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
        });
        $('#tbSUnt tbody').on('click', 'button', function () {
            let dt = GetSelect('#tbSUnt', this); //read current row selected
            $('#txtUnitAdd').val(dt.UnitType);
            $('#frmSearchSUnt').hide();
        });
        $('#tbSUnt tbody').on('click', 'tr', function () {
            $('#tbSUnt tbody > tr').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
            $(this).addClass('selected'); //select row ใหม่
        });
        $('#frmSearchSUnt').show();
        $('#tbSUnt_filter input').focus();
    }
    function SplitData() {
        let dv = document.getElementById("dvSplit")
        dv.innerHTML = '';
        let str = document.getElementById("txtTotalCTN").value;
        if (str.indexOf(',')>0) {
            let arr = str.split(",");
            for (let i = 0; i < arr.length; i++) {
                AddNewService(arr[i]);
            }
        }
        $('#frmSearchSUnt').hide();

        $('#txtQtyAdd').val('');
        $('#txtUnitAdd').val('');
        SumService();
        $('#frmContainerEdit').modal('show');
    }
    function AddService() {
        AddNewService($('#txtQtyAdd').val() + 'x' + $('#txtUnitAdd').val());
    }
    function AddNewService(val) {
        if (val.indexOf("x") < 0) val = "1x" + val;
        let dv = document.getElementById("dvSplit");

        let text = document.createElement("input");
        text.setAttribute("type", "text");
        text.setAttribute("name", "txtQtyCon");
        text.value = val.split("x")[0];
        dv.appendChild(text);

        let text2 = document.createElement("input");
        text2.setAttribute("type", "text");
        text2.setAttribute("name", "txtUnitCon");
        text2.value = val.split("x")[1];
        dv.appendChild(text2);

        let br = document.createElement("br");
        dv.appendChild(br);
        $('#txtQtyAdd').val('');
        $('#txtUnitAdd').val('');
    }
    function SumService() {
        let c = document.getElementsByName("txtQtyCon");
        let u = document.getElementsByName("txtUnitCon");
        let str = '';
        for (let i = 0; i < c.length; i++) {
            if (u[i].value == '') continue;
            if (str.length > 0) str += ',';
            let q = c[i].value;
            if (q == '') q = '1';
            str += q + 'x' + u[i].value;
        }
        let o = document.getElementById("txtTotalCon");
        o.value = str;
    }
    function ApplyService() {
        SumService();
        $('#txtTotalCTN').val($('#txtTotalCon').val());
        $('#frmContainerEdit').modal('hide');
    }
</script>
