
@Code
    ViewBag.Title = "Venders"
End Code
<div class="panel-body">
    <div class="container">
        <div class="row">
            <div class="col-sm-4">
                <a href="#" onclick="SearchData('vender')">Vender Code</a>:<br /><input type="text" id="txtVenCode" Class="form-control" tabIndex="0">
            </div>
            <div class="col-sm-4">
                Branch :<br/>
                <input type="text" id="txtBranchCode" Class="form-control" tabIndex="1" />
            </div>
            <div class="col-sm-4">
                Tax Number:<br /><input type="text" id="txtTaxNumber" Class="form-control" tabIndex="2">
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3">
                Title:<br /><input type="text" id="txtTitle" Class="form-control" tabIndex="3">
            </div>
            <div class="col-sm-4">
                Name:<br /><input type="text" id="txtTName" Class="form-control" tabIndex="4">
            </div>
            <div class="col-sm-5">
                English:<br /><input type="text" id="txtEnglish" Class="form-control" tabIndex="5">
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                Address (TH):<br /><input type="text" id="txtTAddress1" Class="form-control" tabIndex="6">
                <br /><input type="text" id="txtTAddress2" Class="form-control" tabIndex="7">
            </div>
            <div class="col-sm-6">
                Address (EN):<br /><input type="text" id="txtEAddress1" Class="form-control" tabIndex="8">
                <br /><input type="text" id="txtEAddress2" Class="form-control" tabIndex="9">
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3">
                Phone:<br /><input type="text" id="txtPhone" Class="form-control" tabIndex="10">
            </div>
            <div class="col-sm-3">
                Fax:<br /><input type="text" id="txtFaxNumber" Class="form-control" tabIndex="11">
            </div>
            <div class="col-sm-3">
                Web/E-mail:<br /><input type="text" id="txtWEB_SITE" Class="form-control" tabIndex="12">
            </div>
            <div class="col-sm-3">
                GL Code:<br /><input type="text" id="txtGLAccountCode" Class="form-control" tabIndex="13">
            </div>
        </div>
        <div class="row">
            <div class="col-sm-6">
                Contact Information:<br />Account : <input type="text" id="txtContactAcc" Class="form-control" tabIndex="13">
                <br />Sales : <input type="text" id="txtContactSale" Class="form-control" tabIndex="14">
            </div>
            <div class="col-sm-6">
                Customer Service :<br /><input type="text" id="txtContactSupport1" Class="form-control" tabIndex="15">
                <br /><input type="text" id="txtContactSupport2" Class="form-control" tabIndex="16">
                <br /><input type="text" id="txtContactSupport3" Class="form-control" tabIndex="17">
            </div>
        </div>
        <input type="hidden" id="txtLoginName">
        <input type="hidden" id="txtLoginPassword">
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
        SetLOVs();
        SetEnterToTab();
        ClearData();
    });
    function GetDataSave() {
        var dr = {
            VenCode: $('#txtVenCode').val().trim(),
            BranchCode: $('#txtBranchCode').val(),
            TaxNumber: $('#txtTaxNumber').val(),
            Title: $('#txtTitle').val(),
            TName: $('#txtTName').val(),
            English: $('#txtEnglish').val(),
            TAddress1: $('#txtTAddress1').val(),
            TAddress2: $('#txtTAddress2').val(),
            EAddress1: $('#txtEAddress1').val(),
            EAddress2: $('#txtEAddress2').val(),
            Phone: $('#txtPhone').val(),
            FaxNumber: $('#txtFaxNumber').val(),
            LoginName: $('#txtLoginName').val(),
            LoginPassword: $('#txtLoginPassword').val(),
            GLAccountCode: $('#txtGLAccountCode').val(),
            ContactAcc: $('#txtContactAcc').val(),
            ContactSale: $('#txtContactSale').val(),
            ContactSupport1: $('#txtContactSupport1').val(),
            ContactSupport2: $('#txtContactSupport2').val(),
            ContactSupport3: $('#txtContactSupport3').val(),
            WEB_SITE: $('#txtWEB_SITE').val()
        };
        return dr;
    }
    function ClearData() {
        $('#txtVenCode').val('');
        $('#txtBranchCode').val('');
        $('#txtTaxNumber').val('');
        $('#txtTitle').val('');
        $('#txtTName').val('');
        $('#txtEnglish').val('');
        $('#txtTAddress1').val('');
        $('#txtTAddress2').val('');
        $('#txtEAddress1').val('');
        $('#txtEAddress2').val('');
        $('#txtPhone').val('');
        $('#txtFaxNumber').val('');
        $('#txtLoginName').val('');
        $('#txtLoginPassword').val('');
        $('#txtGLAccountCode').val('');
        $('#txtContactAcc').val('');
        $('#txtContactSale').val('');
        $('#txtContactSupport1').val('');
        $('#txtContactSupport2').val('');
        $('#txtContactSupport3').val('');
        $('#txtWEB_SITE').val('');

        $('#txtVenCode').focus();
    }
    function DeleteData() {
        var code = $('#txtVenCode').val();
        var ask = confirm("Do you need to Delete " + code + "?");
        if (ask == false) return;

        $.get(path + 'master/delvender?code=' + code, function (r) {
            alert(r.vender.result);
            ClearData();
        });
    }
    function SaveData() {
        if (row.VenCode != undefined) {
            var obj = GetDataSave();
            if (obj.VenCode == '') {
                alert('Please enter vender code');
                return;
            }
            if (obj.TName == '') {
                alert('Please enter vender name');
                return;
            }
            var ask = confirm("Do you need to " + (row.VenCode == "" ? "Add" : "Save") + " this data?");
            if (ask == false) return;
            var jsonText = JSON.stringify({ data: obj });
            //alert(jsonText);
            $.ajax({
                url: "@Url.Action("SetVender", "Master")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.data!=null) {
                        $('#txtVenCode').val(response.result.data);
                        $('#txtVenCode').focus();
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
    function ReadVender(dr) {
        if (dr.VenCode != undefined) {
            row = dr;
            $('#txtVenCode').val(dr.VenCode);
            $('#txtBranchCode').val(dr.BranchCode);
            $('#txtTaxNumber').val(dr.TaxNumber);
            $('#txtTitle').val(dr.Title);
            $('#txtTName').val(dr.TName);
            $('#txtEnglish').val(dr.English);
            $('#txtTAddress1').val(dr.TAddress1);
            $('#txtTAddress2').val(dr.TAddress2);
            $('#txtEAddress1').val(dr.EAddress1);
            $('#txtEAddress2').val(dr.EAddress2);
            $('#txtPhone').val(dr.Phone);
            $('#txtFaxNumber').val(dr.FaxNumber);
            $('#txtLoginName').val(dr.LoginName);
            $('#txtLoginPassword').val(dr.LoginPassword);
            $('#txtGLAccountCode').val(dr.GLAccountCode);
            $('#txtContactAcc').val(dr.ContactAcc);
            $('#txtContactSale').val(dr.ContactSale);
            $('#txtContactSupport1').val(dr.ContactSupport1);
            $('#txtContactSupport2').val(dr.ContactSupport2);
            $('#txtContactSupport3').val(dr.ContactSupport3);
            $('#txtWEB_SITE').val(dr.WEB_SITE);

            $('#btnSave').removeAttr('disabled');
            if (dr.VenCode != "") {
                $('#btnDel').removeAttr('disabled');
            } else {
                $('#btnDel').attr('disabled', 'disabled');
            }
        } else {
            alert('Data Not Found');
            ClearData();
        }
        //$('#txtVenCode').focus();
    }
    function SearchData(type) {
        switch (type) {
            case 'vender':
                SetGridVender(path, '#tbVend', '#frmSearchVend', ReadVender);
                break;
        }
    }
    function SetEvents() {
        $('#txtVenCode').keydown(function (event) {
            if (event.which == 13) {
                var code = $('#txtVenCode').val();
                ClearData();
                $('#txtVenCode').val(code);
                CallBackQueryVender(path, code, ReadVender);
            }
        });
    }
    function SetLOVs() {
        //3 Fields Show
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            var dv = document.getElementById("dvLOVs");
            CreateLOV(dv, '#frmSearchVend', '#tbVend', 'Venders', response, 2);
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
                    $('[tabindex="0"]').focus();
                }
            });
        });
    }
</script>