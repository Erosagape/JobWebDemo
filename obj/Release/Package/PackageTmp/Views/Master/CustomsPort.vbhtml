﻿@Code
    ViewBag.Title = "Customs Port"
End Code
<div class="panel-body">
    <div class="container">
        <div id="dvForm">
            <a href="#" onclick="SearchData('areacode')">Area Code :</a>
            <br /><input type="text" id="txtAreaCode" class="form-control" tabIndex="1">
            Area Name :<br /><input type="text" id="txtAreaName" class="form-control" tabIndex="2">
            <input type="hidden" id="txtAccNo" class="form-control">
            <input type="hidden" id="txtPayee" class="form-control">
            <input type="hidden" id="txtBankCode" class="form-control">
            <input type="hidden" id="txtAcType" class="form-control">
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
                alert('Please enter area name');
                return;
            }
            var ask = confirm("Do you need to Save " + obj.AreaCode +"?");
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
        var ask = confirm("Do you need to Delete " + code + "?");
        if (ask == false) return;

        $.get(path + 'master/delcustomsport?code=' + code, function (r) {
            alert(r.RFARS.result);
            ClearData();
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
