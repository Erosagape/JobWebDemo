@Code
    ViewBag.Title = "Service Code"
End Code
<div class="panel-body">
    <div id="dvForm" class="container" style="width:100%">
        <div class="form-group row">
            <div class="col-sm-2">
                Choose Type:
                <select id="cboType" class="form-control dropdown" onchange="RefreshGrid()">
                    <option value="SNG">SINGLE</option>
                    <option value="STP">STEP</option>
                    <option value="AIR">AIR</option>
                </select>
            </div>
            <div class="col-sm-2">
                <a onclick="ShowSearch('sicode')">Service Code:</a>
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
                <a onclick="ShowSearch('currency')">Currency:</a>
                <input type="text" id="txtCurrencyCode" class="form-control" tabindex="4" />
            </div>
            <div class="col-sm-3">
                <a onclick="ShowSearch('unit')">Unit:</a><input type="text" id="txtUnitCharge" class="form-control" tabindex="5" />
            </div>
            <div class="col-sm-3">
                <a onclick="ShowSearch('vender')">Vender</a><input type="text" id="txtDefaultVender" class="form-control" tabindex="6" />
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-2">
                GL-Sales<br /><input type="text" id="txtGLAccountCodeSales" class="form-control" tabindex="7" />
            </div>
            <div class="col-sm-2">
                GL-Cost<br /><input type="text" id="txtGLAccountCodeCost" class="form-control" tabindex="8" />
            </div>
            <div class="col-sm-8">
                Process Desc:<textarea id="txtProcessDesc" class="form-control" tabindex="9" ></textarea>
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
                <label for="chkIsUsedCoSlip">Used for Co-person</label>
            </div>
        </div>
        <button id="btnAdd" class="btn btn-default" onclick="AddData()">Add</button>
        <button id="btnSave" class="btn btn-success" onclick="SaveData()">Save</button>
        <button id="btnDel" class="btn btn-danger" onclick="DeleteData()">Delete</button>
    </div>
</div>
<div id="dvList"></div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    var row = {}; //row pointer to current record show in buffer
    $(document).ready(function () {
        SetEvents();
        SetEnterToTab();
        $('#txtSICode').focus();
    });
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
        //2 Field show in grid 
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key', function (response) {
            var dv = document.getElementById("dvList");
            //2 Fields
            //Currency
            CreateLOV(dv,'#dvCurr','#tbCurr','Currency',response,2);
            //Vender
            CreateLOV(dv,'#dvVend','#tbVend','Venders',response,2);
            //SICode
            CreateLOV(dv,'#dvSearch','#tbGrid','Service Code',response,2);
            //1 Fields
            //Unit
            CreateLOV(dv,'#dvUnit','#tbUnit','Units',response,1);
        });
    }
    function SetEvents() {
        SetLOVs();
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
                alert('Data not found');
            }
        });
    }
    function ShowData(dt) {
        LoadData(dt);
        $('#txtSICode').focus();
    }
    function ShowUnit(dt) {
        $('#txtUnitCharge').val(dt.val);
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
    function ShowSearch(ty) {
        switch (ty) {
            case 'sicode':
                SetGridSICode(path, '#tbGrid', $('#cboType').val(), '#dvSearch' , ShowData);
                break;
            case 'vender':
                SetGridVender(path, '#tbVend', '#dvVend' , ShowVender);
                break;
            case 'currency':
                SetGridCurrency(path, '#tbCurr', '#dvCurr', ShowCurrency);
                break;
            case 'unit':
                SetGridUnit(path, '#tbUnit','#dvUnit',ShowUnit);
                break;                 
        }
    }
    function AddData() {
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
        var ask = confirm("Do you need to Delete "+code +"?");
        if (ask == false) return;

        $.get(path + 'master/delservicecode?code=' + code, function (r) {
            alert(r.servicecode.result);
            ShowData(r.servicecode.data[0]);
        });
    }
    function LoadData(dt) {
        row = dt;
        $('#txtSICode').val(dt.SICode);
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
        dt.SICode = $('#txtSICode').val();
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
            var ask = confirm("Do you need to " + (row.SICode == "" ? "Add" : "Save") + " this data?");
            if (ask == false) return;
            var jsonText = JSON.stringify({ data: obj });
            //alert(jsonText);
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
                    alert(response.result.msg);
                },
                error: function (e) {
                    alert(e);
                }
            });
        } else {
            alert('No data to save');
        }
        //alert('VAT=' + $('#chkIsTaxCharge').prop('checked') + ' (' + $('input:radio[name=optVAT]:checked').val() + ') TAX=' + $('#chkIs50Tavi').prop('checked') + ' (' + $('input:radio[name=optWHT]:checked').val()+')');
    }

</script>
