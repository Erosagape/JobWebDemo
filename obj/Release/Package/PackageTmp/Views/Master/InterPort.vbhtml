@Code
    ViewBag.Title = "International Port"
End Code
<div class="panel-body">
    <div class="container">
        <div id="dvForm">
            <div class="row">
                <div class="col-sm-3">
                    <a href="#" onclick="SearchData('country')">Country :</a>
                    <br /><input type="text" id="txtCountryCode" class="form-control" tabIndex="1">
                </div>
                <div class="col-sm-3">
                    <a href="#" onclick="SearchData('code')">Port Code :</a>
                    <br /><input type="text" id="txtPortCode" class="form-control" tabIndex="2">
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6">
                    Name :<br /><input type="text" id="txtPortName" class="form-control" tabIndex="3">
                </div>
                <div class="col-sm-3">
                    Start Date :<br /><input type="date" id="txtStartDate" class="form-control" tabIndex="4">
                </div>
                <div class="col-sm-3">
                    Expire Date :<br /><input type="date" id="txtFinishDate" class="form-control" tabIndex="5">
                </div>
            </div>
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
        $('#txtPortCode').keydown(function (event) {
            if (event.which == 13) {
                var code = $('#txtPortCode').val();
                var key = $('#txtCountryCode').val();
                ClearData();
                $('#txtPortCode').val(code);
                CallBackQueryInterPort(path,code,key,ReadData);
            }
        });
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=code,key,name', function (response) {
            var dv = document.getElementById("dvLOVs");
            CreateLOV(dv, '#frmSearchCode', '#tbCode', 'Inter Port', response, 3);
            CreateLOV(dv, '#frmSearchCountry', '#tbCountry', 'Country', response, 2);
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
    function DeleteData() {
        var code = $('#txtPortCode').val();
        var key = $('#txtCountryCode').val();
        var ask = confirm("Do you need to Delete " + code + " of "+key+"?");
        if (ask == false) return;
            $.get(path + 'master/delinterport?code=' + code + '&key='+key, function (r) {
                alert(r.interport.result);
                ClearData();
        });
    }
    function ReadData(dr) {
        $('#txtPortCode').val(dr.PortCode);
        $('#txtPortName').val(dr.PortName);
        $('#txtCountryCode').val(dr.CountryCode);
        $('#txtStartDate').val(CDateEN(dr.StartDate));
        $('#txtFinishDate').val(CDateEN(dr.FinishDate));
    }
    function ReadCountry(dr) {
        $('#txtCountryCode').val(dr.CTYCODE);
    }
    function SaveData(){
        var obj={
            PortCode: $('#txtPortCode').val(),
            PortName:$('#txtPortName').val(),
            CountryCode:$('#txtCountryCode').val(),
            StartDate:CDateTH($('#txtStartDate').val()),
            FinishDate:CDateTH($('#txtFinishDate').val()),
        };
        if (obj.PortCode !== "") {
            if (obj.CountryCode === "") {
                alert('Please enter country code');
                return;
            }
            if (obj.PortName === "") {
                alert('Please enter port name');
                return;
            }
            var ask = confirm("Do you need to Save " + obj.PortCode + "?");
            if (ask == false) return;
            var jsonText = JSON.stringify({ data: obj });
            //alert(jsonText);
            $.ajax({
                url: "@Url.Action("SetInterPort", "Master")",
                type: "POST",
                contentType: "application/json",
                data: jsonText,
                success: function (response) {
                    if (response.result.data != null) {
                        $('#txtPortCode').val(response.result.data);
                        $('#txtPortCode').focus();
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
        $('#txtPortCode').val('');
        $('#txtPortName').val('');
        //$('#txtCountryCode').val(''); don't clear for select country first
        $('#txtStartDate').val('');
        $('#txtFinishDate').val('');

        $('#txtPortCode').focus();
    }
    function SearchData(type) {
        switch (type) {
            case 'code':
                SetGridInterPort(path, '#tbCode', '#frmSearchCode', $('#txtCountryCode').val(), ReadData);
                break;
            case 'country':
                SetGridCountry(path, '#tbCountry', '#frmSearchCountry', ReadCountry);
                break;
        }
    }

</script>
