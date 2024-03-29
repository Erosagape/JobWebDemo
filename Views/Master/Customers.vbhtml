﻿
@Code
    ViewBag.Title = "Customers"
End Code
<div class="panel-body">
    <div class="container">
        <div class="row">
            <div class="col-sm-3">
                <a href="#" onclick="SearchData('customer')">Customer Code</a> :<br /><input type="text" id="txtCustCode" class="form-control" tabIndex="0">
            </div>
            <div class="col-sm-3">
                Branch :<br /><input type="text" id="txtBranch" class="form-control" tabIndex="1">
            </div>
            <div class="col-sm-3">
                Customer Group :
                <br />
                <select id="txtCustGroup" class="form-control dropdown" tabIndex="2"></select>
            </div>
            <div class="col-sm-3">
                Tax-Reference :<br /><input type="text" id="txtTaxNumber" class="form-control" tabIndex="3">
            </div>
        </div>
        <div class="row">
            <div class="col-sm-2">
                Title :<br /><input type="text" id="txtTitle" class="form-control" tabIndex="4">
            </div>
            <div class="col-sm-5">
                Name (TH) :<br /><input type="text" id="txtNameThai" class="form-control" tabIndex="5">
            </div>
            <div class="col-sm-5">
                English :<br /><input type="text" id="txtNameEng" class="form-control" tabIndex="6">
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
                        Address (TH) :<br /><input type="text" id="txtTAddress1" class="form-control" tabIndex="7">
                        <br /><input type="text" id="txtTAddress2" class="form-control" tabIndex="8">
                    </div>
                    <div class="col-sm-6">
                        Address (EN) :<br /><input type="text" id="txtEAddress1" class="form-control" tabIndex="9">
                        <br /><input type="text" id="txtEAddress2" class="form-control" tabIndex="10">
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-3">
                        Phone :<br /><input type="text" id="txtPhone" class="form-control" tabIndex="11">
                    </div>
                    <div class="col-sm-3">
                        Fax :<br /><input type="text" id="txtFaxNumber" class="form-control" tabIndex="12">
                    </div>
                    <div class="col-sm-3">
                        EMail :<br /><input type="text" id="txtDMailAddress" class="form-control" tabIndex="13">
                    </div>
                    <div class="col-sm-3">
                        WEB :<br /><input type="text" id="txtWEB_SITE" class="form-control" tabIndex="14">
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-3">
                        Language :<br /><select id="txtUsedLanguage" class="form-control dropdown" tabIndex="15"></select>
                    </div>
                    <div class="col-sm-3">
                        Customer Type :<br />
                        <select id="txtCustType" class="form-control dropdown" tabIndex="16"></select>
                    </div>
                    <div class="col-sm-3">
                        Grade/Level :<br /><input type="text" id="txtLevelGrade" class="form-control" tabIndex="17">
                    </div>
                    <div class="col-sm-3">
                        Payment Term :<br /><input type="text" id="txtTermOfPayment" class="form-control" tabIndex="18" value="0">
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-3">
                        Billing Condition :<br /><input type="text" id="txtBillCondition" class="form-control" tabIndex="19">
                    </div>
                    <div class="col-sm-3">
                        Credit Limit :<br /><input type="text" id="txtCreditLimit" class="form-control" tabIndex="20" value="0.00">
                    </div>
                    <div class="col-sm-3">
                        Duty Limit :<br /><input type="text" id="txtDutyLimit" class="form-control" tabIndex="21" value="0.00">
                    </div>
                    <div class="col-sm-3">
                        Commission Rate :<br /><input type="text" id="txtCommRate" class="form-control" tabIndex="22" value="0.00">
                    </div>
                </div>
            </div>
            <div id="tabCust2" class="tab-pane fade">
                <div class="row">
                    <div class="col-sm-6">
                        GL Code :<br /><input type="text" id="txtGLAccountCode" class="form-control" tabIndex="23">
                        <a href="#" onclick="SearchData('billing')">Billing To</a>:<br /><input type="text" id="txtBillToCustCode" class="form-control" tabIndex="24">
                        Billing Branch :<br /><input type="text" id="txtBillToBranch" class="form-control" tabIndex="25">
                        Billing Name :<input type="text" id="txtBillToCustName" class="form-control" disabled />
                        Billing Address :<textarea id="txtBillToAddress" class="form-control" disabled></textarea>
                    </div>
                    <div class="col-sm-6">
                        BLDG No/Street :<br /><input type="text" id="txtTAddress" class="form-control" tabIndex="26">
                        District :<br /><input type="text" id="txtTDistrict" class="form-control" tabIndex="27">
                        Sub District :<br /><input type="text" id="txtTSubProvince" class="form-control" tabIndex="28">
                        Province :<br /><input type="text" id="txtTProvince" class="form-control" tabIndex="29">
                        PostCode :<br /><input type="text" id="txtTPostCode" class="form-control" tabIndex="30">
                    </div>
                </div>

            </div>
            <div id="tabCust3" class="tab-pane fade">
                <div class="row">
                    <div class="col-sm-3">
                        <a href="#" onclick="SearchData('sales')">Sales</a>:<br /><input type="text" id="txtManagerCode" class="form-control" tabIndex="31">
                    </div>
                    <div class="col-sm-3">
                        <a href="#" onclick="SearchData('csimport')">CS Import</a> :<br /><input type="text" id="txtCSCodeIM" class="form-control" tabIndex="32">
                    </div>
                    <div class="col-sm-3">
                        <a href="#" onclick="SearchData('csexport')">CS Export</a> :<br /><input type="text" id="txtCSCodeEX" class="form-control" tabIndex="33">
                    </div>
                    <div class="col-sm-3">
                        <a href="#" onclick="SearchData('csother')">CS Others</a> :<br /><input type="text" id="txtCSCodeOT" class="form-control" tabIndex="34">
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-6">
                        Consign Status :<br /><input type="text" id="txtConsStatus" class="form-control" disabled/>
                        <br/><select id="cboCompanyType" class="form-control" style="height:300px" multiple></select>
                    </div>
                    <div class="col-sm-6">
                        Commercial Level :<br /><input type="text" id="txtCommLevel" class="form-control" disabled />
                        <br /><select id="cboCommLevel" class="form-control"></select>
                    </div>
                </div>
            </div>
        </div>
        <button id="btnAdd" class="btn btn-default" onclick="ClearData()">Add</button>
        <button id="btnSave" class="btn btn-success" onclick="SaveData()">Save</button>
        <button id="btnDel" class="btn btn-danger" onclick="DeleteData()">Delete</button>
        <div id="dvLOVs"></div>
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
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    var row = {};
    $(document).ready(function () {
        SetLOVs();
        SetEvents();
        SetEnterToTab();
        $('#txtCustCode').focus();
    });
    function SetEvents() {
        $('#txtBranch').keydown(function (event) {
            if (event.which == 13) {
                var code = $('#txtCustCode').val();
                var branch = $('#txtBranch').val();
                ClearData();
                CallBackQueryCustomer(path,code ,branch, ReadCustomer);
            }
        });
        $('#txtBillToBranch').keydown(function (event) {
            if (event.which == 13) {
                $('#txtBillToCustName').val('');
                $('#txtBillToAddress').val('');
                CallBackQueryCustomer(path, $('#txtBillToCustCode').val(), $('#txtBillToBranch').val(), ReadBilling);
            }
        });
        $('#cboCommLevel').change(function () {
            var data = $(this).val();
            $('#txtCommLevel').val(data);
        });
        $('#cboCompanyType').change(function () {
            var data = $(this).val();
            var val = data.length>1? data.join(","): data[0];

            $('#txtConsStatus').val(val);
        });
    }
    function SetEnterToTab() {
        //Set enter to tab
        $("input[tabindex], select[tabindex], textarea[tabindex]").each(function () {
            $(this).on("keypress", function (e) {
                if (e.keyCode === 13) {
                    var idx = (this.tabIndex + 1);
                    var nextElement = $('[tabindex="' + idx + '"]');
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
    function SetLOVs() {
        //prepare searching data grid
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (res) {
            var dv = document.getElementById("dvLOVs");
            CreateLOV(dv, '#frmSearchCust', '#tbCust', 'Customers', res, 3);
            CreateLOV(dv, '#frmSearchBill', '#tbBill', 'Billing Place', res, 3);
            CreateLOV(dv, '#frmSearchSales', '#tbSales', 'Staffs', res, 2);
            CreateLOV(dv, '#frmSearchCSIM', '#tbCSI', 'Staffs', res, 2);
            CreateLOV(dv, '#frmSearchCSEX', '#tbCSE', 'Staffs', res, 2);
            CreateLOV(dv, '#frmSearchCSOT', '#tbCSO', 'Staffs', res, 2);

        });
        //load configuration data
        var lists = "CUSTOMER_GROUP=#txtCustGroup";
        lists += ",CUSTOMER_TYPE=#txtCustType";
        lists += ",COMPANY_TYPE=#cboCompanyType";
        lists += ",COMMERCIAL_LEVEL=#cboCommLevel";

        loadCombos(path, lists);
        loadLang('#txtUsedLanguage');
    }
    function SearchData(type) {
        switch (type) {
            case 'customer':
                SetGridCompany(path, '#tbCust','#frmSearchCust', ReadCustomer);
                break;
            case 'billing':
                SetGridCompany(path, '#tbBill', '#frmSearchBill' ,ReadBilling);
                break;
            case 'sales':
                SetGridUser(path, '#tbSales', '#frmSearchSales',ReadSales);
                break;
            case 'csimport':
                SetGridUser(path, '#tbCSI','#frmSearchCSIM', ReadCSImp);
                break;
            case 'csexport':
                SetGridUser(path, '#tbCSE', '#frmSearchCSEX', ReadCSExp);
                break;
            case 'csother':
                SetGridUser(path, '#tbCSO', '#frmSearchCSOT',ReadCSOth);
                break;
        }
    }
    function ReadCustomer(dr) {
        if (dr.CustCode != undefined) {
            row = dr;
            $('#txtCustCode').val(dr.CustCode);
            $('#txtBranch').val(dr.Branch);
            $('#txtCustGroup').val(dr.CustGroup);
            $('#txtTaxNumber').val(dr.TaxNumber);
            $('#txtTitle').val(dr.Title);
            $('#txtNameThai').val(dr.NameThai);
            $('#txtNameEng').val(dr.NameEng);
            $('#txtTAddress1').val(dr.TAddress1);
            $('#txtTAddress2').val(dr.TAddress2);
            $('#txtEAddress1').val(dr.EAddress1);
            $('#txtEAddress2').val(dr.EAddress2);
            $('#txtPhone').val(dr.Phone);
            $('#txtFaxNumber').val(dr.FaxNumber);
            $('#txtLoginName').val(dr.LoginName);
            $('#txtLoginPassword').val(dr.LoginPassword);
            $('#txtManagerCode').val(dr.ManagerCode);
            $('#txtCSCodeIM').val(dr.CSCodeIM);
            $('#txtCSCodeEX').val(dr.CSCodeEX);
            $('#txtCSCodeOT').val(dr.CSCodeOT);
            $('#txtGLAccountCode').val(dr.GLAccountCode);
            $('#txtCustType').val(dr.CustType);
            $('#txtBillToCustCode').val(dr.BillToCustCode);
            $('#txtBillToBranch').val(dr.BillToBranch);

            $('#txtBillToCustName').val('');
            $('#txtBillToAddress').val('');

            CallBackQueryCustomer(path, dr.BillToCustCode, dr.BillToBranch, ReadBilling);

            $('#txtUsedLanguage').val(dr.UsedLanguage);
            $('#txtLevelGrade').val(dr.LevelGrade);
            $('#txtTermOfPayment').val(dr.TermOfPayment);
            $('#txtBillCondition').val(dr.BillCondition);
            $('#txtCreditLimit').val(dr.CreditLimit);
            $('#txtMapText').val(dr.MapText);
            $('#txtMapFileName').val(dr.MapFileName);
            $('#txtCmpType').val(dr.CmpType);
            $('#txtCmpLevelExp').val(dr.CmpLevelExp);
            $('#txtCmpLevelImp').val(dr.CmpLevelImp);
            $('#txtIs19bis').val(dr.Is19bis);
            $('#txtMgrSeq').val(dr.MgrSeq);
            $('#txtLevelNoExp').val(dr.LevelNoExp);
            $('#txtLevelNoImp').val(dr.LevelNoImp);
            $('#txtLnNO').val(dr.LnNO);
            $('#txtAdjTaxCode').val(dr.AdjTaxCode);
            $('#txtBkAuthorNo').val(dr.BkAuthorNo);
            $('#txtBkAuthorCnn').val(dr.BkAuthorCnn);
            $('#txtLtdPsWkName').val(dr.LtdPsWkName);
            $('#txtDutyLimit').val(dr.DutyLimit);
            $('#txtCommRate').val(dr.CommRate);
            $('#txtTAddress').val(dr.TAddress);
            $('#txtTDistrict').val(dr.TDistrict);
            $('#txtTSubProvince').val(dr.TSubProvince);
            $('#txtTProvince').val(dr.TProvince);
            $('#txtTPostCode').val(dr.TPostCode);
            $('#txtDMailAddress').val(dr.DMailAddress);
            $('#txtPrivilegeOption').val(dr.PrivilegeOption);
            $('#txtGoldCardNO').val(dr.GoldCardNO);
            $('#txtCustomsBrokerSeq').val(dr.CustomsBrokerSeq);
            $('#txtISCustomerSign').val(dr.ISCustomerSign);
            $('#txtISCustomerSignInv').val(dr.ISCustomerSignInv);
            $('#txtISCustomerSignDec').val(dr.ISCustomerSignDec);
            $('#txtISCustomerSignECon').val(dr.ISCustomerSignECon);
            $('#txtIsShippingCannotSign').val(dr.IsShippingCannotSign);
            $('#txtExportCode').val(dr.ExportCode);
            $('#txtCode19BIS').val(dr.Code19BIS);
            $('#txtWEB_SITE').val(dr.WEB_SITE);
                          
            var cons = dr.ConsStatus == null ? '' : dr.ConsStatus;
            var lvl = dr.CommLevel == null ? '' : dr.CommLevel;

            $('#txtConsStatus').val(cons);
            $('#txtCommLevel').val(lvl);
            $('#cboCommLevel').val(lvl);

            if (cons.indexOf(',') >= 0) {
                $('#cboCompanyType').val(cons.split(','));
            } else {
                $('#cboCompanyType').val(cons);
            }
        } else {
            alert('Data Not Found');
            ClearData();
        }
    }
    function ReadBilling(dr) {
        $('#txtBillToCustCode').val(dr.CustCode);
        $('#txtBillToBranch').val(dr.Branch);
        if ($('#txtUsedLanguage').val() == "TH") {
            $('#txtBillToCustName').val(dr.NameThai);
            $('#txtBillToAddress').val(dr.TAddress1 + ' ' + dr.TAddress2);
        } else {
            $('#txtBillToCustName').val(dr.NameEng);
            $('#txtBillToAddress').val(dr.EAddress1 + ' ' + dr.EAddress2);
        }
    }
    function ReadSales(dt) {
        $('#txtManagerCode').val(dt.UserID);
        $('#txtManagerCode').focus();
    }
    function ReadCSImp(dt) {
        $('#txtCSCodeIM').val(dt.UserID);
        $('#txtCSCodeIM').focus();
    }
    function ReadCSExp(dt) {
        $('#txtCSCodeEX').val(dt.UserID);
        $('#txtCSCodeEX').focus();
    }
    function ReadCSOth(dt) {
        $('#txtCSCodeOT').val(dt.UserID);
        $('#txtCSCodeOT').focus();
    }
    function ClearData() {
        $('#txtCustCode').val('');
        $('#txtBranch').val('');
        $('#txtCustGroup').val('');
        $('#txtTaxNumber').val('');
        $('#txtTitle').val('');
        $('#txtNameThai').val('');
        $('#txtNameEng').val('');
        $('#txtTAddress1').val('');
        $('#txtTAddress2').val('');
        $('#txtEAddress1').val('');
        $('#txtEAddress2').val('');
        $('#txtPhone').val('');
        $('#txtFaxNumber').val('');
        $('#txtLoginName').val('');
        $('#txtLoginPassword').val('');
        $('#txtManagerCode').val('');
        $('#txtCSCodeIM').val('');
        $('#txtCSCodeEX').val('');
        $('#txtCSCodeOT').val('');
        $('#txtGLAccountCode').val('');
        $('#txtCustType').val('');
        $('#txtBillToCustCode').val('');
        $('#txtBillToCustName').val('');
        $('#txtBillToAddress').val('');
        $('#txtBillToBranch').val('');
        $('#txtUsedLanguage').val('TH');
        $('#txtLevelGrade').val('');
        $('#txtTermOfPayment').val('');
        $('#txtBillCondition').val('');
        $('#txtCreditLimit').val('0.00');
        $('#txtMapText').val('');
        $('#txtMapFileName').val('');
        $('#txtCmpType').val('');
        $('#txtCmpLevelExp').val('');
        $('#txtCmpLevelImp').val('');
        $('#txtIs19bis').val('');
        $('#txtMgrSeq').val('');
        $('#txtLevelNoExp').val('');
        $('#txtLevelNoImp').val('');
        $('#txtLnNO').val('');
        $('#txtAdjTaxCode').val('');
        $('#txtBkAuthorNo').val('');
        $('#txtBkAuthorCnn').val('');
        $('#txtLtdPsWkName').val('');
        $('#txtConsStatus').val('');
        $('#txtCommLevel').val('');
        $('#txtDutyLimit').val('0.00');
        $('#txtCommRate').val('0.00');
        $('#txtTAddress').val('');
        $('#txtTDistrict').val('');
        $('#txtTSubProvince').val('');
        $('#txtTProvince').val('');
        $('#txtTPostCode').val('');
        $('#txtDMailAddress').val('');
        $('#txtPrivilegeOption').val('');
        $('#txtGoldCardNO').val('');
        $('#txtCustomsBrokerSeq').val('');
        $('#txtISCustomerSign').val('');
        $('#txtISCustomerSignInv').val('');
        $('#txtISCustomerSignDec').val('');
        $('#txtISCustomerSignECon').val('');
        $('#txtIsShippingCannotSign').val('');
        $('#txtExportCode').val('');
        $('#txtCode19BIS').val('');
        $('#txtWEB_SITE').val('');
        $('#cboCompanyType').val('');
        $('#cboCommLevel').val('');

        $('#txtCustCode').focus();
    }
    function SaveData() {
        var obj = {
            CustCode: $('#txtCustCode').val().trim(),
            Branch: $('#txtBranch').val().trim(),
            CustGroup: $('#txtCustGroup').val(),
            TaxNumber: $('#txtTaxNumber').val(),
            Title: $('#txtTitle').val(),
            NameThai: $('#txtNameThai').val(),
            NameEng: $('#txtNameEng').val(),
            TAddress1: $('#txtTAddress1').val(),
            TAddress2: $('#txtTAddress2').val(),
            EAddress1: $('#txtEAddress1').val(),
            EAddress2: $('#txtEAddress2').val(),
            Phone: $('#txtPhone').val(),
            FaxNumber: $('#txtFaxNumber').val(),
            LoginName: $('#txtLoginName').val(),
            LoginPassword: $('#txtLoginPassword').val(),
            ManagerCode: $('#txtManagerCode').val(),
            CSCodeIM: $('#txtCSCodeIM').val(),
            CSCodeEX: $('#txtCSCodeEX').val(),
            CSCodeOT: $('#txtCSCodeOT').val(),
            GLAccountCode: $('#txtGLAccountCode').val(),
            CustType: $('#txtCustType').val(),
            BillToCustCode: $('#txtBillToCustCode').val(),
            BillToBranch: $('#txtBillToBranch').val(),
            UsedLanguage: $('#txtUsedLanguage').val(),
            LevelGrade: $('#txtLevelGrade').val(),
            TermOfPayment: $('#txtTermOfPayment').val(),
            BillCondition: $('#txtBillCondition').val(),
            CreditLimit: CNum($('#txtCreditLimit').val()),
            MapText: $('#txtMapText').val(),
            MapFileName: $('#txtMapFileName').val(),
            CmpType: $('#txtCmpType').val(),
            CmpLevelExp: $('#txtCmpLevelExp').val(),
            CmpLevelImp: $('#txtCmpLevelImp').val(),
            Is19bis: $('#txtIs19bis').val(),
            MgrSeq: $('#txtMgrSeq').val(),
            LevelNoExp: $('#txtLevelNoExp').val(),
            LevelNoImp: $('#txtLevelNoImp').val(),
            LnNO: $('#txtLnNO').val(),
            AdjTaxCode: $('#txtAdjTaxCode').val(),
            BkAuthorNo: $('#txtBkAuthorNo').val(),
            BkAuthorCnn: $('#txtBkAuthorCnn').val(),
            LtdPsWkName: $('#txtLtdPsWkName').val(),
            ConsStatus: $('#txtConsStatus').val(),
            CommLevel: $('#txtCommLevel').val(),
            DutyLimit: CNum($('#txtDutyLimit').val()),
            CommRate: CNum($('#txtCommRate').val()),
            TAddress: $('#txtTAddress').val(),
            TDistrict: $('#txtTDistrict').val(),
            TSubProvince: $('#txtTSubProvince').val(),
            TProvince: $('#txtTProvince').val(),
            TPostCode: $('#txtTPostCode').val(),
            DMailAddress: $('#txtDMailAddress').val(),
            PrivilegeOption: $('#txtPrivilegeOption').val(),
            GoldCardNO: $('#txtGoldCardNO').val(),
            CustomsBrokerSeq: $('#txtCustomsBrokerSeq').val(),
            ISCustomerSign: $('#txtISCustomerSign').val(),
            ISCustomerSignInv: $('#txtISCustomerSignInv').val(),
            ISCustomerSignDec: $('#txtISCustomerSignDec').val(),
            ISCustomerSignECon: $('#txtISCustomerSignECon').val(),
            IsShippingCannotSign: $('#txtIsShippingCannotSign').val(),
            ExportCode: $('#txtExportCode').val(),
            Code19BIS: $('#txtCode19BIS').val(),
            WEB_SITE: $('#txtWEB_SITE').val()
        };
        if (obj.CustCode != "") {
            if (obj.Branch == '') {
                alert('Please enter branch');
                return;
            }
            if (obj.NameThai == '') {
                alert('Please enter customer name');
                return;
            }
            var ask = confirm("Do you need to Save " + obj.CustCode + "/" + obj.Branch +"?");
            if (ask == false) return;
            var jsonText = JSON.stringify({ data: obj });
            //alert(jsonText);
            $.ajax({
                url: "@Url.Action("SetCompany", "Master")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.data != null) {
                        $('#txtCustCode').val(response.result.data);
                        $('#txtCustCode').focus();
                    }
                    alert(response.result.msg);
                },
                error: function (e) {
                    alert(e);
                }
            });
        } else {
            alert('No data to save');
        }
    }
    function DeleteData() {
        var code = $('#txtCustCode').val();
        var branch = $('#txtBranch').val();
        var ask = confirm("Do you need to Delete " + code + "/" +branch+"?");
        if (ask == false) return;

        $.get(path + 'master/delcompany?code=' + code + '&branch=' + branch, function (r) {
            alert(r.company.result);
            ClearData();
        });
    }
</script>