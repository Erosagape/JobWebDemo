@Code
    ViewBag.Title = "Service Group"
End Code
<div class="panel-body">
    <div id="dvForm" class="container" style="width:100%">
        <div class="form-group row">

            <div class="col-sm-3"><a onclick="RefreshGrid()">Group Code :</a><br /><input type="text" id="txtGroupCode" class="form-control" tabIndex="1"></div>
            <div class="col-sm-5">Group Name :<br /><input type="text" id="txtGroupName" class="form-control" tabIndex="2"></div>
            <div class="col-sm-4">GL Account :<br /><input type="text" id="txtGLAccountCode" class="form-control" tabIndex="3"></div>
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
                <input type="checkbox" id="chkIsApplyPolicy" />
                <label for="chkIsShowPrice">Apply Policy To all Code</label>
            </div>
        </div>
        <button id="btnAdd" class="btn btn-default" onclick="AddData()">Add</button>
        <button id="btnSave" class="btn btn-success" onclick="SaveData()">Save</button>
        <button id="btnDel" class="btn btn-danger" onclick="DeleteData()">Delete</button>
        <table class="table table-responsive" id="tbDetail">
            <thead>
                <tr>
                    <th></th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            <tbody></tbody>
        </table>
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
        $('#txtGroupCode').focus();
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
            //Service Group
            CreateLOV(dv,'#dvSearch','#tbGrid','Service Group',response,2);
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
        $('#txtGroupCode').keydown(function (e) {
            if (e.which === 13) {
                SearchData($('#txtGroupCode').val());
            }
        });
    }
    function SearchData(code) {
        //function for query data from code
        $.get(path + 'master/getservicegroup?code=' + code).done(function (r) {
            if (r.servicegroup.data.length > 0) {
                LoadData(r.servicegroup.data[0]);
                return;
            } else {
                alert('Data not found');
                AddData();
            }
        });
    }
    function ShowData(dt) {
        LoadData(dt);
        $('#txtGroupCode').focus();
    }
    function RefreshGrid() {
        SetGridGroupCode( path, '#tbGrid', '#dvSearch' , ShowData);
    }
    function AddData() {
        $('#txtGroupCode').val('');
        $('#txtGroupName').val('');
        $('#txtGLAccountCode').val('');

        $('#chkIsTaxCharge').prop('checked',false);
        $('#chkIs50Tavi').prop('checked', false);

        $('input:radio[name=optVAT]:checked').prop('checked', false);
        $('input:radio[name=optWHT]:checked').prop('checked', false);

        $('#txtRate50Tavi').val(0);

        $('#chkIsApplyPolicy').prop('checked', false);
        $('#chkIsHaveSlip').prop('checked', false);
        $('#chkIsCredit').prop('checked', false);
        $('#chkIsExpense').prop('checked', false);

    }
    function DeleteData() {
        var code = $('#txtGroupCode').val();
        var ask = confirm("Do you need to Delete "+code +"?");
        if (ask == false) return;

        $.get(path + 'master/delservicegroup?code=' + code, function (r) {
            alert(r.servicegroup.result);
            ShowData(r.servicegroup.data[0]);
        });
    }
    function LoadData(dt) {
        row = dt;

        $('#txtGroupCode').val(dt.GroupCode);
        $('#txtGroupName').val(dt.GroupName);
        $('#txtGLAccountCode').val(dt.GLAccountCode);

        $('#chkIsApplyPolicy').prop('checked', dt.IsApplyPolicy === 0 ? false : true);
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

        $.get(path + 'Master/GetServiceCode?Group=' + dt.GroupCode, function (r) {
            $('#tbDetail').dataTable({
                data: r.servicecode.data,
                columns: [
                    { data: "SICode", title: "Id" },
                    { data: "NameThai", title: "Description (TH)" },
                    { data: "NameEng", title: "Description (EN)" }
                ],
                destroy:true
            });
        });
    }
    function GetDataSave(dt) {
        dt.GroupCode = $('#txtGroupCode').val();
        dt.GroupName = $('#txtGroupName').val();
        dt.GLAccountCode= $('#txtGLAccountCode').val();

        if ($('#chkIsTaxCharge').prop('checked') == false) {
            dt.IsTaxCharge = 0;
        } else {
            dt.IsTaxCharge = $('input:radio[name=optVAT]:checked').val() == '2' ? 2 : 1;
        }
        dt.IsApplyPolicy = $('#chkIsApplyPolicy').prop('checked') == true ? 1 : 0;
        dt.Is50Tavi = $('#chkIs50Tavi').prop('checked') == true ? 1 : 0;

        dt.IsPay50TaviTo = $('input:radio[name=optWHT]:checked').val() == '2' ? 1 : 0;
        dt.IsLtdAdv50Tavi = $('input:radio[name=optWHT]:checked').val() == '1' ? 1 : 0;
        dt.Rate50Tavi = CNum($('#txtRate50Tavi').val());

        dt.IsHaveSlip = $('#chkIsHaveSlip').prop('checked') === true ? 1 : 0;
        dt.IsCredit = $('#chkIsCredit').prop('checked') === true ? 1 : 0;
        dt.IsExpense = $('#chkIsExpense').prop('checked') === true ? 1 : 0;
        
        return dt;
    }
    function SaveData() {
        if (row.GroupCode != undefined) {
            var obj = GetDataSave(row);
            if (obj.GroupCode == '') {
                alert('Please enter code');
                return;
            }
            if (obj.GroupName == '') {
                alert('Please enter name');
                return;
            }
            var ask = confirm("Do you need to " + (row.GroupCode == "" ? "Add" : "Save") + " this data?");
            if (ask == false) return;
            var jsonText = JSON.stringify({ data: obj });
            //alert(jsonText);
            $.ajax({
                url: "@Url.Action("SetServiceGroup", "Master")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.data!=null) {
                        $('#txtGroupCode').val(response.result.data);
                        $('#txtGroupCode').focus();
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

</script>

