@Code
    ViewBag.Title = "Service Code"
End Code
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
            <a onclick="ShowSearch()">Service Code:</a>
            <input type="text" id="txtSICode" class="form-control" />
        </div>
        <div class="col-sm-4">
            Name Thai:
            <input type="text" id="txtNameThai" class="form-control" />
        </div>
        <div class="col-sm-4">
            Name Eng:
            <input type="text" id="txtNameEng" class="form-control" />
        </div>
    </div>
    <div class="form-group row">
        <div class="col-sm-3">
            Price:
            <input type="text" id="txtStdPrice" class="form-control" />
        </div>
        <div class="col-sm-3">
            <a>Currency:</a>
            <input type="text" id="txtCurrencyCode" class="form-control" />
        </div>
        <div class="col-sm-3">
            <a>Unit:</a><input type="text" id="txtUnitCharge" class="form-control" />
        </div>
        <div class="col-sm-3">
            <a>Vender</a><input type="text" id="txtDefaultVender" class="form-control" />
        </div>
    </div>
    <div class="form-group row">
        <div class="col-sm-2">
            GL-Sales<br /><input type="text" id="txtGLAccountCodeSales" class="form-control" />
        </div>
        <div class="col-sm-2">
            GL-Cost<br /><input type="text" id="txtGLAccountCodeCost" class="form-control" />
        </div>
        <div class="col-sm-8">
            Process Desc:<textarea id="txtProcessDesc" class="form-control"></textarea>
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
    <button id="btnAdd" class="btn btn-warning" onclick="AddData()">Add</button>
    <button id="btnSave" class="btn btn-success" onclick="SaveData()">Save</button>
    <button id="btnAdd" class="btn btn-danger" onclick="DeleteData()">Delete</button>

</div>
<div id="dvSearch" class="modal fade" role="dialog">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-body">
                <table id="tbGrid" class="table table-responsive">
                    <thead>
                        <tr>
                            <th>
                                Service Code
                            </th>
                            <th>
                                Description
                            </th>
                        </tr>
                    </thead>
                </table>
            </div>

        </div>
    </div>
</div>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    var row = {};
    $(document).ready(function () {
        SetEvents();
    });
    function SetEvents() {
        $('#chkIsTaxCharge').change(function () {
            if (this.checked) {
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
        $('#dvSearch').on('shown.bs.modal', function () {
            $('#tbGrid_filter input').focus();
        });
        $('#txtSICode').keydown(function (e) {
            if (e.which === 13) {
                SearchData($('#txtSICode').val());
            }
        });
    }
    function SearchData(code) {
        $.get(path + 'master/getservicecode?code=' + code).done(function (r) {
            if (r.servicecode.data.length > 0) {
                row = r.servicecode.data[0];
                LoadData(row);
                return;
            } else {
                alert('Data not found');
            }
        });
    }

    function ShowSearch() {
        RefreshGrid();
        $('#dvSearch').modal('show');
    }
    function AddData() {
        var code = $('#cboType').val();
        $.get(path + 'master/getnewservicecode?code=' + code + '-',function (r) {
                if (r.servicecode.data.length>0) {
                    row = r.servicecode.data[0];
                    LoadData(row);
                    return;
                }
            });
    }
    function DeleteData() {
        var code = $('#txtSICode').val();
        $.get(path + 'master/delservicecode?code=' + code, function (r) {
            alert(r.servicecode.result);
            row = r.servicecode.data[0];
            LoadData(row);
        });
    }
    function LoadData(dt) {
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
    }
    function GetDataSave(dt) {
        dt.SICode=$('#txtSICode').val();
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
            var jsonText = JSON.stringify({ data: obj });
            //alert(jsonText);
            $.ajax({
                url: "@Url.Action("SetServiceCode", "Master")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    alert(response);
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
    function RefreshGrid() {
        //popup for search data
        $('#tbGrid').DataTable({
            ajax: {
                url: path + 'Master/GetServiceCode?Code=' + $('#cboType').val(), //web service ที่จะ call ไปดึงข้อมูลมา
                dataSrc: 'servicecode.data'
            },
            selected: true, //ให้สามารถเลือกแถวได้
            columns: [ //กำหนด property ของ header column
                { data: "SICode", title: "Service Code" },
                { data: "NameThai", title: "Description" }
            ],
            destroy: true //ให้ล้างข้อมูลใหม่ทุกครั้งที่ reload page
        });
        $('#tbGrid tbody').on('click', 'tr', function () {
            $('#tbGrid tbody tr.selected').removeClass('selected'); //ล้างทุก row ที่มีการ select ก่อน
            $(this).addClass('selected'); //select row ใหม่

            row = $('#tbGrid').DataTable().row(this).data();
            LoadData(row);

            $('#dvSearch').modal('hide');
        });
    }

</script>
