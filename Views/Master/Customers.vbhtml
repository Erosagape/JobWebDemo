
@Code
    ViewBag.Title = "Customers"
End Code
<div class="panel-body">
    <div class="container">
        <div class="row">
            <div class="col-sm-3">
                CustCode :<br /><input type="text" id="txtCustCode" class="form-control" tabIndex="1">
            </div>
            <div class="col-sm-3">
                Branch :<br /><input type="text" id="txtBranch" class="form-control" tabIndex="2">
            </div>
            <div class="col-sm-3">
                CustGroup :<br /><input type="text" id="txtCustGroup" class="form-control" tabIndex="3">
            </div>
            <div class="col-sm-3">
                TaxNumber :<br /><input type="text" id="txtTaxNumber" class="form-control" tabIndex="4">
            </div>
        </div>
        <div class="row">
            <div class="col-sm-2">
                Title :<br /><input type="text" id="txtTitle" class="form-control" tabIndex="5">
            </div>
            <div class="col-sm-5">
                NameThai :<br /><input type="text" id="txtNameThai" class="form-control" tabIndex="6">
            </div>
            <div class="col-sm-5">
                NameEng :<br /><input type="text" id="txtNameEng" class="form-control" tabIndex="7">
            </div>
        </div>
        <ul class="nav nav-tabs">
            <li class="active"><a data-toggle="tab" href="#tabCust1">Information</a></li>
            <li><a data-toggle="tab" href="#tabCust2">Billing</a></li>
            <li><a data-toggle="tab" href="#tabCust3">Configuration</a></li>
        </ul>
        <div class="tab-content">
            <div id="tabCust1" class="tab-pane fade in active">
                <div class="row">
                    <div class="col-sm-6">
                        TAddress1 :<br /><input type="text" id="txtTAddress1" class="form-control" tabIndex="8">
                        TAddress2 :<br /><input type="text" id="txtTAddress2" class="form-control" tabIndex="9">
                    </div>
                    <div class="col-sm-6">
                        EAddress1 :<br /><input type="text" id="txtEAddress1" class="form-control" tabIndex="10">
                        EAddress2 :<br /><input type="text" id="txtEAddress2" class="form-control" tabIndex="11">
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-3">
                        Phone :<br /><input type="text" id="txtPhone" class="form-control" tabIndex="12">
                    </div>
                    <div class="col-sm-3">
                        FaxNumber :<br /><input type="text" id="txtFaxNumber" class="form-control" tabIndex="13">
                    </div>
                    <div class="col-sm-3">
                        EMailAddress :<br /><input type="text" id="txtDMailAddress" class="form-control" tabIndex="14">
                    </div>
                    <div class="col-sm-3">
                        WEB_SITE :<br /><input type="text" id="txtWEB_SITE" class="form-control" tabIndex="15">
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-3">
                        UsedLanguage :<br /><input type="text" id="txtUsedLanguage" class="form-control" tabIndex="28">
                    </div>
                    <div class="col-sm-3">
                        CustType :<br /><input type="text" id="txtCustType" class="form-control" tabIndex="29" value="0">
                    </div>
                    <div class="col-sm-3">
                        LevelGrade :<br /><input type="text" id="txtLevelGrade" class="form-control" tabIndex="30">
                    </div>
                    <div class="col-sm-3">
                        TermOfPayment :<br /><input type="text" id="txtTermOfPayment" class="form-control" tabIndex="31" value="0">
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-3">
                        BillCondition :<br /><input type="text" id="txtBillCondition" class="form-control" tabIndex="32">
                    </div>
                    <div class="col-sm-3">
                        CreditLimit :<br /><input type="text" id="txtCreditLimit" class="form-control" tabIndex="33" value="0.00">
                    </div>
                    <div class="col-sm-3">
                        DutyLimit :<br /><input type="text" id="txtDutyLimit" class="form-control" tabIndex="34" value="0.00">
                    </div>
                    <div class="col-sm-3">
                        CommRate :<br /><input type="text" id="txtCommRate" class="form-control" tabIndex="35" value="0.00">
                    </div>
                </div>
            </div>
            <div id="tabCust2" class="tab-pane fade">
                <div class="row">
                    <div class="col-sm-6">
                        GLAccountCode :<br /><input type="text" id="txtGLAccountCode" class="form-control" tabIndex="20">
                        BillToCustCode :<br /><input type="text" id="txtBillToCustCode" class="form-control" tabIndex="21">
                        BillToBranch :<br /><input type="text" id="txtBillToBranch" class="form-control" tabIndex="22">
                        <input type="text" id="txtBillToCustName" class="form-control" disabled />
                        <textarea id="txtBillToAddress" class="form-control" disabled></textarea>
                        <button id="btnUpdateAddress" class="btn btn-warning">Update Address</button>
                    </div>
                    <div class="col-sm-6">
                        TAddress :<br /><input type="text" id="txtTAddress" class="form-control" tabIndex="23">
                        TDistrict :<br /><input type="text" id="txtTDistrict" class="form-control" tabIndex="24">
                        TSubProvince :<br /><input type="text" id="txtTSubProvince" class="form-control" tabIndex="25">
                        TProvince :<br /><input type="text" id="txtTProvince" class="form-control" tabIndex="26">
                        TPostCode :<br /><input type="text" id="txtTPostCode" class="form-control" tabIndex="27">
                    </div>
                </div>

            </div>
            <div id="tabCust3" class="tab-pane fade">
                <div class="row">
                    <div class="col-sm-3">
                        ManagerCode :<br /><input type="text" id="txtManagerCode" class="form-control" tabIndex="16">
                    </div>
                    <div class="col-sm-3">
                        CSCodeIM :<br /><input type="text" id="txtCSCodeIM" class="form-control" tabIndex="17">
                    </div>
                    <div class="col-sm-3">
                        CSCodeEX :<br /><input type="text" id="txtCSCodeEX" class="form-control" tabIndex="18">
                    </div>
                    <div class="col-sm-3">
                        CSCodeOT :<br /><input type="text" id="txtCSCodeOT" class="form-control" tabIndex="19">
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-6">
                        ConsStatus :<br /><input type="text" id="txtConsStatus" class="form-control" tabIndex="36">
                    </div>
                    <div class="col-sm-6">
                        CommLevel :<br /><input type="text" id="txtCommLevel" class="form-control" tabIndex="37">
                    </div>
                </div>
            </div>
        </div>
        <div id="dvHidden" style="display:none">
            <input type="hidden" id="txtLoginName" class="form-control">
            <input type="hidden" id="txtLoginPassword" class="form-control">
            <input type="hidden" id="txtMapText" class="form-control">
            <input type="hidden" id="txtMapFileName" class="form-control">
            <input type="hidden" id="txtCmpType" class="form-control">
            <input type="hidden" id="txtCmpLevelExp" class="form-control">
            <input type="hidden" id="txtCmpLevelImp" class="form-control">
            <input type="hidden" id="txtIs19bis" class="form-control" value="0">
            <input type="hidden" id="txtMgrSeq" class="form-control" value="0">
            <input type="hidden" id="txtLevelNoExp" class="form-control" value="0">
            <input type="hidden" id="txtLevelNoImp" class="form-control" value="0">
            <input type="hidden" id="txtLnNO" class="form-control">
            <input type="hidden" id="txtAdjTaxCode" class="form-control">
            <input type="hidden" id="txtBkAuthorNo" class="form-control">
            <input type="hidden" id="txtBkAuthorCnn" class="form-control">
            <input type="hidden" id="txtLtdPsWkName" class="form-control">
            <input type="hidden" id="txtPrivilegeOption" class="form-control">
            <input type="hidden" id="txtGoldCardNO" class="form-control" value="0">
            <input type="hidden" id="txtCustomsBrokerSeq" class="form-control" value="0">
            <input type="hidden" id="txtISCustomerSign" class="form-control" value="0">
            <input type="hidden" id="txtISCustomerSignInv" class="form-control" value="0">
            <input type="hidden" id="txtISCustomerSignDec" class="form-control" value="0">
            <input type="hidden" id="txtISCustomerSignECon" class="form-control" value="0">
            <input type="hidden" id="txtIsShippingCannotSign" class="form-control" value="0">
            <input type="hidden" id="txtExportCode" class="form-control">
            <input type="hidden" id="txtCode19BIS" class="form-control">
        </div>
    </div>
</div>