@Code
    ViewBag.Title = "International Port"
End Code
<div class="panel-body">
    <div class="container">
        <div id="dvForm">
            <div class="row">
                <div class="col-sm-3">
                    Country :
                    <br />
                    <div style="display:flex">
                        <div style="flex:1">
                            <input type="text" id="txtCountryCode" class="form-control" tabIndex="1">
                        </div>
                        <div>
                            <input type="button" value="..." class="btn btn-default" onclick="SearchData('country')" />
                        </div>
                    </div>
                </div>
                <div class="col-sm-3">
                    Port Code :
                    <br />
                    <div style="display:flex">
                        <div style="flex:1">
                            <input type="text" id="txtPortCode" class="form-control" tabIndex="2">
                        </div>
                        <div>
                            <input type="button" value="..." class="btn btn-default" onclick="SearchData('code')" />
                        </div>
                    </div>
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
            <a href="#" class="btn btn-default w3-purple" id="btnAdd" onclick="ClearData()">
                <i class="fa fa-lg fa-file-o"></i>&nbsp;<b>New</b>
            </a>
            <a href="#" class="btn btn-success" id="btnSave" onclick="SaveData()">
                <i class="fa fa-lg fa-save"></i>&nbsp;<b>Save</b>
            </a>
            <a href="#" class="btn btn-danger" id="btnDelete" onclick="DeleteData()">
                <i class="fa fa-lg fa-trash"></i>&nbsp;<b>Delete</b>
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
        ShowConfirm("Do you need to Delete " + code + " of " + key + "?", function (ask) {
            if (ask == false) return;
            $.get(path + 'master/delinterport?code=' + code + '&key='+key, function (r) {
                ShowMessage(r.interport.result);
                ClearData();
            });
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
                ShowMessage('Please enter country code');
                return;
            }
            if (obj.PortName === "") {
                ShowMessage('Please enter port name');
                return;
            }
            ShowConfirm("Do you need to Save " + obj.PortCode + "?", function (ask) {
                if (ask == false) return;
                var jsonText = JSON.stringify({ data: obj });
                //ShowMessage(jsonText);
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
