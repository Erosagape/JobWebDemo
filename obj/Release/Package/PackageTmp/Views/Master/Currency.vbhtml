@Code
    ViewBag.Title = "Currency"
End Code
<div class="panel-body">
    <div class="container">
        <div id="dvForm">
            <div class="row">
                <div class="col-sm-3">
                    <a href="#" onclick="SearchData('currency')">Currency Code</a> :
                    <br /><input type="text" id="txtCode" class="form-control" tabIndex="1">
                </div>
                <div class="col-sm-9">
                    Currency Name :<br /><input type="text" id="txtTName" class="form-control" tabIndex="2">
                </div>
            </div>
            <div class="row">
                <div class="col-sm-4">
                    Begin Date :<br /><input type="date" id="txtStartDate" class="form-control" tabIndex="3">
                </div>
                <div class="col-sm-4">
                    Expire Date :<br /><input type="date" id="txtFinishDate" class="form-control" tabIndex="4">
                </div>
                <div class="col-sm-4">
                    Last Update :<br /><input type="date" id="txtLastUpdate" class="form-control" disabled>
                </div>
            </div>
        </div>
        <div id="dvCommand">
            <button id="btnAdd" class="btn btn-default" onclick="ClearData()">Add</button>
            <button id="btnSave" class="btn btn-success" onclick="SaveData()">Save</button>
            <button id="btnDel" class="btn btn-danger" onclick="DeleteData()">Delete</button>
        </div>
    </div>
    <div id="dvLOVs"></div>
</div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    $(document).ready(function () {
        SetEvents();
        SetEnterToTab();
        ClearData();
    });
    function SetEvents() {
        $('#txtCode').keydown(function (event) {
            if (event.which == 13) {
                var code = $('#txtCode').val();
                ClearData();
                $('#txtCode').val(code);
                CallBackQueryCurrency(path, code, ReadData);
            }
        });
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            var dv = document.getElementById("dvLOVs");
            CreateLOV(dv, '#frmSearchCurr', '#tbCurr', 'Currency', response, 2);
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
                    $('[tabindex="1"]').focus();
                }
            });
        });
    }
    function ReadData(dr) {
        $('#txtCode').val(dr.Code);
        $('#txtTName').val(dr.TName);
        $('#txtStartDate').val(CDateEN(dr.StartDate));
        $('#txtFinishDate').val(CDateEN(dr.FinishDate));
        $('#txtLastUpdate').val(CDateEN(dr.LastUpdate));
    }
    function ClearData() {
        $('#txtCode').val('');
        $('#txtTName').val('');
        $('#txtStartDate').val('');
        $('#txtFinishDate').val('');
        $('#txtLastUpdate').val(GetToday());

        $('#txtCode').focus();
    }
    function DeleteData() {
        var code = $('#txtCode').val();
        var ask = confirm("Do you need to Delete " + code + "?");
        if (ask == false) return;

        $.get(path + 'master/delcurrency?code=' + code, function (r) {
            alert(r.currency.result);
            ClearData();
        });
    }
    function SaveData() {
        var obj = {
            Code: $('#txtCode').val(),
            TName: $('#txtTName').val(),
            StartDate: CDateTH($('#txtStartDate').val()),
            FinishDate: CDateTH($('#txtFinishDate').val()),
            LastUpdate: CDateTH(GetToday()),
        };
        if (obj.Code != "") {
            if (obj.TName == '') {
                alert('Please enter currency name');
                return;
            }
            var ask = confirm("Do you need to Save " + obj.Code +"?");
            if (ask == false) return;
            var jsonText = JSON.stringify({ data: obj });
            //alert(jsonText);
            $.ajax({
                url: "@Url.Action("SetCurrency", "Master")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.data != null) {
                        $('#txtCode').val(response.result.data);
                        $('#txtCode').focus();
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
    function SearchData(type) {
        switch (type) {
            case 'currency':
                SetGridCurrency(path, '#tbCurr', '#frmSearchCurr', ReadData);
                break;
        }
    }
</script>
