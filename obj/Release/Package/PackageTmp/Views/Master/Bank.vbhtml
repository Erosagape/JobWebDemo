@Code
    ViewBag.Title = "Bank"
End Code
<div class="panel-body">
    <div class="container">
        <!-- HTML BOOTSTRAP CONTROLS -->
        <div id="dvForm">
            <a href="#" onclick="SearchData('code')">Bank Code:</a><br />
            <input type="text" id="txtCode" class="form-control" tabIndex="1">
            Name :<br /><input type="text" id="txtBName" class="form-control" tabIndex="2">
            Customs Code :<br /><input type="text" id="txtCustomsCode" class="form-control" tabIndex="3">
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
        var ask = confirm("Do you need to Delete " + code + "?");
        if (ask == false) return;
            $.get(path + 'master/delbank?code=' + code, function (r) {
                alert(r.bank.result);
                ClearData();
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
            var ask = confirm("Do you need to Save " + obj.Code + "?");
            if (ask == false) return;
            var jsonText = JSON.stringify({ data: obj });
            //alert(jsonText);
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
        $('#txtCode').val('');
        $('#txtBName').val('');
        $('#txtCustomsCode').val('');
    }
</script>
