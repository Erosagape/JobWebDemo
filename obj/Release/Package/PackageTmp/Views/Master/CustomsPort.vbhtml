@Code
    ViewBag.Title = "Customs Port"
End Code
<div class="panel-body">
    <div class="container">
        <div id="dvForm">
            Area Code :
            <br /><input type="text" id="txtAreaCode" class="form-control" tabIndex="1">
            Area Name :<br /><input type="text" id="txtAreaName" class="form-control" tabIndex="2">
            <input type="hidden" id="txtAccNo" class="form-control">
            <input type="hidden" id="txtPayee" class="form-control">
            <input type="hidden" id="txtBankCode" class="form-control">
            <input type="hidden" id="txtAcType" class="form-control">
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
            <a href="#" class="btn btn-primary" id="btnSearch" onclick="SearchData('areacode')">
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
        $('#txtAreaCode').keydown(function (event) {
            if (event.which == 13) {
                var code = $('#txtAreaCode').val();
                ClearData();
                $('#txtAreaCode').val(code);
                CallBackQueryCustomsPort(path,code , ReadData);
            }
        });
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            var dv = document.getElementById("dvLOVs");
            CreateLOV(dv, '#frmSearchCode', '#tbCode', 'Customs Port', response, 2);
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

        $('#txtAreaCode').val(dr.AreaCode);
        $('#txtAreaName').val(dr.AreaName);
        $('#txtAccNo').val(dr.AccNo);
        $('#txtPayee').val(dr.Payee);
        $('#txtBankCode').val(dr.BankCode);
        $('#txtAcType').val(dr.AcType);
    }
    function SaveData() {
        var obj = {

            AreaCode: $('#txtAreaCode').val(),
            AreaName: $('#txtAreaName').val(),
            AccNo: $('#txtAccNo').val(),
            Payee: $('#txtPayee').val(),
            BankCode: $('#txtBankCode').val(),
            AcType: $('#txtAcType').val(),
        };
        if (obj.AreaCode != "") {
            if (obj.AreaName == '') {
                ShowMessage('Please enter area name');
                return;
            }
            ShowConfirm("Do you need to Save " + obj.AreaCode + "?", function (ask) {
                if (ask == false) return;
                var jsonText = JSON.stringify({ data: obj });

                $.ajax({
                    url: "@Url.Action("SetCustomsPort", "Master")",
                    type: "POST",
                    contentType: "application/json",
                    data: jsonText,
                    success: function (response) {
                        if (response.result.data != null) {
                            $('#txtAreaCode').val(response.result.data);
                            $('#txtAreaCode').focus();
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

        $('#txtAreaCode').val('');
        $('#txtAreaName').val('');
        $('#txtAccNo').val('');
        $('#txtPayee').val('');
        $('#txtBankCode').val('');
        $('#txtAcType').val('');

        $('#txtAreaCode').focus();
    }
    function DeleteData() {
        var code = $('#txtAreaCode').val();
        ShowConfirm("Do you need to Delete " + code + "?", function (ask) {
            if (ask == false) return;
            $.get(path + 'master/delcustomsport?code=' + code, function (r) {
                ShowMessage(r.RFARS.result);
                ClearData();
            });
        });
    }
    function SearchData(type) {
        switch (type) {
            case 'areacode':
                SetGridCustomsPort(path, '#tbCode', '#frmSearchCode', ReadData);
                break;
        }
    }
</script>
