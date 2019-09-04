@Code
    ViewBag.Title = "Service Code"
End Code
<div class="panel-body">
    <div id="dvForm" class="container" style="width:100%">
        <div class="form-group row">
            <div class="col-sm-2">
                Choose Type:
                <select id="cboType" class="form-control dropdown"></select>
            </div>
            <div class="col-sm-2">
                Service Code:
                <input type="text" id="txtSICode" class="form-control" tabindex="0" />
            </div>
            <div class="col-sm-4">
                Name Thai:
                <input type="text" id="txtNameThai" class="form-control" tabindex="1" />
            </div>
            <div class="col-sm-4">
                Name Eng:
                <input type="text" id="txtNameEng" class="form-control" tabindex="2" />
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-3">
                Price:
                <input type="text" id="txtStdPrice" class="form-control" tabindex="3" />
            </div>
            <div class="col-sm-3">
                Currency:
                <div style="display:flex">
                    <div style="flex:1">
                        <input type="text" id="txtCurrencyCode" class="form-control" tabindex="4" />
                    </div>
                    <div>
                        <input type="button" value="..." class="btn btn-default" onclick="ShowSearch('currency')" />
                    </div>
                </div>
            </div>
            <div class="col-sm-3">
                Unit:
                <div style="display:flex">
                    <div style="flex:1">
                        <input type="text" id="txtUnitCharge" class="form-control" tabindex="5" />
                    </div>
                    <div>
                        <input type="button" value="..." class="btn btn-default" onclick="ShowSearch('unit')" />
                    </div>
                </div>
            </div>
            <div class="col-sm-3">
                Vender:
                <div style="display:flex">
                    <div style="flex:1">
                        <input type="text" id="txtDefaultVender" class="form-control" tabindex="6" />
                    </div>
                    <div>
                        <input type="button" value="..." class="btn btn-default" onclick="ShowSearch('vender')" />
                    </div>
                </div>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-4">
                GL-Sales
                <br />
                <div style="display:flex">
                    <input type="text" id="txtGLAccountCodeSales" class="form-control" tabindex="7" />
                    <input type="button" class="btn btn-default" value="..." onclick="ShowSearch('accsales')" />
                </div>
            </div>
            <div class="col-sm-4">
                GL-Cost
                <br />
                <div style="display:flex">
                    <input type="text" id="txtGLAccountCodeCost" class="form-control" tabindex="8" />
                    <input type="button" class="btn btn-default" value="..." onclick="ShowSearch('acccost')" />
                </div>
            </div>
            <div class="col-sm-4">
                Process Desc:<textarea id="txtProcessDesc" class="form-control" tabindex="9"></textarea>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-md-6">
                <input type="checkbox" id="chkIsTaxCharge" />
                <label for="chkIsTaxCharge">Calculate VAT</label>
                <label class="radio-inline"><input type="radio" name="optVAT" value="1">Exclude</label>
                <label class="radio-inline"><input type="radio" name="optVAT" value="2">Include</label>
                <br />
                <input type="checkbox" id="chkIsCredit" />
                <label for="chkIsCredit">Credit Advance</label>
                <br />
                <input type="checkbox" id="chkIsExpense" />
                <label for="chkIsExpense">Company Expenses</label>
                <br />
                <input type="checkbox" id="chkIsHaveSlip" />
                <label for="chkIsHaveSlip">Must have slip</label>
            </div>
            <div class="col-md-6">
                <input type="checkbox" id="chkIs50Tavi" />
                <label for="chkIs50Tavi">Calculate 50Tavi</label>
                <input type="text" id="txtRate50Tavi" /><b>%</b>
                <br />
                <label class="radio-inline"><input type="radio" name="optWHT" value="1">Paid 50Tavi By Company</label>
                <label class="radio-inline"><input type="radio" name="optWHT" value="2">Pay 50Tavi by Customer</label>
                <br />
                <input type="checkbox" id="chkIsShowPrice" />
                <label for="chkIsShowPrice">Cannot Change Price</label>
                <br />
                <input type="checkbox" id="chkIsUsedCoSlip" />
                <label for="chkIsUsedCoSlip">Used for Co-operation</label>
            </div>
        </div>
        <a href="#" class="btn btn-default w3-purple" id="btnAdd" onclick="AddData()">
            <i class="fa fa-lg fa-file-o"></i>&nbsp;<b>New</b>
        </a>
        <input type="checkbox" id="chkCopyMode" /><b>Copy Mode</b>
        <a href="#" class="btn btn-success" id="btnSave" onclick="SaveData()">
            <i class="fa fa-lg fa-save"></i>&nbsp;<b>Save</b>
        </a>
        <a href="#" class="btn btn-danger" id="btnDelete" onclick="DeleteData()">
            <i class="fa fa-lg fa-trash"></i>&nbsp;<b>Delete</b>
        </a>
        <a href="#" class="btn btn-primary" id="btnSearch" onclick="ShowSearch('sicode')">
            <i class="fa fa-lg fa-filter"></i>&nbsp;<b>Search</b>
        </a>

    </div>
</div>
<div id="dvList"></div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    let row = {}; //row pointer to current record show in buffer
    //$(document).ready(function () {
    SetEvents();
    SetEnterToTab();
    AddData();
    //});
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
                }
            });
        });
    }
    function SetLOVs() {
        //load service group code
        loadServiceGroup(path, '#cboType');
        //2 Field show in grid 
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key', function (response) {
            var dv = document.getElementById("dvList");
            //2 Fields
            //Currency
            CreateLOV(dv,'#dvCurr','#tbCurr','Currency',response,2);
            //Vender
            CreateLOV(dv,'#dvVend','#tbVend','Venders',response,2);
            //SICode
            CreateLOV(dv, '#dvSearch', '#tbGrid', 'Service Code', response, 2);
            //Accounts
            CreateLOV(dv, '#frmSearchAcc1', '#tbAcc1', 'Account Code', response, 2);
            CreateLOV(dv, '#frmSearchAcc2', '#tbAcc2', 'Account Code', response, 2);
            //1 Fields
            //Unit
            CreateLOV(dv,'#dvUnit','#tbUnit','Units',response,2);
        });
    }
    function SetEvents() {
        SetLOVs();
        $('#cboType').click(function () {
            let code = $('#cboType').val();
            $.get(path + 'Master/GetServiceGroup?Code=' + code)
                .done(function (r) {
                    if (r.servicegroup.data.length > 0) {
                        let dt = r.servicegroup.data[0];

                        $('#chkIsTaxCharge').prop('checked', dt.IsTaxCharge === 0 ? false : true);
                        $('#chkIs50Tavi').prop('checked', dt.Is50Tavi === 0 ? false : true);
                        $('input:radio[name=optVAT]:checked').prop('checked', false);
                        $('input:radio[name=optWHT]:checked').prop('checked', false);
                        $('input:radio[name=optVAT][value="' + dt.IsTaxCharge + '"]').prop('checked', true);
                        $('input:radio[name=optWHT][value=1]').prop('checked', dt.IsLtdAdv50Tavi === 1 ? true : false);
                        $('input:radio[name=optWHT][value=2]').prop('checked', dt.IsPay50TaviTo === 1 ? true : false);
                        $('#txtRate50Tavi').val(dt.Rate50Tavi);
                        $('#chkIsHaveSlip').prop('checked', dt.IsHaveSlip === 0 ? false : true);
                        $('#chkIsCredit').prop('checked', dt.IsCredit === 0 ? false : true);
                        $('#chkIsExpense').prop('checked', dt.IsExpense === 0 ? false : true);
                    }
                });
        });
        //if value IsTaxCharge =1 -> Exclude VAT ,2-> Include VAT 
        $('#chkIsTaxCharge').change(function () {
            //Default value is Excluded VAT
            $('input:radio[name=optVAT][value=1]').prop('checked', this.checked ? true : false);
        });
        $('#chkIs50Tavi').change(function () {
            $('input:radio[name=optWHT][value=1]').prop('checked', this.checked ? true : false);
        });
        //if enter value then query from database
        $('#txtSICode').keydown(function (e) {
            if (e.which === 13) {
                SearchData($('#txtSICode').val());
            }
        });
    }
    function SearchData(code) {
        //function for query data from code
        $.get(path + 'master/getservicecode?code=' + code).done(function (r) {
            if (r.servicecode.data.length > 0) {
                LoadData(r.servicecode.data[0]);
                return;
            } else {
                ShowMessage('Data not found');
                AddData();
            }
        });
    }
    function ShowData(dt) {
        LoadData(dt);
        $('#txtSICode').focus();
    }
    function ShowUnit(dt) {
        $('#txtUnitCharge').val(dt.UnitType);
        $('#txtUnitCharge').focus();
    }
    function ShowVender(dt) {
        $('#txtDefaultVender').val(dt.VenCode);
        $('#txtDefaultVender').focus();
    }
    function ShowCurrency(dt) {
        $('#txtCurrencyCode').val(dt.Code);
        $('#txtCurrencyCode').focus();
    }
    function ReadGLSales(dt) {
        $('#txtGLAccountCodeSales').val(dt.AccCode);
    }
    function ReadGLCost(dt) {
        $('#txtGLAccountCodeCost').val(dt.AccCode);
    }
    function ShowSearch(ty) {
        switch (ty) {
            case 'accsales':
                SetGridAccountCode(path, '#tbAcc1', '#frmSearchAcc1','', ReadGLSales);
                break;
            case 'acccost':
                SetGridAccountCode(path, '#tbAcc2', '#frmSearchAcc2', '', ReadGLCost);
                break;
            case 'sicode':
                let w = '';
                if ($('#cboType').val() !== null) {
                    w += '?Group=' + $('#cboType').val();
                }
                SetGridSICodeFilter(path, '#tbGrid',w, '#dvSearch' , ShowData);
                break;
            case 'vender':
                SetGridVender(path, '#tbVend', '#dvVend' , ShowVender);
                break;
            case 'currency':
                SetGridCurrency(path, '#tbCurr', '#dvCurr', ShowCurrency);
                break;
            case 'unit':
                SetGridServUnit(path, '#tbUnit','#dvUnit',ShowUnit);
                break;                 
        }
    }
    function AddData() {
        if ($('#chkCopyMode').prop('checked') == true) {
            $('#txtSICode').val('');
            $('#txtNameThai').focus();
            return;
        }
        $.get(path + 'master/getnewservicecode',function (r) {
                if (r.servicecode.data.length>0) {
                    ShowData(r.servicecode.data[0]);
                    $("#txtSICode").attr("disabled", "disabled"); 
                    $('#txtNameThai').focus();
                    return;
                }
            });
    }
    function DeleteData() {
        var code = $('#txtSICode').val();
        ShowConfirm("Do you need to Delete " + code + "?", function (ask) {
            if (ask == false) return;
            $.get(path + 'master/delservicecode?code=' + code, function (r) {
                ShowMessage(r.servicecode.result);
                ShowData(r.servicecode.data[0]);
            });
        });
    }
    function LoadData(dt) {
        row = dt;
        $('#txtSICode').val(dt.SICode);
        $('#cboType').val(dt.GroupCode);
        $('#txtNameThai').val(dt.NameThai);
        $('#txtNameEng').val(dt.NameEng);
        $('#txtStdPrice').val(dt.StdPrice);
        $('#txtUnitCharge').val(dt.UnitCharge);
        $('#txtCurrencyCode').val(dt.CurrencyCode);
        $('#txtDefaultVender').val(dt.DefaultVender);
        $('#txtProcessDesc').val(dt.ProcessDesc);
        $('#txtGLAccountCodeSales').val(dt.GLAccountCodeSales);
        $('#txtGLAccountCodeCost').val(dt.GLAccountCodeCost);

        $('#chkIsTaxCharge').prop('checked', dt.IsTaxCharge === 0 ? false : true);
        $('#chkIs50Tavi').prop('checked', dt.Is50Tavi === 0 ? false : true);

        $('input:radio[name=optVAT]:checked').prop('checked', false);
        $('input:radio[name=optWHT]:checked').prop('checked', false);
        $('input:radio[name=optVAT][value="' + dt.IsTaxCharge + '"]').prop('checked', true);
        $('input:radio[name=optWHT][value=1]').prop('checked', dt.IsLtdAdv50Tavi === 1 ? true : false);
        $('input:radio[name=optWHT][value=2]').prop('checked', dt.IsPay50TaviTo === 1 ? true : false);

        $('#txtRate50Tavi').val(dt.Rate50Tavi);

        $('#chkIsHaveSlip').prop('checked', dt.IsHaveSlip === 0 ? false : true);
        $('#chkIsCredit').prop('checked', dt.IsCredit === 0 ? false : true);
        $('#chkIsExpense').prop('checked', dt.IsExpense === 0 ? false : true);
        $('#chkIsShowPrice').prop('checked', dt.IsShowPrice === 0 ? false : true);
        $('#chkIsUsedCoSlip').prop('checked', dt.IsUsedCoSlip === 0 ? false : true);

        $("#txtSICode").removeAttr("disabled"); 
    }
    function GetDataSave(dt) {
        dt.SICode = $('#txtSICode').val().trim();
        dt.GroupCode = $('#cboType').val();
        if (dt.SICode == "") dt.SICode = $('#cboType').val() + '-';
        dt.NameThai=$('#txtNameThai').val();
        dt.NameEng=$('#txtNameEng').val();
        dt.StdPrice=CNum($('#txtStdPrice').val());
        dt.UnitCharge=$('#txtUnitCharge').val();
        dt.CurrencyCode=$('#txtCurrencyCode').val();
        dt.DefaultVender=$('#txtDefaultVender').val();
        dt.ProcessDesc=$('#txtProcessDesc').val();
        dt.GLAccountCodeSales=$('#txtGLAccountCodeSales').val();
        dt.GLAccountCodeCost=$('#txtGLAccountCodeCost').val();
       
        if ($('#chkIsTaxCharge').prop('checked') == false) {
            dt.IsTaxCharge = 0;
        } else {
            dt.IsTaxCharge = $('input:radio[name=optVAT]:checked').val() == '2' ? 2 : 1;
        }
        dt.Is50Tavi = $('#chkIs50Tavi').prop('checked') == true ? 1 : 0;

        dt.IsPay50TaviTo = $('input:radio[name=optWHT]:checked').val() == '2' ? 1 : 0;
        dt.IsLtdAdv50Tavi = $('input:radio[name=optWHT]:checked').val() == '1' ? 1 : 0;
        dt.Rate50Tavi = CNum($('#txtRate50Tavi').val());

        dt.IsHaveSlip = $('#chkIsHaveSlip').prop('checked') === true ? 1 : 0;
        dt.IsCredit = $('#chkIsCredit').prop('checked') === true ? 1 : 0;
        dt.IsExpense = $('#chkIsExpense').prop('checked') === true ? 1 : 0;
        dt.IsShowPrice = $('#chkIsShowPrice').prop('checked') === true ? 1 : 0;
        dt.IsUsedCoSlip = $('#chkIsUsedCoSlip').prop('checked') === true? 1 : 0;
        return dt;
    }
    function SaveData() {
        if (row.SICode != undefined) {
            var obj = GetDataSave(row);
            if (obj.GroupCode == null) {
                ShowMessage('Please enter service type');
                return;
            }
            if (obj.NameThai == '') {
                ShowMessage('Please enter service name');
                return;
            }
            ShowConfirm("Do you need to " + (row.SICode == "" ? "Add" : "Save") + " this data?", function (ask) {
                if (ask == false) return;
                var jsonText = JSON.stringify({ data: obj });
                //ShowMessage(jsonText);
                $.ajax({
                    url: "@Url.Action("SetServiceCode", "Master")",
                    type: "POST",
                    contentType: "application/json",
                    data: jsonText,
                    success: function (response) {
                        if (response.result.data!=null) {
                            $('#txtSICode').val(response.result.data);
                            $('#txtSICode').focus();
                        }
                        ShowMessage(response.result.msg);
                    },
                    error: function (e) {
                        ShowMessage(e);
                    }
                });
            });
        } else {
            ShowMessage('No data to save');
        }
        //ShowMessage('VAT=' + $('#chkIsTaxCharge').prop('checked') + ' (' + $('input:radio[name=optVAT]:checked').val() + ') TAX=' + $('#chkIs50Tavi').prop('checked') + ' (' + $('input:radio[name=optWHT]:checked').val()+')');
    }

</script>
