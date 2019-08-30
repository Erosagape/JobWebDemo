@Code
    ViewBag.Title = "Users"
End Code
<div class="panel-body">
    <div id="dvForms" class="container">
        <div class="row">
            <div class="col-sm-2">
                User ID :<br /><input type="text" id="txtUserID" class="form-control" tabIndex="1">
            </div>
            <div class="col-sm-4">
                Password :<br /><input type="password" id="txtUPassword" class="form-control" tabIndex="2">
            </div>
            <div class="col-sm-2">
                Department :<br /><select id="txtDeptID" class="form-control dropdown"></select>
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
                Supervisor :<br />
                <div style="display:flex">
                    <div style="flex:1">
                        <input type="text" id="txtUserUpline" class="form-control" tabIndex="7">
                    </div>
                    <div>
                        <input type="button" value="..." class="btn btn-default" onclick="SearchData('sup')" />
                    </div>
                </div>
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
            <a href="#" class="btn btn-primary" id="btnSearch" onclick="SearchData('user')">
                <i class="fa fa-lg fa-filter"></i>&nbsp;<b>Search</b>
            </a>
        </div>
        <div class="row">
            <div class="col-sm-6">
                <b>Role of This User <br /></b>
                <table id="tbRole" class="table table-responsive">
                    <thead>
                        <tr>
                            <th></th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody></tbody>
                </table>
            </div>
            <div class="col-sm-6">
                <b>Module Authorized of This User <br /></b>
                <table id="tbAuthor" class="table table-responsive">
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
    </div>
</div>
<div id="dvLOVs"></div>
<script src="~/Scripts/Func/combo.js"></script>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    let row = {};
    //$(document).ready(function () {
        SetEvents();
        SetEnterToTab();
        ClearData();
    //});
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
        loadLang('#txtUsedLanguage');

        let lists = 'USER_LEVEL=#txtUPosition';
        lists += ',CLR_FROM=#txtDeptID';

        loadCombos(path, lists);

        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            var dv = document.getElementById("dvLOVs");
            //Users
            CreateLOV(dv, '#frmSearchSup', '#tbSup', 'Supervisors', response, 2);
            CreateLOV(dv, '#frmSearchUser', '#tbUser', 'Users', response, 2);
        });
        $('#txtUserID').keydown(function (event) {
            if (event.which == 13) {
                var code = $('#txtUserID').val();
                $('#txtUPassword').val('');
                $('#txtTName').val('');
                $('#txtDeptID').val('');
                $('#txtEName').val('');
                $('#txtTPosition').val('');
                $('#txtUPosition').val('');
                $('#txtEMail').val('');
                $('#txtMobilePhone').val('');
                $('#txtUserUpline').val('');
                $('#txtUsedLanguage').val('');
                CallBackQueryUser(path,code , ReadUser);
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
            $('#txtDeptID').val(dr.DeptID);

            $('#btnSave').removeAttr('disabled');
            if (dr.UserID != "") {
                $('#btnDel').removeAttr('disabled');
            } else {
                $('#btnDel').attr('disabled', 'disabled');
            }

            $.get(path + 'Config/GetUserRoleDetail?ID=' + dr.UserID, function (r) {
                $('#tbRole').dataTable({
                    data: r.userrole.detail,
                    columns: [
                        { data: "RoleID", title: "Id" },
                        { data: "RoleDesc", title: "Description" }
                    ],
                    destroy: true
                });
            });
            $.get(path + 'Config/GetUserAuth?Code=' + dr.UserID, function (r) {
                $('#tbAuthor').dataTable({
                    data: r.userauth.data,
                    columns: [
                        { data: "AppID", title: "Module Id" },
                        { data: "MenuID", title: "Function" },
                        { data: "Author", title: "Authorize" }
                    ],
                    destroy: true
                });
            });
        } else {
            ShowMessage('Data Not Found');
            ClearData();
        }
        //$('#txtUserID').focus();
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
            UserID: $('#txtUserID').val().trim(),
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
            AlertPolicy: row.AlertPolicy,
            DeptID: $('#txtDeptID').val()
        };
        return dr;
    }
    function SaveData() {
        if (row.UserID != undefined) {
            var obj = GetDataSave();
            if (obj.UserID == '') {
                ShowMessage('Please enter user ID');
                return;
            }
            if (obj.TName == '') {
                ShowMessage('Please enter user name');
                return;
            }
            ShowConfirm("Do you need to " + (row.UserID == "" ? "Add" : "Save") + " this data?", function (ask) {
                if (ask == false) return;
                var jsonText = JSON.stringify({ data: obj });
                //ShowMessage(jsonText);
                $.ajax({
                    url: "@Url.Action("SetUser", "Master")",
                    type: "POST",
                    contentType: "application/json",
                    data: jsonText,
                    success: function (response) {
                        if (response.result.data!=null) {
                            $('#txtUserID').val(response.result.data);
                            $('#txtUserID').focus();
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
    function DeleteData() {
        var code = $('#txtUserID').val();
        ShowConfirm("Do you need to Delete " + code + "?", function (ask) {
            if (ask == false) return;
            $.get(path + 'master/deluser?code=' + code, function (r) {
                ShowMessage(r.user.result);
                ClearData();
            });
        });
    }

</script>