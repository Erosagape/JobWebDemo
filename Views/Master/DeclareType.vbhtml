@Code
    ViewBag.Title = "Declare Type"
End Code
<div class="panel-body">
    <div class="container">
        <div id="dvForm">
            <div class="row">
                <div class="col-sm-2">
                    Declare Type :<br />
                    <input type="text" id="txtType" class="form-control" tabIndex="1">
                </div>
                <div class="col-sm-7">
                    Description :<br /><input type="text" id="txtDescription" class="form-control" tabIndex="2">
                </div>
                <div class="col-sm-3">
                    Category :<br />
                    <select id="txtCategory" class="form-control dropdown" tabIndex="3">
                        <option value="B">IMPORT&EXPORT</option>
                        <option value="M">IMPORT</option>
                        <option value="X">EXPORT</option>
                    </select>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-4">
                    StartDate :<br /><input type="date" id="txtStartDate" class="form-control" tabIndex="4">
                </div>
                <div class="col-sm-4">
                    FinishDate :<br /><input type="date" id="txtFinishDate" class="form-control" tabIndex="5">
                </div>
                <div class="col-sm-4">
                    LastUpdate :<br /><input type="date" id="txtLastUpdate" class="form-control" disabled>
                </div>
            </div>
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
            <a href="#" class="btn btn-primary" id="btnSearch" onclick="SearchData('code')">
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
        $('#txtType').keydown(function (event) {
            if (event.which == 13) {
                var code = $('#txtType').val();
                ClearData();
                $('#txtType').val(code);
                CallBackQueryDeclareType(path, code, ReadData);
            }
        });
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            var dv = document.getElementById("dvLOVs");
            CreateLOV(dv, '#frmSearchCode', '#tbCode', 'Declare Type', response, 2);
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
    function SearchData(type) {
        switch (type) {
            case 'code':
                SetGridDeclareType(path, '#tbCode', '#frmSearchCode', ReadData);
                break;
        }
    }
    function ReadData(dr) {
        $('#txtType').val(dr.Type);
        $('#txtDescription').val(dr.Description);
        $('#txtCategory').val(dr.Category);
        $('#txtStartDate').val(CDateEN(dr.StartDate));
        $('#txtFinishDate').val(CDateEN(dr.FinishDate));
        $('#txtLastUpdate').val(CDateEN(dr.LastUpdate));
    }
    function SaveData() {
        var obj = {
            Type: $('#txtType').val(),
            Description: $('#txtDescription').val(),
            Category: $('#txtCategory').val(),
            StartDate: CDateTH($('#txtStartDate').val()),
            FinishDate: CDateTH($('#txtFinishDate').val()),
            LastUpdate: CDateTH(GetToday()),
        };
        if (obj.Type != "") {
            if (obj.Description == '') {
                ShowMessage('Please enter description');
                return;
            }
            ShowConfirm("Do you need to Save " + obj.Type + "/" + obj.Description + "?", function (ask) {
                if (ask == false) return;
                var jsonText = JSON.stringify({ data: obj });
                //ShowMessage(jsonText);
                $.ajax({
                    url: "@Url.Action("SetDeclareType", "Master")",
                    type: "POST",
                    contentType: "application/json",
                    data: jsonText,
                    success: function (response) {
                        if (response.result.data != null) {
                            $('#txtType').val(response.result.data);
                            $('#txtType').focus();
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

        $('#txtType').val('');
        $('#txtDescription').val('');
        $('#txtCategory').val('');
        $('#txtStartDate').val('');
        $('#txtFinishDate').val('');
        $('#txtLastUpdate').val(CDateEN(GetToday()));

        $('#txtType').focus();
    }
    function DeleteData() {
        var code = $('#txtType').val();
        ShowConfirm("Do you need to Delete " + code + "?", function (ask) {
            if (ask == false) return;
            $.get(path + 'master/deldeclaretype?code=' + code, function (r) {
                ShowMessage(r.RFDCT.result);
                ClearData();
            });
        });
    }
</script>
