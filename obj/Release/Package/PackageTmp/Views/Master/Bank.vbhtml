@Code
    ViewBag.Title = "Bank"
End Code
<div class="panel-body">
    <div class="container">
        <!-- HTML BOOTSTRAP CONTROLS -->
        <div id="dvForm">
            Bank Code:
            <input type="text" id="txtCode" class="form-control" tabIndex="1">
            Name :<br /><input type="text" id="txtBName" class="form-control" tabIndex="2">
            Customs Code :<br /><input type="text" id="txtCustomsCode" class="form-control" tabIndex="3">
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
        $('#txtCode').keydown(function (event) {
            if (event.which == 13) {
                var code = $('#txtCode').val();
                ClearData();
                $('#txtCode').val(code);
                CallBackQueryBank(path, code, ReadData);
            }
        });
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            var dv = document.getElementById("dvLOVs");
            CreateLOV(dv, '#frmSearchBank', '#tbBank', 'Bank', response, 2);
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
                SetGridBank(path, '#tbBank', '#frmSearchBank', ReadData);
                break;
        }
    }
    //CRUD Functions used in HTML Java Scripts
    function DeleteData() {
        var code = $('#txtCode').val();
        ShowConfirm("Do you need to Delete " + code + "?", function (ask) {
            if (ask == false) return;
            $.get(path + 'master/delbank?code=' + code, function (r) {
                ShowMessage(r.bank.result);
                ClearData();
            });
        });
    }
    function ReadData(dr){
        $('#txtCode').val(dr.Code);
        $('#txtBName').val(dr.BName);
        $('#txtCustomsCode').val(dr.CustomsCode);
    }
    function SaveData(){
        var obj = {
            Code:$('#txtCode').val(),
            BName:$('#txtBName').val(),
            CustomsCode:$('#txtCustomsCode').val(),
        };
        if (obj.Code != "") {
            ShowConfirm("Do you need to Save " + obj.Code + "?", function (ask) {
                if (ask == false) return;
                var jsonText = JSON.stringify({ data: obj });
                //ShowMessage(jsonText);
                $.ajax({
                    url: "@Url.Action("SetBank", "Master")",
                    type: "POST",
                    contentType: "application/json",
                    data: jsonText,
                    success: function (response) {
                        if (response.result.data != null) {
                            $('#txtCode').val(response.result.data);
                            $('#txtCode').focus();
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
        $('#txtCode').val('');
        $('#txtBName').val('');
        $('#txtCustomsCode').val('');
    }
</script>
