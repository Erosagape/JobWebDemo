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
    <button id="btnSave" class="btn btn-success" onclick="SaveData()">Save</button>
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
    $(document).ready(function () {
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
    });
    function ShowSearch() {
        RefreshGrid();
        $('#dvSearch').modal('show');
    }
    function SaveData() {

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

            var dt = $('#tbGrid').DataTable().row(this).data();

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
                $('input:radio[name=optVAT][value="'+ dt.IsTaxCharge +'"]').prop('checked', true);
            }

            $('input:radio[name=optWHT]:checked').prop('checked', false);
            if (dt.Is50Tavi === 0) {
                $('#chkIs50Tavi').prop('checked', false);
            } else {
                $('#chkIs50Tavi').prop('checked', true);
                if (dt.IsLtdAdv50Tavi === 1) $('input:radio[name=optWHT][value=1]').prop('checked', true);
                if (dt.IsPay50TaviTo === 1) $('input:radio[name=optWHT][value=2]').prop('checked', true);
            }
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

            $('#dvSearch').modal('hide');
        });
    }
</script>
