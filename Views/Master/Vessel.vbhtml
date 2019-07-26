@Code
    ViewBag.Title = "Vessel/Vehicles"
End Code
<div class="panel-body">
    <div class="container">
        <div id="dvForm">
            <a href="#" onclick="SearchData('vessel')">Code:</a><br /><input type="text" id="txtRegsNumber" class="form-control" tabIndex="1">
            Name:<br /><input type="text" id="txtTName" class="form-control" tabIndex="2">
            Type:<br /><input type="text" id="txtVesselType" class="form-control" tabIndex="3">
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
        $('#txtRegsNumber').keydown(function (event) {
            if (event.which == 13) {
                var code = $('#txtRegsNumber').val();
                ClearData();
                $('#txtRegsNumber').val(code);
                CallBackQueryVessel(path, code, ReadData);
            }
        });
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            var dv = document.getElementById("dvLOVs");
            CreateLOV(dv, '#frmSearchCode', '#tbCode', 'Vessel', response, 2);
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
        $('#txtRegsNumber').val(dr.RegsNumber);
        $('#txtTName').val(dr.TName);
        $('#txtVesselType').val(dr.VesselType);
    }
    function DeleteData() {
        var code = $('#txtTName').val();
        var ask = confirm("Do you need to Delete " + code + "?");
        if (ask == false) return;

        $.get(path + 'master/delvessel?code=' + code, function (r) {
            alert(r.vessel.result);
            ClearData();
        });
    }
    function SaveData() {
        var obj = {
            RegsNumber: $('#txtRegsNumber').val(),
            TName: $('#txtTName').val(),
            VesselType: $('#txtVesselType').val()
        };
        if (obj.RegsNumber != "") {
            if (obj.TName == '') {
                alert('Please enter vessel name');
                $('#txtTName').focus();
                return;
            }
            var ask = confirm("Do you need to Save " + obj.TName + "?");
            if (ask == false) return;
            var jsonText = JSON.stringify({ data: obj });
            //alert(jsonText);
            $.ajax({
                url: "@Url.Action("SetVessel", "Master")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.data != null) {
                        $('#txtRegsNumber').val(response.result.data);
                        $('#txtRegsNumber').focus();
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
        $('#txtRegsNumber').val('');
        $('#txtTName').val('');
        $('#txtVesselType').val('0');

        $('#txtRegsNumber').focus();
    }
    function SearchData(type) {
        switch (type) {
            case 'vessel':
                SetGridVessel(path, '#tbCode', '#frmSearchCode', '', ReadData);
                break;
        }
    }
</script>
