@Code
    ViewBag.Title = "Service Units"
End Code
<div class="panel-body">
    <div class="container">
        <div id="dvForm">
            Code:<br /><input type="text" id="txtUnitType" class="form-control" tabIndex="1">
            Name (TH) :<br /><input type="text" id="txtUName" class="form-control" tabIndex="2">
            English :<br /><input type="text" id="txtEName" class="form-control" tabIndex="3">
            Type :<br />
                  <select id="txtIsCTNUnit" class="form-control dropdown" tabIndex="4">
                      <option value="-1">เป็นหน่วยงานบริการ</option>
                      <option value="0">เป็นหน่วยนับสินค้า</option>
                      <option value="1">เป็นหน่วยตู้</option>
                      <option value="2">เป็นหน่วยพาหนะ</option>
                  </select>
        </div>
        <div id="dvCommand">
            <a href="#" class="btn btn-default w3-purple" id="btnAdd" onclick="ClearData()">
                <i class="fa fa-lg fa-file-o"></i>&nbsp;<b>New</b>
            </a>
            <a href="#" class="btn btn-success" id="btnSave" onclick="SaveData()">
                <i class="fa fa-lg fa-save"></i>&nbsp;<b>Save</b>
            </a>
            <a href="#" class="btn btn-danger" id="btnDelete" onclick="DeleteData()">
                <i class="fa fa-lg fa-trash"></i>&nbsp;<b>Delete</b>
            </a>
            <a href="#" class="btn btn-primary" id="btnSearch" onclick="SearchData('unit')">
                <i class="fa fa-lg fa-filter"></i>&nbsp;<b>Search</b>
            </a>
        </div>
    </div>
    <div id="dvLOVs"></div>
</div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    //$(document).ready(function () {
        SetEvents();
        SetEnterToTab();
        ClearData();
    //});
    function SetEvents() {
        $('#txtUnitType').keydown(function (event) {
            if (event.which == 13) {                
                var code = $('#txtUnitType').val();
                ClearData();
                $('#txtUnitType').val(code);
                CallBackQueryServUnit(path, code, ReadData);
            }
        });
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            var dv = document.getElementById("dvLOVs");
            CreateLOV(dv, '#frmSearchUnit', '#tbUnit', 'Units', response, 2);
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
        $('#txtUnitType').val(dr.UnitType);
        $('#txtUName').val(dr.UName);
        $('#txtEName').val(dr.EName);
        $('#txtIsCTNUnit').val(dr.IsCTNUnit);
    }
    function DeleteData() {
        var code = $('#txtUnitType').val();
        ShowConfirm("Do you need to Delete " + code + "?", function (ask) {
            if (ask == false) return;
            $.get(path + 'master/delservunit?code=' + code, function (r) {
                ShowMessage(r.servunit.result);
                ClearData();
            });
        });
    }
    function SaveData() {
        var obj = {
            UnitType: $('#txtUnitType').val(),
            UName: $('#txtUName').val(),
            EName: $('#txtEName').val(),
            IsCTNUnit: $('#txtIsCTNUnit').val(),
        };
        if (obj.UnitType != "") {
            if (obj.UName == '') {
                ShowMessage('Please enter unit name');
                $('#txtUName').focus();
                return;
            }
            ShowConfirm("Do you need to Save " + obj.UnitType + "?", function (ask) {
                if (ask == false) return;
                var jsonText = JSON.stringify({ data: obj });
                //ShowMessage(jsonText);
                $.ajax({
                    url: "@Url.Action("SetServUnit", "Master")",
                    type: "POST",
                    contentType: "application/json",
                    data: jsonText,
                    success: function (response) {
                        if (response.result.data != null) {
                            $('#txtUnitType').val(response.result.data);
                            $('#txtUnitType').focus();
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
    }
    function ClearData() {
        $('#txtUnitType').val('');
        $('#txtUName').val('');
        $('#txtEName').val('');
        $('#txtIsCTNUnit').val('');

        $('#txtUnitType').focus();
    }
    function SearchData(type) {
        switch (type) {
            case 'unit':
                SetGridServUnit(path, '#tbUnit', '#frmSearchUnit', ReadData);
                break;
        }
    }
</script>
