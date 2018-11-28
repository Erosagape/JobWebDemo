@Code
    ViewBag.Title = "Master Files"
End Code
<div class="panel-body">
    <div class="container">
        <div id="dvForm">
            UserID :<br /><input type="text" id="txtUserID" class="form-control" tabIndex="1">
            AppID :<br /><input type="text" id="txtAppID" class="form-control" tabIndex="2">
            MenuID :<br /><input type="text" id="txtMenuID" class="form-control" tabIndex="3">
            Author :<br /><input type="text" id="txtAuthor" class="form-control" tabIndex="4">
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
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            var dv = document.getElementById("dvLOVs");
            CreateLOV(dv, '#frmSearchCode', '#tbCode', 'Search Data', response, 2);
        });
    }
    function SearchData(type) {
        switch (type) {
            default:
                break;
        }
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
    function SetEvents() {
        $('#txtUserID').keydown(function (event) {
            if (event.which == 13) {
                var code = $('#txtUserID').val();
                var app = $('#txtAppID').val();
                var menu = $('#txtMenuID').val();
                ClearData();
                $('#txtUserID').val(code);
                CallBackQueryUserAuth(path, code,app,menu, ReadData);
            }
        });
    }
    function DeleteData() {
        var code = $('#txtUserID').val();
        var key = $('#txtAppID').val();
        var menu = $('#txtMenuID').val();
        var ask = confirm("Do you need to Delete " + code + "?");
        if (ask == false) return;
        $.get(path + 'master/deluserauth?code=' + code + '&app='+key+'&menu='+menu, function (r) {
            alert(r.userauth.result);
            ClearData();
        });
    }
    function ReadData(dr) {
        $('#txtUserID').val(dr.UserID);
        $('#txtAppID').val(dr.AppID);
        $('#txtMenuID').val(dr.MenuID);
        $('#txtAuthor').val(dr.Author);
    }
    function SaveData(){
        var obj = {
            UserID:$('#txtUserID').val(),
            AppID:$('#txtAppID').val(),
            MenuID:$('#txtMenuID').val(),
            Author:$('#txtAuthor').val()
        };
        if (obj.UserID != "") {
            if (obj.AppID === "") {
                alert('Please select Application');
                return;
            }
            if (obj.MenuID === "") {
                alert('Please select Menu');
                return;
            }
            var ask = confirm("Do you need to Save This Authorize for " + obj.UserID + "?");
            if (ask == false) return;
            var jsonText = JSON.stringify({ data: obj });
            $.ajax({
                url: "@Url.Action("SetUserAuth", "Config")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.data != null) {
                        $('#txtUserID').val(response.result.data);
                        $('#txtUserID').focus();
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
    function ClearData(){

        $('#txtUserID').val('');
        $('#txtAppID').val('');
        $('#txtMenuID').val('');
        $('#txtAuthor').val('');
    }
</script>
