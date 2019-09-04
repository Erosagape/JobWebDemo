@Code
    ViewBag.Title = "Account Code"
End Code
<div class="row">
    <div class="col-sm-2">
        Code :
        <br />
        <div style="display:flex">
            <input type="text" id="txtAccCode" class="form-control">
        </div>
    </div>
    <div class="col-sm-5">
        Name (TH) :
        <br />
        <div style="display:flex">
            <input type="text" id="txtAccTName" class="form-control">
        </div>
    </div>
    <div class="col-sm-5">
        Name (EN) :
        <br />
        <div style="display:flex">
            <input type="text" id="txtAccEName" class="form-control">
        </div>
    </div>
</div>
<div class="row">
    <div class="col-sm-2">
        Type :
        <br />
        <div style="display:flex">
            <select id="txtAccType" class="form-control dropdown">
                <option value="1">Assets</option>
                <option value="2">Debts</option>
                <option value="3">Stocks/Captializes</option>
                <option value="4">Revenues</option>
                <option value="5">Expenses</option>
            </select>
        </div>
    </div>
    <div class="col-sm-8">
        Close Balance To :
        <br />
        <div style="display:flex">
            <input type="text" id="txtAccMain" class="form-control" style="width:15%" disabled>
            <input type="button" class="btn btn-default" value="..." onclick="SearchData('sub')" />
            <input type="text" id="txtAccName" class="form-control" style="width:100%" disabled>
        </div>
    </div>
    <div class="col-sm-2">
        Side :
        <br />
        <div style="display:flex">
            <select id="txtAccSide" class="form-control dropdown">
                <option value="D">Debit</option>
                <option value="C">Credit</option>
            </select>
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
    <a href="#" class="btn btn-primary" id="btnSearch" onclick="SearchData('main')">
        <i class="fa fa-lg fa-filter"></i>&nbsp;<b>Search</b>
    </a>
</div>
<div id="dvLOVs"></div>
<script type="text/javascript">
    let path = '@Url.Content("~")';
    SetEvents();
    function SetEvents(){
        $('#txtAccCode').keydown(function (event) {
            if (event.which == 13) {
                let code=$('#txtAccCode').val();
                ClearData();
                $('#txtAccCode').val(code);
                CallBackQueryAccountCode(path, code,ReadData);
            }
        });
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            var dv = document.getElementById("dvLOVs");
            CreateLOV(dv, '#frmSearchMain', '#tbMain', 'Account Code', response, 2);
            CreateLOV(dv, '#frmSearchSub', '#tbSub', 'Account Code', response, 2);
        });
    }
    //CRUD Functions used in HTML Java Scripts
    function DeleteData() {
        let code = $('#txtAccCode').val();
        ShowConfirm("Do you need to Delete " + code + "?",function(ask){
            if (ask == false) return;
            $.get(path + 'master/delaccountcode?code=' + code, function (r) {
                ShowMessage(r.accountcode.result);
                ClearData();
            });
        });
    }
    function ReadData(dr) {
        $('#txtAccCode').val(dr.AccCode);
        $('#txtAccTName').val(dr.AccTName);
        $('#txtAccEName').val(dr.AccEName);
        $('#txtAccType').val(dr.AccType);
        $('#txtAccMain').val(dr.AccMain);
        ShowAccount(path, dr.AccMain, '#txtAccName');
        $('#txtAccSide').val(dr.AccSide);
    }
    function SaveData() {
        let obj = {
            AccCode:$('#txtAccCode').val(),
            AccTName:$('#txtAccTName').val(),
            AccEName:$('#txtAccEName').val(),
            AccType:$('#txtAccType').val(),
            AccMain:$('#txtAccMain').val(),
            AccSide:$('#txtAccSide').val()
	    };
        if (obj.AccCode != "") {
            ShowConfirm("Do you need to Save " + obj.AccCode + "?",function(ask){
                if (ask == false) return;
                let jsonText = JSON.stringify({ data: obj });
                //ShowMessage(jsonText);
                $.ajax({
                    url: "@Url.Action("SetAccountCode", "Master")",
                    type: "POST",
                    contentType: "application/json",
                    data: jsonText,
                    success: function (response) {
                        if (response.result.data != null) {
                            $('#txtAccCode').val(response.result.data);
                            $('#txtAccCode').focus();
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
        $('#txtAccCode').val('');
        $('#txtAccTName').val('');
        $('#txtAccEName').val('');
        $('#txtAccName').val('');
        $('#txtAccType').val('');
        $('#txtAccMain').val('');
        $('#txtAccSide').val('');
    }
    function SearchData(type) {
        switch (type) {
            case 'main':
                SetGridAccountCode(path, '#tbMain', '#frmSearchMain', '', ReadData);
                break;
            case 'sub':
                SetGridAccountCode(path, '#tbSub', '#frmSearchSub', '', ReadSub);
                break;
        }
    }
    function ReadSub(dr) {
        $('#txtAccMain').val(dr.AccCode);
        $('#txtAccName').val(dr.AccTName);
    }
</script>