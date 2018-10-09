@Code
    ViewBag.Title = "ค่าคงที่ต่างๆ (System Variable)"
End Code
<div class="panel-body">
    <div id="divInputs">
        <button id="btnNew" class="btn btn-default" onclick="ClearData()">New</button>
        <table id="frmConfig">
            <tr>
                <td>
                    Config Code :
                </td>
                <td>
                    <input type="text" class="form-control" id="txtCode" />
                </td>
                <td>
                    <input type="button" id="btnBrowse" value="..." onclick="SearchData()" />
                </td>
            </tr>
            <tr>
                <td>
                    Config Key :
                </td>
                <td>
                    <input type="text" class="form-control" id="txtKey" />
                </td>
                <td></td>
            </tr>
            <tr>
                <td>
                    Config Value :
                </td>
                <td>
                    <textarea class="form-control" id="txtValue"></textarea>
                </td>
                <td></td>
            </tr>
        </table>
        <button id="btnSave" class="btn btn-success" onclick="SaveData()">Save</button>
    </div>
    <div id="frmSearch" class="modal fade" role="dialog"></div>
    <hr />
    <div id="divGrid">
        <table id="tblData" class="table table-responsive">
            <thead>
                <tr>
                    <th>Code</th>
                    <th>Key</th>
                    <th>Value</th>
                </tr>
            </thead>
            <tbody />
        </table>
    </div>
    <div id="dvMsg"></div>
</div>
<script type="text/javascript">
    //define variables
    var path = '@Url.Content("~")';
    $(document).ready(function () {
        SetLOV();
        SetEvents();
        ShowData("", "");
        $("#txtCode").focus();
    });
    function SetLOV() {
        //single field show in grid
        $.get(path + 'Config/ListValue?ID=tbX&Head=cpX&FLD=name', function (response) {
            //Unit
            var ListConfig = response.replace('tbX', 'tbLOV').replace('cpX', 'Setting');
            BindList('#frmSearch', '#tbLOV', ListConfig);
        });
    }
    function SetEvents() {
        //listening events
        $("#txtCode").keydown(function (event) {
            if (event.which == 13) {
                ShowData($('#txtCode').val(), "");
                $("#txtKey").focus();
            }
        });
        $("#txtKey").keydown(function (event) {
            if (event.which == 13) {
                GetData();
                $("#txtValue").focus();
            }
        });
    }
    function SearchData() {
        //popup for search data
        SetGridConfigList(path, '#tbLOV', '#frmSearch', LoadData);
    }
    function ClearData() {
        //clear input form and set default values
        $('#txtCode').val('');
        $('#txtKey').val('');
        $('#txtValue').val('');
        $("#txtCode").focus();
    }
    function GetData() {
        //get data from input cliteria
        $.get(path + 'Config/getConfig' + GetParam($('#txtCode').val(), $('#txtKey').val()))
            .done(function (response) {
                if (response.config.data.length == 0) {
                    $('#txtValue').val('');
                    return;
                }
                $('#txtValue').val(response.config.data[0].ConfigValue);
            });
    }
    function GetInput() {
        //read input data and generated class for post
        var obj = {
            ConfigCode: $('#txtCode').val(),
            ConfigKey: $('#txtKey').val(),
            ConfigValue: $('#txtValue').val()
        };
        return obj;
    }
    function SaveData() {
        //post data input to web API
        var obj = GetInput();
        $.ajax({
            url: "@Url.Action("SetConfig", "Config")",
            type: "POST",
            contentType: "application/json",
            data: JSON.stringify({ data: obj }),
            success: function (response) {
                response ? alert("Save Completed!") : alert("Cannot Save data");
                ShowData($('#txtCode').val(), "");
                $("#txtCode").focus();
            }
        });
    }
    function GetParam(Code, Key) {
        //create query string from user input
        var strParam = "";
        if (Code != "") {
            strParam += "Code=" + Code;
        }
        if (Key != "") {
            if (strParam != "") strParam += "&";
            strParam += "Key=" + Key;
        }
        if (strParam != "") strParam = "?" + strParam;
        return strParam;
    }   
    function LoadData(dt) {
        ShowData(dt.ConfigCode, "");
        $('#txtKey').val('');
        $('#txtValue').val('');
        $("#txtCode").focus();
    }
    function ShowData(Code, Key) {
    //function for show grid data
        $('#txtCode').val(Code);
        var table = $('#tblData').DataTable({
            ajax: {
                url: path + "Config/getConfig" + GetParam(Code, Key),
                dataSrc: "config.data"
            },
            destroy: true,
            columns: [
                { data: "ConfigCode" },
                { data: "ConfigKey" },
                { data: "ConfigValue" },
            ]
        });
        //on click load current row select to form
        $('#tblData tbody').on('click', 'tr', function () {
            $('#tblData tbody > tr').removeClass('selected');
            $(this).addClass('selected');

            var data = $('#tblData').DataTable().row(this).data();
            $('#txtCode').val(data.ConfigCode);
            $('#txtKey').val(data.ConfigKey);
            $('#txtValue').val(data.ConfigValue);

            $("#txtCode").focus();
        });
    }
</script>
