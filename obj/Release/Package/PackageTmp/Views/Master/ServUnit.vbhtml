@Code
    ViewBag.Title = "Service Units"
End Code
<div class="panel-body">
    <div class="container">
        <div id="dvForm">
            <a href="#" onclick="SearchData('unit')">Code:</a><br /><input type="text" id="txtUnitType" class="form-control" tabIndex="1">
            Name (TH) :<br /><input type="text" id="txtUName" class="form-control" tabIndex="2">
            English :<br /><input type="text" id="txtEName" class="form-control" tabIndex="3">
            Type :<br />
                  <select id="txtIsCTNUnit" class="form-control dropdown" tabIndex="4">
                      <option value="-1">เป็นหน่วยงานบริการ</option>
                      <option value="0">เป็นหน่วยนับสินค้า</option>
                      <option value="1">เป็นหน่วยตู้/ขนส่ง</option>
                  </select>
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
        var ask = confirm("Do you need to Delete " + code + "?");
        if (ask == false) return;

        $.get(path + 'master/delservunit?code=' + code, function (r) {
            alert(r.servunit.result);
            ClearData();
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
                alert('Please enter unit name');
                $('#txtUName').focus();
                return;
            }
            var ask = confirm("Do you need to Save " + obj.UnitType + "?");
            if (ask == false) return;
            var jsonText = JSON.stringify({ data: obj });
            //alert(jsonText);
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
