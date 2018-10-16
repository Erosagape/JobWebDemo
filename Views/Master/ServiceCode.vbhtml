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
        SetLOVs();
        SetEvents();
        SetEnterToTab();
    });
    function SetEnterToTab() {
        //Set enter to tab
        $("input[tabindex], select[tabindex], textarea[tabindex]").each(function () {
            $(this).on("keypress", function (e) {
                if (e.keyCode === 13) {
                    var nextElement = $('[tabindex="' + (this.tabIndex + 1) + '"]');
                    if (nextElement.length) {
                        $('[tabindex="' + (this.tabIndex + 1) + '"]').focus();
                        e.preventDefault();
                    } else
                        $('[tabindex="1"]').focus();
                }
            });
        });
        $('#txtSICode').focus();
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
        //if value IsTaxCharge =1 -> Exclude VAT ,2-> Include VAT 
        $('#chkIsTaxCharge').change(function () {
            if (this.checked) {
                //Default value is Excluded VAT
                $('input:radio[name=optVAT][value=1]').prop('checked', true);
            } else {
                $('input:radio[name=optVAT]:checked').prop('checked', false);
            }
        });
        $('#chkIs50Tavi').change(function () {
            if (this.checked) {
                $('input:radio[name=optWHT][value=1]').prop('checked', true);
            } else {
                $('input:radio[name=optWHT]:checked').prop('checked', false);
            }
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
        var code = $('#cboType').val();
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

        $('input:radio[name=optVAT]:checked').prop('checked', false);
        if (dt.IsTaxCharge === 0) {
            $('#chkIsTaxCharge').prop('checked', false);
        } else {
            $('#chkIsTaxCharge').prop('checked', true);
            $('input:radio[name=optVAT][value="' + dt.IsTaxCharge + '"]').prop('checked', true);
        }

        $('input:radio[name=optWHT]:checked').prop('checked', false);
        if (dt.Is50Tavi === 0) {
            $('#chkIs50Tavi').prop('checked', false);
        } else {
            $('#chkIs50Tavi').prop('checked', true);
        }
        if (dt.IsLtdAdv50Tavi === 1) $('input:radio[name=optWHT][value=1]').prop('checked', true);
        if (dt.IsPay50TaviTo === 1) $('input:radio[name=optWHT][value=2]').prop('checked', true);

        $('#txtRate50Tavi').val(dt.Rate50Tavi);

        if (dt.IsHaveSlip === 0) {
            $('#chkIsHaveSlip').prop('checked', false);
        } else {
            $('#chkIsHaveSlip').prop('checked', true);
        }

        if (dt.IsCredit === 0) {
            $('#chkIsCredit').prop('checked', false);
        } else {
            $('#chkIsCredit').prop('checked', true);
        }

        if (dt.IsExpense === 0) {
            $('#chkIsExpense').prop('checked', false);
        } else {
            $('#chkIsExpense').prop('checked', true);
        }

        if (dt.IsShowPrice === 0) {
            $('#chkIsShowPrice').prop('checked', false);
        } else {
            $('#chkIsShowPrice').prop('checked', true);
        }

        if (dt.IsUsedCoSlip === 0) {
            $('#chkIsUsedCoSlip').prop('checked', false);
        } else {
            $('#chkIsUsedCoSlip').prop('checked', true);
        }
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
            dt.IsTaxCharge = 0;
            if ($('input:radio[name=optVAT]:checked').val() == '1') dt.IsTaxCharge = 1;
            if ($('input:radio[name=optVAT]:checked').val() == '2') dt.IsTaxCharge = 2;
        }
        if ($('#chkIs50Tavi').prop('checked') == true) {
            dt.Is50Tavi = 1;
        } else {
            dt.Is50Tavi = 0;
        }
        dt.IsLtdAdv50Tavi = 0;
        dt.IsPay50TaviTo = 0;
        if ($('input:radio[name=optWHT]:checked').val() == '1') dt.IsLtdAdv50Tavi = 1;
        if ($('input:radio[name=optWHT]:checked').val() == '2') dt.IsPay50TaviTo = 1;

        dt.Rate50Tavi = CNum($('#txtRate50Tavi').val());

        if ($('#chkIsHaveSlip').prop('checked') === true) {
            dt.IsHaveSlip = 1;
        } else {
            dt.IsHaveSlip = 0;
        }
        if ($('#chkIsCredit').prop('checked') === true) {
            dt.IsCredit = 1;
        } else {
            dt.IsCredit = 0;
        }
        if ($('#chkIsExpense').prop('checked') === true) {
            dt.IsExpense = 1;
        } else {
            dt.IsExpense = 0;
        }
        if ($('#chkIsShowPrice').prop('checked') === true) {
            dt.IsShowPrice = 1;
        } else {
            dt.IsShowPrice = 0;
        }
        if ($('#chkIsUsedCoSlip').prop('checked') === true) {
            dt.IsUsedCoSlip = 1;
        } else {
            dt.IsUsedCoSlip = 0;
        }
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
