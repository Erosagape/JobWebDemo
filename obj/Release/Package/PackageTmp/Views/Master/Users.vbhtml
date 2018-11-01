
@Code
    ViewBag.Title = "Users"
End Code
<div class="panel-body">
    <div id="dvForms" class="container">
        <div class="row">
            <div class="col-sm-2">
                <a onclick="SearchData('user')"> User ID :</a><br /><input type="text" id="txtUserID" class="form-control" tabIndex="1">
            </div>
            <div class="col-sm-4">
                Password :<br /><input type="password" id="txtUPassword" class="form-control" tabIndex="2">
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                Name (TH) :<br /><input type="text" id="txtTName" class="form-control" tabIndex="3">
            </div>
            <div class="col-sm-6">
                Name (EN) :<br /><input type="text" id="txtEName" class="form-control" tabIndex="4">
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                Position :<br /><input type="text" id="txtTPosition" class="form-control" tabIndex="5">
            </div>
            <div class="col-sm-4">
                User Level :<br /><select id="txtUPosition" class="form-control dropdown" tabIndex="6"></select>
            </div>
            <div class="col-sm-4">
                <a onclick="SearchData('sup')"> Supervisor :</a><br /><input type="text" id="txtUserUpline" class="form-control" tabIndex="7">                
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                E-Mail :<br /><input type="text" id="txtEMail" class="form-control" tabIndex="8">
            </div>
            <div class="col-sm-4">
                Mobile Phone :<br /><input type="text" id="txtMobilePhone" class="form-control" tabIndex="9">
            </div>
            <div class="col-sm-4">
                Report Language :<br />
                <select id="txtUsedLanguage" class="form-control dropdown" tabindex="10"></select>
            </div>
        </div>
        <button id="btnAdd" class="btn btn-default" onclick="ClearData()">Add</button>
        <button id="btnSave" class="btn btn-success" onclick="SaveData()">Save</button>
        <button id="btnDel" class="btn btn-danger" onclick="DeleteData()">Delete</button>
    </div>
</div>
<div id="dvLOVs"></div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    var path = '@Url.Content("~")';
    var row = {};
    $(document).ready(function () {
        SetEvents();
    });
    function SetEvents() {
        loadLang('#txtUsedLanguage');
        loadConfig('#txtUPosition', 'USER_LEVEL', path, '');
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            var dv = document.getElementById("dvLOVs");
            //Users
            CreateLOV(dv, '#frmSearchSup', '#tbSup', 'Supervisors', response, 2);
            CreateLOV(dv, '#frmSearchUser', '#tbUser', 'Users', response, 2);
        });
        $('#txtUserID').keydown(function (event) {
            if (event.which == 13) {
                CallBackQueryUser(path, $('#txtUserID').val(), ReadUser);
            }
        });
    }
    function SearchData(type) {
        switch (type) {
            case 'sup':
                SetGridUser(path, '#tbSup', '#frmSearchSup', ReadSup);
                break;
            case 'user':
                SetGridUser(path, '#tbUser', '#frmSearchUser', ReadUser);
                break;
        }
    }
    function ReadSup(dt) {
        $('#txtUserUpline').val(dt.UserID);
        $('#txtUserUpline').focus();
    }
    function ReadUser(dr) {
        if (dr.UserID != undefined) {
            row = dr;
            $('#txtUserID').val(dr.UserID);
            $('#txtUPassword').val(dr.UPassword);
            $('#txtTName').val(dr.TName);
            $('#txtEName').val(dr.EName);
            $('#txtTPosition').val(dr.TPosition);
            $('#txtUPosition').val(CCode(dr.UPosition));
            $('#txtEMail').val(dr.EMail);
            $('#txtMobilePhone').val(dr.MobilePhone);
            $('#txtUserUpline').val(dr.UserUpline);
            $('#txtUsedLanguage').val(dr.UsedLanguage);
        } else {
            alert('Data Not Found');
        }
        $('#txtUserID').focus();
    }
    function ClearData() {
        $.get(path + 'master/getnewuser', function (r) {
            if (r.user.data != undefined) {
                ReadUser(r.user.data);
                $('#txtUserID').focus();
                return;
            }
        });
    }
    function GetDataSave() {
        var dr = {
            UserID: $('#txtUserID').val(),
            UPassword: $('#txtUPassword').val(),
            TName: $('#txtTName').val(),
            EName: $('#txtEName').val(),
            TPosition: $('#txtTPosition').val(),
            LoginDate: row.LoginDate,
            LoginTime: row.LoginTime,
            LogoutDate: row.LogoutDate,
            LogoutTime: row.LogoutTime,
            UPosition: $('#txtUPosition').val(),
            MaxRateDisc: row.MaxRateDisc,
            MaxAdvance: row.MaxAdvance,
            JobAuthorize: row.JobAuthorize,
            EMail: $('#txtEMail').val(),
            MobilePhone: $('#txtMobilePhone').val(),
            IsAlertByAgent: row.IsAlertByAgent,
            IsAlertByEMail: row.IsAlertByEMail,
            IsAlertBySMS: row.IsAlertBySMS,
            UserUpline: $('#txtUserUpline').val(),
            GLAccountCode: row.GLAccountCode,
            UsedLanguage: $('#txtUsedLanguage').val(),
            DMailAccount: row.DMailAccount,
            DMailPassword: row.DMailPassword,
            JobPolicy: row.JobPolicy,
            AlertPolicy: row.AlertPolicy
        };
        return dr;
    }
    function SaveData() {
        if (row.UserID != undefined) {
            var obj = GetDataSave();
            var ask = confirm("Do you need to " + (row.UserID == "" ? "Add" : "Save") + " this data?");
            if (ask == false) return;
            var jsonText = JSON.stringify({ data: obj });
            //alert(jsonText);
            $.ajax({
                url: "@Url.Action("SetUsers", "Master")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.data!=null) {
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
    function DeleteData() {
        var code = $('#txtUserID').val();
        var ask = confirm("Do you need to Delete " + code + "?");
        if (ask == false) return;

        $.get(path + 'master/deluser?code=' + code, function (r) {
            alert(r.user.result);
            ReadUser(r.user.data[0]);
        });
    }

</script>